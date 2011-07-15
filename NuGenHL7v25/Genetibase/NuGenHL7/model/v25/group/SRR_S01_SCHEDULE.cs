using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the SRR_S01_SCHEDULE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SCH (Scheduling Activity Information) <b></b><br>
	/// 1: TQ1 (Timing/Quantity) <b>optional repeating</b><br>
	/// 2: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 3: SRR_S01_PATIENT (a Group object) <b>optional repeating</b><br>
	/// 4: SRR_S01_RESOURCES (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SRR_S01_SCHEDULE:AbstractGroup
	{
		/// <summary> Returns SCH (Scheduling Activity Information) - creates it if necessary</summary>
		virtual public SCH SCH
		{
			get
			{
				SCH ret = null;
				try
				{
					ret = (SCH) this.get_Renamed("SCH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of TQ1 </summary>
		virtual public int TQ1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TQ1").Length;
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
		/// <summary> Returns the number of existing repetitions of SRR_S01_PATIENT </summary>
		virtual public int PATIENTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PATIENT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SRR_S01_RESOURCES </summary>
		virtual public int RESOURCESReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RESOURCES").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SRR_S01_SCHEDULE Group.</summary>
		public SRR_S01_SCHEDULE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SCH), true, false);
				this.add(typeof(TQ1), false, true);
				this.add(typeof(NTE), false, true);
				this.add(typeof(SRR_S01_PATIENT), false, true);
				this.add(typeof(SRR_S01_RESOURCES), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of TQ1 (Timing/Quantity) - creates it if necessary</summary>
		public virtual TQ1 getTQ1()
		{
			TQ1 ret = null;
			try
			{
				ret = (TQ1) this.get_Renamed("TQ1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of TQ1
		/// (Timing/Quantity) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual TQ1 getTQ1(int rep)
		{
			return (TQ1) this.get_Renamed("TQ1", rep);
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
		
		/// <summary> Returns  first repetition of SRR_S01_PATIENT (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_PATIENT getPATIENT()
		{
			SRR_S01_PATIENT ret = null;
			try
			{
				ret = (SRR_S01_PATIENT) this.get_Renamed("PATIENT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_PATIENT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_PATIENT getPATIENT(int rep)
		{
			return (SRR_S01_PATIENT) this.get_Renamed("PATIENT", rep);
		}
		
		/// <summary> Returns  first repetition of SRR_S01_RESOURCES (a Group object) - creates it if necessary</summary>
		public virtual SRR_S01_RESOURCES getRESOURCES()
		{
			SRR_S01_RESOURCES ret = null;
			try
			{
				ret = (SRR_S01_RESOURCES) this.get_Renamed("RESOURCES");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRR_S01_RESOURCES
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRR_S01_RESOURCES getRESOURCES(int rep)
		{
			return (SRR_S01_RESOURCES) this.get_Renamed("RESOURCES", rep);
		}
	}
}