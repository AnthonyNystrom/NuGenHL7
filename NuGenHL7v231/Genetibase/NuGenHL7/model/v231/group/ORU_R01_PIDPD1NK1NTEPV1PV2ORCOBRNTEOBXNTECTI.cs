using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ORU_R01_PIDPD1NK1NTEPV1PV2ORCOBRNTEOBXNTECTI Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORU_R01_PIDPD1NK1NTEPV1PV2 (a Group object) <b>optional </b><br>
	/// 1: ORU_R01_ORCOBRNTEOBXNTECTI (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORU_R01_PIDPD1NK1NTEPV1PV2ORCOBRNTEOBXNTECTI:AbstractGroup
	{
		/// <summary> Returns ORU_R01_PIDPD1NK1NTEPV1PV2 (a Group object) - creates it if necessary</summary>
		virtual public ORU_R01_PIDPD1NK1NTEPV1PV2 PIDPD1NK1NTEPV1PV2
		{
			get
			{
				ORU_R01_PIDPD1NK1NTEPV1PV2 ret = null;
				try
				{
					ret = (ORU_R01_PIDPD1NK1NTEPV1PV2) this.get_Renamed("PIDPD1NK1NTEPV1PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORU_R01_ORCOBRNTEOBXNTECTI </summary>
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
		
		/// <summary> Creates a new ORU_R01_PIDPD1NK1NTEPV1PV2ORCOBRNTEOBXNTECTI Group.</summary>
		public ORU_R01_PIDPD1NK1NTEPV1PV2ORCOBRNTEOBXNTECTI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORU_R01_PIDPD1NK1NTEPV1PV2), false, false);
				this.add(typeof(ORU_R01_ORCOBRNTEOBXNTECTI), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORU_R01_ORCOBRNTEOBXNTECTI (a Group object) - creates it if necessary</summary>
		public virtual ORU_R01_ORCOBRNTEOBXNTECTI getORCOBRNTEOBXNTECTI()
		{
			ORU_R01_ORCOBRNTEOBXNTECTI ret = null;
			try
			{
				ret = (ORU_R01_ORCOBRNTEOBXNTECTI) this.get_Renamed("ORCOBRNTEOBXNTECTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORU_R01_ORCOBRNTEOBXNTECTI
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORU_R01_ORCOBRNTEOBXNTECTI getORCOBRNTEOBXNTECTI(int rep)
		{
			return (ORU_R01_ORCOBRNTEOBXNTECTI) this.get_Renamed("ORCOBRNTEOBXNTECTI", rep);
		}
	}
}