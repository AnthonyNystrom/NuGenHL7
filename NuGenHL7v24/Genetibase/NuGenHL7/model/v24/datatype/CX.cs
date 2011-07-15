using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v24.datatype
{
	
	/// <summary> <p>The HL7 CX (extended composite ID with check digit) data type.  Consists of the following components: </p><ol>
	/// <li>ID (ST)</li>
	/// <li>check digit (ST) (ST)</li>
	/// <li>code identifying the check digit scheme employed (ID)</li>
	/// <li>assigning authority (HD)</li>
	/// <li>identifier type code (ID) (ID)</li>
	/// <li>assigning facility (HD)</li>
	/// <li>effective date (DT) (DT)</li>
	/// <li>expiration date (DT)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CX:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns ID (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ID
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
		/// <summary> Returns check digit (ST) (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST CheckDigit
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
		/// <summary> Returns code identifying the check digit scheme employed (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CodeIdentifyingTheCheckDigitSchemeEmployed
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
		/// <summary> Returns assigning authority (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD AssigningAuthority
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
		/// <summary> Returns identifier type code (ID) (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID IdentifierTypeCode
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
		/// <summary> Returns assigning facility (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD AssigningFacility
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
		/// <summary> Returns effective date (DT) (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT EffectiveDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns expiration date (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT ExpirationDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CX.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CX(Message message):base(message)
		{
			data = new Type[8];
			data[0] = new ST(message);
			data[1] = new ST(message);
			data[2] = new ID(message, 0);
			data[3] = new HD(message);
			data[4] = new ID(message, 203);
			data[5] = new HD(message);
			data[6] = new DT(message);
			data[7] = new DT(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 8 element CX composite");
			}
		}
	}
}