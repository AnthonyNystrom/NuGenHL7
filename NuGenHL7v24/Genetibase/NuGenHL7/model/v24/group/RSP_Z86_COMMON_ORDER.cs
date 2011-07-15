using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RSP_Z86_COMMON_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RSP_Z86_ORDER_DETAIL (a Group object) <b>optional </b><br>
	/// 2: RSP_Z86_ENCODED_ORDER (a Group object) <b>optional </b><br>
	/// 3: RSP_Z86_DISPENSE (a Group object) <b>optional </b><br>
	/// 4: RSP_Z86_GIVE (a Group object) <b>optional </b><br>
	/// 5: RSP_Z86_ADMINISTRATION (a Group object) <b>optional </b><br>
	/// 6: RSP_Z86_OBSERVATION (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RSP_Z86_COMMON_ORDER:AbstractGroup
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
		/// <summary> Returns RSP_Z86_ORDER_DETAIL (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z86_ORDER_DETAIL ORDER_DETAIL
		{
			get
			{
				RSP_Z86_ORDER_DETAIL ret = null;
				try
				{
					ret = (RSP_Z86_ORDER_DETAIL) this.get_Renamed("ORDER_DETAIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RSP_Z86_ENCODED_ORDER (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z86_ENCODED_ORDER ENCODED_ORDER
		{
			get
			{
				RSP_Z86_ENCODED_ORDER ret = null;
				try
				{
					ret = (RSP_Z86_ENCODED_ORDER) this.get_Renamed("ENCODED_ORDER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RSP_Z86_DISPENSE (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z86_DISPENSE DISPENSE
		{
			get
			{
				RSP_Z86_DISPENSE ret = null;
				try
				{
					ret = (RSP_Z86_DISPENSE) this.get_Renamed("DISPENSE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RSP_Z86_GIVE (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z86_GIVE GIVE
		{
			get
			{
				RSP_Z86_GIVE ret = null;
				try
				{
					ret = (RSP_Z86_GIVE) this.get_Renamed("GIVE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RSP_Z86_ADMINISTRATION (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z86_ADMINISTRATION ADMINISTRATION
		{
			get
			{
				RSP_Z86_ADMINISTRATION ret = null;
				try
				{
					ret = (RSP_Z86_ADMINISTRATION) this.get_Renamed("ADMINISTRATION");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RSP_Z86_OBSERVATION </summary>
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
		
		/// <summary> Creates a new RSP_Z86_COMMON_ORDER Group.</summary>
		public RSP_Z86_COMMON_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RSP_Z86_ORDER_DETAIL), false, false);
				this.add(typeof(RSP_Z86_ENCODED_ORDER), false, false);
				this.add(typeof(RSP_Z86_DISPENSE), false, false);
				this.add(typeof(RSP_Z86_GIVE), false, false);
				this.add(typeof(RSP_Z86_ADMINISTRATION), false, false);
				this.add(typeof(RSP_Z86_OBSERVATION), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RSP_Z86_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual RSP_Z86_OBSERVATION getOBSERVATION()
		{
			RSP_Z86_OBSERVATION ret = null;
			try
			{
				ret = (RSP_Z86_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RSP_Z86_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RSP_Z86_OBSERVATION getOBSERVATION(int rep)
		{
			return (RSP_Z86_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}