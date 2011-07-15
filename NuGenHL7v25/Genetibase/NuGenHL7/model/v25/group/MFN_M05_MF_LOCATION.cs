using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the MFN_M05_MF_LOCATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: LOC (Location Identification) <b></b><br>
	/// 2: LCH (Location Characteristic) <b>optional repeating</b><br>
	/// 3: LRL (Location Relationship) <b>optional repeating</b><br>
	/// 4: MFN_M05_MF_LOC_DEPT (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFN_M05_MF_LOCATION:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of MFN_M05_MF_LOC_DEPT </summary>
		virtual public int MF_LOC_DEPTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("MF_LOC_DEPT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFN_M05_MF_LOCATION Group.</summary>
		public MFN_M05_MF_LOCATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(LOC), true, false);
				this.add(typeof(LCH), false, true);
				this.add(typeof(LRL), false, true);
				this.add(typeof(MFN_M05_MF_LOC_DEPT), true, true);
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
		
		/// <summary> Returns  first repetition of MFN_M05_MF_LOC_DEPT (a Group object) - creates it if necessary</summary>
		public virtual MFN_M05_MF_LOC_DEPT getMF_LOC_DEPT()
		{
			MFN_M05_MF_LOC_DEPT ret = null;
			try
			{
				ret = (MFN_M05_MF_LOC_DEPT) this.get_Renamed("MF_LOC_DEPT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of MFN_M05_MF_LOC_DEPT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual MFN_M05_MF_LOC_DEPT getMF_LOC_DEPT(int rep)
		{
			return (MFN_M05_MF_LOC_DEPT) this.get_Renamed("MF_LOC_DEPT", rep);
		}
	}
}