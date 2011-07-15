using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a ADT_A04 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: EVN (EVN - event type segment) <b></b><br>
	/// 2: PID (PID - patient identification segment) <b></b><br>
	/// 3: PD1 (PD1 - patient additional demographic segment) <b>optional </b><br>
	/// 4: NK1 (NK1 - next of kin / associated parties segment-) <b>optional repeating</b><br>
	/// 5: PV1 (PV1 - patient visit segment-) <b></b><br>
	/// 6: PV2 (PV2 - patient visit - additional information segment) <b>optional </b><br>
	/// 7: DB1 (DB1 - Disability segment) <b>optional repeating</b><br>
	/// 8: OBX (OBX - observation/result segment) <b>optional repeating</b><br>
	/// 9: AL1 (AL1 - patient allergy information segment) <b>optional repeating</b><br>
	/// 10: DG1 (DG1 - diagnosis segment) <b>optional repeating</b><br>
	/// 11: DRG (DRG - diagnosis related group segment) <b>optional </b><br>
	/// 12: ADT_A04_PR1ROL (a Group object) <b>optional repeating</b><br>
	/// 13: GT1 (GT1 - guarantor segment) <b>optional repeating</b><br>
	/// 14: ADT_A04_IN1IN2IN3 (a Group object) <b>optional repeating</b><br>
	/// 15: ACC (ACC - accident segment) <b>optional </b><br>
	/// 16: UB1 (UB1 - UB82 data segment) <b>optional </b><br>
	/// 17: UB2 (UB2 - UB92 data segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ADT_A04:AbstractMessage
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
		/// <summary> Returns EVN (EVN - event type segment) - creates it if necessary</summary>
		virtual public EVN EVN
		{
			get
			{
				EVN ret = null;
				try
				{
					ret = (EVN) this.get_Renamed("EVN");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
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
		/// <summary> Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary</summary>
		virtual public PD1 PD1
		{
			get
			{
				PD1 ret = null;
				try
				{
					ret = (PD1) this.get_Renamed("PD1");
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
		/// <summary> Returns PV1 (PV1 - patient visit segment-) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary</summary>
		virtual public PV2 PV2
		{
			get
			{
				PV2 ret = null;
				try
				{
					ret = (PV2) this.get_Renamed("PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DB1 </summary>
		virtual public int DB1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DB1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OBX </summary>
		virtual public int OBXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBX").Length;
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
		/// <summary> Returns DRG (DRG - diagnosis related group segment) - creates it if necessary</summary>
		virtual public DRG DRG
		{
			get
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
			
		}
		/// <summary> Returns the number of existing repetitions of ADT_A04_PR1ROL </summary>
		virtual public int PR1ROLReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PR1ROL").Length;
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
		/// <summary> Returns the number of existing repetitions of ADT_A04_IN1IN2IN3 </summary>
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
		/// <summary> Returns UB1 (UB1 - UB82 data segment) - creates it if necessary</summary>
		virtual public UB1 UB1
		{
			get
			{
				UB1 ret = null;
				try
				{
					ret = (UB1) this.get_Renamed("UB1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns UB2 (UB2 - UB92 data segment) - creates it if necessary</summary>
		virtual public UB2 UB2
		{
			get
			{
				UB2 ret = null;
				try
				{
					ret = (UB2) this.get_Renamed("UB2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ADT_A04 Group with custom ModelClassFactory.</summary>
		public ADT_A04(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A04 Group with DefaultModelClassFactory. </summary>
		public ADT_A04():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(PV1), true, false);
				this.add(typeof(PV2), false, false);
				this.add(typeof(DB1), false, true);
				this.add(typeof(OBX), false, true);
				this.add(typeof(AL1), false, true);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, false);
				this.add(typeof(ADT_A04_PR1ROL), false, true);
				this.add(typeof(GT1), false, true);
				this.add(typeof(ADT_A04_IN1IN2IN3), false, true);
				this.add(typeof(ACC), false, false);
				this.add(typeof(UB1), false, false);
				this.add(typeof(UB2), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
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
		
		/// <summary> Returns  first repetition of DB1 (DB1 - Disability segment) - creates it if necessary</summary>
		public virtual DB1 getDB1()
		{
			DB1 ret = null;
			try
			{
				ret = (DB1) this.get_Renamed("DB1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DB1
		/// (DB1 - Disability segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DB1 getDB1(int rep)
		{
			return (DB1) this.get_Renamed("DB1", rep);
		}
		
		/// <summary> Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary</summary>
		public virtual OBX getOBX()
		{
			OBX ret = null;
			try
			{
				ret = (OBX) this.get_Renamed("OBX");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OBX
		/// (OBX - observation/result segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OBX getOBX(int rep)
		{
			return (OBX) this.get_Renamed("OBX", rep);
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
		
		/// <summary> Returns  first repetition of ADT_A04_PR1ROL (a Group object) - creates it if necessary</summary>
		public virtual ADT_A04_PR1ROL getPR1ROL()
		{
			ADT_A04_PR1ROL ret = null;
			try
			{
				ret = (ADT_A04_PR1ROL) this.get_Renamed("PR1ROL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ADT_A04_PR1ROL
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ADT_A04_PR1ROL getPR1ROL(int rep)
		{
			return (ADT_A04_PR1ROL) this.get_Renamed("PR1ROL", rep);
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
		
		/// <summary> Returns  first repetition of ADT_A04_IN1IN2IN3 (a Group object) - creates it if necessary</summary>
		public virtual ADT_A04_IN1IN2IN3 getIN1IN2IN3()
		{
			ADT_A04_IN1IN2IN3 ret = null;
			try
			{
				ret = (ADT_A04_IN1IN2IN3) this.get_Renamed("IN1IN2IN3");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ADT_A04_IN1IN2IN3
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ADT_A04_IN1IN2IN3 getIN1IN2IN3(int rep)
		{
			return (ADT_A04_IN1IN2IN3) this.get_Renamed("IN1IN2IN3", rep);
		}
	}
}