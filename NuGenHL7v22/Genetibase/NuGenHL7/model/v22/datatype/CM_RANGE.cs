using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>The HL7 CM_RANGE (Wertebereich) data type.  Consists of the following components: </p><ol>
	/// <li>Low Value (CE)</li>
	/// <li>High Value (CE)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CM_RANGE:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Low Value (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE LowValue
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns High Value (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE HighValue
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CM_RANGE.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CM_RANGE(Message message):base(message)
		{
			data = new Type[2];
			data[0] = new CE(message);
			data[1] = new CE(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_RANGE composite");
			}
		}
	}
}