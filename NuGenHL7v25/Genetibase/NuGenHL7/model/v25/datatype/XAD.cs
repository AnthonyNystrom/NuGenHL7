using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 XAD (Extended Address) data type.  Consists of the following components: </p><ol>
	/// <li>Street Address (SAD)</li>
	/// <li>Other Designation (ST)</li>
	/// <li>City (ST)</li>
	/// <li>State or Province (ST)</li>
	/// <li>Zip or Postal Code (ST)</li>
	/// <li>Country (ID)</li>
	/// <li>Address Type (ID)</li>
	/// <li>Other Geographic Designation (ST)</li>
	/// <li>County/Parish Code (IS)</li>
	/// <li>Census Tract (IS)</li>
	/// <li>Address Representation Code (ID)</li>
	/// <li>Address Validity Range (DR)</li>
	/// <li>Effective Date (TS)</li>
	/// <li>Expiration Date (TS)</li>
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
		/// <summary> Returns Street Address (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public SAD StreetAddress
		{
			get
			{
				SAD ret = null;
				try
				{
					ret = (SAD) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Other Designation (component #1).  This is a convenience method that saves you from 
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
		/// <summary> Returns City (component #2).  This is a convenience method that saves you from 
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
		/// <summary> Returns State or Province (component #3).  This is a convenience method that saves you from 
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
		/// <summary> Returns Zip or Postal Code (component #4).  This is a convenience method that saves you from 
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
		/// <summary> Returns Country (component #5).  This is a convenience method that saves you from 
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
		/// <summary> Returns Address Type (component #6).  This is a convenience method that saves you from 
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
		/// <summary> Returns Other Geographic Designation (component #7).  This is a convenience method that saves you from 
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
		/// <summary> Returns County/Parish Code (component #8).  This is a convenience method that saves you from 
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
		/// <summary> Returns Census Tract (component #9).  This is a convenience method that saves you from 
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
		/// <summary> Returns Address Representation Code (component #10).  This is a convenience method that saves you from 
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
		/// <summary> Returns Address Validity Range (component #11).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DR AddressValidityRange
		{
			get
			{
				DR ret = null;
				try
				{
					ret = (DR) getComponent(11);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Effective Date (component #12).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS EffectiveDate
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(12);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Expiration Date (component #13).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS ExpirationDate
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(13);
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
			data = new Type[14];
			data[0] = new SAD(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ID(message, 399);
			data[6] = new ID(message, 190);
			data[7] = new ST(message);
			data[8] = new IS(message, 289);
			data[9] = new IS(message, 288);
			data[10] = new ID(message, 465);
			data[11] = new DR(message);
			data[12] = new TS(message);
			data[13] = new TS(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 14 element XAD composite");
			}
		}
	}
}