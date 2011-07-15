using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 IN2 message segment. 
	/// This segment has the following fields:</p><p>
	/// IN2-1: Insured’s Employee ID (CX)<br> 
	/// IN2-2: Insured’s Social Security Number (ST)<br> 
	/// IN2-3: Insured’s Employer’s Name and ID (XCN)<br> 
	/// IN2-4: Employer Information Data (IS)<br> 
	/// IN2-5: Mail Claim Party (IS)<br> 
	/// IN2-6: Medicare Health Ins Card Number (ST)<br> 
	/// IN2-7: Medicaid Case Name (XPN)<br> 
	/// IN2-8: Medicaid Case Number (ST)<br> 
	/// IN2-9: Military Sponsor Name (XPN)<br> 
	/// IN2-10: Military ID Number (ST)<br> 
	/// IN2-11: Dependent Of Military Recipient (CE)<br> 
	/// IN2-12: Military Organization (ST)<br> 
	/// IN2-13: Military Station (ST)<br> 
	/// IN2-14: Military Service (IS)<br> 
	/// IN2-15: Military Rank/Grade (IS)<br> 
	/// IN2-16: Military Status (IS)<br> 
	/// IN2-17: Military Retire Date (DT)<br> 
	/// IN2-18: Military Non-Avail Cert On File (ID)<br> 
	/// IN2-19: Baby Coverage (ID)<br> 
	/// IN2-20: Combine Baby Bill (ID)<br> 
	/// IN2-21: Blood Deductible (ST)<br> 
	/// IN2-22: Special Coverage Approval Name (XPN)<br> 
	/// IN2-23: Special Coverage Approval Title (ST)<br> 
	/// IN2-24: Non-Covered Insurance Code (IS)<br> 
	/// IN2-25: Payor ID (CX)<br> 
	/// IN2-26: Payor Subscriber ID (CX)<br> 
	/// IN2-27: Eligibility Source (IS)<br> 
	/// IN2-28: Room Coverage Type/Amount (RMC)<br> 
	/// IN2-29: Policy Type/Amount (PTA)<br> 
	/// IN2-30: Daily Deductible (DDI)<br> 
	/// IN2-31: Living Dependency (IS)<br> 
	/// IN2-32: Ambulatory Status (IS)<br> 
	/// IN2-33: Citizenship (CE)<br> 
	/// IN2-34: Primary Language (CE)<br> 
	/// IN2-35: Living Arrangement (IS)<br> 
	/// IN2-36: Publicity Code (CE)<br> 
	/// IN2-37: Protection Indicator (ID)<br> 
	/// IN2-38: Student Indicator (IS)<br> 
	/// IN2-39: Religion (CE)<br> 
	/// IN2-40: Mother’s Maiden Name (XPN)<br> 
	/// IN2-41: Nationality (CE)<br> 
	/// IN2-42: Ethnic Group (CE)<br> 
	/// IN2-43: Marital Status (CE)<br> 
	/// IN2-44: Insured’s Employment Start Date (DT)<br> 
	/// IN2-45: Employment Stop Date (DT)<br> 
	/// IN2-46: Job Title (ST)<br> 
	/// IN2-47: Job Code/Class (JCC)<br> 
	/// IN2-48: Job Status (IS)<br> 
	/// IN2-49: Employer Contact Person Name (XPN)<br> 
	/// IN2-50: Employer Contact Person Phone Number (XTN)<br> 
	/// IN2-51: Employer Contact Reason (IS)<br> 
	/// IN2-52: Insured’s Contact Person’s Name (XPN)<br> 
	/// IN2-53: Insured’s Contact Person Phone Number (XTN)<br> 
	/// IN2-54: Insured’s Contact Person Reason (IS)<br> 
	/// IN2-55: Relationship To The Patient Start Date (DT)<br> 
	/// IN2-56: Relationship To The Patient Stop Date (DT)<br> 
	/// IN2-57: Insurance Co. Contact Reason (IS)<br> 
	/// IN2-58: Insurance Co Contact Phone Number (XTN)<br> 
	/// IN2-59: Policy Scope (IS)<br> 
	/// IN2-60: Policy Source (IS)<br> 
	/// IN2-61: Patient Member Number (CX)<br> 
	/// IN2-62: Guarantor’s Relationship To Insured (CE)<br> 
	/// IN2-63: Insured’s Phone Number - Home (XTN)<br> 
	/// IN2-64: Insured’s Employer Phone Number (XTN)<br> 
	/// IN2-65: Military Handicapped Program (CE)<br> 
	/// IN2-66: Suspend Flag (ID)<br> 
	/// IN2-67: Copay Limit Flag (ID)<br> 
	/// IN2-68: Stoploss Limit Flag (ID)<br> 
	/// IN2-69: Insured Organization Name And ID (XON)<br> 
	/// IN2-70: Insured Employer Organization Name And ID (XON)<br> 
	/// IN2-71: Race (CE)<br> 
	/// IN2-72: HCFA Patient’s Relationship to Insured (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IN2:AbstractSegment
	{
		/// <summary> Returns Insured’s Social Security Number (IN2-2).</summary>
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
		/// <summary> Returns Employer Information Data (IN2-4).</summary>
		virtual public IS EmployerInformationData
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Medicare Health Ins Card Number (IN2-6).</summary>
		virtual public ST MedicareHealthInsCardNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Medicaid Case Number (IN2-8).</summary>
		virtual public ST MedicaidCaseNumber
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
		/// <summary> Returns Military ID Number (IN2-10).</summary>
		virtual public ST MilitaryIDNumber
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
		/// <summary> Returns Dependent Of Military Recipient (IN2-11).</summary>
		virtual public CE DependentOfMilitaryRecipient
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
		/// <summary> Returns Military Organization (IN2-12).</summary>
		virtual public ST MilitaryOrganization
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
		/// <summary> Returns Military Station (IN2-13).</summary>
		virtual public ST MilitaryStation
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
		/// <summary> Returns Military Service (IN2-14).</summary>
		virtual public IS MilitaryService
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Military Rank/Grade (IN2-15).</summary>
		virtual public IS MilitaryRankGrade
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
		/// <summary> Returns Military Status (IN2-16).</summary>
		virtual public IS MilitaryStatus
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
		/// <summary> Returns Military Retire Date (IN2-17).</summary>
		virtual public DT MilitaryRetireDate
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
		/// <summary> Returns Military Non-Avail Cert On File (IN2-18).</summary>
		virtual public ID MilitaryNonAvailCertOnFile
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
		/// <summary> Returns Baby Coverage (IN2-19).</summary>
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
		/// <summary> Returns Combine Baby Bill (IN2-20).</summary>
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
		/// <summary> Returns Blood Deductible (IN2-21).</summary>
		virtual public ST BloodDeductible
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Special Coverage Approval Title (IN2-23).</summary>
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
		/// <summary> Returns Eligibility Source (IN2-27).</summary>
		virtual public IS EligibilitySource
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
		/// <summary> Returns Daily Deductible (IN2-30).</summary>
		virtual public DDI DailyDeductible
		{
			get
			{
				DDI ret = null;
				try
				{
					Type t = this.getField(30, 0);
					ret = (DDI) t;
				}
				catch (System.InvalidCastException )
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
		/// <summary> Returns Living Dependency (IN2-31).</summary>
		virtual public IS LivingDependency
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
		/// <summary> Returns Primary Language (IN2-34).</summary>
		virtual public CE PrimaryLanguage
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(34, 0);
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
		/// <summary> Returns Living Arrangement (IN2-35).</summary>
		virtual public IS LivingArrangement
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
		/// <summary> Returns Publicity Code (IN2-36).</summary>
		virtual public CE PublicityCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Protection Indicator (IN2-37).</summary>
		virtual public ID ProtectionIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(37, 0);
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
		/// <summary> Returns Student Indicator (IN2-38).</summary>
		virtual public IS StudentIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(38, 0);
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
		/// <summary> Returns Religion (IN2-39).</summary>
		virtual public CE Religion
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(39, 0);
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
		/// <summary> Returns Nationality (IN2-41).</summary>
		virtual public CE Nationality
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(41, 0);
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
		/// <summary> Returns Insured’s Employment Start Date (IN2-44).</summary>
		virtual public DT InsuredSEmploymentStartDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(44, 0);
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
		/// <summary> Returns Employment Stop Date (IN2-45).</summary>
		virtual public DT EmploymentStopDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(45, 0);
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
		/// <summary> Returns Job Title (IN2-46).</summary>
		virtual public ST JobTitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(46, 0);
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
		/// <summary> Returns Job Code/Class (IN2-47).</summary>
		virtual public JCC JobCodeClass
		{
			get
			{
				JCC ret = null;
				try
				{
					Type t = this.getField(47, 0);
					ret = (JCC) t;
				}
				catch (System.InvalidCastException )
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
		/// <summary> Returns Job Status (IN2-48).</summary>
		virtual public IS JobStatus
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
		/// <summary> Returns Employer Contact Reason (IN2-51).</summary>
		virtual public IS EmployerContactReason
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(51, 0);
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
		/// <summary> Returns Relationship To The Patient Start Date (IN2-55).</summary>
		virtual public DT RelationshipToThePatientStartDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(55, 0);
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
		/// <summary> Returns Insurance Co. Contact Reason (IN2-57).</summary>
		virtual public IS InsuranceCoContactReason
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(57, 0);
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
		/// <summary> Returns Insurance Co Contact Phone Number (IN2-58).</summary>
		virtual public XTN InsuranceCoContactPhoneNumber
		{
			get
			{
				XTN ret = null;
				try
				{
					Type t = this.getField(58, 0);
					ret = (XTN) t;
				}
				catch (System.InvalidCastException )
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
		/// <summary> Returns Policy Scope (IN2-59).</summary>
		virtual public IS PolicyScope
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(59, 0);
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
		/// <summary> Returns Policy Source (IN2-60).</summary>
		virtual public IS PolicySource
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(60, 0);
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
		/// <summary> Returns Patient Member Number (IN2-61).</summary>
		virtual public CX PatientMemberNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(61, 0);
					ret = (CX) t;
				}
				catch (System.InvalidCastException )
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
		/// <summary> Returns Guarantor’s Relationship To Insured (IN2-62).</summary>
		virtual public CE GuarantorSRelationshipToInsured
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(62, 0);
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
		/// <summary> Returns Military Handicapped Program (IN2-65).</summary>
		virtual public CE MilitaryHandicappedProgram
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(65, 0);
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
		/// <summary> Returns Suspend Flag (IN2-66).</summary>
		virtual public ID SuspendFlag
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(66, 0);
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
		/// <summary> Returns Copay Limit Flag (IN2-67).</summary>
		virtual public ID CopayLimitFlag
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(67, 0);
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
		/// <summary> Returns Stoploss Limit Flag (IN2-68).</summary>
		virtual public ID StoplossLimitFlag
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(68, 0);
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
		/// <summary> Returns HCFA Patient’s Relationship to Insured (IN2-72).</summary>
		virtual public CE HCFAPatientSRelationshipToInsured
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(72, 0);
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
		
		/// <summary> Creates a IN2 (IN2 - insurance additional information segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IN2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CX), false, 0, 59, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 11, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 130, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 139});
				this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 137});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 14, new System.Object[]{message, 140});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 141});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 142});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ST), false, 1, 1, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 8, new System.Object[]{message, 143});
				this.add(typeof(CX), false, 0, 59, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 59, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 144});
				this.add(typeof(RMC), false, 0, 25, new System.Object[]{message});
				this.add(typeof(PTA), false, 0, 25, new System.Object[]{message});
				this.add(typeof(DDI), false, 1, 25, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 223});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 9});
				this.add(typeof(CE), false, 0, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 80, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(JCC), false, 1, 20, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 311});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 222});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 222});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 0, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 232});
				this.add(typeof(XTN), false, 1, 40, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 312});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 313});
				this.add(typeof(CX), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(XON), false, 0, 130, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 130, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Insured’s Employee ID (IN2-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getInsuredSEmployeeID(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Employee ID (IN2-1).</summary>
		public virtual CX[] getInsuredSEmployeeID()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(1);
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
		
		/// <summary> Returns a single repetition of Insured’s Employer’s Name and ID (IN2-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getInsuredSEmployerSNameAndID(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Employer’s Name and ID (IN2-3).</summary>
		public virtual XCN[] getInsuredSEmployerSNameAndID()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Mail Claim Party (IN2-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getMailClaimParty(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Mail Claim Party (IN2-5).</summary>
		public virtual IS[] getMailClaimParty()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of Medicaid Case Name (IN2-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getMedicaidCaseName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Medicaid Case Name (IN2-7).</summary>
		public virtual XPN[] getMedicaidCaseName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of Military Sponsor Name (IN2-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getMilitarySponsorName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Military Sponsor Name (IN2-9).</summary>
		public virtual XPN[] getMilitarySponsorName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
		
		/// <summary> Returns a single repetition of Special Coverage Approval Name (IN2-22).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getSpecialCoverageApprovalName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(22, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Special Coverage Approval Name (IN2-22).</summary>
		public virtual XPN[] getSpecialCoverageApprovalName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(22);
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
		
		/// <summary> Returns a single repetition of Non-Covered Insurance Code (IN2-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getNonCoveredInsuranceCode(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(24, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Non-Covered Insurance Code (IN2-24).</summary>
		public virtual IS[] getNonCoveredInsuranceCode()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(24);
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
		
		/// <summary> Returns a single repetition of Payor ID (IN2-25).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getPayorID(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(25, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Payor ID (IN2-25).</summary>
		public virtual CX[] getPayorID()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(25);
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
		
		/// <summary> Returns a single repetition of Payor Subscriber ID (IN2-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getPayorSubscriberID(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Payor Subscriber ID (IN2-26).</summary>
		public virtual CX[] getPayorSubscriberID()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(26);
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
		
		/// <summary> Returns a single repetition of Room Coverage Type/Amount (IN2-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual RMC getRoomCoverageTypeAmount(int rep)
		{
			RMC ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (RMC) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Room Coverage Type/Amount (IN2-28).</summary>
		public virtual RMC[] getRoomCoverageTypeAmount()
		{
			RMC[] ret = null;
			try
			{
				Type[] t = this.getField(28);
				ret = new RMC[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (RMC) t[i];
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
		
		/// <summary> Returns a single repetition of Policy Type/Amount (IN2-29).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual PTA getPolicyTypeAmount(int rep)
		{
			PTA ret = null;
			try
			{
				Type t = this.getField(29, rep);
				ret = (PTA) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Policy Type/Amount (IN2-29).</summary>
		public virtual PTA[] getPolicyTypeAmount()
		{
			PTA[] ret = null;
			try
			{
				Type[] t = this.getField(29);
				ret = new PTA[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PTA) t[i];
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
		
		/// <summary> Returns a single repetition of Ambulatory Status (IN2-32).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getAmbulatoryStatus(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(32, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ambulatory Status (IN2-32).</summary>
		public virtual IS[] getAmbulatoryStatus()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(32);
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
		
		/// <summary> Returns a single repetition of Citizenship (IN2-33).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCitizenship(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(33, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Citizenship (IN2-33).</summary>
		public virtual CE[] getCitizenship()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(33);
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
		
		/// <summary> Returns a single repetition of Mother’s Maiden Name (IN2-40).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getMotherSMaidenName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(40, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Mother’s Maiden Name (IN2-40).</summary>
		public virtual XPN[] getMotherSMaidenName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(40);
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
		
		/// <summary> Returns a single repetition of Ethnic Group (IN2-42).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getEthnicGroup(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(42, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ethnic Group (IN2-42).</summary>
		public virtual CE[] getEthnicGroup()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(42);
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
		
		/// <summary> Returns a single repetition of Marital Status (IN2-43).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getMaritalStatus(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(43, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Marital Status (IN2-43).</summary>
		public virtual CE[] getMaritalStatus()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(43);
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
		
		/// <summary> Returns a single repetition of Employer Contact Person Name (IN2-49).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getEmployerContactPersonName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(49, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Employer Contact Person Name (IN2-49).</summary>
		public virtual XPN[] getEmployerContactPersonName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(49);
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
		
		/// <summary> Returns a single repetition of Employer Contact Person Phone Number (IN2-50).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getEmployerContactPersonPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(50, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Employer Contact Person Phone Number (IN2-50).</summary>
		public virtual XTN[] getEmployerContactPersonPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(50);
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
		
		/// <summary> Returns a single repetition of Insured’s Contact Person’s Name (IN2-52).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getInsuredSContactPersonSName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(52, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Contact Person’s Name (IN2-52).</summary>
		public virtual XPN[] getInsuredSContactPersonSName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(52);
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
		
		/// <summary> Returns a single repetition of Insured’s Contact Person Phone Number (IN2-53).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getInsuredSContactPersonPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(53, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Contact Person Phone Number (IN2-53).</summary>
		public virtual XTN[] getInsuredSContactPersonPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(53);
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
		
		/// <summary> Returns a single repetition of Insured’s Contact Person Reason (IN2-54).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getInsuredSContactPersonReason(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(54, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Contact Person Reason (IN2-54).</summary>
		public virtual IS[] getInsuredSContactPersonReason()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(54);
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
		
		/// <summary> Returns a single repetition of Relationship To The Patient Stop Date (IN2-56).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DT getRelationshipToThePatientStopDate(int rep)
		{
			DT ret = null;
			try
			{
				Type t = this.getField(56, rep);
				ret = (DT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Relationship To The Patient Stop Date (IN2-56).</summary>
		public virtual DT[] getRelationshipToThePatientStopDate()
		{
			DT[] ret = null;
			try
			{
				Type[] t = this.getField(56);
				ret = new DT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (DT) t[i];
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
		
		/// <summary> Returns a single repetition of Insured’s Phone Number - Home (IN2-63).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getInsuredSPhoneNumberHome(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(63, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Phone Number - Home (IN2-63).</summary>
		public virtual XTN[] getInsuredSPhoneNumberHome()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(63);
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
		
		/// <summary> Returns a single repetition of Insured’s Employer Phone Number (IN2-64).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getInsuredSEmployerPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(64, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured’s Employer Phone Number (IN2-64).</summary>
		public virtual XTN[] getInsuredSEmployerPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(64);
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
		
		/// <summary> Returns a single repetition of Insured Organization Name And ID (IN2-69).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getInsuredOrganizationNameAndID(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(69, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured Organization Name And ID (IN2-69).</summary>
		public virtual XON[] getInsuredOrganizationNameAndID()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(69);
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
		
		/// <summary> Returns a single repetition of Insured Employer Organization Name And ID (IN2-70).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getInsuredEmployerOrganizationNameAndID(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(70, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Insured Employer Organization Name And ID (IN2-70).</summary>
		public virtual XON[] getInsuredEmployerOrganizationNameAndID()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(70);
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
		
		/// <summary> Returns a single repetition of Race (IN2-71).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getRace(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(71, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Race (IN2-71).</summary>
		public virtual CE[] getRace()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(71);
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