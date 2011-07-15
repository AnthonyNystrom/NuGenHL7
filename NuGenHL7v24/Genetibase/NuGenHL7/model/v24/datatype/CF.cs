using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v24.datatype
{
	
	/// <summary> <p>The HL7 CF (coded element with formatted values) data type.  Consists of the following components: </p><ol>
	/// <li>identifier (ID) (ID)</li>
	/// <li>formatted text (FT)</li>
	/// <li>name of coding system (IS)</li>
	/// <li>alternate identifier (ID) (ID)</li>
	/// <li>alternate formatted text (FT)</li>
	/// <li>name of alternate coding system (IS)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CF:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns identifier (ID) (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID Identifier
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns formatted text (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public FT FormattedText
		{
			get
			{
				FT ret = null;
				try
				{
					ret = (FT) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns name of coding system (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS NameOfCodingSystem
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
		/// <summary> Returns alternate identifier (ID) (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID AlternateIdentifier
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns alternate formatted text (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public FT AlternateFormattedText
		{
			get
			{
				FT ret = null;
				try
				{
					ret = (FT) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns name of alternate coding system (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS NameOfAlternateCodingSystem
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
		
		private Type[] data;
		
		/// <summary> Creates a CF.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CF(Message message):base(message)
		{
			data = new Type[6];
			data[0] = new ID(message, 0);
			data[1] = new FT(message);
			data[2] = new IS(message, 0);
			data[3] = new ID(message, 0);
			data[4] = new FT(message);
			data[5] = new IS(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 6 element CF composite");
			}
		}
	}
}