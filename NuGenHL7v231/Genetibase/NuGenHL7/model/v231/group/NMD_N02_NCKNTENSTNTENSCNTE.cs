using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the NMD_N02_NCKNTENSTNTENSCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NMD_N02_NCKNTE (a Group object) <b>optional </b><br>
	/// 1: NMD_N02_NSTNTE (a Group object) <b>optional </b><br>
	/// 2: NMD_N02_NSCNTE (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class NMD_N02_NCKNTENSTNTENSCNTE:AbstractGroup
	{
		/// <summary> Returns NMD_N02_NCKNTE (a Group object) - creates it if necessary</summary>
		virtual public NMD_N02_NCKNTE NCKNTE
		{
			get
			{
				NMD_N02_NCKNTE ret = null;
				try
				{
					ret = (NMD_N02_NCKNTE) this.get_Renamed("NCKNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NMD_N02_NSTNTE (a Group object) - creates it if necessary</summary>
		virtual public NMD_N02_NSTNTE NSTNTE
		{
			get
			{
				NMD_N02_NSTNTE ret = null;
				try
				{
					ret = (NMD_N02_NSTNTE) this.get_Renamed("NSTNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NMD_N02_NSCNTE (a Group object) - creates it if necessary</summary>
		virtual public NMD_N02_NSCNTE NSCNTE
		{
			get
			{
				NMD_N02_NSCNTE ret = null;
				try
				{
					ret = (NMD_N02_NSCNTE) this.get_Renamed("NSCNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new NMD_N02_NCKNTENSTNTENSCNTE Group.</summary>
		public NMD_N02_NCKNTENSTNTENSCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(NMD_N02_NCKNTE), false, false);
				this.add(typeof(NMD_N02_NSTNTE), false, false);
				this.add(typeof(NMD_N02_NSCNTE), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}