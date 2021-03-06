using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v24.datatype
{
	
	/// <summary> <p>The HL7 CCD (charge time) data type.  Consists of the following components: </p><ol>
	/// <li>when to charge code (ID)</li>
	/// <li>date/time (TS)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CCD:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns when to charge code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID WhenToChargeCode
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
		/// <summary> Returns date/time (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS DateTime
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
		
		private Type[] data;
		
		/// <summary> Creates a CCD.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CCD(Message message):base(message)
		{
			data = new Type[2];
			data[0] = new ID(message, 0);
			data[1] = new TS(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 2 element CCD composite");
			}
		}
	}
}