using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the PGL_PC6_GOAL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: GOL (Goal Detail) <b></b><br>
	/// 1: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 2: VAR (Variance) <b>optional repeating</b><br>
	/// 3: PGL_PC6_GOAL_ROLE (a Group object) <b>optional repeating</b><br>
	/// 4: PGL_PC6_PATHWAY (a Group object) <b>optional repeating</b><br>
	/// 5: PGL_PC6_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// 6: PGL_PC6_PROBLEM (a Group object) <b>optional repeating</b><br>
	/// 7: PGL_PC6_ORDER (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PGL_PC6_GOAL:AbstractGroup
	{
		/// <summary> Returns GOL (Goal Detail) - creates it if necessary</summary>
		virtual public GOL GOL
		{
			get
			{
				GOL ret = null;
				try
				{
					ret = (GOL) this.get_Renamed("GOL");
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
		/// <summary> Returns the number of existing repetitions of PGL_PC6_GOAL_ROLE </summary>
		virtual public int GOAL_ROLEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GOAL_ROLE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PGL_PC6_PATHWAY </summary>
		virtual public int PATHWAYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PATHWAY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PGL_PC6_OBSERVATION </summary>
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
		/// <summary> Returns the number of existing repetitions of PGL_PC6_PROBLEM </summary>
		virtual public int PROBLEMReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROBLEM").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PGL_PC6_ORDER </summary>
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
		
		/// <summary> Creates a new PGL_PC6_GOAL Group.</summary>
		public PGL_PC6_GOAL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(GOL), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(VAR), false, true);
				this.add(typeof(PGL_PC6_GOAL_ROLE), false, true);
				this.add(typeof(PGL_PC6_PATHWAY), false, true);
				this.add(typeof(PGL_PC6_OBSERVATION), false, true);
				this.add(typeof(PGL_PC6_PROBLEM), false, true);
				this.add(typeof(PGL_PC6_ORDER), false, true);
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
		
		/// <summary> Returns  first repetition of PGL_PC6_GOAL_ROLE (a Group object) - creates it if necessary</summary>
		public virtual PGL_PC6_GOAL_ROLE getGOAL_ROLE()
		{
			PGL_PC6_GOAL_ROLE ret = null;
			try
			{
				ret = (PGL_PC6_GOAL_ROLE) this.get_Renamed("GOAL_ROLE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PGL_PC6_GOAL_ROLE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PGL_PC6_GOAL_ROLE getGOAL_ROLE(int rep)
		{
			return (PGL_PC6_GOAL_ROLE) this.get_Renamed("GOAL_ROLE", rep);
		}
		
		/// <summary> Returns  first repetition of PGL_PC6_PATHWAY (a Group object) - creates it if necessary</summary>
		public virtual PGL_PC6_PATHWAY getPATHWAY()
		{
			PGL_PC6_PATHWAY ret = null;
			try
			{
				ret = (PGL_PC6_PATHWAY) this.get_Renamed("PATHWAY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PGL_PC6_PATHWAY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PGL_PC6_PATHWAY getPATHWAY(int rep)
		{
			return (PGL_PC6_PATHWAY) this.get_Renamed("PATHWAY", rep);
		}
		
		/// <summary> Returns  first repetition of PGL_PC6_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual PGL_PC6_OBSERVATION getOBSERVATION()
		{
			PGL_PC6_OBSERVATION ret = null;
			try
			{
				ret = (PGL_PC6_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PGL_PC6_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PGL_PC6_OBSERVATION getOBSERVATION(int rep)
		{
			return (PGL_PC6_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
		
		/// <summary> Returns  first repetition of PGL_PC6_PROBLEM (a Group object) - creates it if necessary</summary>
		public virtual PGL_PC6_PROBLEM getPROBLEM()
		{
			PGL_PC6_PROBLEM ret = null;
			try
			{
				ret = (PGL_PC6_PROBLEM) this.get_Renamed("PROBLEM");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PGL_PC6_PROBLEM
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PGL_PC6_PROBLEM getPROBLEM(int rep)
		{
			return (PGL_PC6_PROBLEM) this.get_Renamed("PROBLEM", rep);
		}
		
		/// <summary> Returns  first repetition of PGL_PC6_ORDER (a Group object) - creates it if necessary</summary>
		public virtual PGL_PC6_ORDER getORDER()
		{
			PGL_PC6_ORDER ret = null;
			try
			{
				ret = (PGL_PC6_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PGL_PC6_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PGL_PC6_ORDER getORDER(int rep)
		{
			return (PGL_PC6_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}