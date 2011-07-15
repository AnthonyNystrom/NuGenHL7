using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 PLN (Practitioner License or Other ID Number) data type.  Consists of the following components: </p><ol>
	/// <li>ID Number (ST)</li>
	/// <li>Type of ID Number (IS)</li>
	/// <li>State/other Qualifying Information (ST)</li>
	/// <li>Expiration Date (DT)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class PLN:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns ID Number (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST IDNumber
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Type of ID Number (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS TypeOfIDNumber
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
		/// <summary> Returns State/other Qualifying Information (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST StateOtherQualifyingInformation
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Expiration Date (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT ExpirationDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a PLN.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public PLN(Message message):base(message)
		{
			data = new Type[4];
			data[0] = new ST(message);
			data[1] = new IS(message, 338);
			data[2] = new ST(message);
			data[3] = new DT(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element PLN composite");
			}
		}
	}
}