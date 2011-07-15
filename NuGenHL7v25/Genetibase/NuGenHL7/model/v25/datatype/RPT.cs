using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 RPT (Repeat Pattern) data type.  Consists of the following components: </p><ol>
	/// <li>Repeat Pattern Code (CWE)</li>
	/// <li>Calendar Alignment (ID)</li>
	/// <li>Phase Range Begin Value (NM)</li>
	/// <li>Phase Range End Value (NM)</li>
	/// <li>Period Quantity (NM)</li>
	/// <li>Period Units (IS)</li>
	/// <li>Institution Specified Time (ID)</li>
	/// <li>Event (ID)</li>
	/// <li>Event Offset Quantity (NM)</li>
	/// <li>Event Offset Units (IS)</li>
	/// <li>General Timing Specification (GTS)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class RPT:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Repeat Pattern Code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE RepeatPatternCode
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Calendar Alignment (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CalendarAlignment
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Phase Range Begin Value (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM PhaseRangeBeginValue
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Phase Range End Value (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM PhaseRangeEndValue
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Period Quantity (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM PeriodQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Period Units (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PeriodUnits
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Institution Specified Time (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID InstitutionSpecifiedTime
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Event (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID Event
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Event Offset Quantity (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM EventOffsetQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Event Offset Units (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS EventOffsetUnits
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(9);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns General Timing Specification (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public GTS GeneralTimingSpecification
		{
			get
			{
				GTS ret = null;
				try
				{
					ret = (GTS) getComponent(10);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a RPT.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public RPT(Message message):base(message)
		{
			data = new Type[11];
			data[0] = new CWE(message);
			data[1] = new ID(message, 527);
			data[2] = new NM(message);
			data[3] = new NM(message);
			data[4] = new NM(message);
			data[5] = new IS(message, 0);
			data[6] = new ID(message, 136);
			data[7] = new ID(message, 528);
			data[8] = new NM(message);
			data[9] = new IS(message, 0);
			data[10] = new GTS(message);
		}
		
		/// <summary> Returns an individual data component.</summary>
		/// <throws>  DataTypeException if the given element number is out of range. </throws>
		public virtual Type getComponent(int number)
		{
			
			try
			{
				return this.data[number];
			}
			catch (IndexOutOfRangeException)
			{
				throw new DataTypeException("Element " + number + " doesn't exist in 11 element RPT composite");
			}
		}
	}
}