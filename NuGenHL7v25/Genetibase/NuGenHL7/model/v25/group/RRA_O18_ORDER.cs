using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RRA_O18_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RRA_O18_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: RRA_O18_ADMINISTRATION (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRA_O18_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of RRA_O18_TIMING </summary>
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
		/// <summary> Returns RRA_O18_ADMINISTRATION (a Group object) - creates it if necessary</summary>
		virtual public RRA_O18_ADMINISTRATION ADMINISTRATION
		{
			get
			{
				RRA_O18_ADMINISTRATION ret = null;
				try
				{
					ret = (RRA_O18_ADMINISTRATION) this.get_Renamed("ADMINISTRATION");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRA_O18_ORDER Group.</summary>
		public RRA_O18_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRA_O18_TIMING), false, true);
				this.add(typeof(RRA_O18_ADMINISTRATION), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRA_O18_TIMING (a Group object) - creates it if necessary</summary>
		public virtual RRA_O18_TIMING getTIMING()
		{
			RRA_O18_TIMING ret = null;
			try
			{
				ret = (RRA_O18_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRA_O18_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRA_O18_TIMING getTIMING(int rep)
		{
			return (RRA_O18_TIMING) this.get_Renamed("TIMING", rep);
		}
	}
}