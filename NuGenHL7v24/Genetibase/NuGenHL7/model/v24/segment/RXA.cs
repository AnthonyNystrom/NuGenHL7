using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 RXA message segment. 
	/// This segment has the following fields:</p><p>
	/// RXA-1: Give Sub-ID Counter (NM)<br> 
	/// RXA-2: Administration Sub-ID Counter (NM)<br> 
	/// RXA-3: Date/Time Start of Administration (TS)<br> 
	/// RXA-4: Date/Time End of Administration (TS)<br> 
	/// RXA-5: Administered Code (CE)<br> 
	/// RXA-6: Administered Amount (NM)<br> 
	/// RXA-7: Administered Units (CE)<br> 
	/// RXA-8: Administered Dosage Form (CE)<br> 
	/// RXA-9: Administration Notes (CE)<br> 
	/// RXA-10: Administering Provider (XCN)<br> 
	/// RXA-11: Administered-at Location (LA2)<br> 
	/// RXA-12: Administered Per (Time Unit) (ST)<br> 
	/// RXA-13: Administered Strength (NM)<br> 
	/// RXA-14: Administered Strength Units (CE)<br> 
	/// RXA-15: Substance Lot Number (ST)<br> 
	/// RXA-16: Substance Expiration Date (TS)<br> 
	/// RXA-17: Substance Manufacturer Name (CE)<br> 
	/// RXA-18: Substance/Treatment Refusal Reason (CE)<br> 
	/// RXA-19: Indication (CE)<br> 
	/// RXA-20: Completion Status (ID)<br> 
	/// RXA-21: Action Code-RXA (ID)<br> 
	/// RXA-22: System Entry Date/Time (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RXA:AbstractSegment
	{
		/// <summary> Returns Give Sub-ID Counter (RXA-1).</summary>
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
		/// <summary> Returns Administration Sub-ID Counter (RXA-2).</summary>
		virtual public NM AdministrationSubIDCounter
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
		/// <summary> Returns Date/Time Start of Administration (RXA-3).</summary>
		virtual public TS DateTimeStartOfAdministration
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
		/// <summary> Returns Date/Time End of Administration (RXA-4).</summary>
		virtual public TS DateTimeEndOfAdministration
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Administered Code (RXA-5).</summary>
		virtual public CE AdministeredCode
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
		/// <summary> Returns Administered Amount (RXA-6).</summary>
		virtual public NM AdministeredAmount
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
		/// <summary> Returns Administered Units (RXA-7).</summary>
		virtual public CE AdministeredUnits
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
		/// <summary> Returns Administered Dosage Form (RXA-8).</summary>
		virtual public CE AdministeredDosageForm
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
		/// <summary> Returns Administered-at Location (RXA-11).</summary>
		virtual public LA2 AdministeredAtLocation
		{
			get
			{
				LA2 ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Administered Per (Time Unit) (RXA-12).</summary>
		virtual public ST AdministeredPerTimeUnit
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Administered Strength (RXA-13).</summary>
		virtual public NM AdministeredStrength
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Administered Strength Units (RXA-14).</summary>
		virtual public CE AdministeredStrengthUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Completion Status (RXA-20).</summary>
		virtual public ID CompletionStatus
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
		/// <summary> Returns Action Code-RXA (RXA-21).</summary>
		virtual public ID ActionCodeRXA
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns System Entry Date/Time (RXA-22).</summary>
		virtual public TS SystemEntryDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		
		/// <summary> Creates a RXA (Pharmacy/Treatment Administration) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RXA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(LA2), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 0, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 322});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 323});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Administration Notes (RXA-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getAdministrationNotes(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Administration Notes (RXA-9).</summary>
		public virtual CE[] getAdministrationNotes()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
		
		/// <summary> Returns a single repetition of Administering Provider (RXA-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getAdministeringProvider(int rep)
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
		
		/// <summary> Returns all repetitions of Administering Provider (RXA-10).</summary>
		public virtual XCN[] getAdministeringProvider()
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
		
		/// <summary> Returns a single repetition of Substance Lot Number (RXA-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getSubstanceLotNumber(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Substance Lot Number (RXA-15).</summary>
		public virtual ST[] getSubstanceLotNumber()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
		
		/// <summary> Returns a single repetition of Substance Expiration Date (RXA-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TS getSubstanceExpirationDate(int rep)
		{
			TS ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (TS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Substance Expiration Date (RXA-16).</summary>
		public virtual TS[] getSubstanceExpirationDate()
		{
			TS[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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
		
		/// <summary> Returns a single repetition of Substance Manufacturer Name (RXA-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getSubstanceManufacturerName(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Substance Manufacturer Name (RXA-17).</summary>
		public virtual CE[] getSubstanceManufacturerName()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(17);
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
		
		/// <summary> Returns a single repetition of Substance/Treatment Refusal Reason (RXA-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getSubstanceTreatmentRefusalReason(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Substance/Treatment Refusal Reason (RXA-18).</summary>
		public virtual CE[] getSubstanceTreatmentRefusalReason()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(18);
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
		
		/// <summary> Returns a single repetition of Indication (RXA-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getIndication(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Indication (RXA-19).</summary>
		public virtual CE[] getIndication()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(19);
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