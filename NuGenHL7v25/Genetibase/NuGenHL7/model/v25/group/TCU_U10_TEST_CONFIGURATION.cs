using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the TCU_U10_TEST_CONFIGURATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SPM (Specimen) <b>optional </b><br>
	/// 1: TCC (Test Code Configuration) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class TCU_U10_TEST_CONFIGURATION:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of TCC </summary>
		virtual public int TCCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TCC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new TCU_U10_TEST_CONFIGURATION Group.</summary>
		public TCU_U10_TEST_CONFIGURATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SPM), false, false);
				this.add(typeof(TCC), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of TCC (Test Code Configuration) - creates it if necessary</summary>
		public virtual TCC getTCC()
		{
			TCC ret = null;
			try
			{
				ret = (TCC) this.get_Renamed("TCC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of TCC
		/// (Test Code Configuration) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual TCC getTCC(int rep)
		{
			return (TCC) this.get_Renamed("TCC", rep);
		}
	}
}