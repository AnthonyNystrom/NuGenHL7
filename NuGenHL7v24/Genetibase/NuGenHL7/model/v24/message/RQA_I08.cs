using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a RQA_I08 message structure (see chapter 11). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: RF1 (Referral Information) <b>optional </b><br>
	/// 2: RQA_I08_AUTHORIZATION (a Group object) <b>optional </b><br>
	/// 3: RQA_I08_PROVIDER (a Group object) <b>repeating</b><br>
	/// 4: PID (Patient identification) <b></b><br>
	/// 5: NK1 (Next of kin / associated parties) <b>optional repeating</b><br>
	/// 6: RQA_I08_GUARANTOR_INSURANCE (a Group object) <b>optional </b><br>
	/// 7: ACC (Accident) <b>optional </b><br>
	/// 8: DG1 (Diagnosis) <b>optional repeating</b><br>
	/// 9: DRG (Diagnosis Related Group) <b>optional repeating</b><br>
	/// 10: AL1 (Patient allergy information) <b>optional repeating</b><br>
	/// 11: RQA_I08_PROCEDURE (a Group object) <b>optional repeating</b><br>
	/// 12: RQA_I08_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// 13: RQA_I08_VISIT (a Group object) <b>optional </b><br>
	/// 14: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RQA_I08:AbstractMessage
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
		/// <summary> Returns RF1 (Referral Information) - creates it if necessary</summary>
		virtual public RF1 RF1
		{
			get
			{
				RF1 ret = null;
				try
				{
					ret = (RF1) this.get_Renamed("RF1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RQA_I08_AUTHORIZATION (a Group object) - creates it if necessary</summary>
		virtual public RQA_I08_AUTHORIZATION AUTHORIZATION
		{
			get
			{
				RQA_I08_AUTHORIZATION ret = null;
				try
				{
					ret = (RQA_I08_AUTHORIZATION) this.get_Renamed("AUTHORIZATION");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RQA_I08_PROVIDER </summary>
		virtual public int PROVIDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROVIDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		/// <summary> Returns RQA_I08_GUARANTOR_INSURANCE (a Group object) - creates it if necessary</summary>
		virtual public RQA_I08_GUARANTOR_INSURANCE GUARANTOR_INSURANCE
		{
			get
			{
				RQA_I08_GUARANTOR_INSURANCE ret = null;
				try
				{
					ret = (RQA_I08_GUARANTOR_INSURANCE) this.get_Renamed("GUARANTOR_INSURANCE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ACC (Accident) - creates it if necessary</summary>
		virtual public ACC ACC
		{
			get
			{
				ACC ret = null;
				try
				{
					ret = (ACC) this.get_Renamed("ACC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DG1 </summary>
		virtual public int DG1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DG1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DRG </summary>
		virtual public int DRGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DRG").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of AL1 </summary>
		virtual public int AL1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AL1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RQA_I08_PROCEDURE </summary>
		virtual public int PROCEDUREReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROCEDURE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RQA_I08_OBSERVATION </summary>
		virtual public int OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RQA_I08_VISIT (a Group object) - creates it if necessary</summary>
		virtual public RQA_I08_VISIT VISIT
		{
			get
			{
				RQA_I08_VISIT ret = null;
				try
				{
					ret = (RQA_I08_VISIT) this.get_Renamed("VISIT");
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
		
		/// <summary> Creates a new RQA_I08 Group with custom ModelClassFactory.</summary>
		public RQA_I08(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new RQA_I08 Group with DefaultModelClassFactory. </summary>
		public RQA_I08():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(RF1), false, false);
				this.add(typeof(RQA_I08_AUTHORIZATION), false, false);
				this.add(typeof(RQA_I08_PROVIDER), true, true);
				this.add(typeof(PID), true, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(RQA_I08_GUARANTOR_INSURANCE), false, false);
				this.add(typeof(ACC), false, false);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, true);
				this.add(typeof(AL1), false, true);
				this.add(typeof(RQA_I08_PROCEDURE), false, true);
				this.add(typeof(RQA_I08_OBSERVATION), false, true);
				this.add(typeof(RQA_I08_VISIT), false, false);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RQA_I08_PROVIDER (a Group object) - creates it if necessary</summary>
		public virtual RQA_I08_PROVIDER getPROVIDER()
		{
			RQA_I08_PROVIDER ret = null;
			try
			{
				ret = (RQA_I08_PROVIDER) this.get_Renamed("PROVIDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RQA_I08_PROVIDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RQA_I08_PROVIDER getPROVIDER(int rep)
		{
			return (RQA_I08_PROVIDER) this.get_Renamed("PROVIDER", rep);
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
		
		/// <summary> Returns  first repetition of DG1 (Diagnosis) - creates it if necessary</summary>
		public virtual DG1 getDG1()
		{
			DG1 ret = null;
			try
			{
				ret = (DG1) this.get_Renamed("DG1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DG1
		/// (Diagnosis) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DG1 getDG1(int rep)
		{
			return (DG1) this.get_Renamed("DG1", rep);
		}
		
		/// <summary> Returns  first repetition of DRG (Diagnosis Related Group) - creates it if necessary</summary>
		public virtual DRG getDRG()
		{
			DRG ret = null;
			try
			{
				ret = (DRG) this.get_Renamed("DRG");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DRG
		/// (Diagnosis Related Group) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DRG getDRG(int rep)
		{
			return (DRG) this.get_Renamed("DRG", rep);
		}
		
		/// <summary> Returns  first repetition of AL1 (Patient allergy information) - creates it if necessary</summary>
		public virtual AL1 getAL1()
		{
			AL1 ret = null;
			try
			{
				ret = (AL1) this.get_Renamed("AL1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of AL1
		/// (Patient allergy information) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual AL1 getAL1(int rep)
		{
			return (AL1) this.get_Renamed("AL1", rep);
		}
		
		/// <summary> Returns  first repetition of RQA_I08_PROCEDURE (a Group object) - creates it if necessary</summary>
		public virtual RQA_I08_PROCEDURE getPROCEDURE()
		{
			RQA_I08_PROCEDURE ret = null;
			try
			{
				ret = (RQA_I08_PROCEDURE) this.get_Renamed("PROCEDURE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RQA_I08_PROCEDURE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RQA_I08_PROCEDURE getPROCEDURE(int rep)
		{
			return (RQA_I08_PROCEDURE) this.get_Renamed("PROCEDURE", rep);
		}
		
		/// <summary> Returns  first repetition of RQA_I08_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual RQA_I08_OBSERVATION getOBSERVATION()
		{
			RQA_I08_OBSERVATION ret = null;
			try
			{
				ret = (RQA_I08_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RQA_I08_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RQA_I08_OBSERVATION getOBSERVATION(int rep)
		{
			return (RQA_I08_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
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