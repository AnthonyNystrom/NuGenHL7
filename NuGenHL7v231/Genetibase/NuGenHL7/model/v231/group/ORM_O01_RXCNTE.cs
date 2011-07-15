using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ORM_O01_RXCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXC (RXC - pharmacy/treatment component order segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b></b><br>
	/// </summary>
	[Serializable]
	public class ORM_O01_RXCNTE:AbstractGroup
	{
		/// <summary> Returns RXC (RXC - pharmacy/treatment component order segment) - creates it if necessary</summary>
		virtual public RXC RXC
		{
			get
			{
				RXC ret = null;
				try
				{
					ret = (RXC) this.get_Renamed("RXC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NTE (NTE - notes and comments segment) - creates it if necessary</summary>
		virtual public NTE NTE
		{
			get
			{
				NTE ret = null;
				try
				{
					ret = (NTE) this.get_Renamed("NTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ORM_O01_RXCNTE Group.</summary>
		public ORM_O01_RXCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXC), true, false);
				this.add(typeof(NTE), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}