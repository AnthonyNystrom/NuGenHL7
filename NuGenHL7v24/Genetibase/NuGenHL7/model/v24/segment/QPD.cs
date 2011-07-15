using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 QPD message segment. 
	/// This segment has the following fields:</p><p>
	/// QPD-1: Message Query Name (CE)<br> 
	/// QPD-2: Query Tag (ST)<br> 
	/// QPD-3: User Parameters (in successive fields) (varies)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class QPD:AbstractSegment
	{
		/// <summary> Returns Message Query Name (QPD-1).</summary>
		virtual public CE MessageQueryName
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
		/// <summary> Returns Query Tag (QPD-2).</summary>
		virtual public ST QueryTag
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
		/// <summary> Returns User Parameters (in successive fields) (QPD-3).</summary>
		virtual public Varies UserParametersInsuccessivefields
		{
			get
			{
				Varies ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (Varies) t;
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
		
		/// <summary> Creates a QPD (Query Parameter Definition) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public QPD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 32, new System.Object[]{message});
				this.add(typeof(Varies), false, 1, 256, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}