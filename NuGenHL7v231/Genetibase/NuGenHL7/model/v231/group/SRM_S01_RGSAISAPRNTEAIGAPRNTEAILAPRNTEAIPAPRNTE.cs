using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SRM_S01_RGSAISAPRNTEAIGAPRNTEAILAPRNTEAIPAPRNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RGS (RGS - resource group segment) <b></b><br>
	/// 1: SRM_S01_AISAPRNTE (a Group object) <b>optional repeating</b><br>
	/// 2: SRM_S01_AIGAPRNTE (a Group object) <b>optional repeating</b><br>
	/// 3: SRM_S01_AILAPRNTE (a Group object) <b>optional repeating</b><br>
	/// 4: SRM_S01_AIPAPRNTE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class SRM_S01_RGSAISAPRNTEAIGAPRNTEAILAPRNTEAIPAPRNTE:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of SRM_S01_AISAPRNTE </summary>
		virtual public int AISAPRNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AISAPRNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRM_S01_AIGAPRNTE </summary>
		virtual public int AIGAPRNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AIGAPRNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRM_S01_AILAPRNTE </summary>
		virtual public int AILAPRNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AILAPRNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRM_S01_AIPAPRNTE </summary>
		virtual public int AIPAPRNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AIPAPRNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SRM_S01_RGSAISAPRNTEAIGAPRNTEAILAPRNTEAIPAPRNTE Group.</summary>
		public SRM_S01_RGSAISAPRNTEAIGAPRNTEAILAPRNTEAIPAPRNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RGS), true, false);
				this.add(typeof(SRM_S01_AISAPRNTE), false, true);
				this.add(typeof(SRM_S01_AIGAPRNTE), false, true);
				this.add(typeof(SRM_S01_AILAPRNTE), false, true);
				this.add(typeof(SRM_S01_AIPAPRNTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SRM_S01_AISAPRNTE (a Group object) - creates it if necessary</summary>
		public virtual SRM_S01_AISAPRNTE getAISAPRNTE()
		{
			SRM_S01_AISAPRNTE ret = null;
			try
			{
				ret = (SRM_S01_AISAPRNTE) this.get_Renamed("AISAPRNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRM_S01_AISAPRNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRM_S01_AISAPRNTE getAISAPRNTE(int rep)
		{
			return (SRM_S01_AISAPRNTE) this.get_Renamed("AISAPRNTE", rep);
		}
		
		/// <summary> Returns  first repetition of SRM_S01_AIGAPRNTE (a Group object) - creates it if necessary</summary>
		public virtual SRM_S01_AIGAPRNTE getAIGAPRNTE()
		{
			SRM_S01_AIGAPRNTE ret = null;
			try
			{
				ret = (SRM_S01_AIGAPRNTE) this.get_Renamed("AIGAPRNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRM_S01_AIGAPRNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRM_S01_AIGAPRNTE getAIGAPRNTE(int rep)
		{
			return (SRM_S01_AIGAPRNTE) this.get_Renamed("AIGAPRNTE", rep);
		}
		
		/// <summary> Returns  first repetition of SRM_S01_AILAPRNTE (a Group object) - creates it if necessary</summary>
		public virtual SRM_S01_AILAPRNTE getAILAPRNTE()
		{
			SRM_S01_AILAPRNTE ret = null;
			try
			{
				ret = (SRM_S01_AILAPRNTE) this.get_Renamed("AILAPRNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRM_S01_AILAPRNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRM_S01_AILAPRNTE getAILAPRNTE(int rep)
		{
			return (SRM_S01_AILAPRNTE) this.get_Renamed("AILAPRNTE", rep);
		}
		
		/// <summary> Returns  first repetition of SRM_S01_AIPAPRNTE (a Group object) - creates it if necessary</summary>
		public virtual SRM_S01_AIPAPRNTE getAIPAPRNTE()
		{
			SRM_S01_AIPAPRNTE ret = null;
			try
			{
				ret = (SRM_S01_AIPAPRNTE) this.get_Renamed("AIPAPRNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRM_S01_AIPAPRNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRM_S01_AIPAPRNTE getAIPAPRNTE(int rep)
		{
			return (SRM_S01_AIPAPRNTE) this.get_Renamed("AIPAPRNTE", rep);
		}
	}
}