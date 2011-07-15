using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the CSU_C09_CSSORCOBROBXORCRXARXR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: CSS (CSS - clinical study data schedule segment) <b>optional </b><br>
	/// 1: CSU_C09_ORCOBROBX (a Group object) <b>repeating</b><br>
	/// 2: CSU_C09_ORCRXARXR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09_CSSORCOBROBXORCRXARXR:AbstractGroup
	{
		/// <summary> Returns CSS (CSS - clinical study data schedule segment) - creates it if necessary</summary>
		virtual public CSS CSS
		{
			get
			{
				CSS ret = null;
				try
				{
					ret = (CSS) this.get_Renamed("CSS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_ORCOBROBX </summary>
		virtual public int ORCOBROBXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCOBROBX").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_ORCRXARXR </summary>
		virtual public int ORCRXARXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXARXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09_CSSORCOBROBXORCRXARXR Group.</summary>
		public CSU_C09_CSSORCOBROBXORCRXARXR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(CSS), false, false);
				this.add(typeof(CSU_C09_ORCOBROBX), true, true);
				this.add(typeof(CSU_C09_ORCRXARXR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSU_C09_ORCOBROBX (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_ORCOBROBX getORCOBROBX()
		{
			CSU_C09_ORCOBROBX ret = null;
			try
			{
				ret = (CSU_C09_ORCOBROBX) this.get_Renamed("ORCOBROBX");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_ORCOBROBX
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_ORCOBROBX getORCOBROBX(int rep)
		{
			return (CSU_C09_ORCOBROBX) this.get_Renamed("ORCOBROBX", rep);
		}
		
		/// <summary> Returns  first repetition of CSU_C09_ORCRXARXR (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_ORCRXARXR getORCRXARXR()
		{
			CSU_C09_ORCRXARXR ret = null;
			try
			{
				ret = (CSU_C09_ORCRXARXR) this.get_Renamed("ORCRXARXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_ORCRXARXR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_ORCRXARXR getORCRXARXR(int rep)
		{
			return (CSU_C09_ORCRXARXR) this.get_Renamed("ORCRXARXR", rep);
		}
	}
}