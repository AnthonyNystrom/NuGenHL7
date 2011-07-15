/*
* Created on 21-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A debugging utility that logs raw messages and parsed/encoded versions, and warnings about 
	/// apparent discrepancies between them.  This information is all logged to HapiLog under 
	/// the name of this class, at the "info" level.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/28 22:50:57 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenParseChecker
	{
		
		/// <summary> Encodes the given message and compares it to the given string.  Any differences
		/// are noted in the file [hapi.home]/parse_check.txt.  Ignores extra field delimiters.
		/// </summary>
		public static void  checkParse(System.String originalMessageText, Message parsedMessage, Parser parser)
		{
			System.String newMessageText = parser.encode(parsedMessage);
			
			
			if (!originalMessageText.Equals(newMessageText))
			{
				//check each segment
				SupportClass.Tokenizer tok = new SupportClass.Tokenizer(originalMessageText, "\r");
				System.Collections.ArrayList one = new System.Collections.ArrayList();
				while (tok.HasMoreTokens())
				{
					System.String seg = tok.NextToken();
					if (seg.Length > 4)
						one.Add(seg);
				}
				tok = new SupportClass.Tokenizer(newMessageText, "\r");
				System.Collections.ArrayList two = new System.Collections.ArrayList();
				while (tok.HasMoreTokens())
				{
					System.String seg = tok.NextToken();
					if (seg.Length > 4)
						two.Add(stripExtraDelimiters(seg, seg[3]));
				}
				
				if (one.Count != two.Count)
				{
				}
				else
				{
					//check each segment
					for (int i = 0; i < one.Count; i++)
					{
						System.String origSeg = (System.String) one[i];
						System.String newSeg = (System.String) two[i];
						if (!origSeg.Equals(newSeg))
						{
						}
					}
				}
			}
			else
			{
			}
			
		}
		
		/// <summary> Removes unecessary delimiters from the end of a field or segment.
		/// This is cut-and-pasted from PipeParser (just making it public in
		/// PipeParser would kind of cloud the purpose of PipeParser).
		/// </summary>
		private static System.String stripExtraDelimiters(System.String in_Renamed, char delim)
		{
			char[] chars = in_Renamed.ToCharArray();
			
			//search from back end for first occurance of non-delimiter ...
			int c = chars.Length - 1;
			bool found = false;
			while (c >= 0 && !found)
			{
				if (chars[c--] != delim)
					found = true;
			}
			
			System.String ret = "";
			if (found)
				ret = new System.String(chars, 0, c + 2);
			return ret;
		}
		static NuGenParseChecker()
		{
		}
	}
}