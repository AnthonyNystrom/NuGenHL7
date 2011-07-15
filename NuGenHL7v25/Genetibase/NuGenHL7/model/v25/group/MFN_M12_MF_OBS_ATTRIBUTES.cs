using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the MFN_M12_MF_OBS_ATTRIBUTES Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: OM1 (General Segment) <b></b><br>
	/// 2: OM7 (Additional Basic Attributes) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class MFN_M12_MF_OBS_ATTRIBUTES:AbstractGroup
	{
		/// <summary> Returns MFE (Master File Entry) - creates it if necessary</summary>
		virtual public MFE MFE
		{
			get
			{
				MFE ret = null;
				try
				{
					ret = (MFE) this.get_Renamed("MFE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OM1 (General Segment) - creates it if necessary</summary>
		virtual public OM1 OM1
		{
			get
			{
				OM1 ret = null;
				try
				{
					ret = (OM1) this.get_Renamed("OM1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OM7 (Additional Basic Attributes) - creates it if necessary</summary>
		virtual public OM7 OM7
		{
			get
			{
				OM7 ret = null;
				try
				{
					ret = (OM7) this.get_Renamed("OM7");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new MFN_M12_MF_OBS_ATTRIBUTES Group.</summary>
		public MFN_M12_MF_OBS_ATTRIBUTES(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(OM1), true, false);
				this.add(typeof(OM7), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}