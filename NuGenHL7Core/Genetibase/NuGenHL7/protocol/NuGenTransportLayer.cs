/*
* Created on 15-Apr-2004
*/
using System;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> Encapsulates the transport layer of a connection to another 
	/// HL7 server.  This is the layer responsible for sending and receiving 
	/// message strings.  The underlying protocol used is implementation
	/// dependent, that is there may be transport layers that are implemented 
	/// over email, or JMS, or HTTP.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2004/05/24 16:22:16 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenTransportLayer
	{
		/// <returns> metadata to be added to the metadata of all incoming messages.  
		/// This provides a way of associating connection information with  
		/// incoming messages (eg the IP address of the remote server).
		/// </returns>
		System.Collections.IDictionary CommonMetadata
		{
			get;
			
		}
		/// <returns> true if connect() has completed successfully.  Note that true 
		/// may be returned even if a connection is dead (ie the implementation need 
		/// not test a connection during this call) but should return false if connect()
		/// has not been called, or if connect() has been called and is pending.  
		/// </returns>
		bool Connected
		{
			get;
			
		}
		
		/// <summary> Sends a message to a remote HL7 service.
		/// 
		/// </summary>
		/// <param name="theMessage">the message to send 
		/// </param>
		/// <throws>  TransportException </throws>
		void  send(NuGenTransportable theMessage);
		
		/// <summary> Gets the next message from the remote system.  This call blocks until
		/// the next message is available.  
		/// 
		/// </summary>
		/// <returns> the next available message 
		/// </returns>
		/// <throws>  TransportException </throws>
		NuGenTransportable receive();
		
		/// <summary> Initializes a connection to the remote server.  This can be called after 
		/// an exception is encountered, to refresh a dead connection.  
		/// </summary>
		/// <throws>  TransportException </throws>
		void  connect();
		
		/// <summary> Drops any existing connection to the remote server.  </summary>
		/// <throws>  TransportException </throws>
		void  disconnect();
	}
}