using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PTR_PCF_PATIENT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (Patient Identification) <b></b><br>
	/// 1: PTR_PCF_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 2: PTR_PCF_PATHWAY (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PTR_PCF_PATIENT:AbstractGroup
	{
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
		/// <summary> Returns PTR_PCF_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public PTR_PCF_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				PTR_PCF_PATIENT_VISIT ret = null;
				try
				{
					ret = (PTR_PCF_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PTR_PCF_PATHWAY </summary>
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
		
		/// <summary> Creates a new PTR_PCF_PATIENT Group.</summary>
		public PTR_PCF_PATIENT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PTR_PCF_PATIENT_VISIT), false, false);
				this.add(typeof(PTR_PCF_PATHWAY), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PTR_PCF_PATHWAY (a Group object) - creates it if necessary</summary>
		public virtual PTR_PCF_PATHWAY getPATHWAY()
		{
			PTR_PCF_PATHWAY ret = null;
			try
			{
				ret = (PTR_PCF_PATHWAY) this.get_Renamed("PATHWAY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PTR_PCF_PATHWAY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PTR_PCF_PATHWAY getPATHWAY(int rep)
		{
			return (PTR_PCF_PATHWAY) this.get_Renamed("PATHWAY", rep);
		}
	}
}