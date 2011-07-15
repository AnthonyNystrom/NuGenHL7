using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 PV1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PV1-1: Set ID - Patient Visit (SI)<br> 
	/// PV1-2: Patient Class (ID)<br> 
	/// PV1-3: Assigned Patient Location (CM_INTERNAL_LOCATION)<br> 
	/// PV1-4: Admission Type (ID)<br> 
	/// PV1-5: Preadmit Number (ST)<br> 
	/// PV1-6: Prior Patient Location (CM_INTERNAL_LOCATION)<br> 
	/// PV1-7: Attending Doctor (CN)<br> 
	/// PV1-8: Referring Doctor (CN)<br> 
	/// PV1-9: Consulting Doctor (CN)<br> 
	/// PV1-10: Hospital Service (ID)<br> 
	/// PV1-11: Temporary Location (CM_INTERNAL_LOCATION)<br> 
	/// PV1-12: Preadmit Test Indicator (ID)<br> 
	/// PV1-13: Readmission indicator (ID)<br> 
	/// PV1-14: Admit Source (ID)<br> 
	/// PV1-15: Ambulatory Status (ID)<br> 
	/// PV1-16: VIP Indicator (ID)<br> 
	/// PV1-17: Admitting Doctor (CN)<br> 
	/// PV1-18: Patient type (ID)<br> 
	/// PV1-19: Visit Number (CM_PAT_ID)<br> 
	/// PV1-20: Financial Class (CM_FINANCE)<br> 
	/// PV1-21: Charge Price Indicator (ID)<br> 
	/// PV1-22: Courtesy Code (ID)<br> 
	/// PV1-23: Credit Rating (ID)<br> 
	/// PV1-24: Contract Code (ID)<br> 
	/// PV1-25: Contract Effective Date (DT)<br> 
	/// PV1-26: Contract Amount (NM)<br> 
	/// PV1-27: Contract Period (NM)<br> 
	/// PV1-28: Interest Code (ID)<br> 
	/// PV1-29: Transfer to bad debt - code (ID)<br> 
	/// PV1-30: Transfer to bad debt - date (DT)<br> 
	/// PV1-31: Bad Debt Agency Code (ID)<br> 
	/// PV1-32: Bad Debt Transfer Amount (NM)<br> 
	/// PV1-33: Bad Debt Recovery Amount (NM)<br> 
	/// PV1-34: Delete Account Indicator (ID)<br> 
	/// PV1-35: Delete Account Date (DT)<br> 
	/// PV1-36: Discharge Disposition (ID)<br> 
	/// PV1-37: Discharged to Location (CM_DLD)<br> 
	/// PV1-38: Diet Type (ID)<br> 
	/// PV1-39: Servicing Facility (ID)<br> 
	/// PV1-40: Bed Status (ID)<br> 
	/// PV1-41: Account Status (ID)<br> 
	/// PV1-42: Pending Location (CM_INTERNAL_LOCATION)<br> 
	/// PV1-43: Prior Temporary Location (CM_INTERNAL_LOCATION)<br> 
	/// PV1-44: Admit date / time (TS)<br> 
	/// PV1-45: Discharge date / time (TS)<br> 
	/// PV1-46: Current Patient Balance (NM)<br> 
	/// PV1-47: Total Charges (NM)<br> 
	/// PV1-48: Total Adjustments (NM)<br> 
	/// PV1-49: Total Payments (NM)<br> 
	/// PV1-50: Alternate Visit ID (CM_PAT_ID_0192)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PV1:AbstractSegment
	{
		/// <summary> Returns Set ID - Patient Visit (PV1-1).</summary>
		virtual public SI SetIDPatientVisit
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
		/// <summary> Returns Patient Class (PV1-2).</summary>
		virtual public ID PatientClass
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
		/// <summary> Returns Assigned Patient Location (PV1-3).</summary>
		virtual public CM_INTERNAL_LOCATION AssignedPatientLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CM_INTERNAL_LOCATION) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Admission Type (PV1-4).</summary>
		virtual public ID AdmissionType
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
		/// <summary> Returns Preadmit Number (PV1-5).</summary>
		virtual public ST PreadmitNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Prior Patient Location (PV1-6).</summary>
		virtual public CM_INTERNAL_LOCATION PriorPatientLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (CM_INTERNAL_LOCATION) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Attending Doctor (PV1-7).</summary>
		virtual public CN AttendingDoctor
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Referring Doctor (PV1-8).</summary>
		virtual public CN ReferringDoctor
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Hospital Service (PV1-10).</summary>
		virtual public ID HospitalService
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Temporary Location (PV1-11).</summary>
		virtual public CM_INTERNAL_LOCATION TemporaryLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CM_INTERNAL_LOCATION) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Preadmit Test Indicator (PV1-12).</summary>
		virtual public ID PreadmitTestIndicator
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
		/// <summary> Returns Readmission indicator (PV1-13).</summary>
		virtual public ID ReadmissionIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Admit Source (PV1-14).</summary>
		virtual public ID AdmitSource
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
		/// <summary> Returns VIP Indicator (PV1-16).</summary>
		virtual public ID VIPIndicator
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
		/// <summary> Returns Admitting Doctor (PV1-17).</summary>
		virtual public CN AdmittingDoctor
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Patient type (PV1-18).</summary>
		virtual public ID PatientType
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
		/// <summary> Returns Visit Number (PV1-19).</summary>
		virtual public CM_PAT_ID VisitNumber
		{
			get
			{
				CM_PAT_ID ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (CM_PAT_ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Charge Price Indicator (PV1-21).</summary>
		virtual public ID ChargePriceIndicator
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
		/// <summary> Returns Courtesy Code (PV1-22).</summary>
		virtual public ID CourtesyCode
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
		/// <summary> Returns Credit Rating (PV1-23).</summary>
		virtual public ID CreditRating
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
		/// <summary> Returns Interest Code (PV1-28).</summary>
		virtual public ID InterestCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns Transfer to bad debt - code (PV1-29).</summary>
		virtual public ID TransferToBadDebtCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(29, 0);
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
		/// <summary> Returns Transfer to bad debt - date (PV1-30).</summary>
		virtual public DT TransferToBadDebtDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(30, 0);
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
		/// <summary> Returns Bad Debt Agency Code (PV1-31).</summary>
		virtual public ID BadDebtAgencyCode
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
		/// <summary> Returns Bad Debt Transfer Amount (PV1-32).</summary>
		virtual public NM BadDebtTransferAmount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(32, 0);
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
		/// <summary> Returns Bad Debt Recovery Amount (PV1-33).</summary>
		virtual public NM BadDebtRecoveryAmount
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
		/// <summary> Returns Delete Account Indicator (PV1-34).</summary>
		virtual public ID DeleteAccountIndicator
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
		/// <summary> Returns Delete Account Date (PV1-35).</summary>
		virtual public DT DeleteAccountDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(35, 0);
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
		/// <summary> Returns Discharge Disposition (PV1-36).</summary>
		virtual public ID DischargeDisposition
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
		/// <summary> Returns Discharged to Location (PV1-37).</summary>
		virtual public CM_DLD DischargedToLocation
		{
			get
			{
				CM_DLD ret = null;
				try
				{
					Type t = this.getField(37, 0);
					ret = (CM_DLD) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Diet Type (PV1-38).</summary>
		virtual public ID DietType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(38, 0);
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
		/// <summary> Returns Servicing Facility (PV1-39).</summary>
		virtual public ID ServicingFacility
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
		/// <summary> Returns Bed Status (PV1-40).</summary>
		virtual public ID BedStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(40, 0);
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
		/// <summary> Returns Account Status (PV1-41).</summary>
		virtual public ID AccountStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(41, 0);
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
		/// <summary> Returns Pending Location (PV1-42).</summary>
		virtual public CM_INTERNAL_LOCATION PendingLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(42, 0);
					ret = (CM_INTERNAL_LOCATION) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Prior Temporary Location (PV1-43).</summary>
		virtual public CM_INTERNAL_LOCATION PriorTemporaryLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(43, 0);
					ret = (CM_INTERNAL_LOCATION) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Admit date / time (PV1-44).</summary>
		virtual public TS AdmitDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(44, 0);
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
		/// <summary> Returns Discharge date / time (PV1-45).</summary>
		virtual public TS DischargeDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(45, 0);
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
		/// <summary> Returns Current Patient Balance (PV1-46).</summary>
		virtual public NM CurrentPatientBalance
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(46, 0);
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
		/// <summary> Returns Total Charges (PV1-47).</summary>
		virtual public NM TotalCharges
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(47, 0);
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
		/// <summary> Returns Total Adjustments (PV1-48).</summary>
		virtual public NM TotalAdjustments
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(48, 0);
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
		/// <summary> Returns Total Payments (PV1-49).</summary>
		virtual public NM TotalPayments
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(49, 0);
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
		/// <summary> Returns Alternate Visit ID (PV1-50).</summary>
		virtual public CM_PAT_ID_0192 AlternateVisitID
		{
			get
			{
				CM_PAT_ID_0192 ret = null;
				try
				{
					Type t = this.getField(50, 0);
					ret = (CM_PAT_ID_0192) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a PV1 (PATIENT VISIT) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PV1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 4});
				this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 7});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 69});
				this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 87});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 92});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 23});
				this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 9});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 99});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18});
				this.add(typeof(CM_PAT_ID), false, 1, 15, new System.Object[]{message});
				this.add(typeof(CM_FINANCE), false, 4, 50, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 32});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 45});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 46});
				this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 44});
				this.add(typeof(DT), false, 0, 8, new System.Object[]{message});
				this.add(typeof(NM), false, 0, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 0, 3, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 73});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 110});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 21});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 111});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 112});
				this.add(typeof(CM_DLD), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 114});
				this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 115});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 116});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 117});
				this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CM_PAT_ID_0192), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Consulting Doctor (PV1-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CN getConsultingDoctor(int rep)
		{
			CN ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (CN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Consulting Doctor (PV1-9).</summary>
		public virtual CN[] getConsultingDoctor()
		{
			CN[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new CN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CN) t[i];
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
		
		/// <summary> Returns a single repetition of Ambulatory Status (PV1-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getAmbulatoryStatus(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ambulatory Status (PV1-15).</summary>
		public virtual ID[] getAmbulatoryStatus()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
		
		/// <summary> Returns a single repetition of Financial Class (PV1-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_FINANCE getFinancialClass(int rep)
		{
			CM_FINANCE ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (CM_FINANCE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Financial Class (PV1-20).</summary>
		public virtual CM_FINANCE[] getFinancialClass()
		{
			CM_FINANCE[] ret = null;
			try
			{
				Type[] t = this.getField(20);
				ret = new CM_FINANCE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_FINANCE) t[i];
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
		
		/// <summary> Returns a single repetition of Contract Code (PV1-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getContractCode(int rep)
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
		
		/// <summary> Returns all repetitions of Contract Code (PV1-24).</summary>
		public virtual ID[] getContractCode()
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
		
		/// <summary> Returns a single repetition of Contract Effective Date (PV1-25).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DT getContractEffectiveDate(int rep)
		{
			DT ret = null;
			try
			{
				Type t = this.getField(25, rep);
				ret = (DT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contract Effective Date (PV1-25).</summary>
		public virtual DT[] getContractEffectiveDate()
		{
			DT[] ret = null;
			try
			{
				Type[] t = this.getField(25);
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
		
		/// <summary> Returns a single repetition of Contract Amount (PV1-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getContractAmount(int rep)
		{
			NM ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (NM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contract Amount (PV1-26).</summary>
		public virtual NM[] getContractAmount()
		{
			NM[] ret = null;
			try
			{
				Type[] t = this.getField(26);
				ret = new NM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NM) t[i];
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
		
		/// <summary> Returns a single repetition of Contract Period (PV1-27).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getContractPeriod(int rep)
		{
			NM ret = null;
			try
			{
				Type t = this.getField(27, rep);
				ret = (NM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contract Period (PV1-27).</summary>
		public virtual NM[] getContractPeriod()
		{
			NM[] ret = null;
			try
			{
				Type[] t = this.getField(27);
				ret = new NM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NM) t[i];
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