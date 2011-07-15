/*
* HL7ServerTest.java
*/
using System;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> Helper class used to send messages from a flat file to 
	/// an ip and port. 
	/// 
	/// Messasges are sent using MLLP and ACK protocal
	/// 
	/// <mailto:laura.bright@uhn.on.ca>Laura Bright</mailto>
	/// <mailto:neal.acharya@uhn.on.ca>Neal Acharya</mailto>
	/// <mailto:james.agnew@uhn.on.ca>James Agnew</mailto>
	/// 
	/// </summary>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2006/03/03 16:52:15 $ by $Author: nacharya $
	/// </version>
	public class NuGenHL7ServerTestHelper
	{
		
		private const System.String HL7_START_OF_MESSAGE = "\u000b";
		private const System.String HL7_SEGMENT_SEPARATOR = "\r";
		private const System.String HL7_END_OF_MESSGAE = "\u001c";

		private System.String host = null;
		
		private int port = 0;
		
		private System.Net.Sockets.TcpClient socket = null;
		
		private System.IO.Stream os = null;
		private System.IO.Stream is_Renamed = null;
		
		public NuGenHL7ServerTestHelper(System.String host, int port)
		{
			this.host = host;
			this.port = port;
		}
		
		/*
		* 
		*/
		public virtual void  openSocket()
		{
			socket = new System.Net.Sockets.TcpClient(host, port);
			socket.LingerState = new System.Net.Sockets.LingerOption(true, 1000);
			
			os = socket.GetStream();
			is_Renamed = socket.GetStream();
		}
		
		/// <summary> 
		/// 
		/// </summary>
		public virtual void  closeSocket()
		{
			try
			{
				System.Net.Sockets.TcpClient sckt = socket;
				socket = null;
				if (sckt != null)
					sckt.Close();
			}
			catch (System.Exception)
			{
			}
		}
		
		
		public virtual int process(System.IO.Stream theMsgInputStream)
		{
			Parser hapiParser = new PipeParser();
			
			System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new CommentFilterReader(new System.IO.StreamReader(theMsgInputStream, System.Text.Encoding.Default)).BaseStream, new CommentFilterReader(new System.IO.StreamReader(theMsgInputStream, System.Text.Encoding.Default)).CurrentEncoding);
			
			System.Text.StringBuilder rawMsgBuffer = new System.Text.StringBuilder();
			
			//String line = in.readLine();
			int c = 0;
			while ((c = in_Renamed.Read()) >= 0)
			{
				rawMsgBuffer.Append((char) c);
			}
			
			System.String[] messages = getHL7Messages(rawMsgBuffer.ToString());
			int retVal = 0;
			
			//start time			
            long startTime = DateTime.UtcNow.Ticks;
			
			
			for (int i = 0; i < messages.Length; i++)
			{
				sendMessage(messages[i]);
				readAck();
				retVal++;
			}
			
			//end time
            long endTime = DateTime.UtcNow.Ticks;
			
			//elapsed time
			long elapsedTime = (endTime - startTime) / 1000;

			return retVal;
		}
		
		private System.String readAck()
		{
			System.Text.StringBuilder stringbuffer = new System.Text.StringBuilder();
			int i = 0;
			do 
			{
				i = is_Renamed.ReadByte();
				if (i == - 1)
					return null;
				
				stringbuffer.Append((char) i);
			}
			while (i != 28);
			return stringbuffer.ToString();
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
		public static System.String[] getHL7Messages(System.String theSource)
		{
			System.Collections.ArrayList messages = new System.Collections.ArrayList(20);
            Match m = Regex.Match(theSource, "^MSH", RegexOptions.Multiline);

            foreach(Group g in m.Groups)
            {
                String messageExtent = getMessageExtent(theSource.Substring(g.Index), "^MSH");

                char fieldDelim = messageExtent[3];
                Match segmatch = new Regex("^[A-Z\\d]{3}\\" + fieldDelim + ".*$", RegexOptions.Multiline).Match(messageExtent);
				System.Text.StringBuilder msg = new System.Text.StringBuilder();

                foreach (Group group in segmatch.Groups)
                {
                    msg.Append(g.Value.Trim());
                    msg.Append('\r');
                }

				messages.Add(msg.ToString());
            }

            String[] retVal = new String[messages.Count];
            messages.CopyTo(retVal);

            return retVal;
		}

        private static String getMessageExtent(String theSource, String theStartPattern)
        {
            Match m = Regex.Match(theSource, theStartPattern);
            if (!m.Success)
            {
                throw new Exception(theSource + "does not contain message start pattern"
                    + theStartPattern);
            }

            int start = m.Groups[0].Index;           
            int end = theSource.Length;

            if (m.Groups.Count > 1)
            {
                end = m.Groups[1].Index;
            }

            return theSource.Substring(start, end - start).Trim();
        }
		
		private void  sendMessage(System.String theMessage)
		{
			sbyte[] temp_sbyteArray;
			temp_sbyteArray = SupportClass.ToSByteArray(SupportClass.ToByteArray(HL7_START_OF_MESSAGE));
			os.Write(SupportClass.ToByteArray(temp_sbyteArray), 0, temp_sbyteArray.Length);
			sbyte[] temp_sbyteArray2;
			temp_sbyteArray2 = SupportClass.ToSByteArray(SupportClass.ToByteArray(theMessage));
			os.Write(SupportClass.ToByteArray(temp_sbyteArray2), 0, temp_sbyteArray2.Length);
			sbyte[] temp_sbyteArray3;
			temp_sbyteArray3 = SupportClass.ToSByteArray(SupportClass.ToByteArray(HL7_END_OF_MESSGAE));
			os.Write(SupportClass.ToByteArray(temp_sbyteArray3), 0, temp_sbyteArray3.Length);
			os.WriteByte((System.Byte) 13);
			os.Flush();
		}
		
		/// <summary> TODO: this code is copied from HAPI ... should make it part of HAPI public API instead
		/// Removes C and C++ style comments from a reader stream.  C style comments are
		/// distinguished from URL protocol delimiters by the preceding colon in the
		/// latter.
		/// </summary>
		public class CommentFilterReader:SupportClass.BackReader
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