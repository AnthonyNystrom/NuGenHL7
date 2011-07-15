using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RRG_O16_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RRG_O16_PATIENT (a Group object) <b>optional </b><br>
	/// 1: RRG_O16_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RRG_O16_RESPONSE:AbstractGroup
	{
		/// <summary> Returns RRG_O16_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public RRG_O16_PATIENT PATIENT
		{
			get
			{
				RRG_O16_PATIENT ret = null;
				try
				{
					ret = (RRG_O16_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RRG_O16_ORDER </summary>
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
		
		/// <summary> Creates a new RRG_O16_RESPONSE Group.</summary>
		public RRG_O16_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RRG_O16_PATIENT), false, false);
				this.add(typeof(RRG_O16_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRG_O16_ORDER (a Group object) - creates it if necessary</summary>
		public virtual RRG_O16_ORDER getORDER()
		{
			RRG_O16_ORDER ret = null;
			try
			{
				ret = (RRG_O16_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRG_O16_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRG_O16_ORDER getORDER(int rep)
		{
			return (RRG_O16_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}