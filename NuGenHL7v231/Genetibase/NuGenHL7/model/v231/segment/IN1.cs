using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 IN1 message segment. 
	/// This segment has the following fields:</p><p>
	/// IN1-1: Set ID - IN1 (SI)<br> 
	/// IN1-2: Insurance Plan ID (CE)<br> 
	/// IN1-3: Insurance Company ID (CX)<br> 
	/// IN1-4: Insurance Company Name (XON)<br> 
	/// IN1-5: Insurance Company Address (XAD)<br> 
	/// IN1-6: Insurance Co Contact Person (XPN)<br> 
	/// IN1-7: Insurance Co Phone Number (XTN)<br> 
	/// IN1-8: Group Number (ST)<br> 
	/// IN1-9: Group Name (XON)<br> 
	/// IN1-10: Insured’s Group Emp ID (CX)<br> 
	/// IN1-11: Insured’s Group Emp Name (XON)<br> 
	/// IN1-12: Plan Effective Date (DT)<br> 
	/// IN1-13: Plan Expiration Date (DT)<br> 
	/// IN1-14: Authorization Information (AUI)<br> 
	/// IN1-15: Plan Type (IS)<br> 
	/// IN1-16: Name Of Insured (XPN)<br> 
	/// IN1-17: Insured’s Relationship To Patient (CE)<br> 
	/// IN1-18: Insured’s Date Of Birth (TS)<br> 
	/// IN1-19: Insured’s Address (XAD)<br> 
	/// IN1-20: Assignment Of Benefits (IS)<br> 
	/// IN1-21: Coordination Of Benefits (IS)<br> 
	/// IN1-22: Coord Of Ben. Priority (ST)<br> 
	/// IN1-23: Notice Of Admission Flag (ID)<br> 
	/// IN1-24: Notice Of Admission Date (DT)<br> 
	/// IN1-25: Report Of Eligibility Flag (ID)<br> 
	/// IN1-26: Report Of Eligibility Date (DT)<br> 
	/// IN1-27: Release Information Code (IS)<br> 
	/// IN1-28: Pre-Admit Cert (PAC) (ST)<br> 
	/// IN1-29: Verification Date/Time (TS)<br> 
	/// IN1-30: Verification By (XCN)<br> 
	/// IN1-31: Type Of Agreement Code (IS)<br> 
	/// IN1-32: Billing Status (IS)<br> 
	/// IN1-33: Lifetime Reserve Days (NM)<br> 
	/// IN1-34: Delay Before L.R. Day (NM)<br> 
	/// IN1-35: Company Plan Code (IS)<br> 
	/// IN1-36: Policy Number (ST)<br> 
	/// IN1-37: Policy Deductible (CP)<br> 
	/// IN1-38: Policy Limit - Amount (CP)<br> 
	/// IN1-39: Policy Limit - Days (NM)<br> 
	/// IN1-40: Room Rate - Semi-Private (CP)<br> 
	/// IN1-41: Room Rate - Private (CP)<br> 
	/// IN1-42: Insured’s Employment Status (CE)<br> 
	/// IN1-43: Insured’s Sex (IS)<br> 
	/// IN1-44: Insured’s Employer’s Address (XAD)<br> 
	/// IN1-45: Verification Status (ST)<br> 
	/// IN1-46: Prior Insurance Plan ID (IS)<br> 
	/// IN1-47: Coverage Type (IS)<br> 
	/// IN1-48: Handicap (IS)<br> 
	/// IN1-49: Insured’s ID Number (CX)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IN1:AbstractSegment
	{
		/// <summary> Returns Set ID - IN1 (IN1-1).</summary>
		virtual public SI SetIDIN1
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
		/// <summary> Returns Insurance Plan ID (IN1-2).</summary>
		virtual public CE InsurancePlanID
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
		/// <summary> Returns Group Number (IN1-8).</summary>
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
		/// <summary> Returns Plan Effective Date (IN1-12).</summary>
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
		/// <summary> Returns Plan Expiration Date (IN1-13).</summary>
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
		/// <summary> Returns Authorization Information (IN1-14).</summary>
		virtual public AUI AuthorizationInformation
		{
			get
			{
				AUI ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (AUI) t;
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
		/// <summary> Returns Plan Type (IN1-15).</summary>
		virtual public IS PlanType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Insured’s Relationship To Patient (IN1-17).</summary>
		virtual public CE InsuredSRelationshipToPatient
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
		/// <summary> Returns Insured’s Date Of Birth (IN1-18).</summary>
		virtual public TS InsuredSDateOfBirth
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
		/// <summary> Returns Assignment Of Benefits (IN1-20).</summary>
		virtual public IS AssignmentOfBenefits
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
		/// <summary> Returns Coordination Of Benefits (IN1-21).</summary>
		virtual public IS CoordinationOfBenefits
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
		/// <summary> Returns Coord Of Ben. Priority (IN1-22).</summary>
		virtual public ST CoordOfBenPriority
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
		/// <summary> Returns Notice Of Admission Flag (IN1-23).</summary>
		virtual public ID NoticeOfAdmissionFlag
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
		/// <summary> Returns Notice Of Admission Date (IN1-24).</summary>
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
		/// <summary> Returns Report Of Eligibility Flag (IN1-25).</summary>
		virtual public ID ReportOfEligibilityFlag
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
		/// <summary> Returns Report Of Eligibility Date (IN1-26).</summary>
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
		/// <summary> Returns Release Information Code (IN1-27).</summary>
		virtual public IS ReleaseInformationCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Pre-Admit Cert (PAC) (IN1-28).</summary>
		virtual public ST PreAdmitCert
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
		/// <summary> Returns Verification Date/Time (IN1-29).</summary>
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
		/// <summary> Returns Type Of Agreement Code (IN1-31).</summary>
		virtual public IS TypeOfAgreementCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(31, 0);
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
		/// <summary> Returns Billing Status (IN1-32).</summary>
		virtual public IS BillingStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(32, 0);
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
		/// <summary> Returns Lifetime Reserve Days (IN1-33).</summary>
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
		/// <summary> Returns Delay Before L.R. Day (IN1-34).</summary>
		virtual public NM DelayBeforeLRDay
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
		/// <summary> Returns Company Plan Code (IN1-35).</summary>
		virtual public IS CompanyPlanCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(35, 0);
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
		/// <summary> Returns Policy Number (IN1-36).</summary>
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
		/// <summary> Returns Policy Deductible (IN1-37).</summary>
		virtual public CP PolicyDeductible
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(37, 0);
					ret = (CP) t;
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
		/// <summary> Returns Policy Limit - Amount (IN1-38).</summary>
		virtual public CP PolicyLimitAmount
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(38, 0);
					ret = (CP) t;
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
		/// <summary> Returns Policy Limit - Days (IN1-39).</summary>
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
		/// <summary> Returns Room Rate - Semi-Private (IN1-40).</summary>
		virtual public CP RoomRateSemiPrivate
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(40, 0);
					ret = (CP) t;
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
		/// <summary> Returns Room Rate - Private (IN1-41).</summary>
		virtual public CP RoomRatePrivate
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(41, 0);
					ret = (CP) t;
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
		/// <summary> Returns Insured’s Employment Status (IN1-42).</summary>
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
		/// <summary> Returns Insured’s Sex (IN1-43).</summary>
		virtual public IS InsuredSSex
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(43, 0);
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
		/// <summary> Returns Verification Status (IN1-45).</summary>
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
		/// <summary> Returns Prior Insurance Plan ID (IN1-46).</summary>
		virtual public IS PriorInsurancePlanID
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(46, 0);
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
		/// <summary> Returns Coverage Type (IN1-47).</summary>
		virtual public IS CoverageType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(47, 0);
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
		/// <summary> Returns Handicap (IN1-48).</summary>
		virtual public IS Handicap
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(48, 0);
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
		
		/// <summary> Creates a IN1 (IN1 - insurance segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IN1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CX), true, 0, 59, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 130, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 106, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 130, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 12, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 130, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(AUI), false, 1, 55, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 86});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 106, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 135});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 173});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 93});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 98});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 22});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 42});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(XAD), false, 0, 106, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 72});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 309});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295});
				this.add(typeof(CX), false, 0, 12, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Insurance Company ID (IN1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getInsuranceCompanyID(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insurance Company ID (IN1-3).</summary>
		public virtual CX[] getInsuranceCompanyID()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Insurance Company Name (IN1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getInsuranceCompanyName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insurance Company Name (IN1-4).</summary>
		public virtual XON[] getInsuranceCompanyName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Insurance Company Address (IN1-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getInsuranceCompanyAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insurance Company Address (IN1-5).</summary>
		public virtual XAD[] getInsuranceCompanyAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
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
		
		/// <summary> Returns a single repetition of Insurance Co Contact Person (IN1-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getInsuranceCoContactPerson(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insurance Co Contact Person (IN1-6).</summary>
		public virtual XPN[] getInsuranceCoContactPerson()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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
		
		/// <summary> Returns a single repetition of Insurance Co Phone Number (IN1-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getInsuranceCoPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insurance Co Phone Number (IN1-7).</summary>
		public virtual XTN[] getInsuranceCoPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XTN) t[i];
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
		
		/// <summary> Returns a single repetition of Group Name (IN1-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getGroupName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Group Name (IN1-9).</summary>
		public virtual XON[] getGroupName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
		
		/// <summary> Returns a single repetition of Insured’s Group Emp ID (IN1-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getInsuredSGroupEmpID(int rep)
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
		
		/// <summary> Returns all repetitions of Insured’s Group Emp ID (IN1-10).</summary>
		public virtual CX[] getInsuredSGroupEmpID()
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
		
		/// <summary> Returns a single repetition of Insured’s Group Emp Name (IN1-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getInsuredSGroupEmpName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Group Emp Name (IN1-11).</summary>
		public virtual XON[] getInsuredSGroupEmpName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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
		
		/// <summary> Returns a single repetition of Name Of Insured (IN1-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getNameOfInsured(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Name Of Insured (IN1-16).</summary>
		public virtual XPN[] getNameOfInsured()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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
		
		/// <summary> Returns a single repetition of Insured’s Address (IN1-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getInsuredSAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Address (IN1-19).</summary>
		public virtual XAD[] getInsuredSAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(19);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
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
		
		/// <summary> Returns a single repetition of Verification By (IN1-30).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getVerificationBy(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(30, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Verification By (IN1-30).</summary>
		public virtual XCN[] getVerificationBy()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(30);
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
		
		/// <summary> Returns a single repetition of Insured’s Employer’s Address (IN1-44).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getInsuredSEmployerSAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(44, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Employer’s Address (IN1-44).</summary>
		public virtual XAD[] getInsuredSEmployerSAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(44);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
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
		
		/// <summary> Returns a single repetition of Insured’s ID Number (IN1-49).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getInsuredSIDNumber(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(49, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s ID Number (IN1-49).</summary>
		public virtual CX[] getInsuredSIDNumber()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(49);
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
	}
}