/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "Responder.java".  Description:
/// "Performs the responding role in a message exchange according to HL7's original mode
/// processing rules."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2002.  All Rights Reserved.
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
using HL7Reader = Genetibase.NuGenHL7.llp.NuGenHL7Reader;
using HL7Writer = Genetibase.NuGenHL7.llp.NuGenHL7Writer;
using LLPException = Genetibase.NuGenHL7.llp.NuGenLLPException;
using Message = Genetibase.NuGenHL7.model.Message;
using Segment = Genetibase.NuGenHL7.model.Segment;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
using MessageIDGenerator = Genetibase.NuGenHL7.util.NuGenMessageIDGenerator;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.app
{
	//import Genetibase.NuGenHL7.model.v24.datatype.ValidNM;
	
	/// <summary> <p>Performs the responding role in a message exchange (i.e receiver of the first message,
	/// sender of the response; analagous to the server in a client-server interaction), according
	/// to HL7's original mode processing rules.</p>
	/// <p>At the time of writing, enhanced mode, two-phase reply, continuation messages, and
	/// batch processing are unsupported. </p>
	/// </summary>
	/// <author>   Bryan Tripp
	/// </author>
	public class NuGenResponder
	{
		//private LowerLayerProtocol llp;
		private Parser parser;
		private System.Collections.ArrayList apps;
		private System.IO.StreamWriter checkWriter = null;
		
		/// <summary> Creates a new instance of Responder that optionally validates parsing of incoming
		/// messages using a system property.  If the system property
		/// <code>Genetibase.NuGenHL7.app.checkparse</code> equals "true", parse integrity is checked,
		/// i.e. each message is re-encoded and differences between the received message text
		/// and the re-encoded text are written to the file <hapi.home>/parse_check.txt.
		/// </summary>
		public NuGenResponder(Parser parser)
		{
			init(parser, false);
		}
		
		/// <summary> Creates a new instance of Responder that optionally validates parsing of incoming messages.</summary>
		/// <param name="validate">if true, encodes each incoming message after parsing it, compares
		/// the result to the original message string, and prints differences to the file
		/// "<hapi.home>/parse_check.txt" in the working directory.  This process is slow and should
		/// only be used during testing.
		/// </param>
		public NuGenResponder(Parser parser, bool checkParse)
		{
			init(parser, checkParse);
		}
		
		/// <summary> Performs common constructor tasks.</summary>
		private void  init(Parser parser, bool checkParse)
		{
			this.parser = parser;
			apps = new System.Collections.ArrayList(10);
			try
			{
				if (checkParse)
				{
					checkWriter = new System.IO.StreamWriter(new System.IO.StreamWriter(Genetibase.NuGenHL7.util.NuGenHome.getHomeDirectory().FullName + "/parse_check.txt", true, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(Genetibase.NuGenHL7.util.NuGenHome.getHomeDirectory().FullName + "/parse_check.txt", true, System.Text.Encoding.Default).Encoding);
				}
			}
			catch (System.IO.IOException)
			{
			}
		}
		
		/// <summary> Processes an incoming message string and returns the response message string.
		/// Message processing consists of parsing the message, finding an appropriate
		/// Application and processing the message with it, and encoding the response.
		/// Applications are chosen from among those registered using
		/// <code>registerApplication</code>.  The Parser is obtained from the Connection
		/// associated with this Responder.
		/// </summary>
		protected internal virtual System.String processMessage(System.String incomingMessageString)
		{
			
			Message incomingMessageObject = null;
			System.String outgoingMessageString = null;
			try
			{
				incomingMessageObject = parser.parse(incomingMessageString);
			}
			catch (NuGenHL7Exception e)
			{
				outgoingMessageString = logAndMakeErrorMessage(e, parser.getCriticalResponseData(incomingMessageString), parser, parser.getEncoding(incomingMessageString));
			}
			
			if (outgoingMessageString == null)
			{
				try
				{
					//optionally check integrity of parse
					try
					{
						if (checkWriter != null)
							checkParse(incomingMessageString, incomingMessageObject, parser);
					}
					catch (System.IO.IOException)
					{
					}
					
					//message validation (in terms of optionality, cardinality) would go here ***
					
					NuGenApplication app = findApplication(incomingMessageObject);
					Message response = app.processMessage(incomingMessageObject);
					
					//Here we explicitly use the same encoding as that of the inbound message - this is important with GenericParser, which might use a different encoding by default
					outgoingMessageString = parser.encode(response, parser.getEncoding(incomingMessageString));
				}
				catch (System.Exception e)
				{
					outgoingMessageString = logAndMakeErrorMessage(e, (Segment) incomingMessageObject.get_Renamed("MSH"), parser, parser.getEncoding(incomingMessageString));
				}
			}
			
			return outgoingMessageString;
		}
		
		/// <summary> Returns the first Application that has been registered, which can process the given
		/// Message (according to its canProcess() method).
		/// </summary>
		private NuGenApplication findApplication(Message message)
		{
			int c = 0;
			NuGenApplication app = null;
			while (app == null && c < this.apps.Count)
			{
				NuGenApplication a = (NuGenApplication) this.apps[c++];
				if (a.canProcess(message))
					app = a;
			}
			
			//have to send back an application reject of no apps available to process
			if (app == null)
				app = new NuGenDefaultApplication();
			return app;
		}
		
		/// <summary> Encodes the given message and compares it to the given string.  Any differences
		/// are noted in the file [hapi.home]/parse_check.txt.  Ignores extra field delimiters.
		/// </summary>
		private void  checkParse(System.String originalMessageText, Message parsedMessage, Parser parser)
		{
			System.String newMessageText = parser.encode(parsedMessage);
			
			checkWriter.Write("******************* Comparing Messages ****************\r\n");
			checkWriter.Write("Original:           " + originalMessageText + "\r\n");
			checkWriter.Write("Parsed and Encoded: " + newMessageText + "\r\n");
			
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
					checkWriter.Write("Warning: inbound and parsed messages have different numbers of segments: \r\n");
					checkWriter.Write("Original: " + originalMessageText + "\r\n");
					checkWriter.Write("Parsed:   " + newMessageText + "\r\n");
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
							checkWriter.Write("Warning: inbound and parsed message segment differs: \r\n");
							checkWriter.Write("Original: " + origSeg + "\r\n");
							checkWriter.Write("Parsed: " + newSeg + "\r\n");
						}
					}
				}
			}
			else
			{
				checkWriter.Write("No differences found\r\n");
			}
			
			checkWriter.Write("********************  End Comparison  ******************\r\n");
			checkWriter.Flush();
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
		
		/// <summary> Logs the given exception and creates an error message to send to the
		/// remote system.
		/// 
		/// </summary>
		/// <param name="encoding">The encoding for the error message. If <code>null</code>, uses default encoding 
		/// </param>
		public static System.String logAndMakeErrorMessage(System.Exception e, Segment inHeader, Parser p, System.String encoding)
		{
			
			
			// create error message ...
			System.String errorMessage = null;
			try
			{
				Message out_Renamed = NuGenDefaultApplication.makeACK(inHeader);
				Terser t = new Terser(out_Renamed);
				
				//copy required data from incoming message ...
				try
				{
					t.set_Renamed("/MSH-10", MessageIDGenerator.Instance.NewID);
				}
				catch (System.IO.IOException ioe)
				{
					throw new NuGenHL7Exception("Problem creating error message ID: " + ioe.Message);
				}
				
				//populate MSA ...
				t.set_Renamed("/MSA-1", "AE"); //should this come from HL7Exception constructor?
				t.set_Renamed("/MSA-2", Terser.get_Renamed(inHeader, 10, 0, 1, 1));
				System.String excepMessage = e.Message;
				if (excepMessage != null)
					t.set_Renamed("/MSA-3", excepMessage.Substring(0, (System.Math.Min(80, excepMessage.Length)) - (0)));
				
				/* Some earlier ACKs don't have ERRs, but I think we'll change this within HAPI
				so that there is a single ACK for each version (with an ERR). */
				//see if it's an HL7Exception (so we can get specific information) ...
				if (e.GetType().Equals(typeof(NuGenHL7Exception)))
				{
					Segment err = (Segment) out_Renamed.get_Renamed("ERR");
					((NuGenHL7Exception) e).populate(err);
				}
				else
				{
					t.set_Renamed("/ERR-1-4-1", "207");
					t.set_Renamed("/ERR-1-4-2", "Application Internal Error");
					t.set_Renamed("/ERR-1-4-3", "HL70357");
				}
				
				if (encoding != null)
				{
					errorMessage = p.encode(out_Renamed, encoding);
				}
				else
				{
					errorMessage = p.encode(out_Renamed);
				}
			}
			catch (System.IO.IOException ioe)
			{
				throw new NuGenHL7Exception("IOException creating error response message: " + ioe.Message, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			return errorMessage;
		}
		
		/// <summary> Registers a message parser/encoder with this responder.  If multiple parsers
		/// are registered, each message is inspected by each parser in the order in which
		/// they are registered, until one parser recognizes the format and parses the
		/// message.
		/// </summary>
		/*public void registerParser(Parser p) {
		this.parsers.add(p);
		}*/
		
		/// <summary> Registers an Application with this Responder.  The "Application", in this
		/// context, is the software that uses the information in the message.  If multiple
		/// applications are registered, incoming Message objects will be passed to
		/// each one in turn (calling <code>canProcess()</code>) until one of them accepts
		/// responsibility for the message.  If none of the registered applications can
		/// process the message, a DefaultApplication is used, which simply returns an
		/// Application Reject message.
		/// </summary>
		public virtual void  registerApplication(NuGenApplication a)
		{
			this.apps.Add(a);
		}
		
		/// <summary> Test code.</summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length != 1)
			{
				System.Console.Error.WriteLine("Usage: DefaultApplication message_file");
				System.Environment.Exit(1);
			}
			
			//read test message file ...
			try
			{
				System.IO.FileInfo messageFile = new System.IO.FileInfo(args[0]);
				System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(messageFile.FullName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(messageFile.FullName, System.Text.Encoding.Default).CurrentEncoding);
				int fileLength = (int) SupportClass.FileLength(messageFile);
				char[] cbuf = new char[fileLength];
				in_Renamed.Read(cbuf, 0, fileLength);
				System.String messageString = new System.String(cbuf);
				
				//parse inbound message ...
				Parser parser = new PipeParser();
				Message inMessage = null;
				try
				{
					inMessage = parser.parse(messageString);
				}
				catch (NuGenHL7Exception e)
				{
					SupportClass.WriteStackTrace(e, Console.Error);
				}
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static NuGenResponder()
		{
		}
	}
}