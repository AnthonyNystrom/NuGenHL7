using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the CSU_C09_CSPCSSORCOBROBXORCRXARXR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: CSP (CSP - clinical study phase segment) <b>optional </b><br>
	/// 1: CSU_C09_CSSORCOBROBXORCRXARXR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09_CSPCSSORCOBROBXORCRXARXR:AbstractGroup
	{
		/// <summary> Returns CSP (CSP - clinical study phase segment) - creates it if necessary</summary>
		virtual public CSP CSP
		{
			get
			{
				CSP ret = null;
				try
				{
					ret = (CSP) this.get_Renamed("CSP");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_CSSORCOBROBXORCRXARXR </summary>
		virtual public int CSSORCOBROBXORCRXARXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CSSORCOBROBXORCRXARXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09_CSPCSSORCOBROBXORCRXARXR Group.</summary>
		public CSU_C09_CSPCSSORCOBROBXORCRXARXR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(CSP), false, false);
				this.add(typeof(CSU_C09_CSSORCOBROBXORCRXARXR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSU_C09_CSSORCOBROBXORCRXARXR (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_CSSORCOBROBXORCRXARXR getCSSORCOBROBXORCRXARXR()
		{
			CSU_C09_CSSORCOBROBXORCRXARXR ret = null;
			try
			{
				ret = (CSU_C09_CSSORCOBROBXORCRXARXR) this.get_Renamed("CSSORCOBROBXORCRXARXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_CSSORCOBROBXORCRXARXR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_CSSORCOBROBXORCRXARXR getCSSORCOBROBXORCRXARXR(int rep)
		{
			return (CSU_C09_CSSORCOBROBXORCRXARXR) this.get_Renamed("CSSORCOBROBXORCRXARXR", rep);
		}
	}
}