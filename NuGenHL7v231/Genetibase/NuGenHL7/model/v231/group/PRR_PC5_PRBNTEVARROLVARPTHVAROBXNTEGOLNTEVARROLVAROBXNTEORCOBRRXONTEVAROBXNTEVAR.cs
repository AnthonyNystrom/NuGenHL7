using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the PRR_PC5_PRBNTEVARROLVARPTHVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PRB (Problem Detail) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: VAR (Variance) <b>optional repeating</b><br>
	/// 3: PRR_PC5_ROLVAR (a Group object) <b>optional repeating</b><br>
	/// 4: PRR_PC5_PTHVAR (a Group object) <b>optional repeating</b><br>
	/// 5: PRR_PC5_OBXNTE (a Group object) <b>optional repeating</b><br>
	/// 6: PRR_PC5_GOLNTEVARROLVAROBXNTE (a Group object) <b>optional repeating</b><br>
	/// 7: PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PRR_PC5_PRBNTEVARROLVARPTHVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR:AbstractGroup
	{
		/// <summary> Returns PRB (Problem Detail) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of PRR_PC5_ROLVAR </summary>
		virtual public int ROLVARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ROLVAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRR_PC5_PTHVAR </summary>
		virtual public int PTHVARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PTHVAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRR_PC5_OBXNTE </summary>
		virtual public int OBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRR_PC5_GOLNTEVARROLVAROBXNTE </summary>
		virtual public int GOLNTEVARROLVAROBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GOLNTEVARROLVAROBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR </summary>
		virtual public int ORCOBRRXONTEVAROBXNTEVARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCOBRRXONTEVAROBXNTEVAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PRR_PC5_PRBNTEVARROLVARPTHVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR Group.</summary>
		public PRR_PC5_PRBNTEVARROLVARPTHVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PRB), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(VAR), false, true);
				this.add(typeof(PRR_PC5_ROLVAR), false, true);
				this.add(typeof(PRR_PC5_PTHVAR), false, true);
				this.add(typeof(PRR_PC5_OBXNTE), false, true);
				this.add(typeof(PRR_PC5_GOLNTEVARROLVAROBXNTE), false, true);
				this.add(typeof(PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR), false, true);
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
		
		/// <summary> Returns  first repetition of PRR_PC5_ROLVAR (a Group object) - creates it if necessary</summary>
		public virtual PRR_PC5_ROLVAR getROLVAR()
		{
			PRR_PC5_ROLVAR ret = null;
			try
			{
				ret = (PRR_PC5_ROLVAR) this.get_Renamed("ROLVAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRR_PC5_ROLVAR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRR_PC5_ROLVAR getROLVAR(int rep)
		{
			return (PRR_PC5_ROLVAR) this.get_Renamed("ROLVAR", rep);
		}
		
		/// <summary> Returns  first repetition of PRR_PC5_PTHVAR (a Group object) - creates it if necessary</summary>
		public virtual PRR_PC5_PTHVAR getPTHVAR()
		{
			PRR_PC5_PTHVAR ret = null;
			try
			{
				ret = (PRR_PC5_PTHVAR) this.get_Renamed("PTHVAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRR_PC5_PTHVAR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRR_PC5_PTHVAR getPTHVAR(int rep)
		{
			return (PRR_PC5_PTHVAR) this.get_Renamed("PTHVAR", rep);
		}
		
		/// <summary> Returns  first repetition of PRR_PC5_OBXNTE (a Group object) - creates it if necessary</summary>
		public virtual PRR_PC5_OBXNTE getOBXNTE()
		{
			PRR_PC5_OBXNTE ret = null;
			try
			{
				ret = (PRR_PC5_OBXNTE) this.get_Renamed("OBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRR_PC5_OBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRR_PC5_OBXNTE getOBXNTE(int rep)
		{
			return (PRR_PC5_OBXNTE) this.get_Renamed("OBXNTE", rep);
		}
		
		/// <summary> Returns  first repetition of PRR_PC5_GOLNTEVARROLVAROBXNTE (a Group object) - creates it if necessary</summary>
		public virtual PRR_PC5_GOLNTEVARROLVAROBXNTE getGOLNTEVARROLVAROBXNTE()
		{
			PRR_PC5_GOLNTEVARROLVAROBXNTE ret = null;
			try
			{
				ret = (PRR_PC5_GOLNTEVARROLVAROBXNTE) this.get_Renamed("GOLNTEVARROLVAROBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRR_PC5_GOLNTEVARROLVAROBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRR_PC5_GOLNTEVARROLVAROBXNTE getGOLNTEVARROLVAROBXNTE(int rep)
		{
			return (PRR_PC5_GOLNTEVARROLVAROBXNTE) this.get_Renamed("GOLNTEVARROLVAROBXNTE", rep);
		}
		
		/// <summary> Returns  first repetition of PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR (a Group object) - creates it if necessary</summary>
		public virtual PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR getORCOBRRXONTEVAROBXNTEVAR()
		{
			PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR ret = null;
			try
			{
				ret = (PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR) this.get_Renamed("ORCOBRRXONTEVAROBXNTEVAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR getORCOBRRXONTEVAROBXNTEVAR(int rep)
		{
			return (PRR_PC5_ORCOBRRXONTEVAROBXNTEVAR) this.get_Renamed("ORCOBRRXONTEVAROBXNTEVAR", rep);
		}
	}
}