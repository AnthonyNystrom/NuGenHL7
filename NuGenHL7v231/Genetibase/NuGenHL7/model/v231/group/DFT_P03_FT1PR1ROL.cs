using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the DFT_P03_FT1PR1ROL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: FT1 (FT1 - financial transaction segment) <b></b><br>
	/// 1: DFT_P03_PR1ROL (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class DFT_P03_FT1PR1ROL:AbstractGroup
	{
		/// <summary> Returns FT1 (FT1 - financial transaction segment) - creates it if necessary</summary>
		virtual public FT1 FT1
		{
			get
			{
				FT1 ret = null;
				try
				{
					ret = (FT1) this.get_Renamed("FT1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DFT_P03_PR1ROL </summary>
		virtual public int PR1ROLReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PR1ROL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new DFT_P03_FT1PR1ROL Group.</summary>
		public DFT_P03_FT1PR1ROL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(FT1), true, false);
				this.add(typeof(DFT_P03_PR1ROL), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of DFT_P03_PR1ROL (a Group object) - creates it if necessary</summary>
		public virtual DFT_P03_PR1ROL getPR1ROL()
		{
			DFT_P03_PR1ROL ret = null;
			try
			{
				ret = (DFT_P03_PR1ROL) this.get_Renamed("PR1ROL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DFT_P03_PR1ROL
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DFT_P03_PR1ROL getPR1ROL(int rep)
		{
			return (DFT_P03_PR1ROL) this.get_Renamed("PR1ROL", rep);
		}
	}
}