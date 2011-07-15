using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRE_O02_ORCRXERXRRXC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RRE_O02_RXERXRRXC (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRE_O02_ORCRXERXRRXC:AbstractGroup
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
		/// <summary> Returns RRE_O02_RXERXRRXC (a Group object) - creates it if necessary</summary>
		virtual public RRE_O02_RXERXRRXC RXERXRRXC
		{
			get
			{
				RRE_O02_RXERXRRXC ret = null;
				try
				{
					ret = (RRE_O02_RXERXRRXC) this.get_Renamed("RXERXRRXC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRE_O02_ORCRXERXRRXC Group.</summary>
		public RRE_O02_ORCRXERXRRXC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRE_O02_RXERXRRXC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}