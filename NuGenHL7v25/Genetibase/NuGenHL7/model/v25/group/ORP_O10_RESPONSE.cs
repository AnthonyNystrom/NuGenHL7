using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORP_O10_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORP_O10_PATIENT (a Group object) <b>optional </b><br>
	/// 1: ORP_O10_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORP_O10_RESPONSE:AbstractGroup
	{
		/// <summary> Returns ORP_O10_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public ORP_O10_PATIENT PATIENT
		{
			get
			{
				ORP_O10_PATIENT ret = null;
				try
				{
					ret = (ORP_O10_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORP_O10_ORDER </summary>
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
		
		/// <summary> Creates a new ORP_O10_RESPONSE Group.</summary>
		public ORP_O10_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORP_O10_PATIENT), false, false);
				this.add(typeof(ORP_O10_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORP_O10_ORDER (a Group object) - creates it if necessary</summary>
		public virtual ORP_O10_ORDER getORDER()
		{
			ORP_O10_ORDER ret = null;
			try
			{
				ret = (ORP_O10_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORP_O10_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORP_O10_ORDER getORDER(int rep)
		{
			return (ORP_O10_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}