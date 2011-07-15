using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a PPR_PC1 message structure (see chapter 12). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: PID (Patient identification) <b></b><br>
	/// 2: PPR_PC1_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 3: PPR_PC1_PROBLEM (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class PPR_PC1:AbstractMessage
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
		/// <summary> Returns PPR_PC1_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public PPR_PC1_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				PPR_PC1_PATIENT_VISIT ret = null;
				try
				{
					ret = (PPR_PC1_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PPR_PC1_PROBLEM </summary>
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
		
		/// <summary> Creates a new PPR_PC1 Group with custom ModelClassFactory.</summary>
		public PPR_PC1(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new PPR_PC1 Group with DefaultModelClassFactory. </summary>
		public PPR_PC1():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PPR_PC1_PATIENT_VISIT), false, false);
				this.add(typeof(PPR_PC1_PROBLEM), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PPR_PC1_PROBLEM (a Group object) - creates it if necessary</summary>
		public virtual PPR_PC1_PROBLEM getPROBLEM()
		{
			PPR_PC1_PROBLEM ret = null;
			try
			{
				ret = (PPR_PC1_PROBLEM) this.get_Renamed("PROBLEM");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PPR_PC1_PROBLEM
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PPR_PC1_PROBLEM getPROBLEM(int rep)
		{
			return (PPR_PC1_PROBLEM) this.get_Renamed("PROBLEM", rep);
		}
	}
}