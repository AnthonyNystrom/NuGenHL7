using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a PPP_PCB message structure (see chapter 12). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: PID (Patient identification) <b></b><br>
	/// 2: PPP_PCB_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 3: PPP_PCB_PATHWAY (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPP_PCB:AbstractMessage
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
		/// <summary> Returns PPP_PCB_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public PPP_PCB_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				PPP_PCB_PATIENT_VISIT ret = null;
				try
				{
					ret = (PPP_PCB_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPP_PCB_PATHWAY </summary>
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
		
		/// <summary> Creates a new PPP_PCB Group with custom ModelClassFactory.</summary>
		public PPP_PCB(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new PPP_PCB Group with DefaultModelClassFactory. </summary>
		public PPP_PCB():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PPP_PCB_PATIENT_VISIT), false, false);
				this.add(typeof(PPP_PCB_PATHWAY), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PPP_PCB_PATHWAY (a Group object) - creates it if necessary</summary>
		public virtual PPP_PCB_PATHWAY getPATHWAY()
		{
			PPP_PCB_PATHWAY ret = null;
			try
			{
				ret = (PPP_PCB_PATHWAY) this.get_Renamed("PATHWAY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPP_PCB_PATHWAY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPP_PCB_PATHWAY getPATHWAY(int rep)
		{
			return (PPP_PCB_PATHWAY) this.get_Renamed("PATHWAY", rep);
		}
	}
}