using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 RQD message segment. 
	/// This segment has the following fields:</p><p>
	/// RQD-1: Requisition Line Number (SI)<br> 
	/// RQD-2: Item Code - Internal (CE)<br> 
	/// RQD-3: Item Code - External (CE)<br> 
	/// RQD-4: Hospital Item Code (CE)<br> 
	/// RQD-5: Requisition Quantity (NM)<br> 
	/// RQD-6: Requisition Unit of Measure (CE)<br> 
	/// RQD-7: Dept. Cost Center (IS)<br> 
	/// RQD-8: Item Natural Account Code (IS)<br> 
	/// RQD-9: Deliver To ID (CE)<br> 
	/// RQD-10: Date Needed (DT)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RQD:AbstractSegment
	{
		/// <summary> Returns Requisition Line Number (RQD-1).</summary>
		virtual public SI RequisitionLineNumber
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
		/// <summary> Returns Item Code - Internal (RQD-2).</summary>
		virtual public CE ItemCodeInternal
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Item Code - External (RQD-3).</summary>
		virtual public CE ItemCodeExternal
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
		/// <summary> Returns Hospital Item Code (RQD-4).</summary>
		virtual public CE HospitalItemCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Requisition Quantity (RQD-5).</summary>
		virtual public NM RequisitionQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Requisition Unit of Measure (RQD-6).</summary>
		virtual public CE RequisitionUnitOfMeasure
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Dept. Cost Center (RQD-7).</summary>
		virtual public IS DeptCostCenter
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Item Natural Account Code (RQD-8).</summary>
		virtual public IS ItemNaturalAccountCode
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
		/// <summary> Returns Deliver To ID (RQD-9).</summary>
		virtual public CE DeliverToID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Date Needed (RQD-10).</summary>
		virtual public DT DateNeeded
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
		
		/// <summary> Creates a RQD (Requisition Detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RQD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 6, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 30, new System.Object[]{message, 319});
				this.add(typeof(IS), false, 1, 30, new System.Object[]{message, 320});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}