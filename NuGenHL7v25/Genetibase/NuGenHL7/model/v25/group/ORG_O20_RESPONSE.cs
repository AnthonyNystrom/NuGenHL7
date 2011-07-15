using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORG_O20_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORG_O20_PATIENT (a Group object) <b>optional </b><br>
	/// 1: ORG_O20_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORG_O20_RESPONSE:AbstractGroup
	{
		/// <summary> Returns ORG_O20_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public ORG_O20_PATIENT PATIENT
		{
			get
			{
				ORG_O20_PATIENT ret = null;
				try
				{
					ret = (ORG_O20_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORG_O20_ORDER </summary>
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
		
		/// <summary> Creates a new ORG_O20_RESPONSE Group.</summary>
		public ORG_O20_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORG_O20_PATIENT), false, false);
				this.add(typeof(ORG_O20_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORG_O20_ORDER (a Group object) - creates it if necessary</summary>
		public virtual ORG_O20_ORDER getORDER()
		{
			ORG_O20_ORDER ret = null;
			try
			{
				ret = (ORG_O20_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORG_O20_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORG_O20_ORDER getORDER(int rep)
		{
			return (ORG_O20_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}