using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the ADR_A19_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: EVN (EVENT TYPE) <b>optional </b><br>
	/// 1: PID (PATIENT IDENTIFICATION) <b></b><br>
	/// 2: NK1 (NEXT OF KIN) <b>optional repeating</b><br>
	/// 3: PV1 (PATIENT VISIT) <b></b><br>
	/// 4: PV2 (PATIENT VISIT - additional information) <b>optional </b><br>
	/// 5: OBX (OBSERVATION RESULT) <b>optional repeating</b><br>
	/// 6: AL1 (PATIENT ALLERGY INFORMATION) <b>optional repeating</b><br>
	/// 7: DG1 (DIAGNOSIS) <b>optional repeating</b><br>
	/// 8: PR1 (PROCEDURES) <b>optional repeating</b><br>
	/// 9: GT1 (GUARANTOR) <b>optional repeating</b><br>
	/// 10: ADR_A19_INSURANCE (a Group object) <b>optional repeating</b><br>
	/// 11: ACC (ACCIDENT) <b>optional </b><br>
	/// 12: UB1 (UB82 DATA) <b>optional </b><br>
	/// 13: UB2 (UB92 DATA) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ADR_A19_QUERY_RESPONSE:AbstractGroup
	{
		/// <summary> Returns EVN (EVENT TYPE) - creates it if necessary</summary>
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
		/// <summary> Returns PID (PATIENT IDENTIFICATION) - creates it if necessary</summary>
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
		/// <summary> Returns PV1 (PATIENT VISIT) - creates it if necessary</summary>
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
		/// <summary> Returns PV2 (PATIENT VISIT - additional information) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of PR1 </summary>
		virtual public int PR1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PR1").Length;
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
		/// <summary> Returns the number of existing repetitions of ADR_A19_INSURANCE </summary>
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
		/// <summary> Returns ACC (ACCIDENT) - creates it if necessary</summary>
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
		/// <summary> Returns UB1 (UB82 DATA) - creates it if necessary</summary>
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
		/// <summary> Returns UB2 (UB92 DATA) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new ADR_A19_QUERY_RESPONSE Group.</summary>
		public ADR_A19_QUERY_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(EVN), false, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(PV1), true, false);
				this.add(typeof(PV2), false, false);
				this.add(typeof(OBX), false, true);
				this.add(typeof(AL1), false, true);
				this.add(typeof(DG1), false, true);
				this.add(typeof(PR1), false, true);
				this.add(typeof(GT1), false, true);
				this.add(typeof(ADR_A19_INSURANCE), false, true);
				this.add(typeof(ACC), false, false);
				this.add(typeof(UB1), false, false);
				this.add(typeof(UB2), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NK1 (NEXT OF KIN) - creates it if necessary</summary>
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
		/// (NEXT OF KIN) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NK1 getNK1(int rep)
		{
			return (NK1) this.get_Renamed("NK1", rep);
		}
		
		/// <summary> Returns  first repetition of OBX (OBSERVATION RESULT) - creates it if necessary</summary>
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
		/// (OBSERVATION RESULT) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OBX getOBX(int rep)
		{
			return (OBX) this.get_Renamed("OBX", rep);
		}
		
		/// <summary> Returns  first repetition of AL1 (PATIENT ALLERGY INFORMATION) - creates it if necessary</summary>
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
		/// (PATIENT ALLERGY INFORMATION) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual AL1 getAL1(int rep)
		{
			return (AL1) this.get_Renamed("AL1", rep);
		}
		
		/// <summary> Returns  first repetition of DG1 (DIAGNOSIS) - creates it if necessary</summary>
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
		/// (DIAGNOSIS) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DG1 getDG1(int rep)
		{
			return (DG1) this.get_Renamed("DG1", rep);
		}
		
		/// <summary> Returns  first repetition of PR1 (PROCEDURES) - creates it if necessary</summary>
		public virtual PR1 getPR1()
		{
			PR1 ret = null;
			try
			{
				ret = (PR1) this.get_Renamed("PR1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PR1
		/// (PROCEDURES) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PR1 getPR1(int rep)
		{
			return (PR1) this.get_Renamed("PR1", rep);
		}
		
		/// <summary> Returns  first repetition of GT1 (GUARANTOR) - creates it if necessary</summary>
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
		/// (GUARANTOR) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual GT1 getGT1(int rep)
		{
			return (GT1) this.get_Renamed("GT1", rep);
		}
		
		/// <summary> Returns  first repetition of ADR_A19_INSURANCE (a Group object) - creates it if necessary</summary>
		public virtual ADR_A19_INSURANCE getINSURANCE()
		{
			ADR_A19_INSURANCE ret = null;
			try
			{
				ret = (ADR_A19_INSURANCE) this.get_Renamed("INSURANCE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ADR_A19_INSURANCE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ADR_A19_INSURANCE getINSURANCE(int rep)
		{
			return (ADR_A19_INSURANCE) this.get_Renamed("INSURANCE", rep);
		}
	}
}