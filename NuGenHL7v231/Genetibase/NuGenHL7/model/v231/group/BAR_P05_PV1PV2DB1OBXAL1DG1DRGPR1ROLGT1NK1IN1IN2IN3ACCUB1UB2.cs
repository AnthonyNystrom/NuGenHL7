using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PV1 (PV1 - patient visit segment-) <b>optional </b><br>
	/// 1: PV2 (PV2 - patient visit - additional information segment) <b>optional </b><br>
	/// 2: DB1 (DB1 - Disability segment) <b>optional repeating</b><br>
	/// 3: OBX (OBX - observation/result segment) <b>optional repeating</b><br>
	/// 4: AL1 (AL1 - patient allergy information segment) <b>optional repeating</b><br>
	/// 5: DG1 (DG1 - diagnosis segment) <b>optional repeating</b><br>
	/// 6: DRG (DRG - diagnosis related group segment) <b>optional </b><br>
	/// 7: BAR_P05_PR1ROL (a Group object) <b>optional repeating</b><br>
	/// 8: GT1 (GT1 - guarantor segment) <b>optional repeating</b><br>
	/// 9: NK1 (NK1 - next of kin / associated parties segment-) <b>optional repeating</b><br>
	/// 10: BAR_P05_IN1IN2IN3 (a Group object) <b>optional repeating</b><br>
	/// 11: ACC (ACC - accident segment) <b>optional </b><br>
	/// 12: UB1 (UB1 - UB82 data segment) <b>optional </b><br>
	/// 13: UB2 (UB2 - UB92 data segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2:AbstractGroup
	{
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
		/// <summary> Returns the number of existing repetitions of BAR_P05_PR1ROL </summary>
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
		/// <summary> Returns the number of existing repetitions of BAR_P05_IN1IN2IN3 </summary>
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
		
		/// <summary> Creates a new BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 Group.</summary>
		public BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PV1), false, false);
				this.add(typeof(PV2), false, false);
				this.add(typeof(DB1), false, true);
				this.add(typeof(OBX), false, true);
				this.add(typeof(AL1), false, true);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, false);
				this.add(typeof(BAR_P05_PR1ROL), false, true);
				this.add(typeof(GT1), false, true);
				this.add(typeof(NK1), false, true);
				this.add(typeof(BAR_P05_IN1IN2IN3), false, true);
				this.add(typeof(ACC), false, false);
				this.add(typeof(UB1), false, false);
				this.add(typeof(UB2), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
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
		
		/// <summary> Returns  first repetition of BAR_P05_PR1ROL (a Group object) - creates it if necessary</summary>
		public virtual BAR_P05_PR1ROL getPR1ROL()
		{
			BAR_P05_PR1ROL ret = null;
			try
			{
				ret = (BAR_P05_PR1ROL) this.get_Renamed("PR1ROL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BAR_P05_PR1ROL
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BAR_P05_PR1ROL getPR1ROL(int rep)
		{
			return (BAR_P05_PR1ROL) this.get_Renamed("PR1ROL", rep);
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
		
		/// <summary> Returns  first repetition of BAR_P05_IN1IN2IN3 (a Group object) - creates it if necessary</summary>
		public virtual BAR_P05_IN1IN2IN3 getIN1IN2IN3()
		{
			BAR_P05_IN1IN2IN3 ret = null;
			try
			{
				ret = (BAR_P05_IN1IN2IN3) this.get_Renamed("IN1IN2IN3");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BAR_P05_IN1IN2IN3
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BAR_P05_IN1IN2IN3 getIN1IN2IN3(int rep)
		{
			return (BAR_P05_IN1IN2IN3) this.get_Renamed("IN1IN2IN3", rep);
		}
	}
}