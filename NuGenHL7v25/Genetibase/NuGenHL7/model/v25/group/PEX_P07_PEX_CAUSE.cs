using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PEX_P07_PEX_CAUSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PCR (Possible Causal Relationship) <b></b><br>
	/// 1: PEX_P07_RX_ORDER (a Group object) <b>optional </b><br>
	/// 2: PEX_P07_RX_ADMINISTRATION (a Group object) <b>optional repeating</b><br>
	/// 3: PRB (Problem Details) <b>optional repeating</b><br>
	/// 4: OBX (Observation/Result) <b>optional repeating</b><br>
	/// 5: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 6: PEX_P07_ASSOCIATED_PERSON (a Group object) <b>optional </b><br>
	/// 7: PEX_P07_STUDY (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_PEX_CAUSE:AbstractGroup
	{
		/// <summary> Returns PCR (Possible Causal Relationship) - creates it if necessary</summary>
		virtual public PCR PCR
		{
			get
			{
				PCR ret = null;
				try
				{
					ret = (PCR) this.get_Renamed("PCR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PEX_P07_RX_ORDER (a Group object) - creates it if necessary</summary>
		virtual public PEX_P07_RX_ORDER RX_ORDER
		{
			get
			{
				PEX_P07_RX_ORDER ret = null;
				try
				{
					ret = (PEX_P07_RX_ORDER) this.get_Renamed("RX_ORDER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PEX_P07_RX_ADMINISTRATION </summary>
		virtual public int RX_ADMINISTRATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RX_ADMINISTRATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRB </summary>
		virtual public int PRBReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRB").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OBX </summary>
		virtual public int OBXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBX").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		/// <summary> Returns PEX_P07_ASSOCIATED_PERSON (a Group object) - creates it if necessary</summary>
		virtual public PEX_P07_ASSOCIATED_PERSON ASSOCIATED_PERSON
		{
			get
			{
				PEX_P07_ASSOCIATED_PERSON ret = null;
				try
				{
					ret = (PEX_P07_ASSOCIATED_PERSON) this.get_Renamed("ASSOCIATED_PERSON");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PEX_P07_STUDY </summary>
		virtual public int STUDYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("STUDY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PEX_P07_PEX_CAUSE Group.</summary>
		public PEX_P07_PEX_CAUSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PCR), true, false);
				this.add(typeof(PEX_P07_RX_ORDER), false, false);
				this.add(typeof(PEX_P07_RX_ADMINISTRATION), false, true);
				this.add(typeof(PRB), false, true);
				this.add(typeof(OBX), false, true);
				this.add(typeof(NTE), false, true);
				this.add(typeof(PEX_P07_ASSOCIATED_PERSON), false, false);
				this.add(typeof(PEX_P07_STUDY), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PEX_P07_RX_ADMINISTRATION (a Group object) - creates it if necessary</summary>
		public virtual PEX_P07_RX_ADMINISTRATION getRX_ADMINISTRATION()
		{
			PEX_P07_RX_ADMINISTRATION ret = null;
			try
			{
				ret = (PEX_P07_RX_ADMINISTRATION) this.get_Renamed("RX_ADMINISTRATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PEX_P07_RX_ADMINISTRATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PEX_P07_RX_ADMINISTRATION getRX_ADMINISTRATION(int rep)
		{
			return (PEX_P07_RX_ADMINISTRATION) this.get_Renamed("RX_ADMINISTRATION", rep);
		}
		
		/// <summary> Returns  first repetition of PRB (Problem Details) - creates it if necessary</summary>
		public virtual PRB getPRB()
		{
			PRB ret = null;
			try
			{
				ret = (PRB) this.get_Renamed("PRB");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRB
		/// (Problem Details) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRB getPRB(int rep)
		{
			return (PRB) this.get_Renamed("PRB", rep);
		}
		
		/// <summary> Returns  first repetition of OBX (Observation/Result) - creates it if necessary</summary>
		public virtual OBX getOBX()
		{
			OBX ret = null;
			try
			{
				ret = (OBX) this.get_Renamed("OBX");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OBX
		/// (Observation/Result) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OBX getOBX(int rep)
		{
			return (OBX) this.get_Renamed("OBX", rep);
		}
		
		/// <summary> Returns  first repetition of NTE (Notes and Comments) - creates it if necessary</summary>
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
		/// (Notes and Comments) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of PEX_P07_STUDY (a Group object) - creates it if necessary</summary>
		public virtual PEX_P07_STUDY getSTUDY()
		{
			PEX_P07_STUDY ret = null;
			try
			{
				ret = (PEX_P07_STUDY) this.get_Renamed("STUDY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PEX_P07_STUDY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PEX_P07_STUDY getSTUDY(int rep)
		{
			return (PEX_P07_STUDY) this.get_Renamed("STUDY", rep);
		}
	}
}