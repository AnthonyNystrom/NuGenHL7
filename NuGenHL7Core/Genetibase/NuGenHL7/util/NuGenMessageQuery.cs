/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "MessageQuery.java".  Description:
/// "Queries messages in an SQL-like style.  "
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2005.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Queries messages in an SQL-like style.  We get repeated row-like 
	/// structures by looping over repetitions of groups, segments, or fields. 
	/// 
	/// This is a very advanced class ... maybe too advanced even for you.  If you 
	/// find it confusing, please note that there are simpler ways to get data 
	/// from a message (like calling its getters or using Terser).   
	/// 
	/// LOOPING:    
	/// You specify the loop points as part of the query.  For example you could 
	/// specify loop point x like this: <code>x = /.MSH-18(*)</code>.  The * 
	/// is replaced by numbers 0, 1, 2, etc. as you loop through the results, 
	/// so this example would loop through repetitions of MSH-18.  If 
	/// there are multiple loop points, the loops are nested so that each possible 
	/// combination is returned.  Looping stops when none of the fields under a 
	/// loop point are valued.  The name of the loop point ('x' in the example 
	/// above) is arbitrary.        
	/// 
	/// SELECTING FIELDS: 
	/// The syntax is similar to SQL, except that Terser paths are used in place
	/// of table.field.  You can use the "as" keyword to give a field a name, like 
	/// this: <code>select /.MSH-7 as msg_date</code>.  If your field is under 
	/// a loop point, replace the path up to the loop point with a loop point 
	/// reference, like this: <code>select {foo}-1 loop foo = /.PID-3(*)</code>
	/// 
	/// SELECTING ROWS:
	/// A "row" is a combination of all selected fields at one iteration.  You 
	/// can filter which rows are returned using a where clause similar to that
	/// in SQL.  Use exact values or regular expressions, for example: 
	/// <code>where {1} like '.*blood.*'</code> or <code>where {1}/PID-3-1 = '111'</code>
	/// Multiple filters can be separated with commas (which mean 'and').  Future
	/// versions may support 'or', negation, brackets, etc., but this version doesn't.  
	/// 
	/// FULL EXAMPLE: 
	/// select {pat-id}-1 as id loop pat-id = ./PID-3(*) where {pat-id}-2 = 'mrn'
	/// 
	/// SUBTLETIES OF LOOPING: 
	/// A loop point can be under another loop point.  For example consider the message:   
	/// 
	/// MSH|etc.|etc.
	/// Z01|one~two|a
	/// Z01|three~four|b
	/// 
	/// The query, "select {a}-2, {b} loop a = /Z01(*), b = {a}-1(*)" would return: 
	/// a one
	/// a two 
	/// b three
	/// b four
	/// 
	/// While the query "select {a}-2, {b} loop a = /Z01(*), b = /Z01(1)-1(*)" would return:
	/// a one
	/// a two 
	/// b one
	/// b two
	/// 
	/// In the first case, one loop point refers to another.  In the second case the loops 
	/// are treated as independent, just as if they referred to different branches of the 
	/// message.  
	/// 
	/// TODO: could support distinct easily by keeping record of rows and comparing each 
	/// one to previous rows 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2005/02/22 16:06:36 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenMessageQuery
	{
		
		/// <param name="theMessage">an HL7 message from which data are to be queried 
		/// </param>
		/// <param name="theQuery">the query (see class docs for syntax)
		/// </param>
		/// <returns> data from the message that are selected by the query 
		/// </returns>
		public static NuGenMessageQuery.Result query(Message theMessage, System.String theQuery)
		{
			System.Collections.Specialized.NameValueCollection clauses = getClauses(theQuery);
			
			//parse select clause
			SupportClass.Tokenizer select = new SupportClass.Tokenizer(clauses.Get("select"), ", ", false);
			System.Collections.ArrayList fieldPaths = new System.Collections.ArrayList(10);
			System.Collections.Hashtable names = new System.Collections.Hashtable(10);
			while (select.HasMoreTokens())
			{
				System.String token = select.NextToken();
				if (token.Equals("as"))
				{
					if (!select.HasMoreTokens())
					{
						throw new System.ArgumentException("Keyword 'as' must be followed by a field label");
					}
					names[select.NextToken()] = (System.Int32) (fieldPaths.Count - 1);
				}
				else
				{
					fieldPaths.Add(token);
				}
			}
			
			//parse loop clause 
			SupportClass.Tokenizer loop = new SupportClass.Tokenizer(clauses["loop"] == null?"":clauses["loop"], ",", false);
			System.Collections.ArrayList loopPoints = new System.Collections.ArrayList(10);
			System.Collections.Hashtable loopPointNames = new System.Collections.Hashtable(10);
			while (loop.HasMoreTokens())
			{
				System.String pointDecl = loop.NextToken();
				SupportClass.Tokenizer tok = new SupportClass.Tokenizer(pointDecl, "=", false);
				System.String name = tok.NextToken().Trim();
				System.String path = tok.NextToken().Trim();
				loopPoints.Add(path);
				loopPointNames[name] = (System.Int32) (loopPoints.Count - 1);
			}
			
			//parse where clause 
			//TODO: this will do for now but it should really be evaluated like an expression 
			//rather than a list  
			SupportClass.Tokenizer where = new SupportClass.Tokenizer(clauses["where"] == null?"":clauses["where"], ",", false);
			System.Collections.ArrayList filters = new System.Collections.ArrayList();
			while (where.HasMoreTokens())
			{
				filters.Add(where.NextToken());
			}
			System.String[] filterPaths = new System.String[filters.Count];
			System.String[] filterPatterns = new System.String[filters.Count];
			bool[] exactFlags = new bool[filters.Count];
			
			for (int i = 0; i < filters.Count; i++)
			{
				exactFlags[i] = true;
				System.String filter = (System.String) filters[i];
				System.String[] parts = splitFromEnd(filter, "=");
				if (parts[1] != null)
				{
					parts[1] = parts[1].Substring(1);
				}
				else
				{
					exactFlags[i] = false;
					parts = splitFromEnd(filter, "like");
					parts[1] = parts[1].Substring(4);
				}
				filterPaths[i] = parts[0].Trim();
				parts[1] = parts[1].Trim();
				filterPatterns[i] = parts[1].Substring(1, (parts[1].Length - 1) - (1));
			}

            String[] retVal1 = new String[loopPoints.Count];
            loopPoints.CopyTo(retVal1);

            String[] retVal2 = new String[fieldPaths.Count];
            fieldPaths.CopyTo(retVal2);

			return new ResultImpl(theMessage, retVal1, loopPointNames, retVal2, names, filterPaths, filterPatterns, exactFlags);
		}
		
		
		private static System.Collections.Specialized.NameValueCollection getClauses(System.String theQuery)
		{
			System.Collections.Specialized.NameValueCollection clauses = new System.Collections.Specialized.NameValueCollection();
			
			System.String[] split = splitFromEnd(theQuery, "where ");
			setClause(clauses, "where", split[1]);
			
			split = splitFromEnd(split[0], "loop ");
			setClause(clauses, "loop", split[1]);
			setClause(clauses, "select", split[0]);
			
			if ((clauses["where"] == null?"":clauses["where"]).IndexOf("loop ") >= 0)
			{
				throw new System.ArgumentException("The loop clause must precede the where clause");
			}
			if (clauses.Get("select") == null)
			{
				throw new System.ArgumentException("The query must begin with a select clause");
			}
			return clauses;
		}
		
		private static void  setClause(System.Collections.Specialized.NameValueCollection theClauses, System.String theName, System.String theClause)
		{
			if (theClause != null)
			{
				theClauses[theName] = theClause.Substring(theName.Length).Trim();
			}
		}
		
		private static System.String[] splitFromEnd(System.String theString, System.String theMarker)
		{
			System.String[] result = new System.String[2];
			int begin = theString.IndexOf(theMarker);
			if (begin >= 0)
			{
				result[0] = theString.Substring(0, (begin) - (0));
				result[1] = theString.Substring(begin);
			}
			else
			{
				result[0] = theString;
			}
			return result;
		}
		
		/// <summary> A result set for a message query.    
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.3 $ updated on $Date: 2005/02/22 16:06:36 $ by $Author: bryan_tripp $
		/// </version>
		public interface Result
		{
			/// <returns> a list of named fields as defined with 'as' in the query
			/// </returns>
			System.String[] NamedFields
			{
				get;
				
			}
			
			/// <param name="theFieldNumber">numbered from zero in the order they are specified in the 
			/// query
			/// </param>
			/// <returns> the corresponding value in the current row 
			/// </returns>
			System.String get_Renamed(int theFieldNumber);
			
			/// <param name="theFieldName">a field name as specified in the query with the keyword "as" 
			/// </param>
			/// <returns> the corresponding value in the current row 
			/// </returns>
			System.String get_Renamed(System.String theFieldName);
			
			/// <summary> Advances to the next "row" of data if one is available. </summary>
			/// <returns> true if another row is available  
			/// </returns>
			/// <throws>  HL7Exception </throws>
			bool next();
		}
		
		private class ResultImpl : NuGenMessageQuery.Result
		{
			/// <seealso cref="Genetibase.NuGenHL7.util.MessageQuery.Result.getNamedFields()">
			/// </seealso>
			virtual public System.String[] NamedFields
			{
				get
				{
                    String[] fields = new String[myFieldNames.Count];
                    myFieldNames.CopyTo(fields, 0);

                    return fields;
				}
				
			}
			
			private NuGenTerser myTerser;
			private System.String[] myValues;
			private System.String[] myLoopPoints;
			private System.Collections.IDictionary myLoopPointNames;
			private System.String[] myFieldPaths;
			private System.Collections.IDictionary myFieldNames;
			private int[] myIndices;
			private int[] myNumEmpty; //number of empty sub-loops since last non-empty one
			private int[] myMaxNumEmpty;
			private bool myNonLoopingQuery = false;
			private System.String[] myWherePaths;
			private System.String[] myWhereValues;
			private System.String[] myWherePatterns;
			private bool[] myExactMatchFlags;
			
			public ResultImpl(Message theMessage, System.String[] theLoopPoints, System.Collections.IDictionary theLoopPointNames, System.String[] theFieldPaths, System.Collections.IDictionary theFieldNames, System.String[] theWherePaths, System.String[] theWherePatterns, bool[] theExactMatchFlags)
			{
				
				myTerser = new NuGenTerser(theMessage);
				myLoopPoints = theLoopPoints;
				myIndices = new int[theLoopPoints.Length];
				myNumEmpty = new int[theLoopPoints.Length];
				myMaxNumEmpty = getMaxNumEmpty(theLoopPoints);
				myLoopPointNames = theLoopPointNames;
				myFieldPaths = theFieldPaths;
				myValues = new System.String[theFieldPaths.Length];
				myFieldNames = theFieldNames;
				myWherePaths = theWherePaths;
				myWherePatterns = theWherePatterns;
				myExactMatchFlags = theExactMatchFlags;
				
				if (theLoopPoints.Length == 0)
				{
					myNonLoopingQuery = true; //if no loops, give ourselves 1 iteration
				}
				else
				{
					myIndices[myIndices.Length - 1] = - 1; //start before 1st iteration
				}
			}
			
			//extracts max number of empty iterations for each loop point (this is communicated 
			//as an optional integer after the *, e.g. blah(*3) ... default is 0).  
			private int[] getMaxNumEmpty(System.String[] theLoopPoints)
			{
				int[] retVal = new int[theLoopPoints.Length];
				for (int i = 0; i < theLoopPoints.Length; i++)
				{
					retVal[i] = getMaxNumEmpty(theLoopPoints[i]);
				}
				return retVal;
			}
			
			private int getMaxNumEmpty(System.String theLoopPoint)
			{
				int retVal = 0; //default

                Regex regex = new Regex("\\*(\\d+)");
                Match m = regex.Match(theLoopPoint);

				if (m.Success)
				{
					System.String num = m.Groups[1].Value;
					retVal = System.Int32.Parse(num);
				}
				
				return retVal;
			}
			
			//returns true if some field under the given loop point has a value at the present 
			//iteration
			private bool currentRowValued(int theLoopPoint)
			{
				for (int i = 0; i < myFieldPaths.Length; i++)
				{
					if (referencesLoop(myFieldPaths[i], theLoopPoint))
					{
						System.String value_Renamed = (System.String) myValues[i];
						if (value_Renamed != null && value_Renamed.Length > 0)
						{
							return true;
						}
					}
				}
				return false;
			}
			
			//returns true if the current row matches the where clause filters
			private bool currentRowMatchesFilter()
			{
				for (int i = 0; i < myWhereValues.Length; i++)
				{
					if (myExactMatchFlags[i])
					{
						if (!myWherePatterns[i].Equals(myWhereValues[i]))
						{
							return false;
						}
					}
					else
					{
						if (!Regex.IsMatch(myWhereValues[i], myWherePatterns[i]))
						{
							return false;
						}
					}
				}
				return true;
			}
			
			//true if the given path references the given loop point (directly 
			//or indirectly)
			private bool referencesLoop(System.String theFieldPath, int theLoopPoint)
			{
				System.String path = theFieldPath;
				int lp;
				while ((lp = getLoopPointReference(path)) >= 0)
				{
					if (lp == theLoopPoint)
					{
						return true;
					}
					else
					{
						path = myLoopPoints[lp];
					}
				}
				return false;
			}
			
			//expands a set of paths to their current loop point iterations, and gets 
			//current values from our message
			private System.String[] getCurrentValues(System.String[] thePaths)
			{
				System.String[] paths = composePaths(thePaths);
				System.String[] values = new System.String[paths.Length];
				for (int i = 0; i < paths.Length; i++)
				{
					values[i] = myTerser.get_Renamed(paths[i]);
					if (values[i] == null)
					{
						values[i] = "";
					}
				}
				return values;
			}
			
			//creates full Terser paths from current location, loop points, and given paths 
			//with loop point references 
			private System.String[] composePaths(System.String[] thePaths)
			{
				System.String[] currentLoopPoints = composeLoopPoints();
				System.String[] result = new System.String[thePaths.Length];
				for (int i = 0; i < thePaths.Length; i++)
				{
					result[i] = thePaths[i];
					int ref_Renamed = getLoopPointReference(thePaths[i]);
					if (ref_Renamed >= 0)
					{
						result[i] = expandLoopPointReference(result[i], currentLoopPoints[ref_Renamed]);
					}
				}
				return result;
			}
			
			//parameterizes loop points with present location (i.e. replaces * with current
			//indices)
			private System.String[] composeLoopPoints()
			{
				System.String[] result = new System.String[myLoopPoints.Length];
				for (int i = 0; i < myLoopPoints.Length; i++)
				{
                    result[i] = Regex.Replace(myLoopPoints[i], "\\*\\d*", myIndices[i].ToString());
					
					int ref_Renamed = getLoopPointReference(myLoopPoints[i]);
					if (ref_Renamed >= i)
					{
						throw new System.SystemException("Loop point must be defined after the " + "one it references: " + myLoopPoints[i]);
					}
					else if (ref_Renamed >= 0)
					{
						result[i] = expandLoopPointReference(result[i], result[ref_Renamed]);
					}
				}
				return result;
			}
			
			//extracts LP# of label between first '{' and first '}', or -1 if there isn't one
			private int getLoopPointReference(System.String thePath)
			{
				SupportClass.Tokenizer tok = new SupportClass.Tokenizer(thePath, "{}", false);
				if (thePath.IndexOf('{') >= 0 && tok.HasMoreTokens())
				{
					System.String ref_Renamed = tok.NextToken();
					return ((System.Int32) myLoopPointNames[ref_Renamed]);
				}
				else
				{
					return - 1;
				}
			}
			
			private System.String expandLoopPointReference(System.String thePath, System.String theLoopPoint)
			{
                return Regex.Replace(thePath, "\\{.*\\}", theLoopPoint);
			}
			
			/// <seealso cref="Genetibase.NuGenHL7.util.MessageQuery.Result.get(int)">
			/// </seealso>
			public virtual System.String get_Renamed(int theFieldNumber)
			{
				if (theFieldNumber < 0 || theFieldNumber >= myValues.Length)
				{
					throw new System.ArgumentException("Field number must be between 0 and " + (myValues.Length - 1));
				}
				return (System.String) myValues[theFieldNumber];
			}
			
			/// <seealso cref="Genetibase.NuGenHL7.util.MessageQuery.Result.get(java.lang.String)">
			/// </seealso>
			public virtual System.String get_Renamed(System.String theFieldName)
			{
				System.Int32 fieldNum = (System.Int32) myFieldNames[theFieldName];

                return get_Renamed(fieldNum);                
			}
			
			/// <throws>  HL7Exception </throws>
			/// <seealso cref="Genetibase.NuGenHL7.util.MessageQuery.Result.next()">
			/// </seealso>
			public virtual bool next()
			{
				if (myNonLoopingQuery)
				{
					myNonLoopingQuery = false;
					myValues = getCurrentValues(myFieldPaths);
					myWhereValues = getCurrentValues(myWherePaths);
					return currentRowMatchesFilter();
				}
				
				bool hasNext = false;
				for (int i = myIndices.Length - 1; i >= 0; i--)
				{
					bool gotMatch = false;
					while (!gotMatch && myNumEmpty[i] <= myMaxNumEmpty[i])
					{
						myIndices[i]++;
						myValues = getCurrentValues(myFieldPaths);
						myWhereValues = getCurrentValues(myWherePaths);
						
						if (!currentRowValued(i))
						{
							myNumEmpty[i]++;
						}
						else
						{
							myNumEmpty[i] = 0;
						}
						if (currentRowMatchesFilter())
						{
							gotMatch = true;
						}
					}
					
					hasNext = myNumEmpty[i] <= myMaxNumEmpty[i]; // && currentRowMatchesFilter();
					if (hasNext)
					{
						goto findNext_brk;
					}
					
					myIndices[i] = 0;
					myNumEmpty[i] = 0;
					
					//TODO: if we aren't allowing empties in this loop, and have no value, we want to 
					//return the null in the super-loop.  However, we don't know which loop point, if 
					//any, is the super-loop.  If it was the next one we could do this ... 
					//if (i > 0 && myMaxNumEmpty[i] == 0 && myMaxNumEmpty[i-1] > 0 && myIndices[i-1] == 0) {
					//    myIndices[i-1] = -1;
					//} ... but it may not be, so we'll ignore this problem for now.  
				}

findNext_brk: ;
				
				return hasNext;
			}
		}
	}
}