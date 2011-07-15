using System;
using Genetibase.NuGenHL7.model.v22.group;
using Genetibase.NuGenHL7.model.v22.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v22.message
{
	
	/// <summary> <p>Represents a ORU_R01 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MESSAGE HEADER) <b></b><br>
	/// 1: ORU_R01_PATIENT_RESULT (a Group object) <b>repeating</b><br>
	/// 2: DSC (CONTINUATION POINTER) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORU_R01:AbstractMessage
	{
		/// <summary> Returns MSH (MESSAGE HEADER) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of ORU_R01_PATIENT_RESULT </summary>
		virtual public int PATIENT_RESULTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PATIENT_RESULT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns DSC (CONTINUATION POINTER) - creates it if necessary</summary>
		virtual public DSC DSC
		{
			get
			{
				DSC ret = null;
				try
				{
					ret = (DSC) this.get_Renamed("DSC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ORU_R01 Group with custom ModelClassFactory.</summary>
		public ORU_R01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ORU_R01 Group with DefaultModelClassFactory. </summary>
		public ORU_R01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(ORU_R01_PATIENT_RESULT), true, true);
				this.add(typeof(DSC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORU_R01_PATIENT_RESULT (a Group object) - creates it if necessary</summary>
		public virtual ORU_R01_PATIENT_RESULT getPATIENT_RESULT()
		{
			ORU_R01_PATIENT_RESULT ret = null;
			try
			{
				ret = (ORU_R01_PATIENT_RESULT) this.get_Renamed("PATIENT_RESULT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORU_R01_PATIENT_RESULT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORU_R01_PATIENT_RESULT getPATIENT_RESULT(int rep)
		{
			return (ORU_R01_PATIENT_RESULT) this.get_Renamed("PATIENT_RESULT", rep);
		}
	}
}