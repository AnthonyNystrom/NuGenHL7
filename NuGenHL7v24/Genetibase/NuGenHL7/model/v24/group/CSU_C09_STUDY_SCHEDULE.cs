using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the CSU_C09_STUDY_SCHEDULE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: CSS (Clinical Study Data Schedule Segment) <b>optional </b><br>
	/// 1: CSU_C09_STUDY_OBSERVATION (a Group object) <b>repeating</b><br>
	/// 2: CSU_C09_STUDY_PHARM (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09_STUDY_SCHEDULE:AbstractGroup
	{
		/// <summary> Returns CSS (Clinical Study Data Schedule Segment) - creates it if necessary</summary>
		virtual public CSS CSS
		{
			get
			{
				CSS ret = null;
				try
				{
					ret = (CSS) this.get_Renamed("CSS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_STUDY_OBSERVATION </summary>
		virtual public int STUDY_OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("STUDY_OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_STUDY_PHARM </summary>
		virtual public int STUDY_PHARMReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("STUDY_PHARM").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09_STUDY_SCHEDULE Group.</summary>
		public CSU_C09_STUDY_SCHEDULE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(CSS), false, false);
				this.add(typeof(CSU_C09_STUDY_OBSERVATION), true, true);
				this.add(typeof(CSU_C09_STUDY_PHARM), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSU_C09_STUDY_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_STUDY_OBSERVATION getSTUDY_OBSERVATION()
		{
			CSU_C09_STUDY_OBSERVATION ret = null;
			try
			{
				ret = (CSU_C09_STUDY_OBSERVATION) this.get_Renamed("STUDY_OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_STUDY_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_STUDY_OBSERVATION getSTUDY_OBSERVATION(int rep)
		{
			return (CSU_C09_STUDY_OBSERVATION) this.get_Renamed("STUDY_OBSERVATION", rep);
		}
		
		/// <summary> Returns  first repetition of CSU_C09_STUDY_PHARM (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_STUDY_PHARM getSTUDY_PHARM()
		{
			CSU_C09_STUDY_PHARM ret = null;
			try
			{
				ret = (CSU_C09_STUDY_PHARM) this.get_Renamed("STUDY_PHARM");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_STUDY_PHARM
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_STUDY_PHARM getSTUDY_PHARM(int rep)
		{
			return (CSU_C09_STUDY_PHARM) this.get_Renamed("STUDY_PHARM", rep);
		}
	}
}