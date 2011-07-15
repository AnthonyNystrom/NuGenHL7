using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OML_O33_OBSERVATION_REQUEST Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OBR (Observation Request) <b></b><br>
	/// 1: TCD (Test Code Detail) <b>optional </b><br>
	/// 2: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 3: DG1 (Diagnosis) <b>optional repeating</b><br>
	/// 4: OML_O33_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// 5: OML_O33_PRIOR_RESULT (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OML_O33_OBSERVATION_REQUEST:AbstractGroup
	{
		/// <summary> Returns OBR (Observation Request) - creates it if necessary</summary>
		virtual public OBR OBR
		{
			get
			{
				OBR ret = null;
				try
				{
					ret = (OBR) this.get_Renamed("OBR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns TCD (Test Code Detail) - creates it if necessary</summary>
		virtual public TCD TCD
		{
			get
			{
				TCD ret = null;
				try
				{
					ret = (TCD) this.get_Renamed("TCD");
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
		/// <summary> Returns the number of existing repetitions of DG1 </summary>
		virtual public int DG1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DG1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OML_O33_OBSERVATION </summary>
		virtual public int OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OML_O33_PRIOR_RESULT </summary>
		virtual public int PRIOR_RESULTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRIOR_RESULT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OML_O33_OBSERVATION_REQUEST Group.</summary>
		public OML_O33_OBSERVATION_REQUEST(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OBR), true, false);
				this.add(typeof(TCD), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(DG1), false, true);
				this.add(typeof(OML_O33_OBSERVATION), false, true);
				this.add(typeof(OML_O33_PRIOR_RESULT), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
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
		
		/// <summary> Returns  first repetition of DG1 (Diagnosis) - creates it if necessary</summary>
		public virtual DG1 getDG1()
		{
			DG1 ret = null;
			try
			{
				ret = (DG1) this.get_Renamed("DG1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DG1
		/// (Diagnosis) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DG1 getDG1(int rep)
		{
			return (DG1) this.get_Renamed("DG1", rep);
		}
		
		/// <summary> Returns  first repetition of OML_O33_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual OML_O33_OBSERVATION getOBSERVATION()
		{
			OML_O33_OBSERVATION ret = null;
			try
			{
				ret = (OML_O33_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O33_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O33_OBSERVATION getOBSERVATION(int rep)
		{
			return (OML_O33_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
		
		/// <summary> Returns  first repetition of OML_O33_PRIOR_RESULT (a Group object) - creates it if necessary</summary>
		public virtual OML_O33_PRIOR_RESULT getPRIOR_RESULT()
		{
			OML_O33_PRIOR_RESULT ret = null;
			try
			{
				ret = (OML_O33_PRIOR_RESULT) this.get_Renamed("PRIOR_RESULT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O33_PRIOR_RESULT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O33_PRIOR_RESULT getPRIOR_RESULT(int rep)
		{
			return (OML_O33_PRIOR_RESULT) this.get_Renamed("PRIOR_RESULT", rep);
		}
	}
}