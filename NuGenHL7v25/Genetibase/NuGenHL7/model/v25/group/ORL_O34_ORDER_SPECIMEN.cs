using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORL_O34_ORDER_SPECIMEN Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SPM (Specimen) <b></b><br>
	/// 1: SAC (Specimen Container detail) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORL_O34_ORDER_SPECIMEN:AbstractGroup
	{
		/// <summary> Returns SPM (Specimen) - creates it if necessary</summary>
		virtual public SPM SPM
		{
			get
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
			
		}
		/// <summary> Returns the number of existing repetitions of SAC </summary>
		virtual public int SACReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SAC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORL_O34_ORDER_SPECIMEN Group.</summary>
		public ORL_O34_ORDER_SPECIMEN(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SPM), true, false);
				this.add(typeof(SAC), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SAC (Specimen Container detail) - creates it if necessary</summary>
		public virtual SAC getSAC()
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
		
		/// <summary> Returns a specific repetition of SAC
		/// (Specimen Container detail) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SAC getSAC(int rep)
		{
			return (SAC) this.get_Renamed("SAC", rep);
		}
	}
}