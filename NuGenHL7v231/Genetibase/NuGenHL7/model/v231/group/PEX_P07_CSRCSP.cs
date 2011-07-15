using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the PEX_P07_CSRCSP Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: CSR (CSR - clinical study registration segment) <b></b><br>
	/// 1: CSP (CSP - clinical study phase segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_CSRCSP:AbstractGroup
	{
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
		
		/// <summary> Creates a new PEX_P07_CSRCSP Group.</summary>
		public PEX_P07_CSRCSP(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(CSR), true, false);
				this.add(typeof(CSP), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSP (CSP - clinical study phase segment) - creates it if necessary</summary>
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
		/// (CSP - clinical study phase segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSP getCSP(int rep)
		{
			return (CSP) this.get_Renamed("CSP", rep);
		}
	}
}