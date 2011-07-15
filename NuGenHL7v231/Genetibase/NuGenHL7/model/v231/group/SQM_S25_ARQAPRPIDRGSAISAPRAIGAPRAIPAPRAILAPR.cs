using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SQM_S25_ARQAPRPIDRGSAISAPRAIGAPRAIPAPRAILAPR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ARQ (ARQ - appointment request segment) <b></b><br>
	/// 1: APR (APR - appointment preferences segment) <b>optional </b><br>
	/// 2: PID (PID - patient identification segment) <b>optional </b><br>
	/// 3: SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SQM_S25_ARQAPRPIDRGSAISAPRAIGAPRAIPAPRAILAPR:AbstractGroup
	{
		/// <summary> Returns ARQ (ARQ - appointment request segment) - creates it if necessary</summary>
		virtual public ARQ ARQ
		{
			get
			{
				ARQ ret = null;
				try
				{
					ret = (ARQ) this.get_Renamed("ARQ");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns APR (APR - appointment preferences segment) - creates it if necessary</summary>
		virtual public APR APR
		{
			get
			{
				APR ret = null;
				try
				{
					ret = (APR) this.get_Renamed("APR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PID (PID - patient identification segment) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR </summary>
		virtual public int RGSAISAPRAIGAPRAIPAPRAILAPRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RGSAISAPRAIGAPRAIPAPRAILAPR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SQM_S25_ARQAPRPIDRGSAISAPRAIGAPRAIPAPRAILAPR Group.</summary>
		public SQM_S25_ARQAPRPIDRGSAISAPRAIGAPRAIPAPRAILAPR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ARQ), true, false);
				this.add(typeof(APR), false, false);
				this.add(typeof(PID), false, false);
				this.add(typeof(SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR (a Group object) - creates it if necessary</summary>
		public virtual SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR getRGSAISAPRAIGAPRAIPAPRAILAPR()
		{
			SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR ret = null;
			try
			{
				ret = (SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR) this.get_Renamed("RGSAISAPRAIGAPRAIPAPRAILAPR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR getRGSAISAPRAIGAPRAIPAPRAILAPR(int rep)
		{
			return (SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR) this.get_Renamed("RGSAISAPRAIGAPRAIPAPRAILAPR", rep);
		}
	}
}