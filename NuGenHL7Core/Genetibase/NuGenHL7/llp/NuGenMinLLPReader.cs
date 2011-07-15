/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "MinLLPReader.java".  Description: 
/// "Title:        HL7Reader
/// Description:  A buffered reader specifically designed for use in reading
/// HL7 ASCII strings" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
namespace Genetibase.NuGenHL7.llp
{
	
	/// <summary> Title:        HL7Reader
	/// Description:  A buffered reader specifically designed for use in reading
	/// HL7 ASCII strings. This class assumes that the minimal lower
	/// layer protocol is being used.
	/// Copyright:    Copyright (c) 2001
	/// Company:      University Health Network
	/// </summary>
	/// <author>        Damian Horton (damian.horton@uhn.on.ca); mods by Bryan Tripp
	/// </author>
	
	public class NuGenMinLLPReader : NuGenHL7Reader
	{
		
		public const System.String CHARSET_KEY = "Genetibase.NuGenHL7.llp.charset";

		private System.IO.StreamReader myReader;
		
		private const char END_MESSAGE = '\u001c'; //character indicating the
		//termination of an HL7 message
		private const char START_MESSAGE = '\u000b'; //character indicating the
		//start of an HL7 message
		private const char LAST_CHARACTER = (char) (13); //the final character of
		//a message: a carriage return
		
		//NB: The above is as per the minimal lower layer protocol.
		
		/// <summary>Creates a MinLLPReader with no setup - setInputStream must be set later. </summary>
		public NuGenMinLLPReader()
		{
		}
		
		/// <summary>Creates a MinLLPReader which reads from the given InputStream. The stream
		/// is assumed to be an ASCII bit stream.
		/// </summary>
		public NuGenMinLLPReader(System.IO.Stream in_Renamed)
		{
			setInputStream(in_Renamed);
		}
		
		/// <summary> Sets the InputStream from which to read messages.  The InputStream must be set 
		/// before any calls to <code>getMessage()</code>.
		/// </summary>
		public virtual void  setInputStream(System.IO.Stream in_Renamed)
		{
			lock (this)
			{
                myReader = new System.IO.StreamReader(in_Renamed);
			}
		}
		
		/// <summary>Calls the same method in the underlying BufferedReader. </summary>
		/// <summary>private int read(char[] parm1, int parm2, int parm3) throws java.io.IOException
		/// {
		/// return myReader.read(parm1, parm2, parm3);
		/// }
		/// </summary>
		
		/// <summary>Reads an HL7 encoded message from this Reader's InputStream.</summary>
		/// <returns> The message, in string format, without the lower level
		/// protocol delimeters. Returns null if a -1 is received on the initial
		/// read.
		/// </returns>
		public virtual System.String getMessage()
		{
			lock (this)
			{
				System.Text.StringBuilder s_buffer = new System.Text.StringBuilder();
				
				bool end_of_message = false;
				
				int c = 0;
				try
				{
					c = myReader.Read();
				}
				catch (System.Net.Sockets.SocketException)
				{
					return null;
				}
				
				//trying to read when there is no data (stream may have been closed at other end)
				if (c == - 1)
				{
					return null;
				}
				NuGenLowerLayerProtocol.logCharacterReceived(c);
				
				if (c != START_MESSAGE)
				{
					throw new NuGenLLPException("Message violates the " + "minimal lower layer protocol: no start of message indicator " + "received.");
				}
				
				while (!end_of_message)
				{
					c = myReader.Read();
					
					if (c == - 1)
					{
						throw new NuGenLLPException("Message violates the " + "minimal lower protocol: message terminated without " + "a terminating character.");
					}
					NuGenLowerLayerProtocol.logCharacterReceived(c);
					
					if (c == END_MESSAGE)
					{
						//subsequent character should be a carriage return
						c = myReader.Read();
						if (c >= 0)
							NuGenLowerLayerProtocol.logCharacterReceived(c);
						if (c != LAST_CHARACTER)
						{
							throw new NuGenLLPException("Message " + "violates the minimal lower layer protocol: " + "message terminator not followed by a return " + "character.");
						}
						end_of_message = true;
					}
					else
					{
						//the character wasn't the end of message, append it to the message
						s_buffer.Append((char) c);
					}
				} //end while
				
				return s_buffer.ToString();
			}
		}
		
		/// <summary>Test driver for the program. Bounces a message off of an echo socket,
		/// and ascertaines whether or not this class works.
		/// </summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			try
			{
				System.Net.Sockets.TcpClient s = new System.Net.Sockets.TcpClient("142.224.51.2", 7);
				
				NuGenHL7Reader in_Renamed = new NuGenMinLLPReader(s.GetStream());
				NuGenHL7Writer out_Renamed = new NuGenMinLLPWriter(s.GetStream());
				
				out_Renamed.writeMessage("Some message.");
				System.Console.Out.WriteLine("wrote");
				System.String str = in_Renamed.getMessage();
				System.Console.Out.WriteLine("read");
				
				System.Console.Out.WriteLine(str);
			}
			catch (System.Exception e)
			{
				System.Console.Out.WriteLine(e);
			}
		}
		
		/// <summary> Closes the underlying BufferedReader.</summary>
		public virtual void  close()
		{
			lock (this)
			{
				myReader.Close();
			}
		}
		
		private static System.IO.StreamWriter getWriter(System.IO.Stream theStream)
		{
			return new System.IO.StreamWriter(theStream, System.Text.Encoding.Default);
		}
		static NuGenMinLLPReader()
		{
		}
	}
}