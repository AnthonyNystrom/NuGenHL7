using System;
using Message = Genetibase.NuGenHL7.model.Message;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> Routes messages to various Applications based on message type and trigger event.
	/// The router is told which Application to which to route various messages by calling
	/// the method <code>registerApplication(...)</code>.
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenMessageTypeRouter : NuGenApplication
	{
		private System.Collections.Hashtable apps;
		
		/// <summary>Creates a new instance of MessageTypeRouter </summary>
		public NuGenMessageTypeRouter()
		{
			apps = new System.Collections.Hashtable(20);
		}
		
		/// <summary> Returns true if at least one application has been registered to accept this
		/// type of message.  Applications are registered using <code>registerApplication(...)</code>.
		/// </summary>
		public virtual bool canProcess(Message in_Renamed)
		{
			bool can = false;
			try
			{
				NuGenApplication matches = this.getMatchingApplication(in_Renamed);
				if (matches != null)
					can = true;
			}
			catch (NuGenHL7Exception)
			{
				can = false;
			}
			return can;
		}
		
		/// <summary> Forwards the given message to any Applications that have been registered to
		/// accept messages of that type and trigger event.
		/// </summary>
		/// <throws>  ApplicationException if no such Applications are registered, or if </throws>
		/// <summary>      the underlying Application throws this exception during processing.
		/// </summary>
		public virtual Message processMessage(Message in_Renamed)
		{
			Message out_Renamed;
			try
			{
				NuGenApplication matchingApp = this.getMatchingApplication(in_Renamed);
				out_Renamed = matchingApp.processMessage(in_Renamed);
			}
			catch (NuGenHL7Exception e)
			{
				throw new NuGenApplicationException("Error internally routing message: " + e.ToString(), e);
			}
			return out_Renamed;
		}
		
		/// <summary> Registers the given application to handle messages corresponding to the given type
		/// and trigger event.  Only one application can be registered for a given message type
		/// and trigger event combination.  A repeated registration for a particular combination 
		/// of type and trigger event over-writes the previous one.  Use "*" as a wildcard (e.g. 
		/// registerApplication("ADT", "*", myApp) would register your app for all ADT messages).
		/// </summary>
		public virtual void  registerApplication(System.String messageType, System.String triggerEvent, NuGenApplication handler)
		{
			lock (this)
			{
				this.apps[getKey(messageType, triggerEvent)] = handler;
				
				//status message
				System.Text.StringBuilder buf = new System.Text.StringBuilder();
				buf.Append(handler.GetType().FullName);
				buf.Append(" registered to handle ");
				buf.Append(messageType);
				buf.Append("^");
				buf.Append(triggerEvent);
				buf.Append(" messages");
			}
		}
		
		/// <summary> Returns the Applications that has been registered to handle 
		/// messages of the type and trigger event of the given message, or null if 
		/// there are none. 
		/// </summary>
		private NuGenApplication getMatchingApplication(Message message)
		{
			Terser t = new Terser(message);
			System.String messageType = t.get_Renamed("/MSH-9-1");
			System.String triggerEvent = t.get_Renamed("/MSH-9-2");
			return this.getMatchingApplication(messageType, triggerEvent);
		}
		
		/// <summary> Returns the Applications that has been registered to handle 
		/// messages of the given type and trigger event, or null if 
		/// there are none.  If there is not an exact match, wildcards 
		/// ("*") are tried as well.  
		/// </summary>
		private NuGenApplication getMatchingApplication(System.String messageType, System.String triggerEvent)
		{
			lock (this)
			{
				NuGenApplication matchingApp = null;
				System.Object o = this.apps[getKey(messageType, triggerEvent)];
				if (o == null)
				{
					o = this.apps[getKey(messageType, "*")];
				}
				if (o == null)
				{
					o = this.apps[getKey("*", triggerEvent)];
				}
				if (o == null)
				{
					o = this.apps[getKey("*", "*")];
				}
				if (o != null)
					matchingApp = (NuGenApplication) o;
				return matchingApp;
			}
		}
		
		/// <summary> Creates reproducible hash key. </summary>
		private System.String getKey(System.String messageType, System.String triggerEvent)
		{
			//create hash key string by concatenating type and trigger event
			return messageType + "|" + triggerEvent;
		}
		static NuGenMessageTypeRouter()
		{
		}
	}
}