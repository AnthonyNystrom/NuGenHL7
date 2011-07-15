using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v231.datatype
{
	
	/// <summary> <p>The HL7 OSD (order sequence) data type.  Consists of the following components: </p><ol>
	/// <li>sequence/results flag (ID)</li>
	/// <li>placer order number: entity identifier (ST)</li>
	/// <li>placer order number: namespace ID (IS)</li>
	/// <li>filler order number: entity identifier (ST)</li>
	/// <li>filler order number: namespace ID (IS)</li>
	/// <li>sequence condition value (ST)</li>
	/// <li>maximum number of repeats (NM)</li>
	/// <li>placer order number: universal ID (ST)</li>
	/// <li>placer order number; universal ID type (ID)</li>
	/// <li>filler order number: universal ID (ST)</li>
	/// <li>filler order number: universal ID type (ID)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class OSD:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns sequence/results flag (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID SequenceResultsFlag
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns placer order number: entity identifier (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST PlacerOrderNumberEntityIdentifier
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
		/// <summary> Returns placer order number: namespace ID (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS PlacerOrderNumberNamespaceID
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns filler order number: entity identifier (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST FillerOrderNumberEntityIdentifier
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
		/// <summary> Returns filler order number: namespace ID (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public IS FillerOrderNumberNamespaceID
		{
			get
			{
				IS ret = null;
				try
				{
					ret = (IS) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns sequence condition value (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST SequenceConditionValue
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
		/// <summary> Returns maximum number of repeats (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM MaximumNumberOfRepeats
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns placer order number: universal ID (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST PlacerOrderNumberUniversalID
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns placer order number; universal ID type (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID PlacerOrderNumberUniversalIDType
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(8);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns filler order number: universal ID (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST FillerOrderNumberUniversalID
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
		/// <summary> Returns filler order number: universal ID type (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID FillerOrderNumberUniversalIDType
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
		
		/// <summary> Creates a OSD.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public OSD(Message message):base(message)
		{
			data = new Type[11];
			data[0] = new ID(message, 0);
			data[1] = new ST(message);
			data[2] = new IS(message, 0);
			data[3] = new ST(message);
			data[4] = new IS(message, 0);
			data[5] = new ST(message);
			data[6] = new NM(message);
			data[7] = new ST(message);
			data[8] = new ID(message, 0);
			data[9] = new ST(message);
			data[10] = new ID(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 11 element OSD composite");
			}
		}
	}
}