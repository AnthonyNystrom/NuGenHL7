using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 RXD message segment. 
	/// This segment has the following fields:</p><p>
	/// RXD-1: Dispense Sub-ID Counter (NM)<br> 
	/// RXD-2: Dispense/Give Code (CE)<br> 
	/// RXD-3: Date/Time Dispensed (TS)<br> 
	/// RXD-4: Actual Dispense Amount (NM)<br> 
	/// RXD-5: Actual Dispense Units (CE)<br> 
	/// RXD-6: Actual Dosage Form (CE)<br> 
	/// RXD-7: Prescription Number (ST)<br> 
	/// RXD-8: Number of Refills Remaining (NM)<br> 
	/// RXD-9: Dispense Notes (ST)<br> 
	/// RXD-10: Dispensing Provider (XCN)<br> 
	/// RXD-11: Substitution Status (ID)<br> 
	/// RXD-12: Total Daily Dose (CQ)<br> 
	/// RXD-13: Dispense-To Location (LA2)<br> 
	/// RXD-14: Needs Human Review (ID)<br> 
	/// RXD-15: Pharmacy/Treatment Supplier's Special Dispensing Instructions (CE)<br> 
	/// RXD-16: Actual Strength (NM)<br> 
	/// RXD-17: Actual Strength Unit (CE)<br> 
	/// RXD-18: Substance Lot Number (ST)<br> 
	/// RXD-19: Substance Expiration Date (TS)<br> 
	/// RXD-20: Substance Manufacturer Name (CE)<br> 
	/// RXD-21: Indication (CE)<br> 
	/// RXD-22: Dispense Package Size (NM)<br> 
	/// RXD-23: Dispense Package Size Unit (CE)<br> 
	/// RXD-24: Dispense Package Method (ID)<br> 
	/// RXD-25: Supplementary Code (CE)<br> 
	/// RXD-26: Initiating Location (CE)<br> 
	/// RXD-27: Packaging/Assembly Location (CE)<br> 
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
		/// <summary> Returns Dispense/Give Code (RXD-2).</summary>
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
		/// <summary> Returns Date/Time Dispensed (RXD-3).</summary>
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
		virtual public CQ TotalDailyDose
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CQ) t;
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
		/// <summary> Returns Dispense-To Location (RXD-13).</summary>
		virtual public LA2 DispenseToLocation
		{
			get
			{
				LA2 ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (LA2) t;
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
		/// <summary> Returns Actual Strength (RXD-16).</summary>
		virtual public NM ActualStrength
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
		/// <summary> Returns Actual Strength Unit (RXD-17).</summary>
		virtual public CE ActualStrengthUnit
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Dispense Package Size (RXD-22).</summary>
		virtual public NM DispensePackageSize
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Dispense Package Size Unit (RXD-23).</summary>
		virtual public CE DispensePackageSizeUnit
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
		/// <summary> Returns Dispense Package Method (RXD-24).</summary>
		virtual public ID DispensePackageMethod
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Initiating Location (RXD-26).</summary>
		virtual public CE InitiatingLocation
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns Packaging/Assembly Location (RXD-27).</summary>
		virtual public CE PackagingAssemblyLocation
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		
		/// <summary> Creates a RXD (Pharmacy/Treatment Dispense) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RXD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 200, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167});
				this.add(typeof(CQ), false, 1, 10, new System.Object[]{message});
				this.add(typeof(LA2), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 0, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 321});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
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
		
		/// <summary> Returns a single repetition of Dispensing Provider (RXD-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getDispensingProvider(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Dispensing Provider (RXD-10).</summary>
		public virtual XCN[] getDispensingProvider()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Pharmacy/Treatment Supplier's Special Dispensing Instructions (RXD-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getPharmacyTreatmentSupplierSSpecialDispensingInstructions(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Pharmacy/Treatment Supplier's Special Dispensing Instructions (RXD-15).</summary>
		public virtual CE[] getPharmacyTreatmentSupplierSSpecialDispensingInstructions()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
		
		/// <summary> Returns a single repetition of Substance Lot Number (RXD-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getSubstanceLotNumber(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Substance Lot Number (RXD-18).</summary>
		public virtual ST[] getSubstanceLotNumber()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(18);
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
		
		/// <summary> Returns a single repetition of Substance Expiration Date (RXD-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TS getSubstanceExpirationDate(int rep)
		{
			TS ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (TS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Substance Expiration Date (RXD-19).</summary>
		public virtual TS[] getSubstanceExpirationDate()
		{
			TS[] ret = null;
			try
			{
				Type[] t = this.getField(19);
				ret = new TS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TS) t[i];
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
		
		/// <summary> Returns a single repetition of Substance Manufacturer Name (RXD-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getSubstanceManufacturerName(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Substance Manufacturer Name (RXD-20).</summary>
		public virtual CE[] getSubstanceManufacturerName()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(20);
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
		
		/// <summary> Returns a single repetition of Indication (RXD-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getIndication(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Indication (RXD-21).</summary>
		public virtual CE[] getIndication()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(21);
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
		
		/// <summary> Returns a single repetition of Supplementary Code (RXD-25).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getSupplementaryCode(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(25, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Supplementary Code (RXD-25).</summary>
		public virtual CE[] getSupplementaryCode()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(25);
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