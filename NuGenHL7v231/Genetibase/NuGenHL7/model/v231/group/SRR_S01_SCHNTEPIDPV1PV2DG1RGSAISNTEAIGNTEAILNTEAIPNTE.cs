using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SCH (SCH - schedule activity information segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: SRR_S01_PIDPV1PV2DG1 (a Group object) <b>optional repeating</b><br>
	/// 3: SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE:AbstractGroup
	{
		/// <summary> Returns SCH (SCH - schedule activity information segment) - creates it if necessary</summary>
		virtual public SCH SCH
		{
			get
			{
				SCH ret = null;
				try
				{
					ret = (SCH) this.get_Renamed("SCH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRR_S01_PIDPV1PV2DG1 </summary>
		virtual public int PIDPV1PV2DG1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PIDPV1PV2DG1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE </summary>
		virtual public int RGSAISNTEAIGNTEAILNTEAIPNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RGSAISNTEAIGNTEAILNTEAIPNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE Group.</summary>
		public SRR_S01_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAILNTEAIPNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SCH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(SRR_S01_PIDPV1PV2DG1), false, true);
				this.add(typeof(SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of SRR_S01_PIDPV1PV2DG1 (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_PIDPV1PV2DG1 getPIDPV1PV2DG1()
		{
			SRR_S01_PIDPV1PV2DG1 ret = null;
			try
			{
				ret = (SRR_S01_PIDPV1PV2DG1) this.get_Renamed("PIDPV1PV2DG1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_PIDPV1PV2DG1
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_PIDPV1PV2DG1 getPIDPV1PV2DG1(int rep)
		{
			return (SRR_S01_PIDPV1PV2DG1) this.get_Renamed("PIDPV1PV2DG1", rep);
		}
		
		/// <summary> Returns  first repetition of SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE getRGSAISNTEAIGNTEAILNTEAIPNTE()
		{
			SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE ret = null;
			try
			{
				ret = (SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE) this.get_Renamed("RGSAISNTEAIGNTEAILNTEAIPNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE getRGSAISNTEAIGNTEAILNTEAIPNTE(int rep)
		{
			return (SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE) this.get_Renamed("RGSAISNTEAIGNTEAILNTEAIPNTE", rep);
		}
	}
}