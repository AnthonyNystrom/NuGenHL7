using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 VTQ message segment. 
	/// This segment has the following fields:</p><p>
	/// VTQ-1: Query Tag (ST)<br> 
	/// VTQ-2: Query/ Response Format Code (ID)<br> 
	/// VTQ-3: VT Query Name (CE)<br> 
	/// VTQ-4: Virtual Table Name (CE)<br> 
	/// VTQ-5: Selection Criteria (QSC)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class VTQ:AbstractSegment
	{
		/// <summary> Returns Query Tag (VTQ-1).</summary>
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
		/// <summary> Returns Query/ Response Format Code (VTQ-2).</summary>
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
		/// <summary> Returns VT Query Name (VTQ-3).</summary>
		virtual public CE VTQueryName
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
		/// <summary> Returns Virtual Table Name (VTQ-4).</summary>
		virtual public CE VirtualTableName
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		
		/// <summary> Creates a VTQ (VTQ - virtual table query request segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public VTQ(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 32, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 106});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(QSC), false, 0, 256, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Selection Criteria (VTQ-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual QSC getSelectionCriteria(int rep)
		{
			QSC ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (QSC) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Selection Criteria (VTQ-5).</summary>
		public virtual QSC[] getSelectionCriteria()
		{
			QSC[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new QSC[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (QSC) t[i];
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