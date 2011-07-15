using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the CSU_C09_STUDY_PHASE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: CSP (Clinical Study Phase) <b>optional repeating</b><br>
	/// 1: CSU_C09_STUDY_SCHEDULE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09_STUDY_PHASE:AbstractGroup
	{
		/// <summary> Returns the number of existing repetitions of CSP </summary>
		virtual public int CSPReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CSP").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_STUDY_SCHEDULE </summary>
		virtual public int STUDY_SCHEDULEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("STUDY_SCHEDULE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09_STUDY_PHASE Group.</summary>
		public CSU_C09_STUDY_PHASE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(CSP), false, true);
				this.add(typeof(CSU_C09_STUDY_SCHEDULE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSP (Clinical Study Phase) - creates it if necessary</summary>
		public virtual CSP getCSP()
		{
			CSP ret = null;
			try
			{
				ret = (CSP) this.get_Renamed("CSP");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSP
		/// (Clinical Study Phase) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSP getCSP(int rep)
		{
			return (CSP) this.get_Renamed("CSP", rep);
		}
		
		/// <summary> Returns  first repetition of CSU_C09_STUDY_SCHEDULE (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_STUDY_SCHEDULE getSTUDY_SCHEDULE()
		{
			CSU_C09_STUDY_SCHEDULE ret = null;
			try
			{
				ret = (CSU_C09_STUDY_SCHEDULE) this.get_Renamed("STUDY_SCHEDULE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_STUDY_SCHEDULE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_STUDY_SCHEDULE getSTUDY_SCHEDULE(int rep)
		{
			return (CSU_C09_STUDY_SCHEDULE) this.get_Renamed("STUDY_SCHEDULE", rep);
		}
	}
}