using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OML_O21_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: OML_O21_TIIMING (a Group object) <b>optional repeating</b><br>
	/// 2: OML_O21_OBSERVATION_REQUEST (a Group object) <b>optional </b><br>
	/// 3: FT1 (Financial Transaction) <b>optional repeating</b><br>
	/// 4: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
	/// 5: BLG (Billing) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OML_O21_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of OML_O21_TIIMING </summary>
		virtual public int TIIMINGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIIMING").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns OML_O21_OBSERVATION_REQUEST (a Group object) - creates it if necessary</summary>
		virtual public OML_O21_OBSERVATION_REQUEST OBSERVATION_REQUEST
		{
			get
			{
				OML_O21_OBSERVATION_REQUEST ret = null;
				try
				{
					ret = (OML_O21_OBSERVATION_REQUEST) this.get_Renamed("OBSERVATION_REQUEST");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of FT1 </summary>
		virtual public int FT1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("FT1").Length;
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
		/// <summary> Returns BLG (Billing) - creates it if necessary</summary>
		virtual public BLG BLG
		{
			get
			{
				BLG ret = null;
				try
				{
					ret = (BLG) this.get_Renamed("BLG");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new OML_O21_ORDER Group.</summary>
		public OML_O21_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OML_O21_TIIMING), false, true);
				this.add(typeof(OML_O21_OBSERVATION_REQUEST), false, false);
				this.add(typeof(FT1), false, true);
				this.add(typeof(CTI), false, true);
				this.add(typeof(BLG), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OML_O21_TIIMING (a Group object) - creates it if necessary</summary>
		public virtual OML_O21_TIIMING getTIIMING()
		{
			OML_O21_TIIMING ret = null;
			try
			{
				ret = (OML_O21_TIIMING) this.get_Renamed("TIIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O21_TIIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O21_TIIMING getTIIMING(int rep)
		{
			return (OML_O21_TIIMING) this.get_Renamed("TIIMING", rep);
		}
		
		/// <summary> Returns  first repetition of FT1 (Financial Transaction) - creates it if necessary</summary>
		public virtual FT1 getFT1()
		{
			FT1 ret = null;
			try
			{
				ret = (FT1) this.get_Renamed("FT1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of FT1
		/// (Financial Transaction) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual FT1 getFT1(int rep)
		{
			return (FT1) this.get_Renamed("FT1", rep);
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