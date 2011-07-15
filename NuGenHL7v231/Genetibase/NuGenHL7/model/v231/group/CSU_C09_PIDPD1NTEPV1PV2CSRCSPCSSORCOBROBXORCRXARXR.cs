using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (PID - patient identification segment) <b></b><br>
	/// 1: PD1 (PD1 - patient additional demographic segment) <b>optional </b><br>
	/// 2: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 3: CSU_C09_PV1PV2 (a Group object) <b>optional </b><br>
	/// 4: CSR (CSR - clinical study registration segment) <b></b><br>
	/// 5: CSU_C09_CSPCSSORCOBROBXORCRXARXR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR:AbstractGroup
	{
		/// <summary> Returns PID (PID - patient identification segment) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary</summary>
		virtual public PD1 PD1
		{
			get
			{
				PD1 ret = null;
				try
				{
					ret = (PD1) this.get_Renamed("PD1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns CSU_C09_PV1PV2 (a Group object) - creates it if necessary</summary>
		virtual public CSU_C09_PV1PV2 PV1PV2
		{
			get
			{
				CSU_C09_PV1PV2 ret = null;
				try
				{
					ret = (CSU_C09_PV1PV2) this.get_Renamed("PV1PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns CSR (CSR - clinical study registration segment) - creates it if necessary</summary>
		virtual public CSR CSR
		{
			get
			{
				CSR ret = null;
				try
				{
					ret = (CSR) this.get_Renamed("CSR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CSU_C09_CSPCSSORCOBROBXORCRXARXR </summary>
		virtual public int CSPCSSORCOBROBXORCRXARXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CSPCSSORCOBROBXORCRXARXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR Group.</summary>
		public CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(CSU_C09_PV1PV2), false, false);
				this.add(typeof(CSR), true, false);
				this.add(typeof(CSU_C09_CSPCSSORCOBROBXORCRXARXR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of CSU_C09_CSPCSSORCOBROBXORCRXARXR (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_CSPCSSORCOBROBXORCRXARXR getCSPCSSORCOBROBXORCRXARXR()
		{
			CSU_C09_CSPCSSORCOBROBXORCRXARXR ret = null;
			try
			{
				ret = (CSU_C09_CSPCSSORCOBROBXORCRXARXR) this.get_Renamed("CSPCSSORCOBROBXORCRXARXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_CSPCSSORCOBROBXORCRXARXR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_CSPCSSORCOBROBXORCRXARXR getCSPCSSORCOBROBXORCRXARXR(int rep)
		{
			return (CSU_C09_CSPCSSORCOBROBXORCRXARXR) this.get_Renamed("CSPCSSORCOBROBXORCRXARXR", rep);
		}
	}
}