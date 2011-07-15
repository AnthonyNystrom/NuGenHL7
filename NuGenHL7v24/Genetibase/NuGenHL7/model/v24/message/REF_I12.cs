using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a REF_I12 message structure (see chapter 11). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: RF1 (Referral Information) <b>optional </b><br>
	/// 2: REF_I12_AUTHORIZATION_CONTACT (a Group object) <b>optional </b><br>
	/// 3: REF_I12_PROVIDER_CONTACT (a Group object) <b>repeating</b><br>
	/// 4: PID (Patient identification) <b></b><br>
	/// 5: NK1 (Next of kin / associated parties) <b>optional repeating</b><br>
	/// 6: GT1 (Guarantor) <b>optional repeating</b><br>
	/// 7: REF_I12_INSURANCE (a Group object) <b>optional repeating</b><br>
	/// 8: ACC (Accident) <b>optional </b><br>
	/// 9: DG1 (Diagnosis) <b>optional repeating</b><br>
	/// 10: DRG (Diagnosis Related Group) <b>optional repeating</b><br>
	/// 11: AL1 (Patient allergy information) <b>optional repeating</b><br>
	/// 12: REF_I12_PROCEDURE (a Group object) <b>optional repeating</b><br>
	/// 13: REF_I12_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// 14: REF_I12_PATIENT_VISIT (a Group object) <b>optional </b><br>
	/// 15: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class REF_I12:AbstractMessage
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
		/// <summary> Returns REF_I12_AUTHORIZATION_CONTACT (a Group object) - creates it if necessary</summary>
		virtual public REF_I12_AUTHORIZATION_CONTACT AUTHORIZATION_CONTACT
		{
			get
			{
				REF_I12_AUTHORIZATION_CONTACT ret = null;
				try
				{
					ret = (REF_I12_AUTHORIZATION_CONTACT) this.get_Renamed("AUTHORIZATION_CONTACT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of REF_I12_PROVIDER_CONTACT </summary>
		virtual public int PROVIDER_CONTACTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PROVIDER_CONTACT").Length;
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
		/// <summary> Returns the number of existing repetitions of GT1 </summary>
		virtual public int GT1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GT1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of REF_I12_INSURANCE </summary>
		virtual public int INSURANCEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("INSURANCE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		/// <summary> Returns the number of existing repetitions of REF_I12_PROCEDURE </summary>
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
		/// <summary> Returns the number of existing repetitions of REF_I12_OBSERVATION </summary>
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
		/// <summary> Returns REF_I12_PATIENT_VISIT (a Group object) - creates it if necessary</summary>
		virtual public REF_I12_PATIENT_VISIT PATIENT_VISIT
		{
			get
			{
				REF_I12_PATIENT_VISIT ret = null;
				try
				{
					ret = (REF_I12_PATIENT_VISIT) this.get_Renamed("PATIENT_VISIT");
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
		
		/// <summary> Creates a new REF_I12 Group with custom ModelClassFactory.</summary>
		public REF_I12(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new REF_I12 Group with DefaultModelClassFactory. </summary>
		public REF_I12():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(RF1), false, false);
				this.add(typeof(REF_I12_AUTHORIZATION_CONTACT), false, false);
				this.add(typeof(REF_I12_PROVIDER_CONTACT), true, true);
				this.add(typeof(PID), true, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(GT1), false, true);
				this.add(typeof(REF_I12_INSURANCE), false, true);
				this.add(typeof(ACC), false, false);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, true);
				this.add(typeof(AL1), false, true);
				this.add(typeof(REF_I12_PROCEDURE), false, true);
				this.add(typeof(REF_I12_OBSERVATION), false, true);
				this.add(typeof(REF_I12_PATIENT_VISIT), false, false);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of REF_I12_PROVIDER_CONTACT (a Group object) - creates it if necessary</summary>
		public virtual REF_I12_PROVIDER_CONTACT getPROVIDER_CONTACT()
		{
			REF_I12_PROVIDER_CONTACT ret = null;
			try
			{
				ret = (REF_I12_PROVIDER_CONTACT) this.get_Renamed("PROVIDER_CONTACT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of REF_I12_PROVIDER_CONTACT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual REF_I12_PROVIDER_CONTACT getPROVIDER_CONTACT(int rep)
		{
			return (REF_I12_PROVIDER_CONTACT) this.get_Renamed("PROVIDER_CONTACT", rep);
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
		
		/// <summary> Returns  first repetition of GT1 (Guarantor) - creates it if necessary</summary>
		public virtual GT1 getGT1()
		{
			GT1 ret = null;
			try
			{
				ret = (GT1) this.get_Renamed("GT1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of GT1
		/// (Guarantor) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual GT1 getGT1(int rep)
		{
			return (GT1) this.get_Renamed("GT1", rep);
		}
		
		/// <summary> Returns  first repetition of REF_I12_INSURANCE (a Group object) - creates it if necessary</summary>
		public virtual REF_I12_INSURANCE getINSURANCE()
		{
			REF_I12_INSURANCE ret = null;
			try
			{
				ret = (REF_I12_INSURANCE) this.get_Renamed("INSURANCE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of REF_I12_INSURANCE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual REF_I12_INSURANCE getINSURANCE(int rep)
		{
			return (REF_I12_INSURANCE) this.get_Renamed("INSURANCE", rep);
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
		
		/// <summary> Returns  first repetition of REF_I12_PROCEDURE (a Group object) - creates it if necessary</summary>
		public virtual REF_I12_PROCEDURE getPROCEDURE()
		{
			REF_I12_PROCEDURE ret = null;
			try
			{
				ret = (REF_I12_PROCEDURE) this.get_Renamed("PROCEDURE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of REF_I12_PROCEDURE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual REF_I12_PROCEDURE getPROCEDURE(int rep)
		{
			return (REF_I12_PROCEDURE) this.get_Renamed("PROCEDURE", rep);
		}
		
		/// <summary> Returns  first repetition of REF_I12_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual REF_I12_OBSERVATION getOBSERVATION()
		{
			REF_I12_OBSERVATION ret = null;
			try
			{
				ret = (REF_I12_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of REF_I12_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual REF_I12_OBSERVATION getOBSERVATION(int rep)
		{
			return (REF_I12_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
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