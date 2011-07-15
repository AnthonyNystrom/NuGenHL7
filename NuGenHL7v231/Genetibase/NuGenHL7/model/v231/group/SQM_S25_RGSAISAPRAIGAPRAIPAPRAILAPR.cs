using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RGS (RGS - resource group segment) <b></b><br>
	/// 1: SQM_S25_AISAPR (a Group object) <b>optional repeating</b><br>
	/// 2: SQM_S25_AIGAPR (a Group object) <b>optional repeating</b><br>
	/// 3: SQM_S25_AIPAPR (a Group object) <b>optional repeating</b><br>
	/// 4: SQM_S25_AILAPR (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR:AbstractGroup
	{
		/// <summary> Returns RGS (RGS - resource group segment) - creates it if necessary</summary>
		virtual public RGS RGS
		{
			get
			{
				RGS ret = null;
				try
				{
					ret = (RGS) this.get_Renamed("RGS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SQM_S25_AISAPR </summary>
		virtual public int AISAPRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AISAPR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SQM_S25_AIGAPR </summary>
		virtual public int AIGAPRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AIGAPR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SQM_S25_AIPAPR </summary>
		virtual public int AIPAPRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AIPAPR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SQM_S25_AILAPR </summary>
		virtual public int AILAPRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AILAPR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR Group.</summary>
		public SQM_S25_RGSAISAPRAIGAPRAIPAPRAILAPR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RGS), true, false);
				this.add(typeof(SQM_S25_AISAPR), false, true);
				this.add(typeof(SQM_S25_AIGAPR), false, true);
				this.add(typeof(SQM_S25_AIPAPR), false, true);
				this.add(typeof(SQM_S25_AILAPR), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SQM_S25_AISAPR (a Group object) - creates it if necessary</summary>
		public virtual SQM_S25_AISAPR getAISAPR()
		{
			SQM_S25_AISAPR ret = null;
			try
			{
				ret = (SQM_S25_AISAPR) this.get_Renamed("AISAPR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQM_S25_AISAPR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQM_S25_AISAPR getAISAPR(int rep)
		{
			return (SQM_S25_AISAPR) this.get_Renamed("AISAPR", rep);
		}
		
		/// <summary> Returns  first repetition of SQM_S25_AIGAPR (a Group object) - creates it if necessary</summary>
		public virtual SQM_S25_AIGAPR getAIGAPR()
		{
			SQM_S25_AIGAPR ret = null;
			try
			{
				ret = (SQM_S25_AIGAPR) this.get_Renamed("AIGAPR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQM_S25_AIGAPR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQM_S25_AIGAPR getAIGAPR(int rep)
		{
			return (SQM_S25_AIGAPR) this.get_Renamed("AIGAPR", rep);
		}
		
		/// <summary> Returns  first repetition of SQM_S25_AIPAPR (a Group object) - creates it if necessary</summary>
		public virtual SQM_S25_AIPAPR getAIPAPR()
		{
			SQM_S25_AIPAPR ret = null;
			try
			{
				ret = (SQM_S25_AIPAPR) this.get_Renamed("AIPAPR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQM_S25_AIPAPR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQM_S25_AIPAPR getAIPAPR(int rep)
		{
			return (SQM_S25_AIPAPR) this.get_Renamed("AIPAPR", rep);
		}
		
		/// <summary> Returns  first repetition of SQM_S25_AILAPR (a Group object) - creates it if necessary</summary>
		public virtual SQM_S25_AILAPR getAILAPR()
		{
			SQM_S25_AILAPR ret = null;
			try
			{
				ret = (SQM_S25_AILAPR) this.get_Renamed("AILAPR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQM_S25_AILAPR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQM_S25_AILAPR getAILAPR(int rep)
		{
			return (SQM_S25_AILAPR) this.get_Renamed("AILAPR", rep);
		}
	}
}