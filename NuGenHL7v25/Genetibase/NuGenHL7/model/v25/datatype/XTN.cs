using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 XTN (Extended Telecommunication Number) data type.  Consists of the following components: </p><ol>
	/// <li>Telephone Number (ST)</li>
	/// <li>Telecommunication Use Code (ID)</li>
	/// <li>Telecommunication Equipment Type (ID)</li>
	/// <li>Email Address (ST)</li>
	/// <li>Country Code (NM)</li>
	/// <li>Area/City Code (NM)</li>
	/// <li>Local Number (NM)</li>
	/// <li>Extension (NM)</li>
	/// <li>Any Text (ST)</li>
	/// <li>Extension Prefix (ST)</li>
	/// <li>Speed Dial Code (ST)</li>
	/// <li>Unformatted Telephone number (ST)</li>
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
		/// <summary> Returns Telephone Number (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST TelephoneNumber
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
		/// <summary> Returns Telecommunication Use Code (component #1).  This is a convenience method that saves you from 
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
		/// <summary> Returns Telecommunication Equipment Type (component #2).  This is a convenience method that saves you from 
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
		/// <summary> Returns Email Address (component #3).  This is a convenience method that saves you from 
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
		/// <summary> Returns Area/City Code (component #5).  This is a convenience method that saves you from 
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
		/// <summary> Returns Local Number (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM LocalNumber
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
		/// <summary> Returns Any Text (component #8).  This is a convenience method that saves you from 
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
		/// <summary> Returns Extension Prefix (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ExtensionPrefix
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(9);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Speed Dial Code (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SpeedDialCode
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(10);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Unformatted Telephone number (component #11).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST UnformattedTelephoneNumber
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(11);
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
			data = new Type[12];
			data[0] = new ST(message);
			data[1] = new ID(message, 201);
			data[2] = new ID(message, 202);
			data[3] = new ST(message);
			data[4] = new NM(message);
			data[5] = new NM(message);
			data[6] = new NM(message);
			data[7] = new NM(message);
			data[8] = new ST(message);
			data[9] = new ST(message);
			data[10] = new ST(message);
			data[11] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 12 element XTN composite");
			}
		}
	}
}