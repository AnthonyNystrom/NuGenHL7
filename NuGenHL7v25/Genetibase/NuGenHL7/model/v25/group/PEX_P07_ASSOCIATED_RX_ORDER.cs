using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PEX_P07_ASSOCIATED_RX_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXE (Pharmacy/Treatment Encoded Order) <b></b><br>
	/// 1: PEX_P07_NK1_TIMING_QTY (a Group object) <b>repeating</b><br>
	/// 2: RXR (Pharmacy/Treatment Route) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_ASSOCIATED_RX_ORDER:AbstractGroup
	{
		/// <summary> Returns RXE (Pharmacy/Treatment Encoded Order) - creates it if necessary</summary>
		virtual public RXE RXE
		{
			get
			{
				RXE ret = null;
				try
				{
					ret = (RXE) this.get_Renamed("RXE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PEX_P07_NK1_TIMING_QTY </summary>
		virtual public int NK1_TIMING_QTYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NK1_TIMING_QTY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RXR </summary>
		virtual public int RXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PEX_P07_ASSOCIATED_RX_ORDER Group.</summary>
		public PEX_P07_ASSOCIATED_RX_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXE), true, false);
				this.add(typeof(PEX_P07_NK1_TIMING_QTY), true, true);
				this.add(typeof(RXR), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PEX_P07_NK1_TIMING_QTY (a Group object) - creates it if necessary</summary>
		public virtual PEX_P07_NK1_TIMING_QTY getNK1_TIMING_QTY()
		{
			PEX_P07_NK1_TIMING_QTY ret = null;
			try
			{
				ret = (PEX_P07_NK1_TIMING_QTY) this.get_Renamed("NK1_TIMING_QTY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PEX_P07_NK1_TIMING_QTY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PEX_P07_NK1_TIMING_QTY getNK1_TIMING_QTY(int rep)
		{
			return (PEX_P07_NK1_TIMING_QTY) this.get_Renamed("NK1_TIMING_QTY", rep);
		}
		
		/// <summary> Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary</summary>
		public virtual RXR getRXR()
		{
			RXR ret = null;
			try
			{
				ret = (RXR) this.get_Renamed("RXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RXR
		/// (Pharmacy/Treatment Route) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXR getRXR(int rep)
		{
			return (RXR) this.get_Renamed("RXR", rep);
		}
	}
}