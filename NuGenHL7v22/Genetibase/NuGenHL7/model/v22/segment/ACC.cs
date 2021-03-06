using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 ACC message segment. 
	/// This segment has the following fields:</p><p>
	/// ACC-1: Accident date / time (TS)<br> 
	/// ACC-2: Accident code (ID)<br> 
	/// ACC-3: Accident location (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ACC:AbstractSegment
	{
		/// <summary> Returns Accident date / time (ACC-1).</summary>
		virtual public TS AccidentDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Accident code (ACC-2).</summary>
		virtual public ID AccidentCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Accident location (ACC-3).</summary>
		virtual public ST AccidentLocation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a ACC (ACCIDENT) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ACC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 50});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}