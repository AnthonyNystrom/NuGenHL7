/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "SimpleServer.java".  Description:
/// "A simple TCP/IP-based HL7 server."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2002.  All Rights Reserved.
/// 
/// Contributor(s): Kyle Buza
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
using LowerLayerProtocol = Genetibase.NuGenHL7.llp.NuGenLowerLayerProtocol;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> <p>A simple TCP/IP-based HL7 server.  This server listens for connections
	/// on a particular port, and creates a ConnectionManager for each incoming
	/// connection.  </p>
	/// <p>A single SimpleServer can only service requests that use a
	/// single class of LowerLayerProtocol (specified at construction time).</p>
	/// <p>The ConnectionManager uses a PipeParser of the version specified in
	/// the constructor</p>
	/// <p>ConnectionManagers currently only support original mode processing.</p>
	/// <p>The ConnectionManager routes messages to various "Application"s based on
	/// message type.  From the HL7 perspective, an Application is something that
	/// does something with a message.</p>
	/// </summary>
	/// <author>   Bryan Tripp
	/// </author>
	public class NuGenSimpleServer:NuGenHL7Service
	{
		private int port;
		
		/// <summary> Creates a new instance of SimpleServer that listens
		/// </summary>
		public NuGenSimpleServer(int port, LowerLayerProtocol llp, Parser parser):base(parser, llp)
		{
			this.port = port;
		}

        System.Net.Sockets.TcpListener ss;

        public override void stop()
        {
            base.stop();

            ss.Stop();
        }
		
		/// <summary> Loop that waits for a connection and starts a ConnectionManager
		/// when it gets one.
		/// </summary>
		public override void  Run()
		{
			try
			{
				System.Net.Sockets.TcpListener temp_tcpListener;                
				temp_tcpListener = new System.Net.Sockets.TcpListener(System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[0], port);
				temp_tcpListener.Start();
                ss = temp_tcpListener;
				while (keepRunning())
				{
					try
					{                        
						System.Net.Sockets.TcpClient newSocket = ss.AcceptTcpClient();						
						NuGenConnection conn = new NuGenConnection(parser, this.llp, newSocket);
						newConnection(conn);
					}
					catch (System.IO.IOException)
					{
						//ignore - just timed out waiting for connection
					}
					catch (System.Exception)
					{
					}
				}
				
				ss.Stop();
			}
			catch (System.Exception)
			{
			}
			finally
			{
				//Bug 960113:  Make sure HL7Service.stop() is called to stop ConnectionCleaner thread.
				this.stop();
			}
		}
		
		/// <summary> Run server from command line.  Port number should be passed as an argument,
		/// and a file containing a list of Applications to use can also be specified
		/// as an optional argument (as per <code>loadApplicationsFromFile(...)</code>).
		/// Uses the default LowerLayerProtocol.
		/// </summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length < 1 || args.Length > 2)
			{
				System.Console.Out.WriteLine("Usage: Genetibase.NuGenHL7.app.SimpleServer port_num [application_spec_file_name]");
				System.Environment.Exit(1);
			}
			
			int port = 0;
			try
			{
				port = System.Int32.Parse(args[0]);
			}
			catch (System.FormatException)
			{
				System.Console.Error.WriteLine("The given port (" + args[0] + ") is not an integer.");
				System.Environment.Exit(1);
			}
			
			System.IO.FileInfo appFile = null;
			if (args.Length == 2)
			{
				appFile = new System.IO.FileInfo(args[1]);
			}
			
			try
			{
				NuGenSimpleServer server = new NuGenSimpleServer(port, LowerLayerProtocol.makeLLP(), new PipeParser());
				if (appFile != null)
					server.loadApplicationsFromFile(appFile);
				server.start();
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static NuGenSimpleServer()
		{
		}
	}
}