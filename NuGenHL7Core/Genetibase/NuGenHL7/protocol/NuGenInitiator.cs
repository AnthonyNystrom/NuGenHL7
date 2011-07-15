/*
* Created on 16-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> <p>A convenient way for the initiator of a message exchange to send a 
	/// message to a remote server and await the response in the same thread.</p>  
	/// 
	/// <p>Acknowledgements, threading, and accept-level retries are handled by 
	/// an associated <code>Processor</code>.</p>
	/// 
	/// <p>Recall that acknowledgement requirements are specified in MSH fields 15 
	/// and 16 (see HL7 v2.5 chapter 2), so the sender has control.  If no response is 
	/// needed, and you would like this call to return right away, specify that no 
	/// acknowledgements are required.</p> 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2004/05/06 03:00:24 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenInitiator
	{
		/// <returns> the <code>Parser</code> that is used to encode outbound messages
		/// and parse inbound ones.  It may be of interest to set certain parameters 
		/// of this parser, for example whether to use XML encoding.   
		/// </returns>
		Parser Parser
		{
			get;
			
		}
		/// <returns> the <code>Processor</code> instance that is used to perform the message
		/// exchange   
		/// </returns>
		NuGenProcessor UnderlyingProcessor
		{
			get;
			
		}
		/// <returns> the list of fields that will be included as metadata when a <code>Message</code>
		/// is converted to a <code>Transportable</code>.  Each field is a <code>Terser</code>
		/// path (type String).  
		/// </returns>
		System.Collections.IList MetadataFields
		{
			get;
			
		}
		
		/// <summary> Encodes a message, sends it to a remote system, awaits the response, 
		/// parses it, and returns it.  The response may be null if the message doesn't 
		/// require an application-level acknowledgement.   
		/// 
		/// </summary>
		/// <param name="theMessage">the message to send to the remote system
		/// </param>
		/// <returns> the response from the remote system 
		/// </returns>
		Message sendAndReceive(Message theMessage);
	}
}