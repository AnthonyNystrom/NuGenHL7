/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Initiator.java".  Description: 
/// "Performs the initiation role of a message exchange accorging to HL7's original 
/// mode rules." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2002.  All Rights Reserved. 
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
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using HL7Reader = Genetibase.NuGenHL7.llp.NuGenHL7Reader;
using HL7Writer = Genetibase.NuGenHL7.llp.NuGenHL7Writer;
using LLPException = Genetibase.NuGenHL7.llp.NuGenLLPException;
using LowerLayerProtocol = Genetibase.NuGenHL7.llp.NuGenLowerLayerProtocol;
using Message = Genetibase.NuGenHL7.model.Message;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
using MessageIDGenerator = Genetibase.NuGenHL7.util.NuGenMessageIDGenerator;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> <p>Performs the initiation role of a message exchange (i.e sender of the first message; 
	/// analagous to the client in a client-server interaction), according to HL7's original 
	/// mode processing rules.</p>
	/// <p>The <code>sendAndReceive(...)</code> method blocks until either a response is received 
	/// with the matching message ID, or until a timeout period has passed.  The timeout defaults to 
	/// 10000 ms (10 sec) but can be configured by setting the system property "Genetibase.NuGenHL7.app.initiator.timeout"
	/// to an integer value representing the number of ms after which to time out.</p>
	/// <p>At the time of writing, enhanced mode, two-phase reply, continuation messages, and 
	/// batch processing are unsupported. </p>
	/// </summary>
	/// <author>   Bryan Tripp
	/// </author>
	public class NuGenInitiator
	{
		private class AnonymousClassRunnable : IThreadRunnable
		{
			public AnonymousClassRunnable(Genetibase.NuGenHL7.parser.NuGenParser parser, System.String outText, Genetibase.NuGenHL7.app.NuGenInitiator initiator)
			{
				InitBlock(parser, outText, initiator);
			}
			private void  InitBlock(Genetibase.NuGenHL7.parser.NuGenParser parser, System.String outText, Genetibase.NuGenHL7.app.NuGenInitiator initiator)
			{
				this.parser = parser;
				this.outText = outText;
				this.initiator = initiator;
			}
			private Genetibase.NuGenHL7.parser.NuGenParser parser;
			private System.String outText;
			private Genetibase.NuGenHL7.app.NuGenInitiator initiator;
			public virtual void  Run()
			{
				try
				{
					//get message ID
					System.String ID = MessageIDGenerator.Instance.NewID;
					Message out_Renamed = parser.parse(outText);
					Terser tOut = new Terser(out_Renamed);
					tOut.set_Renamed("/MSH-10", ID);
					
					//send, get response
					Message in_Renamed = initiator.sendAndReceive(out_Renamed);
					
					//get ACK ID
					Terser tIn = new Terser(in_Renamed);
					System.String ackID = tIn.get_Renamed("/MSA-2");
					if (ID.Equals(ackID))
					{
						System.Console.Out.WriteLine("OK - ack ID matches");
					}
					else
					{
						throw new System.SystemException("Ack ID for message " + ID + " is " + ackID);
					}
				}
				catch (System.Exception e)
				{
					SupportClass.WriteStackTrace(e, Console.Error);
				}
			}
		}
		/// <summary> Sets the time (in milliseconds) that the initiator will wait for a response 
		/// for a given message before timing out and throwing an exception (default 
		/// is 10 seconds). 
		/// </summary>
		virtual public int TimeoutMillis
		{
			set
			{
				this.timeoutMillis = value;
			}
			
		}
		//private Parser parser;		
		private NuGenConnection conn;
		//private boolean keepListening;    
		private int timeoutMillis = 10000;
		
		/// <summary> Creates a new instance of Initiator.  </summary>
		/// <param name="conn">the Connection associated with this Initiator.   
		/// </param>
		protected internal NuGenInitiator(NuGenConnection conn)
		{
			this.conn = conn;
		}
		
		/// <summary> Sends a message to a responder system, receives the reply, and 
		/// returns the reply as a Message object.  This method is thread-safe - multiple  
		/// threads can share an Initiator and call this method.  Responses are returned to 
		/// the calling thread on the basis of message ID.  
		/// </summary>
		public virtual Message sendAndReceive(Message out_Renamed)
		{
			
			if (out_Renamed == null)
				throw new NuGenHL7Exception("Can't encode null message", NuGenHL7Exception.REQUIRED_FIELD_MISSING);
			
			//register message with response Receiver(s) (by message ID)
			Terser t = new Terser(out_Renamed);
			System.String messID = t.get_Renamed("/MSH-10");
			NuGenMessageReceipt mr = this.conn.reserveResponse(messID);
			
			//log and send message 
			System.String outbound = conn.Parser.encode(out_Renamed);
			
			try
			{
				this.conn.SendWriter.writeMessage(outbound);
			}
			catch (System.IO.IOException e)
			{
				conn.close();
				throw e;
			}
			
			//wait for response
			bool done = false;
			Message response = null;
			long startTime = (System.DateTime.Now.Ticks - 621355968000000000) / 10000;
			while (!done)
			{
				lock (mr)
				{
					try
					{
						System.Threading.Monitor.Wait(mr, TimeSpan.FromMilliseconds(500)); //if it comes, notifyAll() will be called
					}
					catch (System.Threading.ThreadInterruptedException)
					{
					}
					
					if (mr.Message != null)
					{
						//get message from receipt 
						System.String inbound = mr.Message;
						
						//parse message
						response = conn.Parser.parse(inbound);
						done = true;
					}
					
					//if ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 > startTime + timeoutMillis)
						//throw new HL7Exception("Timeout waiting for response to message with control ID '" + messID);
				}
			}
			
			return response;
		}
		
		/// <summary> Test harness</summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length != 2)
			{
				System.Console.Out.WriteLine("Usage: Genetibase.NuGenHL7.app.Initiator host port");
			}
			
			try
			{
				
				//set up connection to server
				System.String host = args[0];
				int port = System.Int32.Parse(args[1]);
				
				Parser parser = new PipeParser();
				LowerLayerProtocol llp = LowerLayerProtocol.makeLLP();
				NuGenConnection connection = new NuGenConnection(parser, llp, new System.Net.Sockets.TcpClient(host, port));
				NuGenInitiator initiator = connection.Initiator;
				System.String outText = "MSH|^~\\&|||||||ACK^^ACK|||R|2.4|\rMSA|AA";
				
				//get a bunch of threads to send messages
				for (int i = 0; i < 1000; i++)
				{
					SupportClass.ThreadClass sender = new SupportClass.ThreadClass(new System.Threading.ThreadStart(new AnonymousClassRunnable(parser, outText, initiator).Run));
					sender.Start();
				}
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static NuGenInitiator()
		{
		}
	}
}