using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the MFN_M06_MF_PHASE_SCHED_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: CM1 (Clinical Study Phase Master) <b></b><br>
	/// 1: CM2 (Clinical Study Schedule Master) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFN_M06_MF_PHASE_SCHED_DETAIL:AbstractGroup
	{
		/// <summary> Returns CM1 (Clinical Study Phase Master) - creates it if necessary</summary>
		virtual public CM1 CM1
		{
			get
			{
				CM1 ret = null;
				try
				{
					ret = (CM1) this.get_Renamed("CM1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CM2 </summary>
		virtual public int CM2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CM2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFN_M06_MF_PHASE_SCHED_DETAIL Group.</summary>
		public MFN_M06_MF_PHASE_SCHED_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(CM1), true, false);
				this.add(typeof(CM2), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CM2 (Clinical Study Schedule Master) - creates it if necessary</summary>
		public virtual CM2 getCM2()
		{
			CM2 ret = null;
			try
			{
				ret = (CM2) this.get_Renamed("CM2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CM2
		/// (Clinical Study Schedule Master) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CM2 getCM2(int rep)
		{
			return (CM2) this.get_Renamed("CM2", rep);
		}
	}
}