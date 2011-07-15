using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RGV_O01_RXONTERXRRXCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXO (RXO - pharmacy/treatment order segment) <b></b><br>
	/// 1: RGV_O01_NTERXRRXCNTE (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RGV_O01_RXONTERXRRXCNTE:AbstractGroup
	{
		/// <summary> Returns RXO (RXO - pharmacy/treatment order segment) - creates it if necessary</summary>
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
		/// <summary> Returns RGV_O01_NTERXRRXCNTE (a Group object) - creates it if necessary</summary>
		virtual public RGV_O01_NTERXRRXCNTE NTERXRRXCNTE
		{
			get
			{
				RGV_O01_NTERXRRXCNTE ret = null;
				try
				{
					ret = (RGV_O01_NTERXRRXCNTE) this.get_Renamed("NTERXRRXCNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RGV_O01_RXONTERXRRXCNTE Group.</summary>
		public RGV_O01_RXONTERXRRXCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXO), true, false);
				this.add(typeof(RGV_O01_NTERXRRXCNTE), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}