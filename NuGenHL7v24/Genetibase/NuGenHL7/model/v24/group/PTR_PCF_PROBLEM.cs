using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the PTR_PCF_PROBLEM Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PRB (Problem Details) <b></b><br>
	/// 1: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 2: VAR (Variance) <b>optional repeating</b><br>
	/// 3: PTR_PCF_PROBLEM_ROLE (a Group object) <b>optional repeating</b><br>
	/// 4: PTR_PCF_PROBLEM_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// 5: PTR_PCF_GOAL (a Group object) <b>optional repeating</b><br>
	/// 6: PTR_PCF_ORDER (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PTR_PCF_PROBLEM:AbstractGroup
	{
		/// <summary> Returns PRB (Problem Details) - creates it if necessary</summary>
		virtual public PRB PRB
		{
			get
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
		/// <summary> Returns the number of existing repetitions of VAR </summary>
		virtual public int VARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("VAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PTR_PCF_PROBLEM_ROLE </summary>
		virtual public int PROBLEM_ROLEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROBLEM_ROLE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PTR_PCF_PROBLEM_OBSERVATION </summary>
		virtual public int PROBLEM_OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROBLEM_OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PTR_PCF_GOAL </summary>
		virtual public int GOALReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GOAL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PTR_PCF_ORDER </summary>
		virtual public int ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PTR_PCF_PROBLEM Group.</summary>
		public PTR_PCF_PROBLEM(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PRB), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(VAR), false, true);
				this.add(typeof(PTR_PCF_PROBLEM_ROLE), false, true);
				this.add(typeof(PTR_PCF_PROBLEM_OBSERVATION), false, true);
				this.add(typeof(PTR_PCF_GOAL), false, true);
				this.add(typeof(PTR_PCF_ORDER), false, true);
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
		
		/// <summary> Returns  first repetition of VAR (Variance) - creates it if necessary</summary>
		public virtual VAR getVAR()
		{
			VAR ret = null;
			try
			{
				ret = (VAR) this.get_Renamed("VAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of VAR
		/// (Variance) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual VAR getVAR(int rep)
		{
			return (VAR) this.get_Renamed("VAR", rep);
		}
		
		/// <summary> Returns  first repetition of PTR_PCF_PROBLEM_ROLE (a Group object) - creates it if necessary</summary>
		public virtual PTR_PCF_PROBLEM_ROLE getPROBLEM_ROLE()
		{
			PTR_PCF_PROBLEM_ROLE ret = null;
			try
			{
				ret = (PTR_PCF_PROBLEM_ROLE) this.get_Renamed("PROBLEM_ROLE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PTR_PCF_PROBLEM_ROLE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PTR_PCF_PROBLEM_ROLE getPROBLEM_ROLE(int rep)
		{
			return (PTR_PCF_PROBLEM_ROLE) this.get_Renamed("PROBLEM_ROLE", rep);
		}
		
		/// <summary> Returns  first repetition of PTR_PCF_PROBLEM_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual PTR_PCF_PROBLEM_OBSERVATION getPROBLEM_OBSERVATION()
		{
			PTR_PCF_PROBLEM_OBSERVATION ret = null;
			try
			{
				ret = (PTR_PCF_PROBLEM_OBSERVATION) this.get_Renamed("PROBLEM_OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PTR_PCF_PROBLEM_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PTR_PCF_PROBLEM_OBSERVATION getPROBLEM_OBSERVATION(int rep)
		{
			return (PTR_PCF_PROBLEM_OBSERVATION) this.get_Renamed("PROBLEM_OBSERVATION", rep);
		}
		
		/// <summary> Returns  first repetition of PTR_PCF_GOAL (a Group object) - creates it if necessary</summary>
		public virtual PTR_PCF_GOAL getGOAL()
		{
			PTR_PCF_GOAL ret = null;
			try
			{
				ret = (PTR_PCF_GOAL) this.get_Renamed("GOAL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PTR_PCF_GOAL
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PTR_PCF_GOAL getGOAL(int rep)
		{
			return (PTR_PCF_GOAL) this.get_Renamed("GOAL", rep);
		}
		
		/// <summary> Returns  first repetition of PTR_PCF_ORDER (a Group object) - creates it if necessary</summary>
		public virtual PTR_PCF_ORDER getORDER()
		{
			PTR_PCF_ORDER ret = null;
			try
			{
				ret = (PTR_PCF_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PTR_PCF_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PTR_PCF_ORDER getORDER(int rep)
		{
			return (PTR_PCF_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}