using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 PRL (Parent Result Link) data type.  Consists of the following components: </p><ol>
	/// <li>Parent Observation Identifier (CE)</li>
	/// <li>Parent Observation Sub-identifier (ST)</li>
	/// <li>Parent Observation Value Descriptor (TX)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class PRL:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Parent Observation Identifier (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE ParentObservationIdentifier
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
		/// <summary> Returns Parent Observation Sub-identifier (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ParentObservationSubIdentifier
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
		/// <summary> Returns Parent Observation Value Descriptor (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TX ParentObservationValueDescriptor
		{
			get
			{
				TX ret = null;
				try
				{
					ret = (TX) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a PRL.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public PRL(Message message):base(message)
		{
			data = new Type[3];
			data[0] = new CE(message);
			data[1] = new ST(message);
			data[2] = new TX(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 3 element PRL composite");
			}
		}
	}
}