using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the DFT_P03_COMMON_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b>optional </b><br>
	/// 1: DFT_P03_TIMING_QUANTITY (a Group object) <b>optional repeating</b><br>
	/// 2: DFT_P03_ORDER (a Group object) <b>optional </b><br>
	/// 3: DFT_P03_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class DFT_P03_COMMON_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of DFT_P03_TIMING_QUANTITY </summary>
		virtual public int TIMING_QUANTITYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING_QUANTITY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns DFT_P03_ORDER (a Group object) - creates it if necessary</summary>
		virtual public DFT_P03_ORDER ORDER
		{
			get
			{
				DFT_P03_ORDER ret = null;
				try
				{
					ret = (DFT_P03_ORDER) this.get_Renamed("ORDER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DFT_P03_OBSERVATION </summary>
		virtual public int OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new DFT_P03_COMMON_ORDER Group.</summary>
		public DFT_P03_COMMON_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), false, false);
				this.add(typeof(DFT_P03_TIMING_QUANTITY), false, true);
				this.add(typeof(DFT_P03_ORDER), false, false);
				this.add(typeof(DFT_P03_OBSERVATION), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of DFT_P03_TIMING_QUANTITY (a Group object) - creates it if necessary</summary>
		public virtual DFT_P03_TIMING_QUANTITY getTIMING_QUANTITY()
		{
			DFT_P03_TIMING_QUANTITY ret = null;
			try
			{
				ret = (DFT_P03_TIMING_QUANTITY) this.get_Renamed("TIMING_QUANTITY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DFT_P03_TIMING_QUANTITY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DFT_P03_TIMING_QUANTITY getTIMING_QUANTITY(int rep)
		{
			return (DFT_P03_TIMING_QUANTITY) this.get_Renamed("TIMING_QUANTITY", rep);
		}
		
		/// <summary> Returns  first repetition of DFT_P03_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual DFT_P03_OBSERVATION getOBSERVATION()
		{
			DFT_P03_OBSERVATION ret = null;
			try
			{
				ret = (DFT_P03_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DFT_P03_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DFT_P03_OBSERVATION getOBSERVATION(int rep)
		{
			return (DFT_P03_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}