/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "HL7Server.java".  Description: 
"A TCP/IP based server." 

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
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ApplicationRouter = Genetibase.NuGenHL7.protocol.NuGenApplicationRouter;
using Processor = Genetibase.NuGenHL7.protocol.NuGenProcessor;
using ProcessorContext = Genetibase.NuGenHL7.protocol.NuGenProcessorContext;
using SafeStorage = Genetibase.NuGenHL7.protocol.NuGenSafeStorage;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
using TransportLayer = Genetibase.NuGenHL7.protocol.NuGenTransportLayer;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A TCP/IP based server. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2004/05/31 17:14:20 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenHL7Server
	{
		private class AnonymousClassThread:SupportClass.ThreadClass
		{
			public AnonymousClassThread(System.Collections.IList processors, NuGenHL7Server enclosingInstance)
			{
				InitBlock(processors, enclosingInstance);
			}
			private void  InitBlock(System.Collections.IList processors, NuGenHL7Server enclosingInstance)
			{
				this.processors = processors;
				this.enclosingInstance = enclosingInstance;
			}
			private System.Collections.IList processors;
			private NuGenHL7Server enclosingInstance;
			public NuGenHL7Server Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			override public void  Run()
			{
				try
				{
					System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 1000));
				}
				catch (System.Threading.ThreadInterruptedException)
				{
				}
				
				lock (processors.SyncRoot)
				{                    
					System.Collections.IEnumerator it = processors.GetEnumerator();
                    System.Collections.IList remove = new System.Collections.ArrayList();
					while (it.MoveNext())
					{
						NuGenProcessor proc = (NuGenProcessor) it.Current;
						if (!proc.Context.LocallyDrivenTransportLayer.Connected || !proc.Context.RemotelyDrivenTransportLayer.Connected)
						{
                            //processors.Remove(it.Current);                            
                            remove.Add(it.Current);
						}
					}

                    foreach (object item in remove)
                    {
                        processors.Remove(item);
                    }
				}
			}
		}
		private class AnonymousClassRunnable : IThreadRunnable
		{
			public AnonymousClassRunnable(Genetibase.NuGenHL7.protocol.impl.NuGenHL7Server server, System.String theAddress, NuGenHL7Server enclosingInstance)
			{
				InitBlock(server, theAddress, enclosingInstance);
			}
			private void  InitBlock(Genetibase.NuGenHL7.protocol.impl.NuGenHL7Server server, System.String theAddress, NuGenHL7Server enclosingInstance)
			{
				this.server = server;
				this.theAddress = theAddress;
				this.enclosingInstance = enclosingInstance;
			}
			private Genetibase.NuGenHL7.protocol.impl.NuGenHL7Server server;
			private System.String theAddress;
			private NuGenHL7Server enclosingInstance;
			public NuGenHL7Server Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			public virtual void  Run()
			{
				while (server.Running)
				{
					try
					{
						NuGenProcessor p = server.accept(theAddress);
						server.newProcessor(p);
						System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 1));
					}
					catch (NuGenTransportException)
					{
					}
					catch (System.Threading.ThreadInterruptedException)
					{
					}
				}
			}
		}
		/// <returns> true between when start() returns and when stop() is called.  
		/// </returns>
		virtual public bool Running
		{
			get
			{
				return myIsRunning;
			}
			
		}
		/// <returns> <code>Processor</code>s arising from connections to this server 
		/// </returns>
		virtual public NuGenProcessor[] Processors
		{
			get
			{
				lock (myProcessors.SyncRoot)
				{
                    NuGenProcessor[] retVal = new NuGenProcessor[myProcessors.Count];
                    myProcessors.CopyTo(retVal, 0);

                    return retVal;
				}
			}
			
		}
		
		private System.Net.Sockets.TcpListener myServerSocket;
		private System.Net.Sockets.TcpListener myServerSocket2;
		private NuGenApplicationRouter myRouter;
		private NuGenSafeStorage myStorage;
		
		private bool myIsRunning = false;
		private System.Collections.IList myProcessors;
		
		/// <param name="theServerSocket">a ServerSocket on which to listen for connections that will
		/// be used for both locally-driven and remotely-driven message exchanges
		/// </param>
		/// <param name="theRouter">used to send incoming messages to appropriate <code>Application</code>s
		/// </param>
		/// <param name="theStorage">used to commit incoming messages to safe storage before returning 
		/// an accept ACK 
		/// </param>
		public NuGenHL7Server(System.Net.Sockets.TcpListener theServerSocket, NuGenApplicationRouter theRouter, NuGenSafeStorage theStorage)
		{
			myServerSocket = theServerSocket;
			myRouter = theRouter;
			myStorage = theStorage;
			initProcessorList();
		}
		
		/// <param name="theLocallyDriven">a ServerSocket on which to listen for connections that will
		/// be used for locally-initiated message exchanges
		/// </param>
		/// <param name="theRemotelyDriven">a ServerSocket on which to listen for connections that will
		/// be used for remotely-initiated message exchanges
		/// </param>
		/// <param name="theRouter">used to send incoming messages to appropriate <code>Application</code>s
		/// </param>
		/// <param name="theStorage">used to commit incoming messages to safe storage before returning 
		/// an accept ACK 
		/// </param>
		public NuGenHL7Server(System.Net.Sockets.TcpListener theLocallyDriven, System.Net.Sockets.TcpListener theRemotelyDriven, NuGenApplicationRouter theRouter, NuGenSafeStorage theStorage)
		{
			
			myServerSocket = theLocallyDriven;
			myServerSocket2 = theRemotelyDriven;
			myRouter = theRouter;
			myStorage = theStorage;
			initProcessorList();
		}
		
		//creates list and starts thread to clean dead processors from it     
		private void  initProcessorList()
		{
			myProcessors = new System.Collections.ArrayList();
			
			System.Collections.IList processors = myProcessors;
			SupportClass.ThreadClass cleaner = new AnonymousClassThread(processors, this);
			cleaner.Start();
		}
		
		/// <summary> Accepts a single inbound connection if the same ServerSocket is used for 
		/// all message exchanges, or a connection from each if two ServerSockets are 
		/// being used. 
		/// 
		/// </summary>
		/// <param name="theAddress">the IP address from which to accept connections (null means 
		/// accept from any address).  Connection attempts from other addresses will 
		/// be ignored.  
		/// </param>
		/// <returns> a <code>Processor</code> connected to the given address  
		/// </returns>
		/// <throws>  TransportException </throws>
		public virtual NuGenProcessor accept(System.String theAddress)
		{
			NuGenTransportLayer transport = getTransport(myServerSocket, theAddress);
			NuGenProcessorContext context = null;
			
			if (myServerSocket2 == null)
			{
				//we're doing inbound & outbound on the same port
				transport.connect();
				context = new NuGenProcessorContextImpl(myRouter, transport, myStorage);
			}
			else
			{
				NuGenTransportLayer transport2 = getTransport(myServerSocket2, theAddress);
				NuGenDualTransportConnector connector = new NuGenDualTransportConnector(transport, transport2);
				connector.connect();
				
				context = new NuGenProcessorContextImpl(myRouter, transport, transport2, myStorage);
			}
			return new NuGenProcessorImpl(context, true);
		}
		
		private static NuGenTransportLayer getTransport(System.Net.Sockets.TcpListener theServerSocket, System.String theAddress)
		{
			NuGenServerSocketStreamSource ss = new NuGenServerSocketStreamSource(theServerSocket, theAddress);
			return new NuGenMLLPTransport(ss);
		}
		
		/// <summary> Starts accepting connections in a new Thread.  Note that this can be 
		/// called multiple times with separate addresses.  The stop() method ends
		/// all Threads started here.  
		/// 
		/// </summary>
		/// <param name="theAddress">IP address from which connections are accepted (null 
		/// means any address is OK) 
		/// </param>
		public virtual void  start(System.String theAddress)
		{
			NuGenHL7Server server = this;
			IThreadRunnable acceptor = new AnonymousClassRunnable(server, theAddress, this);
			
			myIsRunning = true;
			
			SupportClass.ThreadClass thd = new SupportClass.ThreadClass(new System.Threading.ThreadStart(acceptor.Run));
			thd.Start();
		}
		
		private void  newProcessor(NuGenProcessor theProcessor)
		{
			lock (myProcessors.SyncRoot)
			{
				myProcessors.Add(theProcessor);
			}
		}
		
		/// <summary> Stops running after the next connection is made. </summary>
		public virtual void  stop()
		{
			myIsRunning = false;
		}
		
		/// <summary> </summary>
		/// <param name="theUrlSpec">a string specifying an URL, which can optionally begin with "classpath:" 
		/// </param>
		/// <returns> the resource specified after "classpath:", if that's how it starts, otherwise 
		/// new URL(theUrlSpec) 
		/// </returns>
		/// <throws>  MalformedURLException </throws>
		private static System.Uri getURL(System.String theUrlSpec)
		{
			return new System.Uri(theUrlSpec);
		}
		
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length < 1 || args.Length > 3)
			{
				System.Console.Out.WriteLine("Usage: HL7Server (shared_port | (locally_driven_port remotely_driven_port)) app_binding_URL");
				System.Environment.Exit(1);
			}
			
			NuGenSafeStorage storage = new NuGenNullSafeStorage();
			NuGenApplicationRouter router = new NuGenApplicationRouterImpl();
			
			try
			{
				NuGenHL7Server server = null;
				System.String appURL = null;
				if (args.Length == 2)
				{
					int port = System.Int32.Parse(args[0]);
					System.Net.Sockets.TcpListener temp_tcpListener;
					temp_tcpListener = new System.Net.Sockets.TcpListener(System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0], port);
					temp_tcpListener.Start();
					server = new NuGenHL7Server(temp_tcpListener, router, storage);
					appURL = args[1];
				}
				else
				{
					int localPort = System.Int32.Parse(args[0]);
					int remotePort = System.Int32.Parse(args[1]);
					System.Net.Sockets.TcpListener temp_tcpListener2;
					temp_tcpListener2 = new System.Net.Sockets.TcpListener(System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0], localPort);
					temp_tcpListener2.Start();
					System.Net.Sockets.TcpListener temp_tcpListener3;
					temp_tcpListener3 = new System.Net.Sockets.TcpListener(System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0], remotePort);
					temp_tcpListener3.Start();
					server = new NuGenHL7Server(temp_tcpListener2, temp_tcpListener3, router, storage);
					appURL = args[2];
				}
				
				NuGenApplicationLoader.loadApplications(router, getURL(appURL));
				
				server.start(null); //any address OK            
			}
			catch (System.FormatException)
			{
				System.Console.Out.WriteLine("Port arguments must be integers");
				System.Environment.Exit(2);
			}
			catch (System.IO.IOException e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
				System.Environment.Exit(3);
			}
			catch (NuGenHL7Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
				System.Environment.Exit(4);
			}
			catch (System.UnauthorizedAccessException e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
				System.Environment.Exit(7);
			}
		}
		static NuGenHL7Server()
		{
		}
	}
}