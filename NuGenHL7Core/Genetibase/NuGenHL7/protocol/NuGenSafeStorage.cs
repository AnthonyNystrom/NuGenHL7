/*
* Created on 16-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> Represents a persistent store for incoming messages.  Messages 
	/// may be stored here before an accept ACK is returned.  The local
	/// side of the interface then takes on responsibility for delivering 
	/// the message to the application.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/19 22:08:24 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenSafeStorage
	{
		
		/// <summary> Stores a message so that it can be reliably retrieved and sent to 
		/// the proper application, even if this service is restarted in the mean
		/// time.
		/// 
		/// </summary>
		/// <param name="theMessage">the message to store 
		/// </param>
		/// <throws>  HL7Exception if there is some problem accessing the store </throws>
		void  store(NuGenTransportable theMessage);
		
		/// <summary> If the given message exists in the store, it is removed.
		/// 
		/// </summary>
		/// <param name="theMessage">the message to discard
		/// </param>
		/// <throws>  HL7Exception if there is some problem accessing the store </throws>
		void  discard(NuGenTransportable theMessage);
		
		/// <summary> Returns all messages that have been stored.  The store retains a copy 
		/// of each one until discard() is called.  This method would be called 
		/// after the HL7 server is restarted.
		/// 
		/// </summary>
		/// <returns> all messages in the store 
		/// </returns>
		/// <throws>  HL7Exception if there is some problem accessing the store </throws>
		NuGenTransportable[] restore();
	}
}