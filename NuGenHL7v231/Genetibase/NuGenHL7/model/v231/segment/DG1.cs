using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 DG1 message segment. 
	/// This segment has the following fields:</p><p>
	/// DG1-1: Set ID - DG1 (SI)<br> 
	/// DG1-2: Diagnosis Coding Method (ID)<br> 
	/// DG1-3: Diagnosis Code - DG1 (CE)<br> 
	/// DG1-4: Diagnosis Description (ST)<br> 
	/// DG1-5: Diagnosis Date/Time (TS)<br> 
	/// DG1-6: Diagnosis Type (IS)<br> 
	/// DG1-7: Major Diagnostic Category (CE)<br> 
	/// DG1-8: Diagnostic Related Group (CE)<br> 
	/// DG1-9: DRG Approval Indicator (ID)<br> 
	/// DG1-10: DRG Grouper Review Code (IS)<br> 
	/// DG1-11: Outlier Type (CE)<br> 
	/// DG1-12: Outlier Days (NM)<br> 
	/// DG1-13: Outlier Cost (CP)<br> 
	/// DG1-14: Grouper Version And Type (ST)<br> 
	/// DG1-15: Diagnosis Priority (ID)<br> 
	/// DG1-16: Diagnosing Clinician (XCN)<br> 
	/// DG1-17: Diagnosis Classification (IS)<br> 
	/// DG1-18: Confidential Indicator (ID)<br> 
	/// DG1-19: Attestation Date/Time (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class DG1:AbstractSegment
	{
		/// <summary> Returns Set ID - DG1 (DG1-1).</summary>
		virtual public SI SetIDDG1
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
		/// <summary> Returns Diagnosis Coding Method (DG1-2).</summary>
		virtual public ID DiagnosisCodingMethod
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
		/// <summary> Returns Diagnosis Code - DG1 (DG1-3).</summary>
		virtual public CE DiagnosisCodeDG1
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
		/// <summary> Returns Diagnosis Description (DG1-4).</summary>
		virtual public ST DiagnosisDescription
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
		/// <summary> Returns Diagnosis Date/Time (DG1-5).</summary>
		virtual public TS DiagnosisDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Diagnosis Type (DG1-6).</summary>
		virtual public IS DiagnosisType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Major Diagnostic Category (DG1-7).</summary>
		virtual public CE MajorDiagnosticCategory
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Diagnostic Related Group (DG1-8).</summary>
		virtual public CE DiagnosticRelatedGroup
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns DRG Approval Indicator (DG1-9).</summary>
		virtual public ID DRGApprovalIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns DRG Grouper Review Code (DG1-10).</summary>
		virtual public IS DRGGrouperReviewCode
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
		/// <summary> Returns Outlier Type (DG1-11).</summary>
		virtual public CE OutlierType
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Outlier Days (DG1-12).</summary>
		virtual public NM OutlierDays
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Outlier Cost (DG1-13).</summary>
		virtual public CP OutlierCost
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (CP) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Grouper Version And Type (DG1-14).</summary>
		virtual public ST GrouperVersionAndType
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Diagnosis Priority (DG1-15).</summary>
		virtual public ID DiagnosisPriority
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
		/// <summary> Returns Diagnosis Classification (DG1-17).</summary>
		virtual public IS DiagnosisClassification
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Confidential Indicator (DG1-18).</summary>
		virtual public ID ConfidentialIndicator
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
		/// <summary> Returns Attestation Date/Time (DG1-19).</summary>
		virtual public TS AttestationDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		
		/// <summary> Creates a DG1 (DG1 - diagnosis segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public DG1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 53});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), true, 1, 2, new System.Object[]{message, 52});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 56});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 359});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 228});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Diagnosing Clinician (DG1-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getDiagnosingClinician(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Diagnosing Clinician (DG1-16).</summary>
		public virtual XCN[] getDiagnosingClinician()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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