/*
* Created on 19-Apr-2004
*/
using System;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
using System.Net;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A client-side <code>SocketStreamSource</code>.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2004/05/17 19:28:54 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenClientSocketStreamSource:NuGenSocketStreamSource
	{
		
		private String myAddress;
		private System.Net.Sockets.TcpClient mySocket;
        private int myPort;

        public int Port
        {
            get
            {
                return myPort;
            }
        }
		
		/// <param name="theSharedAddress">the address at which to connect sockets 
		/// </param>
		/// <throws>  TransportException </throws>
		public NuGenClientSocketStreamSource(String theAddress, int port)
		{
			myAddress = theAddress;
            myPort = port;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.impl.SocketStreamSource.getSocket()">
		/// </seealso>
		public override System.Net.Sockets.TcpClient getSocket()
		{
			return mySocket;
		}
		
		/// <summary> Gets fresh instances of sockets.  </summary>
		public override void  connect()
		{
			mySocket = getSocket(myAddress, myPort);
		}
		
		private System.Net.Sockets.TcpClient getSocket(String theAddress, int port)
		{
			System.Net.Sockets.TcpClient s = new System.Net.Sockets.TcpClient();
			try
			{
                s.Connect(theAddress, port);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException(e);
			}
			return s;
		}
	}
}