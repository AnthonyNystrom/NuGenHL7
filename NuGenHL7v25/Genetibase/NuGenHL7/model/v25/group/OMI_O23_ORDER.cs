using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OMI_O23_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: OMI_O23_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: OBR (Observation Request) <b></b><br>
	/// 3: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 4: CTD (Contact Data) <b>optional </b><br>
	/// 5: DG1 (Diagnosis) <b>optional repeating</b><br>
	/// 6: OMI_O23_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// 7: IPC (Imaging Procedure Control Segment) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OMI_O23_ORDER:AbstractGroup
	{
		/// <summary> Returns ORC (Common Order) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OMI_O23_TIMING </summary>
		virtual public int TIMINGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns OBR (Observation Request) - creates it if necessary</summary>
		virtual public OBR OBR
		{
			get
			{
				OBR ret = null;
				try
				{
					ret = (OBR) this.get_Renamed("OBR");
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
		/// <summary> Returns CTD (Contact Data) - creates it if necessary</summary>
		virtual public CTD CTD
		{
			get
			{
				CTD ret = null;
				try
				{
					ret = (CTD) this.get_Renamed("CTD");
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
		/// <summary> Returns the number of existing repetitions of OMI_O23_OBSERVATION </summary>
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
		/// <summary> Returns the number of existing repetitions of IPC </summary>
		virtual public int IPCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("IPC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OMI_O23_ORDER Group.</summary>
		public OMI_O23_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OMI_O23_TIMING), false, true);
				this.add(typeof(OBR), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(CTD), false, false);
				this.add(typeof(DG1), false, true);
				this.add(typeof(OMI_O23_OBSERVATION), false, true);
				this.add(typeof(IPC), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OMI_O23_TIMING (a Group object) - creates it if necessary</summary>
		public virtual OMI_O23_TIMING getTIMING()
		{
			OMI_O23_TIMING ret = null;
			try
			{
				ret = (OMI_O23_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMI_O23_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMI_O23_TIMING getTIMING(int rep)
		{
			return (OMI_O23_TIMING) this.get_Renamed("TIMING", rep);
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
		
		/// <summary> Returns  first repetition of OMI_O23_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual OMI_O23_OBSERVATION getOBSERVATION()
		{
			OMI_O23_OBSERVATION ret = null;
			try
			{
				ret = (OMI_O23_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMI_O23_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMI_O23_OBSERVATION getOBSERVATION(int rep)
		{
			return (OMI_O23_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
		
		/// <summary> Returns  first repetition of IPC (Imaging Procedure Control Segment) - creates it if necessary</summary>
		public virtual IPC getIPC()
		{
			IPC ret = null;
			try
			{
				ret = (IPC) this.get_Renamed("IPC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of IPC
		/// (Imaging Procedure Control Segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual IPC getIPC(int rep)
		{
			return (IPC) this.get_Renamed("IPC", rep);
		}
	}
}