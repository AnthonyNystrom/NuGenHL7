using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 PTA (Policy Type and Amount) data type.  Consists of the following components: </p><ol>
	/// <li>Policy Type (IS)</li>
	/// <li>Amount Class (IS)</li>
	/// <li>Money or Percentage Quantity (NM)</li>
	/// <li>Money or Percentage (MOP)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class PTA:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Policy Type (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PolicyType
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
		/// <summary> Returns Amount Class (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS AmountClass
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
		/// <summary> Returns Money or Percentage Quantity (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM MoneyOrPercentageQuantity
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
		/// <summary> Returns Money or Percentage (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public MOP MoneyOrPercentage
		{
			get
			{
				MOP ret = null;
				try
				{
					ret = (MOP) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a PTA.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public PTA(Message message):base(message)
		{
			data = new Type[4];
			data[0] = new IS(message, 147);
			data[1] = new IS(message, 193);
			data[2] = new NM(message);
			data[3] = new MOP(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element PTA composite");
			}
		}
	}
}