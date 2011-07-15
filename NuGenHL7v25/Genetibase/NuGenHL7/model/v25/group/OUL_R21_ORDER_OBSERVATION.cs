using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OUL_R21_ORDER_OBSERVATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OUL_R21_CONTAINER (a Group object) <b>optional </b><br>
	/// 1: ORC (Common Order) <b>optional </b><br>
	/// 2: OBR (Observation Request) <b></b><br>
	/// 3: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 4: OUL_R21_TIMING_QTY (a Group object) <b>optional repeating</b><br>
	/// 5: OUL_R21_OBSERVATION (a Group object) <b>repeating</b><br>
	/// 6: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OUL_R21_ORDER_OBSERVATION:AbstractGroup
	{
		/// <summary> Returns OUL_R21_CONTAINER (a Group object) - creates it if necessary</summary>
		virtual public OUL_R21_CONTAINER CONTAINER
		{
			get
			{
				OUL_R21_CONTAINER ret = null;
				try
				{
					ret = (OUL_R21_CONTAINER) this.get_Renamed("CONTAINER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
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
		/// <summary> Returns the number of existing repetitions of OUL_R21_TIMING_QTY </summary>
		virtual public int TIMING_QTYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING_QTY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OUL_R21_OBSERVATION </summary>
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
		/// <summary> Returns the number of existing repetitions of CTI </summary>
		virtual public int CTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OUL_R21_ORDER_OBSERVATION Group.</summary>
		public OUL_R21_ORDER_OBSERVATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OUL_R21_CONTAINER), false, false);
				this.add(typeof(ORC), false, false);
				this.add(typeof(OBR), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OUL_R21_TIMING_QTY), false, true);
				this.add(typeof(OUL_R21_OBSERVATION), true, true);
				this.add(typeof(CTI), false, true);
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
		
		/// <summary> Returns  first repetition of OUL_R21_TIMING_QTY (a Group object) - creates it if necessary</summary>
		public virtual OUL_R21_TIMING_QTY getTIMING_QTY()
		{
			OUL_R21_TIMING_QTY ret = null;
			try
			{
				ret = (OUL_R21_TIMING_QTY) this.get_Renamed("TIMING_QTY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OUL_R21_TIMING_QTY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OUL_R21_TIMING_QTY getTIMING_QTY(int rep)
		{
			return (OUL_R21_TIMING_QTY) this.get_Renamed("TIMING_QTY", rep);
		}
		
		/// <summary> Returns  first repetition of OUL_R21_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual OUL_R21_OBSERVATION getOBSERVATION()
		{
			OUL_R21_OBSERVATION ret = null;
			try
			{
				ret = (OUL_R21_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OUL_R21_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OUL_R21_OBSERVATION getOBSERVATION(int rep)
		{
			return (OUL_R21_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
		
		/// <summary> Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary</summary>
		public virtual CTI getCTI()
		{
			CTI ret = null;
			try
			{
				ret = (CTI) this.get_Renamed("CTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CTI
		/// (Clinical Trial Identification) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CTI getCTI(int rep)
		{
			return (CTI) this.get_Renamed("CTI", rep);
		}
	}
}