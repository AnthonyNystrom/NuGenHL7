using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>The HL7 CM_RFR (reference range) data type.  Consists of the following components: </p><ol>
	/// <li>Reference Range (CM_RANGE)</li>
	/// <li>Sex (ID)</li>
	/// <li>Age Range (CM_RANGE)</li>
	/// <li>Gestational Age Range (CM_RANGE)</li>
	/// <li>Species (ST)</li>
	/// <li>Race / Subspecies (ID)</li>
	/// <li>Text Condition (ST)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CM_RFR:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Reference Range (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CM_RANGE ReferenceRange
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
		/// <summary> Returns Sex (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID Sex
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
		/// <summary> Returns Age Range (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CM_RANGE AgeRange
		{
			get
			{
				CM_RANGE ret = null;
				try
				{
					ret = (CM_RANGE) getComponent(2);
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
		virtual public CM_RANGE GestationalAgeRange
		{
			get
			{
				CM_RANGE ret = null;
				try
				{
					ret = (CM_RANGE) getComponent(3);
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
		/// <summary> Returns Race / Subspecies (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID RaceSubspecies
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Text Condition (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST TextCondition
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CM_RFR.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CM_RFR(Message message):base(message)
		{
			data = new Type[7];
			data[0] = new CM_RANGE(message);
			data[1] = new ID(message, 0);
			data[2] = new CM_RANGE(message);
			data[3] = new CM_RANGE(message);
			data[4] = new ST(message);
			data[5] = new ID(message, 0);
			data[6] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 7 element CM_RFR composite");
			}
		}
	}
}