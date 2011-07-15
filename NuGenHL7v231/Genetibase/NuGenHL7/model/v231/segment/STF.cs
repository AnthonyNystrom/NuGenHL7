using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 STF message segment. 
	/// This segment has the following fields:</p><p>
	/// STF-1: Primary Key Value - STF (CE)<br> 
	/// STF-2: Staff ID Code (CX)<br> 
	/// STF-3: Staff Name (XPN)<br> 
	/// STF-4: Staff Type (IS)<br> 
	/// STF-5: Sex (IS)<br> 
	/// STF-6: Date/Time Of Birth (TS)<br> 
	/// STF-7: Active/Inactive Flag (ID)<br> 
	/// STF-8: Department (CE)<br> 
	/// STF-9: Hospital Service (CE)<br> 
	/// STF-10: Phone (XTN)<br> 
	/// STF-11: Office/Home Address (XAD)<br> 
	/// STF-12: Institution Activation Date (DIN)<br> 
	/// STF-13: Institution Inactivation Date (DIN)<br> 
	/// STF-14: Backup Person ID (CE)<br> 
	/// STF-15: E-Mail Address (ST)<br> 
	/// STF-16: Preferred Method Of Contact (CE)<br> 
	/// STF-17: Marital Status (CE)<br> 
	/// STF-18: Job Title (ST)<br> 
	/// STF-19: Job Code/Class (JCC)<br> 
	/// STF-20: Employment Status (IS)<br> 
	/// STF-21: Additional Insured on  Auto (ID)<br> 
	/// STF-22: Driver’s License Number - Staff (DLN)<br> 
	/// STF-23: Copy  Auto Ins (ID)<br> 
	/// STF-24: Auto Ins. Expires (DT)<br> 
	/// STF-25: Date Last DMV Review (DT)<br> 
	/// STF-26: Date Next DMV Review (DT)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class STF:AbstractSegment
	{
		/// <summary> Returns Primary Key Value - STF (STF-1).</summary>
		virtual public CE PrimaryKeyValueSTF
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Sex (STF-5).</summary>
		virtual public IS Sex
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
		/// <summary> Returns Date/Time Of Birth (STF-6).</summary>
		virtual public TS DateTimeOfBirth
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Active/Inactive Flag (STF-7).</summary>
		virtual public ID ActiveInactiveFlag
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Preferred Method Of Contact (STF-16).</summary>
		virtual public CE PreferredMethodOfContact
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Marital Status (STF-17).</summary>
		virtual public CE MaritalStatus
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
		/// <summary> Returns Job Title (STF-18).</summary>
		virtual public ST JobTitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Job Code/Class (STF-19).</summary>
		virtual public JCC JobCodeClass
		{
			get
			{
				JCC ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Employment Status (STF-20).</summary>
		virtual public IS EmploymentStatus
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
		/// <summary> Returns Additional Insured on  Auto (STF-21).</summary>
		virtual public ID AdditionalInsuredOnAuto
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
		/// <summary> Returns Driver’s License Number - Staff (STF-22).</summary>
		virtual public DLN DriverSLicenseNumberStaff
		{
			get
			{
				DLN ret = null;
				try
				{
					Type t = this.getField(22, 0);
					ret = (DLN) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Copy  Auto Ins (STF-23).</summary>
		virtual public ID CopyAutoIns
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
		/// <summary> Returns Auto Ins. Expires (STF-24).</summary>
		virtual public DT AutoInsExpires
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
		/// <summary> Returns Date Last DMV Review (STF-25).</summary>
		virtual public DT DateLastDMVReview
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Date Next DMV Review (STF-26).</summary>
		virtual public DT DateNextDMVReview
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
		
		/// <summary> Creates a STF (STF - staff identification segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public STF(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 60, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 182});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 183});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 106, new System.Object[]{message});
				this.add(typeof(DIN), false, 0, 26, new System.Object[]{message});
				this.add(typeof(DIN), false, 0, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 40, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(JCC), false, 1, 20, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 66});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(DLN), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Staff ID Code (STF-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getStaffIDCode(int rep)
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
		
		/// <summary> Returns all repetitions of Staff ID Code (STF-2).</summary>
		public virtual CX[] getStaffIDCode()
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
		
		/// <summary> Returns a single repetition of Staff Name (STF-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getStaffName(int rep)
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
		
		/// <summary> Returns all repetitions of Staff Name (STF-3).</summary>
		public virtual XPN[] getStaffName()
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
		
		/// <summary> Returns a single repetition of Staff Type (STF-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getStaffType(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Staff Type (STF-4).</summary>
		public virtual IS[] getStaffType()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Department (STF-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getDepartment(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Department (STF-8).</summary>
		public virtual CE[] getDepartment()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
		
		/// <summary> Returns a single repetition of Hospital Service (STF-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getHospitalService(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Hospital Service (STF-9).</summary>
		public virtual CE[] getHospitalService()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
		
		/// <summary> Returns a single repetition of Phone (STF-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getPhone(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone (STF-10).</summary>
		public virtual XTN[] getPhone()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(10);
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
		
		/// <summary> Returns a single repetition of Office/Home Address (STF-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getOfficeHomeAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Office/Home Address (STF-11).</summary>
		public virtual XAD[] getOfficeHomeAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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
		
		/// <summary> Returns a single repetition of Institution Activation Date (STF-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DIN getInstitutionActivationDate(int rep)
		{
			DIN ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (DIN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Institution Activation Date (STF-12).</summary>
		public virtual DIN[] getInstitutionActivationDate()
		{
			DIN[] ret = null;
			try
			{
				Type[] t = this.getField(12);
				ret = new DIN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (DIN) t[i];
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
		
		/// <summary> Returns a single repetition of Institution Inactivation Date (STF-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DIN getInstitutionInactivationDate(int rep)
		{
			DIN ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (DIN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Institution Inactivation Date (STF-13).</summary>
		public virtual DIN[] getInstitutionInactivationDate()
		{
			DIN[] ret = null;
			try
			{
				Type[] t = this.getField(13);
				ret = new DIN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (DIN) t[i];
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
		
		/// <summary> Returns a single repetition of Backup Person ID (STF-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getBackupPersonID(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Backup Person ID (STF-14).</summary>
		public virtual CE[] getBackupPersonID()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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
		
		/// <summary> Returns a single repetition of E-Mail Address (STF-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getEMailAddress(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of E-Mail Address (STF-15).</summary>
		public virtual ST[] getEMailAddress()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
	}
}