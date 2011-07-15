using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 PPN (Performing Person Time Stamp) data type.  Consists of the following components: </p><ol>
	/// <li>ID Number (ST)</li>
	/// <li>Family Name (FN)</li>
	/// <li>Given Name (ST)</li>
	/// <li>Second and Further Given Names or Initials Thereof (ST)</li>
	/// <li>Suffix (e.g., JR or III) (ST)</li>
	/// <li>Prefix (e.g., DR) (ST)</li>
	/// <li>Degree (e.g., MD) (IS)</li>
	/// <li>Source Table (IS)</li>
	/// <li>Assigning Authority (HD)</li>
	/// <li>Name Type Code (ID)</li>
	/// <li>Identifier Check Digit (ST)</li>
	/// <li>Check Digit Scheme (ID)</li>
	/// <li>Identifier Type Code (ID)</li>
	/// <li>Assigning Facility (HD)</li>
	/// <li>Date/Time Action Performed (TS)</li>
	/// <li>Name Representation Code (ID)</li>
	/// <li>Name Context (CE)</li>
	/// <li>Name Validity Range (DR)</li>
	/// <li>Name Assembly Order (ID)</li>
	/// <li>Effective Date (TS)</li>
	/// <li>Expiration Date (TS)</li>
	/// <li>Professional Suffix (ST)</li>
	/// <li>Assigning Jurisdiction (CWE)</li>
	/// <li>Assigning Agency or Department (CWE)</li>
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
		virtual public FN FamilyName
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
		/// <summary> Returns Degree (e.g., MD) (component #6).  This is a convenience method that saves you from 
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
		/// <summary> Returns Assigning Authority (component #8).  This is a convenience method that saves you from 
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
		/// <summary> Returns Name Type Code (component #9).  This is a convenience method that saves you from 
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
		/// <summary> Returns Identifier Check Digit (component #10).  This is a convenience method that saves you from 
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
		/// <summary> Returns Check Digit Scheme (component #11).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CheckDigitScheme
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
		/// <summary> Returns Identifier Type Code (component #12).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID IdentifierTypeCode
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(12);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Assigning Facility (component #13).  This is a convenience method that saves you from 
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
		/// <summary> Returns Name Representation Code (component #15).  This is a convenience method that saves you from 
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
		/// <summary> Returns Name Context (component #16).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE NameContext
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(16);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Name Validity Range (component #17).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public DR NameValidityRange
		{
			get
			{
				DR ret = null;
				try
				{
					ret = (DR) getComponent(17);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Name Assembly Order (component #18).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID NameAssemblyOrder
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(18);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Effective Date (component #19).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS EffectiveDate
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(19);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Expiration Date (component #20).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS ExpirationDate
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(20);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Professional Suffix (component #21).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ProfessionalSuffix
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(21);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Assigning Jurisdiction (component #22).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE AssigningJurisdiction
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(22);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Assigning Agency or Department (component #23).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE AssigningAgencyOrDepartment
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(23);
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
			data = new Type[24];
			data[0] = new ST(message);
			data[1] = new FN(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ST(message);
			data[6] = new IS(message, 360);
			data[7] = new IS(message, 297);
			data[8] = new HD(message);
			data[9] = new ID(message, 200);
			data[10] = new ST(message);
			data[11] = new ID(message, 61);
			data[12] = new ID(message, 203);
			data[13] = new HD(message);
			data[14] = new TS(message);
			data[15] = new ID(message, 465);
			data[16] = new CE(message);
			data[17] = new DR(message);
			data[18] = new ID(message, 444);
			data[19] = new TS(message);
			data[20] = new TS(message);
			data[21] = new ST(message);
			data[22] = new CWE(message);
			data[23] = new CWE(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 24 element PPN composite");
			}
		}
	}
}