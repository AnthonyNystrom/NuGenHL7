/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "TwoPortService.java".  Description: 
/// "A TCP/IP-based HL7 Service that uses separate ports for inbound and outbound messages." 
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
using LLPException = Genetibase.NuGenHL7.llp.NuGenLLPException;
using LowerLayerProtocol = Genetibase.NuGenHL7.llp.NuGenLowerLayerProtocol;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> A TCP/IP-based HL7 Service that uses separate ports for inbound and outbound messages.
	/// A connection is only activated when the same remote host connects to both the 
	/// inbound and outbound ports.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenTwoPortService:NuGenHL7Service
	{
		private System.Collections.ArrayList inSockets; //Vector because it's synchronized 
		private System.Collections.ArrayList outSockets;
		private int inboundPort;
		private int outboundPort;
		
		/// <summary>Creates a new instance of TwoPortService </summary>
		public NuGenTwoPortService(Parser parser, LowerLayerProtocol llp, int inboundPort, int outboundPort):base(parser, llp)
		{
			inSockets = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(20));
			outSockets = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(20));
			this.inboundPort = inboundPort;
			this.outboundPort = outboundPort;
		}
		
		/// <summary> Initially sets up server sockets and starts separate threads to accept connections 
		/// on them.  Then loops, calling this.accept() super.newConnection().   
		/// </summary>
		public override void Run()
		{
			try
			{
				AcceptThread inAccept = new AcceptThread(this, inboundPort, inSockets);
				AcceptThread outAccept = new AcceptThread(this, outboundPort, outSockets);
				SupportClass.ThreadClass inThread = new SupportClass.ThreadClass(new System.Threading.ThreadStart(inAccept.Run));
				SupportClass.ThreadClass outThread = new SupportClass.ThreadClass(new System.Threading.ThreadStart(outAccept.Run));
				inThread.Start();
				outThread.Start();
				
				while (keepRunning())
				{
					NuGenConnection conn = accept(3000);
					if (conn != null)
					{
						newConnection(conn);
					}
				}
				
				inAccept.stop();
				outAccept.stop();
			}
			catch (System.Exception)
			{
			}
		}
		
		/// <summary> Returns a Connection based on an inbound and outbound connection pair from 
		/// the same remote host.  This is done by looping through all the connections
		/// trying to match the host addresses of all posible inbound and outbound 
		/// pairs.  When a matching pair is found, both sockets are removed from the 
		/// pending sockets lists, so there should normally be a very small number of 
		/// sockets to search through.  This method will return null if the specified 
		/// number of milliseconds has passed, otherwise will wait until a single remote 
		/// host has connected to both the inbound and outbound ports.  
		/// </summary>
		private NuGenConnection accept(long timeoutMillis)
		{
			long startTime = (System.DateTime.Now.Ticks - 621355968000000000) / 10000;
			NuGenConnection conn = null;
			while (conn == null && (System.DateTime.Now.Ticks - 621355968000000000) / 10000 < startTime + timeoutMillis)
			{
				int i = 0;
				while (conn == null && i < inSockets.Count)
				{
					System.Net.Sockets.TcpClient in_Renamed = (System.Net.Sockets.TcpClient) inSockets[i];
					int j = 0;
					while (conn == null && j < outSockets.Count)
					{
						System.Net.Sockets.TcpClient out_Renamed = (System.Net.Sockets.TcpClient) outSockets[j];
                        System.Net.IPEndPoint end = out_Renamed.Client.RemoteEndPoint as System.Net.IPEndPoint;
                        System.Net.IPEndPoint endin = in_Renamed.Client.RemoteEndPoint as System.Net.IPEndPoint;
                        if (end.Address.Equals(endin.Address))
						{
							conn = new NuGenConnection(parser, llp, in_Renamed, out_Renamed);
							inSockets.RemoveAt(i);
							outSockets.RemoveAt(j);
						}
						j++;
					}
					i++;
				}
				try
				{
					System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 10));
				}
				catch (System.Threading.ThreadInterruptedException)
				{
				}
			}
			return conn;
		}
		
		/// <summary> A Runnable that accepts connections on a ServerSocket and adds them to 
		/// a Vector, so that they can be matched later.  After stop() is called, the 
		/// ServerSocket is closed.
		/// </summary>
		private class AcceptThread : IThreadRunnable
		{
			private void  InitBlock(NuGenTwoPortService enclosingInstance)
			{
				this.enclosingInstance = enclosingInstance;
			}
			private NuGenTwoPortService enclosingInstance;
			public NuGenTwoPortService Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			
			private System.Net.Sockets.TcpListener ss;
			private System.Collections.ArrayList sockets;
			private bool keepRunning = true;
			
			public AcceptThread(NuGenTwoPortService enclosingInstance, int port, System.Collections.ArrayList sockets)
			{
				InitBlock(enclosingInstance);
				System.Net.Sockets.TcpListener temp_tcpListener;
				temp_tcpListener = new System.Net.Sockets.TcpListener(System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0], port);
				temp_tcpListener.Start();
				ss = temp_tcpListener;
				this.sockets = sockets;
			}
			
			public virtual void  Run()
			{
				try
				{
					while (keepRunning)
					{
						try
						{
							System.Net.Sockets.TcpClient s = ss.AcceptTcpClient();
							sockets.Add(s);
						}
						catch (System.IO.IOException)
						{
							/* OK - just timed out */
						}
					}
					ss.Stop();
				}
				catch (System.Exception)
				{
				}
			}
			
			public virtual void  stop()
			{
				keepRunning = false;
			}
		}
		
		/// <summary> Run server from command line.  Inbound and outbound port numbers should be provided as arguments,
		/// and a file containing a list of Applications to use can also be specified
		/// as an optional argument (as per <code>super.loadApplicationsFromFile(...)</code>).
		/// Uses the default LowerLayerProtocol.
		/// </summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length < 2 || args.Length > 3)
			{
				System.Console.Out.WriteLine("Usage: Genetibase.NuGenHL7.app.TwoPortService inbound_port outbound_port [application_spec_file_name]");
				System.Environment.Exit(1);
			}
			
			int inPort = 0;
			int outPort = 0;
			try
			{
				inPort = System.Int32.Parse(args[0]);
				outPort = System.Int32.Parse(args[1]);
			}
			catch (System.FormatException)
			{
				System.Console.Error.WriteLine("One of the given ports (" + args[0] + " or " + args[1] + ") is not an integer.");
				System.Environment.Exit(1);
			}
			
			System.IO.FileInfo appFile = null;
			if (args.Length == 3)
			{
				appFile = new System.IO.FileInfo(args[2]);
			}
			
			try
			{
				NuGenTwoPortService server = new NuGenTwoPortService(new PipeParser(), LowerLayerProtocol.makeLLP(), inPort, outPort);
				if (appFile != null)
					server.loadApplicationsFromFile(appFile);
				server.start();
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static NuGenTwoPortService()
		{
		}
	}
}