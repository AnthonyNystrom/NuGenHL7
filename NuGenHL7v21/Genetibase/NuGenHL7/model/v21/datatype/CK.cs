using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v21.datatype
{
	
	/// <summary> <p>The HL7 CK (composite ID with check digit) data type.  Consists of the following components: </p><ol>
	/// <li>ID number (NM)</li>
	/// <li>check digit (NM)</li>
	/// <li>code identifying check digit scheme employed (ID)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CK:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns ID number (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM IDNumber
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns check digit (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM CheckDigit
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns code identifying check digit scheme employed (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CodeIdentifyingCheckDigitSchemeEmployed
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
		
		private Type[] data;
		
		/// <summary> Creates a CK.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CK(Message message):base(message)
		{
			data = new Type[3];
			data[0] = new NM(message);
			data[1] = new NM(message);
			data[2] = new ID(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 3 element CK composite");
			}
		}
	}
}