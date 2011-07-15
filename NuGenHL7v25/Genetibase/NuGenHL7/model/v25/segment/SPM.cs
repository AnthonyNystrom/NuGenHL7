using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 SPM message segment. 
	/// This segment has the following fields:</p><p>
	/// SPM-1: Set ID _ SPM (SI)<br> 
	/// SPM-2: Specimen ID (EIP)<br> 
	/// SPM-3: Specimen Parent IDs (EIP)<br> 
	/// SPM-4: Specimen Type (CWE)<br> 
	/// SPM-5: Specimen Type Modifier (CWE)<br> 
	/// SPM-6: Specimen Additives (CWE)<br> 
	/// SPM-7: Specimen Collection Method (CWE)<br> 
	/// SPM-8: Specimen Source Site (CWE)<br> 
	/// SPM-9: Specimen Source Site Modifier (CWE)<br> 
	/// SPM-10: Specimen Collection Site (CWE)<br> 
	/// SPM-11: Specimen Role (CWE)<br> 
	/// SPM-12: Specimen Collection Amount (CQ)<br> 
	/// SPM-13: Grouped Specimen Count (NM)<br> 
	/// SPM-14: Specimen Description (ST)<br> 
	/// SPM-15: Specimen Handling Code (CWE)<br> 
	/// SPM-16: Specimen Risk Code (CWE)<br> 
	/// SPM-17: Specimen Collection Date/Time (DR)<br> 
	/// SPM-18: Specimen Received Date/Time (TS)<br> 
	/// SPM-19: Specimen Expiration Date/Time (TS)<br> 
	/// SPM-20: Specimen Availability (ID)<br> 
	/// SPM-21: Specimen Reject Reason (CWE)<br> 
	/// SPM-22: Specimen Quality (CWE)<br> 
	/// SPM-23: Specimen Appropriateness (CWE)<br> 
	/// SPM-24: Specimen Condition (CWE)<br> 
	/// SPM-25: Specimen Current Quantity (CQ)<br> 
	/// SPM-26: Number of Specimen Containers (NM)<br> 
	/// SPM-27: Container Type (CWE)<br> 
	/// SPM-28: Container Condition (CWE)<br> 
	/// SPM-29: Specimen Child Role (CWE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class SPM:AbstractSegment
	{
		/// <summary> Returns Set ID _ SPM (SPM-1).</summary>
		virtual public SI SetIDSPM
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
		/// <summary> Returns Specimen ID (SPM-2).</summary>
		virtual public EIP SpecimenID
		{
			get
			{
				EIP ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (EIP) t;
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
		/// <summary> Returns Specimen Type (SPM-4).</summary>
		virtual public CWE SpecimenType
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Specimen Collection Method (SPM-7).</summary>
		virtual public CWE SpecimenCollectionMethod
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Specimen Source Site (SPM-8).</summary>
		virtual public CWE SpecimenSourceSite
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Specimen Collection Site (SPM-10).</summary>
		virtual public CWE SpecimenCollectionSite
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Specimen Collection Amount (SPM-12).</summary>
		virtual public CQ SpecimenCollectionAmount
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
		/// <summary> Returns Grouped Specimen Count (SPM-13).</summary>
		virtual public NM GroupedSpecimenCount
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
		/// <summary> Returns Specimen Collection Date/Time (SPM-17).</summary>
		virtual public DR SpecimenCollectionDateTime
		{
			get
			{
				DR ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (DR) t;
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
		/// <summary> Returns Specimen Received Date/Time (SPM-18).</summary>
		virtual public TS SpecimenReceivedDateTime
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
		/// <summary> Returns Specimen Expiration Date/Time (SPM-19).</summary>
		virtual public TS SpecimenExpirationDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Specimen Availability (SPM-20).</summary>
		virtual public ID SpecimenAvailability
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
		/// <summary> Returns Specimen Quality (SPM-22).</summary>
		virtual public CWE SpecimenQuality
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(22, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Specimen Appropriateness (SPM-23).</summary>
		virtual public CWE SpecimenAppropriateness
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Specimen Current Quantity (SPM-25).</summary>
		virtual public CQ SpecimenCurrentQuantity
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Number of Specimen Containers (SPM-26).</summary>
		virtual public NM NumberOfSpecimenContainers
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns Container Type (SPM-27).</summary>
		virtual public CWE ContainerType
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(27, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Container Condition (SPM-28).</summary>
		virtual public CWE ContainerCondition
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(28, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Specimen Child Role (SPM-29).</summary>
		virtual public CWE SpecimenChildRole
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(29, 0);
					ret = (CWE) t;
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
		
		/// <summary> Creates a SPM (Specimen) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public SPM(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(EIP), false, 1, 80, new System.Object[]{message});
				this.add(typeof(EIP), false, 0, 80, new System.Object[]{message});
				this.add(typeof(CWE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 6, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(DR), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Specimen Parent IDs (SPM-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EIP getSpecimenParentIDs(int rep)
		{
			EIP ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (EIP) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Parent IDs (SPM-3).</summary>
		public virtual EIP[] getSpecimenParentIDs()
		{
			EIP[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new EIP[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EIP) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Type Modifier (SPM-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenTypeModifier(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Type Modifier (SPM-5).</summary>
		public virtual CWE[] getSpecimenTypeModifier()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Additives (SPM-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenAdditives(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Additives (SPM-6).</summary>
		public virtual CWE[] getSpecimenAdditives()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Source Site Modifier (SPM-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenSourceSiteModifier(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Source Site Modifier (SPM-9).</summary>
		public virtual CWE[] getSpecimenSourceSiteModifier()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Role (SPM-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenRole(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Role (SPM-11).</summary>
		public virtual CWE[] getSpecimenRole()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Description (SPM-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getSpecimenDescription(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Description (SPM-14).</summary>
		public virtual ST[] getSpecimenDescription()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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
		
		/// <summary> Returns a single repetition of Specimen Handling Code (SPM-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenHandlingCode(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Handling Code (SPM-15).</summary>
		public virtual CWE[] getSpecimenHandlingCode()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(15);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Risk Code (SPM-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenRiskCode(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Risk Code (SPM-16).</summary>
		public virtual CWE[] getSpecimenRiskCode()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(16);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Reject Reason (SPM-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenRejectReason(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Reject Reason (SPM-21).</summary>
		public virtual CWE[] getSpecimenRejectReason()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(21);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of Specimen Condition (SPM-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSpecimenCondition(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(24, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Condition (SPM-24).</summary>
		public virtual CWE[] getSpecimenCondition()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(24);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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