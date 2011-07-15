using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 XAD (extended address) data type.  Consists of the following components: </p><ol>
	/// <li>street address (ST)</li>
	/// <li>other designation (ST)</li>
	/// <li>city (ST)</li>
	/// <li>state or province (ST)</li>
	/// <li>zip or postal code (ST)</li>
	/// <li>country (ID)</li>
	/// <li>address type (ID)</li>
	/// <li>other geographic designation (ST)</li>
	/// <li>county/parish code (IS)</li>
	/// <li>census tract (IS)</li>
	/// <li>address representation code (ID)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class XAD:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns street address (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST StreetAddress
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
		/// <summary> Returns other designation (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST OtherDesignation
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
		/// <summary> Returns city (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST City
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
		/// <summary> Returns state or province (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST StateOrProvince
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
		/// <summary> Returns zip or postal code (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ZipOrPostalCode
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
		/// <summary> Returns country (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID Country
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
		/// <summary> Returns address type (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID AddressType
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns other geographic designation (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST OtherGeographicDesignation
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns county/parish code (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS CountyParishCode
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns census tract (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS CensusTract
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(9);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns address representation code (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID AddressRepresentationCode
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(10);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a XAD.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public XAD(Message message):base(message)
		{
			data = new Type[11];
			data[0] = new ST(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ID(message, 0);
			data[6] = new ID(message, 0);
			data[7] = new ST(message);
			data[8] = new IS(message, 0);
			data[9] = new IS(message, 0);
			data[10] = new ID(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 11 element XAD composite");
			}
		}
	}
}