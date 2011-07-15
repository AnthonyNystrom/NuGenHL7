using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 XON (Extended Composite Name and Identification Number for Organizations) data type.  Consists of the following components: </p><ol>
	/// <li>Organization Name (ST)</li>
	/// <li>Organization Name Type Code (IS)</li>
	/// <li>ID Number (NM)</li>
	/// <li>Check Digit (NM)</li>
	/// <li>Check Digit Scheme (ID)</li>
	/// <li>Assigning Authority (HD)</li>
	/// <li>Identifier Type Code (ID)</li>
	/// <li>Assigning Facility (HD)</li>
	/// <li>Name Representation Code (ID)</li>
	/// <li>Organization Identifier (ST)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class XON:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Organization Name (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST OrganizationName
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
		/// <summary> Returns Organization Name Type Code (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS OrganizationNameTypeCode
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
		/// <summary> Returns ID Number (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM IDNumber
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Check Digit (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM CheckDigit
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Check Digit Scheme (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CheckDigitScheme
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Assigning Authority (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD AssigningAuthority
		{
			get
			{
				HD ret = null;
				try
				{
					ret = (HD) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Identifier Type Code (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID IdentifierTypeCode
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
		/// <summary> Returns Assigning Facility (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD AssigningFacility
		{
			get
			{
				HD ret = null;
				try
				{
					ret = (HD) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Name Representation Code (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID NameRepresentationCode
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Organization Identifier (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST OrganizationIdentifier
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
		
		private Type[] data;
		
		/// <summary> Creates a XON.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public XON(Message message):base(message)
		{
			data = new Type[10];
			data[0] = new ST(message);
			data[1] = new IS(message, 204);
			data[2] = new NM(message);
			data[3] = new NM(message);
			data[4] = new ID(message, 61);
			data[5] = new HD(message);
			data[6] = new ID(message, 203);
			data[7] = new HD(message);
			data[8] = new ID(message, 465);
			data[9] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 10 element XON composite");
			}
		}
	}
}