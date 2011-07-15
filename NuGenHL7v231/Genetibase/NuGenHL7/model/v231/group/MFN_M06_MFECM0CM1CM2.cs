using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the MFN_M06_MFECM0CM1CM2 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (MFE - master file entry segment) <b></b><br>
	/// 1: CM0 (CM0 - clinical study master segment) <b></b><br>
	/// 2: MFN_M06_CM1CM2 (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFN_M06_MFECM0CM1CM2:AbstractGroup
	{
		/// <summary> Returns MFE (MFE - master file entry segment) - creates it if necessary</summary>
		virtual public MFE MFE
		{
			get
			{
				MFE ret = null;
				try
				{
					ret = (MFE) this.get_Renamed("MFE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns CM0 (CM0 - clinical study master segment) - creates it if necessary</summary>
		virtual public CM0 CM0
		{
			get
			{
				CM0 ret = null;
				try
				{
					ret = (CM0) this.get_Renamed("CM0");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of MFN_M06_CM1CM2 </summary>
		virtual public int CM1CM2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CM1CM2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFN_M06_MFECM0CM1CM2 Group.</summary>
		public MFN_M06_MFECM0CM1CM2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(CM0), true, false);
				this.add(typeof(MFN_M06_CM1CM2), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of MFN_M06_CM1CM2 (a Group object) - creates it if necessary</summary>
		public virtual MFN_M06_CM1CM2 getCM1CM2()
		{
			MFN_M06_CM1CM2 ret = null;
			try
			{
				ret = (MFN_M06_CM1CM2) this.get_Renamed("CM1CM2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of MFN_M06_CM1CM2
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual MFN_M06_CM1CM2 getCM1CM2(int rep)
		{
			return (MFN_M06_CM1CM2) this.get_Renamed("CM1CM2", rep);
		}
	}
}