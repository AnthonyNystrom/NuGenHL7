using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORL_O22_OBSERVATION_REQUEST Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OBR (Observation Request) <b></b><br>
	/// 1: ORL_O22_SPECIMEN (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORL_O22_OBSERVATION_REQUEST:AbstractGroup
	{
		/// <summary> Returns OBR (Observation Request) - creates it if necessary</summary>
		virtual public OBR OBR
		{
			get
			{
				OBR ret = null;
				try
				{
					ret = (OBR) this.get_Renamed("OBR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORL_O22_SPECIMEN </summary>
		virtual public int SPECIMENReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SPECIMEN").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORL_O22_OBSERVATION_REQUEST Group.</summary>
		public ORL_O22_OBSERVATION_REQUEST(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OBR), true, false);
				this.add(typeof(ORL_O22_SPECIMEN), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORL_O22_SPECIMEN (a Group object) - creates it if necessary</summary>
		public virtual ORL_O22_SPECIMEN getSPECIMEN()
		{
			ORL_O22_SPECIMEN ret = null;
			try
			{
				ret = (ORL_O22_SPECIMEN) this.get_Renamed("SPECIMEN");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORL_O22_SPECIMEN
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORL_O22_SPECIMEN getSPECIMEN(int rep)
		{
			return (ORL_O22_SPECIMEN) this.get_Renamed("SPECIMEN", rep);
		}
	}
}