using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 VH (visiting hours) data type.  Consists of the following components: </p><ol>
	/// <li>start day range (ID)</li>
	/// <li>end day range (ID)</li>
	/// <li>start hour range (TM)</li>
	/// <li>end hour range (TM)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class VH:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns start day range (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID StartDayRange
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns end day range (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID EndDayRange
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
		/// <summary> Returns start hour range (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TM StartHourRange
		{
			get
			{
				TM ret = null;
				try
				{
					ret = (TM) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns end hour range (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TM EndHourRange
		{
			get
			{
				TM ret = null;
				try
				{
					ret = (TM) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a VH.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public VH(Message message):base(message)
		{
			data = new Type[4];
			data[0] = new ID(message, 0);
			data[1] = new ID(message, 0);
			data[2] = new TM(message);
			data[3] = new TM(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element VH composite");
			}
		}
	}
}