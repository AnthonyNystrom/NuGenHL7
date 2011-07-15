using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the MFR_M06_MF_QUERY Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: CM0 (Clinical Study Master) <b></b><br>
	/// 2: CM1 (Clinical Study Phase Master) <b>optional repeating</b><br>
	/// 3: CM2 (Clinical Study Schedule Master) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class MFR_M06_MF_QUERY:AbstractGroup
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
		/// <summary> Returns CM0 (Clinical Study Master) - creates it if necessary</summary>
		virtual public CM0 CM0
		{
			get
			{
				CM0 ret = null;
				try
				{
					ret = (CM0) this.get_Renamed("CM0");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CM1 </summary>
		virtual public int CM1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CM1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CM2 </summary>
		virtual public int CM2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CM2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new MFR_M06_MF_QUERY Group.</summary>
		public MFR_M06_MF_QUERY(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(CM0), true, false);
				this.add(typeof(CM1), false, true);
				this.add(typeof(CM2), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CM1 (Clinical Study Phase Master) - creates it if necessary</summary>
		public virtual CM1 getCM1()
		{
			CM1 ret = null;
			try
			{
				ret = (CM1) this.get_Renamed("CM1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CM1
		/// (Clinical Study Phase Master) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CM1 getCM1(int rep)
		{
			return (CM1) this.get_Renamed("CM1", rep);
		}
		
		/// <summary> Returns  first repetition of CM2 (Clinical Study Schedule Master) - creates it if necessary</summary>
		public virtual CM2 getCM2()
		{
			CM2 ret = null;
			try
			{
				ret = (CM2) this.get_Renamed("CM2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CM2
		/// (Clinical Study Schedule Master) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CM2 getCM2(int rep)
		{
			return (CM2) this.get_Renamed("CM2", rep);
		}
	}
}