using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 LDP message segment. 
	/// This segment has the following fields:</p><p>
	/// LDP-1: Primary Key Value - LDP (PL)<br> 
	/// LDP-2: Location Department (IS)<br> 
	/// LDP-3: Location Service (IS)<br> 
	/// LDP-4: Specialty Type (CE)<br> 
	/// LDP-5: Valid Patient Classes (IS)<br> 
	/// LDP-6: Active/Inactive Flag (ID)<br> 
	/// LDP-7: Activation Date  LDP (TS)<br> 
	/// LDP-8: Inactivation Date - LDP (TS)<br> 
	/// LDP-9: Inactivated Reason (ST)<br> 
	/// LDP-10: Visiting Hours (VH)<br> 
	/// LDP-11: Contact Phone (XTN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class LDP:AbstractSegment
	{
		/// <summary> Returns Primary Key Value - LDP (LDP-1).</summary>
		virtual public PL PrimaryKeyValueLDP
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (PL) t;
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
		/// <summary> Returns Location Department (LDP-2).</summary>
		virtual public IS LocationDepartment
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (IS) t;
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
		/// <summary> Returns Active/Inactive Flag (LDP-6).</summary>
		virtual public ID ActiveInactiveFlag
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
		/// <summary> Returns Activation Date  LDP (LDP-7).</summary>
		virtual public TS ActivationDateLDP
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
		/// <summary> Returns Inactivation Date - LDP (LDP-8).</summary>
		virtual public TS InactivationDateLDP
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Inactivated Reason (LDP-9).</summary>
		virtual public ST InactivatedReason
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Contact Phone (LDP-11).</summary>
		virtual public XTN ContactPhone
		{
			get
			{
				XTN ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (XTN) t;
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
		
		/// <summary> Creates a LDP (LDP - location department segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public LDP(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(PL), true, 1, 200, new System.Object[]{message});
				this.add(typeof(IS), true, 1, 10, new System.Object[]{message, 264});
				this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 69});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 4});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 183});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(VH), false, 0, 80, new System.Object[]{message});
				this.add(typeof(XTN), false, 1, 40, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Location Service (LDP-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getLocationService(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Location Service (LDP-3).</summary>
		public virtual IS[] getLocationService()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Specialty Type (LDP-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getSpecialtyType(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specialty Type (LDP-4).</summary>
		public virtual CE[] getSpecialtyType()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Valid Patient Classes (LDP-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getValidPatientClasses(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Valid Patient Classes (LDP-5).</summary>
		public virtual IS[] getValidPatientClasses()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Visiting Hours (LDP-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual VH getVisitingHours(int rep)
		{
			VH ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (VH) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Visiting Hours (LDP-10).</summary>
		public virtual VH[] getVisitingHours()
		{
			VH[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new VH[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (VH) t[i];
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