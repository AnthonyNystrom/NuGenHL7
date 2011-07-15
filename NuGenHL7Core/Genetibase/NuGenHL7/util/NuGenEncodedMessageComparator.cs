using System;
using Genetibase.NuGenHL7.parser;
using Message = Genetibase.NuGenHL7.model.Message;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Tools for testing message strings for semantic equivalence without assuming the correctness
	/// of parsers.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenEncodedMessageComparator
	{
		
		private static NuGenGenericParser parser = new NuGenGenericParser();
		
		/// <summary> Returns a "standardized" equivalent of the given message string.  For delimited
		/// messages, the returned value is the shortest string that has an equivalent
		/// meaning in HL7.  For XML-encoded messages, the returned value is equivalent XML output
		/// using a standard pretty-print format.  An automatic determination is made about whether 
		/// the given string is XML or ER7 (i.e. traditionally) encoded.
		/// </summary>
		/// <param name="message">an XML-encoded or ER7-encoded message string
		/// </param>
		public static System.String standardize(System.String message)
		{
			System.String result = null;
			System.String encoding = parser.getEncoding(message);
			if (encoding.Equals("XML"))
			{
				result = standardizeXML(message);
			}
			else
			{
				result = standardizeER7(message);
			}
			return result;
		}
		
		/// <summary> Returns the shortest string that is semantically equivalent to a given ER7-encoded 
		/// message string.
		/// </summary>
		public static System.String standardizeER7(System.String message)
		{
			
			//make delimiter sequences (must quote with \ if not alphanumeric; can't otherwise because of regexp rules)
			char fieldDelimChar = message[3];
			System.String fieldDelim = System.Convert.ToString(fieldDelimChar);
			if (!System.Char.IsLetterOrDigit(fieldDelimChar))
				fieldDelim = "\\" + fieldDelimChar;
			
			char compSepChar = message[4];
			System.String compSep = System.Convert.ToString(compSepChar);
			if (!System.Char.IsLetterOrDigit(compSepChar))
				compSep = "\\" + compSepChar;
			
			char repSepChar = message[5];
			System.String repSep = System.Convert.ToString(repSepChar);
			if (!System.Char.IsLetterOrDigit(repSepChar))
				repSep = "\\" + repSepChar;
			
			char subSepChar = message[7];
			System.String subSep = System.Convert.ToString(subSepChar);
			if (!System.Char.IsLetterOrDigit(subSepChar))
				subSep = "\\" + subSepChar;
			
			//char space = ' ';
			
			/* Things to strip (cumulative):
			*  - all delimiters and repetition separators before end line (i.e. end segment)
			*  - repetition separators, comp and subcomp delims before new field
			*  - subcomponent delimiters before new component
			*/
            message = Regex.Replace(message, "[" + fieldDelim + compSep + repSep + subSep + "]*[\n\r]+", "\r");
            message = Regex.Replace(message, "[" + repSep + compSep + subSep + "]*" + fieldDelim, fieldDelim);
            message = Regex.Replace(message, "[" + subSep + "]*" + compSep, compSep);
			
			//Pattern endSub = Pattern.compile("[ ]*" + subSep);
			//message = endSub.matcher(message).replaceAll(String.valueOf(subSep));
			
			//handle special case of subcomp delim in encoding characters
			message = message.Substring(0, (7) - (0)) + subSepChar + message.Substring(7);
			
			return message;
		}
		
		/// <summary> Returns a semantic equivalent of a given XML-encoded message in a default format.
		/// Attributes, comments, and processing instructions are not considered to change the 
		/// HL7 meaning of the message, and are removed in the standardized representation.    
		/// </summary>
		public static System.String standardizeXML(System.String message)
		{			
			System.Xml.XmlDocument doc = null;
			System.IO.StringWriter out_Renamed = new System.IO.StringWriter();
			try
			{
				lock (parser)
				{
                    XmlTextReader reader = new XmlTextReader(new System.IO.MemoryStream(new System.Text.ASCIIEncoding().GetBytes(message)));
                    System.Data.DataSet data = new System.Data.DataSet();
                    data.ReadXml(reader);
                    doc = new XmlDataDocument(data);
				}
				clean((System.Xml.XmlElement) doc.DocumentElement);
			}
			catch (System.IO.IOException e)
			{
				throw new System.SystemException("IOException doing IO to a string!!! " + e.Message);
			}
			return out_Renamed.ToString();
		}
		
		/// <summary>Removes attributes, comments, and processing instructions. </summary>
		private static void  clean(System.Xml.XmlElement elem)
		{
			System.Xml.XmlNodeList children = elem.ChildNodes;
			for (int i = 0; i < children.Count; i++)
			{
				System.Xml.XmlNode child = children.Item(i);
				if (System.Convert.ToInt16(child.NodeType) == (short) System.Xml.XmlNodeType.ProcessingInstruction || System.Convert.ToInt16(child.NodeType) == (short) System.Xml.XmlNodeType.Comment)
				{
					elem.RemoveChild(child);
				}
				else if (System.Convert.ToInt16(child.NodeType) == (short) System.Xml.XmlNodeType.Element)
				{
					clean((System.Xml.XmlElement) child);
				}
			}
			
			System.Xml.XmlNamedNodeMap attributes = (System.Xml.XmlAttributeCollection) elem.Attributes;
			//get names
			System.String[] names = new System.String[attributes.Count];
			for (int i = 0; i < names.Length; i++)
			{
				names[i] = attributes.Item(i).Name;
			}
			//remove by name
			for (int i = 0; i < names.Length; i++)
			{
				attributes.RemoveNamedItem(names[i]);
			}
		}
		
		/// <summary> <p>Compares two HL7 messages to see if they are equivalent (in terms of their  
		/// HL7 meaning).  Semantically irrelevant differences (e.g. spaces in an XML tag; 
		/// extra field delimiters at the end of a segment; XML vs. ER7 encoding; XML attributes)
		/// are ignored. This check is performed without assuming the correctness of the HAPI parsers, 
		/// and can therefore be used to test them.  This is done by parsing a message, encoding it
		/// again, and comparing the result with this original.  </p>
		/// <p>If one message is in XML and the other in ER7, the former is converted to ER7 to 
		/// perform the comparison.  This process relies on the HAPI parsers.  However, the 
		/// parsed message is first encoded as XML and compared to the original, so that the 
		/// integrity of the parser can be verified.  An exception is thrown if this comparison 
		/// is unsuccessful.  </p>
		/// </summary>
		/// <returns> true if given messages are semantically equivalent 
		/// </returns>
		public static bool equivalent(System.String message1, System.String message2)
		{
			System.String encoding1 = parser.getEncoding(message1);
			System.String encoding2 = parser.getEncoding(message2);
			
			if (!encoding1.Equals(encoding2))
			{
				if (encoding1.Equals("XML"))
				{
					message1 = safeER7Conversion(message1);
				}
				else
				{
					message2 = safeER7Conversion(message2);
				}
			}
			
			System.String std1, std2;
			try
			{
				std1 = standardize(message1);
				std2 = standardize(message2);
			}
			catch (System.Xml.XmlException e)
			{
				throw new NuGenHL7Exception("Equivalence check failed due to SAXException: " + e.Message);
			}
			
			return std1.Equals(std2);
		}
		
		/// <summary> Converts XML message to ER7, first checking integrity of parse and throwing 
		/// an exception if parse not correct
		/// </summary>
		private static System.String safeER7Conversion(System.String xmlMessage)
		{
			Message m = parser.parse(xmlMessage);
			
			System.String check = parser.encode(m, "XML");
			if (!equivalent(xmlMessage, check))
			{
				throw new NuGenHL7Exception("Parsed and encoded message not equivalent to original (possibilities: invalid message, bug in parser)");
			}
			
			return parser.encode(m, "VB");
		}
	}
}