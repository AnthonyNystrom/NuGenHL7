using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the SUR_P09_FACILITY Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: FAC (Facility) <b></b><br>
	/// 1: SUR_P09_PRODUCT (a Group object) <b>repeating</b><br>
	/// 2: PSH (Product Summary Header) <b></b><br>
	/// 3: SUR_P09_FACILITY_DETAIL (a Group object) <b>repeating</b><br>
	/// 4: ED (Encapsulated Data (wrong segment)) <b></b><br>
	/// </summary>
	[Serializable]
	public class SUR_P09_FACILITY:AbstractGroup
	{
		/// <summary> Returns FAC (Facility) - creates it if necessary</summary>
		virtual public FAC FAC
		{
			get
			{
				FAC ret = null;
				try
				{
					ret = (FAC) this.get_Renamed("FAC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SUR_P09_PRODUCT </summary>
		virtual public int PRODUCTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRODUCT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns PSH (Product Summary Header) - creates it if necessary</summary>
		virtual public PSH PSH
		{
			get
			{
				PSH ret = null;
				try
				{
					ret = (PSH) this.get_Renamed("PSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SUR_P09_FACILITY_DETAIL </summary>
		virtual public int FACILITY_DETAILReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("FACILITY_DETAIL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns ED (Encapsulated Data (wrong segment)) - creates it if necessary</summary>
		virtual public ED ED
		{
			get
			{
				ED ret = null;
				try
				{
					ret = (ED) this.get_Renamed("ED");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SUR_P09_FACILITY Group.</summary>
		public SUR_P09_FACILITY(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(FAC), true, false);
				this.add(typeof(SUR_P09_PRODUCT), true, true);
				this.add(typeof(PSH), true, false);
				this.add(typeof(SUR_P09_FACILITY_DETAIL), true, true);
				this.add(typeof(ED), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SUR_P09_PRODUCT (a Group object) - creates it if necessary</summary>
		public virtual SUR_P09_PRODUCT getPRODUCT()
		{
			SUR_P09_PRODUCT ret = null;
			try
			{
				ret = (SUR_P09_PRODUCT) this.get_Renamed("PRODUCT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SUR_P09_PRODUCT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SUR_P09_PRODUCT getPRODUCT(int rep)
		{
			return (SUR_P09_PRODUCT) this.get_Renamed("PRODUCT", rep);
		}
		
		/// <summary> Returns  first repetition of SUR_P09_FACILITY_DETAIL (a Group object) - creates it if necessary</summary>
		public virtual SUR_P09_FACILITY_DETAIL getFACILITY_DETAIL()
		{
			SUR_P09_FACILITY_DETAIL ret = null;
			try
			{
				ret = (SUR_P09_FACILITY_DETAIL) this.get_Renamed("FACILITY_DETAIL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SUR_P09_FACILITY_DETAIL
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SUR_P09_FACILITY_DETAIL getFACILITY_DETAIL(int rep)
		{
			return (SUR_P09_FACILITY_DETAIL) this.get_Renamed("FACILITY_DETAIL", rep);
		}
	}
}