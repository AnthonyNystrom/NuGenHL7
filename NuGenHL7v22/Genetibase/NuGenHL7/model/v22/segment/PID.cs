using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 PID message segment. 
	/// This segment has the following fields:</p><p>
	/// PID-1: Set ID - Patient ID (SI)<br> 
	/// PID-2: Patient ID (External ID) (CK)<br> 
	/// PID-3: Patient ID (Internal ID) (CM_PAT_ID)<br> 
	/// PID-4: Alternate Patient ID (ST)<br> 
	/// PID-5: Patient Name (PN)<br> 
	/// PID-6: Mother's Maiden Name (ST)<br> 
	/// PID-7: Date of Birth (TS)<br> 
	/// PID-8: Sex (ID)<br> 
	/// PID-9: Patient Alias (PN)<br> 
	/// PID-10: Race (ID)<br> 
	/// PID-11: Patient Address (AD)<br> 
	/// PID-12: County code (ID)<br> 
	/// PID-13: Phone Number - Home (TN)<br> 
	/// PID-14: Phone Number - Business (TN)<br> 
	/// PID-15: Language - Patient (ST)<br> 
	/// PID-16: Marital Status (ID)<br> 
	/// PID-17: Religion (ID)<br> 
	/// PID-18: Patient Account Number (CK)<br> 
	/// PID-19: Social security number - patient (ST)<br> 
	/// PID-20: Driver's license number - patient (CM_LICENSE_NO)<br> 
	/// PID-21: Mother's Identifier (CK)<br> 
	/// PID-22: Ethnic Group (ID)<br> 
	/// PID-23: Birth Place (ST)<br> 
	/// PID-24: Multiple Birth Indicator (ID)<br> 
	/// PID-25: Birth Order (NM)<br> 
	/// PID-26: Citizenship (ID)<br> 
	/// PID-27: Veterans Military Status (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PID:AbstractSegment
	{
		/// <summary> Returns Set ID - Patient ID (PID-1).</summary>
		virtual public SI SetIDPatientID
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
		/// <summary> Returns Patient ID (External ID) (PID-2).</summary>
		virtual public CK PatientIDExternalID
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CK) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Alternate Patient ID (PID-4).</summary>
		virtual public ST AlternatePatientID
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
		/// <summary> Returns Patient Name (PID-5).</summary>
		virtual public PN PatientName
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Mother's Maiden Name (PID-6).</summary>
		virtual public ST MotherSMaidenName
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
		/// <summary> Returns Date of Birth (PID-7).</summary>
		virtual public TS DateOfBirth
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
		/// <summary> Returns Sex (PID-8).</summary>
		virtual public ID Sex
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Race (PID-10).</summary>
		virtual public ID Race
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
		/// <summary> Returns County code (PID-12).</summary>
		virtual public ID CountyCode
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
		/// <summary> Returns Language - Patient (PID-15).</summary>
		virtual public ST LanguagePatient
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Marital Status (PID-16).</summary>
		virtual public ID MaritalStatus
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
		/// <summary> Returns Religion (PID-17).</summary>
		virtual public ID Religion
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
		/// <summary> Returns Patient Account Number (PID-18).</summary>
		virtual public CK PatientAccountNumber
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (CK) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Social security number - patient (PID-19).</summary>
		virtual public ST SocialSecurityNumberPatient
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
		/// <summary> Returns Driver's license number - patient (PID-20).</summary>
		virtual public CM_LICENSE_NO DriverSLicenseNumberPatient
		{
			get
			{
				CM_LICENSE_NO ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (CM_LICENSE_NO) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Mother's Identifier (PID-21).</summary>
		virtual public CK MotherSIdentifier
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (CK) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Ethnic Group (PID-22).</summary>
		virtual public ID EthnicGroup
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
		virtual public ST VeteransMilitaryStatus
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		
		/// <summary> Creates a PID (PATIENT IDENTIFICATION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PID(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CK), false, 1, 16, new System.Object[]{message});
				this.add(typeof(CM_PAT_ID), true, 0, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(PN), true, 1, 48, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(PN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 5});
				this.add(typeof(AD), false, 3, 106, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 0});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 2});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 6});
				this.add(typeof(CK), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
				this.add(typeof(CM_LICENSE_NO), false, 1, 25, new System.Object[]{message});
				this.add(typeof(CK), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 189});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 3, new System.Object[]{message, 171});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Patient ID (Internal ID) (PID-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_PAT_ID getPatientIDInternalID(int rep)
		{
			CM_PAT_ID ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (CM_PAT_ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient ID (Internal ID) (PID-3).</summary>
		public virtual CM_PAT_ID[] getPatientIDInternalID()
		{
			CM_PAT_ID[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new CM_PAT_ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_PAT_ID) t[i];
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
		public virtual PN getPatientAlias(int rep)
		{
			PN ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (PN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Alias (PID-9).</summary>
		public virtual PN[] getPatientAlias()
		{
			PN[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new PN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PN) t[i];
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
		public virtual AD getPatientAddress(int rep)
		{
			AD ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (AD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Address (PID-11).</summary>
		public virtual AD[] getPatientAddress()
		{
			AD[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new AD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (AD) t[i];
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
		public virtual TN getPhoneNumberHome(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone Number - Home (PID-13).</summary>
		public virtual TN[] getPhoneNumberHome()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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
		
		/// <summary> Returns a single repetition of Phone Number - Business (PID-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getPhoneNumberBusiness(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone Number - Business (PID-14).</summary>
		public virtual TN[] getPhoneNumberBusiness()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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
		
		/// <summary> Returns a single repetition of Citizenship (PID-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getCitizenship(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Citizenship (PID-26).</summary>
		public virtual ID[] getCitizenship()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(26);
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
	}
}