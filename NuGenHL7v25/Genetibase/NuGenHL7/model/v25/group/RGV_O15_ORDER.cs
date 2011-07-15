using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RGV_O15_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RGV_O15_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: RGV_O15_ORDER_DETAIL (a Group object) <b>optional </b><br>
	/// 3: RGV_O15_ENCODING (a Group object) <b>optional </b><br>
	/// 4: RGV_O15_GIVE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RGV_O15_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of RGV_O15_TIMING </summary>
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
		/// <summary> Returns RGV_O15_ORDER_DETAIL (a Group object) - creates it if necessary</summary>
		virtual public RGV_O15_ORDER_DETAIL ORDER_DETAIL
		{
			get
			{
				RGV_O15_ORDER_DETAIL ret = null;
				try
				{
					ret = (RGV_O15_ORDER_DETAIL) this.get_Renamed("ORDER_DETAIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RGV_O15_ENCODING (a Group object) - creates it if necessary</summary>
		virtual public RGV_O15_ENCODING ENCODING
		{
			get
			{
				RGV_O15_ENCODING ret = null;
				try
				{
					ret = (RGV_O15_ENCODING) this.get_Renamed("ENCODING");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RGV_O15_GIVE </summary>
		virtual public int GIVEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GIVE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RGV_O15_ORDER Group.</summary>
		public RGV_O15_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RGV_O15_TIMING), false, true);
				this.add(typeof(RGV_O15_ORDER_DETAIL), false, false);
				this.add(typeof(RGV_O15_ENCODING), false, false);
				this.add(typeof(RGV_O15_GIVE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RGV_O15_TIMING (a Group object) - creates it if necessary</summary>
		public virtual RGV_O15_TIMING getTIMING()
		{
			RGV_O15_TIMING ret = null;
			try
			{
				ret = (RGV_O15_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGV_O15_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGV_O15_TIMING getTIMING(int rep)
		{
			return (RGV_O15_TIMING) this.get_Renamed("TIMING", rep);
		}
		
		/// <summary> Returns  first repetition of RGV_O15_GIVE (a Group object) - creates it if necessary</summary>
		public virtual RGV_O15_GIVE getGIVE()
		{
			RGV_O15_GIVE ret = null;
			try
			{
				ret = (RGV_O15_GIVE) this.get_Renamed("GIVE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGV_O15_GIVE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGV_O15_GIVE getGIVE(int rep)
		{
			return (RGV_O15_GIVE) this.get_Renamed("GIVE", rep);
		}
	}
}