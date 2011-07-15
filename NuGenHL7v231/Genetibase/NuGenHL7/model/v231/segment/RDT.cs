using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 RDT message segment. 
	/// This segment has the following fields:</p><p>
	/// RDT-1: Column Value (varies)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RDT:AbstractSegment
	{
		/// <summary> Returns Column Value (RDT-1).</summary>
		virtual public Varies ColumnValue
		{
			get
			{
				Varies ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		
		/// <summary> Creates a RDT (RDT - table row data segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RDT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(Varies), false, 1, 0, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}