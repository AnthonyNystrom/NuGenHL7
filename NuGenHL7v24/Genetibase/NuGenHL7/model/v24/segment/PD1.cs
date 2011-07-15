using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 PD1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PD1-1: Living Dependency (IS)<br> 
	/// PD1-2: Living Arrangement (IS)<br> 
	/// PD1-3: Patient Primary Facility (XON)<br> 
	/// PD1-4: Patient Primary Care Provider Name & ID No. (XCN)<br> 
	/// PD1-5: Student Indicator (IS)<br> 
	/// PD1-6: Handicap (IS)<br> 
	/// PD1-7: Living Will Code (IS)<br> 
	/// PD1-8: Organ Donor Code (IS)<br> 
	/// PD1-9: Separate Bill (ID)<br> 
	/// PD1-10: Duplicate Patient (CX)<br> 
	/// PD1-11: Publicity Code (CE)<br> 
	/// PD1-12: Protection Indicator (ID)<br> 
	/// PD1-13: Protection Indicator Effective Date (DT)<br> 
	/// PD1-14: Place of Worship (XON)<br> 
	/// PD1-15: Advance Directive Code (CE)<br> 
	/// PD1-16: Immunization Registry Status (IS)<br> 
	/// PD1-17: Immunization Registry Status Effective Date (DT)<br> 
	/// PD1-18: Publicity Code Effective Date (DT)<br> 
	/// PD1-19: Military Branch (IS)<br> 
	/// PD1-20: Military Rank/Grade (IS)<br> 
	/// PD1-21: Military Status (IS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PD1:AbstractSegment
	{
		/// <summary> Returns Living Arrangement (PD1-2).</summary>
		virtual public IS LivingArrangement
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
		/// <summary> Returns Student Indicator (PD1-5).</summary>
		virtual public IS StudentIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Handicap (PD1-6).</summary>
		virtual public IS Handicap
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Living Will Code (PD1-7).</summary>
		virtual public IS LivingWillCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Organ Donor Code (PD1-8).</summary>
		virtual public IS OrganDonorCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Separate Bill (PD1-9).</summary>
		virtual public ID SeparateBill
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
		/// <summary> Returns Publicity Code (PD1-11).</summary>
		virtual public CE PublicityCode
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
		/// <summary> Returns Protection Indicator (PD1-12).</summary>
		virtual public ID ProtectionIndicator
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
		/// <summary> Returns Protection Indicator Effective Date (PD1-13).</summary>
		virtual public DT ProtectionIndicatorEffectiveDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (DT) t;
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
		/// <summary> Returns Immunization Registry Status (PD1-16).</summary>
		virtual public IS ImmunizationRegistryStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Immunization Registry Status Effective Date (PD1-17).</summary>
		virtual public DT ImmunizationRegistryStatusEffectiveDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (DT) t;
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
		/// <summary> Returns Publicity Code Effective Date (PD1-18).</summary>
		virtual public DT PublicityCodeEffectiveDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (DT) t;
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
		/// <summary> Returns Military Branch (PD1-19).</summary>
		virtual public IS MilitaryBranch
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Military Rank/Grade (PD1-20).</summary>
		virtual public IS MilitaryRankGrade
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Military Status (PD1-21).</summary>
		virtual public IS MilitaryStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		
		/// <summary> Creates a PD1 (patient additional demographic) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PD1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 223});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 315});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 316});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 441});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 5, new System.Object[]{message, 140});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 141});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 142});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Living Dependency (PD1-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getLivingDependency(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Living Dependency (PD1-1).</summary>
		public virtual IS[] getLivingDependency()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(1);
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
		
		/// <summary> Returns a single repetition of Patient Primary Facility (PD1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getPatientPrimaryFacility(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Primary Facility (PD1-3).</summary>
		public virtual XON[] getPatientPrimaryFacility()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new XON[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XON) t[i];
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
		
		/// <summary> Returns a single repetition of Patient Primary Care Provider Name & ID No. (PD1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getPatientPrimaryCareProviderNameIDNo(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Primary Care Provider Name & ID No. (PD1-4).</summary>
		public virtual XCN[] getPatientPrimaryCareProviderNameIDNo()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Duplicate Patient (PD1-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getDuplicatePatient(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Duplicate Patient (PD1-10).</summary>
		public virtual CX[] getDuplicatePatient()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CX) t[i];
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
		
		/// <summary> Returns a single repetition of Place of Worship (PD1-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getPlaceOfWorship(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Place of Worship (PD1-14).</summary>
		public virtual XON[] getPlaceOfWorship()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(14);
				ret = new XON[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XON) t[i];
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
		
		/// <summary> Returns a single repetition of Advance Directive Code (PD1-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getAdvanceDirectiveCode(int rep)
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
		
		/// <summary> Returns all repetitions of Advance Directive Code (PD1-15).</summary>
		public virtual CE[] getAdvanceDirectiveCode()
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
	}
}