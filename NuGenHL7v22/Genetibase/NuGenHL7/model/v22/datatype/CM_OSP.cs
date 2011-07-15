using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>The HL7 CM_OSP (occurence span) data type.  Consists of the following components: </p><ol>
	/// <li>occurrence span code (ID)</li>
	/// <li>occurrence span start date (DT)</li>
	/// <li>occurrence span stop date (DT)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CM_OSP:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns occurrence span code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID OccurrenceSpanCode
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
		/// <summary> Returns occurrence span start date (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT OccurrenceSpanStartDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns occurrence span stop date (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT OccurrenceSpanStopDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CM_OSP.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CM_OSP(Message message):base(message)
		{
			data = new Type[3];
			data[0] = new ID(message, 0);
			data[1] = new DT(message);
			data[2] = new DT(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_OSP composite");
			}
		}
	}
}