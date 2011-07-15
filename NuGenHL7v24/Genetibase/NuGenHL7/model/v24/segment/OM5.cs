using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 OM5 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM5-1: Sequence Number - Test/ Observation Master File (NM)<br> 
	/// OM5-2: Test/Observations Included within an Ordered Test Battery (CE)<br> 
	/// OM5-3: Observation ID Suffixes (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM5:AbstractSegment
	{
		/// <summary> Returns Sequence Number - Test/ Observation Master File (OM5-1).</summary>
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
		/// <summary> Returns Observation ID Suffixes (OM5-3).</summary>
		virtual public ST ObservationIDSuffixes
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
		
		/// <summary> Creates a OM5 (Observation Batteries (Sets)) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM5(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Test/Observations Included within an Ordered Test Battery (OM5-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getTestObservationsIncludedWithinAnOrderedTestBattery(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Test/Observations Included within an Ordered Test Battery (OM5-2).</summary>
		public virtual CE[] getTestObservationsIncludedWithinAnOrderedTestBattery()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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