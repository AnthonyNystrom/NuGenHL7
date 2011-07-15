using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the CSU_C09_STUDY_PHARM Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b>optional </b><br>
	/// 1: CSU_C09_RX_ADMIN (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09_STUDY_PHARM:AbstractGroup
	{
		/// <summary> Returns ORC (Common Order) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_RX_ADMIN </summary>
		virtual public int RX_ADMINReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RX_ADMIN").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09_STUDY_PHARM Group.</summary>
		public CSU_C09_STUDY_PHARM(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), false, false);
				this.add(typeof(CSU_C09_RX_ADMIN), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSU_C09_RX_ADMIN (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_RX_ADMIN getRX_ADMIN()
		{
			CSU_C09_RX_ADMIN ret = null;
			try
			{
				ret = (CSU_C09_RX_ADMIN) this.get_Renamed("RX_ADMIN");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_RX_ADMIN
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_RX_ADMIN getRX_ADMIN(int rep)
		{
			return (CSU_C09_RX_ADMIN) this.get_Renamed("RX_ADMIN", rep);
		}
	}
}