using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRD_O02_PIDNTEORCRXDRXRRXC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RRD_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: RRD_O02_ORCRXDRXRRXC (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RRD_O02_PIDNTEORCRXDRXRRXC:AbstractGroup
	{
		/// <summary> Returns RRD_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public RRD_O02_PIDNTE PIDNTE
		{
			get
			{
				RRD_O02_PIDNTE ret = null;
				try
				{
					ret = (RRD_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RRD_O02_ORCRXDRXRRXC </summary>
		virtual public int ORCRXDRXRRXCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXDRXRRXC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RRD_O02_PIDNTEORCRXDRXRRXC Group.</summary>
		public RRD_O02_PIDNTEORCRXDRXRRXC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RRD_O02_PIDNTE), false, false);
				this.add(typeof(RRD_O02_ORCRXDRXRRXC), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRD_O02_ORCRXDRXRRXC (a Group object) - creates it if necessary</summary>
		public virtual RRD_O02_ORCRXDRXRRXC getORCRXDRXRRXC()
		{
			RRD_O02_ORCRXDRXRRXC ret = null;
			try
			{
				ret = (RRD_O02_ORCRXDRXRRXC) this.get_Renamed("ORCRXDRXRRXC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRD_O02_ORCRXDRXRRXC
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRD_O02_ORCRXDRXRRXC getORCRXDRXRRXC(int rep)
		{
			return (RRD_O02_ORCRXDRXRRXC) this.get_Renamed("ORCRXDRXRRXC", rep);
		}
	}
}