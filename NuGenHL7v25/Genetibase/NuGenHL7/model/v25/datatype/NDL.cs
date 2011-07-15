using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 NDL (Name with Date and Location) data type.  Consists of the following components: </p><ol>
	/// <li>Name Of Person (CNN)</li>
	/// <li>Start Date/time (TS)</li>
	/// <li>End Date/time (TS)</li>
	/// <li>Point of Care (IS)</li>
	/// <li>Room (IS)</li>
	/// <li>Bed (IS)</li>
	/// <li>Facility (HD)</li>
	/// <li>Location Status (IS)</li>
	/// <li>Patient Location Type (IS)</li>
	/// <li>Building (IS)</li>
	/// <li>Floor (IS)</li>
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
		/// <summary> Returns Name Of Person (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CNN NameOfPerson
		{
			get
			{
				CNN ret = null;
				try
				{
					ret = (CNN) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Start Date/time (component #1).  This is a convenience method that saves you from 
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
		/// <summary> Returns End Date/time (component #2).  This is a convenience method that saves you from 
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
		/// <summary> Returns Point of Care (component #3).  This is a convenience method that saves you from 
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
		/// <summary> Returns Room (component #4).  This is a convenience method that saves you from 
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
		/// <summary> Returns Bed (component #5).  This is a convenience method that saves you from 
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
		/// <summary> Returns Facility (component #6).  This is a convenience method that saves you from 
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
		/// <summary> Returns Location Status (component #7).  This is a convenience method that saves you from 
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
		/// <summary> Returns Patient Location Type (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PatientLocationType
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
		/// <summary> Returns Building (component #9).  This is a convenience method that saves you from 
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
		/// <summary> Returns Floor (component #10).  This is a convenience method that saves you from 
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
			data[0] = new CNN(message);
			data[1] = new TS(message);
			data[2] = new TS(message);
			data[3] = new IS(message, 302);
			data[4] = new IS(message, 303);
			data[5] = new IS(message, 304);
			data[6] = new HD(message);
			data[7] = new IS(message, 306);
			data[8] = new IS(message, 305);
			data[9] = new IS(message, 307);
			data[10] = new IS(message, 308);
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