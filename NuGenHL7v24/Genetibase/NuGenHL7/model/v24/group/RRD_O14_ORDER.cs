using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RRD_O14_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RRD_O14_DISPENSE (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRD_O14_ORDER:AbstractGroup
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
		/// <summary> Returns RRD_O14_DISPENSE (a Group object) - creates it if necessary</summary>
		virtual public RRD_O14_DISPENSE DISPENSE
		{
			get
			{
				RRD_O14_DISPENSE ret = null;
				try
				{
					ret = (RRD_O14_DISPENSE) this.get_Renamed("DISPENSE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRD_O14_ORDER Group.</summary>
		public RRD_O14_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRD_O14_DISPENSE), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}