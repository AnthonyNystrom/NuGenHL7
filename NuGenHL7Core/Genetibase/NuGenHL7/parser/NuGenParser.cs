/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Parser.java".  Description: 
/// "Parses HL7 message Strings into HL7 Message objects and 
/// encodes HL7 Message objects into HL7 message Strings" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using GenericMessage = Genetibase.NuGenHL7.model.GenericMessage;
using Group = Genetibase.NuGenHL7.model.Group;
using Message = Genetibase.NuGenHL7.model.Message;
using Segment = Genetibase.NuGenHL7.model.Segment;
using MessageValidator = Genetibase.NuGenHL7.validation.NuGenMessageValidator;
using ValidationContext = Genetibase.NuGenHL7.validation.NuGenValidationContext;
using DefaultValidation = Genetibase.NuGenHL7.validation.impl.NuGenDefaultValidation;
namespace Genetibase.NuGenHL7.parser
{
	
	/// <summary> Parses HL7 message Strings into HL7 Message objects and 
	/// encodes HL7 Message objects into HL7 message Strings.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public abstract class NuGenParser
	{
		/// <returns> the factory used by this Parser for model class lookup
		/// </returns>
		virtual public NuGenModelClassFactory Factory
		{
			get
			{
				return myFactory;
			}
			
		}
		/// <returns> the preferred encoding of this Parser
		/// </returns>
		public abstract System.String DefaultEncoding{get;}
		/// <summary> Returns event->structure maps.  </summary>
		private static System.Collections.IDictionary MessageStructures
		{
			get
			{
				lock (typeof(Genetibase.NuGenHL7.parser.NuGenParser))
				{
					if (messageStructures == null)
					{
						messageStructures = loadMessageStructures();
					}
					return messageStructures;
				}
			}
			
		}
		
		private static System.Collections.IDictionary messageStructures = null;
		
		private static readonly System.String[] versions = new System.String[]{"2.0", "2.0D", "2.1", "2.2", "2.3", "2.3.1", "2.4", "2.5"};
		
		private NuGenModelClassFactory myFactory;
		private ValidationContext myContext;
		private MessageValidator myValidator;
		
		/// <summary> Uses DefaultModelClassFactory for model class lookup. </summary>
		public NuGenParser()
		{
			myFactory = new NuGenDefaultModelClassFactory();
			setValidationContext(new DefaultValidation());
		}
		
		/// <param name="theFactory">custom factory to use for model class lookup 
		/// </param>
		public NuGenParser(NuGenModelClassFactory theFactory)
		{
			myFactory = theFactory;
			setValidationContext(new DefaultValidation());
		}
		
		/// <returns> the set of validation rules that is applied to messages parsed or encoded by this parser
		/// </returns>
		public virtual ValidationContext getValidationContext()
		{
			return myContext;
		}
		
		/// <param name="theContext">the set of validation rules to be applied to messages parsed or 
		/// encoded by this parser (defaults to ValidationContextFactory.DefaultValidation)
		/// </param>
		public virtual void  setValidationContext(ValidationContext theContext)
		{
			myContext = theContext;
			myValidator = new MessageValidator(theContext, true);
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
		public abstract System.String getEncoding(System.String message);
		
		/// <summary> Returns true if and only if the given encoding is supported 
		/// by this Parser.  
		/// </summary>
		public abstract bool supportsEncoding(System.String encoding);
		
		/// <summary> Parses a message string and returns the corresponding Message object.
		/// 
		/// </summary>
		/// <param name="message">a String that contains an HL7 message 
		/// </param>
		/// <returns> a HAPI Message object parsed from the given String 
		/// </returns>
		/// <throws>  HL7Exception if the message is not correctly formatted.   </throws>
		/// <throws>  EncodingNotSupportedException if the message encoded  </throws>
		/// <summary>      is not supported by this parser.   
		/// </summary>
		public virtual Message parse(System.String message)
		{
			System.String encoding = getEncoding(message);
			if (!supportsEncoding(encoding))
			{
				throw new NuGenEncodingNotSupportedException("Can't parse message beginning " + message.Substring(0, (System.Math.Min(message.Length, 50)) - (0)));
			}
			
			System.String version = getVersion(message);
			if (!validVersion(version))
			{
				throw new NuGenHL7Exception("Can't process message of version '" + version + "' - version not recognized", NuGenHL7Exception.UNSUPPORTED_VERSION_ID);
			}
			
			myValidator.validate(message, encoding.Equals("XML"), version);
			Message result = doParse(message, version);
			myValidator.validate(result);
			
			return result;
		}
		
		/// <summary> Called by parse() to perform implementation-specific parsing work.  
		/// 
		/// </summary>
		/// <param name="message">a String that contains an HL7 message 
		/// </param>
		/// <param name="version">the name of the HL7 version to which the message belongs (eg "2.5") 
		/// </param>
		/// <returns> a HAPI Message object parsed from the given String 
		/// </returns>
		/// <throws>  HL7Exception if the message is not correctly formatted.   </throws>
		/// <throws>  EncodingNotSupportedException if the message encoded  </throws>
		/// <summary>      is not supported by this parser.   
		/// </summary>
		protected internal abstract Message doParse(System.String message, System.String version);
		
		/// <summary> Formats a Message object into an HL7 message string using the given 
		/// encoding. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <param name="encoding">the name of the HL7 encoding to use (eg "XML"; most implementations support only  
		/// one encoding) 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not  </throws>
		/// <summary>      supported by this parser.  
		/// </summary>
		public virtual System.String encode(Message source, System.String encoding)
		{
			myValidator.validate(source);
			System.String result = doEncode(source, encoding);
			myValidator.validate(result, encoding.Equals("XML"), source.Version);
			
			return result;
		}
		
		/// <summary> Called by encode(Message, String) to perform implementation-specific encoding work. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <param name="encoding">the name of the HL7 encoding to use (eg "XML"; most implementations support only 
		/// one encoding) 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not  </throws>
		/// <summary>      supported by this parser.  
		/// </summary>
		protected internal abstract System.String doEncode(Message source, System.String encoding);
		
		/// <summary> Formats a Message object into an HL7 message string using this parser's  
		/// default encoding. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <param name="encoding">the name of the encoding to use (eg "XML"; most implementations support only one 
		/// encoding) 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		public virtual System.String encode(Message source)
		{
			System.String encoding = DefaultEncoding;
			
			myValidator.validate(source);
			System.String result = doEncode(source);
			myValidator.validate(result, encoding.Equals("XML"), source.Version);
			
			return result;
		}
		
		/// <summary> Called by encode(Message) to perform implementation-specific encoding work. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not  </throws>
		/// <summary>      supported by this parser.  
		/// </summary>
		protected internal abstract System.String doEncode(Message source);
		
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
		/// <returns> an MSH segment 
		/// </returns>
		public abstract Segment getCriticalResponseData(System.String message);
		
		/// <summary> For response messages, returns the value of MSA-2 (the message ID of the message 
		/// sent by the sending system).  This value may be needed prior to main message parsing, 
		/// so that (particularly in a multi-threaded scenario) the message can be routed to 
		/// the thread that sent the request.  We need this information first so that any 
		/// parse exceptions are thrown to the correct thread.  Implementers of Parsers should 
		/// take care to make the implementation of this method very fast and robust.  
		/// Returns null if MSA-2 can not be found (e.g. if the message is not a 
		/// response message). 
		/// </summary>
		public abstract System.String getAckID(System.String message);
		
		/// <summary> Returns the version ID (MSH-12) from the given message, without fully parsing the message. 
		/// The version is needed prior to parsing in order to determine the message class
		/// into which the text of the message should be parsed. 
		/// </summary>
		/// <throws>  HL7Exception if the version field can not be found.  </throws>
		public abstract System.String getVersion(System.String message);
		
		
		/// <summary> Creates a version-specific MSH object and returns it as a version-independent 
		/// MSH interface. 
		/// throws HL7Exception if there is a problem, e.g. invalid version, code not available 
		/// for given version. 
		/// </summary>
		public static Segment makeControlMSH(System.String version, NuGenModelClassFactory factory)
		{
			Segment msh = null;
			try
			{
				Message dummy = (Message) GenericMessage.getGenericMessageClass(version).GetConstructor(new System.Type[]{typeof(NuGenModelClassFactory)}).Invoke(new System.Object[]{factory});
				
				System.Type[] constructorParamTypes = new System.Type[]{typeof(Group), typeof(NuGenModelClassFactory)};
				System.Object[] constructorParamArgs = new System.Object[]{dummy, factory};
				System.Type c = factory.getSegmentClass("MSH", version);
				System.Reflection.ConstructorInfo constructor = c.GetConstructor(constructorParamTypes);
				msh = (Segment) constructor.Invoke(constructorParamArgs);
			}
			catch (System.Exception e)
			{
				throw new NuGenHL7Exception("Couldn't create MSH for version " + version + " (does your classpath include this version?) ... ", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
			}
			return msh;
		}
		
		/// <summary> Returns true if the given string represents a valid 2.x version.  Valid versions 
		/// include "2.0", "2.0D", "2.1", "2.2", "2.3", "2.3.1", "2.4", "2.5". 
		/// </summary>
		public static bool validVersion(System.String version)
		{
			bool versionOK = false;
			int c = 0;
			while (versionOK == false && c < versions.Length)
			{
				if (versions[c++].Equals(version))
					versionOK = true;
			}
			return versionOK;
		}
		
		/// <summary> Given a concatenation of message type and event (e.g. ADT_A04), and the 
		/// version, finds the corresponding message structure (e.g. ADT_A01).  This  
		/// is needed because some events share message structures, although it is not needed
		/// when the message structure is explicitly valued in MSH-9-3. 
		/// If no mapping is found, returns the original name.
		/// </summary>
		/// <throws>  HL7Exception if there is an error retrieving the map, or if the given  </throws>
		/// <summary>      version is invalid  
		/// </summary>
		public static System.String getMessageStructureForEvent(System.String name, System.String version)
		{
			System.String structure = null;
			
			if (!validVersion(version))
				throw new NuGenHL7Exception("The version " + version + " is unknown");
			
			System.Collections.Specialized.NameValueCollection p = null;
			try
			{
				p = (System.Collections.Specialized.NameValueCollection) MessageStructures[version];
			}
			catch (System.IO.IOException ioe)
			{
				throw new NuGenHL7Exception(ioe);
			}
			
			if (p == null)
				throw new NuGenHL7Exception("No map found for version " + version);
			
			structure = p.Get(name);
			
			if (structure == null)
			{
				structure = name;
			}
			
			return structure;
		}
		
		private static System.Collections.IDictionary loadMessageStructures()
		{
			lock (typeof(Genetibase.NuGenHL7.parser.NuGenParser))
			{
				System.Collections.IDictionary map = new System.Collections.Hashtable();
				for (int i = 0; i < versions.Length; i++)
				{					
					System.Collections.Specialized.NameValueCollection structures = null;

					structures = new System.Collections.Specialized.NameValueCollection();
					structures = new System.Collections.Specialized.NameValueCollection(System.Configuration.ConfigurationSettings.AppSettings);					                    

					map[versions[i]] = structures;
				}
				return map;
			}
		}
		
		/// <summary> Note that the validation context of the resulting message is set to this parser's validation 
		/// context.  The validation context is used within Primitive.setValue().
		/// 
		/// </summary>
		/// <param name="name">name of the desired structure in the form XXX_YYY
		/// </param>
		/// <param name="version">HL7 version (e.g. "2.3")  
		/// </param>
		/// <param name="isExplicit">true if the structure was specified explicitly in MSH-9-3, false if it 
		/// was inferred from MSH-9-1 and MSH-9-2.  If false, a lookup may be performed to find 
		/// an alternate structure corresponding to that message type and event.   
		/// </param>
		/// <returns> a Message instance 
		/// </returns>
		/// <throws>  HL7Exception if the version is not recognized or no appropriate class can be found or the Message  </throws>
		/// <summary>      class throws an exception on instantiation (e.g. if args are not as expected) 
		/// </summary>
		protected internal virtual Message instantiateMessage(System.String theName, System.String theVersion, bool isExplicit)
		{
			Message result = null;
			
			try
			{
				System.Type messageClass = myFactory.getMessageClass(theName, theVersion, isExplicit);
				if (messageClass == null)
				{
					throw new System.Exception("Can't find message class in current package list: " + theName);
				}
				System.Reflection.ConstructorInfo constructor = messageClass.GetConstructor(new System.Type[]{typeof(NuGenModelClassFactory)});
				result = (Message) constructor.Invoke(new System.Object[]{myFactory});
			}
			catch (System.Exception e)
			{
				throw new NuGenHL7Exception("Couldn't create Message object of type " + theName, NuGenHL7Exception.UNSUPPORTED_MESSAGE_TYPE, e);
			}
			
			result.ValidationContext = myContext;
			
			return result;
		}
		static NuGenParser()
		{
		}
	}
}