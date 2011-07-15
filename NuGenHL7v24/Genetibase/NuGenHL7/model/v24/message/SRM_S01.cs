using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a SRM_S01 message structure (see chapter 10). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: ARQ (Appointment Request) <b></b><br>
	/// 2: APR (Appointment Preferences) <b>optional </b><br>
	/// 3: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 4: SRM_S01_PATIENT (a Group object) <b>optional repeating</b><br>
	/// 5: SRM_S01_RESOURCES (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SRM_S01:AbstractMessage
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
		/// <summary> Returns ARQ (Appointment Request) - creates it if necessary</summary>
		virtual public ARQ ARQ
		{
			get
			{
				ARQ ret = null;
				try
				{
					ret = (ARQ) this.get_Renamed("ARQ");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns APR (Appointment Preferences) - creates it if necessary</summary>
		virtual public APR APR
		{
			get
			{
				APR ret = null;
				try
				{
					ret = (APR) this.get_Renamed("APR");
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
		/// <summary> Returns the number of existing repetitions of SRM_S01_PATIENT </summary>
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
		/// <summary> Returns the number of existing repetitions of SRM_S01_RESOURCES </summary>
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
		
		/// <summary> Creates a new SRM_S01 Group with custom ModelClassFactory.</summary>
		public SRM_S01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new SRM_S01 Group with DefaultModelClassFactory. </summary>
		public SRM_S01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(ARQ), true, false);
				this.add(typeof(APR), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(SRM_S01_PATIENT), false, true);
				this.add(typeof(SRM_S01_RESOURCES), true, true);
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
		
		/// <summary> Returns  first repetition of SRM_S01_PATIENT (a Group object) - creates it if necessary</summary>
		public virtual SRM_S01_PATIENT getPATIENT()
		{
			SRM_S01_PATIENT ret = null;
			try
			{
				ret = (SRM_S01_PATIENT) this.get_Renamed("PATIENT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRM_S01_PATIENT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRM_S01_PATIENT getPATIENT(int rep)
		{
			return (SRM_S01_PATIENT) this.get_Renamed("PATIENT", rep);
		}
		
		/// <summary> Returns  first repetition of SRM_S01_RESOURCES (a Group object) - creates it if necessary</summary>
		public virtual SRM_S01_RESOURCES getRESOURCES()
		{
			SRM_S01_RESOURCES ret = null;
			try
			{
				ret = (SRM_S01_RESOURCES) this.get_Renamed("RESOURCES");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SRM_S01_RESOURCES
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SRM_S01_RESOURCES getRESOURCES(int rep)
		{
			return (SRM_S01_RESOURCES) this.get_Renamed("RESOURCES", rep);
		}
	}
}