using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OMD_O03_ORDER_TRAY Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: OMD_O03_TIMING_TRAY (a Group object) <b>optional repeating</b><br>
	/// 2: ODT (Diet Tray Instructions) <b>repeating</b><br>
	/// 3: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OMD_O03_ORDER_TRAY:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of OMD_O03_TIMING_TRAY </summary>
		virtual public int TIMING_TRAYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING_TRAY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ODT </summary>
		virtual public int ODTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ODT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		
		/// <summary> Creates a new OMD_O03_ORDER_TRAY Group.</summary>
		public OMD_O03_ORDER_TRAY(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OMD_O03_TIMING_TRAY), false, true);
				this.add(typeof(ODT), true, true);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OMD_O03_TIMING_TRAY (a Group object) - creates it if necessary</summary>
		public virtual OMD_O03_TIMING_TRAY getTIMING_TRAY()
		{
			OMD_O03_TIMING_TRAY ret = null;
			try
			{
				ret = (OMD_O03_TIMING_TRAY) this.get_Renamed("TIMING_TRAY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O03_TIMING_TRAY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O03_TIMING_TRAY getTIMING_TRAY(int rep)
		{
			return (OMD_O03_TIMING_TRAY) this.get_Renamed("TIMING_TRAY", rep);
		}
		
		/// <summary> Returns  first repetition of ODT (Diet Tray Instructions) - creates it if necessary</summary>
		public virtual ODT getODT()
		{
			ODT ret = null;
			try
			{
				ret = (ODT) this.get_Renamed("ODT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ODT
		/// (Diet Tray Instructions) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ODT getODT(int rep)
		{
			return (ODT) this.get_Renamed("ODT", rep);
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