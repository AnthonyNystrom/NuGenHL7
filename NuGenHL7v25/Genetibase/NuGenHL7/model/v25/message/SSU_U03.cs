using System;
using Genetibase.NuGenHL7.model.v25.group;
using Genetibase.NuGenHL7.model.v25.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v25.message
{
	
	/// <summary> <p>Represents a SSU_U03 message structure (see chapter 13.3.3). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SFT (Software Segment) <b>optional repeating</b><br>
	/// 2: EQU (Equipment Detail) <b></b><br>
	/// 3: SSU_U03_SPECIMEN_CONTAINER (a Group object) <b>repeating</b><br>
	/// 4: ROL (Role) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class SSU_U03:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of SFT </summary>
		virtual public int SFTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SFT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns EQU (Equipment Detail) - creates it if necessary</summary>
		virtual public EQU EQU
		{
			get
			{
				EQU ret = null;
				try
				{
					ret = (EQU) this.get_Renamed("EQU");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SSU_U03_SPECIMEN_CONTAINER </summary>
		virtual public int SPECIMEN_CONTAINERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SPECIMEN_CONTAINER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns ROL (Role) - creates it if necessary</summary>
		virtual public ROL ROL
		{
			get
			{
				ROL ret = null;
				try
				{
					ret = (ROL) this.get_Renamed("ROL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SSU_U03 Group with custom ModelClassFactory.</summary>
		public SSU_U03(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new SSU_U03 Group with DefaultModelClassFactory. </summary>
		public SSU_U03():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SFT), false, true);
				this.add(typeof(EQU), true, false);
				this.add(typeof(SSU_U03_SPECIMEN_CONTAINER), true, true);
				this.add(typeof(ROL), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SFT (Software Segment) - creates it if necessary</summary>
		public virtual SFT getSFT()
		{
			SFT ret = null;
			try
			{
				ret = (SFT) this.get_Renamed("SFT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SFT
		/// (Software Segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SFT getSFT(int rep)
		{
			return (SFT) this.get_Renamed("SFT", rep);
		}
		
		/// <summary> Returns  first repetition of SSU_U03_SPECIMEN_CONTAINER (a Group object) - creates it if necessary</summary>
		public virtual SSU_U03_SPECIMEN_CONTAINER getSPECIMEN_CONTAINER()
		{
			SSU_U03_SPECIMEN_CONTAINER ret = null;
			try
			{
				ret = (SSU_U03_SPECIMEN_CONTAINER) this.get_Renamed("SPECIMEN_CONTAINER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SSU_U03_SPECIMEN_CONTAINER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SSU_U03_SPECIMEN_CONTAINER getSPECIMEN_CONTAINER(int rep)
		{
			return (SSU_U03_SPECIMEN_CONTAINER) this.get_Renamed("SPECIMEN_CONTAINER", rep);
		}
	}
}