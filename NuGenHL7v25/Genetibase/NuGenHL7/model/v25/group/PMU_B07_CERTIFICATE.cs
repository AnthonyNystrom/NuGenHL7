using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PMU_B07_CERTIFICATE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: CER (Certificate Detail) <b></b><br>
	/// 1: ROL (Role) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PMU_B07_CERTIFICATE:AbstractGroup
	{
		/// <summary> Returns CER (Certificate Detail) - creates it if necessary</summary>
		virtual public CER CER
		{
			get
			{
				CER ret = null;
				try
				{
					ret = (CER) this.get_Renamed("CER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ROL </summary>
		virtual public int ROLReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ROL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PMU_B07_CERTIFICATE Group.</summary>
		public PMU_B07_CERTIFICATE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(CER), true, false);
				this.add(typeof(ROL), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ROL (Role) - creates it if necessary</summary>
		public virtual ROL getROL()
		{
			ROL ret = null;
			try
			{
				ret = (ROL) this.get_Renamed("ROL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ROL
		/// (Role) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ROL getROL(int rep)
		{
			return (ROL) this.get_Renamed("ROL", rep);
		}
	}
}