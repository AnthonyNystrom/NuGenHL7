using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 GP1 message segment. 
	/// This segment has the following fields:</p><p>
	/// GP1-1: Type of Bill Code (IS)<br> 
	/// GP1-2: Revenue Code (IS)<br> 
	/// GP1-3: Overall Claim Disposition Code (IS)<br> 
	/// GP1-4: OCE Edits per Visit Code (IS)<br> 
	/// GP1-5: Outlier Cost (CP)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class GP1:AbstractSegment
	{
		/// <summary> Returns Type of Bill Code (GP1-1).</summary>
		virtual public IS TypeOfBillCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (IS) t;
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
		/// <summary> Returns Overall Claim Disposition Code (GP1-3).</summary>
		virtual public IS OverallClaimDispositionCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (IS) t;
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
		/// <summary> Returns Outlier Cost (GP1-5).</summary>
		virtual public CP OutlierCost
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CP) t;
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
		
		/// <summary> Creates a GP1 (Grouping/Reimbursement - Visit) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public GP1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(IS), true, 1, 3, new System.Object[]{message, 455});
				this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 456});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 457});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 458});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Revenue Code (GP1-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getRevenueCode(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Revenue Code (GP1-2).</summary>
		public virtual IS[] getRevenueCode()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of OCE Edits per Visit Code (GP1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getOCEEditsPerVisitCode(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of OCE Edits per Visit Code (GP1-4).</summary>
		public virtual IS[] getOCEEditsPerVisitCode()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(4);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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