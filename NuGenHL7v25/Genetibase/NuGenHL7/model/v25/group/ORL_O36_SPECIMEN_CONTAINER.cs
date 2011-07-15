using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORL_O36_SPECIMEN_CONTAINER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SAC (Specimen Container detail) <b></b><br>
	/// 1: ORL_O36_ORDER (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORL_O36_SPECIMEN_CONTAINER:AbstractGroup
	{
		/// <summary> Returns SAC (Specimen Container detail) - creates it if necessary</summary>
		virtual public SAC SAC
		{
			get
			{
				SAC ret = null;
				try
				{
					ret = (SAC) this.get_Renamed("SAC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORL_O36_ORDER </summary>
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
		
		/// <summary> Creates a new ORL_O36_SPECIMEN_CONTAINER Group.</summary>
		public ORL_O36_SPECIMEN_CONTAINER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SAC), true, false);
				this.add(typeof(ORL_O36_ORDER), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORL_O36_ORDER (a Group object) - creates it if necessary</summary>
		public virtual ORL_O36_ORDER getORDER()
		{
			ORL_O36_ORDER ret = null;
			try
			{
				ret = (ORL_O36_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORL_O36_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORL_O36_ORDER getORDER(int rep)
		{
			return (ORL_O36_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}