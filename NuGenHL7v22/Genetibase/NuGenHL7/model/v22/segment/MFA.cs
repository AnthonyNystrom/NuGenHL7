using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 MFA message segment. 
	/// This segment has the following fields:</p><p>
	/// MFA-1: Record-level event code (ID)<br> 
	/// MFA-2: MFN control ID (ST)<br> 
	/// MFA-3: Event completion date / time (TS)<br> 
	/// MFA-4: Error return code and/or text (CE)<br> 
	/// MFA-5: Primary key value (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MFA:AbstractSegment
	{
		/// <summary> Returns Record-level event code (MFA-1).</summary>
		virtual public ID RecordLevelEventCode
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
		/// <summary> Returns MFN control ID (MFA-2).</summary>
		virtual public ST MFNControlID
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
		/// <summary> Returns Event completion date / time (MFA-3).</summary>
		virtual public TS EventCompletionDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Error return code and/or text (MFA-4).</summary>
		virtual public CE ErrorReturnCodeAndOrText
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		
		/// <summary> Creates a MFA (MASTER FILE ACKNOWLEDGEMENT) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public MFA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 3, new System.Object[]{message, 180});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), true, 0, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Primary key value (MFA-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getPrimaryKeyValue(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Primary key value (MFA-5).</summary>
		public virtual CE[] getPrimaryKeyValue()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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