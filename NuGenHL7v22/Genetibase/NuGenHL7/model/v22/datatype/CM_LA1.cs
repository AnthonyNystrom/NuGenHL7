using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>The HL7 CM_LA1 (Location with address information) data type.  Consists of the following components: </p><ol>
	/// <li>Dispense / Deliver to Location (CM_INTERNAL_LOCATION)</li>
	/// <li>location (AD)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CM_LA1:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Dispense / Deliver to Location (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CM_INTERNAL_LOCATION DispenseDeliverToLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					ret = (CM_INTERNAL_LOCATION) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns location (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public AD Location
		{
			get
			{
				AD ret = null;
				try
				{
					ret = (AD) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CM_LA1.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CM_LA1(Message message):base(message)
		{
			data = new Type[2];
			data[0] = new CM_INTERNAL_LOCATION(message);
			data[1] = new AD(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_LA1 composite");
			}
		}
	}
}