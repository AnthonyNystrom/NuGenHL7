using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the MFN_M03_MF_TEST Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: OM1 (General Segment) <b></b><br>
	/// 2: Hxx (any HL7 segment) <b></b><br>
	/// </summary>
	[Serializable]
	public class MFN_M03_MF_TEST:AbstractGroup
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
		/// <summary> Returns Hxx (any HL7 segment) - creates it if necessary</summary>
		virtual public Hxx Hxx
		{
			get
			{
				Hxx ret = null;
				try
				{
					ret = (Hxx) this.get_Renamed("Hxx");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new MFN_M03_MF_TEST Group.</summary>
		public MFN_M03_MF_TEST(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(OM1), true, false);
				this.add(typeof(Hxx), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}