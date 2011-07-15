using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRA_O02_PIDNTEORCRXARXR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RRA_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: RRA_O02_ORCRXARXR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RRA_O02_PIDNTEORCRXARXR:AbstractGroup
	{
		/// <summary> Returns RRA_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public RRA_O02_PIDNTE PIDNTE
		{
			get
			{
				RRA_O02_PIDNTE ret = null;
				try
				{
					ret = (RRA_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RRA_O02_ORCRXARXR </summary>
		virtual public int ORCRXARXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXARXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RRA_O02_PIDNTEORCRXARXR Group.</summary>
		public RRA_O02_PIDNTEORCRXARXR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RRA_O02_PIDNTE), false, false);
				this.add(typeof(RRA_O02_ORCRXARXR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRA_O02_ORCRXARXR (a Group object) - creates it if necessary</summary>
		public virtual RRA_O02_ORCRXARXR getORCRXARXR()
		{
			RRA_O02_ORCRXARXR ret = null;
			try
			{
				ret = (RRA_O02_ORCRXARXR) this.get_Renamed("ORCRXARXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRA_O02_ORCRXARXR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRA_O02_ORCRXARXR getORCRXARXR(int rep)
		{
			return (RRA_O02_ORCRXARXR) this.get_Renamed("ORCRXARXR", rep);
		}
	}
}