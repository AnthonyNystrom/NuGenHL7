using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 EVN message segment. 
	/// This segment has the following fields:</p><p>
	/// EVN-1: EVENT TYPE CODE (ID)<br> 
	/// EVN-2: DATE/TIME OF EVENT (TS)<br> 
	/// EVN-3: DATE/TIME PLANNED EVENT (TS)<br> 
	/// EVN-4: EVENT REASON CODE (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class EVN:AbstractSegment
	{
		/// <summary> Returns EVENT TYPE CODE (EVN-1).</summary>
		virtual public ID EVENTTYPECODE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns DATE/TIME OF EVENT (EVN-2).</summary>
		virtual public TS DATETIMEOFEVENT
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (TS) t;
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
		/// <summary> Returns DATE/TIME PLANNED EVENT (EVN-3).</summary>
		virtual public TS DATETIMEPLANNEDEVENT
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (TS) t;
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
		/// <summary> Returns EVENT REASON CODE (EVN-4).</summary>
		virtual public ID EVENTREASONCODE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		
		/// <summary> Creates a EVN (EVENT TYPE) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public EVN(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 3, new System.Object[]{message, 3});
				this.add(typeof(TS), true, 1, 19, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 62});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}