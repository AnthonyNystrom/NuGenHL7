/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "Receiver.java".  Description:
/// "Listens for incoming messages on a certain input stream, and
/// sends them to the appropriate location."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2002.  All Rights Reserved.
/// 
/// Contributor(s): _____________.
/// 
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
using HL7Reader = Genetibase.NuGenHL7.llp.NuGenHL7Reader;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> Listens for incoming messages on a certain input stream, and
	/// sends them to the appropriate location.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenReceiver : IThreadRunnable
	{
		private NuGenConnection conn;
		private HL7Reader in_Renamed;
		private bool running;
		
		/// <summary>Creates a new instance of Receiver, associated with the given Connection  </summary>
		public NuGenReceiver(NuGenConnection c, HL7Reader in_Renamed)
		{
			this.conn = c;
			this.in_Renamed = in_Renamed;
		}
		
		/// <summary> Loops continuously, reading messages and calling processMessage() until
		/// stop() is called.
		/// </summary>
		public virtual void  Run()
		{
			while (running)
			{
				System.Threading.Thread.Sleep(0);
				try
				{
					System.String message = in_Renamed.getMessage();
					if (message == null)
					{
						conn.close();
					}
					else
					{
						processMessage(message);
					}
				}
				catch (System.IO.IOException)
				{
					conn.close();
				}
				catch (System.Exception)
				{
				}
			}
		}
		
		/// <summary> Processes a single incoming message by sending it to the appropriate
		/// internal location.  If an incoming message contains
		/// an MSA-2 field, it is assumed that this message is meant as a reply to a message that has been sent
		/// earlier.  In this case an attempt is give the message to the object
		/// that sent the corresponding outbound message.  If the message contains an MSA-2 but there are no objects that
		/// appear to be waiting for it, it is discarded and an exception is logged. If the message does not
		/// contain an MSA-2 field, it is concluded that the message has arrived unsolicited.  In this case
		/// it is sent to the Responder (in a new Thread).
		/// </summary>
		protected internal virtual void  processMessage(System.String message)
		{
			System.String ackID = conn.Parser.getAckID(message);
			if (ackID == null)
			{
				Grunt g = new Grunt(this, conn, message);
				g.Start();
			}
			else
			{
				NuGenMessageReceipt mr = conn.findRecipient(ackID);
				if (mr == null)
				{
				}
				else
				{
					mr.Message = message;
				}
			}
		}
		
		/// <summary>Independent thread for processing a single message </summary>
		private class Grunt:SupportClass.ThreadClass
		{
			private void  InitBlock(NuGenReceiver enclosingInstance)
			{
				this.enclosingInstance = enclosingInstance;
			}
			private NuGenReceiver enclosingInstance;
			public NuGenReceiver Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			
			private NuGenConnection conn;
			private System.String m;
			
			public Grunt(NuGenReceiver enclosingInstance, NuGenConnection conn, System.String message)
			{
				InitBlock(enclosingInstance);
				this.conn = conn;
				this.m = message;
			}
			
			override public void  Run()
			{
				try
				{
					System.String response = conn.Responder.processMessage(m);
					conn.AckWriter.writeMessage(response);
				}
				catch (System.Exception)
				{
				}
			}
		}
		
		/// <summary>Starts the Receiver in a new thread </summary>
		public virtual void  start()
		{
			running = true;
			SupportClass.ThreadClass thd = new SupportClass.ThreadClass(new System.Threading.ThreadStart(this.Run));
			thd.Start();
		}
		
		/// <summary>Stops the Receiver after the next message is read. </summary>
		public virtual void  stop()
		{
			running = false;
		}
		static NuGenReceiver()
		{
		}
	}
}