using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the VXU_V04_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: VXU_V04_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: RXA (Pharmacy/Treatment Administration) <b></b><br>
	/// 3: RXR (Pharmacy/Treatment Route) <b>optional </b><br>
	/// 4: VXU_V04_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class VXU_V04_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of VXU_V04_TIMING </summary>
		virtual public int TIMINGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RXA (Pharmacy/Treatment Administration) - creates it if necessary</summary>
		virtual public RXA RXA
		{
			get
			{
				RXA ret = null;
				try
				{
					ret = (RXA) this.get_Renamed("RXA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RXR (Pharmacy/Treatment Route) - creates it if necessary</summary>
		virtual public RXR RXR
		{
			get
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
			
		}
		/// <summary> Returns the number of existing repetitions of VXU_V04_OBSERVATION </summary>
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
		
		/// <summary> Creates a new VXU_V04_ORDER Group.</summary>
		public VXU_V04_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(VXU_V04_TIMING), false, true);
				this.add(typeof(RXA), true, false);
				this.add(typeof(RXR), false, false);
				this.add(typeof(VXU_V04_OBSERVATION), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of VXU_V04_TIMING (a Group object) - creates it if necessary</summary>
		public virtual VXU_V04_TIMING getTIMING()
		{
			VXU_V04_TIMING ret = null;
			try
			{
				ret = (VXU_V04_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of VXU_V04_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual VXU_V04_TIMING getTIMING(int rep)
		{
			return (VXU_V04_TIMING) this.get_Renamed("TIMING", rep);
		}
		
		/// <summary> Returns  first repetition of VXU_V04_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual VXU_V04_OBSERVATION getOBSERVATION()
		{
			VXU_V04_OBSERVATION ret = null;
			try
			{
				ret = (VXU_V04_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of VXU_V04_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual VXU_V04_OBSERVATION getOBSERVATION(int rep)
		{
			return (VXU_V04_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}