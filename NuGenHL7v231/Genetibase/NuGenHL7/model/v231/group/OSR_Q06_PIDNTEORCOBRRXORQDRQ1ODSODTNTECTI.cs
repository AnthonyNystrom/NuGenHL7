using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OSR_Q06_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI:AbstractGroup
	{
		/// <summary> Returns OSR_Q06_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public OSR_Q06_PIDNTE PIDNTE
		{
			get
			{
				OSR_Q06_PIDNTE ret = null;
				try
				{
					ret = (OSR_Q06_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI </summary>
		virtual public int ORCOBRRXORQDRQ1ODSODTNTECTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCOBRRXORQDRQ1ODSODTNTECTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI Group.</summary>
		public OSR_Q06_PIDNTEORCOBRRXORQDRQ1ODSODTNTECTI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OSR_Q06_PIDNTE), false, false);
				this.add(typeof(OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI (a Group object) - creates it if necessary</summary>
		public virtual OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI getORCOBRRXORQDRQ1ODSODTNTECTI()
		{
			OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI ret = null;
			try
			{
				ret = (OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI) this.get_Renamed("ORCOBRRXORQDRQ1ODSODTNTECTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI getORCOBRRXORQDRQ1ODSODTNTECTI(int rep)
		{
			return (OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI) this.get_Renamed("ORCOBRRXORQDRQ1ODSODTNTECTI", rep);
		}
	}
}