using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 IN3 message segment. 
	/// This segment has the following fields:</p><p>
	/// IN3-1: Set ID - IN3 (SI)<br> 
	/// IN3-2: Certification Number (CX)<br> 
	/// IN3-3: Certified By (XCN)<br> 
	/// IN3-4: Certification Required (ID)<br> 
	/// IN3-5: Penalty (MOP)<br> 
	/// IN3-6: Certification Date/Time (TS)<br> 
	/// IN3-7: Certification Modify Date/Time (TS)<br> 
	/// IN3-8: Operator (XCN)<br> 
	/// IN3-9: Certification Begin Date (DT)<br> 
	/// IN3-10: Certification End Date (DT)<br> 
	/// IN3-11: Days (DTN)<br> 
	/// IN3-12: Non-Concur Code/Description (CE)<br> 
	/// IN3-13: Non-Concur Effective Date/Time (TS)<br> 
	/// IN3-14: Physician Reviewer (XCN)<br> 
	/// IN3-15: Certification Contact (ST)<br> 
	/// IN3-16: Certification Contact Phone Number (XTN)<br> 
	/// IN3-17: Appeal Reason (CE)<br> 
	/// IN3-18: Certification Agency (CE)<br> 
	/// IN3-19: Certification Agency Phone Number (XTN)<br> 
	/// IN3-20: Pre-Certification Req/Window (PCF)<br> 
	/// IN3-21: Case Manager (ST)<br> 
	/// IN3-22: Second Opinion Date (DT)<br> 
	/// IN3-23: Second Opinion Status (IS)<br> 
	/// IN3-24: Second Opinion Documentation Received (IS)<br> 
	/// IN3-25: Second Opinion Physician (XCN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IN3:AbstractSegment
	{
		/// <summary> Returns Set ID - IN3 (IN3-1).</summary>
		virtual public SI SetIDIN3
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
		/// <summary> Returns Certification Number (IN3-2).</summary>
		virtual public CX CertificationNumber
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
		/// <summary> Returns Certification Required (IN3-4).</summary>
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
		virtual public MOP Penalty
		{
			get
			{
				MOP ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (MOP) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Certification Date/Time (IN3-6).</summary>
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
		/// <summary> Returns Certification Modify Date/Time (IN3-7).</summary>
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
		/// <summary> Returns Certification Begin Date (IN3-9).</summary>
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
		/// <summary> Returns Certification End Date (IN3-10).</summary>
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
		virtual public DTN Days
		{
			get
			{
				DTN ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (DTN) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Non-Concur Code/Description (IN3-12).</summary>
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
		/// <summary> Returns Non-Concur Effective Date/Time (IN3-13).</summary>
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
		/// <summary> Returns Certification Contact (IN3-15).</summary>
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
		/// <summary> Returns Appeal Reason (IN3-17).</summary>
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
		/// <summary> Returns Certification Agency (IN3-18).</summary>
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
		/// <summary> Returns Case Manager (IN3-21).</summary>
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
		/// <summary> Returns Second Opinion Date (IN3-22).</summary>
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
		/// <summary> Returns Second Opinion Status (IN3-23).</summary>
		virtual public IS SecondOpinionStatus
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
		
		/// <summary> Creates a IN3 (Insurance Additional Information, Certification) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IN3(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(MOP), false, 1, 10, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DTN), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 48, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(PCF), false, 0, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 48, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 151});
				this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 152});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Certified By (IN3-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getCertifiedBy(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Certified By (IN3-3).</summary>
		public virtual XCN[] getCertifiedBy()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Operator (IN3-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getOperator(int rep)
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
		
		/// <summary> Returns all repetitions of Operator (IN3-8).</summary>
		public virtual XCN[] getOperator()
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
		
		/// <summary> Returns a single repetition of Physician Reviewer (IN3-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getPhysicianReviewer(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Physician Reviewer (IN3-14).</summary>
		public virtual XCN[] getPhysicianReviewer()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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
		
		/// <summary> Returns a single repetition of Certification Contact Phone Number (IN3-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getCertificationContactPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Certification Contact Phone Number (IN3-16).</summary>
		public virtual XTN[] getCertificationContactPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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
		
		/// <summary> Returns a single repetition of Certification Agency Phone Number (IN3-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getCertificationAgencyPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Certification Agency Phone Number (IN3-19).</summary>
		public virtual XTN[] getCertificationAgencyPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(19);
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
		
		/// <summary> Returns a single repetition of Pre-Certification Req/Window (IN3-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual PCF getPreCertificationReqWindow(int rep)
		{
			PCF ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (PCF) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Pre-Certification Req/Window (IN3-20).</summary>
		public virtual PCF[] getPreCertificationReqWindow()
		{
			PCF[] ret = null;
			try
			{
				Type[] t = this.getField(20);
				ret = new PCF[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PCF) t[i];
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
		
		/// <summary> Returns a single repetition of Second Opinion Documentation Received (IN3-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getSecondOpinionDocumentationReceived(int rep)
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
		
		/// <summary> Returns all repetitions of Second Opinion Documentation Received (IN3-24).</summary>
		public virtual IS[] getSecondOpinionDocumentationReceived()
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
		
		/// <summary> Returns a single repetition of Second Opinion Physician (IN3-25).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getSecondOpinionPhysician(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(25, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Second Opinion Physician (IN3-25).</summary>
		public virtual XCN[] getSecondOpinionPhysician()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(25);
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