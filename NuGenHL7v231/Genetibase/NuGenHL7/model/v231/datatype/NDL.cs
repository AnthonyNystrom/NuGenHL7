using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 NDL (observing practitioner) data type.  Consists of the following components: </p><ol>
	/// <li>OP name (CN)</li>
	/// <li>start date/time (TS)</li>
	/// <li>end date/time (TS)</li>
	/// <li>point of care (IS) (IS)</li>
	/// <li>room (IS)</li>
	/// <li>bed (IS)</li>
	/// <li>facility (HD) (HD)</li>
	/// <li>location status (IS)</li>
	/// <li>person location type (IS)</li>
	/// <li>building (IS)</li>
	/// <li>floor (IS)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class NDL:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns OP name (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CN OPName
		{
			get
			{
				CN ret = null;
				try
				{
					ret = (CN) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns start date/time (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS StartDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns end date/time (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS EndDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns point of care (IS) (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PointOfCare
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns room (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Room
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns bed (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Bed
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
		/// <summary> Returns facility (HD) (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD Facility
		{
			get
			{
				HD ret = null;
				try
				{
					ret = (HD) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns location status (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS LocationStatus
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns person location type (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PersonLocationType
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns building (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Building
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
		/// <summary> Returns floor (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Floor
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(10);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a NDL.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public NDL(Message message):base(message)
		{
			data = new Type[11];
			data[0] = new CN(message);
			data[1] = new TS(message);
			data[2] = new TS(message);
			data[3] = new IS(message, 0);
			data[4] = new IS(message, 0);
			data[5] = new IS(message, 0);
			data[6] = new HD(message);
			data[7] = new IS(message, 0);
			data[8] = new IS(message, 0);
			data[9] = new IS(message, 0);
			data[10] = new IS(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 11 element NDL composite");
			}
		}
	}
}