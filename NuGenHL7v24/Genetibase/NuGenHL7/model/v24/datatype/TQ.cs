using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v24.datatype
{
	
	/// <summary> <p>The HL7 TQ (timing quantity) data type.  Consists of the following components: </p><ol>
	/// <li>quantity (CQ)</li>
	/// <li>interval (RI)</li>
	/// <li>duration (ST)</li>
	/// <li>start date/time (TS)</li>
	/// <li>end date/time (TS)</li>
	/// <li>priority (ST)</li>
	/// <li>condition (ST)</li>
	/// <li>text (TX) (TX)</li>
	/// <li>conjunction component (ID)</li>
	/// <li>order sequencing (OSD)</li>
	/// <li>occurrence duration (CE)</li>
	/// <li>total occurences (NM)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class TQ:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns quantity (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CQ Quantity
		{
			get
			{
				CQ ret = null;
				try
				{
					ret = (CQ) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns interval (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public RI Interval
		{
			get
			{
				RI ret = null;
				try
				{
					ret = (RI) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns duration (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST Duration
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
		/// <summary> Returns start date/time (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS StartDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns end date/time (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TS EndDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					ret = (TS) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns priority (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST Priority
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
		/// <summary> Returns condition (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST Condition
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(6);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns text (TX) (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public TX Text
		{
			get
			{
				TX ret = null;
				try
				{
					ret = (TX) getComponent(7);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns conjunction component (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID ConjunctionComponent
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
		/// <summary> Returns order sequencing (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public OSD OrderSequencing
		{
			get
			{
				OSD ret = null;
				try
				{
					ret = (OSD) getComponent(9);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns occurrence duration (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CE OccurrenceDuration
		{
			get
			{
				CE ret = null;
				try
				{
					ret = (CE) getComponent(10);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns total occurences (component #11).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM TotalOccurences
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(11);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a TQ.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public TQ(Message message):base(message)
		{
			data = new Type[12];
			data[0] = new CQ(message);
			data[1] = new RI(message);
			data[2] = new ST(message);
			data[3] = new TS(message);
			data[4] = new TS(message);
			data[5] = new ST(message);
			data[6] = new ST(message);
			data[7] = new TX(message);
			data[8] = new ID(message, 0);
			data[9] = new OSD(message);
			data[10] = new CE(message);
			data[11] = new NM(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 12 element TQ composite");
			}
		}
	}
}