using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 EIP (Entity Identifier Pair) data type.  Consists of the following components: </p><ol>
	/// <li>Placer Assigned Identifier (EI)</li>
	/// <li>Filler Assigned Identifier (EI)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class EIP:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Placer Assigned Identifier (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public EI PlacerAssignedIdentifier
		{
			get
			{
				EI ret = null;
				try
				{
					ret = (EI) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Filler Assigned Identifier (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public EI FillerAssignedIdentifier
		{
			get
			{
				EI ret = null;
				try
				{
					ret = (EI) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a EIP.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public EIP(Message message):base(message)
		{
			data = new Type[2];
			data[0] = new EI(message);
			data[1] = new EI(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 2 element EIP composite");
			}
		}
	}
}