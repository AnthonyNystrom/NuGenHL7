using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORB_O28_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORB_O28_PATIENT (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORB_O28_RESPONSE:AbstractGroup
	{
		/// <summary> Returns ORB_O28_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public ORB_O28_PATIENT PATIENT
		{
			get
			{
				ORB_O28_PATIENT ret = null;
				try
				{
					ret = (ORB_O28_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ORB_O28_RESPONSE Group.</summary>
		public ORB_O28_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORB_O28_PATIENT), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}