using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORP_O10_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: ORP_O10_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: ORP_O10_ORDER_DETAIL (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORP_O10_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of ORP_O10_TIMING </summary>
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
		/// <summary> Returns ORP_O10_ORDER_DETAIL (a Group object) - creates it if necessary</summary>
		virtual public ORP_O10_ORDER_DETAIL ORDER_DETAIL
		{
			get
			{
				ORP_O10_ORDER_DETAIL ret = null;
				try
				{
					ret = (ORP_O10_ORDER_DETAIL) this.get_Renamed("ORDER_DETAIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ORP_O10_ORDER Group.</summary>
		public ORP_O10_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(ORP_O10_TIMING), false, true);
				this.add(typeof(ORP_O10_ORDER_DETAIL), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORP_O10_TIMING (a Group object) - creates it if necessary</summary>
		public virtual ORP_O10_TIMING getTIMING()
		{
			ORP_O10_TIMING ret = null;
			try
			{
				ret = (ORP_O10_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORP_O10_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORP_O10_TIMING getTIMING(int rep)
		{
			return (ORP_O10_TIMING) this.get_Renamed("TIMING", rep);
		}
	}
}