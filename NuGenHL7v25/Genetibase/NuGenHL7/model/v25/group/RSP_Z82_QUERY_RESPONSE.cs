using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RSP_Z82_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RSP_Z82_PATIENT (a Group object) <b>optional </b><br>
	/// 1: RSP_Z82_COMMON_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RSP_Z82_QUERY_RESPONSE:AbstractGroup
	{
		/// <summary> Returns RSP_Z82_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z82_PATIENT PATIENT
		{
			get
			{
				RSP_Z82_PATIENT ret = null;
				try
				{
					ret = (RSP_Z82_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RSP_Z82_COMMON_ORDER </summary>
		virtual public int COMMON_ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("COMMON_ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RSP_Z82_QUERY_RESPONSE Group.</summary>
		public RSP_Z82_QUERY_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RSP_Z82_PATIENT), false, false);
				this.add(typeof(RSP_Z82_COMMON_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RSP_Z82_COMMON_ORDER (a Group object) - creates it if necessary</summary>
		public virtual RSP_Z82_COMMON_ORDER getCOMMON_ORDER()
		{
			RSP_Z82_COMMON_ORDER ret = null;
			try
			{
				ret = (RSP_Z82_COMMON_ORDER) this.get_Renamed("COMMON_ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RSP_Z82_COMMON_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RSP_Z82_COMMON_ORDER getCOMMON_ORDER(int rep)
		{
			return (RSP_Z82_COMMON_ORDER) this.get_Renamed("COMMON_ORDER", rep);
		}
	}
}