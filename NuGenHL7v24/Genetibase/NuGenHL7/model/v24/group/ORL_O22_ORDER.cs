using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the ORL_O22_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: ORL_O22_OBSERVATION_REQUEST (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORL_O22_ORDER:AbstractGroup
	{
		/// <summary> Returns ORC (Common Order) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ORL_O22_OBSERVATION_REQUEST (a Group object) - creates it if necessary</summary>
		virtual public ORL_O22_OBSERVATION_REQUEST OBSERVATION_REQUEST
		{
			get
			{
				ORL_O22_OBSERVATION_REQUEST ret = null;
				try
				{
					ret = (ORL_O22_OBSERVATION_REQUEST) this.get_Renamed("OBSERVATION_REQUEST");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ORL_O22_ORDER Group.</summary>
		public ORL_O22_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(ORL_O22_OBSERVATION_REQUEST), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}