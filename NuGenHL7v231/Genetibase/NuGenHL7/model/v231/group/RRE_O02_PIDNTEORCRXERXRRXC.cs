using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRE_O02_PIDNTEORCRXERXRRXC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RRE_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: RRE_O02_ORCRXERXRRXC (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RRE_O02_PIDNTEORCRXERXRRXC:AbstractGroup
	{
		/// <summary> Returns RRE_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public RRE_O02_PIDNTE PIDNTE
		{
			get
			{
				RRE_O02_PIDNTE ret = null;
				try
				{
					ret = (RRE_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RRE_O02_ORCRXERXRRXC </summary>
		virtual public int ORCRXERXRRXCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXERXRRXC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RRE_O02_PIDNTEORCRXERXRRXC Group.</summary>
		public RRE_O02_PIDNTEORCRXERXRRXC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RRE_O02_PIDNTE), false, false);
				this.add(typeof(RRE_O02_ORCRXERXRRXC), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRE_O02_ORCRXERXRRXC (a Group object) - creates it if necessary</summary>
		public virtual RRE_O02_ORCRXERXRRXC getORCRXERXRRXC()
		{
			RRE_O02_ORCRXERXRRXC ret = null;
			try
			{
				ret = (RRE_O02_ORCRXERXRRXC) this.get_Renamed("ORCRXERXRRXC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRE_O02_ORCRXERXRRXC
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRE_O02_ORCRXERXRRXC getORCRXERXRRXC(int rep)
		{
			return (RRE_O02_ORCRXERXRRXC) this.get_Renamed("ORCRXERXRRXC", rep);
		}
	}
}