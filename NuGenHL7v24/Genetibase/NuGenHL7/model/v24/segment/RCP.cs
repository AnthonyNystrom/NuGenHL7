using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 RCP message segment. 
	/// This segment has the following fields:</p><p>
	/// RCP-1: Query Priority (ID)<br> 
	/// RCP-2: Quantity Limited Request (CQ)<br> 
	/// RCP-3: Response Modality (CE)<br> 
	/// RCP-4: Execution and Delivery Time (TS)<br> 
	/// RCP-5: Modify Indicator (ID)<br> 
	/// RCP-6: Sort-by Field (SRT)<br> 
	/// RCP-7: Segment group inclusion (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RCP:AbstractSegment
	{
		/// <summary> Returns Query Priority (RCP-1).</summary>
		virtual public ID QueryPriority
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Quantity Limited Request (RCP-2).</summary>
		virtual public CQ QuantityLimitedRequest
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CQ) t;
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
		/// <summary> Returns Response Modality (RCP-3).</summary>
		virtual public CE ResponseModality
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
		/// <summary> Returns Execution and Delivery Time (RCP-4).</summary>
		virtual public TS ExecutionAndDeliveryTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Modify Indicator (RCP-5).</summary>
		virtual public ID ModifyIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		
		/// <summary> Creates a RCP (Response Control Parameter) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RCP(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 91});
				this.add(typeof(CQ), false, 1, 10, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 395});
				this.add(typeof(SRT), false, 0, 512, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 256, new System.Object[]{message, 0});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Sort-by Field (RCP-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual SRT getSortByField(int rep)
		{
			SRT ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (SRT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Sort-by Field (RCP-6).</summary>
		public virtual SRT[] getSortByField()
		{
			SRT[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new SRT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (SRT) t[i];
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
		
		/// <summary> Returns a single repetition of Segment group inclusion (RCP-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getSegmentGroupInclusion(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Segment group inclusion (RCP-7).</summary>
		public virtual ID[] getSegmentGroupInclusion()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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