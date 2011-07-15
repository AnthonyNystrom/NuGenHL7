using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RRA_O18_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RRA_O18_PATIENT (a Group object) <b>optional </b><br>
	/// 1: RRA_O18_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RRA_O18_RESPONSE:AbstractGroup
	{
		/// <summary> Returns RRA_O18_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public RRA_O18_PATIENT PATIENT
		{
			get
			{
				RRA_O18_PATIENT ret = null;
				try
				{
					ret = (RRA_O18_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RRA_O18_ORDER </summary>
		virtual public int ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RRA_O18_RESPONSE Group.</summary>
		public RRA_O18_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RRA_O18_PATIENT), false, false);
				this.add(typeof(RRA_O18_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRA_O18_ORDER (a Group object) - creates it if necessary</summary>
		public virtual RRA_O18_ORDER getORDER()
		{
			RRA_O18_ORDER ret = null;
			try
			{
				ret = (RRA_O18_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRA_O18_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRA_O18_ORDER getORDER(int rep)
		{
			return (RRA_O18_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}