using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a PGL_PC6 message structure (see chapter 12). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: PID (Patient identification) <b></b><br>
	/// 2: PGL_PC6_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 3: PGL_PC6_GOAL (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PGL_PC6:AbstractMessage
	{
		/// <summary> Returns MSH (Message Header) - creates it if necessary</summary>
		virtual public MSH MSH
		{
			get
			{
				MSH ret = null;
				try
				{
					ret = (MSH) this.get_Renamed("MSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
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
		/// <summary> Returns PGL_PC6_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public PGL_PC6_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				PGL_PC6_PATIENT_VISIT ret = null;
				try
				{
					ret = (PGL_PC6_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PGL_PC6_GOAL </summary>
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
		
		/// <summary> Creates a new PGL_PC6 Group with custom ModelClassFactory.</summary>
		public PGL_PC6(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new PGL_PC6 Group with DefaultModelClassFactory. </summary>
		public PGL_PC6():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PGL_PC6_PATIENT_VISIT), false, false);
				this.add(typeof(PGL_PC6_GOAL), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PGL_PC6_GOAL (a Group object) - creates it if necessary</summary>
		public virtual PGL_PC6_GOAL getGOAL()
		{
			PGL_PC6_GOAL ret = null;
			try
			{
				ret = (PGL_PC6_GOAL) this.get_Renamed("GOAL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PGL_PC6_GOAL
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PGL_PC6_GOAL getGOAL(int rep)
		{
			return (PGL_PC6_GOAL) this.get_Renamed("GOAL", rep);
		}
	}
}