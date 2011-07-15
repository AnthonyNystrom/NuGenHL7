using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 OM6 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM6-1: Sequence Number - Test/ Observation Master File (NM)<br> 
	/// OM6-2: Derivation Rule (TX)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM6:AbstractSegment
	{
		/// <summary> Returns Sequence Number - Test/ Observation Master File (OM6-1).</summary>
		virtual public NM SequenceNumberTestObservationMasterFile
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Derivation Rule (OM6-2).</summary>
		virtual public TX DerivationRule
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (TX) t;
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
		
		/// <summary> Creates a OM6 (Observations that are Calculated from Other Observ) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM6(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 10240, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}