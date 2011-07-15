using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 PID message segment. 
	/// This segment has the following fields:</p><p>
	/// PID-1: Set ID - PID (SI)<br> 
	/// PID-2: Patient ID (CX)<br> 
	/// PID-3: Patient Identifier List (CX)<br> 
	/// PID-4: Alternate Patient ID - PID (CX)<br> 
	/// PID-5: Patient Name (XPN)<br> 
	/// PID-6: Mother's Maiden Name (XPN)<br> 
	/// PID-7: Date/Time of Birth (TS)<br> 
	/// PID-8: Administrative Sex (IS)<br> 
	/// PID-9: Patient Alias (XPN)<br> 
	/// PID-10: Race (CE)<br> 
	/// PID-11: Patient Address (XAD)<br> 
	/// PID-12: County Code (IS)<br> 
	/// PID-13: Phone Number - Home (XTN)<br> 
	/// PID-14: Phone Number - Business (XTN)<br> 
	/// PID-15: Primary Language (CE)<br> 
	/// PID-16: Marital Status (CE)<br> 
	/// PID-17: Religion (CE)<br> 
	/// PID-18: Patient Account Number (CX)<br> 
	/// PID-19: SSN Number - Patient (ST)<br> 
	/// PID-20: Driver's License Number - Patient (DLN)<br> 
	/// PID-21: Mother's Identifier (CX)<br> 
	/// PID-22: Ethnic Group (CE)<br> 
	/// PID-23: Birth Place (ST)<br> 
	/// PID-24: Multiple Birth Indicator (ID)<br> 
	/// PID-25: Birth Order (NM)<br> 
	/// PID-26: Citizenship (CE)<br> 
	/// PID-27: Veterans Military Status (CE)<br> 
	/// PID-28: Nationality (CE)<br> 
	/// PID-29: Patient Death Date and Time (TS)<br> 
	/// PID-30: Patient Death Indicator (ID)<br> 
	/// PID-31: Identity Unknown Indicator (ID)<br> 
	/// PID-32: Identity Reliability Code (IS)<br> 
	/// PID-33: Last Update Date/Time (TS)<br> 
	/// PID-34: Last Update Facility (HD)<br> 
	/// PID-35: Species Code (CE)<br> 
	/// PID-36: Breed Code (CE)<br> 
	/// PID-37: Strain (ST)<br> 
	/// PID-38: Production Class Code (CE)<br> 
	/// PID-39: Tribal Citizenship (CWE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PID:AbstractSegment
	{
		/// <summary> Returns Set ID - PID (PID-1).</summary>
		virtual public SI SetIDPID
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
		/// <summary> Returns Patient ID (PID-2).</summary>
		virtual public CX PatientID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Date/Time of Birth (PID-7).</summary>
		virtual public TS DateTimeOfBirth
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Administrative Sex (PID-8).</summary>
		virtual public IS AdministrativeSex
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns County Code (PID-12).</summary>
		virtual public IS CountyCode
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
		/// <summary> Returns Primary Language (PID-15).</summary>
		virtual public CE PrimaryLanguage
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Marital Status (PID-16).</summary>
		virtual public CE MaritalStatus
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
		/// <summary> Returns Religion (PID-17).</summary>
		virtual public CE Religion
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
		/// <summary> Returns Patient Account Number (PID-18).</summary>
		virtual public CX PatientAccountNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns SSN Number - Patient (PID-19).</summary>
		virtual public ST SSNNumberPatient
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Driver's License Number - Patient (PID-20).</summary>
		virtual public DLN DriverSLicenseNumberPatient
		{
			get
			{
				DLN ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Birth Place (PID-23).</summary>
		virtual public ST BirthPlace
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
		/// <summary> Returns Multiple Birth Indicator (PID-24).</summary>
		virtual public ID MultipleBirthIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Birth Order (PID-25).</summary>
		virtual public NM BirthOrder
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Veterans Military Status (PID-27).</summary>
		virtual public CE VeteransMilitaryStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Nationality (PID-28).</summary>
		virtual public CE Nationality
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns Patient Death Date and Time (PID-29).</summary>
		virtual public TS PatientDeathDateAndTime
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
		/// <summary> Returns Patient Death Indicator (PID-30).</summary>
		virtual public ID PatientDeathIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(30, 0);
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
		/// <summary> Returns Identity Unknown Indicator (PID-31).</summary>
		virtual public ID IdentityUnknownIndicator
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
		/// <summary> Returns Last Update Date/Time (PID-33).</summary>
		virtual public TS LastUpdateDateTime
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
		/// <summary> Returns Last Update Facility (PID-34).</summary>
		virtual public HD LastUpdateFacility
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(34, 0);
					ret = (HD) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Species Code (PID-35).</summary>
		virtual public CE SpeciesCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(35, 0);
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
		/// <summary> Returns Breed Code (PID-36).</summary>
		virtual public CE BreedCode
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
		/// <summary> Returns Strain (PID-37).</summary>
		virtual public ST Strain
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(37, 0);
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
		/// <summary> Returns Production Class Code (PID-38).</summary>
		virtual public CE ProductionClassCode
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
		
		/// <summary> Creates a PID (Patient Identification) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PID(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CX), true, 0, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 20, new System.Object[]{message});
				this.add(typeof(XPN), true, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 4, new System.Object[]{message, 289});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
				this.add(typeof(DLN), false, 1, 25, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 0, 20, new System.Object[]{message, 445});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 241, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Patient Identifier List (PID-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getPatientIdentifierList(int rep)
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
		
		/// <summary> Returns all repetitions of Patient Identifier List (PID-3).</summary>
		public virtual CX[] getPatientIdentifierList()
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
		
		/// <summary> Returns a single repetition of Alternate Patient ID - PID (PID-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getAlternatePatientIDPID(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Alternate Patient ID - PID (PID-4).</summary>
		public virtual CX[] getAlternatePatientIDPID()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Patient Name (PID-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getPatientName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Name (PID-5).</summary>
		public virtual XPN[] getPatientName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of Mother's Maiden Name (PID-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getMotherSMaidenName(int rep)
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
		
		/// <summary> Returns all repetitions of Mother's Maiden Name (PID-6).</summary>
		public virtual XPN[] getMotherSMaidenName()
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
		
		/// <summary> Returns a single repetition of Patient Alias (PID-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getPatientAlias(int rep)
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
		
		/// <summary> Returns all repetitions of Patient Alias (PID-9).</summary>
		public virtual XPN[] getPatientAlias()
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
		
		/// <summary> Returns a single repetition of Race (PID-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getRace(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Race (PID-10).</summary>
		public virtual CE[] getRace()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(10);
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
		
		/// <summary> Returns a single repetition of Patient Address (PID-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getPatientAddress(int rep)
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
		
		/// <summary> Returns all repetitions of Patient Address (PID-11).</summary>
		public virtual XAD[] getPatientAddress()
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
		
		/// <summary> Returns a single repetition of Phone Number - Home (PID-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getPhoneNumberHome(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone Number - Home (PID-13).</summary>
		public virtual XTN[] getPhoneNumberHome()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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
		
		/// <summary> Returns a single repetition of Phone Number - Business (PID-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getPhoneNumberBusiness(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone Number - Business (PID-14).</summary>
		public virtual XTN[] getPhoneNumberBusiness()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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
		
		/// <summary> Returns a single repetition of Mother's Identifier (PID-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getMotherSIdentifier(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Mother's Identifier (PID-21).</summary>
		public virtual CX[] getMotherSIdentifier()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(21);
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
		
		/// <summary> Returns a single repetition of Ethnic Group (PID-22).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getEthnicGroup(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(22, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ethnic Group (PID-22).</summary>
		public virtual CE[] getEthnicGroup()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(22);
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
		
		/// <summary> Returns a single repetition of Citizenship (PID-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCitizenship(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Citizenship (PID-26).</summary>
		public virtual CE[] getCitizenship()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(26);
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
		
		/// <summary> Returns a single repetition of Identity Reliability Code (PID-32).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getIdentityReliabilityCode(int rep)
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
		
		/// <summary> Returns all repetitions of Identity Reliability Code (PID-32).</summary>
		public virtual IS[] getIdentityReliabilityCode()
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
		
		/// <summary> Returns a single repetition of Tribal Citizenship (PID-39).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getTribalCitizenship(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(39, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Tribal Citizenship (PID-39).</summary>
		public virtual CWE[] getTribalCitizenship()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(39);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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