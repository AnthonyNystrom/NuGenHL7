using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the MFN_M04_MF_CDM Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: CDM (Charge Description Master) <b></b><br>
	/// 2: PRC (Pricing) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFN_M04_MF_CDM:AbstractGroup
	{
		/// <summary> Returns MFE (Master File Entry) - creates it if necessary</summary>
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
		/// <summary> Returns CDM (Charge Description Master) - creates it if necessary</summary>
		virtual public CDM CDM
		{
			get
			{
				CDM ret = null;
				try
				{
					ret = (CDM) this.get_Renamed("CDM");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRC </summary>
		virtual public int PRCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFN_M04_MF_CDM Group.</summary>
		public MFN_M04_MF_CDM(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(CDM), true, false);
				this.add(typeof(PRC), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PRC (Pricing) - creates it if necessary</summary>
		public virtual PRC getPRC()
		{
			PRC ret = null;
			try
			{
				ret = (PRC) this.get_Renamed("PRC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRC
		/// (Pricing) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRC getPRC(int rep)
		{
			return (PRC) this.get_Renamed("PRC", rep);
		}
	}
}