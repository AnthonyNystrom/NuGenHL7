using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>The HL7 CM_PARENT_RESULT (undefined CM data type) data type.  Consists of the following components: </p><ol>
	/// <li>observation identifier (OBX-3) of parent result (CE)</li>
	/// <li>sub-ID (OBX-4) of parent result (ST)</li>
	/// <li>result (OBX-5) from parent (CE)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CM_PARENT_RESULT:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns observation identifier (OBX-3) of parent result (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE ObservationIdentifierOBX3OfParentResult
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
		/// <summary> Returns sub-ID (OBX-4) of parent result (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SubIDOBX4OfParentResult
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns result (OBX-5) from parent (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE ResultOBX5FromParent
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CM_PARENT_RESULT.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CM_PARENT_RESULT(Message message):base(message)
		{
			data = new Type[3];
			data[0] = new CE(message);
			data[1] = new ST(message);
			data[2] = new CE(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_PARENT_RESULT composite");
			}
		}
	}
}