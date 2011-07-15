using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 IN1 message segment. 
	/// This segment has the following fields:</p><p>
	/// IN1-1: Set ID - insurance (SI)<br> 
	/// IN1-2: Insurance plan ID (ID)<br> 
	/// IN1-3: Insurance company ID (ST)<br> 
	/// IN1-4: Insurance company name (ST)<br> 
	/// IN1-5: Insurance company address (AD)<br> 
	/// IN1-6: Insurance company contact pers (PN)<br> 
	/// IN1-7: Insurance company phone number (TN)<br> 
	/// IN1-8: Group number (ST)<br> 
	/// IN1-9: Group name (ST)<br> 
	/// IN1-10: Insured's group employer ID (ST)<br> 
	/// IN1-11: Insured's group employer name (ST)<br> 
	/// IN1-12: Plan effective date (DT)<br> 
	/// IN1-13: Plan expiration date (DT)<br> 
	/// IN1-14: Authorization information (CM_AUI)<br> 
	/// IN1-15: Plan type (ID)<br> 
	/// IN1-16: Name of insured (PN)<br> 
	/// IN1-17: Insured's relationship to patient (ID)<br> 
	/// IN1-18: Insured's date of birth (DT)<br> 
	/// IN1-19: Insured's address (AD)<br> 
	/// IN1-20: Assignment of benefits (ID)<br> 
	/// IN1-21: Coordination of benefits (ID)<br> 
	/// IN1-22: Coordination of benefits - priority (ST)<br> 
	/// IN1-23: Notice of admission code (ID)<br> 
	/// IN1-24: Notice of admission date (DT)<br> 
	/// IN1-25: Report of eligibility code (ID)<br> 
	/// IN1-26: Report of eligibility date (DT)<br> 
	/// IN1-27: Release information code (ID)<br> 
	/// IN1-28: Pre-admit certification (PAC) (ST)<br> 
	/// IN1-29: Verification date / time (TS)<br> 
	/// IN1-30: Verification by (CN)<br> 
	/// IN1-31: Type of agreement code (ID)<br> 
	/// IN1-32: Billing status (ID)<br> 
	/// IN1-33: Lifetime reserve days (NM)<br> 
	/// IN1-34: Delay before lifetime reserve days (NM)<br> 
	/// IN1-35: Company plan code (ID)<br> 
	/// IN1-36: Policy number (ST)<br> 
	/// IN1-37: Policy deductible (NM)<br> 
	/// IN1-38: Policy limit - amount (NM)<br> 
	/// IN1-39: Policy limit - days (NM)<br> 
	/// IN1-40: Room rate - semi-private (NM)<br> 
	/// IN1-41: Room rate - private (NM)<br> 
	/// IN1-42: Insured's employment status (CE)<br> 
	/// IN1-43: Insured's sex (ID)<br> 
	/// IN1-44: Insured's employer address (AD)<br> 
	/// IN1-45: Verification status (ST)<br> 
	/// IN1-46: Prior insurance plan ID (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IN1:AbstractSegment
	{
		/// <summary> Returns Set ID - insurance (IN1-1).</summary>
		virtual public SI SetIDInsurance
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
		/// <summary> Returns Insurance plan ID (IN1-2).</summary>
		virtual public ID InsurancePlanID
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Insurance company ID (IN1-3).</summary>
		virtual public ST InsuranceCompanyID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Insurance company name (IN1-4).</summary>
		virtual public ST InsuranceCompanyName
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Insurance company address (IN1-5).</summary>
		virtual public AD InsuranceCompanyAddress
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (AD) t;
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
		/// <summary> Returns Insurance company contact pers (IN1-6).</summary>
		virtual public PN InsuranceCompanyContactPers
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Group number (IN1-8).</summary>
		virtual public ST GroupNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Group name (IN1-9).</summary>
		virtual public ST GroupName
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
		/// <summary> Returns Insured's group employer ID (IN1-10).</summary>
		virtual public ST InsuredSGroupEmployerID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Insured's group employer name (IN1-11).</summary>
		virtual public ST InsuredSGroupEmployerName
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Plan effective date (IN1-12).</summary>
		virtual public DT PlanEffectiveDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Plan expiration date (IN1-13).</summary>
		virtual public DT PlanExpirationDate
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
		/// <summary> Returns Authorization information (IN1-14).</summary>
		virtual public CM_AUI AuthorizationInformation
		{
			get
			{
				CM_AUI ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (CM_AUI) t;
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
		/// <summary> Returns Plan type (IN1-15).</summary>
		virtual public ID PlanType
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
		/// <summary> Returns Name of insured (IN1-16).</summary>
		virtual public PN NameOfInsured
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Insured's relationship to patient (IN1-17).</summary>
		virtual public ID InsuredSRelationshipToPatient
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Insured's date of birth (IN1-18).</summary>
		virtual public DT InsuredSDateOfBirth
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
		/// <summary> Returns Insured's address (IN1-19).</summary>
		virtual public AD InsuredSAddress
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (AD) t;
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
		/// <summary> Returns Assignment of benefits (IN1-20).</summary>
		virtual public ID AssignmentOfBenefits
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
		/// <summary> Returns Coordination of benefits (IN1-21).</summary>
		virtual public ID CoordinationOfBenefits
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
		/// <summary> Returns Coordination of benefits - priority (IN1-22).</summary>
		virtual public ST CoordinationOfBenefitsPriority
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
		/// <summary> Returns Notice of admission code (IN1-23).</summary>
		virtual public ID NoticeOfAdmissionCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Notice of admission date (IN1-24).</summary>
		virtual public DT NoticeOfAdmissionDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Report of eligibility code (IN1-25).</summary>
		virtual public ID ReportOfEligibilityCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Report of eligibility date (IN1-26).</summary>
		virtual public DT ReportOfEligibilityDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns Release information code (IN1-27).</summary>
		virtual public ID ReleaseInformationCode
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
		/// <summary> Returns Pre-admit certification (PAC) (IN1-28).</summary>
		virtual public ST PreAdmitCertification
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns Verification date / time (IN1-29).</summary>
		virtual public TS VerificationDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(29, 0);
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
		/// <summary> Returns Verification by (IN1-30).</summary>
		virtual public CN VerificationBy
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(30, 0);
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
		/// <summary> Returns Type of agreement code (IN1-31).</summary>
		virtual public ID TypeOfAgreementCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(31, 0);
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
		/// <summary> Returns Billing status (IN1-32).</summary>
		virtual public ID BillingStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(32, 0);
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
		/// <summary> Returns Lifetime reserve days (IN1-33).</summary>
		virtual public NM LifetimeReserveDays
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(33, 0);
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
		/// <summary> Returns Delay before lifetime reserve days (IN1-34).</summary>
		virtual public NM DelayBeforeLifetimeReserveDays
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(34, 0);
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
		/// <summary> Returns Company plan code (IN1-35).</summary>
		virtual public ID CompanyPlanCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(35, 0);
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
		/// <summary> Returns Policy number (IN1-36).</summary>
		virtual public ST PolicyNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Policy deductible (IN1-37).</summary>
		virtual public NM PolicyDeductible
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(37, 0);
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
		/// <summary> Returns Policy limit - amount (IN1-38).</summary>
		virtual public NM PolicyLimitAmount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(38, 0);
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
		/// <summary> Returns Policy limit - days (IN1-39).</summary>
		virtual public NM PolicyLimitDays
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(39, 0);
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
		/// <summary> Returns Room rate - semi-private (IN1-40).</summary>
		virtual public NM RoomRateSemiPrivate
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(40, 0);
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
		/// <summary> Returns Room rate - private (IN1-41).</summary>
		virtual public NM RoomRatePrivate
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(41, 0);
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
		/// <summary> Returns Insured's employment status (IN1-42).</summary>
		virtual public CE InsuredSEmploymentStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(42, 0);
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
		/// <summary> Returns Insured's sex (IN1-43).</summary>
		virtual public ID InsuredSSex
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(43, 0);
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
		/// <summary> Returns Insured's employer address (IN1-44).</summary>
		virtual public AD InsuredSEmployerAddress
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(44, 0);
					ret = (AD) t;
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
		/// <summary> Returns Verification status (IN1-45).</summary>
		virtual public ST VerificationStatus
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(45, 0);
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
		/// <summary> Returns Prior insurance plan ID (IN1-46).</summary>
		virtual public ID PriorInsurancePlanID
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(46, 0);
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
		
		/// <summary> Creates a IN1 (INSURANCE) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IN1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 72});
				this.add(typeof(ST), true, 1, 9, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 45, new System.Object[]{message});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 35, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 45, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(CM_AUI), false, 1, 55, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 86});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 63});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 135});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 173});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 0});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 93});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 98});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 22});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 42});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 72});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Insurance company phone number (IN1-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getInsuranceCompanyPhoneNumber(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insurance company phone number (IN1-7).</summary>
		public virtual TN[] getInsuranceCompanyPhoneNumber()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new TN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TN) t[i];
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