using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the BRP_O30_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: BRP_O30_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: BPO (Blood product order) <b>optional </b><br>
	/// 3: BPX (Blood product dispense status) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class BRP_O30_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of BRP_O30_TIMING </summary>
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
		/// <summary> Returns the number of existing repetitions of BPX </summary>
		virtual public int BPXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("BPX").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new BRP_O30_ORDER Group.</summary>
		public BRP_O30_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(BRP_O30_TIMING), false, true);
				this.add(typeof(BPO), false, false);
				this.add(typeof(BPX), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of BRP_O30_TIMING (a Group object) - creates it if necessary</summary>
		public virtual BRP_O30_TIMING getTIMING()
		{
			BRP_O30_TIMING ret = null;
			try
			{
				ret = (BRP_O30_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BRP_O30_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BRP_O30_TIMING getTIMING(int rep)
		{
			return (BRP_O30_TIMING) this.get_Renamed("TIMING", rep);
		}
		
		/// <summary> Returns  first repetition of BPX (Blood product dispense status) - creates it if necessary</summary>
		public virtual BPX getBPX()
		{
			BPX ret = null;
			try
			{
				ret = (BPX) this.get_Renamed("BPX");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BPX
		/// (Blood product dispense status) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BPX getBPX(int rep)
		{
			return (BPX) this.get_Renamed("BPX", rep);
		}
	}
}