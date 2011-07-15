using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 DG1 message segment. 
	/// This segment has the following fields:</p><p>
	/// DG1-1: SET ID - DIAGNOSIS (SI)<br> 
	/// DG1-2: DIAGNOSIS CODING METHOD (ID)<br> 
	/// DG1-3: DIAGNOSIS CODE (ID)<br> 
	/// DG1-4: DIAGNOSIS DESCRIPTION (ST)<br> 
	/// DG1-5: DIAGNOSIS DATE/TIME (TS)<br> 
	/// DG1-6: DIAGNOSIS/DRG TYPE (ID)<br> 
	/// DG1-7: MAJOR DIAGNOSTIC CATEGORY (ST)<br> 
	/// DG1-8: DIAGNOSTIC RELATED GROUP (ID)<br> 
	/// DG1-9: DRG APPROVAL INDICATOR (ID)<br> 
	/// DG1-10: DRG GROUPER REVIEW CODE (ID)<br> 
	/// DG1-11: OUTLIER TYPE (ID)<br> 
	/// DG1-12: OUTLIER DAYS (NM)<br> 
	/// DG1-13: OUTLIER COST (NM)<br> 
	/// DG1-14: GROUPER VERSION AND TYPE (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class DG1:AbstractSegment
	{
		/// <summary> Returns SET ID - DIAGNOSIS (DG1-1).</summary>
		virtual public SI SETIDDIAGNOSIS
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
		/// <summary> Returns DIAGNOSIS CODING METHOD (DG1-2).</summary>
		virtual public ID DIAGNOSISCODINGMETHOD
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
		/// <summary> Returns DIAGNOSIS CODE (DG1-3).</summary>
		virtual public ID DIAGNOSISCODE
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
		/// <summary> Returns DIAGNOSIS DESCRIPTION (DG1-4).</summary>
		virtual public ST DIAGNOSISDESCRIPTION
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
		/// <summary> Returns DIAGNOSIS DATE/TIME (DG1-5).</summary>
		virtual public TS DIAGNOSISDATETIME
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
		/// <summary> Returns DIAGNOSIS/DRG TYPE (DG1-6).</summary>
		virtual public ID DIAGNOSISDRGTYPE
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
		/// <summary> Returns MAJOR DIAGNOSTIC CATEGORY (DG1-7).</summary>
		virtual public ST MAJORDIAGNOSTICCATEGORY
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns DIAGNOSTIC RELATED GROUP (DG1-8).</summary>
		virtual public ID DIAGNOSTICRELATEDGROUP
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
		/// <summary> Returns DRG APPROVAL INDICATOR (DG1-9).</summary>
		virtual public ID DRGAPPROVALINDICATOR
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
		/// <summary> Returns DRG GROUPER REVIEW CODE (DG1-10).</summary>
		virtual public ID DRGGROUPERREVIEWCODE
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
		/// <summary> Returns OUTLIER TYPE (DG1-11).</summary>
		virtual public ID OUTLIERTYPE
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
		/// <summary> Returns OUTLIER DAYS (DG1-12).</summary>
		virtual public NM OUTLIERDAYS
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
		/// <summary> Returns OUTLIER COST (DG1-13).</summary>
		virtual public NM OUTLIERCOST
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
		/// <summary> Returns GROUPER VERSION AND TYPE (DG1-14).</summary>
		virtual public ST GROUPERVERSIONANDTYPE
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
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 52});
				this.add(typeof(ST), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 55});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 56});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 83});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 4, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}