using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the DFT_P03_FINANCIAL_COMMON_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b>optional </b><br>
	/// 1: DFT_P03_FINANCIAL_ORDER (a Group object) <b>optional </b><br>
	/// 2: DFT_P03_FINANCIAL_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class DFT_P03_FINANCIAL_COMMON_ORDER:AbstractGroup
	{
		/// <summary> Returns ORC (Common Order) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns DFT_P03_FINANCIAL_ORDER (a Group object) - creates it if necessary</summary>
		virtual public DFT_P03_FINANCIAL_ORDER FINANCIAL_ORDER
		{
			get
			{
				DFT_P03_FINANCIAL_ORDER ret = null;
				try
				{
					ret = (DFT_P03_FINANCIAL_ORDER) this.get_Renamed("FINANCIAL_ORDER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DFT_P03_FINANCIAL_OBSERVATION </summary>
		virtual public int FINANCIAL_OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("FINANCIAL_OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new DFT_P03_FINANCIAL_COMMON_ORDER Group.</summary>
		public DFT_P03_FINANCIAL_COMMON_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), false, false);
				this.add(typeof(DFT_P03_FINANCIAL_ORDER), false, false);
				this.add(typeof(DFT_P03_FINANCIAL_OBSERVATION), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of DFT_P03_FINANCIAL_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual DFT_P03_FINANCIAL_OBSERVATION getFINANCIAL_OBSERVATION()
		{
			DFT_P03_FINANCIAL_OBSERVATION ret = null;
			try
			{
				ret = (DFT_P03_FINANCIAL_OBSERVATION) this.get_Renamed("FINANCIAL_OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DFT_P03_FINANCIAL_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DFT_P03_FINANCIAL_OBSERVATION getFINANCIAL_OBSERVATION(int rep)
		{
			return (DFT_P03_FINANCIAL_OBSERVATION) this.get_Renamed("FINANCIAL_OBSERVATION", rep);
		}
	}
}