using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 MFA message segment. 
	/// This segment has the following fields:</p><p>
	/// MFA-1: Record-Level Event Code (ID)<br> 
	/// MFA-2: MFN Control ID (ST)<br> 
	/// MFA-3: Event Completion Date/Time (TS)<br> 
	/// MFA-4: MFN Record Level Error Return (CE)<br> 
	/// MFA-5: Primary Key Value - MFA (CE)<br> 
	/// MFA-6: Primary Key Value Type - MFA (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MFA:AbstractSegment
	{
		/// <summary> Returns Record-Level Event Code (MFA-1).</summary>
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
		/// <summary> Returns MFN Control ID (MFA-2).</summary>
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
		/// <summary> Returns Event Completion Date/Time (MFA-3).</summary>
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
		/// <summary> Returns MFN Record Level Error Return (MFA-4).</summary>
		virtual public CE MFNRecordLevelErrorReturn
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
		
		/// <summary> Creates a MFA (Master File Acknowledgment) segment object that belongs to the given 
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
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), true, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), true, 0, 3, new System.Object[]{message, 355});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Primary Key Value - MFA (MFA-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getPrimaryKeyValueMFA(int rep)
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
		
		/// <summary> Returns all repetitions of Primary Key Value - MFA (MFA-5).</summary>
		public virtual CE[] getPrimaryKeyValueMFA()
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
		
		/// <summary> Returns a single repetition of Primary Key Value Type - MFA (MFA-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getPrimaryKeyValueTypeMFA(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Primary Key Value Type - MFA (MFA-6).</summary>
		public virtual ID[] getPrimaryKeyValueTypeMFA()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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