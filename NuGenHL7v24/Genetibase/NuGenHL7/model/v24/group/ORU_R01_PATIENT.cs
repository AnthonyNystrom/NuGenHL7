using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the ORU_R01_PATIENT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (Patient identification) <b></b><br>
	/// 1: PD1 (patient additional demographic) <b>optional </b><br>
	/// 2: NK1 (Next of kin / associated parties) <b>optional repeating</b><br>
	/// 3: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 4: ORU_R01_VISIT (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORU_R01_PATIENT:AbstractGroup
	{
		/// <summary> Returns PID (Patient identification) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PD1 (patient additional demographic) - creates it if necessary</summary>
		virtual public PD1 PD1
		{
			get
			{
				PD1 ret = null;
				try
				{
					ret = (PD1) this.get_Renamed("PD1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
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
		/// <summary> Returns ORU_R01_VISIT (a Group object) - creates it if necessary</summary>
		virtual public ORU_R01_VISIT VISIT
		{
			get
			{
				ORU_R01_VISIT ret = null;
				try
				{
					ret = (ORU_R01_VISIT) this.get_Renamed("VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ORU_R01_PATIENT Group.</summary>
		public ORU_R01_PATIENT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(NTE), false, true);
				this.add(typeof(ORU_R01_VISIT), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NK1 (Next of kin / associated parties) - creates it if necessary</summary>
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
		/// (Next of kin / associated parties) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NK1 getNK1(int rep)
		{
			return (NK1) this.get_Renamed("NK1", rep);
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
	}
}