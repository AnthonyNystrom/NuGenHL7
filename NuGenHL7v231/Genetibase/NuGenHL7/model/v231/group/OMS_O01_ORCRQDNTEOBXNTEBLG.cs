using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the OMS_O01_ORCRQDNTEOBXNTEBLG Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: OMS_O01_RQDNTEOBXNTE (a Group object) <b>optional </b><br>
	/// 2: BLG (BLG - billing segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OMS_O01_ORCRQDNTEOBXNTEBLG:AbstractGroup
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
		/// <summary> Returns OMS_O01_RQDNTEOBXNTE (a Group object) - creates it if necessary</summary>
		virtual public OMS_O01_RQDNTEOBXNTE RQDNTEOBXNTE
		{
			get
			{
				OMS_O01_RQDNTEOBXNTE ret = null;
				try
				{
					ret = (OMS_O01_RQDNTEOBXNTE) this.get_Renamed("RQDNTEOBXNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns BLG (BLG - billing segment) - creates it if necessary</summary>
		virtual public BLG BLG
		{
			get
			{
				BLG ret = null;
				try
				{
					ret = (BLG) this.get_Renamed("BLG");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new OMS_O01_ORCRQDNTEOBXNTEBLG Group.</summary>
		public OMS_O01_ORCRQDNTEOBXNTEBLG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OMS_O01_RQDNTEOBXNTE), false, false);
				this.add(typeof(BLG), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}