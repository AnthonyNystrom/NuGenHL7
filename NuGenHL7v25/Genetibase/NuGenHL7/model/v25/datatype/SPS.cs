using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 SPS (Specimen Source) data type.  Consists of the following components: </p><ol>
	/// <li>Specimen Source Name or Code (CWE)</li>
	/// <li>Additives (CWE)</li>
	/// <li>Specimen Collection Method (TX)</li>
	/// <li>Body Site (CWE)</li>
	/// <li>Site Modifier (CWE)</li>
	/// <li>Collection Method Modifier Code (CWE)</li>
	/// <li>Specimen Role (CWE)</li>
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
		/// <summary> Returns Specimen Source Name or Code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE SpecimenSourceNameOrCode
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Additives (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE Additives
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Specimen Collection Method (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TX SpecimenCollectionMethod
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
		/// <summary> Returns Body Site (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE BodySite
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Site Modifier (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE SiteModifier
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Collection Method Modifier Code (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE CollectionMethodModifierCode
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Specimen Role (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CWE SpecimenRole
		{
			get
			{
				CWE ret = null;
				try
				{
					ret = (CWE) getComponent(6);
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
			data[0] = new CWE(message);
			data[1] = new CWE(message);
			data[2] = new TX(message);
			data[3] = new CWE(message);
			data[4] = new CWE(message);
			data[5] = new CWE(message);
			data[6] = new CWE(message);
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