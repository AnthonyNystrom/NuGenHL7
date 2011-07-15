/*
* Created on 21-Apr-2004
*/
using System;
using ApplicationRouter = Genetibase.NuGenHL7.protocol.NuGenApplicationRouter;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A default implementation of <code>ApplicationRouter.AppRoutingData</code>. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/28 22:50:57 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenAppRoutingDataImpl : Genetibase.NuGenHL7.protocol.AppRoutingData
	{
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData.getMessageType()">
		/// </seealso>
		virtual public System.String MessageType
		{
			get
			{
				return myMessageType;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData.getTriggerEvent()">
		/// </seealso>
		virtual public System.String TriggerEvent
		{
			get
			{
				return myTriggerEvent;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData.getProcessingId()">
		/// </seealso>
		virtual public System.String ProcessingId
		{
			get
			{
				return myProcessingId;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData.getVersion()">
		/// </seealso>
		virtual public System.String Version
		{
			get
			{
				return myVersionId;
			}
			
		}
		
		private System.String myMessageType;
		private System.String myTriggerEvent;
		private System.String myProcessingId;
		private System.String myVersionId;
		
		/// <summary> Creates a new instance with args used as values that will be returned 
		/// by the corresponding getters.  
		/// 
		/// </summary>
		/// <param name="theMessageType">
		/// </param>
		/// <param name="theTriggerEvent">
		/// </param>
		/// <param name="theProcessingId">
		/// </param>
		/// <param name="theVersionId">
		/// </param>
		public NuGenAppRoutingDataImpl(System.String theMessageType, System.String theTriggerEvent, System.String theProcessingId, System.String theVersionId)
		{
			myMessageType = theMessageType;
			myTriggerEvent = theTriggerEvent;
			myProcessingId = theProcessingId;
			myVersionId = theVersionId;
		}
		
		public  override bool Equals(System.Object o)
		{
			bool result = false;
			if (o is NuGenAppRoutingDataImpl)
			{
				NuGenAppRoutingDataImpl that = (NuGenAppRoutingDataImpl) o;
				if ((System.Object) this.MessageType == (System.Object) that.MessageType && (System.Object) this.TriggerEvent == (System.Object) that.TriggerEvent && (System.Object) this.ProcessingId == (System.Object) that.ProcessingId && (System.Object) this.Version == (System.Object) that.Version)
				{
					
					result = true;
				}
			}
			return result;
		}
		
		public override int GetHashCode()
		{
			return MessageType.GetHashCode() + TriggerEvent.GetHashCode() + ProcessingId.GetHashCode() + Version.GetHashCode();
		}
	}
}