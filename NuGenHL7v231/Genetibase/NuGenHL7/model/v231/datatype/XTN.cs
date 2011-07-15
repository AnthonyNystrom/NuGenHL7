using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 XTN (extended telecommunication number) data type.  Consists of the following components: </p><ol>
	/// <li>[(999)] 999-9999 [X99999][C any text] (TN)</li>
	/// <li>telecommunication use code (ID)</li>
	/// <li>telecommunication equipment type (ID) (ID)</li>
	/// <li>Email address (ST)</li>
	/// <li>Country Code (NM)</li>
	/// <li>Area/city code (NM)</li>
	/// <li>Phone number (NM)</li>
	/// <li>Extension (NM)</li>
	/// <li>any text (ST)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class XTN:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns telecommunication use code (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID TelecommunicationUseCode
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
		/// <summary> Returns telecommunication equipment type (ID) (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID TelecommunicationEquipmentType
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Email address (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST EmailAddress
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Country Code (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM CountryCode
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Area/city code (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM AreaCityCode
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Phone number (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM PhoneNumber
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Extension (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM Extension
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns any text (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST AnyText
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a XTN.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public XTN(Message message):base(message)
		{
			data = new Type[9];
			data[0] = new TN(message);
			data[1] = new ID(message, 0);
			data[2] = new ID(message, 0);
			data[3] = new ST(message);
			data[4] = new NM(message);
			data[5] = new NM(message);
			data[6] = new NM(message);
			data[7] = new NM(message);
			data[8] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 9 element XTN composite");
			}
		}
		/// <summary> Returns [(999)] 999-9999 [X99999][C any text] (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		public virtual TN get9999999X99999CAnyText()
		{
			TN ret = null;
			try
			{
				ret = (TN) getComponent(0);
			}
			catch (DataTypeException)
			{
				throw new Exception();
			}
			return ret;
		}
	}
}