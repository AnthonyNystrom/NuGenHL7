/*
* Created on 3-May-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using GenericParser = Genetibase.NuGenHL7.parser.NuGenGenericParser;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using Initiator = Genetibase.NuGenHL7.protocol.NuGenInitiator;
using Processor = Genetibase.NuGenHL7.protocol.NuGenProcessor;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> Default implementation of <code>Initiator</code>. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2005/05/10 23:14:17 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenInitiatorImpl : NuGenInitiator
	{
		/// <param name="theMaxRetries">max number of retries for initial message delivery 
		/// </param>
		virtual public int MaxRetries
		{
			get
			{
				return myMaxRetries;
			}
			
			set
			{
				myMaxRetries = value;
			}
			
		}
		/// <param name="theRetryIntervalMillis">milliseconds between retries of message delivery 
		/// </param>
		virtual public long RetryInterval
		{
			get
			{
				return myRetryInterval;
			}
			
			set
			{
				myRetryInterval = value;
			}
			
		}
		/// <param name="theReceiveTimeout">the length of time we wait for responses (defaults 
		/// to 10 seconds)
		/// </param>
		virtual public long ReceiveTimeout
		{
			get
			{
				return myReceiveTimeout;
			}
			
			set
			{
				myReceiveTimeout = value;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Initiator.getParser()">
		/// </seealso>
		virtual public Parser Parser
		{
			get
			{
				return myParser;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Initiator.getUnderlyingProcessor()">
		/// </seealso>
		virtual public NuGenProcessor UnderlyingProcessor
		{
			get
			{
				return myProcessor;
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Initiator.getMetadataFields()">
		/// </seealso>
		virtual public System.Collections.IList MetadataFields
		{
			get
			{
				return myMetadataFields;
			}
			
		}
		
		private System.Collections.IList myMetadataFields;
		private Parser myParser;
		private NuGenProcessor myProcessor;
		private int myMaxRetries;
		private long myRetryInterval;
		private long myReceiveTimeout;
		
		/// <summary> Creates an instance that uses a <code>GenericParser</code></summary>
		/// <param name="theProcessor">the <code>Processor</code> used to communicate 
		/// with the remote system
		/// </param>
		public NuGenInitiatorImpl(NuGenProcessor theProcessor)
		{
			myMetadataFields = new System.Collections.ArrayList(20);
			myMetadataFields.Add("MSH-18"); //add character set by default
			myParser = new GenericParser();
			myProcessor = theProcessor;
			init();
		}
		
		/// <summary> Creates an instance that uses the given <code>Parser</code></summary>
		/// <param name="theParser">parser to use for parsing and encoding messages
		/// </param>
		/// <param name="theProcessor">the <code>Processor</code> used to communicate 
		/// with the remote system
		/// </param>
		public NuGenInitiatorImpl(Parser theParser, NuGenProcessor theProcessor)
		{
			myMetadataFields = new System.Collections.ArrayList(20);
			myParser = theParser;
			myProcessor = theProcessor;
			init();
		}
		
		private void  init()
		{
			myMaxRetries = 3;
			myRetryInterval = 3000;
			myReceiveTimeout = 10000;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Initiator.sendAndReceive(Genetibase.NuGenHL7.model.Message)">
		/// </seealso>
		public virtual Message sendAndReceive(Message theMessage)
		{
			Terser t = new Terser(theMessage);
			System.String appAckNeeded = t.get_Renamed("/MSH-16");
			System.String msgId = t.get_Renamed("/MSH-10");
			
			System.String messageText = Parser.encode(theMessage);
			System.Collections.IDictionary metadata = getMetadata(theMessage);
			NuGenTransportable out_Renamed = new NuGenTransportableImpl(messageText, metadata);
			
			if (needAck(appAckNeeded))
			{
				myProcessor.reserve(msgId, ReceiveTimeout);
			}
			
			myProcessor.send(out_Renamed, MaxRetries, RetryInterval);
			
			Message in_Renamed = null;
			if (needAck(appAckNeeded))
			{
				NuGenTransportable received = myProcessor.receive(msgId, ReceiveTimeout);
				if (received != null && received.Message != null)
				{
					in_Renamed = Parser.parse(received.Message);
				}
			}
			
			return in_Renamed;
		}
		
		/// <param name="theAckCode">from MSH-16
		/// </param>
		/// <returns> true if the code indicates that we should wait for an ACK and try 
		/// to return it to the caller 
		/// </returns>
		private bool needAck(System.String theAckCode)
		{
			bool need = false;
			if (theAckCode == null || theAckCode.Equals("") || theAckCode.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.AL) || theAckCode.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.ER))
			{
				need = true;
			}
			return need;
		}
		
		private System.Collections.IDictionary getMetadata(Message theMessage)
		{
			System.Collections.IDictionary md = new System.Collections.Hashtable();
			Terser t = new Terser(theMessage);
			
			//snapshot so concurrent changes won't break our iteration

            Object[] fields = new Object[MetadataFields.Count];
            MetadataFields.CopyTo(fields, 0);
			
			for (int i = 0; i < fields.Length; i++)
			{
				System.String field = fields[i].ToString();
				System.String val = t.get_Renamed(field);
				md[field] = val;
			}
			
			return md;
		}
	}
}