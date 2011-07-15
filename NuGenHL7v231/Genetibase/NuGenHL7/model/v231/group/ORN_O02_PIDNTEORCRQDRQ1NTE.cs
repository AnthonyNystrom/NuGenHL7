using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ORN_O02_PIDNTEORCRQDRQ1NTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORN_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: ORN_O02_ORCRQDRQ1NTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORN_O02_PIDNTEORCRQDRQ1NTE:AbstractGroup
	{
		/// <summary> Returns ORN_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public ORN_O02_PIDNTE PIDNTE
		{
			get
			{
				ORN_O02_PIDNTE ret = null;
				try
				{
					ret = (ORN_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORN_O02_ORCRQDRQ1NTE </summary>
		virtual public int ORCRQDRQ1NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRQDRQ1NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORN_O02_PIDNTEORCRQDRQ1NTE Group.</summary>
		public ORN_O02_PIDNTEORCRQDRQ1NTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORN_O02_PIDNTE), false, false);
				this.add(typeof(ORN_O02_ORCRQDRQ1NTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORN_O02_ORCRQDRQ1NTE (a Group object) - creates it if necessary</summary>
		public virtual ORN_O02_ORCRQDRQ1NTE getORCRQDRQ1NTE()
		{
			ORN_O02_ORCRQDRQ1NTE ret = null;
			try
			{
				ret = (ORN_O02_ORCRQDRQ1NTE) this.get_Renamed("ORCRQDRQ1NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORN_O02_ORCRQDRQ1NTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORN_O02_ORCRQDRQ1NTE getORCRQDRQ1NTE(int rep)
		{
			return (ORN_O02_ORCRQDRQ1NTE) this.get_Renamed("ORCRQDRQ1NTE", rep);
		}
	}
}