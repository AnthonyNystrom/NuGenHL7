using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 PN (person name) data type.  Consists of the following components: </p><ol>
	/// <li>family+last name (FN)</li>
	/// <li>given name (ST)</li>
	/// <li>middle initial or name (ST)</li>
	/// <li>suffix (e.g., JR or III) (ST)</li>
	/// <li>prefix (e.g., DR) (ST)</li>
	/// <li>degree (e.g., MD) (IS)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class PN:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns family+last name (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public FN FamilyLastName
		{
			get
			{
				FN ret = null;
				try
				{
					ret = (FN) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns given name (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST GivenName
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
		/// <summary> Returns middle initial or name (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST MiddleInitialOrName
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
		/// <summary> Returns suffix (e.g., JR or III) (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SuffixEgJRorIII
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
		/// <summary> Returns prefix (e.g., DR) (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST PrefixEgDR
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns degree (e.g., MD) (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS DegreeEgMD
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
		
		/// <summary> Creates a PN.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public PN(Message message):base(message)
		{
			data = new Type[6];
			data[0] = new FN(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 6 element PN composite");
			}
		}
	}
}