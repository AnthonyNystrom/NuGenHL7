using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the SQM_S25_REQUEST Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ARQ (Appointment Request) <b></b><br>
	/// 1: APR (Appointment Preferences) <b>optional </b><br>
	/// 2: PID (Patient Identification) <b>optional </b><br>
	/// 3: SQM_S25_RESOURCES (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SQM_S25_REQUEST:AbstractGroup
	{
		/// <summary> Returns ARQ (Appointment Request) - creates it if necessary</summary>
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
		/// <summary> Returns APR (Appointment Preferences) - creates it if necessary</summary>
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
		/// <summary> Returns PID (Patient Identification) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of SQM_S25_RESOURCES </summary>
		virtual public int RESOURCESReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RESOURCES").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SQM_S25_REQUEST Group.</summary>
		public SQM_S25_REQUEST(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ARQ), true, false);
				this.add(typeof(APR), false, false);
				this.add(typeof(PID), false, false);
				this.add(typeof(SQM_S25_RESOURCES), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SQM_S25_RESOURCES (a Group object) - creates it if necessary</summary>
		public virtual SQM_S25_RESOURCES getRESOURCES()
		{
			SQM_S25_RESOURCES ret = null;
			try
			{
				ret = (SQM_S25_RESOURCES) this.get_Renamed("RESOURCES");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQM_S25_RESOURCES
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQM_S25_RESOURCES getRESOURCES(int rep)
		{
			return (SQM_S25_RESOURCES) this.get_Renamed("RESOURCES", rep);
		}
	}
}