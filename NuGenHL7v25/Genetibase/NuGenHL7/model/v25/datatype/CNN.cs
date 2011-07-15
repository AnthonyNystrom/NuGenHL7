using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 CNN (Composite ID Number and Name Simplified) data type.  Consists of the following components: </p><ol>
	/// <li>ID Number (ST)</li>
	/// <li>Family Name (ST)</li>
	/// <li>Given Name (ST)</li>
	/// <li>Second and Further Given Names or Initials Thereof (ST)</li>
	/// <li>Suffix (e.g., JR or III) (ST)</li>
	/// <li>Prefix (e.g., DR) (ST)</li>
	/// <li>Degree (e.g., MD (IS)</li>
	/// <li>Source Table (IS)</li>
	/// <li>Assigning Authority   - Namespace ID (IS)</li>
	/// <li>Assigning Authority  - Universal ID (ST)</li>
	/// <li>Assigning Authority  - Universal ID Type (ID)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CNN:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns ID Number (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST IDNumber
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
		/// <summary> Returns Family Name (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST FamilyName
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
		/// <summary> Returns Given Name (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST GivenName
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
		/// <summary> Returns Second and Further Given Names or Initials Thereof (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SecondAndFurtherGivenNamesOrInitialsThereof
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
		/// <summary> Returns Suffix (e.g., JR or III) (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SuffixEgJRorIII
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
		/// <summary> Returns Prefix (e.g., DR) (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST PrefixEgDR
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
		/// <summary> Returns Degree (e.g., MD (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS DegreeEgMD
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Source Table (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS SourceTable
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Assigning Authority   - Namespace ID (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS AssigningAuthorityNamespaceID
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Assigning Authority  - Universal ID (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST AssigningAuthorityUniversalID
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(9);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Assigning Authority  - Universal ID Type (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID AssigningAuthorityUniversalIDType
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(10);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CNN.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CNN(Message message):base(message)
		{
			data = new Type[11];
			data[0] = new ST(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ST(message);
			data[6] = new IS(message, 360);
			data[7] = new IS(message, 297);
			data[8] = new IS(message, 363);
			data[9] = new ST(message);
			data[10] = new ID(message, 301);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 11 element CNN composite");
			}
		}
	}
}