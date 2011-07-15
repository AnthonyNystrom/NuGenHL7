using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 SID message segment. 
	/// This segment has the following fields:</p><p>
	/// SID-1: Application / Method Identifier (CE)<br> 
	/// SID-2: Substance Lot Number (ST)<br> 
	/// SID-3: Substance Container Identifier (ST)<br> 
	/// SID-4: Substance Manufacturer Identifier (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class SID:AbstractSegment
	{
		/// <summary> Returns Application / Method Identifier (SID-1).</summary>
		virtual public CE ApplicationMethodIdentifier
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
		/// <summary> Returns Substance Lot Number (SID-2).</summary>
		virtual public ST SubstanceLotNumber
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
		/// <summary> Returns Substance Container Identifier (SID-3).</summary>
		virtual public ST SubstanceContainerIdentifier
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Substance Manufacturer Identifier (SID-4).</summary>
		virtual public CE SubstanceManufacturerIdentifier
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
		
		/// <summary> Creates a SID (Substance Identifier) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public SID(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}