/*
* Hl7InputStreamReader.java
*/
using System;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.util
{
	
	
	/// <summary> Reads HL7 messages from an InputStream
	/// 
	/// </summary>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2006/02/01 18:17:57 $ by $Author: nacharya $
	/// </version>
	public class NuGenHl7InputStreamReader
	{
		
		
		
		/// <summary> Reads HL7 messages from an InputStream and outputs an array of HL7 message strings
		/// 
		/// </summary>
		/// <version>  $Revision: 1.1 $ updated on $Date: 2006/02/01 18:17:57 $ by $Author: nacharya $
		/// </version>
		public static System.String[] read(System.IO.Stream theMsgInputStream)
		{
			Parser hapiParser = new PipeParser();
			
			System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new CommentFilterReader(new System.IO.StreamReader(theMsgInputStream, System.Text.Encoding.Default)).BaseStream, new CommentFilterReader(new System.IO.StreamReader(theMsgInputStream, System.Text.Encoding.Default)).CurrentEncoding);
			
			System.Text.StringBuilder rawMsgBuffer = new System.Text.StringBuilder();
			
			int c = 0;
			while ((c = in_Renamed.Read()) >= 0)
			{
				rawMsgBuffer.Append((char) c);
			}
			
			System.String[] messages = getHL7Messages(rawMsgBuffer.ToString());
			
			return messages;
		}
		
		
		
		/// <summary> Given a string that contains HL7 messages, and possibly other junk, 
		/// returns an array of the HL7 messages.  
		/// An attempt is made to recognize segments even if there is other 
		/// content between segments, for example if a log file logs segments 
		/// individually with timestamps between them.  
		/// 
		/// </summary>
		/// <param name="theSource">a string containing HL7 messages 
		/// </param>
		/// <returns> the HL7 messages contained in theSource
		/// </returns>
        private static System.String[] getHL7Messages(System.String theSource)
        {
            System.Collections.ArrayList messages = new System.Collections.ArrayList(20);
            Match startMatch = new Regex("^MSH", RegexOptions.Multiline).Match(theSource);

            foreach (Group group in startMatch.Groups)
            {
                System.String messageExtent = getMessageExtent(theSource.Substring(group.Index), "^MSH");

                char fieldDelim = messageExtent[3];

                Match segmentMatch = Regex.Match(messageExtent, "^[A-Z]{3}\\" + fieldDelim + ".*$", RegexOptions.Multiline);

                System.Text.StringBuilder msg = new System.Text.StringBuilder();
                foreach (Group segGroup in segmentMatch.Groups)
                {
                    msg.Append(segGroup.Value.Trim());
                    msg.Append('\r');
                }

                messages.Add(msg.ToString());
            }

            String[] retVal = new String[messages.Count];
            messages.CopyTo(retVal);

            return retVal;
        }

        /** 
         * Given a string that contains at least one HL7 message, returns the 
         * smallest string that contains the first of these messages.  
         */
        private static String getMessageExtent(String theSource, String theStartPattern)
        {
            Match startMatcher = Regex.Match(theSource, theStartPattern);
            if (!startMatcher.Success)
            {
                throw new Exception(theSource + "does not contain message start pattern"
                    + theStartPattern);
            }

            int start = startMatcher.Groups[0].Index;
            int end = theSource.Length;
            if (startMatcher.Groups.Count > 1)
            {
                end = startMatcher.Groups[1].Index;
            }

            return theSource.Substring(start, end-start).Trim();
        }
		
		/// <summary> TODO: this code is copied from HAPI ... should make it part of HAPI public API instead
		/// Removes C and C++ style comments from a reader stream.  C style comments are
		/// distinguished from URL protocol delimiters by the preceding colon in the
		/// latter.
		/// </summary>
		private class CommentFilterReader:SupportClass.BackReader
		{
			
			private char[] startCPPComment = new char[]{'/', '*'};
			private char[] endCPPComment = new char[]{'*', '/'};
			private char[] startCComment = new char[]{'/', '/'};
			private char[] endCComment = new char[]{'\n'};
			private char[] protocolDelim = new char[]{':', '/', '/'};
			
			public CommentFilterReader(System.IO.StreamReader in_Renamed):base(in_Renamed.BaseStream, 5, in_Renamed.CurrentEncoding)
			{
			}
			
			/// <summary> Returns the next character, not including comments.</summary>
			public int read()
			{
				if (atSequence(protocolDelim))
				{
					//proceed normally
				}
				else if (atSequence(startCPPComment))
				{
					//skip() doesn't seem to work for some reason
					while (!atSequence(endCPPComment))
						base.Read();
					for (int i = 0; i < endCPPComment.Length; i++)
						base.Read();
				}
				else if (atSequence(startCComment))
				{
					while (!atSequence(endCComment))
						base.Read();
					for (int i = 0; i < endCComment.Length; i++)
						base.Read();
				}
				int ret = base.Read();
				if (ret == 65535)
					ret = - 1;
				return ret;
			}
			
			public int read(char[] cbuf, int off, int len)
			{
				int i = - 1;
				bool done = false;
				while (++i < len)
				{
					int next = read();
					if (next == 65535 || next == - 1)
					{
						//Pushback causes -1 to convert to 65535
						done = true;
						break;
					}
					cbuf[off + i] = (char) next;
				}
				if (i == 0 && done)
					i = - 1;
				return i;
			}
			
			/// <summary> Tests incoming data for match with char sequence, resets reader when done.</summary>
			private bool atSequence(char[] sequence)
			{
				bool result = true;
				int i = - 1;
				int[] data = new int[sequence.Length];
				while (++i < sequence.Length && result == true)
				{
					data[i] = base.Read();
					if ((char) data[i] != sequence[i])
						result = false; //includes case where end of stream reached
				}
				for (int j = i - 1; j >= 0; j--)
				{
					this.UnRead(data[j]);
				}
				return result;
			}
		}
	}
}