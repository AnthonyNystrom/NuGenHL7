using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SQR_S25_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAIPNTEAILNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SCH (SCH - schedule activity information segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: SQR_S25_PIDPV1PV2DG1 (a Group object) <b>optional </b><br>
	/// 3: SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SQR_S25_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAIPNTEAILNTE:AbstractGroup
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
		/// <summary> Returns SQR_S25_PIDPV1PV2DG1 (a Group object) - creates it if necessary</summary>
		virtual public SQR_S25_PIDPV1PV2DG1 PIDPV1PV2DG1
		{
			get
			{
				SQR_S25_PIDPV1PV2DG1 ret = null;
				try
				{
					ret = (SQR_S25_PIDPV1PV2DG1) this.get_Renamed("PIDPV1PV2DG1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE </summary>
		virtual public int RGSAISNTEAIGNTEAIPNTEAILNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RGSAISNTEAIGNTEAIPNTEAILNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SQR_S25_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAIPNTEAILNTE Group.</summary>
		public SQR_S25_SCHNTEPIDPV1PV2DG1RGSAISNTEAIGNTEAIPNTEAILNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SCH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(SQR_S25_PIDPV1PV2DG1), false, false);
				this.add(typeof(SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE), true, true);
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
		
		/// <summary> Returns  first repetition of SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE (a Group object) - creates it if necessary</summary>
		public virtual SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE getRGSAISNTEAIGNTEAIPNTEAILNTE()
		{
			SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE ret = null;
			try
			{
				ret = (SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE) this.get_Renamed("RGSAISNTEAIGNTEAIPNTEAILNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE getRGSAISNTEAIGNTEAIPNTEAILNTE(int rep)
		{
			return (SQR_S25_RGSAISNTEAIGNTEAIPNTEAILNTE) this.get_Renamed("RGSAISNTEAIGNTEAIPNTEAILNTE", rep);
		}
	}
}