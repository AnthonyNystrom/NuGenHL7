using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 RXE message segment. 
	/// This segment has the following fields:</p><p>
	/// RXE-1: Quantity / timing (TQ)<br> 
	/// RXE-2: Give Code (CE)<br> 
	/// RXE-3: Give Amount - Minimum (NM)<br> 
	/// RXE-4: Give Amount - Maximum (NM)<br> 
	/// RXE-5: Give Units (CE)<br> 
	/// RXE-6: Give Dosage Form (CE)<br> 
	/// RXE-7: Provider's Administration Instructions (CE)<br> 
	/// RXE-8: Deliver-to location (CM_LA1)<br> 
	/// RXE-9: Substitution Status (ID)<br> 
	/// RXE-10: Dispense Amount (NM)<br> 
	/// RXE-11: Dispense Units (CE)<br> 
	/// RXE-12: Number of Refills (NM)<br> 
	/// RXE-13: Ordering Provider's DEA Number (CN)<br> 
	/// RXE-14: Pharmacist Verifier ID (CN)<br> 
	/// RXE-15: Prescription Number (ST)<br> 
	/// RXE-16: Number of Refills Remaining (NM)<br> 
	/// RXE-17: Number of refills / doses dispensed (NM)<br> 
	/// RXE-18: Date / time of most recent refill or dose dispensed (TS)<br> 
	/// RXE-19: Total Daily Dose (CQ_QUANTITY)<br> 
	/// RXE-20: Needs Human Review (ID)<br> 
	/// RXE-21: Pharmacy Special Dispensing Instructions (CE)<br> 
	/// RXE-22: Give Per (Time Unit) (ST)<br> 
	/// RXE-23: Give Rate Amount (CE)<br> 
	/// RXE-24: Give Rate Units (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RXE:AbstractSegment
	{
		/// <summary> Returns Give Code (RXE-2).</summary>
		virtual public CE GiveCode
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
		/// <summary> Returns Give Amount - Minimum (RXE-3).</summary>
		virtual public NM GiveAmountMinimum
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Give Amount - Maximum (RXE-4).</summary>
		virtual public NM GiveAmountMaximum
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
		/// <summary> Returns Give Units (RXE-5).</summary>
		virtual public CE GiveUnits
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
		/// <summary> Returns Give Dosage Form (RXE-6).</summary>
		virtual public CE GiveDosageForm
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
		/// <summary> Returns Deliver-to location (RXE-8).</summary>
		virtual public CM_LA1 DeliverToLocation
		{
			get
			{
				CM_LA1 ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Substitution Status (RXE-9).</summary>
		virtual public ID SubstitutionStatus
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
		/// <summary> Returns Dispense Amount (RXE-10).</summary>
		virtual public NM DispenseAmount
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
		/// <summary> Returns Dispense Units (RXE-11).</summary>
		virtual public CE DispenseUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Number of Refills (RXE-12).</summary>
		virtual public NM NumberOfRefills
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Ordering Provider's DEA Number (RXE-13).</summary>
		virtual public CN OrderingProviderSDEANumber
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Pharmacist Verifier ID (RXE-14).</summary>
		virtual public CN PharmacistVerifierID
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Prescription Number (RXE-15).</summary>
		virtual public ST PrescriptionNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Number of Refills Remaining (RXE-16).</summary>
		virtual public NM NumberOfRefillsRemaining
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Number of refills / doses dispensed (RXE-17).</summary>
		virtual public NM NumberOfRefillsDosesDispensed
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Date / time of most recent refill or dose dispensed (RXE-18).</summary>
		virtual public TS DateTimeOfMostRecentRefillOrDoseDispensed
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Total Daily Dose (RXE-19).</summary>
		virtual public CQ_QUANTITY TotalDailyDose
		{
			get
			{
				CQ_QUANTITY ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Needs Human Review (RXE-20).</summary>
		virtual public ID NeedsHumanReview
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
		/// <summary> Returns Pharmacy Special Dispensing Instructions (RXE-21).</summary>
		virtual public CE PharmacySpecialDispensingInstructions
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Give Per (Time Unit) (RXE-22).</summary>
		virtual public ST GivePerTimeUnit
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Give Rate Amount (RXE-23).</summary>
		virtual public CE GiveRateAmount
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Give Rate Units (RXE-24).</summary>
		virtual public CE GiveRateUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		
		/// <summary> Creates a RXE (PHARMACY ENCODED ORDER) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RXE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(TQ), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 100, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CM_LA1), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CQ_QUANTITY), false, 1, 10, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 6, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Quantity / timing (RXE-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TQ getQuantityTiming(int rep)
		{
			TQ ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (TQ) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Quantity / timing (RXE-1).</summary>
		public virtual TQ[] getQuantityTiming()
		{
			TQ[] ret = null;
			try
			{
				Type[] t = this.getField(1);
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
		
		/// <summary> Returns a single repetition of Provider's Administration Instructions (RXE-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProviderSAdministrationInstructions(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Provider's Administration Instructions (RXE-7).</summary>
		public virtual CE[] getProviderSAdministrationInstructions()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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