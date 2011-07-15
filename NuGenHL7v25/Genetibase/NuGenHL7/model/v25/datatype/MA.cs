using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v25.datatype
{
	
	/// <summary> <p>The HL7 MA (Multiplexed Array) data type.  Consists of the following components: </p><ol>
	/// <li>Sample 1 From Channel 1 (NM)</li>
	/// <li>Sample 1 From Channel 2 (NM)</li>
	/// <li>Sample 1 From Channel N (NM)</li>
	/// <li>Sample 2 From Channel 1 (NM)</li>
	/// <li>Sample 2 From Channel N (NM)</li>
	/// <li>Sample N From Channel N (NM)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class MA:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns Sample 1 From Channel 1 (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM Sample1FromChannel1
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
		/// <summary> Returns Sample 1 From Channel 2 (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM Sample1FromChannel2
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Sample 1 From Channel N (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM Sample1FromChannelN
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Sample 2 From Channel 1 (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM Sample2FromChannel1
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Sample 2 From Channel N (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM Sample2FromChannelN
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(4);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Sample N From Channel N (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM SampleNFromChannelN
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a MA.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public MA(Message message):base(message)
		{
			data = new Type[6];
			data[0] = new NM(message);
			data[1] = new NM(message);
			data[2] = new NM(message);
			data[3] = new NM(message);
			data[4] = new NM(message);
			data[5] = new NM(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 6 element MA composite");
			}
		}
	}
}