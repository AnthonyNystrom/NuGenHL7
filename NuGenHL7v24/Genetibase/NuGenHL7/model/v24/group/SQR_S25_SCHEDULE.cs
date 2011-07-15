using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the SQR_S25_SCHEDULE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SCH (Scheduling Activity Information) <b></b><br>
	/// 1: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 2: SQR_S25_PATIENT (a Group object) <b>optional </b><br>
	/// 3: SQR_S25_RESOURCES (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SQR_S25_SCHEDULE:AbstractGroup
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
		/// <summary> Returns SQR_S25_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public SQR_S25_PATIENT PATIENT
		{
			get
			{
				SQR_S25_PATIENT ret = null;
				try
				{
					ret = (SQR_S25_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SQR_S25_RESOURCES </summary>
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
		
		/// <summary> Creates a new SQR_S25_SCHEDULE Group.</summary>
		public SQR_S25_SCHEDULE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SCH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(SQR_S25_PATIENT), false, false);
				this.add(typeof(SQR_S25_RESOURCES), true, true);
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
		
		/// <summary> Returns  first repetition of SQR_S25_RESOURCES (a Group object) - creates it if necessary</summary>
		public virtual SQR_S25_RESOURCES getRESOURCES()
		{
			SQR_S25_RESOURCES ret = null;
			try
			{
				ret = (SQR_S25_RESOURCES) this.get_Renamed("RESOURCES");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SQR_S25_RESOURCES
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SQR_S25_RESOURCES getRESOURCES(int rep)
		{
			return (SQR_S25_RESOURCES) this.get_Renamed("RESOURCES", rep);
		}
	}
}