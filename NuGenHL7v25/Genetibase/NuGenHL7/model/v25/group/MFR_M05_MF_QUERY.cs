using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the MFR_M05_MF_QUERY Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: LOC (Location Identification) <b></b><br>
	/// 2: LCH (Location Characteristic) <b>optional repeating</b><br>
	/// 3: LRL (Location Relationship) <b>optional repeating</b><br>
	/// 4: LDP (Location Department) <b>repeating</b><br>
	/// 5: LCH (Location Characteristic) <b>optional repeating</b><br>
	/// 6: LCC (Location Charge Code) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFR_M05_MF_QUERY:AbstractGroup
	{
		/// <summary> Returns MFE (Master File Entry) - creates it if necessary</summary>
		virtual public MFE MFE
		{
			get
			{
				MFE ret = null;
				try
				{
					ret = (MFE) this.get_Renamed("MFE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns LOC (Location Identification) - creates it if necessary</summary>
		virtual public LOC LOC
		{
			get
			{
				LOC ret = null;
				try
				{
					ret = (LOC) this.get_Renamed("LOC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of LCH </summary>
		virtual public int LCHReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("LCH").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of LRL </summary>
		virtual public int LRLReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("LRL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of LDP </summary>
		virtual public int LDPReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("LDP").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of LCH2 </summary>
		virtual public int LCH2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("LCH2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of LCC </summary>
		virtual public int LCCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("LCC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFR_M05_MF_QUERY Group.</summary>
		public MFR_M05_MF_QUERY(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(LOC), true, false);
				this.add(typeof(LCH), false, true);
				this.add(typeof(LRL), false, true);
				this.add(typeof(LDP), true, true);
				this.add(typeof(LCH), false, true);
				this.add(typeof(LCC), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of LCH (Location Characteristic) - creates it if necessary</summary>
		public virtual LCH getLCH()
		{
			LCH ret = null;
			try
			{
				ret = (LCH) this.get_Renamed("LCH");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of LCH
		/// (Location Characteristic) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LCH getLCH(int rep)
		{
			return (LCH) this.get_Renamed("LCH", rep);
		}
		
		/// <summary> Returns  first repetition of LRL (Location Relationship) - creates it if necessary</summary>
		public virtual LRL getLRL()
		{
			LRL ret = null;
			try
			{
				ret = (LRL) this.get_Renamed("LRL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of LRL
		/// (Location Relationship) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LRL getLRL(int rep)
		{
			return (LRL) this.get_Renamed("LRL", rep);
		}
		
		/// <summary> Returns  first repetition of LDP (Location Department) - creates it if necessary</summary>
		public virtual LDP getLDP()
		{
			LDP ret = null;
			try
			{
				ret = (LDP) this.get_Renamed("LDP");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of LDP
		/// (Location Department) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LDP getLDP(int rep)
		{
			return (LDP) this.get_Renamed("LDP", rep);
		}
		
		/// <summary> Returns  first repetition of LCH2 (Location Characteristic) - creates it if necessary</summary>
		public virtual LCH getLCH2()
		{
			LCH ret = null;
			try
			{
				ret = (LCH) this.get_Renamed("LCH2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of LCH2
		/// (Location Characteristic) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LCH getLCH2(int rep)
		{
			return (LCH) this.get_Renamed("LCH2", rep);
		}
		
		/// <summary> Returns  first repetition of LCC (Location Charge Code) - creates it if necessary</summary>
		public virtual LCC getLCC()
		{
			LCC ret = null;
			try
			{
				ret = (LCC) this.get_Renamed("LCC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of LCC
		/// (Location Charge Code) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LCC getLCC(int rep)
		{
			return (LCC) this.get_Renamed("LCC", rep);
		}
	}
}