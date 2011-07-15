using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 CSR message segment. 
	/// This segment has the following fields:</p><p>
	/// CSR-1: Sponsor Study ID (EI)<br> 
	/// CSR-2: Alternate Study ID (EI)<br> 
	/// CSR-3: Institution Registering the Patient (CE)<br> 
	/// CSR-4: Sponsor Patient ID (CX)<br> 
	/// CSR-5: Alternate Patient ID - CSR (CX)<br> 
	/// CSR-6: Date/Time Of Patient Study Registration (TS)<br> 
	/// CSR-7: Person Performing Study Registration (XCN)<br> 
	/// CSR-8: Study Authorizing Provider (XCN)<br> 
	/// CSR-9: Date/time Patient Study Consent Signed (TS)<br> 
	/// CSR-10: Patient Study Eligibility Status (CE)<br> 
	/// CSR-11: Study Randomization Date/time (TS)<br> 
	/// CSR-12: Randomized Study Arm (CE)<br> 
	/// CSR-13: Stratum for Study Randomization (CE)<br> 
	/// CSR-14: Patient Evaluability Status (CE)<br> 
	/// CSR-15: Date/time Ended Study (TS)<br> 
	/// CSR-16: Reason Ended Study (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class CSR:AbstractSegment
	{
		/// <summary> Returns Sponsor Study ID (CSR-1).</summary>
		virtual public EI SponsorStudyID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (EI) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Alternate Study ID (CSR-2).</summary>
		virtual public EI AlternateStudyID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (EI) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Institution Registering the Patient (CSR-3).</summary>
		virtual public CE InstitutionRegisteringThePatient
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
		/// <summary> Returns Sponsor Patient ID (CSR-4).</summary>
		virtual public CX SponsorPatientID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Alternate Patient ID - CSR (CSR-5).</summary>
		virtual public CX AlternatePatientIDCSR
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
		/// <summary> Returns Date/Time Of Patient Study Registration (CSR-6).</summary>
		virtual public TS DateTimeOfPatientStudyRegistration
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
		/// <summary> Returns Date/time Patient Study Consent Signed (CSR-9).</summary>
		virtual public TS DateTimePatientStudyConsentSigned
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
		/// <summary> Returns Patient Study Eligibility Status (CSR-10).</summary>
		virtual public CE PatientStudyEligibilityStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Patient Evaluability Status (CSR-14).</summary>
		virtual public CE PatientEvaluabilityStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Date/time Ended Study (CSR-15).</summary>
		virtual public TS DateTimeEndedStudy
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Reason Ended Study (CSR-16).</summary>
		virtual public CE ReasonEndedStudy
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
		
		/// <summary> Creates a CSR (Clinical Study Registration) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public CSR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(EI), true, 1, 60, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CX), true, 1, 30, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 30, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), true, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 0, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Person Performing Study Registration (CSR-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getPersonPerformingStudyRegistration(int rep)
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
		
		/// <summary> Returns all repetitions of Person Performing Study Registration (CSR-7).</summary>
		public virtual XCN[] getPersonPerformingStudyRegistration()
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
		
		/// <summary> Returns a single repetition of Study Authorizing Provider (CSR-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getStudyAuthorizingProvider(int rep)
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
		
		/// <summary> Returns all repetitions of Study Authorizing Provider (CSR-8).</summary>
		public virtual XCN[] getStudyAuthorizingProvider()
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
		
		/// <summary> Returns a single repetition of Study Randomization Date/time (CSR-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TS getStudyRandomizationDateTime(int rep)
		{
			TS ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (TS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Study Randomization Date/time (CSR-11).</summary>
		public virtual TS[] getStudyRandomizationDateTime()
		{
			TS[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new TS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TS) t[i];
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
		
		/// <summary> Returns a single repetition of Randomized Study Arm (CSR-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getRandomizedStudyArm(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Randomized Study Arm (CSR-12).</summary>
		public virtual CE[] getRandomizedStudyArm()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(12);
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
		
		/// <summary> Returns a single repetition of Stratum for Study Randomization (CSR-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getStratumForStudyRandomization(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Stratum for Study Randomization (CSR-13).</summary>
		public virtual CE[] getStratumForStudyRandomization()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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