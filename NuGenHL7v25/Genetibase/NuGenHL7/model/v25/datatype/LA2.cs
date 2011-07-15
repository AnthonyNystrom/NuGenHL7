using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 LA2 (Location with Address Variation 2) data type.  Consists of the following components: </p><ol>
	/// <li>Point of Care (IS)</li>
	/// <li>Room (IS)</li>
	/// <li>Bed (IS)</li>
	/// <li>Facility (HD)</li>
	/// <li>Location Status (IS)</li>
	/// <li>Patient Location Type (IS)</li>
	/// <li>Building (IS)</li>
	/// <li>Floor (IS)</li>
	/// <li>Street Address (ST)</li>
	/// <li>Other Designation (ST)</li>
	/// <li>City (ST)</li>
	/// <li>State or Province (ST)</li>
	/// <li>Zip or Postal Code (ST)</li>
	/// <li>Country (ID)</li>
	/// <li>Address Type (ID)</li>
	/// <li>Other Geographic Designation (ST)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class LA2:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Point of Care (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PointOfCare
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Room (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Room
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
		/// <summary> Returns Bed (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Bed
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Facility (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD Facility
		{
			get
			{
				HD ret = null;
				try
				{
					ret = (HD) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Location Status (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS LocationStatus
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Patient Location Type (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PatientLocationType
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Building (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Building
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Floor (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS Floor
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Street Address (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST StreetAddress
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
		/// <summary> Returns Other Designation (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST OtherDesignation
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
		/// <summary> Returns City (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST City
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
		/// <summary> Returns State or Province (component #11).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST StateOrProvince
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
		/// <summary> Returns Zip or Postal Code (component #12).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ZipOrPostalCode
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(12);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Country (component #13).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID Country
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(13);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Address Type (component #14).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID AddressType
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(14);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Other Geographic Designation (component #15).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST OtherGeographicDesignation
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(15);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a LA2.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public LA2(Message message):base(message)
		{
			data = new Type[16];
			data[0] = new IS(message, 302);
			data[1] = new IS(message, 303);
			data[2] = new IS(message, 304);
			data[3] = new HD(message);
			data[4] = new IS(message, 306);
			data[5] = new IS(message, 305);
			data[6] = new IS(message, 307);
			data[7] = new IS(message, 308);
			data[8] = new ST(message);
			data[9] = new ST(message);
			data[10] = new ST(message);
			data[11] = new ST(message);
			data[12] = new ST(message);
			data[13] = new ID(message, 399);
			data[14] = new ID(message, 190);
			data[15] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 16 element LA2 composite");
			}
		}
	}
}