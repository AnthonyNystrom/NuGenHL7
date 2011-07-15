using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 IN3 message segment. 
	/// This segment has the following fields:</p><p>
	/// IN3-1: Set ID - insurance certification (SI)<br> 
	/// IN3-2: Certification number (ST)<br> 
	/// IN3-3: Certified by (CN)<br> 
	/// IN3-4: Certification required (ID)<br> 
	/// IN3-5: Penalty (CM_PEN)<br> 
	/// IN3-6: Certification date / time (TS)<br> 
	/// IN3-7: Certification modify date / time (TS)<br> 
	/// IN3-8: Operator (CN)<br> 
	/// IN3-9: Certification begin date (DT)<br> 
	/// IN3-10: Certification end date (DT)<br> 
	/// IN3-11: Days (CM_DTN)<br> 
	/// IN3-12: Non-concur code / description (CE)<br> 
	/// IN3-13: Non-concur effective date / time (TS)<br> 
	/// IN3-14: Physician reviewer (CN)<br> 
	/// IN3-15: Certification contact (ST)<br> 
	/// IN3-16: Certification contact phone number (TN)<br> 
	/// IN3-17: Appeal reason (CE)<br> 
	/// IN3-18: Certification agency (CE)<br> 
	/// IN3-19: Certification agency phone number (TN)<br> 
	/// IN3-20: Pre-certification required / window (CM_PCF)<br> 
	/// IN3-21: Case manager (ST)<br> 
	/// IN3-22: Second opinion date (DT)<br> 
	/// IN3-23: Second opinion status (ID)<br> 
	/// IN3-24: Second opinion documentation received (ID)<br> 
	/// IN3-25: Second opinion practitioner (CN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IN3:AbstractSegment
	{
		/// <summary> Returns Set ID - insurance certification (IN3-1).</summary>
		virtual public SI SetIDInsuranceCertification
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
		/// <summary> Returns Certification number (IN3-2).</summary>
		virtual public ST CertificationNumber
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
		/// <summary> Returns Certified by (IN3-3).</summary>
		virtual public CN CertifiedBy
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Certification required (IN3-4).</summary>
		virtual public ID CertificationRequired
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
		/// <summary> Returns Penalty (IN3-5).</summary>
		virtual public CM_PEN Penalty
		{
			get
			{
				CM_PEN ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CM_PEN) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Certification date / time (IN3-6).</summary>
		virtual public TS CertificationDateTime
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
		/// <summary> Returns Certification modify date / time (IN3-7).</summary>
		virtual public TS CertificationModifyDateTime
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
		/// <summary> Returns Operator (IN3-8).</summary>
		virtual public CN Operator
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
		/// <summary> Returns Certification begin date (IN3-9).</summary>
		virtual public DT CertificationBeginDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Certification end date (IN3-10).</summary>
		virtual public DT CertificationEndDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Days (IN3-11).</summary>
		virtual public CM_DTN Days
		{
			get
			{
				CM_DTN ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CM_DTN) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Non-concur code / description (IN3-12).</summary>
		virtual public CE NonConcurCodeDescription
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Non-concur effective date / time (IN3-13).</summary>
		virtual public TS NonConcurEffectiveDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Physician reviewer (IN3-14).</summary>
		virtual public CN PhysicianReviewer
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Certification contact (IN3-15).</summary>
		virtual public ST CertificationContact
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
		/// <summary> Returns Appeal reason (IN3-17).</summary>
		virtual public CE AppealReason
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
		/// <summary> Returns Certification agency (IN3-18).</summary>
		virtual public CE CertificationAgency
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Case manager (IN3-21).</summary>
		virtual public ST CaseManager
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
		/// <summary> Returns Second opinion date (IN3-22).</summary>
		virtual public DT SecondOpinionDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Second opinion status (IN3-23).</summary>
		virtual public ID SecondOpinionStatus
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
		/// <summary> Returns Second opinion documentation received (IN3-24).</summary>
		virtual public ID SecondOpinionDocumentationReceived
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
		/// <summary> Returns Second opinion practitioner (IN3-25).</summary>
		virtual public CN SecondOpinionPractitioner
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		
		/// <summary> Creates a IN3 (INSURANCE ADDITIONAL INFO-CERTIFICATION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IN3(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CM_PEN), false, 1, 10, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(CM_DTN), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 48, new System.Object[]{message});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(CM_PCF), false, 0, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 48, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 151});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 152});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Certification contact phone number (IN3-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getCertificationContactPhoneNumber(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Certification contact phone number (IN3-16).</summary>
		public virtual TN[] getCertificationContactPhoneNumber()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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
		
		/// <summary> Returns a single repetition of Certification agency phone number (IN3-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getCertificationAgencyPhoneNumber(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Certification agency phone number (IN3-19).</summary>
		public virtual TN[] getCertificationAgencyPhoneNumber()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(19);
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
		
		/// <summary> Returns a single repetition of Pre-certification required / window (IN3-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_PCF getPreCertificationRequiredWindow(int rep)
		{
			CM_PCF ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (CM_PCF) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Pre-certification required / window (IN3-20).</summary>
		public virtual CM_PCF[] getPreCertificationRequiredWindow()
		{
			CM_PCF[] ret = null;
			try
			{
				Type[] t = this.getField(20);
				ret = new CM_PCF[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_PCF) t[i];
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