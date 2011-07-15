using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the MFN_M08_MF_TEST_NUMERIC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: OM1 (General Segment) <b></b><br>
	/// 2: OM2 (Numeric Observation) <b>optional </b><br>
	/// 3: OM3 (Categorical Service/Test/Observation) <b>optional </b><br>
	/// 4: OM4 (Observations that Require Specimens) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class MFN_M08_MF_TEST_NUMERIC:AbstractGroup
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
		/// <summary> Returns OM3 (Categorical Service/Test/Observation) - creates it if necessary</summary>
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
		/// <summary> Returns OM4 (Observations that Require Specimens) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new MFN_M08_MF_TEST_NUMERIC Group.</summary>
		public MFN_M08_MF_TEST_NUMERIC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(OM1), true, false);
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