using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 PV1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PV1-1: Set ID - PV1 (SI)<br> 
	/// PV1-2: Patient Class (IS)<br> 
	/// PV1-3: Assigned Patient Location (PL)<br> 
	/// PV1-4: Admission Type (IS)<br> 
	/// PV1-5: Preadmit Number (CX)<br> 
	/// PV1-6: Prior Patient Location (PL)<br> 
	/// PV1-7: Attending Doctor (XCN)<br> 
	/// PV1-8: Referring Doctor (XCN)<br> 
	/// PV1-9: Consulting Doctor (XCN)<br> 
	/// PV1-10: Hospital Service (IS)<br> 
	/// PV1-11: Temporary Location (PL)<br> 
	/// PV1-12: Preadmit Test Indicator (IS)<br> 
	/// PV1-13: Re-admission Indicator (IS)<br> 
	/// PV1-14: Admit Source (IS)<br> 
	/// PV1-15: Ambulatory Status (IS)<br> 
	/// PV1-16: VIP Indicator (IS)<br> 
	/// PV1-17: Admitting Doctor (XCN)<br> 
	/// PV1-18: Patient Type (IS)<br> 
	/// PV1-19: Visit Number (CX)<br> 
	/// PV1-20: Financial Class (FC)<br> 
	/// PV1-21: Charge Price Indicator (IS)<br> 
	/// PV1-22: Courtesy Code (IS)<br> 
	/// PV1-23: Credit Rating (IS)<br> 
	/// PV1-24: Contract Code (IS)<br> 
	/// PV1-25: Contract Effective Date (DT)<br> 
	/// PV1-26: Contract Amount (NM)<br> 
	/// PV1-27: Contract Period (NM)<br> 
	/// PV1-28: Interest Code (IS)<br> 
	/// PV1-29: Transfer to Bad Debt Code (IS)<br> 
	/// PV1-30: Transfer to Bad Debt Date (DT)<br> 
	/// PV1-31: Bad Debt Agency Code (IS)<br> 
	/// PV1-32: Bad Debt Transfer Amount (NM)<br> 
	/// PV1-33: Bad Debt Recovery Amount (NM)<br> 
	/// PV1-34: Delete Account Indicator (IS)<br> 
	/// PV1-35: Delete Account Date (DT)<br> 
	/// PV1-36: Discharge Disposition (IS)<br> 
	/// PV1-37: Discharged to Location (DLD)<br> 
	/// PV1-38: Diet Type (CE)<br> 
	/// PV1-39: Servicing Facility (IS)<br> 
	/// PV1-40: Bed Status (IS)<br> 
	/// PV1-41: Account Status (IS)<br> 
	/// PV1-42: Pending Location (PL)<br> 
	/// PV1-43: Prior Temporary Location (PL)<br> 
	/// PV1-44: Admit Date/Time (TS)<br> 
	/// PV1-45: Discharge Date/Time (TS)<br> 
	/// PV1-46: Current Patient Balance (NM)<br> 
	/// PV1-47: Total Charges (NM)<br> 
	/// PV1-48: Total Adjustments (NM)<br> 
	/// PV1-49: Total Payments (NM)<br> 
	/// PV1-50: Alternate Visit ID (CX)<br> 
	/// PV1-51: Visit Indicator (IS)<br> 
	/// PV1-52: Other Healthcare Provider (XCN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PV1:AbstractSegment
	{
		/// <summary> Returns Set ID - PV1 (PV1-1).</summary>
		virtual public SI SetIDPV1
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
		virtual public IS PatientClass
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
		/// <summary> Returns Assigned Patient Location (PV1-3).</summary>
		virtual public PL AssignedPatientLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Admission Type (PV1-4).</summary>
		virtual public IS AdmissionType
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
		/// <summary> Returns Preadmit Number (PV1-5).</summary>
		virtual public CX PreadmitNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Prior Patient Location (PV1-6).</summary>
		virtual public PL PriorPatientLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Hospital Service (PV1-10).</summary>
		virtual public IS HospitalService
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
		/// <summary> Returns Temporary Location (PV1-11).</summary>
		virtual public PL TemporaryLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Preadmit Test Indicator (PV1-12).</summary>
		virtual public IS PreadmitTestIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Re-admission Indicator (PV1-13).</summary>
		virtual public IS ReAdmissionIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Admit Source (PV1-14).</summary>
		virtual public IS AdmitSource
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
		/// <summary> Returns VIP Indicator (PV1-16).</summary>
		virtual public IS VIPIndicator
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
		/// <summary> Returns Patient Type (PV1-18).</summary>
		virtual public IS PatientType
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
		/// <summary> Returns Visit Number (PV1-19).</summary>
		virtual public CX VisitNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Charge Price Indicator (PV1-21).</summary>
		virtual public IS ChargePriceIndicator
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
		/// <summary> Returns Courtesy Code (PV1-22).</summary>
		virtual public IS CourtesyCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Credit Rating (PV1-23).</summary>
		virtual public IS CreditRating
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Interest Code (PV1-28).</summary>
		virtual public IS InterestCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns Transfer to Bad Debt Code (PV1-29).</summary>
		virtual public IS TransferToBadDebtCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(29, 0);
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
		/// <summary> Returns Transfer to Bad Debt Date (PV1-30).</summary>
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
		virtual public IS BadDebtAgencyCode
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
		virtual public IS DeleteAccountIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(34, 0);
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
		virtual public IS DischargeDisposition
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Discharged to Location (PV1-37).</summary>
		virtual public DLD DischargedToLocation
		{
			get
			{
				DLD ret = null;
				try
				{
					Type t = this.getField(37, 0);
					ret = (DLD) t;
				}
				catch (System.InvalidCastException )
				{
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
		virtual public CE DietType
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
		/// <summary> Returns Servicing Facility (PV1-39).</summary>
		virtual public IS ServicingFacility
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(39, 0);
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
		/// <summary> Returns Bed Status (PV1-40).</summary>
		virtual public IS BedStatus
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
		/// <summary> Returns Account Status (PV1-41).</summary>
		virtual public IS AccountStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(41, 0);
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
		/// <summary> Returns Pending Location (PV1-42).</summary>
		virtual public PL PendingLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(42, 0);
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
		/// <summary> Returns Prior Temporary Location (PV1-43).</summary>
		virtual public PL PriorTemporaryLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(43, 0);
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
		/// <summary> Returns Admit Date/Time (PV1-44).</summary>
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
		/// <summary> Returns Discharge Date/Time (PV1-45).</summary>
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
		virtual public CX AlternateVisitID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(50, 0);
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
		/// <summary> Returns Visit Indicator (PV1-51).</summary>
		virtual public IS VisitIndicator
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
		
		/// <summary> Creates a PV1 (PV1 - patient visit segment-) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PV1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(IS), true, 1, 1, new System.Object[]{message, 4});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 7});
				this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 69});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 87});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 92});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 23});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 9});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 99});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 18});
				this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
				this.add(typeof(FC), false, 0, 50, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 32});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 45});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 46});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 44});
				this.add(typeof(DT), false, 0, 8, new System.Object[]{message});
				this.add(typeof(NM), false, 0, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 0, 3, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 73});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 110});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 10, new System.Object[]{message, 21});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 111});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 112});
				this.add(typeof(DLD), false, 1, 25, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 115});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 116});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 117});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 326});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Attending Doctor (PV1-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getAttendingDoctor(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Attending Doctor (PV1-7).</summary>
		public virtual XCN[] getAttendingDoctor()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of Referring Doctor (PV1-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getReferringDoctor(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Referring Doctor (PV1-8).</summary>
		public virtual XCN[] getReferringDoctor()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
		
		/// <summary> Returns a single repetition of Consulting Doctor (PV1-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getConsultingDoctor(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Consulting Doctor (PV1-9).</summary>
		public virtual XCN[] getConsultingDoctor()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
		
		/// <summary> Returns a single repetition of Ambulatory Status (PV1-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getAmbulatoryStatus(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ambulatory Status (PV1-15).</summary>
		public virtual IS[] getAmbulatoryStatus()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
		
		/// <summary> Returns a single repetition of Admitting Doctor (PV1-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getAdmittingDoctor(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Admitting Doctor (PV1-17).</summary>
		public virtual XCN[] getAdmittingDoctor()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(17);
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
		
		/// <summary> Returns a single repetition of Financial Class (PV1-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FC getFinancialClass(int rep)
		{
			FC ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (FC) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Financial Class (PV1-20).</summary>
		public virtual FC[] getFinancialClass()
		{
			FC[] ret = null;
			try
			{
				Type[] t = this.getField(20);
				ret = new FC[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FC) t[i];
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
		public virtual IS getContractCode(int rep)
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
		
		/// <summary> Returns all repetitions of Contract Code (PV1-24).</summary>
		public virtual IS[] getContractCode()
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
		
		/// <summary> Returns a single repetition of Other Healthcare Provider (PV1-52).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getOtherHealthcareProvider(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(52, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Other Healthcare Provider (PV1-52).</summary>
		public virtual XCN[] getOtherHealthcareProvider()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(52);
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
	}
}