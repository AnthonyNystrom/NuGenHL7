using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v22.datatype
{
	
	/// <summary> <p>The HL7 CM_FINANCE (CM f�r Finanzen) data type.  Consists of the following components: </p><ol>
	/// <li>financial class ID (ID)</li>
	/// <li>effective date (TS)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CM_FINANCE:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns financial class ID (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID FinancialClassID
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
		/// <summary> Returns effective date (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS EffectiveDate
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CM_FINANCE.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CM_FINANCE(Message message):base(message)
		{
			data = new Type[2];
			data[0] = new ID(message, 0);
			data[1] = new TS(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_FINANCE composite");
			}
		}
	}
}