/*
* Created on 15-Apr-2004
*/
using System;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> An HL7 message in text form, with optional metadata, which can 
	/// be handled in a transport layer. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/19 22:08:24 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenTransportable
	{
		/// <returns> the text of an HL7 message (either ER7 or XML encoding).
		/// </returns>
		System.String Message
		{
			get;
			
		}
		/// <returns> metadata associated with the message.  If the message is being 
		/// sent to a <code>TransportLayer</code>, this may include selected message fields
		/// (eg to facilitate routing based on MSH fields without re-parsing the   
		/// message).  If the message is being received, this may include 
		/// information such as the IP address of the server from which the message 
		/// was received (this depends on the underlying <code>TransportLayer</code> used).  
		/// Message fields are keyed with <code>Terser</code> path names.  
		/// </returns>
		System.Collections.IDictionary Metadata
		{
			get;
			
		}
	}
}