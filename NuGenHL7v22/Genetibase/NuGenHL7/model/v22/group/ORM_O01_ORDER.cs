using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the ORM_O01_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (COMMOM ORDER) <b></b><br>
	/// 1: ORM_O01_ORDER_DETAIL (a Group object) <b>optional </b><br>
	/// 2: BLG (BILLING) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORM_O01_ORDER:AbstractGroup
	{
		/// <summary> Returns ORC (COMMOM ORDER) - creates it if necessary</summary>
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
		/// <summary> Returns BLG (BILLING) - creates it if necessary</summary>
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
				this.add(typeof(BLG), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}