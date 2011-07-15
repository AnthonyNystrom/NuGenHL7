using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the EAN_U09_NOTIFICATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NDS (Notification Detail) <b></b><br>
	/// 1: NTE (Notes and Comments) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class EAN_U09_NOTIFICATION:AbstractGroup
	{
		/// <summary> Returns NDS (Notification Detail) - creates it if necessary</summary>
		virtual public NDS NDS
		{
			get
			{
				NDS ret = null;
				try
				{
					ret = (NDS) this.get_Renamed("NDS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NTE (Notes and Comments) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new EAN_U09_NOTIFICATION Group.</summary>
		public EAN_U09_NOTIFICATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(NDS), true, false);
				this.add(typeof(NTE), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}