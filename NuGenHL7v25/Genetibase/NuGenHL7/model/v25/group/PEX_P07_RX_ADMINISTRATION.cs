using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PEX_P07_RX_ADMINISTRATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXA (Pharmacy/Treatment Administration) <b></b><br>
	/// 1: RXR (Pharmacy/Treatment Route) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_RX_ADMINISTRATION:AbstractGroup
	{
		/// <summary> Returns RXA (Pharmacy/Treatment Administration) - creates it if necessary</summary>
		virtual public RXA RXA
		{
			get
			{
				RXA ret = null;
				try
				{
					ret = (RXA) this.get_Renamed("RXA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RXR (Pharmacy/Treatment Route) - creates it if necessary</summary>
		virtual public RXR RXR
		{
			get
			{
				RXR ret = null;
				try
				{
					ret = (RXR) this.get_Renamed("RXR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new PEX_P07_RX_ADMINISTRATION Group.</summary>
		public PEX_P07_RX_ADMINISTRATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXA), true, false);
				this.add(typeof(RXR), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}