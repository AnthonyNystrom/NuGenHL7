using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v21.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v21.group
{
	/// <summary> <p>Represents the BAR_P01_VISIT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PV1 (PATIENT VISIT) <b>optional </b><br>
	/// 1: DG1 (DIAGNOSIS) <b>optional repeating</b><br>
	/// 2: PR1 (PROCEDURES) <b>optional repeating</b><br>
	/// 3: GT1 (GUARANTOR) <b>optional repeating</b><br>
	/// 4: NK1 (NEXT OF KIN) <b>optional repeating</b><br>
	/// 5: IN1 (INSURANCE) <b>optional repeating</b><br>
	/// 6: ACC (ACCIDENT) <b>optional </b><br>
	/// 7: UB1 (UB82 DATA) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class BAR_P01_VISIT:AbstractGroup
	{
		/// <summary> Returns PV1 (PATIENT VISIT) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
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
		/// <summary> Returns the number of existing repetitions of PR1 </summary>
		virtual public int PR1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PR1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		/// <summary> Returns the number of existing repetitions of NK1 </summary>
		virtual public int NK1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NK1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of IN1 </summary>
		virtual public int IN1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("IN1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns ACC (ACCIDENT) - creates it if necessary</summary>
		virtual public ACC ACC
		{
			get
			{
				ACC ret = null;
				try
				{
					ret = (ACC) this.get_Renamed("ACC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns UB1 (UB82 DATA) - creates it if necessary</summary>
		virtual public UB1 UB1
		{
			get
			{
				UB1 ret = null;
				try
				{
					ret = (UB1) this.get_Renamed("UB1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new BAR_P01_VISIT Group.</summary>
		public BAR_P01_VISIT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PV1), false, false);
				this.add(typeof(DG1), false, true);
				this.add(typeof(PR1), false, true);
				this.add(typeof(GT1), false, true);
				this.add(typeof(NK1), false, true);
				this.add(typeof(IN1), false, true);
				this.add(typeof(ACC), false, false);
				this.add(typeof(UB1), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of DG1 (DIAGNOSIS) - creates it if necessary</summary>
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
		/// (DIAGNOSIS) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DG1 getDG1(int rep)
		{
			return (DG1) this.get_Renamed("DG1", rep);
		}
		
		/// <summary> Returns  first repetition of PR1 (PROCEDURES) - creates it if necessary</summary>
		public virtual PR1 getPR1()
		{
			PR1 ret = null;
			try
			{
				ret = (PR1) this.get_Renamed("PR1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PR1
		/// (PROCEDURES) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PR1 getPR1(int rep)
		{
			return (PR1) this.get_Renamed("PR1", rep);
		}
		
		/// <summary> Returns  first repetition of GT1 (GUARANTOR) - creates it if necessary</summary>
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
		/// (GUARANTOR) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual GT1 getGT1(int rep)
		{
			return (GT1) this.get_Renamed("GT1", rep);
		}
		
		/// <summary> Returns  first repetition of NK1 (NEXT OF KIN) - creates it if necessary</summary>
		public virtual NK1 getNK1()
		{
			NK1 ret = null;
			try
			{
				ret = (NK1) this.get_Renamed("NK1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NK1
		/// (NEXT OF KIN) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NK1 getNK1(int rep)
		{
			return (NK1) this.get_Renamed("NK1", rep);
		}
		
		/// <summary> Returns  first repetition of IN1 (INSURANCE) - creates it if necessary</summary>
		public virtual IN1 getIN1()
		{
			IN1 ret = null;
			try
			{
				ret = (IN1) this.get_Renamed("IN1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of IN1
		/// (INSURANCE) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual IN1 getIN1(int rep)
		{
			return (IN1) this.get_Renamed("IN1", rep);
		}
	}
}