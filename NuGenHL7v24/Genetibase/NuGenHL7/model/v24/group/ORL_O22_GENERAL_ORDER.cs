using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the ORL_O22_GENERAL_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORL_O22_CONTAINER (a Group object) <b>optional </b><br>
	/// 1: ORL_O22_ORDER (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORL_O22_GENERAL_ORDER:AbstractGroup
	{
		/// <summary> Returns ORL_O22_CONTAINER (a Group object) - creates it if necessary</summary>
		virtual public ORL_O22_CONTAINER CONTAINER
		{
			get
			{
				ORL_O22_CONTAINER ret = null;
				try
				{
					ret = (ORL_O22_CONTAINER) this.get_Renamed("CONTAINER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORL_O22_ORDER </summary>
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
		
		/// <summary> Creates a new ORL_O22_GENERAL_ORDER Group.</summary>
		public ORL_O22_GENERAL_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORL_O22_CONTAINER), false, false);
				this.add(typeof(ORL_O22_ORDER), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORL_O22_ORDER (a Group object) - creates it if necessary</summary>
		public virtual ORL_O22_ORDER getORDER()
		{
			ORL_O22_ORDER ret = null;
			try
			{
				ret = (ORL_O22_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORL_O22_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORL_O22_ORDER getORDER(int rep)
		{
			return (ORL_O22_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}