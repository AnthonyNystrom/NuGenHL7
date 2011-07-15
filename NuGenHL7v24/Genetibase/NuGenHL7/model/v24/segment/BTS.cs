using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 BTS message segment. 
	/// This segment has the following fields:</p><p>
	/// BTS-1: Batch Message Count (ST)<br> 
	/// BTS-2: Batch Comment (ST)<br> 
	/// BTS-3: Batch Totals (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class BTS:AbstractSegment
	{
		/// <summary> Returns Batch Message Count (BTS-1).</summary>
		virtual public ST BatchMessageCount
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Batch Comment (BTS-2).</summary>
		virtual public ST BatchComment
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
		
		/// <summary> Creates a BTS (Batch Trailer) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public BTS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 10, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(NM), false, 0, 100, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Batch Totals (BTS-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getBatchTotals(int rep)
		{
			NM ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (NM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Batch Totals (BTS-3).</summary>
		public virtual NM[] getBatchTotals()
		{
			NM[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new NM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NM) t[i];
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