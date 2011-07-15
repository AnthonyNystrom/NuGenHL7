using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 DG1 message segment. 
	/// This segment has the following fields:</p><p>
	/// DG1-1: Set ID - diagnosis (SI)<br> 
	/// DG1-2: Diagnosis coding method (ID)<br> 
	/// DG1-3: Diagnosis code (ID)<br> 
	/// DG1-4: Diagnosis description (ST)<br> 
	/// DG1-5: Diagnosis date / time (TS)<br> 
	/// DG1-6: Diagnosis / DRG type (ID)<br> 
	/// DG1-7: Major diagnostic category (CE)<br> 
	/// DG1-8: Diagnostic related group (ID)<br> 
	/// DG1-9: DRG approval indicator (ID)<br> 
	/// DG1-10: DRG grouper review code (ID)<br> 
	/// DG1-11: Outlier type (ID)<br> 
	/// DG1-12: Outlier days (NM)<br> 
	/// DG1-13: Outlier cost (NM)<br> 
	/// DG1-14: Grouper version and type (ST)<br> 
	/// DG1-15: Diagnosis / DRG priority (NM)<br> 
	/// DG1-16: Diagnosing clinician (CN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class DG1:AbstractSegment
	{
		/// <summary> Returns Set ID - diagnosis (DG1-1).</summary>
		virtual public SI SetIDDiagnosis
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
		/// <summary> Returns Diagnosis coding method (DG1-2).</summary>
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
		/// <summary> Returns Diagnosis code (DG1-3).</summary>
		virtual public ID DiagnosisCode
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
		/// <summary> Returns Diagnosis description (DG1-4).</summary>
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
		/// <summary> Returns Diagnosis date / time (DG1-5).</summary>
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
		/// <summary> Returns Diagnosis / DRG type (DG1-6).</summary>
		virtual public ID DiagnosisDRGType
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
		/// <summary> Returns Major diagnostic category (DG1-7).</summary>
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
		/// <summary> Returns Diagnostic related group (DG1-8).</summary>
		virtual public ID DiagnosticRelatedGroup
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
		/// <summary> Returns DRG approval indicator (DG1-9).</summary>
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
		/// <summary> Returns DRG grouper review code (DG1-10).</summary>
		virtual public ID DRGGrouperReviewCode
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
		/// <summary> Returns Outlier type (DG1-11).</summary>
		virtual public ID OutlierType
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
		/// <summary> Returns Outlier days (DG1-12).</summary>
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
		/// <summary> Returns Outlier cost (DG1-13).</summary>
		virtual public NM OutlierCost
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Grouper version and type (DG1-14).</summary>
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
		/// <summary> Returns Diagnosis / DRG priority (DG1-15).</summary>
		virtual public NM DiagnosisDRGPriority
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Diagnosing clinician (DG1-16).</summary>
		virtual public CN DiagnosingClinician
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		
		/// <summary> Creates a DG1 (DIAGNOSIS) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public DG1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 53});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 51});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 52});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 55});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 56});
				this.add(typeof(ID), false, 1, 60, new System.Object[]{message, 83});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}