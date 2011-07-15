using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PEX_P07_PEX_OBSERVATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PEO (Product Experience Observation) <b></b><br>
	/// 1: PEX_P07_PEX_CAUSE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_PEX_OBSERVATION:AbstractGroup
	{
		/// <summary> Returns PEO (Product Experience Observation) - creates it if necessary</summary>
		virtual public PEO PEO
		{
			get
			{
				PEO ret = null;
				try
				{
					ret = (PEO) this.get_Renamed("PEO");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PEX_P07_PEX_CAUSE </summary>
		virtual public int PEX_CAUSEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PEX_CAUSE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PEX_P07_PEX_OBSERVATION Group.</summary>
		public PEX_P07_PEX_OBSERVATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PEO), true, false);
				this.add(typeof(PEX_P07_PEX_CAUSE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PEX_P07_PEX_CAUSE (a Group object) - creates it if necessary</summary>
		public virtual PEX_P07_PEX_CAUSE getPEX_CAUSE()
		{
			PEX_P07_PEX_CAUSE ret = null;
			try
			{
				ret = (PEX_P07_PEX_CAUSE) this.get_Renamed("PEX_CAUSE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PEX_P07_PEX_CAUSE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PEX_P07_PEX_CAUSE getPEX_CAUSE(int rep)
		{
			return (PEX_P07_PEX_CAUSE) this.get_Renamed("PEX_CAUSE", rep);
		}
	}
}