using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 NPU message segment. 
	/// This segment has the following fields:</p><p>
	/// NPU-1: Bed Location (CM_INTERNAL_LOCATION)<br> 
	/// NPU-2: Bed Status (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NPU:AbstractSegment
	{
		/// <summary> Returns Bed Location (NPU-1).</summary>
		virtual public CM_INTERNAL_LOCATION BedLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (CM_INTERNAL_LOCATION) t;
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
		/// <summary> Returns Bed Status (NPU-2).</summary>
		virtual public ID BedStatus
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
		
		/// <summary> Creates a NPU (BED STATUS UPDATE) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NPU(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CM_INTERNAL_LOCATION), true, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 116});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}