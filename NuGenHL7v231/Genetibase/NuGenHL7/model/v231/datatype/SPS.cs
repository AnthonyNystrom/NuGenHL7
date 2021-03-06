using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 SPS (specimen source) data type.  Consists of the following components: </p><ol>
	/// <li>specimen source name or code (CE)</li>
	/// <li>additives (TX)</li>
	/// <li>freetext (TX)</li>
	/// <li>body site (CE)</li>
	/// <li>site modifier (CE)</li>
	/// <li>collection modifier method code (CE)</li>
	/// <li>specimen role (CE)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class SPS:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns specimen source name or code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE SpecimenSourceNameOrCode
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
		/// <summary> Returns additives (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TX Additives
		{
			get
			{
				TX ret = null;
				try
				{
					ret = (TX) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns freetext (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TX Freetext
		{
			get
			{
				TX ret = null;
				try
				{
					ret = (TX) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns body site (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE BodySite
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns site modifier (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE SiteModifier
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns collection modifier method code (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE CollectionModifierMethodCode
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns specimen role (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE SpecimenRole
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a SPS.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public SPS(Message message):base(message)
		{
			data = new Type[7];
			data[0] = new CE(message);
			data[1] = new TX(message);
			data[2] = new TX(message);
			data[3] = new CE(message);
			data[4] = new CE(message);
			data[5] = new CE(message);
			data[6] = new CE(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 7 element SPS composite");
			}
		}
	}
}