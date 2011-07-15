using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>The HL7 CM_ABS_RANGE (absolute range) data type.  Consists of the following components: </p><ol>
	/// <li>Range (CM_RANGE)</li>
	/// <li>Numeric Change (NM)</li>
	/// <li>Percent per Change (NM)</li>
	/// <li>Days (NM)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CM_ABS_RANGE:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Range (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CM_RANGE Range
		{
			get
			{
				CM_RANGE ret = null;
				try
				{
					ret = (CM_RANGE) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Numeric Change (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM NumericChange
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Percent per Change (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM PercentPerChange
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
		/// <summary> Returns Days (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM Days
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
		
		private Type[] data;
		
		/// <summary> Creates a CM_ABS_RANGE.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CM_ABS_RANGE(Message message):base(message)
		{
			data = new Type[4];
			data[0] = new CM_RANGE(message);
			data[1] = new NM(message);
			data[2] = new NM(message);
			data[3] = new NM(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element CM_ABS_RANGE composite");
			}
		}
	}
}