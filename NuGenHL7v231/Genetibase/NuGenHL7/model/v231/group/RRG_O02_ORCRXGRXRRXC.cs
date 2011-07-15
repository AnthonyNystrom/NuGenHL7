using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRG_O02_ORCRXGRXRRXC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RRG_O02_RXGRXRRXC (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRG_O02_ORCRXGRXRRXC:AbstractGroup
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
		/// <summary> Returns RRG_O02_RXGRXRRXC (a Group object) - creates it if necessary</summary>
		virtual public RRG_O02_RXGRXRRXC RXGRXRRXC
		{
			get
			{
				RRG_O02_RXGRXRRXC ret = null;
				try
				{
					ret = (RRG_O02_RXGRXRRXC) this.get_Renamed("RXGRXRRXC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRG_O02_ORCRXGRXRRXC Group.</summary>
		public RRG_O02_ORCRXGRXRRXC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRG_O02_RXGRXRRXC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}