using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 DRG message segment. 
	/// This segment has the following fields:</p><p>
	/// DRG-1: Diagnostic Related Group (CE)<br> 
	/// DRG-2: DRG Assigned Date/Time (TS)<br> 
	/// DRG-3: DRG Approval Indicator (ID)<br> 
	/// DRG-4: DRG Grouper Review Code (IS)<br> 
	/// DRG-5: Outlier Type (CE)<br> 
	/// DRG-6: Outlier Days (NM)<br> 
	/// DRG-7: Outlier Cost (CP)<br> 
	/// DRG-8: DRG Payor (IS)<br> 
	/// DRG-9: Outlier Reimbursement (CP)<br> 
	/// DRG-10: Confidential Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class DRG:AbstractSegment
	{
		/// <summary> Returns Diagnostic Related Group (DRG-1).</summary>
		virtual public CE DiagnosticRelatedGroup
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
		/// <summary> Returns DRG Assigned Date/Time (DRG-2).</summary>
		virtual public TS DRGAssignedDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns DRG Approval Indicator (DRG-3).</summary>
		virtual public ID DRGApprovalIndicator
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
		/// <summary> Returns DRG Grouper Review Code (DRG-4).</summary>
		virtual public IS DRGGrouperReviewCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Outlier Type (DRG-5).</summary>
		virtual public CE OutlierType
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Outlier Days (DRG-6).</summary>
		virtual public NM OutlierDays
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Outlier Cost (DRG-7).</summary>
		virtual public CP OutlierCost
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns DRG Payor (DRG-8).</summary>
		virtual public IS DRGPayor
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
		/// <summary> Returns Outlier Reimbursement (DRG-9).</summary>
		virtual public CP OutlierReimbursement
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Confidential Indicator (DRG-10).</summary>
		virtual public ID ConfidentialIndicator
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
		
		/// <summary> Creates a DRG (DRG - diagnosis related group segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public DRG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 56});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 229});
				this.add(typeof(CP), false, 1, 9, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}