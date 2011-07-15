/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "SourceGenerator.java".  Description:
/// "Manages automatic generation of HL7 API source code for all data types,
/// segments, groups, and message structures"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
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
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
namespace Genetibase.NuGenHL7.sourcegen
{
	
	/// <summary> <p>Manages automatic generation of HL7 API source code for all data types,
	/// segments, groups, and message structures. </p>
	/// <p>Note: should put a nice UI on this</p>
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public class NuGenSourceGenerator:System.Object
	{
		
		/// <summary>Creates new SourceGenerator </summary>
		public NuGenSourceGenerator()
		{
		}
		
		/// <summary> Generates source code for all data types, segments, groups, and messages.</summary>
		/// <param name="baseDirectory">the directory where source should be written
		/// </param>
		public static void  makeAll(System.String baseDirectory, System.String version)
		{
			//load driver and set DB URL
			/*if (System.getProperty("ca.on.uhn.hl7.database.url") == null) {
			System.setProperty("ca.on.uhn.hl7.database.url", "jdbc:odbc:hl7");
			}*/
			
			try
			{
				System.Type.GetType("sun.jdbc.odbc.JdbcOdbcDriver");
				NuGenDataTypeGenerator.makeAll(baseDirectory, version);
				NuGenSegmentGenerator.makeAll(baseDirectory, version);
				NuGenMessageGenerator.makeAll(baseDirectory, version);
				// group and message not implemented
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		
		/// <summary> Make a Java-ish accessor method name out of a field or component description
		/// by removing non-letters and adding "get".  One complication is that some description
		/// entries in the DB have their data types in brackets, and these should not be
		/// part of the method name.  On the other hand, sometimes critical distinguishing
		/// information is in brackets, so we can't omit everything in brackets.  The approach
		/// taken here is to eliminate bracketed text if a it looks like a data type.
		/// </summary>
		public static System.String makeAccessorName(System.String fieldDesc)
		{
			System.Text.StringBuilder aName = new System.Text.StringBuilder("get");
			char[] chars = fieldDesc.ToCharArray();
			bool lastCharWasNotLetter = true;
			int inBrackets = 0;
			System.Text.StringBuilder bracketContents = new System.Text.StringBuilder();
			for (int i = 0; i < chars.Length; i++)
			{
				if (chars[i] == '(')
					inBrackets++;
				if (chars[i] == ')')
					inBrackets--;
				
				if (System.Char.IsLetterOrDigit(chars[i]))
				{
					if (inBrackets > 0)
					{
						//buffer everthing in brackets
						bracketContents.Append(chars[i]);
					}
					else
					{
						//add capitalized bracketed text if appropriate 
						if (bracketContents.Length > 0)
						{
							aName.Append(capitalize(filterBracketedText(bracketContents.ToString())));
							bracketContents = new System.Text.StringBuilder();
						}
						if (lastCharWasNotLetter)
						{
							//first letter of each word is upper-case
							aName.Append(System.Char.ToUpper(chars[i]));
						}
						else
						{
							aName.Append(chars[i]);
						}
						lastCharWasNotLetter = false;
					}
				}
				else
				{
					lastCharWasNotLetter = true;
				}
			}
			aName.Append(capitalize(filterBracketedText(bracketContents.ToString())));
			return aName.ToString();
		}
		
		/// <summary> Bracketed text in a field description should be included in the accessor 
		/// name unless it corresponds to a data type name. Given the text that appears in 
		/// brackets in a field description, this method returns an empty string if it 
		/// corresponds to a data type name, or returns original text if not.  It isn't 
		/// convenient to actually check (e.g. with DataTypeGenerator) whether the given 
		/// text actually corresponds to a data type name, so we are going to conclude that 
		/// it is a data type if and only if it is all caps and has 2 or 3 characters.  
		/// </summary>
		private static System.String filterBracketedText(System.String text)
		{
			System.String filtered = "";
			bool isDataType = true;
			if (!text.Equals(text.ToUpper()))
				isDataType = false;
			if (text.Length < 2 || text.Length > 3)
				isDataType = false;
			
			if (!isDataType)
				filtered = text;
			return filtered;
		}
		
		/// <summary>Capitalizes first character of the given text. </summary>
		private static System.String capitalize(System.String text)
		{
			System.Text.StringBuilder cap = new System.Text.StringBuilder();
			if (text.Length > 0)
			{
				cap.Append(System.Char.ToUpper(text[0]));
				cap.Append(text.Substring(1, (text.Length) - (1)));
			}
			return cap.ToString();
		}
		
		/// <summary> Creates the given directory if it does not exist.</summary>
		public static System.IO.FileInfo makeDirectory(System.String directory)
		{
			SupportClass.Tokenizer tok = new SupportClass.Tokenizer(directory, "\\/", false);
			
			System.IO.FileInfo currDir = null;
			while (tok.HasMoreTokens())
			{
				System.String thisDirName = tok.NextToken();
				
				currDir = new System.IO.FileInfo(currDir.FullName + "\\" + thisDirName); //if currDir null, defaults to 1 arg call
				
				bool tmpBool;
				if (System.IO.File.Exists(currDir.FullName))
					tmpBool = true;
				else
					tmpBool = System.IO.Directory.Exists(currDir.FullName);
				if (!tmpBool)
				{
					//create
					System.IO.Directory.CreateDirectory(currDir.FullName);
					;
				}
				else if (System.IO.File.Exists(currDir.FullName))
				{
					throw new System.IO.IOException("Can't create directory " + thisDirName + " - file with same name exists.");
				}
			}
			
			return currDir;
		}
		
		/// <summary> <p>Returns either the given data type name or an alternate data type that Composites
		/// and Segments should use in place of the given Type.  </p>
		/// <p>As currently implemented, substitutions
		/// may be desired if there is a validating subclass of the given Type.
		/// By convention such classes would be named ValidX (where X is the Type name).  This
		/// method checks the classpath for classes of this name in the datatype package and
		/// returns this name if one is found.</p>
		/// <p>Also converts "varies" to Varies which is an implementation of Type that contains
		/// a Type that can be set at run-time.</p>
		/// </summary>
		public static System.String getAlternateType(System.String dataTypeName, System.String version)
		{
			System.String ret = dataTypeName;
			
			//convert to varies to Varies
			if (ret.Equals("varies"))
				ret = "Varies";
			
			//Valid.. classes are removed as of HAPI 0.3 (validating code implemented directly in Primitive classes
			/*try {
			Class.forName(getVersionPackageName(version) + "datatype.Valid" + dataTypeName);
			ret = "Valid" + dataTypeName;
			} catch (Exception e) {
			// fine ... there isn't a ValidX implementation
			// I don't like using Class.forName here but I don't know a better way to
			// search for the class 
			}*/
			
			return ret;
		}
		
		/// <summary> Returns the path to the base package for model elements of the given version
		/// - e.g. "ca/uhn/hl7v2/model/v24/".
		/// This package should have the packages datatype, segment, group, and message
		/// under it. The path ends in with a slash.
		/// </summary>
		public static System.String getVersionPackagePath(System.String ver)
		{
			if (Parser.validVersion(ver) == false)
			{
				throw new NuGenHL7Exception("The HL7 version " + ver + " is not recognized", NuGenHL7Exception.UNSUPPORTED_VERSION_ID);
			}
			System.Text.StringBuilder path = new System.Text.StringBuilder("Genetibase/NuGenHL7/model/v");
			char[] versionChars = new char[ver.Length];
			SupportClass.GetCharsFromString(ver, 0, ver.Length, versionChars, 0);
			for (int i = 0; i < versionChars.Length; i++)
			{
				if (versionChars[i] != '.')
					path.Append(versionChars[i]);
			}
			path.Append('/');
			return path.ToString();
		}
		
		/// <summary> Returns the package name for model elements of the given version - e.g.
		/// "Genetibase.NuGenHL7.model.v24.".  This method
		/// is identical to <code>getVersionPackagePath(...)</code> except that path
		/// separators are replaced with dots.
		/// </summary>
		public static System.String getVersionPackageName(System.String ver)
		{
			System.String path = getVersionPackagePath(ver);
			System.String packg = path.Replace('/', '.');
			packg = packg.Replace('\\', '.');
			return packg;
		}
	}
}