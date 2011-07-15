using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the BRP_O30_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: BRP_O30_PATIENT (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class BRP_O30_RESPONSE:AbstractGroup
	{
		/// <summary> Returns BRP_O30_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public BRP_O30_PATIENT PATIENT
		{
			get
			{
				BRP_O30_PATIENT ret = null;
				try
				{
					ret = (BRP_O30_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new BRP_O30_RESPONSE Group.</summary>
		public BRP_O30_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(BRP_O30_PATIENT), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}