using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 GT1 message segment. 
	/// This segment has the following fields:</p><p>
	/// GT1-1: Set ID - GT1 (SI)<br> 
	/// GT1-2: Guarantor Number (CX)<br> 
	/// GT1-3: Guarantor Name (XPN)<br> 
	/// GT1-4: Guarantor Spouse Name (XPN)<br> 
	/// GT1-5: Guarantor Address (XAD)<br> 
	/// GT1-6: Guarantor Ph Num - Home (XTN)<br> 
	/// GT1-7: Guarantor Ph Num - Business (XTN)<br> 
	/// GT1-8: Guarantor Date/Time Of Birth (TS)<br> 
	/// GT1-9: Guarantor Administrative Sex (IS)<br> 
	/// GT1-10: Guarantor Type (IS)<br> 
	/// GT1-11: Guarantor Relationship (CE)<br> 
	/// GT1-12: Guarantor SSN (ST)<br> 
	/// GT1-13: Guarantor Date - Begin (DT)<br> 
	/// GT1-14: Guarantor Date - End (DT)<br> 
	/// GT1-15: Guarantor Priority (NM)<br> 
	/// GT1-16: Guarantor Employer Name (XPN)<br> 
	/// GT1-17: Guarantor Employer Address (XAD)<br> 
	/// GT1-18: Guarantor Employer Phone Number (XTN)<br> 
	/// GT1-19: Guarantor Employee ID Number (CX)<br> 
	/// GT1-20: Guarantor Employment Status (IS)<br> 
	/// GT1-21: Guarantor Organization Name (XON)<br> 
	/// GT1-22: Guarantor Billing Hold Flag (ID)<br> 
	/// GT1-23: Guarantor Credit Rating Code (CE)<br> 
	/// GT1-24: Guarantor Death Date And Time (TS)<br> 
	/// GT1-25: Guarantor Death Flag (ID)<br> 
	/// GT1-26: Guarantor Charge Adjustment Code (CE)<br> 
	/// GT1-27: Guarantor Household Annual Income (CP)<br> 
	/// GT1-28: Guarantor Household Size (NM)<br> 
	/// GT1-29: Guarantor Employer ID Number (CX)<br> 
	/// GT1-30: Guarantor Marital Status Code (CE)<br> 
	/// GT1-31: Guarantor Hire Effective Date (DT)<br> 
	/// GT1-32: Employment Stop Date (DT)<br> 
	/// GT1-33: Living Dependency (IS)<br> 
	/// GT1-34: Ambulatory Status (IS)<br> 
	/// GT1-35: Citizenship (CE)<br> 
	/// GT1-36: Primary Language (CE)<br> 
	/// GT1-37: Living Arrangement (IS)<br> 
	/// GT1-38: Publicity Code (CE)<br> 
	/// GT1-39: Protection Indicator (ID)<br> 
	/// GT1-40: Student Indicator (IS)<br> 
	/// GT1-41: Religion (CE)<br> 
	/// GT1-42: Mother's Maiden Name (XPN)<br> 
	/// GT1-43: Nationality (CE)<br> 
	/// GT1-44: Ethnic Group (CE)<br> 
	/// GT1-45: Contact Person's Name (XPN)<br> 
	/// GT1-46: Contact Person's Telephone Number (XTN)<br> 
	/// GT1-47: Contact Reason (CE)<br> 
	/// GT1-48: Contact Relationship (IS)<br> 
	/// GT1-49: Job Title (ST)<br> 
	/// GT1-50: Job Code/Class (JCC)<br> 
	/// GT1-51: Guarantor Employer's Organization Name (XON)<br> 
	/// GT1-52: Handicap (IS)<br> 
	/// GT1-53: Job Status (IS)<br> 
	/// GT1-54: Guarantor Financial Class (FC)<br> 
	/// GT1-55: Guarantor Race (CE)<br> 
	/// GT1-56: Guarantor Birth Place (ST)<br> 
	/// GT1-57: VIP Indicator (IS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class GT1:AbstractSegment
	{
		/// <summary> Returns Set ID - GT1 (GT1-1).</summary>
		virtual public SI SetIDGT1
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
		/// <summary> Returns Guarantor Date/Time Of Birth (GT1-8).</summary>
		virtual public TS GuarantorDateTimeOfBirth
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Guarantor Administrative Sex (GT1-9).</summary>
		virtual public IS GuarantorAdministrativeSex
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Guarantor Type (GT1-10).</summary>
		virtual public IS GuarantorType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Guarantor Relationship (GT1-11).</summary>
		virtual public CE GuarantorRelationship
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
		/// <summary> Returns Guarantor SSN (GT1-12).</summary>
		virtual public ST GuarantorSSN
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
		/// <summary> Returns Guarantor Date - Begin (GT1-13).</summary>
		virtual public DT GuarantorDateBegin
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
		/// <summary> Returns Guarantor Date - End (GT1-14).</summary>
		virtual public DT GuarantorDateEnd
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Guarantor Priority (GT1-15).</summary>
		virtual public NM GuarantorPriority
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Guarantor Employment Status (GT1-20).</summary>
		virtual public IS GuarantorEmploymentStatus
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
		/// <summary> Returns Guarantor Billing Hold Flag (GT1-22).</summary>
		virtual public ID GuarantorBillingHoldFlag
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Guarantor Credit Rating Code (GT1-23).</summary>
		virtual public CE GuarantorCreditRatingCode
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
		/// <summary> Returns Guarantor Death Date And Time (GT1-24).</summary>
		virtual public TS GuarantorDeathDateAndTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Guarantor Death Flag (GT1-25).</summary>
		virtual public ID GuarantorDeathFlag
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
		/// <summary> Returns Guarantor Charge Adjustment Code (GT1-26).</summary>
		virtual public CE GuarantorChargeAdjustmentCode
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
		/// <summary> Returns Guarantor Household Annual Income (GT1-27).</summary>
		virtual public CP GuarantorHouseholdAnnualIncome
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Guarantor Household Size (GT1-28).</summary>
		virtual public NM GuarantorHouseholdSize
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns Guarantor Marital Status Code (GT1-30).</summary>
		virtual public CE GuarantorMaritalStatusCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(30, 0);
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
		/// <summary> Returns Guarantor Hire Effective Date (GT1-31).</summary>
		virtual public DT GuarantorHireEffectiveDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(31, 0);
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
		/// <summary> Returns Employment Stop Date (GT1-32).</summary>
		virtual public DT EmploymentStopDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(32, 0);
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
		/// <summary> Returns Living Dependency (GT1-33).</summary>
		virtual public IS LivingDependency
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(33, 0);
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
		/// <summary> Returns Primary Language (GT1-36).</summary>
		virtual public CE PrimaryLanguage
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
		/// <summary> Returns Living Arrangement (GT1-37).</summary>
		virtual public IS LivingArrangement
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(37, 0);
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
		/// <summary> Returns Publicity Code (GT1-38).</summary>
		virtual public CE PublicityCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(38, 0);
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
		/// <summary> Returns Protection Indicator (GT1-39).</summary>
		virtual public ID ProtectionIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(39, 0);
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
		/// <summary> Returns Student Indicator (GT1-40).</summary>
		virtual public IS StudentIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(40, 0);
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
		/// <summary> Returns Religion (GT1-41).</summary>
		virtual public CE Religion
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
		/// <summary> Returns Nationality (GT1-43).</summary>
		virtual public CE Nationality
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(43, 0);
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
		/// <summary> Returns Contact Reason (GT1-47).</summary>
		virtual public CE ContactReason
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(47, 0);
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
		/// <summary> Returns Contact Relationship (GT1-48).</summary>
		virtual public IS ContactRelationship
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
		/// <summary> Returns Job Title (GT1-49).</summary>
		virtual public ST JobTitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(49, 0);
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
		/// <summary> Returns Job Code/Class (GT1-50).</summary>
		virtual public JCC JobCodeClass
		{
			get
			{
				JCC ret = null;
				try
				{
					Type t = this.getField(50, 0);
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
		/// <summary> Returns Handicap (GT1-52).</summary>
		virtual public IS Handicap
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(52, 0);
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
		/// <summary> Returns Job Status (GT1-53).</summary>
		virtual public IS JobStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(53, 0);
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
		/// <summary> Returns Guarantor Financial Class (GT1-54).</summary>
		virtual public FC GuarantorFinancialClass
		{
			get
			{
				FC ret = null;
				try
				{
					Type t = this.getField(54, 0);
					ret = (FC) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Guarantor Birth Place (GT1-56).</summary>
		virtual public ST GuarantorBirthPlace
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(56, 0);
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
		/// <summary> Returns VIP Indicator (GT1-57).</summary>
		virtual public IS VIPIndicator
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
		
		/// <summary> Creates a GT1 (Guarantor) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public GT1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), true, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 68});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 11, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 66});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 223});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 9});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 63});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(JCC), false, 1, 20, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 311});
				this.add(typeof(FC), false, 1, 50, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 99});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Guarantor Number (GT1-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getGuarantorNumber(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Number (GT1-2).</summary>
		public virtual CX[] getGuarantorNumber()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(2);
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
		
		/// <summary> Returns a single repetition of Guarantor Name (GT1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getGuarantorName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Name (GT1-3).</summary>
		public virtual XPN[] getGuarantorName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Guarantor Spouse Name (GT1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getGuarantorSpouseName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Spouse Name (GT1-4).</summary>
		public virtual XPN[] getGuarantorSpouseName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Guarantor Address (GT1-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getGuarantorAddress(int rep)
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
		
		/// <summary> Returns all repetitions of Guarantor Address (GT1-5).</summary>
		public virtual XAD[] getGuarantorAddress()
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
		
		/// <summary> Returns a single repetition of Guarantor Ph Num - Home (GT1-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getGuarantorPhNumHome(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Ph Num - Home (GT1-6).</summary>
		public virtual XTN[] getGuarantorPhNumHome()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of Guarantor Ph Num - Business (GT1-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getGuarantorPhNumBusiness(int rep)
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
		
		/// <summary> Returns all repetitions of Guarantor Ph Num - Business (GT1-7).</summary>
		public virtual XTN[] getGuarantorPhNumBusiness()
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
		
		/// <summary> Returns a single repetition of Guarantor Employer Name (GT1-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getGuarantorEmployerName(int rep)
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
		
		/// <summary> Returns all repetitions of Guarantor Employer Name (GT1-16).</summary>
		public virtual XPN[] getGuarantorEmployerName()
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
		
		/// <summary> Returns a single repetition of Guarantor Employer Address (GT1-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getGuarantorEmployerAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Employer Address (GT1-17).</summary>
		public virtual XAD[] getGuarantorEmployerAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(17);
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
		
		/// <summary> Returns a single repetition of Guarantor Employer Phone Number (GT1-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getGuarantorEmployerPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Employer Phone Number (GT1-18).</summary>
		public virtual XTN[] getGuarantorEmployerPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(18);
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
		
		/// <summary> Returns a single repetition of Guarantor Employee ID Number (GT1-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getGuarantorEmployeeIDNumber(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Employee ID Number (GT1-19).</summary>
		public virtual CX[] getGuarantorEmployeeIDNumber()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(19);
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
		
		/// <summary> Returns a single repetition of Guarantor Organization Name (GT1-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getGuarantorOrganizationName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Organization Name (GT1-21).</summary>
		public virtual XON[] getGuarantorOrganizationName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(21);
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
		
		/// <summary> Returns a single repetition of Guarantor Employer ID Number (GT1-29).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getGuarantorEmployerIDNumber(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(29, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Employer ID Number (GT1-29).</summary>
		public virtual CX[] getGuarantorEmployerIDNumber()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(29);
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
		
		/// <summary> Returns a single repetition of Ambulatory Status (GT1-34).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getAmbulatoryStatus(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(34, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ambulatory Status (GT1-34).</summary>
		public virtual IS[] getAmbulatoryStatus()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(34);
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
		
		/// <summary> Returns a single repetition of Citizenship (GT1-35).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCitizenship(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(35, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Citizenship (GT1-35).</summary>
		public virtual CE[] getCitizenship()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(35);
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
		
		/// <summary> Returns a single repetition of Mother's Maiden Name (GT1-42).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getMotherSMaidenName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(42, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Mother's Maiden Name (GT1-42).</summary>
		public virtual XPN[] getMotherSMaidenName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(42);
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
		
		/// <summary> Returns a single repetition of Ethnic Group (GT1-44).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getEthnicGroup(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(44, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ethnic Group (GT1-44).</summary>
		public virtual CE[] getEthnicGroup()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(44);
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
		
		/// <summary> Returns a single repetition of Contact Person's Name (GT1-45).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getContactPersonSName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(45, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Person's Name (GT1-45).</summary>
		public virtual XPN[] getContactPersonSName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(45);
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
		
		/// <summary> Returns a single repetition of Contact Person's Telephone Number (GT1-46).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getContactPersonSTelephoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(46, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Person's Telephone Number (GT1-46).</summary>
		public virtual XTN[] getContactPersonSTelephoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(46);
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
		
		/// <summary> Returns a single repetition of Guarantor Employer's Organization Name (GT1-51).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getGuarantorEmployerSOrganizationName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(51, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Employer's Organization Name (GT1-51).</summary>
		public virtual XON[] getGuarantorEmployerSOrganizationName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(51);
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
		
		/// <summary> Returns a single repetition of Guarantor Race (GT1-55).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getGuarantorRace(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(55, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Guarantor Race (GT1-55).</summary>
		public virtual CE[] getGuarantorRace()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(55);
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