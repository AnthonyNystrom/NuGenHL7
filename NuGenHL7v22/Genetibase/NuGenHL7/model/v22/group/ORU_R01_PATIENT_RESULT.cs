using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the ORU_R01_PATIENT_RESULT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORU_R01_PATIENT (a Group object) <b>optional </b><br>
	/// 1: ORU_R01_ORDER_OBSERVATION (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORU_R01_PATIENT_RESULT:AbstractGroup
	{
		/// <summary> Returns ORU_R01_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public ORU_R01_PATIENT PATIENT
		{
			get
			{
				ORU_R01_PATIENT ret = null;
				try
				{
					ret = (ORU_R01_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORU_R01_ORDER_OBSERVATION </summary>
		virtual public int ORDER_OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER_OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORU_R01_PATIENT_RESULT Group.</summary>
		public ORU_R01_PATIENT_RESULT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORU_R01_PATIENT), false, false);
				this.add(typeof(ORU_R01_ORDER_OBSERVATION), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORU_R01_ORDER_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual ORU_R01_ORDER_OBSERVATION getORDER_OBSERVATION()
		{
			ORU_R01_ORDER_OBSERVATION ret = null;
			try
			{
				ret = (ORU_R01_ORDER_OBSERVATION) this.get_Renamed("ORDER_OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORU_R01_ORDER_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORU_R01_ORDER_OBSERVATION getORDER_OBSERVATION(int rep)
		{
			return (ORU_R01_ORDER_OBSERVATION) this.get_Renamed("ORDER_OBSERVATION", rep);
		}
	}
}