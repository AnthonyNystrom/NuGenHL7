using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using Segment = Genetibase.NuGenHL7.model.Segment;
using ValidationContext = Genetibase.NuGenHL7.validation.NuGenValidationContext;
namespace Genetibase.NuGenHL7.parser
{
	
	/// <summary> A Parser that delegates parsing tasks to an underlying PipeParser and DefaultXMLParser
	/// as needed.  Messages to be parsed are inspected in order to determine which Parser 
	/// to use.  If a message is to be encoded, the "primary" Parser will be used.  The 
	/// primary parser defaults to PipeParser, and can be configured using the 
	/// set...AsPrimary() methods.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenGenericParser:NuGenParser
	{
		/// <returns> the preferred encoding of the current primary Parser
		/// </returns>
		override public System.String DefaultEncoding
		{
			get
			{
				return primaryParser.DefaultEncoding;
			}
			
		}
		
		private NuGenParser primaryParser;
		private NuGenParser secondaryParser;
		private NuGenPipeParser pipeParser;
		private NuGenXMLParser xmlParser;
		
		/// <summary>Creates a new instance of GenericParser </summary>
		public NuGenGenericParser():base()
		{
			
			pipeParser = new NuGenPipeParser();
			xmlParser = new NuGenDefaultXMLParser();
			setPipeParserAsPrimary();
		}
		
		/// <summary> Sets the underlying XMLParser as the primary parser, so that subsequent calls to 
		/// encode() will return XML encoded messages, and an attempt will be made to use the 
		/// XMLParser first for parsing.  
		/// </summary>
		public virtual void  setXMLParserAsPrimary()
		{
			primaryParser = xmlParser;
			secondaryParser = pipeParser;
		}
		
		/// <summary> Sets the underlying PipeParser as the primary parser, so that subsequent calls to 
		/// encode() will return traditionally encoded messages, and an attempt will be made to use the 
		/// PipeParser first for parsing.  This is the default setting.  
		/// </summary>
		public virtual void  setPipeParserAsPrimary()
		{
			primaryParser = pipeParser;
			secondaryParser = xmlParser;
		}
		
		/// <param name="theContext">the set of validation rules to be applied to messages parsed or
		/// encoded by this parser (defaults to ValidationContextFactory.DefaultValidation)
		/// </param>
		public override void  setValidationContext(ValidationContext theContext)
		{
			base.setValidationContext(theContext);
			
			// These parsers are not yet initialized when this is called during the Parser constructor
			if (xmlParser != null)
			{
				pipeParser.setValidationContext(theContext);
				xmlParser.setValidationContext(theContext);
			}
		}
		
		/// <summary> Checks the encoding of the message using getEncoding(), and returns the corresponding
		/// parser (either pipeParser or xmlParser).  If the encoding is not recognized an 
		/// HL7Exception is thrown. 
		/// </summary>
		private NuGenParser getAppropriateParser(System.String message)
		{
			System.String encoding = getEncoding(message);
			if (encoding == null)
				encoding = ""; //prevent null pointer exception
			NuGenParser appropriateParser = null;
			if (encoding.ToUpper().Equals("VB".ToUpper()))
			{
				appropriateParser = pipeParser;
			}
			else if (encoding.ToUpper().Equals("XML".ToUpper()))
			{
				appropriateParser = xmlParser;
			}
			else
			{
				throw new NuGenHL7Exception("Can't find appropriate parser - encoding not recognized", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			return appropriateParser;
		}
		
		/// <summary> Formats a Message object into an HL7 message string using the given
		/// encoding.
		/// </summary>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding </throws>
		/// <summary>     (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not </throws>
		/// <summary>     supported by this parser.
		/// </summary>
		protected internal override System.String doEncode(Message source, System.String encoding)
		{
			System.String ret = null;
			if (encoding == null)
				encoding = ""; //prevent null pointer exception
			if (encoding.ToUpper().Equals("VB".ToUpper()))
			{
				ret = pipeParser.doEncode(source);
			}
			else if (encoding.ToUpper().Equals("XML".ToUpper()))
			{
				ret = xmlParser.doEncode(source);
			}
			else
			{
				throw new NuGenEncodingNotSupportedException("The encoding " + encoding + " is not supported by " + this.GetType().FullName);
			}
			return ret;
		}
		
		/// <summary> <p>Returns a minimal amount of data from a message string, including only the
		/// data needed to send a response to the remote system.  This includes the
		/// following fields:
		/// <ul><li>field separator</li>
		/// <li>encoding characters</li>
		/// <li>processing ID</li>
		/// <li>message control ID</li></ul>
		/// This method is intended for use when there is an error parsing a message,
		/// (so the Message object is unavailable) but an error message must be sent
		/// back to the remote system including some of the information in the inbound
		/// message.  This method parses only that required information, hopefully
		/// avoiding the condition that caused the original error.</p>
		/// </summary>
		public override Segment getCriticalResponseData(System.String message)
		{
			return getAppropriateParser(message).getCriticalResponseData(message);
		}
		
		/// <summary> Returns the version ID (MSH-12) from the given message, without fully parsing the message.
		/// The version is needed prior to parsing in order to determine the message class
		/// into which the text of the message should be parsed.
		/// </summary>
		/// <throws>  HL7Exception if the version field can not be found. </throws>
		public override System.String getVersion(System.String message)
		{
			return getAppropriateParser(message).getVersion(message);
		}
		
		/// <summary> Returns a String representing the encoding of the given message, if
		/// the encoding is recognized.  For example if the given message appears
		/// to be encoded using HL7 2.x XML rules then "XML" would be returned.
		/// If the encoding is not recognized then null is returned.  That this
		/// method returns a specific encoding does not guarantee that the
		/// message is correctly encoded (e.g. well formed XML) - just that
		/// it is not encoded using any other encoding than the one returned.
		/// Returns null if the encoding is not recognized.
		/// </summary>
		public override System.String getEncoding(System.String message)
		{
			System.String encoding = primaryParser.getEncoding(message);
			if (encoding == null)
				encoding = secondaryParser.getEncoding(message);
			return encoding;
		}
		
		/// <summary> For response messages, returns the value of MSA-2 (the message ID of the message
		/// sent by the sending system).  This value may be needed prior to main message parsing,
		/// so that (particularly in a multi-threaded scenario) the message can be routed to
		/// the thread that sent the request.  We need this information first so that any
		/// parse exceptions are thrown to the correct thread.  Implementers of Parsers should
		/// take care to make the implementation of this method very fast and robust.
		/// Returns null if MSA-2 can not be found (e.g. if the message is not a
		/// response message).
		/// </summary>
		public override System.String getAckID(System.String message)
		{
			try
			{
				return getAppropriateParser(message).getAckID(message);
			}
			catch (NuGenHL7Exception)
			{
				return null;
			}
		}
		
		/// <summary> Returns true if and only if the given encoding is supported
		/// by this Parser.
		/// </summary>
		public override bool supportsEncoding(System.String encoding)
		{
			bool supported = false;
			if ("VB".ToUpper().Equals(encoding.ToUpper()) || "XML".ToUpper().Equals(encoding.ToUpper()))
				supported = true;
			return supported;
		}
		
		/// <summary> Parses a message string and returns the corresponding Message
		/// object.
		/// </summary>
		/// <throws>  HL7Exception if the message is not correctly formatted. </throws>
		/// <throws>  EncodingNotSupportedException if the message encoded </throws>
		/// <summary>     is not supported by this parser.
		/// </summary>
		protected internal override Message doParse(System.String message, System.String version)
		{
			return getAppropriateParser(message).doParse(message, version);
		}
		
		/// <summary> Formats a Message object into an HL7 message string using this parser's
		/// default encoding.
		/// </summary>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding </throws>
		/// <summary>     (e.g. required fields are null)
		/// </summary>
		protected internal override System.String doEncode(Message source)
		{
			return primaryParser.doEncode(source);
		}
	}
}