using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the DFT_P03_FINANCIAL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: FT1 (Financial Transaction) <b></b><br>
	/// 1: DFT_P03_FINANCIAL_PROCEDURE (a Group object) <b>optional repeating</b><br>
	/// 2: DFT_P03_FINANCIAL_COMMON_ORDER (a Group object) <b>optional repeating</b><br>
	/// 3: DG1 (Diagnosis) <b>optional repeating</b><br>
	/// 4: DRG (Diagnosis Related Group) <b>optional </b><br>
	/// 5: GT1 (Guarantor) <b>optional repeating</b><br>
	/// 6: DFT_P03_INSURANCE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class DFT_P03_FINANCIAL:AbstractGroup
	{
		/// <summary> Returns FT1 (Financial Transaction) - creates it if necessary</summary>
		virtual public FT1 FT1
		{
			get
			{
				FT1 ret = null;
				try
				{
					ret = (FT1) this.get_Renamed("FT1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DFT_P03_FINANCIAL_PROCEDURE </summary>
		virtual public int FINANCIAL_PROCEDUREReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("FINANCIAL_PROCEDURE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DFT_P03_FINANCIAL_COMMON_ORDER </summary>
		virtual public int FINANCIAL_COMMON_ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("FINANCIAL_COMMON_ORDER").Length;
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
		/// <summary> Returns DRG (Diagnosis Related Group) - creates it if necessary</summary>
		virtual public DRG DRG
		{
			get
			{
				DRG ret = null;
				try
				{
					ret = (DRG) this.get_Renamed("DRG");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of GT1 </summary>
		virtual public int GT1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GT1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DFT_P03_INSURANCE </summary>
		virtual public int INSURANCEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("INSURANCE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new DFT_P03_FINANCIAL Group.</summary>
		public DFT_P03_FINANCIAL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(FT1), true, false);
				this.add(typeof(DFT_P03_FINANCIAL_PROCEDURE), false, true);
				this.add(typeof(DFT_P03_FINANCIAL_COMMON_ORDER), false, true);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, false);
				this.add(typeof(GT1), false, true);
				this.add(typeof(DFT_P03_INSURANCE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of DFT_P03_FINANCIAL_PROCEDURE (a Group object) - creates it if necessary</summary>
		public virtual DFT_P03_FINANCIAL_PROCEDURE getFINANCIAL_PROCEDURE()
		{
			DFT_P03_FINANCIAL_PROCEDURE ret = null;
			try
			{
				ret = (DFT_P03_FINANCIAL_PROCEDURE) this.get_Renamed("FINANCIAL_PROCEDURE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DFT_P03_FINANCIAL_PROCEDURE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DFT_P03_FINANCIAL_PROCEDURE getFINANCIAL_PROCEDURE(int rep)
		{
			return (DFT_P03_FINANCIAL_PROCEDURE) this.get_Renamed("FINANCIAL_PROCEDURE", rep);
		}
		
		/// <summary> Returns  first repetition of DFT_P03_FINANCIAL_COMMON_ORDER (a Group object) - creates it if necessary</summary>
		public virtual DFT_P03_FINANCIAL_COMMON_ORDER getFINANCIAL_COMMON_ORDER()
		{
			DFT_P03_FINANCIAL_COMMON_ORDER ret = null;
			try
			{
				ret = (DFT_P03_FINANCIAL_COMMON_ORDER) this.get_Renamed("FINANCIAL_COMMON_ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DFT_P03_FINANCIAL_COMMON_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DFT_P03_FINANCIAL_COMMON_ORDER getFINANCIAL_COMMON_ORDER(int rep)
		{
			return (DFT_P03_FINANCIAL_COMMON_ORDER) this.get_Renamed("FINANCIAL_COMMON_ORDER", rep);
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
		
		/// <summary> Returns  first repetition of GT1 (Guarantor) - creates it if necessary</summary>
		public virtual GT1 getGT1()
		{
			GT1 ret = null;
			try
			{
				ret = (GT1) this.get_Renamed("GT1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of GT1
		/// (Guarantor) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual GT1 getGT1(int rep)
		{
			return (GT1) this.get_Renamed("GT1", rep);
		}
		
		/// <summary> Returns  first repetition of DFT_P03_INSURANCE (a Group object) - creates it if necessary</summary>
		public virtual DFT_P03_INSURANCE getINSURANCE()
		{
			DFT_P03_INSURANCE ret = null;
			try
			{
				ret = (DFT_P03_INSURANCE) this.get_Renamed("INSURANCE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DFT_P03_INSURANCE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DFT_P03_INSURANCE getINSURANCE(int rep)
		{
			return (DFT_P03_INSURANCE) this.get_Renamed("INSURANCE", rep);
		}
	}
}