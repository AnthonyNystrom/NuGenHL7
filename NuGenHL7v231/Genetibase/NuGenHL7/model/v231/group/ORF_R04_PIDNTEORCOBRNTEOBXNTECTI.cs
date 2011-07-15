using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ORF_R04_PIDNTEORCOBRNTEOBXNTECTI Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORF_R04_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: ORF_R04_ORCOBRNTEOBXNTECTI (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORF_R04_PIDNTEORCOBRNTEOBXNTECTI:AbstractGroup
	{
		/// <summary> Returns ORF_R04_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public ORF_R04_PIDNTE PIDNTE
		{
			get
			{
				ORF_R04_PIDNTE ret = null;
				try
				{
					ret = (ORF_R04_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORF_R04_ORCOBRNTEOBXNTECTI </summary>
		virtual public int ORCOBRNTEOBXNTECTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCOBRNTEOBXNTECTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORF_R04_PIDNTEORCOBRNTEOBXNTECTI Group.</summary>
		public ORF_R04_PIDNTEORCOBRNTEOBXNTECTI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORF_R04_PIDNTE), false, false);
				this.add(typeof(ORF_R04_ORCOBRNTEOBXNTECTI), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORF_R04_ORCOBRNTEOBXNTECTI (a Group object) - creates it if necessary</summary>
		public virtual ORF_R04_ORCOBRNTEOBXNTECTI getORCOBRNTEOBXNTECTI()
		{
			ORF_R04_ORCOBRNTEOBXNTECTI ret = null;
			try
			{
				ret = (ORF_R04_ORCOBRNTEOBXNTECTI) this.get_Renamed("ORCOBRNTEOBXNTECTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORF_R04_ORCOBRNTEOBXNTECTI
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORF_R04_ORCOBRNTEOBXNTECTI getORCOBRNTEOBXNTECTI(int rep)
		{
			return (ORF_R04_ORCOBRNTEOBXNTECTI) this.get_Renamed("ORCOBRNTEOBXNTECTI", rep);
		}
	}
}