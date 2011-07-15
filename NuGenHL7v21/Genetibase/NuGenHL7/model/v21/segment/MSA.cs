using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 MSA message segment. 
	/// This segment has the following fields:</p><p>
	/// MSA-1: ACKNOWLEDGMENT CODE (ID)<br> 
	/// MSA-2: MESSAGE CONTROL ID (ST)<br> 
	/// MSA-3: TEXT MESSAGE (ST)<br> 
	/// MSA-4: EXPECTED SEQUENCE NUMBER (NM)<br> 
	/// MSA-5: DELAYED ACKNOWLEDGMENT TYPE (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MSA:AbstractSegment
	{
		/// <summary> Returns ACKNOWLEDGMENT CODE (MSA-1).</summary>
		virtual public ID ACKNOWLEDGMENTCODE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns MESSAGE CONTROL ID (MSA-2).</summary>
		virtual public ST MESSAGECONTROLID
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
		/// <summary> Returns TEXT MESSAGE (MSA-3).</summary>
		virtual public ST TEXTMESSAGE
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns EXPECTED SEQUENCE NUMBER (MSA-4).</summary>
		virtual public NM EXPECTEDSEQUENCENUMBER
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns DELAYED ACKNOWLEDGMENT TYPE (MSA-5).</summary>
		virtual public ID DELAYEDACKNOWLEDGMENTTYPE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		
		/// <summary> Creates a MSA (MESSAGE ACKNOWLEDGMENT) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public MSA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 8});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 102});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}