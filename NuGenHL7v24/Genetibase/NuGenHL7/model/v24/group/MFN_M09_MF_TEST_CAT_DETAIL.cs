using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the MFN_M09_MF_TEST_CAT_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OM3 (Categorical Service/Test/Observation) <b></b><br>
	/// 1: OM4 (Observations that Require Specimens) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFN_M09_MF_TEST_CAT_DETAIL:AbstractGroup
	{
		/// <summary> Returns OM3 (Categorical Service/Test/Observation) - creates it if necessary</summary>
		virtual public OM3 OM3
		{
			get
			{
				OM3 ret = null;
				try
				{
					ret = (OM3) this.get_Renamed("OM3");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OM4 </summary>
		virtual public int OM4Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OM4").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFN_M09_MF_TEST_CAT_DETAIL Group.</summary>
		public MFN_M09_MF_TEST_CAT_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OM3), true, false);
				this.add(typeof(OM4), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OM4 (Observations that Require Specimens) - creates it if necessary</summary>
		public virtual OM4 getOM4()
		{
			OM4 ret = null;
			try
			{
				ret = (OM4) this.get_Renamed("OM4");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OM4
		/// (Observations that Require Specimens) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OM4 getOM4(int rep)
		{
			return (OM4) this.get_Renamed("OM4", rep);
		}
	}
}