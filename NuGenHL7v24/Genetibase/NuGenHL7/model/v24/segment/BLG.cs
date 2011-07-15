using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 BLG message segment. 
	/// This segment has the following fields:</p><p>
	/// BLG-1: When to Charge (CCD)<br> 
	/// BLG-2: Charge Type (ID)<br> 
	/// BLG-3: Account ID (CX)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class BLG:AbstractSegment
	{
		/// <summary> Returns When to Charge (BLG-1).</summary>
		virtual public CCD WhenToCharge
		{
			get
			{
				CCD ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (CCD) t;
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
		/// <summary> Returns Charge Type (BLG-2).</summary>
		virtual public ID ChargeType
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
		/// <summary> Returns Account ID (BLG-3).</summary>
		virtual public CX AccountID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		
		/// <summary> Creates a BLG (Billing) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public BLG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CCD), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 50, new System.Object[]{message, 122});
				this.add(typeof(CX), false, 1, 100, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}