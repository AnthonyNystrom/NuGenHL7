using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ORR_O02_PIDNTEORCOBRRQDRQ1RXOODSODTNTECTI Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORR_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORR_O02_PIDNTEORCOBRRQDRQ1RXOODSODTNTECTI:AbstractGroup
	{
		/// <summary> Returns ORR_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public ORR_O02_PIDNTE PIDNTE
		{
			get
			{
				ORR_O02_PIDNTE ret = null;
				try
				{
					ret = (ORR_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI </summary>
		virtual public int ORCOBRRQDRQ1RXOODSODTNTECTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCOBRRQDRQ1RXOODSODTNTECTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORR_O02_PIDNTEORCOBRRQDRQ1RXOODSODTNTECTI Group.</summary>
		public ORR_O02_PIDNTEORCOBRRQDRQ1RXOODSODTNTECTI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORR_O02_PIDNTE), false, false);
				this.add(typeof(ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI (a Group object) - creates it if necessary</summary>
		public virtual ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI getORCOBRRQDRQ1RXOODSODTNTECTI()
		{
			ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI ret = null;
			try
			{
				ret = (ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI) this.get_Renamed("ORCOBRRQDRQ1RXOODSODTNTECTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI getORCOBRRQDRQ1RXOODSODTNTECTI(int rep)
		{
			return (ORR_O02_ORCOBRRQDRQ1RXOODSODTNTECTI) this.get_Renamed("ORCOBRRQDRQ1RXOODSODTNTECTI", rep);
		}
	}
}