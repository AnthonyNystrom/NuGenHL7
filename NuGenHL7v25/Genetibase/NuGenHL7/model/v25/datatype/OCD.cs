using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 OCD (Occurrence Code and Date) data type.  Consists of the following components: </p><ol>
	/// <li>Occurrence Code (CNE)</li>
	/// <li>Occurrence Date (DT)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class OCD:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Occurrence Code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CNE OccurrenceCode
		{
			get
			{
				CNE ret = null;
				try
				{
					ret = (CNE) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Occurrence Date (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT OccurrenceDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a OCD.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public OCD(Message message):base(message)
		{
			data = new Type[2];
			data[0] = new CNE(message);
			data[1] = new DT(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 2 element OCD composite");
			}
		}
	}
}