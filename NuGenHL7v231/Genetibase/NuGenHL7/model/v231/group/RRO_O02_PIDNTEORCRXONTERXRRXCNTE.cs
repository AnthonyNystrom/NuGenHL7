using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRO_O02_PIDNTEORCRXONTERXRRXCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RRO_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: RRO_O02_ORCRXONTERXRRXCNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RRO_O02_PIDNTEORCRXONTERXRRXCNTE:AbstractGroup
	{
		/// <summary> Returns RRO_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public RRO_O02_PIDNTE PIDNTE
		{
			get
			{
				RRO_O02_PIDNTE ret = null;
				try
				{
					ret = (RRO_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RRO_O02_ORCRXONTERXRRXCNTE </summary>
		virtual public int ORCRXONTERXRRXCNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXONTERXRRXCNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RRO_O02_PIDNTEORCRXONTERXRRXCNTE Group.</summary>
		public RRO_O02_PIDNTEORCRXONTERXRRXCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RRO_O02_PIDNTE), false, false);
				this.add(typeof(RRO_O02_ORCRXONTERXRRXCNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RRO_O02_ORCRXONTERXRRXCNTE (a Group object) - creates it if necessary</summary>
		public virtual RRO_O02_ORCRXONTERXRRXCNTE getORCRXONTERXRRXCNTE()
		{
			RRO_O02_ORCRXONTERXRRXCNTE ret = null;
			try
			{
				ret = (RRO_O02_ORCRXONTERXRRXCNTE) this.get_Renamed("ORCRXONTERXRRXCNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RRO_O02_ORCRXONTERXRRXCNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RRO_O02_ORCRXONTERXRRXCNTE getORCRXONTERXRRXCNTE(int rep)
		{
			return (RRO_O02_ORCRXONTERXRRXCNTE) this.get_Renamed("ORCRXONTERXRRXCNTE", rep);
		}
	}
}