/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "AbstactTransport.java".  Description: 
"A base implementation of TransportLayer." 

The Initial Developer of the Original Code is University Health Network. Copyright (C) 
2004.  All Rights Reserved. 

Contributor(s): ______________________________________. 

Alternatively, the contents of this file may be used under the terms of the 
GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
applicable instead of those above.  If you wish to allow use of your version of this 
file only under the terms of the GPL and not to allow others to use your version 
of this file under the MPL, indicate your decision by deleting  the provisions above 
and replace  them with the notice and other provisions required by the GPL License.  
If you do not delete the provisions above, a recipient may use your version of 
this file under either the MPL or the GPL. */
using System;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
using TransportLayer = Genetibase.NuGenHL7.protocol.NuGenTransportLayer;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A base implementation of <code>TransportLayer</code> which looks after the 
	/// addition of common metadata to each inbound <code>Transportable</code>.
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.5 $ updated on $Date: 2004/05/31 17:06:22 $ by $Author: bryan_tripp $
	/// </version>
	public abstract class NuGenAbstractTransport : NuGenTransportLayer
	{
		/// <seealso cref="Genetibase.NuGenHL7.protocol.TransportLayer.getCommonMetadata()">
		/// </seealso>
		virtual public System.Collections.IDictionary CommonMetadata
		{
			get
			{
				return myCommonMetadata;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.TransportLayer.isConnected()">
		/// </seealso>
		virtual public bool Connected
		{
			get
			{
				return myIsConnected;
			}
			
		}
		private System.Collections.IDictionary myCommonMetadata;
		private bool myIsConnected = false;
		
		public NuGenAbstractTransport()
		{
			myCommonMetadata = new System.Collections.Hashtable();
		}
		
		/// <summary> Delegates to <code>doReceive()</code> and adds common metadata
		/// to the resulting <code>Transportable</code> before it is returned.
		/// </summary>
		public virtual NuGenTransportable receive()
		{
			if (!Connected)
			{
				throw new NuGenTransportException("Can't receive because TransportLayer is not connected");
			}
			
			NuGenTransportable message = doReceive();
			if (message != null)
			{
				SupportClass.MapSupport.PutAll(message.Metadata, myCommonMetadata);
			}
			
			
			return message;
		}
		
		/// <summary> Called by receive(), which then adds common metadata.   
		/// 
		/// </summary>
		/// <returns> Transportable the next available message 
		/// </returns>
		/// <throws>  TransportException </throws>
		public abstract NuGenTransportable doReceive();
		
		/// <summary> Delegates to <code>doSend()</code> after checking that we are connected. 
		/// 
		/// </summary>
		/// <seealso cref="Genetibase.NuGenHL7.protocol.TransportLayer.send(Transportable)">
		/// </seealso>
		public virtual void  send(NuGenTransportable theMessage)
		{
			if (!Connected)
			{
				throw new NuGenTransportException("Can't send because TransportLayer is not connected");
			}
			
			doSend(theMessage);
			
		}
		
		/// <summary> The method send() delegates to this method after checking whether we are 
		/// connected.   
		/// </summary>
		/// <param name="theMessage">
		/// </param>
		/// <throws>  TransportException </throws>
		public abstract void  doSend(NuGenTransportable theMessage);
		
		/// <summary> Sets isConnected() to false, then calls doConnect(), then sets isConnected() to 
		/// true. 
		/// </summary>
		/// <seealso cref="Genetibase.NuGenHL7.protocol.TransportLayer.connect()">
		/// </seealso>
		public virtual void  connect()
		{
			myIsConnected = false;
			doConnect();
			myIsConnected = true;
		}
		
		/// <summary> Performs connection as described in TransportLayer.connect().  The 
		/// connect() method of this class delegates to doConnect() after some
		/// internal housekeeping.
		/// 
		/// </summary>
		/// <throws>  TransportException </throws>
		public abstract void  doConnect();
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.TransportLayer.disconnect()">
		/// </seealso>
		public virtual void  disconnect()
		{
			myIsConnected = false;
			doDisconnect();
		}
		
		/// <summary> Performs disconnection as described in TransportLayer.disconnect().  The 
		/// disconnect() method of this class delegates to doDisconnect() after some
		/// internal housekeeping.
		/// 
		/// </summary>
		/// <throws>  TransportException </throws>
		public abstract void  doDisconnect();
		static NuGenAbstractTransport()
		{
		}
	}
}