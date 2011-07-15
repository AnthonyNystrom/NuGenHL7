/*
* Created on 19-Apr-2004
*/
using System;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> Default implementation of <code>Transportable</code>. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/19 23:07:50 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenTransportableImpl : NuGenTransportable
	{
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Transportable.getMessage()">
		/// </seealso>
		virtual public System.String Message
		{
			get
			{
				return myMessageText;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Transportable.getMetadata()">
		/// </seealso>
		virtual public System.Collections.IDictionary Metadata
		{
			get
			{
				return myMetadata;
			}
			
		}
		
		private System.String myMessageText;
		private System.Collections.IDictionary myMetadata;
		
		/// <summary> Creates a new instance with no associated metadata (metadata can 
		/// be added later using <code>getMetadata()</code>. 
		/// 
		/// </summary>
		/// <param name="theMessageText">the text of an HL7 message 
		/// </param>
		public NuGenTransportableImpl(System.String theMessageText)
		{
			myMessageText = theMessageText;
			myMetadata = new System.Collections.Hashtable();
		}
		
		/// <summary> Creates a new instance with specified metadata (further metadata can   
		/// be added later using <code>getMetadata()</code>. 
		/// 
		/// </summary>
		/// <param name="theMessageText">the text of an HL7 message 
		/// </param>
		/// <param name="theMetadata">metadata associated with the message (typical examples 
		/// would be selected field values for routing) 
		/// </param>
		public NuGenTransportableImpl(System.String theMessageText, System.Collections.IDictionary theMetadata)
		{
			myMessageText = theMessageText;
			myMetadata = theMetadata;
		}
	}
}