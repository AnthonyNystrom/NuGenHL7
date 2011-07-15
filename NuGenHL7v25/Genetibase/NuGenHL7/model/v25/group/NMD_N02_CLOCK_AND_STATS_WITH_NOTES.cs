using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the NMD_N02_CLOCK_AND_STATS_WITH_NOTES Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NMD_N02_CLOCK (a Group object) <b>optional </b><br>
	/// 1: NMD_N02_APP_STATS (a Group object) <b>optional </b><br>
	/// 2: NMD_N02_APP_STATUS (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class NMD_N02_CLOCK_AND_STATS_WITH_NOTES:AbstractGroup
	{
		/// <summary> Returns NMD_N02_CLOCK (a Group object) - creates it if necessary</summary>
		virtual public NMD_N02_CLOCK CLOCK
		{
			get
			{
				NMD_N02_CLOCK ret = null;
				try
				{
					ret = (NMD_N02_CLOCK) this.get_Renamed("CLOCK");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NMD_N02_APP_STATS (a Group object) - creates it if necessary</summary>
		virtual public NMD_N02_APP_STATS APP_STATS
		{
			get
			{
				NMD_N02_APP_STATS ret = null;
				try
				{
					ret = (NMD_N02_APP_STATS) this.get_Renamed("APP_STATS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NMD_N02_APP_STATUS (a Group object) - creates it if necessary</summary>
		virtual public NMD_N02_APP_STATUS APP_STATUS
		{
			get
			{
				NMD_N02_APP_STATUS ret = null;
				try
				{
					ret = (NMD_N02_APP_STATUS) this.get_Renamed("APP_STATUS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new NMD_N02_CLOCK_AND_STATS_WITH_NOTES Group.</summary>
		public NMD_N02_CLOCK_AND_STATS_WITH_NOTES(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(NMD_N02_CLOCK), false, false);
				this.add(typeof(NMD_N02_APP_STATS), false, false);
				this.add(typeof(NMD_N02_APP_STATUS), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}