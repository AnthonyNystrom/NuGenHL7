using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the PPV_PCA_PATIENT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (Patient identification) <b></b><br>
	/// 1: PPV_PCA_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 2: PPV_PCA_GOAL (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPV_PCA_PATIENT:AbstractGroup
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
		/// <summary> Returns PPV_PCA_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public PPV_PCA_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				PPV_PCA_PATIENT_VISIT ret = null;
				try
				{
					ret = (PPV_PCA_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPV_PCA_GOAL </summary>
		virtual public int GOALReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GOAL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PPV_PCA_PATIENT Group.</summary>
		public PPV_PCA_PATIENT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PPV_PCA_PATIENT_VISIT), false, false);
				this.add(typeof(PPV_PCA_GOAL), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PPV_PCA_GOAL (a Group object) - creates it if necessary</summary>
		public virtual PPV_PCA_GOAL getGOAL()
		{
			PPV_PCA_GOAL ret = null;
			try
			{
				ret = (PPV_PCA_GOAL) this.get_Renamed("GOAL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPV_PCA_GOAL
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPV_PCA_GOAL getGOAL(int rep)
		{
			return (PPV_PCA_GOAL) this.get_Renamed("GOAL", rep);
		}
	}
}