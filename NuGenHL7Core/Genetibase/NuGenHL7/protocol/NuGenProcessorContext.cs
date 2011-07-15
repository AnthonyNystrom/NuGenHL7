/*
* Created on 16-Apr-2004
*/
using System;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> The operational context of a <code>Processor</code>.  This defines 
	/// certain resources that are not part of the <code>Processor</code>, 
	/// but are needed in order to implement it, and may vary between  
	/// deployments.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2004/05/24 16:20:53 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenProcessorContext
	{
		/// <returns> the router that directs unsolicited inbound messages to 
		/// the appropriate <code>Application</code>  
		/// </returns>
		NuGenApplicationRouter Router
		{
			get;
			
		}
		/// <returns> the object responsible for transport of remotely initiated message 
		/// exchanges (normally with a remote server)
		/// </returns>
		NuGenTransportLayer RemotelyDrivenTransportLayer
		{
			get;
			
		}
		/// <returns> the object responsible for transport of locally initiated message 
		/// exchanges (normally with a remote server)
		/// </returns>
		NuGenTransportLayer LocallyDrivenTransportLayer
		{
			get;
			
		}
		/// <returns> the validators that determine whether a message can be 
		/// accepted for routing to the appropriate application 
		/// </returns>
		NuGenAcceptValidator[] Validators
		{
			get;
			
		}
		/// <returns> a store for messages while they are being routed to the 
		/// appropriate application 
		/// </returns>
		NuGenSafeStorage SafeStorage
		{
			get;
			
		}
		/// <summary> Returns the list of fields that are to be included as metadata whenever a <code>Message</code>
		/// is converted to a <code>Transportable</code>.  Each field is a String <code>Terser</code>
		/// path.  
		/// 
		/// </summary>
		/// <param name="theMetadataFields">list of <code>Terser</code> paths of metadata fields 
		/// </param>
		System.Collections.IList MetadataFields
		{
			get;
			
		}
		
		/// <summary> Adds a new validator to the list of those returned by 
		/// <code>getValidators()</code>.  
		/// 
		/// </summary>
		/// <param name="theValidator">the validator to add 
		/// </param>
		void  addValidator(NuGenAcceptValidator theValidator);
	}
}