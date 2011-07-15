using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a SIU_S12 message structure (see chapter 10). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SCH (Scheduling Activity Information) <b></b><br>
	/// 2: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 3: SIU_S12_PATIENT (a Group object) <b>optional repeating</b><br>
	/// 4: SIU_S12_RESOURCES (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SIU_S12:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of SIU_S12_PATIENT </summary>
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
		/// <summary> Returns the number of existing repetitions of SIU_S12_RESOURCES </summary>
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
		
		/// <summary> Creates a new SIU_S12 Group with custom ModelClassFactory.</summary>
		public SIU_S12(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new SIU_S12 Group with DefaultModelClassFactory. </summary>
		public SIU_S12():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SCH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(SIU_S12_PATIENT), false, true);
				this.add(typeof(SIU_S12_RESOURCES), true, true);
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
		
		/// <summary> Returns  first repetition of SIU_S12_PATIENT (a Group object) - creates it if necessary</summary>
		public virtual SIU_S12_PATIENT getPATIENT()
		{
			SIU_S12_PATIENT ret = null;
			try
			{
				ret = (SIU_S12_PATIENT) this.get_Renamed("PATIENT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SIU_S12_PATIENT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SIU_S12_PATIENT getPATIENT(int rep)
		{
			return (SIU_S12_PATIENT) this.get_Renamed("PATIENT", rep);
		}
		
		/// <summary> Returns  first repetition of SIU_S12_RESOURCES (a Group object) - creates it if necessary</summary>
		public virtual SIU_S12_RESOURCES getRESOURCES()
		{
			SIU_S12_RESOURCES ret = null;
			try
			{
				ret = (SIU_S12_RESOURCES) this.get_Renamed("RESOURCES");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SIU_S12_RESOURCES
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SIU_S12_RESOURCES getRESOURCES(int rep)
		{
			return (SIU_S12_RESOURCES) this.get_Renamed("RESOURCES", rep);
		}
	}
}