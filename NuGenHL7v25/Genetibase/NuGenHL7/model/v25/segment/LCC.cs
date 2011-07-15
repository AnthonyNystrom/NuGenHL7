using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 LCC message segment. 
	/// This segment has the following fields:</p><p>
	/// LCC-1: Primary Key Value - LCC (PL)<br> 
	/// LCC-2: Location Department (CE)<br> 
	/// LCC-3: Accommodation Type (CE)<br> 
	/// LCC-4: Charge Code (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class LCC:AbstractSegment
	{
		/// <summary> Returns Primary Key Value - LCC (LCC-1).</summary>
		virtual public PL PrimaryKeyValueLCC
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (PL) t;
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
		/// <summary> Returns Location Department (LCC-2).</summary>
		virtual public CE LocationDepartment
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
		
		/// <summary> Creates a LCC (Location Charge Code) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public LCC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(PL), true, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), true, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Accommodation Type (LCC-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getAccommodationType(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Accommodation Type (LCC-3).</summary>
		public virtual CE[] getAccommodationType()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Charge Code (LCC-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getChargeCode(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Charge Code (LCC-4).</summary>
		public virtual CE[] getChargeCode()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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