using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the MFN_M11_MF_TEST_CALC_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OM6 (Observations that are Calculated from Other Observ) <b></b><br>
	/// 1: OM2 (Numeric Observation) <b></b><br>
	/// </summary>
	[Serializable]
	public class MFN_M11_MF_TEST_CALC_DETAIL:AbstractGroup
	{
		/// <summary> Returns OM6 (Observations that are Calculated from Other Observ) - creates it if necessary</summary>
		virtual public OM6 OM6
		{
			get
			{
				OM6 ret = null;
				try
				{
					ret = (OM6) this.get_Renamed("OM6");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OM2 (Numeric Observation) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new MFN_M11_MF_TEST_CALC_DETAIL Group.</summary>
		public MFN_M11_MF_TEST_CALC_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OM6), true, false);
				this.add(typeof(OM2), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}