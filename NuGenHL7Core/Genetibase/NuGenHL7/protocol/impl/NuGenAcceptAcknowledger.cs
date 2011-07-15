/*
* Created on 10-May-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using DefaultApplication = Genetibase.NuGenHL7.app.NuGenDefaultApplication;
using Message = Genetibase.NuGenHL7.model.Message;
using Segment = Genetibase.NuGenHL7.model.Segment;
using GenericParser = Genetibase.NuGenHL7.parser.NuGenGenericParser;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using AcceptValidator = Genetibase.NuGenHL7.protocol.NuGenAcceptValidator;
using Processor = Genetibase.NuGenHL7.protocol.NuGenProcessor;
using ProcessorContext = Genetibase.NuGenHL7.protocol.NuGenProcessorContext;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> Checks whether messages can be accepted and creates appropriate
	/// ACK messages.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2004/05/24 16:25:33 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenAcceptAcknowledger
	{
		private static Parser ourParser = new GenericParser();
		
		/// <summary> Validates the given message against our accept validators, attempts to commit
		/// the message to safe storage, and returns an ACK message indicating acceptance 
		/// or rejection at the accept level (see enhanced mode processing rules in HL7 
		/// chapter 2, v2.5).  
		/// </summary>
		public static AcceptACK validate(NuGenProcessorContext theContext, NuGenTransportable theMessage)
		{
			AcceptACK ruling = null;
			
			NuGenAcceptValidator[] validators = theContext.Validators;
			for (int i = 0; i < validators.Length && ruling == null; i++)
			{
				Genetibase.NuGenHL7.protocol.AcceptRuling vr = validators[i].check(theMessage);
				if (!vr.Acceptable)
				{
					System.String description = (vr.Reasons.Length > 0)?vr.Reasons[0]:null;
					NuGenTransportable ack = makeAcceptAck(theMessage, vr.AckCode, vr.ErrorCode, description);
					ruling = new AcceptACK(false, ack);
				}
			}
			
			if (ruling == null)
			{
				try
				{
					theContext.SafeStorage.store(theMessage);
					NuGenTransportable ack = makeAcceptAck(theMessage, Genetibase.NuGenHL7.protocol.Processor_Fields.CA, NuGenHL7Exception.MESSAGE_ACCEPTED, "");
					ruling = new AcceptACK(true, ack);
				}
				catch (NuGenHL7Exception e)
				{
					int code = NuGenHL7Exception.APPLICATION_INTERNAL_ERROR;
					NuGenTransportable ack = makeAcceptAck(theMessage, Genetibase.NuGenHL7.protocol.Processor_Fields.CR, code, e.Message);
					ruling = new AcceptACK(false, ack);
				}
			}
			
			return ruling;
		}
		
		
		private static NuGenTransportable makeAcceptAck(NuGenTransportable theMessage, System.String theAckCode, int theErrorCode, System.String theDescription)
		{
			
			Segment header = ourParser.getCriticalResponseData(theMessage.Message);
			Message out_Renamed;
			try
			{
				out_Renamed = DefaultApplication.makeACK(header);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenHL7Exception(e);
			}
			
			Terser t = new Terser(out_Renamed);
			t.set_Renamed("/MSA-1", theAckCode);
			
			//TODO: when 2.5 is available, use 2.5 fields for remaining problems 
			if (theErrorCode != NuGenHL7Exception.MESSAGE_ACCEPTED)
			{
				t.set_Renamed("/MSA-3", theDescription.Substring(0, (System.Math.Min(80, theDescription.Length)) - (0)));
				t.set_Renamed("/ERR-1-4-1", System.Convert.ToString(theErrorCode));
				t.set_Renamed("/ERR-1-4-3", "HL70357");
			}
			
			System.String originalEncoding = ourParser.getEncoding(theMessage.Message);
			System.String ackText = ourParser.encode(out_Renamed, originalEncoding);
			return new NuGenTransportableImpl(ackText);
		}
		
		
		/// <summary> A structure for decisions as to whether a message can be accepted, 
		/// along with a corresponding accept or reject acknowlegement message. 
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.2 $ updated on $Date: 2004/05/24 16:25:33 $ by $Author: bryan_tripp $
		/// </version>
		public class AcceptACK
		{
			virtual public bool Acceptable
			{
				get
				{
					return myIsAcceptable;
				}
				
			}
			virtual public NuGenTransportable Message
			{
				get
				{
					return myAck;
				}
				
			}
			private NuGenTransportable myAck;
			private bool myIsAcceptable;
			
			public AcceptACK(bool isAcceptable, NuGenTransportable theAck)
			{
				myIsAcceptable = isAcceptable;
				myAck = theAck;
			}
		}
		static NuGenAcceptAcknowledger()
		{
		}
	}
}