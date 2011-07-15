using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 IN2 message segment. 
	/// This segment has the following fields:</p><p>
	/// IN2-1: Insured's employee ID (ST)<br> 
	/// IN2-2: Insured's social security number (ST)<br> 
	/// IN2-3: Insured's employer name (CN)<br> 
	/// IN2-4: Employer information data (ID)<br> 
	/// IN2-5: Mail claim party (ID)<br> 
	/// IN2-6: Medicare health insurance card number (NM)<br> 
	/// IN2-7: Medicaid case name (PN)<br> 
	/// IN2-8: Medicaid case number (NM)<br> 
	/// IN2-9: Champus sponsor name (PN)<br> 
	/// IN2-10: Champus ID number (NM)<br> 
	/// IN2-11: Dependent of champus recipient (ID)<br> 
	/// IN2-12: Champus organization (ST)<br> 
	/// IN2-13: Champus station (ST)<br> 
	/// IN2-14: Champus service (ID)<br> 
	/// IN2-15: Champus rank / grade (ID)<br> 
	/// IN2-16: Champus status (ID)<br> 
	/// IN2-17: Champus retire date (DT)<br> 
	/// IN2-18: Champus non-availability certification on file (ID)<br> 
	/// IN2-19: Baby coverage (ID)<br> 
	/// IN2-20: Combine baby bill (ID)<br> 
	/// IN2-21: Blood deductible (NM)<br> 
	/// IN2-22: Special coverage approval name (PN)<br> 
	/// IN2-23: Special coverage approval title (ST)<br> 
	/// IN2-24: Non-covered insurance code (ID)<br> 
	/// IN2-25: Payor ID (ST)<br> 
	/// IN2-26: Payor subscriber ID (ST)<br> 
	/// IN2-27: Eligibility source (ID)<br> 
	/// IN2-28: Room coverage type / amount (CM_RMC)<br> 
	/// IN2-29: Policy type / amount (CM_PTA)<br> 
	/// IN2-30: Daily deductible (CM_DDI)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IN2:AbstractSegment
	{
		/// <summary> Returns Insured's employee ID (IN2-1).</summary>
		virtual public ST InsuredSEmployeeID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Insured's social security number (IN2-2).</summary>
		virtual public ST InsuredSSocialSecurityNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Insured's employer name (IN2-3).</summary>
		virtual public CN InsuredSEmployerName
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Employer information data (IN2-4).</summary>
		virtual public ID EmployerInformationData
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Mail claim party (IN2-5).</summary>
		virtual public ID MailClaimParty
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Medicare health insurance card number (IN2-6).</summary>
		virtual public NM MedicareHealthInsuranceCardNumber
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
		/// <summary> Returns Medicaid case name (IN2-7).</summary>
		virtual public PN MedicaidCaseName
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (PN) t;
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
		/// <summary> Returns Medicaid case number (IN2-8).</summary>
		virtual public NM MedicaidCaseNumber
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
		/// <summary> Returns Champus sponsor name (IN2-9).</summary>
		virtual public PN ChampusSponsorName
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (PN) t;
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
		/// <summary> Returns Champus ID number (IN2-10).</summary>
		virtual public NM ChampusIDNumber
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
		/// <summary> Returns Dependent of champus recipient (IN2-11).</summary>
		virtual public ID DependentOfChampusRecipient
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
		/// <summary> Returns Champus organization (IN2-12).</summary>
		virtual public ST ChampusOrganization
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
		/// <summary> Returns Champus station (IN2-13).</summary>
		virtual public ST ChampusStation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Champus service (IN2-14).</summary>
		virtual public ID ChampusService
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
		/// <summary> Returns Champus rank / grade (IN2-15).</summary>
		virtual public ID ChampusRankGrade
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
		/// <summary> Returns Champus status (IN2-16).</summary>
		virtual public ID ChampusStatus
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
		/// <summary> Returns Champus retire date (IN2-17).</summary>
		virtual public DT ChampusRetireDate
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
		/// <summary> Returns Champus non-availability certification on file (IN2-18).</summary>
		virtual public ID ChampusNonAvailabilityCertificationOnFile
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Baby coverage (IN2-19).</summary>
		virtual public ID BabyCoverage
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Combine baby bill (IN2-20).</summary>
		virtual public ID CombineBabyBill
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
		/// <summary> Returns Blood deductible (IN2-21).</summary>
		virtual public NM BloodDeductible
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Special coverage approval name (IN2-22).</summary>
		virtual public PN SpecialCoverageApprovalName
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(22, 0);
					ret = (PN) t;
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
		/// <summary> Returns Special coverage approval title (IN2-23).</summary>
		virtual public ST SpecialCoverageApprovalTitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Payor ID (IN2-25).</summary>
		virtual public ST PayorID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Payor subscriber ID (IN2-26).</summary>
		virtual public ST PayorSubscriberID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns Eligibility source (IN2-27).</summary>
		virtual public ID EligibilitySource
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Daily deductible (IN2-30).</summary>
		virtual public CM_DDI DailyDeductible
		{
			get
			{
				CM_DDI ret = null;
				try
				{
					Type t = this.getField(30, 0);
					ret = (CM_DDI) t;
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
		
		/// <summary> Creates a IN2 (INSURANCE ADDITIONAL INFO) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IN2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 9, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 139});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 137});
				this.add(typeof(NM), false, 1, 15, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 15, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 14, new System.Object[]{message, 140});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 141});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 142});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(NM), false, 1, 1, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 8, new System.Object[]{message, 143});
				this.add(typeof(ST), false, 1, 6, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 6, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 144});
				this.add(typeof(CM_RMC), false, 0, 25, new System.Object[]{message});
				this.add(typeof(CM_PTA), false, 0, 25, new System.Object[]{message});
				this.add(typeof(CM_DDI), false, 1, 25, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Non-covered insurance code (IN2-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getNonCoveredInsuranceCode(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(24, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Non-covered insurance code (IN2-24).</summary>
		public virtual ID[] getNonCoveredInsuranceCode()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(24);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
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
		
		/// <summary> Returns a single repetition of Room coverage type / amount (IN2-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_RMC getRoomCoverageTypeAmount(int rep)
		{
			CM_RMC ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (CM_RMC) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Room coverage type / amount (IN2-28).</summary>
		public virtual CM_RMC[] getRoomCoverageTypeAmount()
		{
			CM_RMC[] ret = null;
			try
			{
				Type[] t = this.getField(28);
				ret = new CM_RMC[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_RMC) t[i];
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
		
		/// <summary> Returns a single repetition of Policy type / amount (IN2-29).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_PTA getPolicyTypeAmount(int rep)
		{
			CM_PTA ret = null;
			try
			{
				Type t = this.getField(29, rep);
				ret = (CM_PTA) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Policy type / amount (IN2-29).</summary>
		public virtual CM_PTA[] getPolicyTypeAmount()
		{
			CM_PTA[] ret = null;
			try
			{
				Type[] t = this.getField(29);
				ret = new CM_PTA[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_PTA) t[i];
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