using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 BLC message segment. 
	/// This segment has the following fields:</p><p>
	/// BLC-1: Blood Product Code (CE)<br> 
	/// BLC-2: Blood Amount (CQ)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class BLC:AbstractSegment
	{
		/// <summary> Returns Blood Product Code (BLC-1).</summary>
		virtual public CE BloodProductCode
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
		/// <summary> Returns Blood Amount (BLC-2).</summary>
		virtual public CQ BloodAmount
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
		
		/// <summary> Creates a BLC (Blood Code) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public BLC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 83, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}