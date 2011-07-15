/*
* Created on 15-Apr-2004
*/
using System;
using StreamSource = Genetibase.NuGenHL7.protocol.NuGenStreamSource;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A base implementation of <code>StreamSource</code> based on sockets. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2004/05/24 16:44:12 $ by $Author: bryan_tripp $
	/// </version>
	public abstract class NuGenSocketStreamSource : NuGenStreamSource
	{
		/// <returns> the stream to which we write outbound messages.   
		/// </returns>
		virtual public System.IO.Stream OutboundStream
		{
			get
			{
				checkConnected();
				try
				{
					return getSocket().GetStream();
				}
				catch (System.IO.IOException e)
				{
					throw new NuGenTransportException(e);
				}
			}
			
		}
		private bool Connected
		{
			get
			{
				bool is_Renamed = false;
				if (getSocket() != null && getSocket().Connected && getSocket().Connected)
				{
					is_Renamed = true;
				}
				return is_Renamed;
			}
			
		}
		/// <returns> the stream to which we expect the remote server to send messages.  
		/// </returns>
		virtual public System.IO.Stream InboundStream
		{
			get
			{
				checkConnected();
				try
				{
					return getSocket().GetStream();
				}
				catch (System.IO.IOException e)
				{
					throw new NuGenTransportException(e);
				}
			}
			
		}
		
		/// <returns> a socket from which input and output streams for message exchages 
		/// are to be obtained    
		/// </returns>
		public abstract System.Net.Sockets.TcpClient getSocket();
		
		/// <summary> Gets fresh instance of socket, which is subsequently available 
		/// from <code>getSocket()</code>.  
		/// </summary>
		public abstract void  connect();
		
		/// <summary> Closes streams and underlying socket. </summary>
		/// <seealso cref="Genetibase.NuGenHL7.protocol.StreamSource.disconnect()">
		/// </seealso>
		public virtual void  disconnect()
		{
			try
			{
				if (Connected)
				{
					OutboundStream.Close();
					InboundStream.Close();
					getSocket().Close();
				}
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException(e);
			}
		}
		
		private void  checkConnected()
		{
			if (!Connected)
			{
				throw new NuGenTransportException("The socket is not connected");
			}
		}
	}
}