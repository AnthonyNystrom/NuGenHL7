/*
* Created on 16-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> Routes messages to the appropriate application.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2005/05/16 18:13:08 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenApplicationRouter
	{
		/// <returns> the <code>Parser</code> that is used to parse inbound messages
		/// and encode outbound ones.  It may be of interest to set certain parameters 
		/// of this parser.     
		/// </returns>
		Parser Parser
		{
			get;
			
		}
		
		/// <summary> Attempts to route the given message to the associated <code>Application</code>  
		/// and obtain a response.  
		/// 
		/// </summary>
		/// <param name="theMessage">the message to route 
		/// </param>
		/// <returns> the response message (this may be null, for example if the given 
		/// message doesn't require an application ACK)
		/// </returns>
		NuGenTransportable processMessage(NuGenTransportable theMessage);
		
		/// <param name="theRoutingData">message fields used in determining the appropriate destination  
		/// </param>
		/// <returns> true if there is a destination application for messages with the given
		/// characteristics  
		/// </returns>
		bool hasActiveBinding(AppRoutingData theRoutingData);
		
		/// <summary> <p>Associates the given application with the given message parameters, so that messages
		/// with matching parameters will be sent there.  Only one application can be registered 
		/// for a given set of parameters: repeated registration for a particular combination 
		/// over-writes the previous one.</p>  
		/// 
		/// <p>Because of wildcards, there may be multiple registrations that match a given message.  
		/// In this case, the first registered wins.</p>  
		/// 
		/// </summary>
		/// <param name="theRoutingData">message fields used in determining the appropriate destination  
		/// </param>
		/// <param name="theApplication">the application to which messages with these parameters should be 
		/// sent 
		/// </param>
		void  bindApplication(AppRoutingData theRoutingData, NuGenReceivingApplication theApplication);
		
		/// <summary> Temporarily deactivates the binding on the given field data, if present.  </summary>
		/// <param name="theRoutingData">the fields that define a set of messages that are bound to 
		/// some <code>Application</code>  
		/// </param>
		void  disableBinding(AppRoutingData theRoutingData);
		
		/// <summary> Undoes <code>disableBinding(AppRoutingData theRoutingData)</code>.    </summary>
		/// <param name="theRoutingData">the fields that define a set of messages that are bound to 
		/// some <code>Application</code>  
		/// </param>
		void  enableBinding(AppRoutingData theRoutingData);
		
	}
	/// <summary> <p>Encapsulates the message fields used for routing of messages from the 
	/// HL7 protocol to the appropriate <code>Application</code>. </p>   
	/// 
	/// <p>The wildcard "*" in any member indicates all values of the associated parameter.  For 
	/// example the conbination "ADT", "*", "*", "*" means all ADT messages.  Each value can also
	/// be a regular expression that is matched against the corresponding field.  </p>
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2005/05/16 18:13:08 $ by $Author: bryan_tripp $
	/// </version>
	public interface AppRoutingData
	{
		/// <returns> MSH-9-1
		/// </returns>
		System.String MessageType
		{
			get;
			
		}
		/// <returns> MSH-9-2
		/// </returns>
		System.String TriggerEvent
		{
			get;
			
		}
		/// <returns> MSH-11-1
		/// </returns>
		System.String ProcessingId
		{
			get;
			
		}
		/// <returns> MSH-12
		/// </returns>
		System.String Version
		{
			get;
			
		}
	}
}