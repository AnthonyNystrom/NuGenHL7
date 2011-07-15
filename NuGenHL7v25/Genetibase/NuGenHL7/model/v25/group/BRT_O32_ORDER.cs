using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the BRT_O32_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: BRT_O32_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: BPO (Blood product order) <b>optional </b><br>
	/// 3: BTX (Blood Product Transfusion/Disposition) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class BRT_O32_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of BRT_O32_TIMING </summary>
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
		/// <summary> Returns BPO (Blood product order) - creates it if necessary</summary>
		virtual public BPO BPO
		{
			get
			{
				BPO ret = null;
				try
				{
					ret = (BPO) this.get_Renamed("BPO");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of BTX </summary>
		virtual public int BTXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("BTX").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new BRT_O32_ORDER Group.</summary>
		public BRT_O32_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(BRT_O32_TIMING), false, true);
				this.add(typeof(BPO), false, false);
				this.add(typeof(BTX), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of BRT_O32_TIMING (a Group object) - creates it if necessary</summary>
		public virtual BRT_O32_TIMING getTIMING()
		{
			BRT_O32_TIMING ret = null;
			try
			{
				ret = (BRT_O32_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BRT_O32_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BRT_O32_TIMING getTIMING(int rep)
		{
			return (BRT_O32_TIMING) this.get_Renamed("TIMING", rep);
		}
		
		/// <summary> Returns  first repetition of BTX (Blood Product Transfusion/Disposition) - creates it if necessary</summary>
		public virtual BTX getBTX()
		{
			BTX ret = null;
			try
			{
				ret = (BTX) this.get_Renamed("BTX");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BTX
		/// (Blood Product Transfusion/Disposition) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BTX getBTX(int rep)
		{
			return (BTX) this.get_Renamed("BTX", rep);
		}
	}
}