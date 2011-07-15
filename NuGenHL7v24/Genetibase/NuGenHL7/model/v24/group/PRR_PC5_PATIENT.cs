using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the PRR_PC5_PATIENT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (Patient identification) <b></b><br>
	/// 1: PRR_PC5_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 2: PRR_PC5_PROBLEM (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PRR_PC5_PATIENT:AbstractGroup
	{
		/// <summary> Returns PID (Patient identification) - creates it if necessary</summary>
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
		/// <summary> Returns PRR_PC5_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public PRR_PC5_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				PRR_PC5_PATIENT_VISIT ret = null;
				try
				{
					ret = (PRR_PC5_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRR_PC5_PROBLEM </summary>
		virtual public int PROBLEMReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROBLEM").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PRR_PC5_PATIENT Group.</summary>
		public PRR_PC5_PATIENT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PRR_PC5_PATIENT_VISIT), false, false);
				this.add(typeof(PRR_PC5_PROBLEM), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PRR_PC5_PROBLEM (a Group object) - creates it if necessary</summary>
		public virtual PRR_PC5_PROBLEM getPROBLEM()
		{
			PRR_PC5_PROBLEM ret = null;
			try
			{
				ret = (PRR_PC5_PROBLEM) this.get_Renamed("PROBLEM");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRR_PC5_PROBLEM
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRR_PC5_PROBLEM getPROBLEM(int rep)
		{
			return (PRR_PC5_PROBLEM) this.get_Renamed("PROBLEM", rep);
		}
	}
}