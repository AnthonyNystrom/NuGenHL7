using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 DSP message segment. 
	/// This segment has the following fields:</p><p>
	/// DSP-1: Set ID - DSP (SI)<br> 
	/// DSP-2: Display Level (SI)<br> 
	/// DSP-3: Data Line (TX)<br> 
	/// DSP-4: Logical Break Point (ST)<br> 
	/// DSP-5: Result ID (TX)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class DSP:AbstractSegment
	{
		/// <summary> Returns Set ID - DSP (DSP-1).</summary>
		virtual public SI SetIDDSP
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI) t;
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
		/// <summary> Returns Display Level (DSP-2).</summary>
		virtual public SI DisplayLevel
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (SI) t;
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
		/// <summary> Returns Data Line (DSP-3).</summary>
		virtual public TX DataLine
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (TX) t;
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
		/// <summary> Returns Logical Break Point (DSP-4).</summary>
		virtual public ST LogicalBreakPoint
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
		/// <summary> Returns Result ID (DSP-5).</summary>
		virtual public TX ResultID
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (TX) t;
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
		
		/// <summary> Creates a DSP (DSP - display data segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public DSP(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(TX), true, 1, 300, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}