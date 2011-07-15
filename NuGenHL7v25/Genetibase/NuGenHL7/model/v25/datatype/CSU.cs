using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 CSU (Channel Sensitivity) data type.  Consists of the following components: </p><ol>
	/// <li>Channel Sensitivity (NM)</li>
	/// <li>Unit of Measure Identifier (ST)</li>
	/// <li>Unit of Measure Description (ST)</li>
	/// <li>Unit of Measure Coding System (ID)</li>
	/// <li>Alternate Unit of Measure Identifier (ST)</li>
	/// <li>Alternate Unit of Measure Description (ST)</li>
	/// <li>Alternate Unit of Measure Coding System (ID)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CSU:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Channel Sensitivity (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM ChannelSensitivity
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Unit of Measure Identifier (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST UnitOfMeasureIdentifier
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
		/// <summary> Returns Unit of Measure Description (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST UnitOfMeasureDescription
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
		/// <summary> Returns Unit of Measure Coding System (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID UnitOfMeasureCodingSystem
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Alternate Unit of Measure Identifier (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST AlternateUnitOfMeasureIdentifier
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
		/// <summary> Returns Alternate Unit of Measure Description (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST AlternateUnitOfMeasureDescription
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
		/// <summary> Returns Alternate Unit of Measure Coding System (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID AlternateUnitOfMeasureCodingSystem
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CSU.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CSU(Message message):base(message)
		{
			data = new Type[7];
			data[0] = new NM(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ID(message, 396);
			data[4] = new ST(message);
			data[5] = new ST(message);
			data[6] = new ID(message, 396);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 7 element CSU composite");
			}
		}
	}
}