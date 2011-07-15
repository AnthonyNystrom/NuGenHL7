using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a RPA_I08 message structure (see chapter null). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: MSA (MSA - message acknowledgment segment) <b></b><br>
	/// 2: RF1 (Referral Infomation) <b>optional </b><br>
	/// 3: RPA_I08_AUTCTD (a Group object) <b>optional </b><br>
	/// 4: RPA_I08_PRDCTD (a Group object) <b>repeating</b><br>
	/// 5: PID (PID - patient identification segment) <b></b><br>
	/// 6: NK1 (NK1 - next of kin / associated parties segment-) <b>optional repeating</b><br>
	/// 7: GT1 (GT1 - guarantor segment) <b>optional repeating</b><br>
	/// 8: RPA_I08_IN1IN2IN3 (a Group object) <b>optional repeating</b><br>
	/// 9: ACC (ACC - accident segment) <b>optional </b><br>
	/// 10: DG1 (DG1 - diagnosis segment) <b>optional repeating</b><br>
	/// 11: DRG (DRG - diagnosis related group segment) <b>optional repeating</b><br>
	/// 12: AL1 (AL1 - patient allergy information segment) <b>optional repeating</b><br>
	/// 13: RPA_I08_PR1AUTCTD (a Group object) <b>repeating</b><br>
	/// 14: RPA_I08_OBRNTEOBXNTE (a Group object) <b>optional repeating</b><br>
	/// 15: RPA_I08_PV1PV2 (a Group object) <b>optional </b><br>
	/// 16: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RPA_I08:AbstractMessage
	{
		/// <summary> Returns MSH (MSH - message header segment) - creates it if necessary</summary>
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
		/// <summary> Returns MSA (MSA - message acknowledgment segment) - creates it if necessary</summary>
		virtual public MSA MSA
		{
			get
			{
				MSA ret = null;
				try
				{
					ret = (MSA) this.get_Renamed("MSA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RF1 (Referral Infomation) - creates it if necessary</summary>
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
		/// <summary> Returns RPA_I08_AUTCTD (a Group object) - creates it if necessary</summary>
		virtual public RPA_I08_AUTCTD AUTCTD
		{
			get
			{
				RPA_I08_AUTCTD ret = null;
				try
				{
					ret = (RPA_I08_AUTCTD) this.get_Renamed("AUTCTD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RPA_I08_PRDCTD </summary>
		virtual public int PRDCTDReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRDCTD").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns PID (PID - patient identification segment) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of RPA_I08_IN1IN2IN3 </summary>
		virtual public int IN1IN2IN3Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("IN1IN2IN3").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns ACC (ACC - accident segment) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of RPA_I08_PR1AUTCTD </summary>
		virtual public int PR1AUTCTDReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PR1AUTCTD").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RPA_I08_OBRNTEOBXNTE </summary>
		virtual public int OBRNTEOBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBRNTEOBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RPA_I08_PV1PV2 (a Group object) - creates it if necessary</summary>
		virtual public RPA_I08_PV1PV2 PV1PV2
		{
			get
			{
				RPA_I08_PV1PV2 ret = null;
				try
				{
					ret = (RPA_I08_PV1PV2) this.get_Renamed("PV1PV2");
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
		
		/// <summary> Creates a new RPA_I08 Group with custom ModelClassFactory.</summary>
		public RPA_I08(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new RPA_I08 Group with DefaultModelClassFactory. </summary>
		public RPA_I08():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(RF1), false, false);
				this.add(typeof(RPA_I08_AUTCTD), false, false);
				this.add(typeof(RPA_I08_PRDCTD), true, true);
				this.add(typeof(PID), true, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(GT1), false, true);
				this.add(typeof(RPA_I08_IN1IN2IN3), false, true);
				this.add(typeof(ACC), false, false);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, true);
				this.add(typeof(AL1), false, true);
				this.add(typeof(RPA_I08_PR1AUTCTD), true, true);
				this.add(typeof(RPA_I08_OBRNTEOBXNTE), false, true);
				this.add(typeof(RPA_I08_PV1PV2), false, false);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RPA_I08_PRDCTD (a Group object) - creates it if necessary</summary>
		public virtual RPA_I08_PRDCTD getPRDCTD()
		{
			RPA_I08_PRDCTD ret = null;
			try
			{
				ret = (RPA_I08_PRDCTD) this.get_Renamed("PRDCTD");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RPA_I08_PRDCTD
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RPA_I08_PRDCTD getPRDCTD(int rep)
		{
			return (RPA_I08_PRDCTD) this.get_Renamed("PRDCTD", rep);
		}
		
		/// <summary> Returns  first repetition of NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary</summary>
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
		/// (NK1 - next of kin / associated parties segment-) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NK1 getNK1(int rep)
		{
			return (NK1) this.get_Renamed("NK1", rep);
		}
		
		/// <summary> Returns  first repetition of GT1 (GT1 - guarantor segment) - creates it if necessary</summary>
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
		/// (GT1 - guarantor segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual GT1 getGT1(int rep)
		{
			return (GT1) this.get_Renamed("GT1", rep);
		}
		
		/// <summary> Returns  first repetition of RPA_I08_IN1IN2IN3 (a Group object) - creates it if necessary</summary>
		public virtual RPA_I08_IN1IN2IN3 getIN1IN2IN3()
		{
			RPA_I08_IN1IN2IN3 ret = null;
			try
			{
				ret = (RPA_I08_IN1IN2IN3) this.get_Renamed("IN1IN2IN3");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RPA_I08_IN1IN2IN3
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RPA_I08_IN1IN2IN3 getIN1IN2IN3(int rep)
		{
			return (RPA_I08_IN1IN2IN3) this.get_Renamed("IN1IN2IN3", rep);
		}
		
		/// <summary> Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary</summary>
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
		/// (DG1 - diagnosis segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DG1 getDG1(int rep)
		{
			return (DG1) this.get_Renamed("DG1", rep);
		}
		
		/// <summary> Returns  first repetition of DRG (DRG - diagnosis related group segment) - creates it if necessary</summary>
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
		/// (DRG - diagnosis related group segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DRG getDRG(int rep)
		{
			return (DRG) this.get_Renamed("DRG", rep);
		}
		
		/// <summary> Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if necessary</summary>
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
		/// (AL1 - patient allergy information segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual AL1 getAL1(int rep)
		{
			return (AL1) this.get_Renamed("AL1", rep);
		}
		
		/// <summary> Returns  first repetition of RPA_I08_PR1AUTCTD (a Group object) - creates it if necessary</summary>
		public virtual RPA_I08_PR1AUTCTD getPR1AUTCTD()
		{
			RPA_I08_PR1AUTCTD ret = null;
			try
			{
				ret = (RPA_I08_PR1AUTCTD) this.get_Renamed("PR1AUTCTD");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RPA_I08_PR1AUTCTD
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RPA_I08_PR1AUTCTD getPR1AUTCTD(int rep)
		{
			return (RPA_I08_PR1AUTCTD) this.get_Renamed("PR1AUTCTD", rep);
		}
		
		/// <summary> Returns  first repetition of RPA_I08_OBRNTEOBXNTE (a Group object) - creates it if necessary</summary>
		public virtual RPA_I08_OBRNTEOBXNTE getOBRNTEOBXNTE()
		{
			RPA_I08_OBRNTEOBXNTE ret = null;
			try
			{
				ret = (RPA_I08_OBRNTEOBXNTE) this.get_Renamed("OBRNTEOBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RPA_I08_OBRNTEOBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RPA_I08_OBRNTEOBXNTE getOBRNTEOBXNTE(int rep)
		{
			return (RPA_I08_OBRNTEOBXNTE) this.get_Renamed("OBRNTEOBXNTE", rep);
		}
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
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
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
	}
}