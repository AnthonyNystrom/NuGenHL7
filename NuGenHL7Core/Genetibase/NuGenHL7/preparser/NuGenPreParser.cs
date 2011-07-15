/*
* Created on 28-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using GenericParser = Genetibase.NuGenHL7.parser.NuGenGenericParser;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.preparser
{
	
	/// <summary> <p>Extracts specified fields from unparsed messages.  This class is a 
	/// facade for the ER7 and XML classes.  Use it like this: </p>
	/// 
	/// <code>
	/// String message = null; //... your ER7 or XML message string goes here
	/// String[] fieldSpecs = {"MSH-9-1", "MSH-9-2", "MSH-12"};
	/// String[] fields = PreParser.getFields(message, fieldSpecs);
	/// </code>
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2004/05/31 16:57:27 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenPreParser
	{
		
		private static GenericParser ourParser = new GenericParser();
		
		/// <summary> Extracts selected fields from a message.  
		/// 
		/// </summary>
		/// <param name="theMessageText">an unparsed message from which to get fields 
		/// </param>
		/// <param name="thePathSpecs">Terser-like paths to fields in the message.  See documentation
		/// for Terser.  These paths are identical except that they start with the segment
		/// name (search flags and group names are to be omitted as they are not relevant 
		/// with unparsed ER7 messages).  
		/// </param>
		/// <returns> field values corresponding to the given paths
		/// </returns>
		/// <throws>  HL7Exception </throws>
		public static System.String[] getFields(System.String theMessageText, System.String[] thePathSpecs)
		{
			NuGenDatumPath[] paths = new NuGenDatumPath[thePathSpecs.Length];
			for (int i = 0; i < thePathSpecs.Length; i++)
			{
				SupportClass.Tokenizer tok = new SupportClass.Tokenizer(thePathSpecs[i], "-", false);
				System.String segSpec = tok.NextToken();
				tok = new SupportClass.Tokenizer(segSpec, "()", false);
				System.String segName = tok.NextToken();
				if (segName.Length != 3)
				{
					throw new NuGenHL7Exception("In field path, " + segName + " is not a valid segment name");
				}
				int segRep = 0;
				if (tok.HasMoreTokens())
				{
					System.String rep = tok.NextToken();
					try
					{
						segRep = System.Int32.Parse(rep);
					}
					catch (System.FormatException e)
					{
						throw new NuGenHL7Exception("In field path, segment rep" + rep + " is not valid", e);
					}
				}
				
				int[] indices = Terser.getIndices(thePathSpecs[i]);
				paths[i] = new NuGenDatumPath();
				paths[i].add(segName).add(segRep);
				paths[i].add(indices[0]).add(indices[1]).add(indices[2]).add(indices[3]);
			}
			return getFields(theMessageText, paths);
		}
		
		/// <summary> Gets selected fields from a message, as with String[] arg version but 
		/// using DatumPaths. 
		/// </summary>
		private static System.String[] getFields(System.String theMessageText, NuGenDatumPath[] thePaths)
		{
			System.String[] fields = new System.String[thePaths.Length];
			System.String encoding = ourParser.getEncoding(theMessageText);
			System.Collections.Specialized.NameValueCollection props = new System.Collections.Specialized.NameValueCollection();
			
			System.Collections.ArrayList mask = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			for (int i = 0; i < thePaths.Length; i++)
			{
				mask.Add(thePaths[i]);
			}
			
			if (encoding == null)
			{
				throw new NuGenHL7Exception("Message encoding is not recognized");
			}
			
			bool OK = false;
			if (encoding.Equals("VB"))
			{
				OK = NuGenER7.parseMessage(props, mask, theMessageText);
			}
			else if (encoding.Equals("XML"))
			{
				OK = NuGenXML.parseMessage(props, theMessageText, null);
			}
			
			if (!OK)
			{
				throw new NuGenHL7Exception("Parse failed");
			}
			
			for (int i = 0; i < fields.Length; i++)
			{
				fields[i] = props.Get(thePaths[i].ToString());
			}
			return fields;
		}
	}
}