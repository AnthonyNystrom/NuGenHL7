using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the OMN_O01_ORCRQDRQ1NTEOBXNTEBLG Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: OMN_O01_RQDRQ1NTEOBXNTE (a Group object) <b>optional </b><br>
	/// 2: BLG (BLG - billing segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OMN_O01_ORCRQDRQ1NTEOBXNTEBLG:AbstractGroup
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
		/// <summary> Returns OMN_O01_RQDRQ1NTEOBXNTE (a Group object) - creates it if necessary</summary>
		virtual public OMN_O01_RQDRQ1NTEOBXNTE RQDRQ1NTEOBXNTE
		{
			get
			{
				OMN_O01_RQDRQ1NTEOBXNTE ret = null;
				try
				{
					ret = (OMN_O01_RQDRQ1NTEOBXNTE) this.get_Renamed("RQDRQ1NTEOBXNTE");
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
		
		/// <summary> Creates a new OMN_O01_ORCRQDRQ1NTEOBXNTEBLG Group.</summary>
		public OMN_O01_ORCRQDRQ1NTEOBXNTEBLG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OMN_O01_RQDRQ1NTEOBXNTE), false, false);
				this.add(typeof(BLG), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}