using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 CF (coded element with formatted values) data type.  Consists of the following components: </p><ol>
	/// <li>identifier (ST)</li>
	/// <li>formatted text (FT)</li>
	/// <li>name of coding system (ST)</li>
	/// <li>alternate identifier (ST)</li>
	/// <li>alternate formatted text (FT)</li>
	/// <li>name of alternate coding system (ST)</li>
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
		/// <summary> Returns identifier (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST Identifier
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
		virtual public ST NameOfCodingSystem
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
		/// <summary> Returns alternate identifier (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST AlternateIdentifier
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
		virtual public ST NameOfAlternateCodingSystem
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(5);
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
			data[0] = new ST(message);
			data[1] = new FT(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new FT(message);
			data[5] = new ST(message);
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