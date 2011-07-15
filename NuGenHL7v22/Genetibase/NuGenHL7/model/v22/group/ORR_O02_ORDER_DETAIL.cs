using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the ORR_O02_ORDER_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OBR (OBSERVATION REQUEST) <b></b><br>
	/// 1: RQD (REQUISITION DETAIL) <b></b><br>
	/// 2: RQ1 (REQUISITION DETAIL-!) <b></b><br>
	/// 3: RXO (PHARMACY PRESCRIPTION ORDER) <b></b><br>
	/// 4: ODS (DIETARY ORDERS, SUPPLEMENTS, and PREFERENCES) <b></b><br>
	/// 5: ODT (DIET TRAY INSTRUCTION) <b></b><br>
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
		/// <summary> Returns RQD (REQUISITION DETAIL) - creates it if necessary</summary>
		virtual public RQD RQD
		{
			get
			{
				RQD ret = null;
				try
				{
					ret = (RQD) this.get_Renamed("RQD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RQ1 (REQUISITION DETAIL-!) - creates it if necessary</summary>
		virtual public RQ1 RQ1
		{
			get
			{
				RQ1 ret = null;
				try
				{
					ret = (RQ1) this.get_Renamed("RQ1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RXO (PHARMACY PRESCRIPTION ORDER) - creates it if necessary</summary>
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
		/// <summary> Returns ODS (DIETARY ORDERS, SUPPLEMENTS, and PREFERENCES) - creates it if necessary</summary>
		virtual public ODS ODS
		{
			get
			{
				ODS ret = null;
				try
				{
					ret = (ODS) this.get_Renamed("ODS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ODT (DIET TRAY INSTRUCTION) - creates it if necessary</summary>
		virtual public ODT ODT
		{
			get
			{
				ODT ret = null;
				try
				{
					ret = (ODT) this.get_Renamed("ODT");
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
				this.add(typeof(RQD), true, false);
				this.add(typeof(RQ1), true, false);
				this.add(typeof(RXO), true, false);
				this.add(typeof(ODS), true, false);
				this.add(typeof(ODT), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}