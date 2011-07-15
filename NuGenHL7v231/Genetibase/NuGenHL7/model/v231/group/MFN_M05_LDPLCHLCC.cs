using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the MFN_M05_LDPLCHLCC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: LDP (LDP - location department segment) <b></b><br>
	/// 1: LCH (LCH - location characteristic segment) <b>optional repeating</b><br>
	/// 2: LCC (LCC - location charge code segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFN_M05_LDPLCHLCC:AbstractGroup
	{
		/// <summary> Returns LDP (LDP - location department segment) - creates it if necessary</summary>
		virtual public LDP LDP
		{
			get
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
		
		/// <summary> Creates a new MFN_M05_LDPLCHLCC Group.</summary>
		public MFN_M05_LDPLCHLCC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(LDP), true, false);
				this.add(typeof(LCH), false, true);
				this.add(typeof(LCC), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of LCH (LCH - location characteristic segment) - creates it if necessary</summary>
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
		/// (LCH - location characteristic segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LCH getLCH(int rep)
		{
			return (LCH) this.get_Renamed("LCH", rep);
		}
		
		/// <summary> Returns  first repetition of LCC (LCC - location charge code segment) - creates it if necessary</summary>
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
		/// (LCC - location charge code segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LCC getLCC(int rep)
		{
			return (LCC) this.get_Renamed("LCC", rep);
		}
	}
}