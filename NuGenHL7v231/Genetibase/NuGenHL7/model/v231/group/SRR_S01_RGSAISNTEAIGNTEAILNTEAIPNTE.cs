using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RGS (RGS - resource group segment) <b></b><br>
	/// 1: SRR_S01_AISNTE (a Group object) <b>optional repeating</b><br>
	/// 2: SRR_S01_AIGNTE (a Group object) <b>optional repeating</b><br>
	/// 3: SRR_S01_AILNTE (a Group object) <b>optional repeating</b><br>
	/// 4: SRR_S01_AIPNTE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of SRR_S01_AISNTE </summary>
		virtual public int AISNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AISNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRR_S01_AIGNTE </summary>
		virtual public int AIGNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AIGNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRR_S01_AILNTE </summary>
		virtual public int AILNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AILNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRR_S01_AIPNTE </summary>
		virtual public int AIPNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AIPNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE Group.</summary>
		public SRR_S01_RGSAISNTEAIGNTEAILNTEAIPNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RGS), true, false);
				this.add(typeof(SRR_S01_AISNTE), false, true);
				this.add(typeof(SRR_S01_AIGNTE), false, true);
				this.add(typeof(SRR_S01_AILNTE), false, true);
				this.add(typeof(SRR_S01_AIPNTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SRR_S01_AISNTE (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_AISNTE getAISNTE()
		{
			SRR_S01_AISNTE ret = null;
			try
			{
				ret = (SRR_S01_AISNTE) this.get_Renamed("AISNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_AISNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_AISNTE getAISNTE(int rep)
		{
			return (SRR_S01_AISNTE) this.get_Renamed("AISNTE", rep);
		}
		
		/// <summary> Returns  first repetition of SRR_S01_AIGNTE (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_AIGNTE getAIGNTE()
		{
			SRR_S01_AIGNTE ret = null;
			try
			{
				ret = (SRR_S01_AIGNTE) this.get_Renamed("AIGNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_AIGNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_AIGNTE getAIGNTE(int rep)
		{
			return (SRR_S01_AIGNTE) this.get_Renamed("AIGNTE", rep);
		}
		
		/// <summary> Returns  first repetition of SRR_S01_AILNTE (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_AILNTE getAILNTE()
		{
			SRR_S01_AILNTE ret = null;
			try
			{
				ret = (SRR_S01_AILNTE) this.get_Renamed("AILNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_AILNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_AILNTE getAILNTE(int rep)
		{
			return (SRR_S01_AILNTE) this.get_Renamed("AILNTE", rep);
		}
		
		/// <summary> Returns  first repetition of SRR_S01_AIPNTE (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_AIPNTE getAIPNTE()
		{
			SRR_S01_AIPNTE ret = null;
			try
			{
				ret = (SRR_S01_AIPNTE) this.get_Renamed("AIPNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_AIPNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_AIPNTE getAIPNTE(int rep)
		{
			return (SRR_S01_AIPNTE) this.get_Renamed("AIPNTE", rep);
		}
	}
}