using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 PPN (performing person time stamp) data type.  Consists of the following components: </p><ol>
	/// <li>ID number (ST) (ST)</li>
	/// <li>family+last name (FN)</li>
	/// <li>given name (ST)</li>
	/// <li>middle initial or name (ST)</li>
	/// <li>suffix (e.g., JR or III) (ST)</li>
	/// <li>prefix (e.g., DR) (ST)</li>
	/// <li>degree (e.g., MD) (IS)</li>
	/// <li>source table (IS)</li>
	/// <li>assigning authority (HD)</li>
	/// <li>name type code (ID)</li>
	/// <li>identifier check digit (ST)</li>
	/// <li>code identifying the check digit scheme employed (ID)</li>
	/// <li>identifier type code (IS)</li>
	/// <li>assigning facility (HD)</li>
	/// <li>Date/Time Action Performed (TS)</li>
	/// <li>Name Representation code (ID)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class PPN:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns ID number (ST) (component #0).  This is a convenience method that saves you from 
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
		/// <summary> Returns family+last name (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public FN FamilyLastName
		{
			get
			{
				FN ret = null;
				try
				{
					ret = (FN) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns given name (component #2).  This is a convenience method that saves you from 
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
		/// <summary> Returns middle initial or name (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST MiddleInitialOrName
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
		/// <summary> Returns suffix (e.g., JR or III) (component #4).  This is a convenience method that saves you from 
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
		/// <summary> Returns prefix (e.g., DR) (component #5).  This is a convenience method that saves you from 
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
		/// <summary> Returns degree (e.g., MD) (component #6).  This is a convenience method that saves you from 
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
		/// <summary> Returns source table (component #7).  This is a convenience method that saves you from 
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
		/// <summary> Returns assigning authority (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD AssigningAuthority
		{
			get
			{
				HD ret = null;
				try
				{
					ret = (HD) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns name type code (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID NameTypeCode
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(9);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns identifier check digit (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST IdentifierCheckDigit
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(10);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns code identifying the check digit scheme employed (component #11).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CodeIdentifyingTheCheckDigitSchemeEmployed
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(11);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns identifier type code (component #12).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS IdentifierTypeCode
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(12);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns assigning facility (component #13).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public HD AssigningFacility
		{
			get
			{
				HD ret = null;
				try
				{
					ret = (HD) getComponent(13);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Date/Time Action Performed (component #14).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS DateTimeActionPerformed
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(14);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Name Representation code (component #15).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID NameRepresentationCode
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(15);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a PPN.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public PPN(Message message):base(message)
		{
			data = new Type[16];
			data[0] = new ST(message);
			data[1] = new FN(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ST(message);
			data[6] = new IS(message, 0);
			data[7] = new IS(message, 0);
			data[8] = new HD(message);
			data[9] = new ID(message, 0);
			data[10] = new ST(message);
			data[11] = new ID(message, 0);
			data[12] = new IS(message, 0);
			data[13] = new HD(message);
			data[14] = new TS(message);
			data[15] = new ID(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 16 element PPN composite");
			}
		}
	}
}