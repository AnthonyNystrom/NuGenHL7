using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 PV2 message segment. 
	/// This segment has the following fields:</p><p>
	/// PV2-1: Prior Pending Location (PL)<br> 
	/// PV2-2: Accommodation Code (CE)<br> 
	/// PV2-3: Admit Reason (CE)<br> 
	/// PV2-4: Transfer Reason (CE)<br> 
	/// PV2-5: Patient Valuables (ST)<br> 
	/// PV2-6: Patient Valuables Location (ST)<br> 
	/// PV2-7: Visit User Code (IS)<br> 
	/// PV2-8: Expected Admit Date/Time (TS)<br> 
	/// PV2-9: Expected Discharge Date/Time (TS)<br> 
	/// PV2-10: Estimated Length of Inpatient Stay (NM)<br> 
	/// PV2-11: Actual Length of Inpatient Stay (NM)<br> 
	/// PV2-12: Visit Description (ST)<br> 
	/// PV2-13: Referral Source Code (XCN)<br> 
	/// PV2-14: Previous Service Date (DT)<br> 
	/// PV2-15: Employment Illness Related Indicator (ID)<br> 
	/// PV2-16: Purge Status Code (IS)<br> 
	/// PV2-17: Purge Status Date (DT)<br> 
	/// PV2-18: Special Program Code (IS)<br> 
	/// PV2-19: Retention Indicator (ID)<br> 
	/// PV2-20: Expected Number of Insurance Plans (NM)<br> 
	/// PV2-21: Visit Publicity Code (IS)<br> 
	/// PV2-22: Visit Protection Indicator (ID)<br> 
	/// PV2-23: Clinic Organization Name (XON)<br> 
	/// PV2-24: Patient Status Code (IS)<br> 
	/// PV2-25: Visit Priority Code (IS)<br> 
	/// PV2-26: Previous Treatment Date (DT)<br> 
	/// PV2-27: Expected Discharge Disposition (IS)<br> 
	/// PV2-28: Signature on File Date (DT)<br> 
	/// PV2-29: First Similar Illness Date (DT)<br> 
	/// PV2-30: Patient Charge Adjustment Code (CE)<br> 
	/// PV2-31: Recurring Service Code (IS)<br> 
	/// PV2-32: Billing Media Code (ID)<br> 
	/// PV2-33: Expected Surgery Date & Time (TS)<br> 
	/// PV2-34: Military Partnership Code (ID)<br> 
	/// PV2-35: Military Non-Availability Code (ID)<br> 
	/// PV2-36: Newborn Baby Indicator (ID)<br> 
	/// PV2-37: Baby Detained Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PV2:AbstractSegment
	{
		/// <summary> Returns Prior Pending Location (PV2-1).</summary>
		virtual public PL PriorPendingLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (PL) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Accommodation Code (PV2-2).</summary>
		virtual public CE AccommodationCode
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
		/// <summary> Returns Admit Reason (PV2-3).</summary>
		virtual public CE AdmitReason
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Transfer Reason (PV2-4).</summary>
		virtual public CE TransferReason
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Patient Valuables Location (PV2-6).</summary>
		virtual public ST PatientValuablesLocation
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
		/// <summary> Returns Visit User Code (PV2-7).</summary>
		virtual public IS VisitUserCode
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
		/// <summary> Returns Expected Admit Date/Time (PV2-8).</summary>
		virtual public TS ExpectedAdmitDateTime
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
		/// <summary> Returns Expected Discharge Date/Time (PV2-9).</summary>
		virtual public TS ExpectedDischargeDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Estimated Length of Inpatient Stay (PV2-10).</summary>
		virtual public NM EstimatedLengthOfInpatientStay
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
		/// <summary> Returns Actual Length of Inpatient Stay (PV2-11).</summary>
		virtual public NM ActualLengthOfInpatientStay
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Visit Description (PV2-12).</summary>
		virtual public ST VisitDescription
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
		/// <summary> Returns Previous Service Date (PV2-14).</summary>
		virtual public DT PreviousServiceDate
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
		/// <summary> Returns Employment Illness Related Indicator (PV2-15).</summary>
		virtual public ID EmploymentIllnessRelatedIndicator
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
		/// <summary> Returns Purge Status Code (PV2-16).</summary>
		virtual public IS PurgeStatusCode
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
		/// <summary> Returns Purge Status Date (PV2-17).</summary>
		virtual public DT PurgeStatusDate
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
		/// <summary> Returns Special Program Code (PV2-18).</summary>
		virtual public IS SpecialProgramCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Retention Indicator (PV2-19).</summary>
		virtual public ID RetentionIndicator
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
		/// <summary> Returns Expected Number of Insurance Plans (PV2-20).</summary>
		virtual public NM ExpectedNumberOfInsurancePlans
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Visit Publicity Code (PV2-21).</summary>
		virtual public IS VisitPublicityCode
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
		/// <summary> Returns Visit Protection Indicator (PV2-22).</summary>
		virtual public ID VisitProtectionIndicator
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
		/// <summary> Returns Patient Status Code (PV2-24).</summary>
		virtual public IS PatientStatusCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Visit Priority Code (PV2-25).</summary>
		virtual public IS VisitPriorityCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Previous Treatment Date (PV2-26).</summary>
		virtual public DT PreviousTreatmentDate
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
		/// <summary> Returns Expected Discharge Disposition (PV2-27).</summary>
		virtual public IS ExpectedDischargeDisposition
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
		/// <summary> Returns Signature on File Date (PV2-28).</summary>
		virtual public DT SignatureOnFileDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns First Similar Illness Date (PV2-29).</summary>
		virtual public DT FirstSimilarIllnessDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(29, 0);
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
		/// <summary> Returns Patient Charge Adjustment Code (PV2-30).</summary>
		virtual public CE PatientChargeAdjustmentCode
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
		/// <summary> Returns Recurring Service Code (PV2-31).</summary>
		virtual public IS RecurringServiceCode
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
		/// <summary> Returns Billing Media Code (PV2-32).</summary>
		virtual public ID BillingMediaCode
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
		/// <summary> Returns Expected Surgery Date & Time (PV2-33).</summary>
		virtual public TS ExpectedSurgeryDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(33, 0);
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
		/// <summary> Returns Military Partnership Code (PV2-34).</summary>
		virtual public ID MilitaryPartnershipCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(34, 0);
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
		/// <summary> Returns Military Non-Availability Code (PV2-35).</summary>
		virtual public ID MilitaryNonAvailabilityCode
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
		/// <summary> Returns Newborn Baby Indicator (PV2-36).</summary>
		virtual public ID NewbornBabyIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Baby Detained Indicator (PV2-37).</summary>
		virtual public ID BabyDetainedIndicator
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
		
		/// <summary> Creates a PV2 (PV2 - patient visit - additional information segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PV2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 25, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 130});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 50, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 90, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 213});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 214});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(NM), false, 1, 1, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 215});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(XON), false, 0, 90, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 216});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 217});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 112});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 219});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Patient Valuables (PV2-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getPatientValuables(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Valuables (PV2-5).</summary>
		public virtual ST[] getPatientValuables()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of Referral Source Code (PV2-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getReferralSourceCode(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Referral Source Code (PV2-13).</summary>
		public virtual XCN[] getReferralSourceCode()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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
		
		/// <summary> Returns a single repetition of Clinic Organization Name (PV2-23).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getClinicOrganizationName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(23, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Clinic Organization Name (PV2-23).</summary>
		public virtual XON[] getClinicOrganizationName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(23);
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
	}
}