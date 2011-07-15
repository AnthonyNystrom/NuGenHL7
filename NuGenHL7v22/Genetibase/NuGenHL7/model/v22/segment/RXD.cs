using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 RXD message segment. 
	/// This segment has the following fields:</p><p>
	/// RXD-1: Dispense Sub-ID Counter (NM)<br> 
	/// RXD-2: Dispense / give code (CE)<br> 
	/// RXD-3: Date / time dispensed (TS)<br> 
	/// RXD-4: Actual Dispense Amount (NM)<br> 
	/// RXD-5: Actual Dispense Units (CE)<br> 
	/// RXD-6: Actual Dosage Form (CE)<br> 
	/// RXD-7: Prescription Number (ST)<br> 
	/// RXD-8: Number of Refills Remaining (NM)<br> 
	/// RXD-9: Dispense Notes (ST)<br> 
	/// RXD-10: Dispensing Provider (CN)<br> 
	/// RXD-11: Substitution Status (ID)<br> 
	/// RXD-12: Total Daily Dose (CQ_QUANTITY)<br> 
	/// RXD-13: Deliver-to location (CM_LA1)<br> 
	/// RXD-14: Needs Human Review (ID)<br> 
	/// RXD-15: Pharmacy Special Dispensing Instructions (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RXD:AbstractSegment
	{
		/// <summary> Returns Dispense Sub-ID Counter (RXD-1).</summary>
		virtual public NM DispenseSubIDCounter
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
		/// <summary> Returns Dispense / give code (RXD-2).</summary>
		virtual public CE DispenseGiveCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Date / time dispensed (RXD-3).</summary>
		virtual public TS DateTimeDispensed
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
		/// <summary> Returns Actual Dispense Amount (RXD-4).</summary>
		virtual public NM ActualDispenseAmount
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
		/// <summary> Returns Actual Dispense Units (RXD-5).</summary>
		virtual public CE ActualDispenseUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Actual Dosage Form (RXD-6).</summary>
		virtual public CE ActualDosageForm
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Prescription Number (RXD-7).</summary>
		virtual public ST PrescriptionNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Number of Refills Remaining (RXD-8).</summary>
		virtual public NM NumberOfRefillsRemaining
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
		/// <summary> Returns Dispensing Provider (RXD-10).</summary>
		virtual public CN DispensingProvider
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Substitution Status (RXD-11).</summary>
		virtual public ID SubstitutionStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Total Daily Dose (RXD-12).</summary>
		virtual public CQ_QUANTITY TotalDailyDose
		{
			get
			{
				CQ_QUANTITY ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CQ_QUANTITY) t;
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
		/// <summary> Returns Deliver-to location (RXD-13).</summary>
		virtual public CM_LA1 DeliverToLocation
		{
			get
			{
				CM_LA1 ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Needs Human Review (RXD-14).</summary>
		virtual public ID NeedsHumanReview
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Pharmacy Special Dispensing Instructions (RXD-15).</summary>
		virtual public CE PharmacySpecialDispensingInstructions
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
		
		/// <summary> Creates a RXD (PHARMACY DISPENSE) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RXD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 100, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167});
				this.add(typeof(CQ_QUANTITY), false, 1, 10, new System.Object[]{message});
				this.add(typeof(CM_LA1), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Dispense Notes (RXD-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getDispenseNotes(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Dispense Notes (RXD-9).</summary>
		public virtual ST[] getDispenseNotes()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
	}
}