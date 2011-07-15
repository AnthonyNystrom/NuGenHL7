using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 PIP (Practitioner Institutional Privileges) data type.  Consists of the following components: </p><ol>
	/// <li>Privilege (CE)</li>
	/// <li>Privilege Class (CE)</li>
	/// <li>Expiration Date (DT)</li>
	/// <li>Activation Date (DT)</li>
	/// <li>Facility (EI)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class PIP:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Privilege (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE Privilege
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Privilege Class (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE PrivilegeClass
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Expiration Date (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT ExpirationDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Activation Date (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DT ActivationDate
		{
			get
			{
				DT ret = null;
				try
				{
					ret = (DT) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Facility (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public EI Facility
		{
			get
			{
				EI ret = null;
				try
				{
					ret = (EI) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a PIP.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public PIP(Message message):base(message)
		{
			data = new Type[5];
			data[0] = new CE(message);
			data[1] = new CE(message);
			data[2] = new DT(message);
			data[3] = new DT(message);
			data[4] = new EI(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 5 element PIP composite");
			}
		}
	}
}