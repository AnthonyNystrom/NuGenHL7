using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 RXG message segment. 
	/// This segment has the following fields:</p><p>
	/// RXG-1: Give Sub-ID Counter (NM)<br> 
	/// RXG-2: Dispense Sub-ID Counter (NM)<br> 
	/// RXG-3: Quantity / timing (TQ)<br> 
	/// RXG-4: Give Code (CE)<br> 
	/// RXG-5: Give Amount - Minimum (NM)<br> 
	/// RXG-6: Give Amount - Maximum (NM)<br> 
	/// RXG-7: Give Units (CE)<br> 
	/// RXG-8: Give Dosage Form (CE)<br> 
	/// RXG-9: Administration Notes (ST)<br> 
	/// RXG-10: Substitution Status (ID)<br> 
	/// RXG-11: Deliver-to location (CM_LA1)<br> 
	/// RXG-12: Needs Human Review (ID)<br> 
	/// RXG-13: Pharmacy Special Administration Instructions (CE)<br> 
	/// RXG-14: Give Per (Time Unit) (ST)<br> 
	/// RXG-15: Give Rate Amount (CE)<br> 
	/// RXG-16: Give Rate Units (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RXG:AbstractSegment
	{
		/// <summary> Returns Give Sub-ID Counter (RXG-1).</summary>
		virtual public NM GiveSubIDCounter
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Dispense Sub-ID Counter (RXG-2).</summary>
		virtual public NM DispenseSubIDCounter
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Give Code (RXG-4).</summary>
		virtual public CE GiveCode
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
		/// <summary> Returns Give Amount - Minimum (RXG-5).</summary>
		virtual public NM GiveAmountMinimum
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Give Amount - Maximum (RXG-6).</summary>
		virtual public NM GiveAmountMaximum
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Give Units (RXG-7).</summary>
		virtual public CE GiveUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Give Dosage Form (RXG-8).</summary>
		virtual public CE GiveDosageForm
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Administration Notes (RXG-9).</summary>
		virtual public ST AdministrationNotes
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
		/// <summary> Returns Substitution Status (RXG-10).</summary>
		virtual public ID SubstitutionStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Deliver-to location (RXG-11).</summary>
		virtual public CM_LA1 DeliverToLocation
		{
			get
			{
				CM_LA1 ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CM_LA1) t;
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
		/// <summary> Returns Needs Human Review (RXG-12).</summary>
		virtual public ID NeedsHumanReview
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Give Per (Time Unit) (RXG-14).</summary>
		virtual public ST GivePerTimeUnit
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
		/// <summary> Returns Give Rate Amount (RXG-15).</summary>
		virtual public CE GiveRateAmount
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Give Rate Units (RXG-16).</summary>
		virtual public CE GiveRateUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		
		/// <summary> Creates a RXG (PHARMACY GIVE) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RXG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(TQ), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 100, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167});
				this.add(typeof(CM_LA1), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 6, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Quantity / timing (RXG-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TQ getQuantityTiming(int rep)
		{
			TQ ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (TQ) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Quantity / timing (RXG-3).</summary>
		public virtual TQ[] getQuantityTiming()
		{
			TQ[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new TQ[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TQ) t[i];
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
		
		/// <summary> Returns a single repetition of Pharmacy Special Administration Instructions (RXG-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getPharmacySpecialAdministrationInstructions(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Pharmacy Special Administration Instructions (RXG-13).</summary>
		public virtual CE[] getPharmacySpecialAdministrationInstructions()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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