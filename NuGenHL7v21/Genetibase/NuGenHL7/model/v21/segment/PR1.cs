using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 PR1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PR1-1: SET ID - PROCEDURE (SI)<br> 
	/// PR1-2: PROCEDURE CODING METHOD. (ID)<br> 
	/// PR1-3: PROCEDURE CODE (ID)<br> 
	/// PR1-4: PROCEDURE DESCRIPTION (ST)<br> 
	/// PR1-5: PROCEDURE DATE/TIME (TS)<br> 
	/// PR1-6: PROCEDURE TYPE (ID)<br> 
	/// PR1-7: PROCEDURE MINUTES (NM)<br> 
	/// PR1-8: ANESTHESIOLOGIST (CN)<br> 
	/// PR1-9: ANESTHESIA CODE (ID)<br> 
	/// PR1-10: ANESTHESIA MINUTES (NM)<br> 
	/// PR1-11: SURGEON (CN)<br> 
	/// PR1-12: RESIDENT CODE (CN)<br> 
	/// PR1-13: CONSENT CODE (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PR1:AbstractSegment
	{
		/// <summary> Returns PROCEDURE CODING METHOD. (PR1-2).</summary>
		virtual public ID PROCEDURECODINGMETHOD
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns PROCEDURE CODE (PR1-3).</summary>
		virtual public ID PROCEDURECODE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns PROCEDURE DESCRIPTION (PR1-4).</summary>
		virtual public ST PROCEDUREDESCRIPTION
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns PROCEDURE DATE/TIME (PR1-5).</summary>
		virtual public TS PROCEDUREDATETIME
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
		/// <summary> Returns PROCEDURE TYPE (PR1-6).</summary>
		virtual public ID PROCEDURETYPE
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
		/// <summary> Returns PROCEDURE MINUTES (PR1-7).</summary>
		virtual public NM PROCEDUREMINUTES
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
		/// <summary> Returns ANESTHESIOLOGIST (PR1-8).</summary>
		virtual public CN ANESTHESIOLOGIST
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
		/// <summary> Returns ANESTHESIA CODE (PR1-9).</summary>
		virtual public ID ANESTHESIACODE
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
		/// <summary> Returns ANESTHESIA MINUTES (PR1-10).</summary>
		virtual public NM ANESTHESIAMINUTES
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
		/// <summary> Returns SURGEON (PR1-11).</summary>
		virtual public CN SURGEON
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
		/// <summary> Returns RESIDENT CODE (PR1-12).</summary>
		virtual public CN RESIDENTCODE
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns CONSENT CODE (PR1-13).</summary>
		virtual public ID CONSENTCODE
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
		
		/// <summary> Creates a PR1 (PROCEDURES) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PR1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 0, 4, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 89});
				this.add(typeof(ID), true, 1, 10, new System.Object[]{message, 88});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 19, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 90});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 19});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 59});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of SET ID - PROCEDURE (PR1-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual SI getSETIDPROCEDURE(int rep)
		{
			SI ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (SI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of SET ID - PROCEDURE (PR1-1).</summary>
		public virtual SI[] getSETIDPROCEDURE()
		{
			SI[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new SI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (SI) t[i];
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