using System;
using Composite = Genetibase.NuGenHL7.model.Composite;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
using Type = Genetibase.NuGenHL7.model.Type;
using AbstractType = Genetibase.NuGenHL7.model.AbstractType;
namespace Genetibase.NuGenHL7.model.v24.datatype
{
	
	/// <summary> <p>The HL7 CD (channel definition) data type.  Consists of the following components: </p><ol>
	/// <li>channel identifier (WVI)</li>
	/// <li>waveform source (WVS)</li>
	/// <li>channel sensitivity/units (CSU)</li>
	/// <li>channel calibration parameters (CCP)</li>
	/// <li>channel sampling frequency (NM)</li>
	/// <li>minimum/maximum data values (NR)</li>
	/// </ol>
	/// </summary>
	[Serializable]
	public class CD:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns channel identifier (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public WVI ChannelIdentifier
		{
			get
			{
				WVI ret = null;
				try
				{
					ret = (WVI) getComponent(0);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns waveform source (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public WVS WaveformSource
		{
			get
			{
				WVS ret = null;
				try
				{
					ret = (WVS) getComponent(1);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns channel sensitivity/units (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CSU ChannelSensitivityUnits
		{
			get
			{
				CSU ret = null;
				try
				{
					ret = (CSU) getComponent(2);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns channel calibration parameters (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public CCP ChannelCalibrationParameters
		{
			get
			{
				CCP ret = null;
				try
				{
					ret = (CCP) getComponent(3);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns channel sampling frequency (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM ChannelSamplingFrequency
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
		/// <summary> Returns minimum/maximum data values (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NR MinimumMaximumDataValues
		{
			get
			{
				NR ret = null;
				try
				{
					ret = (NR) getComponent(5);
				}
				catch (DataTypeException)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CD.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CD(Message message):base(message)
		{
			data = new Type[6];
			data[0] = new WVI(message);
			data[1] = new WVS(message);
			data[2] = new CSU(message);
			data[3] = new CCP(message);
			data[4] = new NM(message);
			data[5] = new NR(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 6 element CD composite");
			}
		}
	}
}