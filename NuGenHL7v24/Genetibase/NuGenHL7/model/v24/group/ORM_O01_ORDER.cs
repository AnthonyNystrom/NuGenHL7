using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the ORM_O01_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: ORM_O01_ORDER_DETAIL (a Group object) <b>optional </b><br>
	/// 2: FT1 (Financial Transaction) <b>optional repeating</b><br>
	/// 3: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
	/// 4: BLG (Billing) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORM_O01_ORDER:AbstractGroup
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
		/// <summary> Returns ORM_O01_ORDER_DETAIL (a Group object) - creates it if necessary</summary>
		virtual public ORM_O01_ORDER_DETAIL ORDER_DETAIL
		{
			get
			{
				ORM_O01_ORDER_DETAIL ret = null;
				try
				{
					ret = (ORM_O01_ORDER_DETAIL) this.get_Renamed("ORDER_DETAIL");
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
		
		/// <summary> Creates a new ORM_O01_ORDER Group.</summary>
		public ORM_O01_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(ORM_O01_ORDER_DETAIL), false, false);
				this.add(typeof(FT1), false, true);
				this.add(typeof(CTI), false, true);
				this.add(typeof(BLG), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
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