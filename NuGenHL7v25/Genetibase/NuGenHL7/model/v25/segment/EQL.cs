using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 EQL message segment. 
	/// This segment has the following fields:</p><p>
	/// EQL-1: Query Tag (ST)<br> 
	/// EQL-2: Query/Response Format Code (ID)<br> 
	/// EQL-3: EQL Query Name (CE)<br> 
	/// EQL-4: EQL Query Statement (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class EQL:AbstractSegment
	{
		/// <summary> Returns Query Tag (EQL-1).</summary>
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
		/// <summary> Returns Query/Response Format Code (EQL-2).</summary>
		virtual public ID QueryResponseFormatCode
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
		/// <summary> Returns EQL Query Name (EQL-3).</summary>
		virtual public CE EQLQueryName
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns EQL Query Statement (EQL-4).</summary>
		virtual public ST EQLQueryStatement
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		
		/// <summary> Creates a EQL (Embedded Query Language) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public EQL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 32, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 106});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 4096, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}