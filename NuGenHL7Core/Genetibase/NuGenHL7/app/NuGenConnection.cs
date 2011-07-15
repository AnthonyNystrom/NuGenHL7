/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Connection.java".  Description: 
/// "A TCP/IP connection to a remote HL7 server." 
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
using HL7Writer = Genetibase.NuGenHL7.llp.NuGenHL7Writer;
using LLPException = Genetibase.NuGenHL7.llp.NuGenLLPException;
using LowerLayerProtocol = Genetibase.NuGenHL7.llp.NuGenLowerLayerProtocol;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> A TCP/IP connection to a remote HL7 server.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenConnection
	{
		/// <summary> Returns the address of the remote host to which this Connection is connected. 
		/// If separate inbound and outbound sockets are used, the address of the outbound
		/// socket is returned (the addresses should normally be the same, but this isn't 
		/// checked).  
		/// </summary>
		virtual public System.Net.IPAddress RemoteAddress
		{
			get
			{
				System.Net.Sockets.TcpClient s = (System.Net.Sockets.TcpClient) sockets[0];
                System.Net.IPEndPoint end = s.Client.RemoteEndPoint as System.Net.IPEndPoint;

                return end.Address;
			}
			
		}
		/// <summary>Returns the Initiator associated with this connection </summary>
		virtual public NuGenInitiator Initiator
		{
			get
			{
				return this.initiator;
			}
			
		}
		/// <summary>Returns the Responder associated with this connection </summary>
		virtual public NuGenResponder Responder
		{
			get
			{
				return this.responder;
			}
			
		}
		/// <summary>Returns the HL7Writer through which unsolicited outbound messages should be sent. </summary>
		virtual protected internal HL7Writer SendWriter
		{
			get
			{
				return this.sendWriter;
			}
			
		}
		/// <summary>Returns the HL7Writer through which responses to inbound messages should be sent. </summary>
		virtual protected internal HL7Writer AckWriter
		{
			get
			{
				return this.ackWriter;
			}
			
		}
		virtual public Parser Parser
		{
			get
			{
				return this.parser;
			}
			
		}
		/// <summary>Returns false if the Connection has been closed. </summary>
		virtual public bool Open
		{
			get
			{
				return open;
			}
			
		}

		private NuGenInitiator initiator;
		private NuGenResponder responder;
		private System.Collections.ArrayList sockets;
		private HL7Writer ackWriter;
		private HL7Writer sendWriter;
		private Parser parser;
		private System.Collections.Hashtable receipts;
		private System.Collections.ArrayList receivers;
		private bool open = true;
		
		/// <summary> Creates a new instance of Connection, with inbound and outbound 
		/// communication on a single port. 
		/// </summary>
		public NuGenConnection(Parser parser, LowerLayerProtocol llp, System.Net.Sockets.TcpClient bidirectional)
		{
			init(parser);
			ackWriter = llp.getWriter(bidirectional.GetStream());
			sendWriter = ackWriter;
			sockets.Add(bidirectional);
			NuGenReceiver r = new NuGenReceiver(this, llp.getReader(bidirectional.GetStream()));
			r.start();
			receivers.Add(r);
			this.initiator = new NuGenInitiator(this);
		}
		
		/// <summary> Creates a new instance of Connection, with inbound communication on one 
		/// port and outbound on another.
		/// </summary>
		public NuGenConnection(Parser parser, LowerLayerProtocol llp, System.Net.Sockets.TcpClient inbound, System.Net.Sockets.TcpClient outbound)
		{
			init(parser);
			ackWriter = llp.getWriter(inbound.GetStream());
			sendWriter = llp.getWriter(outbound.GetStream());
			sockets.Add(outbound); //always add outbound first ... see getRemoteAddress()
			sockets.Add(inbound);
			NuGenReceiver inRec = new NuGenReceiver(this, llp.getReader(inbound.GetStream()));
			NuGenReceiver outRec = new NuGenReceiver(this, llp.getReader(outbound.GetStream()));
			inRec.start();
			outRec.start();
			receivers.Add(inRec);
			receivers.Add(outRec);
			this.initiator = new NuGenInitiator(this);
		}
		
		/// <summary>Common initialization tasks </summary>
		private void  init(Parser parser)
		{
			this.parser = parser;
			sockets = new System.Collections.ArrayList();
			receipts = new System.Collections.Hashtable();
			receivers = new System.Collections.ArrayList();
			responder = new NuGenResponder(parser);
		}
		
		public override System.String ToString()
		{
			System.Text.StringBuilder buf = new System.Text.StringBuilder();
			buf.Append(System.Net.Dns.GetHostEntry(RemoteAddress.ToString()).HostName);
			buf.Append(":");
			for (int i = 0; i < sockets.Count; i++)
			{
				System.Net.IPEndPoint end = ((System.Net.Sockets.TcpClient) sockets[i]).Client.RemoteEndPoint as System.Net.IPEndPoint;
                buf.Append(end.Port);
				if (i + 1 < sockets.Count)
					buf.Append(",");
			}
			return buf.ToString();
		}
		
		/// <summary> Reserves a future incoming message by ack ID.  When the incoming message 
		/// with the given ack ID arrives, the message will be available through 
		/// the returned MessageReceipt.  
		/// </summary>
		protected internal virtual NuGenMessageReceipt reserveResponse(System.String messageID)
		{
			NuGenMessageReceipt mr = new NuGenMessageReceipt();
			receipts[messageID] = mr;
			return mr;
		}
		
		/// <summary> Given the ack ID (MSA-2) of a message, returns the corresponding 
		/// MessageReceipt if one exists (ie if reserveResponse has been called for this 
		/// ack ID).  Otherwise (i.e. if no object is waiting for this message), returns null. 
		/// This method can only be called once per ackId (the record is dropped with the 
		/// call).  
		/// </summary>
		protected internal virtual NuGenMessageReceipt findRecipient(System.String ackID)
		{
			//String ID = getParser().getAckID(message);
			NuGenMessageReceipt mr = null;
			if (ackID != null)
			{
				System.Object tempObject;
				tempObject = receipts[ackID];
				receipts.Remove(ackID);
				mr = (NuGenMessageReceipt) tempObject;
			}
			return mr;
		}
		
		/// <summary>Stops running Receiver threads and closes open sockets </summary>
		public virtual void  close()
		{
			for (int i = 0; i < receivers.Count; i++)
			{
				((NuGenReceiver) receivers[i]).stop();
			}
			for (int i = 0; i < sockets.Count; i++)
			{
				try
				{
					((System.Net.Sockets.TcpClient) sockets[i]).Close();
				}
				catch (System.IO.IOException)
				{
				}
			}
			open = false;
		}
		static NuGenConnection()
		{
		}
	}
}