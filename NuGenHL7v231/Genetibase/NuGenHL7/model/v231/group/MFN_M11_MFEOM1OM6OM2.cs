using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the MFN_M11_MFEOM1OM6OM2 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (MFE - master file entry segment) <b></b><br>
	/// 1: OM1 (OM1 - general segment (fields that apply to most observations)) <b></b><br>
	/// 2: MFN_M11_OM6OM2 (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class MFN_M11_MFEOM1OM6OM2:AbstractGroup
	{
		/// <summary> Returns MFE (MFE - master file entry segment) - creates it if necessary</summary>
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
		/// <summary> Returns OM1 (OM1 - general segment (fields that apply to most observations)) - creates it if necessary</summary>
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
		/// <summary> Returns MFN_M11_OM6OM2 (a Group object) - creates it if necessary</summary>
		virtual public MFN_M11_OM6OM2 OM6OM2
		{
			get
			{
				MFN_M11_OM6OM2 ret = null;
				try
				{
					ret = (MFN_M11_OM6OM2) this.get_Renamed("OM6OM2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new MFN_M11_MFEOM1OM6OM2 Group.</summary>
		public MFN_M11_MFEOM1OM6OM2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(OM1), true, false);
				this.add(typeof(MFN_M11_OM6OM2), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}