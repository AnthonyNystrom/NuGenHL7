using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRA_O02_ORCRXARXR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RRA_O02_RXARXR (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRA_O02_ORCRXARXR:AbstractGroup
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
		/// <summary> Returns RRA_O02_RXARXR (a Group object) - creates it if necessary</summary>
		virtual public RRA_O02_RXARXR RXARXR
		{
			get
			{
				RRA_O02_RXARXR ret = null;
				try
				{
					ret = (RRA_O02_RXARXR) this.get_Renamed("RXARXR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRA_O02_ORCRXARXR Group.</summary>
		public RRA_O02_ORCRXARXR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RRA_O02_RXARXR), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}