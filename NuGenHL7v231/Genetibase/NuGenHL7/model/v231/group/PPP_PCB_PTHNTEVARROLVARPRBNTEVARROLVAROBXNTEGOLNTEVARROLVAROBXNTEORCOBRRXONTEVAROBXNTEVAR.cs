using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the PPP_PCB_PTHNTEVARROLVARPRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PTH (Pathway) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: VAR (Variance) <b>optional repeating</b><br>
	/// 3: PPP_PCB_ROLVAR (a Group object) <b>optional repeating</b><br>
	/// 4: PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPP_PCB_PTHNTEVARROLVARPRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR:AbstractGroup
	{
		/// <summary> Returns PTH (Pathway) - creates it if necessary</summary>
		virtual public PTH PTH
		{
			get
			{
				PTH ret = null;
				try
				{
					ret = (PTH) this.get_Renamed("PTH");
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
		/// <summary> Returns the number of existing repetitions of PPP_PCB_ROLVAR </summary>
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
		/// <summary> Returns the number of existing repetitions of PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR </summary>
		virtual public int PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVARReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PPP_PCB_PTHNTEVARROLVARPRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR Group.</summary>
		public PPP_PCB_PTHNTEVARROLVARPRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PTH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(VAR), false, true);
				this.add(typeof(PPP_PCB_ROLVAR), false, true);
				this.add(typeof(PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR), false, true);
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
		
		/// <summary> Returns  first repetition of PPP_PCB_ROLVAR (a Group object) - creates it if necessary</summary>
		public virtual PPP_PCB_ROLVAR getROLVAR()
		{
			PPP_PCB_ROLVAR ret = null;
			try
			{
				ret = (PPP_PCB_ROLVAR) this.get_Renamed("ROLVAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPP_PCB_ROLVAR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPP_PCB_ROLVAR getROLVAR(int rep)
		{
			return (PPP_PCB_ROLVAR) this.get_Renamed("ROLVAR", rep);
		}
		
		/// <summary> Returns  first repetition of PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR (a Group object) - creates it if necessary</summary>
		public virtual PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR getPRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR()
		{
			PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR ret = null;
			try
			{
				ret = (PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR) this.get_Renamed("PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR getPRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR(int rep)
		{
			return (PPP_PCB_PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR) this.get_Renamed("PRBNTEVARROLVAROBXNTEGOLNTEVARROLVAROBXNTEORCOBRRXONTEVAROBXNTEVAR", rep);
		}
	}
}