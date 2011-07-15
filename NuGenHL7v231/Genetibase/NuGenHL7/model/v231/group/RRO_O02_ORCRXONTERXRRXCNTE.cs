using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRO_O02_ORCRXONTERXRRXCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RRO_O02_RXONTERXRRXCNTE (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRO_O02_ORCRXONTERXRRXCNTE:AbstractGroup
	{
		/// <summary> Returns ORC (ORC - common order segment) - creates it if necessary</summary>
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
		/// <summary> Returns RRO_O02_RXONTERXRRXCNTE (a Group object) - creates it if necessary</summary>
		virtual public RRO_O02_RXONTERXRRXCNTE RXONTERXRRXCNTE
		{
			get
			{
				RRO_O02_RXONTERXRRXCNTE ret = null;
				try
				{
					ret = (RRO_O02_RXONTERXRRXCNTE) this.get_Renamed("RXONTERXRRXCNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRO_O02_ORCRXONTERXRRXCNTE Group.</summary>
		public RRO_O02_ORCRXONTERXRRXCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRO_O02_RXONTERXRRXCNTE), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}