using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RGV_O15_ORDER_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXO (Pharmacy/Treatment Order) <b></b><br>
	/// 1: RGV_O15_ORDER_DETAIL_SUPPLEMENT (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RGV_O15_ORDER_DETAIL:AbstractGroup
	{
		/// <summary> Returns RXO (Pharmacy/Treatment Order) - creates it if necessary</summary>
		virtual public RXO RXO
		{
			get
			{
				RXO ret = null;
				try
				{
					ret = (RXO) this.get_Renamed("RXO");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RGV_O15_ORDER_DETAIL_SUPPLEMENT (a Group object) - creates it if necessary</summary>
		virtual public RGV_O15_ORDER_DETAIL_SUPPLEMENT ORDER_DETAIL_SUPPLEMENT
		{
			get
			{
				RGV_O15_ORDER_DETAIL_SUPPLEMENT ret = null;
				try
				{
					ret = (RGV_O15_ORDER_DETAIL_SUPPLEMENT) this.get_Renamed("ORDER_DETAIL_SUPPLEMENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RGV_O15_ORDER_DETAIL Group.</summary>
		public RGV_O15_ORDER_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXO), true, false);
				this.add(typeof(RGV_O15_ORDER_DETAIL_SUPPLEMENT), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}