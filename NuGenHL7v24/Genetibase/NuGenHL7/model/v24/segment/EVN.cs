using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 EVN message segment. 
	/// This segment has the following fields:</p><p>
	/// EVN-1: Event Type Code (ID)<br> 
	/// EVN-2: Recorded Date/Time (TS)<br> 
	/// EVN-3: Date/Time Planned Event (TS)<br> 
	/// EVN-4: Event Reason Code (IS)<br> 
	/// EVN-5: Operator ID (XCN)<br> 
	/// EVN-6: Event Occurred (TS)<br> 
	/// EVN-7: Event Facility (HD)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class EVN:AbstractSegment
	{
		/// <summary> Returns Event Type Code (EVN-1).</summary>
		virtual public ID EventTypeCode
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
		/// <summary> Returns Recorded Date/Time (EVN-2).</summary>
		virtual public TS RecordedDateTime
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
		/// <summary> Returns Date/Time Planned Event (EVN-3).</summary>
		virtual public TS DateTimePlannedEvent
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
		/// <summary> Returns Event Reason Code (EVN-4).</summary>
		virtual public IS EventReasonCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Event Occurred (EVN-6).</summary>
		virtual public TS EventOccurred
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Event Facility (EVN-7).</summary>
		virtual public HD EventFacility
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (HD) t;
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
		
		/// <summary> Creates a EVN (Event Type) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public EVN(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 3});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 62});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 180, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Operator ID (EVN-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getOperatorID(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Operator ID (EVN-5).</summary>
		public virtual XCN[] getOperatorID()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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