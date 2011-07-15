using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 RFR (Reference Range) data type.  Consists of the following components: </p><ol>
	/// <li>Numeric Range (NR)</li>
	/// <li>Administrative Sex (IS)</li>
	/// <li>Age Range (NR)</li>
	/// <li>Gestational Age Range (NR)</li>
	/// <li>Species (ST)</li>
	/// <li>Race/subspecies (ST)</li>
	/// <li>Conditions (TX)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class RFR:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Numeric Range (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NR NumericRange
		{
			get
			{
				NR ret = null;
				try
				{
					ret = (NR) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Administrative Sex (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS AdministrativeSex
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Age Range (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NR AgeRange
		{
			get
			{
				NR ret = null;
				try
				{
					ret = (NR) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Gestational Age Range (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NR GestationalAgeRange
		{
			get
			{
				NR ret = null;
				try
				{
					ret = (NR) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Species (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST Species
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Race/subspecies (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST RaceSubspecies
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Conditions (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TX Conditions
		{
			get
			{
				TX ret = null;
				try
				{
					ret = (TX) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a RFR.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public RFR(Message message):base(message)
		{
			data = new Type[7];
			data[0] = new NR(message);
			data[1] = new IS(message, 1);
			data[2] = new NR(message);
			data[3] = new NR(message);
			data[4] = new ST(message);
			data[5] = new ST(message);
			data[6] = new TX(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 7 element RFR composite");
			}
		}
	}
}