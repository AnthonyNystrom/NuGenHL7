using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v21.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v21.group
{
	/// <summary> <p>Represents the ORR_O02_ORDER_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OBR (OBSERVATION REQUEST) <b></b><br>
	/// 1: ORO (ORDER OTHER) <b></b><br>
	/// 2: RX1 (PHARMACY ORDER) <b></b><br>
	/// </summary>
	[Serializable]
	public class ORR_O02_ORDER_DETAIL:AbstractGroup
	{
		/// <summary> Returns OBR (OBSERVATION REQUEST) - creates it if necessary</summary>
		virtual public OBR OBR
		{
			get
			{
				OBR ret = null;
				try
				{
					ret = (OBR) this.get_Renamed("OBR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ORO (ORDER OTHER) - creates it if necessary</summary>
		virtual public ORO ORO
		{
			get
			{
				ORO ret = null;
				try
				{
					ret = (ORO) this.get_Renamed("ORO");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RX1 (PHARMACY ORDER) - creates it if necessary</summary>
		virtual public RX1 RX1
		{
			get
			{
				RX1 ret = null;
				try
				{
					ret = (RX1) this.get_Renamed("RX1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ORR_O02_ORDER_DETAIL Group.</summary>
		public ORR_O02_ORDER_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OBR), true, false);
				this.add(typeof(ORO), true, false);
				this.add(typeof(RX1), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}