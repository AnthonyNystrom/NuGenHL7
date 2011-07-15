using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 PRC message segment. 
	/// This segment has the following fields:</p><p>
	/// PRC-1: Primary Key Value - PRC (CE)<br> 
	/// PRC-2: Facility ID - PRC (CE)<br> 
	/// PRC-3: Department (CE)<br> 
	/// PRC-4: Valid Patient Classes (IS)<br> 
	/// PRC-5: Price (CP)<br> 
	/// PRC-6: Formula (ST)<br> 
	/// PRC-7: Minimum Quantity (NM)<br> 
	/// PRC-8: Maximum Quantity (NM)<br> 
	/// PRC-9: Minimum Price (MO)<br> 
	/// PRC-10: Maximum Price (MO)<br> 
	/// PRC-11: Effective Start Date (TS)<br> 
	/// PRC-12: Effective End Date (TS)<br> 
	/// PRC-13: Price Override Flag (IS)<br> 
	/// PRC-14: Billing Category (CE)<br> 
	/// PRC-15: Chargeable Flag (ID)<br> 
	/// PRC-16: Active/Inactive Flag (ID)<br> 
	/// PRC-17: Cost (MO)<br> 
	/// PRC-18: Charge On Indicator (IS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PRC:AbstractSegment
	{
		/// <summary> Returns Primary Key Value - PRC (PRC-1).</summary>
		virtual public CE PrimaryKeyValuePRC
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Minimum Quantity (PRC-7).</summary>
		virtual public NM MinimumQuantity
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
		/// <summary> Returns Maximum Quantity (PRC-8).</summary>
		virtual public NM MaximumQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Minimum Price (PRC-9).</summary>
		virtual public MO MinimumPrice
		{
			get
			{
				MO ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (MO) t;
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
		/// <summary> Returns Maximum Price (PRC-10).</summary>
		virtual public MO MaximumPrice
		{
			get
			{
				MO ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (MO) t;
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
		/// <summary> Returns Effective Start Date (PRC-11).</summary>
		virtual public TS EffectiveStartDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Effective End Date (PRC-12).</summary>
		virtual public TS EffectiveEndDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Price Override Flag (PRC-13).</summary>
		virtual public IS PriceOverrideFlag
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Chargeable Flag (PRC-15).</summary>
		virtual public ID ChargeableFlag
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
		/// <summary> Returns Active/Inactive Flag (PRC-16).</summary>
		virtual public ID ActiveInactiveFlag
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
		/// <summary> Returns Cost (PRC-17).</summary>
		virtual public MO Cost
		{
			get
			{
				MO ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (MO) t;
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
		/// <summary> Returns Charge On Indicator (PRC-18).</summary>
		virtual public IS ChargeOnIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		
		/// <summary> Creates a PRC (Pricing) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PRC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 4});
				this.add(typeof(CP), false, 0, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 200, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(MO), false, 1, 12, new System.Object[]{message});
				this.add(typeof(MO), false, 1, 12, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 268});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 183});
				this.add(typeof(MO), false, 1, 12, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 269});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Facility ID - PRC (PRC-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getFacilityIDPRC(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Facility ID - PRC (PRC-2).</summary>
		public virtual CE[] getFacilityIDPRC()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(2);
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
		
		/// <summary> Returns a single repetition of Department (PRC-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getDepartment(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Department (PRC-3).</summary>
		public virtual CE[] getDepartment()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Valid Patient Classes (PRC-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getValidPatientClasses(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Valid Patient Classes (PRC-4).</summary>
		public virtual IS[] getValidPatientClasses()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Price (PRC-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CP getPrice(int rep)
		{
			CP ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (CP) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Price (PRC-5).</summary>
		public virtual CP[] getPrice()
		{
			CP[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new CP[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CP) t[i];
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
		
		/// <summary> Returns a single repetition of Formula (PRC-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getFormula(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Formula (PRC-6).</summary>
		public virtual ST[] getFormula()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of Billing Category (PRC-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getBillingCategory(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Billing Category (PRC-14).</summary>
		public virtual CE[] getBillingCategory()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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