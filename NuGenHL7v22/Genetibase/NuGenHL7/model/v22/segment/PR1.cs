using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 PR1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PR1-1: Set ID - procedure (SI)<br> 
	/// PR1-2: Procedure coding method (ID)<br> 
	/// PR1-3: Procedure code (ID)<br> 
	/// PR1-4: Procedure description (ST)<br> 
	/// PR1-5: Procedure date / time (TS)<br> 
	/// PR1-6: Procedure type (ID)<br> 
	/// PR1-7: Procedure minutes (NM)<br> 
	/// PR1-8: Anesthesiologist (CN)<br> 
	/// PR1-9: Anesthesia code (ID)<br> 
	/// PR1-10: Anesthesia minutes (NM)<br> 
	/// PR1-11: Surgeon (CN)<br> 
	/// PR1-12: Procedure Practitioner (CM_PRACTITIONER)<br> 
	/// PR1-13: Consent code (ID)<br> 
	/// PR1-14: Procedure priority (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PR1:AbstractSegment
	{
		/// <summary> Returns Set ID - procedure (PR1-1).</summary>
		virtual public SI SetIDProcedure
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI) t;
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
		/// <summary> Returns Procedure date / time (PR1-5).</summary>
		virtual public TS ProcedureDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Procedure type (PR1-6).</summary>
		virtual public ID ProcedureType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Procedure minutes (PR1-7).</summary>
		virtual public NM ProcedureMinutes
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Anesthesiologist (PR1-8).</summary>
		virtual public CN Anesthesiologist
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (CN) t;
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
		/// <summary> Returns Anesthesia code (PR1-9).</summary>
		virtual public ID AnesthesiaCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Anesthesia minutes (PR1-10).</summary>
		virtual public NM AnesthesiaMinutes
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Surgeon (PR1-11).</summary>
		virtual public CN Surgeon
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CN) t;
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
		/// <summary> Returns Consent code (PR1-13).</summary>
		virtual public ID ConsentCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Procedure priority (PR1-14).</summary>
		virtual public NM ProcedurePriority
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		
		/// <summary> Creates a PR1 (PROCEDURES) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PR1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), true, 0, 2, new System.Object[]{message, 89});
				this.add(typeof(ID), true, 0, 10, new System.Object[]{message, 88});
				this.add(typeof(ST), false, 0, 40, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 90});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 19});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CM_PRACTITIONER), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 59});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Procedure coding method (PR1-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getProcedureCodingMethod(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Procedure coding method (PR1-2).</summary>
		public virtual ID[] getProcedureCodingMethod()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(2);
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
		
		/// <summary> Returns a single repetition of Procedure code (PR1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getProcedureCode(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Procedure code (PR1-3).</summary>
		public virtual ID[] getProcedureCode()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Procedure description (PR1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getProcedureDescription(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Procedure description (PR1-4).</summary>
		public virtual ST[] getProcedureDescription()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(4);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of Procedure Practitioner (PR1-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_PRACTITIONER getProcedurePractitioner(int rep)
		{
			CM_PRACTITIONER ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (CM_PRACTITIONER) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Procedure Practitioner (PR1-12).</summary>
		public virtual CM_PRACTITIONER[] getProcedurePractitioner()
		{
			CM_PRACTITIONER[] ret = null;
			try
			{
				Type[] t = this.getField(12);
				ret = new CM_PRACTITIONER[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_PRACTITIONER) t[i];
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