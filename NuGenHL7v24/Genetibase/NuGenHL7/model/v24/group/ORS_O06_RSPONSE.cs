using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the ORS_O06_RSPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORS_O06_PATIENT (a Group object) <b>optional </b><br>
	/// 1: ORS_O06_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORS_O06_RSPONSE:AbstractGroup
	{
		/// <summary> Returns ORS_O06_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public ORS_O06_PATIENT PATIENT
		{
			get
			{
				ORS_O06_PATIENT ret = null;
				try
				{
					ret = (ORS_O06_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORS_O06_ORDER </summary>
		virtual public int ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORS_O06_RSPONSE Group.</summary>
		public ORS_O06_RSPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORS_O06_PATIENT), false, false);
				this.add(typeof(ORS_O06_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORS_O06_ORDER (a Group object) - creates it if necessary</summary>
		public virtual ORS_O06_ORDER getORDER()
		{
			ORS_O06_ORDER ret = null;
			try
			{
				ret = (ORS_O06_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORS_O06_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORS_O06_ORDER getORDER(int rep)
		{
			return (ORS_O06_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}