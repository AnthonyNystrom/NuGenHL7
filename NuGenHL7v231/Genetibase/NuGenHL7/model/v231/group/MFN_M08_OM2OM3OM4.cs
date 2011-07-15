using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the MFN_M08_OM2OM3OM4 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OM2 (OM2 - numeric observation segment) <b>optional </b><br>
	/// 1: OM3 (OM3 - categorical test/observation segment) <b>optional </b><br>
	/// 2: OM4 (OM4 - observations that require specimens segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class MFN_M08_OM2OM3OM4:AbstractGroup
	{
		/// <summary> Returns OM2 (OM2 - numeric observation segment) - creates it if necessary</summary>
		virtual public OM2 OM2
		{
			get
			{
				OM2 ret = null;
				try
				{
					ret = (OM2) this.get_Renamed("OM2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OM3 (OM3 - categorical test/observation segment) - creates it if necessary</summary>
		virtual public OM3 OM3
		{
			get
			{
				OM3 ret = null;
				try
				{
					ret = (OM3) this.get_Renamed("OM3");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OM4 (OM4 - observations that require specimens segment) - creates it if necessary</summary>
		virtual public OM4 OM4
		{
			get
			{
				OM4 ret = null;
				try
				{
					ret = (OM4) this.get_Renamed("OM4");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new MFN_M08_OM2OM3OM4 Group.</summary>
		public MFN_M08_OM2OM3OM4(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OM2), false, false);
				this.add(typeof(OM3), false, false);
				this.add(typeof(OM4), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}