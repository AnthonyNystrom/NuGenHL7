using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ORS_O02_PIDNTEORCRQDNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORS_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: ORS_O02_ORCRQDNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORS_O02_PIDNTEORCRQDNTE:AbstractGroup
	{
		/// <summary> Returns ORS_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public ORS_O02_PIDNTE PIDNTE
		{
			get
			{
				ORS_O02_PIDNTE ret = null;
				try
				{
					ret = (ORS_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORS_O02_ORCRQDNTE </summary>
		virtual public int ORCRQDNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRQDNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORS_O02_PIDNTEORCRQDNTE Group.</summary>
		public ORS_O02_PIDNTEORCRQDNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORS_O02_PIDNTE), false, false);
				this.add(typeof(ORS_O02_ORCRQDNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORS_O02_ORCRQDNTE (a Group object) - creates it if necessary</summary>
		public virtual ORS_O02_ORCRQDNTE getORCRQDNTE()
		{
			ORS_O02_ORCRQDNTE ret = null;
			try
			{
				ret = (ORS_O02_ORCRQDNTE) this.get_Renamed("ORCRQDNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORS_O02_ORCRQDNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORS_O02_ORCRQDNTE getORCRQDNTE(int rep)
		{
			return (ORS_O02_ORCRQDNTE) this.get_Renamed("ORCRQDNTE", rep);
		}
	}
}