using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the BPS_O29_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: BPS_O29_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: BPO (Blood product order) <b></b><br>
	/// 3: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 4: BPS_O29_PRODUCT (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class BPS_O29_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of BPS_O29_TIMING </summary>
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
		/// <summary> Returns the number of existing repetitions of BPS_O29_PRODUCT </summary>
		virtual public int PRODUCTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRODUCT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new BPS_O29_ORDER Group.</summary>
		public BPS_O29_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(BPS_O29_TIMING), false, true);
				this.add(typeof(BPO), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(BPS_O29_PRODUCT), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of BPS_O29_TIMING (a Group object) - creates it if necessary</summary>
		public virtual BPS_O29_TIMING getTIMING()
		{
			BPS_O29_TIMING ret = null;
			try
			{
				ret = (BPS_O29_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BPS_O29_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BPS_O29_TIMING getTIMING(int rep)
		{
			return (BPS_O29_TIMING) this.get_Renamed("TIMING", rep);
		}
		
		/// <summary> Returns  first repetition of NTE (Notes and Comments) - creates it if necessary</summary>
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
		/// (Notes and Comments) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of BPS_O29_PRODUCT (a Group object) - creates it if necessary</summary>
		public virtual BPS_O29_PRODUCT getPRODUCT()
		{
			BPS_O29_PRODUCT ret = null;
			try
			{
				ret = (BPS_O29_PRODUCT) this.get_Renamed("PRODUCT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BPS_O29_PRODUCT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BPS_O29_PRODUCT getPRODUCT(int rep)
		{
			return (BPS_O29_PRODUCT) this.get_Renamed("PRODUCT", rep);
		}
	}
}