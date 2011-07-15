using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRG_O02_PIDNTEORCRXGRXRRXC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RRG_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: RRG_O02_ORCRXGRXRRXC (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RRG_O02_PIDNTEORCRXGRXRRXC:AbstractGroup
	{
		/// <summary> Returns RRG_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public RRG_O02_PIDNTE PIDNTE
		{
			get
			{
				RRG_O02_PIDNTE ret = null;
				try
				{
					ret = (RRG_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RRG_O02_ORCRXGRXRRXC </summary>
		virtual public int ORCRXGRXRRXCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXGRXRRXC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RRG_O02_PIDNTEORCRXGRXRRXC Group.</summary>
		public RRG_O02_PIDNTEORCRXGRXRRXC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RRG_O02_PIDNTE), false, false);
				this.add(typeof(RRG_O02_ORCRXGRXRRXC), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRG_O02_ORCRXGRXRRXC (a Group object) - creates it if necessary</summary>
		public virtual RRG_O02_ORCRXGRXRRXC getORCRXGRXRRXC()
		{
			RRG_O02_ORCRXGRXRRXC ret = null;
			try
			{
				ret = (RRG_O02_ORCRXGRXRRXC) this.get_Renamed("ORCRXGRXRRXC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRG_O02_ORCRXGRXRRXC
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRG_O02_ORCRXGRXRRXC getORCRXGRXRRXC(int rep)
		{
			return (RRG_O02_ORCRXGRXRRXC) this.get_Renamed("ORCRXGRXRRXC", rep);
		}
	}
}