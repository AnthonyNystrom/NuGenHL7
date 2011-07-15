using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 XON (extended composite name and identification number for organizations) data type.  Consists of the following components: </p><ol>
	/// <li>organization name (ST)</li>
	/// <li>organization name type code (IS)</li>
	/// <li>ID number (NM) (NM)</li>
	/// <li>check digit (ST)</li>
	/// <li>code identifying the check digit scheme employed (ID)</li>
	/// <li>assigning authority (HD)</li>
	/// <li>identifier type code (IS)</li>
	/// <li>assigning facility ID (HD)</li>
	/// <li>Name Representation code (ID)</li>
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
		/// <summary> Returns organization name (component #0).  This is a convenience method that saves you from 
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
		/// <summary> Returns organization name type code (component #1).  This is a convenience method that saves you from 
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
		/// <summary> Returns ID number (NM) (component #2).  This is a convenience method that saves you from 
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
		/// <summary> Returns check digit (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST CheckDigit
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
		/// <summary> Returns code identifying the check digit scheme employed (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CodeIdentifyingTheCheckDigitSchemeEmployed
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
		/// <summary> Returns assigning authority (component #5).  This is a convenience method that saves you from 
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
		/// <summary> Returns identifier type code (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS IdentifierTypeCode
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
		/// <summary> Returns assigning facility ID (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD AssigningFacilityID
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
		/// <summary> Returns Name Representation code (component #8).  This is a convenience method that saves you from 
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
		
		private Type[] data;
		
		/// <summary> Creates a XON.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public XON(Message message):base(message)
		{
			data = new Type[9];
			data[0] = new ST(message);
			data[1] = new IS(message, 0);
			data[2] = new NM(message);
			data[3] = new ST(message);
			data[4] = new ID(message, 0);
			data[5] = new HD(message);
			data[6] = new IS(message, 0);
			data[7] = new HD(message);
			data[8] = new ID(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 9 element XON composite");
			}
		}
	}
}