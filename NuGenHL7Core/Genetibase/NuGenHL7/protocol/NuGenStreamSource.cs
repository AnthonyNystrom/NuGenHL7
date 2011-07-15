/*
* Created on 16-Apr-2004
*/
using System;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> A source of input and output streams for use with stream-based 
	/// <code>TransportLayer</code>s.  Implementations should contain the 
	/// necessary information for reconnecting streams as necessary.  For 
	/// example a ServerSocket-based implementation should be able to listen  
	/// for fresh connections and get new streams from them (this must be 
	/// done when refresh() is called).  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2004/05/24 16:21:43 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenStreamSource
	{
		/// <returns> the stream to which we write outbound messages.   
		/// </returns>
		/// <throws>  TransportException </throws>
		System.IO.Stream OutboundStream
		{
			get;
			
		}
		/// <returns> the stream to which we expect the remote server to send messages.  
		/// </returns>
		/// <throws>  TransportException </throws>
		System.IO.Stream InboundStream
		{
			get;
			
		}
		
		/// <summary> Gets new streams.  This should be called only if one of the streams 
		/// is dead.  
		/// </summary>
		/// <throws>  TransportException </throws>
		void  connect();
		
		/// <summary> Closes streams and underlying connections.  </summary>
		/// <throws>  TransportException </throws>
		void  disconnect();
	}
}