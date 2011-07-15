using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the SSR_U04_SPECIMEN_CONTAINER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SAC (Specimen Container detail) <b></b><br>
	/// 1: SPM (Specimen) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class SSR_U04_SPECIMEN_CONTAINER:AbstractGroup
	{
		/// <summary> Returns SAC (Specimen Container detail) - creates it if necessary</summary>
		virtual public SAC SAC
		{
			get
			{
				SAC ret = null;
				try
				{
					ret = (SAC) this.get_Renamed("SAC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SPM </summary>
		virtual public int SPMReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SPM").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SSR_U04_SPECIMEN_CONTAINER Group.</summary>
		public SSR_U04_SPECIMEN_CONTAINER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SAC), true, false);
				this.add(typeof(SPM), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SPM (Specimen) - creates it if necessary</summary>
		public virtual SPM getSPM()
		{
			SPM ret = null;
			try
			{
				ret = (SPM) this.get_Renamed("SPM");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SPM
		/// (Specimen) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SPM getSPM(int rep)
		{
			return (SPM) this.get_Renamed("SPM", rep);
		}
	}
}