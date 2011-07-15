using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 ERQ message segment. 
	/// This segment has the following fields:</p><p>
	/// ERQ-1: Query Tag (ST)<br> 
	/// ERQ-2: Event Identifier (CE)<br> 
	/// ERQ-3: Input Parameter List (QIP)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ERQ:AbstractSegment
	{
		/// <summary> Returns Query Tag (ERQ-1).</summary>
		virtual public ST QueryTag
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
		/// <summary> Returns Event Identifier (ERQ-2).</summary>
		virtual public CE EventIdentifier
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
		
		/// <summary> Creates a ERQ (ERQ - event replay query segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ERQ(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 32, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(QIP), false, 0, 256, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Input Parameter List (ERQ-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual QIP getInputParameterList(int rep)
		{
			QIP ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (QIP) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Input Parameter List (ERQ-3).</summary>
		public virtual QIP[] getInputParameterList()
		{
			QIP[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new QIP[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (QIP) t[i];
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