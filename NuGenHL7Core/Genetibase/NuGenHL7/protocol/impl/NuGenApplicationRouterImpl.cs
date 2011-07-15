/*
* Created on 21-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using DefaultApplication = Genetibase.NuGenHL7.app.NuGenDefaultApplication;
using Responder = Genetibase.NuGenHL7.app.NuGenResponder;
using Message = Genetibase.NuGenHL7.model.Message;
using Segment = Genetibase.NuGenHL7.model.Segment;
using GenericParser = Genetibase.NuGenHL7.parser.NuGenGenericParser;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using ApplicationRouter = Genetibase.NuGenHL7.protocol.NuGenApplicationRouter;
using ReceivingApplication = Genetibase.NuGenHL7.protocol.NuGenReceivingApplication;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> <p>A default implementation of <code>ApplicationRouter</code> </p>  
	/// 
	/// <p>Note that ParseChecker is used for each inbound message, iff the system
	/// property Genetibase.NuGenHL7.protocol.impl.check_parse = "TRUE".  </p>
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.7 $ updated on $Date: 2006/12/12 01:01:36 $ by $Author: jamesagnew $
	/// </version>
	public class NuGenApplicationRouterImpl : NuGenApplicationRouter
	{
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.getParser()">
		/// </seealso>
		virtual public Parser Parser
		{
			get
			{
				return myParser;
			}
			
		}
		
		/// <summary> Key under which raw message text is stored in metadata Map sent to 
		/// <code>ReceivingApplication</code>s. 
		/// </summary>
		public static System.String RAW_MESSAGE_KEY = "raw-message";
		
		private System.Collections.IList myBindings;
		private Parser myParser;
		
		
		/// <summary> Creates an instance that uses a <code>GenericParser</code>. </summary>
		public NuGenApplicationRouterImpl()
		{
			init(new GenericParser());
		}
		
		/// <summary> Creates an instance that uses the specified <code>Parser</code>. </summary>
		/// <param name="theParser">the parser used for converting between Message and 
		/// Transportable
		/// </param>
		public NuGenApplicationRouterImpl(Parser theParser)
		{
			init(theParser);
		}
		
		private void  init(Parser theParser)
		{
			myBindings = new System.Collections.ArrayList(20);
			myParser = theParser;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.processMessage(Genetibase.NuGenHL7.protocol.Transportable)">
		/// </seealso>
		public virtual NuGenTransportable processMessage(NuGenTransportable theMessage)
		{
			System.String[] result = processMessage(theMessage.Message, theMessage.Metadata);
			NuGenTransportable response = new NuGenTransportableImpl(result[0]);
			
			if (result[1] != null)
			{
				response.Metadata["MSH-18"] = result[1];
			}
			
			return response;
		}
		
		/// <summary> Processes an incoming message string and returns the response message string.
		/// Message processing consists of parsing the message, finding an appropriate
		/// Application and processing the message with it, and encoding the response.
		/// Applications are chosen from among those registered using
		/// <code>bindApplication</code>.  
		/// 
		/// </summary>
		/// <returns> {text, charset}
		/// </returns>
		private System.String[] processMessage(System.String incomingMessageString, System.Collections.IDictionary theMetadata)
		{;
			
			Message incomingMessageObject = null;
			System.String outgoingMessageString = null;
			System.String outgoingMessageCharset = null;
			try
			{
				incomingMessageObject = myParser.parse(incomingMessageString);
			}
			catch (NuGenHL7Exception e)
			{
				outgoingMessageString = Responder.logAndMakeErrorMessage(e, myParser.getCriticalResponseData(incomingMessageString), myParser, myParser.getEncoding(incomingMessageString));
			}
			
			if (outgoingMessageString == null)
			{
				try
				{				
					//message validation (in terms of optionality, cardinality) would go here ***
					
					NuGenReceivingApplication app = findApplication(incomingMessageObject);
					theMetadata[RAW_MESSAGE_KEY] = incomingMessageString;
					Message response = app.processMessage(incomingMessageObject, theMetadata);
					
					//Here we explicitly use the same encoding as that of the inbound message - this is important with GenericParser, which might use a different encoding by default
					outgoingMessageString = myParser.encode(response, myParser.getEncoding(incomingMessageString));
					
					Terser t = new Terser(response);
					outgoingMessageCharset = t.get_Renamed("MSH-18");
				}
				catch (System.Exception e)
				{
					outgoingMessageString = Responder.logAndMakeErrorMessage(e, (Segment) incomingMessageObject.get_Renamed("MSH"), myParser, myParser.getEncoding(incomingMessageString));
				}
			}
			
			return new System.String[]{outgoingMessageString, outgoingMessageCharset};
		}
		
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.hasActiveBinding(Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData)">
		/// </seealso>
		public virtual bool hasActiveBinding(AppRoutingData theRoutingData)
		{
			bool result = false;
			NuGenReceivingApplication app = findDestination(theRoutingData);
			if (app != null)
			{
				result = true;
			}
			return result;
		}
		
		/// <param name="theRoutingData">
		/// </param>
		/// <returns> the application from the binding with a WILDCARD match, if one exists
		/// </returns>
		private NuGenReceivingApplication findDestination(AppRoutingData theRoutingData)
		{
			NuGenReceivingApplication result = null;
			for (int i = 0; i < myBindings.Count && result == null; i++)
			{
				Binding binding = (Binding) myBindings[i];
				if (matches(theRoutingData, binding.routingData) && binding.active)
				{
					result = binding.application;
				}
			}
			return result;
		}
		
		/// <param name="theRoutingData">
		/// </param>
		/// <returns> the binding with an EXACT match on routing data if one exists 
		/// </returns>
		private Binding findBinding(AppRoutingData theRoutingData)
		{
			Binding result = null;
			for (int i = 0; i < myBindings.Count && result == null; i++)
			{
				Binding binding = (Binding) myBindings[i];
				if (theRoutingData.Equals(binding.routingData))
				{
					result = binding;
				}
			}
			return result;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.bindApplication(">
		/// Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData, Genetibase.NuGenHL7.protocol.ReceivingApplication)
		/// </seealso>
		public virtual void  bindApplication(AppRoutingData theRoutingData, NuGenReceivingApplication theApplication)
		{
			Binding binding = new Binding(theRoutingData, true, theApplication);
			myBindings.Add(binding);
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.disableBinding(Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData)">
		/// </seealso>
		public virtual void  disableBinding(AppRoutingData theRoutingData)
		{
			Binding b = findBinding(theRoutingData);
			if (b != null)
			{
				b.active = false;
			}
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ApplicationRouter.enableBinding(Genetibase.NuGenHL7.protocol.ApplicationRouter.AppRoutingData)">
		/// </seealso>
		public virtual void  enableBinding(AppRoutingData theRoutingData)
		{
			Binding b = findBinding(theRoutingData);
			if (b != null)
			{
				b.active = true;
			}
		}
		
		/// <param name="theMessageData">routing data related to a particular message
		/// </param>
		/// <param name="theReferenceData">routing data related to a binding, which may include 
		/// wildcards 
		/// </param>
		/// <param name="exact">if true, each field must match exactly
		/// </param>
		/// <returns> true if the message data is consist with the reference data, ie all 
		/// values either match or are wildcards in the reference
		/// </returns>
		public static bool matches(AppRoutingData theMessageData, AppRoutingData theReferenceData)
		{
			
			bool result = false;
			
			Genetibase.NuGenHL7.protocol.AppRoutingData ref_Renamed = theReferenceData;
			Genetibase.NuGenHL7.protocol.AppRoutingData msg = theMessageData;
			
			if (matches(msg.MessageType, ref_Renamed.MessageType) && matches(msg.TriggerEvent, ref_Renamed.TriggerEvent) && matches(msg.ProcessingId, ref_Renamed.ProcessingId) && matches(msg.Version, ref_Renamed.Version))
			{
				
				result = true;
			}
			
			return result;
		}
		
		//support method for matches(AppRoutingData theMessageData, AppRoutingData theReferenceData)
		private static bool matches(System.String theMessageData, System.String theReferenceData)
		{
			bool result = false;
			if (theMessageData.Equals(theReferenceData) || theReferenceData.Equals("*") || Regex.IsMatch(theMessageData, theReferenceData))
			{
				result = true;
			}
			return result;
		}
		
		/// <summary> Returns the first Application that has been bound to messages of this type.  </summary>
		private NuGenReceivingApplication findApplication(Message theMessage)
		{
			Terser t = new Terser(theMessage);
			AppRoutingData msgData = new NuGenAppRoutingDataImpl(t.get_Renamed("/MSH-9-1"), t.get_Renamed("/MSH-9-2"), t.get_Renamed("/MSH-11-1"), t.get_Renamed("/MSH-12"));
			
			NuGenReceivingApplication app = findDestination(msgData);
			
			//have to send back an application reject if no apps available to process
			if (app == null)
				app = new NuGenAppWrapper(new DefaultApplication());
			return app;
		}
		
		/// <summary> A structure for bindings between routing data and applications.  </summary>
		private class Binding
		{
			public AppRoutingData routingData;
			public bool active;
			public NuGenReceivingApplication application;
			
			public Binding(AppRoutingData theRoutingData, bool isActive, NuGenReceivingApplication theApplication)
			{
				routingData = theRoutingData;
				active = isActive;
				application = theApplication;
			}
		}
		static NuGenApplicationRouterImpl()
		{
		}
	}
}