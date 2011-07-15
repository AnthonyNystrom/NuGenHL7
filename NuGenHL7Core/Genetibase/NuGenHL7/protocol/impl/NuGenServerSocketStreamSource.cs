/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "ServerSocketStreamSource.java".  Description: 
"A StreamSource that gets streams from ServerSockets." 

The Initial Developer of the Original Code is University Health Network. Copyright (C) 
2004.  All Rights Reserved. 

Contributor(s): ______________________________________. 

Alternatively, the contents of this file may be used under the terms of the 
GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
applicable instead of those above.  If you wish to allow use of your version of this 
file only under the terms of the GPL and not to allow others to use your version 
of this file under the MPL, indicate your decision by deleting  the provisions above 
and replace  them with the notice and other provisions required by the GPL License.  
If you do not delete the provisions above, a recipient may use your version of 
this file under either the MPL or the GPL. */
using System;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A <code>StreamSource</code> that gets streams from ServerSockets.  This 
	/// allows you to communicate over sockets that are established by the remote 
	/// party (ie as a TCP/IP server).
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2004/05/31 17:11:58 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenServerSocketStreamSource:NuGenSocketStreamSource
	{
		
		private System.Net.Sockets.TcpListener myServerSocket;
		private System.String myExpectedAddress;
		private System.Net.Sockets.TcpClient mySocket;
		
		/// <param name="theServerSocket">a ServerSocket at which to listen for incoming connections  
		/// </param>
		/// <param name="theExpectedAddress">the IP address from which to accept connections (null means 
		/// accept from any address) 
		/// </param>
		/// <throws>  TransportException </throws>
		public NuGenServerSocketStreamSource(System.Net.Sockets.TcpListener theServerSocket, System.String theExpectedAddress)
		{
			myServerSocket = theServerSocket;
			myExpectedAddress = theExpectedAddress;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.impl.SocketStreamSource.getSocket()">
		/// </seealso>
		public override System.Net.Sockets.TcpClient getSocket()
		{
			return mySocket;
		}
		
		/// <summary> Accepts new connections on underlying ServerSocket, replacing 
		/// any existing socket with the new one, blocking until a connection 
		/// is available.  See {@link DualTransportConnector} for a method of 
		/// connecting two <code>TransportLayer</code>s in a way that avoids deadlock.    
		/// 
		/// </summary>
		/// <seealso cref="Genetibase.NuGenHL7.protocol.StreamSource.connect()">
		/// </seealso>
		public override void  connect()
		{
			Acceptor a = new Acceptor(myServerSocket, myExpectedAddress);
			mySocket = a.waitForSocket();
		}
		
		/// <summary> A thing with which waiting for inbound socket connections can 
		/// be done in a separate thread.  This is needed because we may have to 
		/// start waiting at two ports before pending on either.  Otherwise if 
		/// we accept() in a different order than the remote system connects, 
		/// we will deadlock.  
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.4 $ updated on $Date: 2004/05/31 17:11:58 $ by $Author: bryan_tripp $
		/// </version>
		private class Acceptor
		{
			private class AnonymousClassRunnable : IThreadRunnable
			{
				public AnonymousClassRunnable(Genetibase.NuGenHL7.protocol.impl.NuGenServerSocketStreamSource.Acceptor a, System.Net.Sockets.TcpListener theServer, System.String theAddress, Acceptor enclosingInstance)
				{
					InitBlock(a, theServer, theAddress, enclosingInstance);
				}
				private void  InitBlock(Genetibase.NuGenHL7.protocol.impl.NuGenServerSocketStreamSource.Acceptor a, System.Net.Sockets.TcpListener theServer, System.String theAddress, Acceptor enclosingInstance)
				{
					this.a = a;
					this.theServer = theServer;
					this.theAddress = theAddress;
					this.enclosingInstance = enclosingInstance;
				}
				private Genetibase.NuGenHL7.protocol.impl.NuGenServerSocketStreamSource.Acceptor a;
				private System.Net.Sockets.TcpListener theServer;
				private System.String theAddress;
				private Acceptor enclosingInstance;
				public Acceptor Enclosing_Instance
				{
					get
					{
						return enclosingInstance;
					}
					
				}
				public virtual void  Run()
				{
					while (a.Socket == null)
					{
						System.Net.Sockets.TcpClient s;
						try
						{
							s = theServer.AcceptTcpClient();
                            System.Net.IPEndPoint end = s.Client.RemoteEndPoint as System.Net.IPEndPoint;
                            System.String address = end.Address.ToString();
							if (theAddress == null || address.Equals(theAddress))
							{
								a.Socket = s;
								lock (a)
								{
									System.Threading.Monitor.PulseAll(a);
								}
							}
							else
							{
							}
						}
						catch (System.IO.IOException)
						{
							
							//if there's a problem, don't fill up the log at lightning speed  
							try
							{
								System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 1000));
							}
							catch (System.Threading.ThreadInterruptedException)
							{
							}
						}
					}
				}
			}
			virtual public System.Net.Sockets.TcpClient Socket
			{
				get
				{
					return mySocket;
				}
				
				set
				{
					mySocket = value;
				}
				
			}
			private System.Net.Sockets.TcpClient mySocket;
			
			/// <summary> Starts waiting in a separate thread for connections to the given 
			/// ServerSocket from the given IP address.  
			/// </summary>
			/// <param name="theServer">
			/// </param>
			/// <param name="theAddress">IP address from which to accept connections (null
			/// means any) 
			/// </param>
			public Acceptor(System.Net.Sockets.TcpListener theServer, System.String theAddress)
			{
				Acceptor a = this;
				
				IThreadRunnable r = new AnonymousClassRunnable(a, theServer, theAddress, this);
				
				SupportClass.ThreadClass thd = new SupportClass.ThreadClass(new System.Threading.ThreadStart(r.Run));
				thd.Start();
			}
			
			/// <returns> as getSocket(), but doesn't return until getSocket() returns 
			/// non-null.  
			/// </returns>
			public virtual System.Net.Sockets.TcpClient waitForSocket()
			{
				while (Socket == null)
				{
					try
					{
						lock (this)
						{
							System.Threading.Monitor.Wait(this, TimeSpan.FromMilliseconds(100));
						}
					}
					catch (System.Threading.ThreadInterruptedException)
					{
					}
				}
				return Socket;
			}
			static Acceptor()
			{
			}
		}
	}
}