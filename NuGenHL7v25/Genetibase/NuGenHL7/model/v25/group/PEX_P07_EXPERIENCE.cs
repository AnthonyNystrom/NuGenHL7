using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PEX_P07_EXPERIENCE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PES (Product Experience Sender) <b></b><br>
	/// 1: PEX_P07_PEX_OBSERVATION (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_EXPERIENCE:AbstractGroup
	{
		/// <summary> Returns PES (Product Experience Sender) - creates it if necessary</summary>
		virtual public PES PES
		{
			get
			{
				PES ret = null;
				try
				{
					ret = (PES) this.get_Renamed("PES");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PEX_P07_PEX_OBSERVATION </summary>
		virtual public int PEX_OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PEX_OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PEX_P07_EXPERIENCE Group.</summary>
		public PEX_P07_EXPERIENCE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PES), true, false);
				this.add(typeof(PEX_P07_PEX_OBSERVATION), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PEX_P07_PEX_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual PEX_P07_PEX_OBSERVATION getPEX_OBSERVATION()
		{
			PEX_P07_PEX_OBSERVATION ret = null;
			try
			{
				ret = (PEX_P07_PEX_OBSERVATION) this.get_Renamed("PEX_OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PEX_P07_PEX_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PEX_P07_PEX_OBSERVATION getPEX_OBSERVATION(int rep)
		{
			return (PEX_P07_PEX_OBSERVATION) this.get_Renamed("PEX_OBSERVATION", rep);
		}
	}
}