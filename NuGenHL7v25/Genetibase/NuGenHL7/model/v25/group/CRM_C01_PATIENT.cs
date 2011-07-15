using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the CRM_C01_PATIENT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (Patient Identification) <b></b><br>
	/// 1: PV1 (Patient Visit) <b>optional </b><br>
	/// 2: CSR (Clinical Study Registration) <b></b><br>
	/// 3: CSP (Clinical Study Phase) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class CRM_C01_PATIENT:AbstractGroup
	{
		/// <summary> Returns PID (Patient Identification) - creates it if necessary</summary>
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
		/// <summary> Returns PV1 (Patient Visit) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns CSR (Clinical Study Registration) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of CSP </summary>
		virtual public int CSPReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CSP").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CRM_C01_PATIENT Group.</summary>
		public CRM_C01_PATIENT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PV1), false, false);
				this.add(typeof(CSR), true, false);
				this.add(typeof(CSP), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSP (Clinical Study Phase) - creates it if necessary</summary>
		public virtual CSP getCSP()
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
		
		/// <summary> Returns a specific repetition of CSP
		/// (Clinical Study Phase) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSP getCSP(int rep)
		{
			return (CSP) this.get_Renamed("CSP", rep);
		}
	}
}