using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the BAR_P10_PROCEDURE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PR1 (Procedures) <b></b><br>
	/// 1: GP2 (Grouping/Reimbursement - Procedure Line Item) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class BAR_P10_PROCEDURE:AbstractGroup
	{
		/// <summary> Returns PR1 (Procedures) - creates it if necessary</summary>
		virtual public PR1 PR1
		{
			get
			{
				PR1 ret = null;
				try
				{
					ret = (PR1) this.get_Renamed("PR1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns GP2 (Grouping/Reimbursement - Procedure Line Item) - creates it if necessary</summary>
		virtual public GP2 GP2
		{
			get
			{
				GP2 ret = null;
				try
				{
					ret = (GP2) this.get_Renamed("GP2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new BAR_P10_PROCEDURE Group.</summary>
		public BAR_P10_PROCEDURE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PR1), true, false);
				this.add(typeof(GP2), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}