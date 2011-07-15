using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 AIS message segment. 
	/// This segment has the following fields:</p><p>
	/// AIS-1: Set ID - AIS (SI)<br> 
	/// AIS-2: Segment Action Code (ID)<br> 
	/// AIS-3: Universal Service ID (CE)<br> 
	/// AIS-4: Start Date/Time (TS)<br> 
	/// AIS-5: Start Date/Time Offset (NM)<br> 
	/// AIS-6: Start Date/Time Offset Units (CE)<br> 
	/// AIS-7: Duration (NM)<br> 
	/// AIS-8: Duration Units (CE)<br> 
	/// AIS-9: Allow Substitution Code (IS)<br> 
	/// AIS-10: Filler Status Code (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class AIS:AbstractSegment
	{
		/// <summary> Returns Set ID - AIS (AIS-1).</summary>
		virtual public SI SetIDAIS
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
		/// <summary> Returns Segment Action Code (AIS-2).</summary>
		virtual public ID SegmentActionCode
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
		/// <summary> Returns Universal Service ID (AIS-3).</summary>
		virtual public CE UniversalServiceID
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
		/// <summary> Returns Start Date/Time (AIS-4).</summary>
		virtual public TS StartDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Start Date/Time Offset (AIS-5).</summary>
		virtual public NM StartDateTimeOffset
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (NM) t;
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
		/// <summary> Returns Start Date/Time Offset Units (AIS-6).</summary>
		virtual public CE StartDateTimeOffsetUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Duration (AIS-7).</summary>
		virtual public NM Duration
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (NM) t;
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
		/// <summary> Returns Duration Units (AIS-8).</summary>
		virtual public CE DurationUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Allow Substitution Code (AIS-9).</summary>
		virtual public IS AllowSubstitutionCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Filler Status Code (AIS-10).</summary>
		virtual public CE FillerStatusCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		
		/// <summary> Creates a AIS (AIS - appointment information - service segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public AIS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 206});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 10, new System.Object[]{message, 279});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}