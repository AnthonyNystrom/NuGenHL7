using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 MSH message segment. 
	/// This segment has the following fields:</p><p>
	/// MSH-1: Field Separator (ST)<br> 
	/// MSH-2: Encoding Characters (ST)<br> 
	/// MSH-3: Sending Application (HD)<br> 
	/// MSH-4: Sending Facility (HD)<br> 
	/// MSH-5: Receiving Application (HD)<br> 
	/// MSH-6: Receiving Facility (HD)<br> 
	/// MSH-7: Date/Time Of Message (TS)<br> 
	/// MSH-8: Security (ST)<br> 
	/// MSH-9: Message Type (MSG)<br> 
	/// MSH-10: Message Control ID (ST)<br> 
	/// MSH-11: Processing ID (PT)<br> 
	/// MSH-12: Version ID (VID)<br> 
	/// MSH-13: Sequence Number (NM)<br> 
	/// MSH-14: Continuation Pointer (ST)<br> 
	/// MSH-15: Accept Acknowledgment Type (ID)<br> 
	/// MSH-16: Application Acknowledgment Type (ID)<br> 
	/// MSH-17: Country Code (ID)<br> 
	/// MSH-18: Character Set (ID)<br> 
	/// MSH-19: Principal Language Of Message (CE)<br> 
	/// MSH-20: Alternate Character Set Handling Scheme (ID)<br> 
	/// MSH-21: Conformance Statement ID (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MSH:AbstractSegment
	{
		/// <summary> Returns Field Separator (MSH-1).</summary>
		virtual public ST FieldSeparator
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Encoding Characters (MSH-2).</summary>
		virtual public ST EncodingCharacters
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Sending Application (MSH-3).</summary>
		virtual public HD SendingApplication
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (HD) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Sending Facility (MSH-4).</summary>
		virtual public HD SendingFacility
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (HD) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Receiving Application (MSH-5).</summary>
		virtual public HD ReceivingApplication
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (HD) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Receiving Facility (MSH-6).</summary>
		virtual public HD ReceivingFacility
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (HD) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Date/Time Of Message (MSH-7).</summary>
		virtual public TS DateTimeOfMessage
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Security (MSH-8).</summary>
		virtual public ST Security
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Message Type (MSH-9).</summary>
		virtual public MSG MessageType
		{
			get
			{
				MSG ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (MSG) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Message Control ID (MSH-10).</summary>
		virtual public ST MessageControlID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Processing ID (MSH-11).</summary>
		virtual public PT ProcessingID
		{
			get
			{
				PT ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (PT) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Version ID (MSH-12).</summary>
		virtual public VID VersionID
		{
			get
			{
				VID ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (VID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Sequence Number (MSH-13).</summary>
		virtual public NM SequenceNumber
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Continuation Pointer (MSH-14).</summary>
		virtual public ST ContinuationPointer
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Accept Acknowledgment Type (MSH-15).</summary>
		virtual public ID AcceptAcknowledgmentType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Application Acknowledgment Type (MSH-16).</summary>
		virtual public ID ApplicationAcknowledgmentType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(16, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Country Code (MSH-17).</summary>
		virtual public ID CountryCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Principal Language Of Message (MSH-19).</summary>
		virtual public CE PrincipalLanguageOfMessage
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Alternate Character Set Handling Scheme (MSH-20).</summary>
		virtual public ID AlternateCharacterSetHandlingScheme
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a MSH (Message Header) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public MSH(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 1, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 4, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 180, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 180, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 180, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 180, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(MSG), true, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(PT), true, 1, 3, new System.Object[]{message});
				this.add(typeof(VID), true, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 180, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 155});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 155});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 399});
				this.add(typeof(ID), false, 0, 16, new System.Object[]{message, 211});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 356});
				this.add(typeof(ID), false, 0, 10, new System.Object[]{message, 449});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Character Set (MSH-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getCharacterSet(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Character Set (MSH-18).</summary>
		public virtual ID[] getCharacterSet()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(18);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Conformance Statement ID (MSH-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getConformanceStatementID(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Conformance Statement ID (MSH-21).</summary>
		public virtual ID[] getConformanceStatementID()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(21);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
	}
}