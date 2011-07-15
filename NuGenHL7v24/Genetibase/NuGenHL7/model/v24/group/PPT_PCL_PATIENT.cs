using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the PPT_PCL_PATIENT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (Patient identification) <b></b><br>
	/// 1: PPT_PCL_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 2: PPT_PCL_PATHWAY (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPT_PCL_PATIENT:AbstractGroup
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
		/// <summary> Returns PPT_PCL_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public PPT_PCL_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				PPT_PCL_PATIENT_VISIT ret = null;
				try
				{
					ret = (PPT_PCL_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPT_PCL_PATHWAY </summary>
		virtual public int PATHWAYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PATHWAY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PPT_PCL_PATIENT Group.</summary>
		public PPT_PCL_PATIENT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PPT_PCL_PATIENT_VISIT), false, false);
				this.add(typeof(PPT_PCL_PATHWAY), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PPT_PCL_PATHWAY (a Group object) - creates it if necessary</summary>
		public virtual PPT_PCL_PATHWAY getPATHWAY()
		{
			PPT_PCL_PATHWAY ret = null;
			try
			{
				ret = (PPT_PCL_PATHWAY) this.get_Renamed("PATHWAY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPT_PCL_PATHWAY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPT_PCL_PATHWAY getPATHWAY(int rep)
		{
			return (PPT_PCL_PATHWAY) this.get_Renamed("PATHWAY", rep);
		}
	}
}