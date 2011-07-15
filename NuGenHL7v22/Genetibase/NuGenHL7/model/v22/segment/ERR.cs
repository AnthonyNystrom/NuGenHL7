using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 ERR message segment. 
	/// This segment has the following fields:</p><p>
	/// ERR-1: Error Code and Location (CM_ELD)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ERR:AbstractSegment
	{
		
		/// <summary> Creates a ERR (ERROR) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ERR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CM_ELD), true, 0, 80, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Error Code and Location (ERR-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_ELD getErrorCodeAndLocation(int rep)
		{
			CM_ELD ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (CM_ELD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Error Code and Location (ERR-1).</summary>
		public virtual CM_ELD[] getErrorCodeAndLocation()
		{
			CM_ELD[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new CM_ELD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_ELD) t[i];
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