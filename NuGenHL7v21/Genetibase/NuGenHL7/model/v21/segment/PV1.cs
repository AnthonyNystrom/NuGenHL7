using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 PV1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PV1-1: SET ID - PATIENT VISIT (SI)<br> 
	/// PV1-2: PATIENT CLASS (ID)<br> 
	/// PV1-3: ASSIGNED PATIENT LOCATION (ID)<br> 
	/// PV1-4: ADMISSION TYPE (ID)<br> 
	/// PV1-5: PRE-ADMIT NUMBER (ST)<br> 
	/// PV1-6: PRIOR PATIENT LOCATION (ID)<br> 
	/// PV1-7: ATTENDING DOCTOR (CN)<br> 
	/// PV1-8: REFERRING DOCTOR (CN)<br> 
	/// PV1-9: CONSULTING DOCTOR (CN)<br> 
	/// PV1-10: HOSPITAL SERVICE (ID)<br> 
	/// PV1-11: TEMPORARY LOCATION (ID)<br> 
	/// PV1-12: PRE-ADMIT TEST INDICATOR (ID)<br> 
	/// PV1-13: RE-ADMISSION INDICATOR (ID)<br> 
	/// PV1-14: ADMIT SOURCE (ID)<br> 
	/// PV1-15: AMBULATORY STATUS (ID)<br> 
	/// PV1-16: VIP INDICATOR (ID)<br> 
	/// PV1-17: ADMITTING DOCTOR (CN)<br> 
	/// PV1-18: PATIENT TYPE (ID)<br> 
	/// PV1-19: VISIT NUMBER (NM)<br> 
	/// PV1-20: FINANCIAL CLASS (ID)<br> 
	/// PV1-21: CHARGE PRICE INDICATOR (ID)<br> 
	/// PV1-22: COURTESY CODE (ID)<br> 
	/// PV1-23: CREDIT RATING (ID)<br> 
	/// PV1-24: CONTRACT CODE (ID)<br> 
	/// PV1-25: CONTRACT EFFECTIVE DATE (DT)<br> 
	/// PV1-26: CONTRACT AMOUNT (NM)<br> 
	/// PV1-27: CONTRACT PERIOD (NM)<br> 
	/// PV1-28: INTEREST CODE (ID)<br> 
	/// PV1-29: TRANSFER TO BAD DEBT CODE (ID)<br> 
	/// PV1-30: TRANSFER TO BAD DEBT DATE (DT)<br> 
	/// PV1-31: BAD DEBT AGENCY CODE (ST)<br> 
	/// PV1-32: BAD DEBT TRANSFER AMOUNT (NM)<br> 
	/// PV1-33: BAD DEBT RECOVERY AMOUNT (NM)<br> 
	/// PV1-34: DELETE ACCOUNT INDICATOR (ID)<br> 
	/// PV1-35: DELETE ACCOUNT DATE (DT)<br> 
	/// PV1-36: DISCHARGE DISPOSITION (ID)<br> 
	/// PV1-37: DISCHARGED TO LOCATION (ID)<br> 
	/// PV1-38: DIET TYPE (ID)<br> 
	/// PV1-39: SERVICING FACILITY (ID)<br> 
	/// PV1-40: BED STATUS (ID)<br> 
	/// PV1-41: ACCOUNT STATUS (ID)<br> 
	/// PV1-42: PENDING LOCATION (ID)<br> 
	/// PV1-43: PRIOR TEMPORARY LOCATION (ID)<br> 
	/// PV1-44: ADMIT DATE/TIME (TS)<br> 
	/// PV1-45: DISCHARGE DATE/TIME (TS)<br> 
	/// PV1-46: CURRENT PATIENT BALANCE (NM)<br> 
	/// PV1-47: TOTAL CHARGES (NM)<br> 
	/// PV1-48: TOTAL ADJUSTMENTS (NM)<br> 
	/// PV1-49: TOTAL PAYMENTS (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PV1:AbstractSegment
	{
		/// <summary> Returns SET ID - PATIENT VISIT (PV1-1).</summary>
		virtual public SI SETIDPATIENTVISIT
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
		/// <summary> Returns PATIENT CLASS (PV1-2).</summary>
		virtual public ID PATIENTCLASS
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
		/// <summary> Returns ASSIGNED PATIENT LOCATION (PV1-3).</summary>
		virtual public ID ASSIGNEDPATIENTLOCATION
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns ADMISSION TYPE (PV1-4).</summary>
		virtual public ID ADMISSIONTYPE
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
		/// <summary> Returns PRE-ADMIT NUMBER (PV1-5).</summary>
		virtual public ST PREADMITNUMBER
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
		/// <summary> Returns PRIOR PATIENT LOCATION (PV1-6).</summary>
		virtual public ID PRIORPATIENTLOCATION
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns ATTENDING DOCTOR (PV1-7).</summary>
		virtual public CN ATTENDINGDOCTOR
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
		/// <summary> Returns REFERRING DOCTOR (PV1-8).</summary>
		virtual public CN REFERRINGDOCTOR
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
		/// <summary> Returns HOSPITAL SERVICE (PV1-10).</summary>
		virtual public ID HOSPITALSERVICE
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
		/// <summary> Returns TEMPORARY LOCATION (PV1-11).</summary>
		virtual public ID TEMPORARYLOCATION
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
		/// <summary> Returns PRE-ADMIT TEST INDICATOR (PV1-12).</summary>
		virtual public ID PREADMITTESTINDICATOR
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
		/// <summary> Returns RE-ADMISSION INDICATOR (PV1-13).</summary>
		virtual public ID READMISSIONINDICATOR
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
		/// <summary> Returns ADMIT SOURCE (PV1-14).</summary>
		virtual public ID ADMITSOURCE
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
		/// <summary> Returns AMBULATORY STATUS (PV1-15).</summary>
		virtual public ID AMBULATORYSTATUS
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
		/// <summary> Returns VIP INDICATOR (PV1-16).</summary>
		virtual public ID VIPINDICATOR
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
		/// <summary> Returns ADMITTING DOCTOR (PV1-17).</summary>
		virtual public CN ADMITTINGDOCTOR
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
		/// <summary> Returns PATIENT TYPE (PV1-18).</summary>
		virtual public ID PATIENTTYPE
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
		/// <summary> Returns VISIT NUMBER (PV1-19).</summary>
		virtual public NM VISITNUMBER
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns CHARGE PRICE INDICATOR (PV1-21).</summary>
		virtual public ID CHARGEPRICEINDICATOR
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
		/// <summary> Returns COURTESY CODE (PV1-22).</summary>
		virtual public ID COURTESYCODE
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
		/// <summary> Returns CREDIT RATING (PV1-23).</summary>
		virtual public ID CREDITRATING
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
		/// <summary> Returns INTEREST CODE (PV1-28).</summary>
		virtual public ID INTERESTCODE
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
		/// <summary> Returns TRANSFER TO BAD DEBT CODE (PV1-29).</summary>
		virtual public ID TRANSFERTOBADDEBTCODE
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
		/// <summary> Returns TRANSFER TO BAD DEBT DATE (PV1-30).</summary>
		virtual public DT TRANSFERTOBADDEBTDATE
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
		/// <summary> Returns BAD DEBT AGENCY CODE (PV1-31).</summary>
		virtual public ST BADDEBTAGENCYCODE
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(31, 0);
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
		/// <summary> Returns BAD DEBT TRANSFER AMOUNT (PV1-32).</summary>
		virtual public NM BADDEBTTRANSFERAMOUNT
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
		/// <summary> Returns BAD DEBT RECOVERY AMOUNT (PV1-33).</summary>
		virtual public NM BADDEBTRECOVERYAMOUNT
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
		/// <summary> Returns DELETE ACCOUNT INDICATOR (PV1-34).</summary>
		virtual public ID DELETEACCOUNTINDICATOR
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
		/// <summary> Returns DELETE ACCOUNT DATE (PV1-35).</summary>
		virtual public DT DELETEACCOUNTDATE
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
		/// <summary> Returns DISCHARGE DISPOSITION (PV1-36).</summary>
		virtual public ID DISCHARGEDISPOSITION
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
		/// <summary> Returns DISCHARGED TO LOCATION (PV1-37).</summary>
		virtual public ID DISCHARGEDTOLOCATION
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
		/// <summary> Returns DIET TYPE (PV1-38).</summary>
		virtual public ID DIETTYPE
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
		/// <summary> Returns SERVICING FACILITY (PV1-39).</summary>
		virtual public ID SERVICINGFACILITY
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
		/// <summary> Returns BED STATUS (PV1-40).</summary>
		virtual public ID BEDSTATUS
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
		/// <summary> Returns ACCOUNT STATUS (PV1-41).</summary>
		virtual public ID ACCOUNTSTATUS
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
		/// <summary> Returns PENDING LOCATION (PV1-42).</summary>
		virtual public ID PENDINGLOCATION
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(42, 0);
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
		/// <summary> Returns PRIOR TEMPORARY LOCATION (PV1-43).</summary>
		virtual public ID PRIORTEMPORARYLOCATION
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
		/// <summary> Returns ADMIT DATE/TIME (PV1-44).</summary>
		virtual public TS ADMITDATETIME
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
		/// <summary> Returns DISCHARGE DATE/TIME (PV1-45).</summary>
		virtual public TS DISCHARGEDATETIME
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
		/// <summary> Returns CURRENT PATIENT BALANCE (PV1-46).</summary>
		virtual public NM CURRENTPATIENTBALANCE
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
		/// <summary> Returns TOTAL CHARGES (PV1-47).</summary>
		virtual public NM TOTALCHARGES
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
		/// <summary> Returns TOTAL ADJUSTMENTS (PV1-48).</summary>
		virtual public NM TOTALADJUSTMENTS
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
		/// <summary> Returns TOTAL PAYMENTS (PV1-49).</summary>
		virtual public NM TOTALPAYMENTS
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
				this.add(typeof(ID), true, 1, 12, new System.Object[]{message, 79});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 7});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 69});
				this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 87});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 92});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 23});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 9});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 99});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 4, 11, new System.Object[]{message, 64});
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
				this.add(typeof(ST), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 111});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 112});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 113});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 114});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 115});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 116});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 117});
				this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79});
				this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of CONSULTING DOCTOR (PV1-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CN getCONSULTINGDOCTOR(int rep)
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
		
		/// <summary> Returns all repetitions of CONSULTING DOCTOR (PV1-9).</summary>
		public virtual CN[] getCONSULTINGDOCTOR()
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
		
		/// <summary> Returns a single repetition of FINANCIAL CLASS (PV1-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getFINANCIALCLASS(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of FINANCIAL CLASS (PV1-20).</summary>
		public virtual ID[] getFINANCIALCLASS()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(20);
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
		
		/// <summary> Returns a single repetition of CONTRACT CODE (PV1-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getCONTRACTCODE(int rep)
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
		
		/// <summary> Returns all repetitions of CONTRACT CODE (PV1-24).</summary>
		public virtual ID[] getCONTRACTCODE()
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
		
		/// <summary> Returns a single repetition of CONTRACT EFFECTIVE DATE (PV1-25).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DT getCONTRACTEFFECTIVEDATE(int rep)
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
		
		/// <summary> Returns all repetitions of CONTRACT EFFECTIVE DATE (PV1-25).</summary>
		public virtual DT[] getCONTRACTEFFECTIVEDATE()
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
		
		/// <summary> Returns a single repetition of CONTRACT AMOUNT (PV1-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getCONTRACTAMOUNT(int rep)
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
		
		/// <summary> Returns all repetitions of CONTRACT AMOUNT (PV1-26).</summary>
		public virtual NM[] getCONTRACTAMOUNT()
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
		
		/// <summary> Returns a single repetition of CONTRACT PERIOD (PV1-27).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getCONTRACTPERIOD(int rep)
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
		
		/// <summary> Returns all repetitions of CONTRACT PERIOD (PV1-27).</summary>
		public virtual NM[] getCONTRACTPERIOD()
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