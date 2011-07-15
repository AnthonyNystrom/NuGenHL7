using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the SQM_S25_LOCATION_RESOURCE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: AIL (Appointment Information _ Location Resource) <b></b><br>
	/// 1: APR (Appointment Preferences) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class SQM_S25_LOCATION_RESOURCE:AbstractGroup
	{
		/// <summary> Returns AIL (Appointment Information _ Location Resource) - creates it if necessary</summary>
		virtual public AIL AIL
		{
			get
			{
				AIL ret = null;
				try
				{
					ret = (AIL) this.get_Renamed("AIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns APR (Appointment Preferences) - creates it if necessary</summary>
		virtual public APR APR
		{
			get
			{
				APR ret = null;
				try
				{
					ret = (APR) this.get_Renamed("APR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SQM_S25_LOCATION_RESOURCE Group.</summary>
		public SQM_S25_LOCATION_RESOURCE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(AIL), true, false);
				this.add(typeof(APR), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}