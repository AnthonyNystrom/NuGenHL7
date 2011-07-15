using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRD_O02_ORCRXDRXRRXC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RRD_O02_RXDRXRRXC (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRD_O02_ORCRXDRXRRXC:AbstractGroup
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
		/// <summary> Returns RRD_O02_RXDRXRRXC (a Group object) - creates it if necessary</summary>
		virtual public RRD_O02_RXDRXRRXC RXDRXRRXC
		{
			get
			{
				RRD_O02_RXDRXRRXC ret = null;
				try
				{
					ret = (RRD_O02_RXDRXRRXC) this.get_Renamed("RXDRXRRXC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRD_O02_ORCRXDRXRRXC Group.</summary>
		public RRD_O02_ORCRXDRXRRXC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRD_O02_RXDRXRRXC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}