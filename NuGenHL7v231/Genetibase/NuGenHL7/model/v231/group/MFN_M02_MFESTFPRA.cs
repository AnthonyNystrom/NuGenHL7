using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the MFN_M02_MFESTFPRA Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (MFE - master file entry segment) <b></b><br>
	/// 1: STF (STF - staff identification segment) <b></b><br>
	/// 2: PRA (PRA - practitioner detail segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class MFN_M02_MFESTFPRA:AbstractGroup
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
		/// <summary> Returns STF (STF - staff identification segment) - creates it if necessary</summary>
		virtual public STF STF
		{
			get
			{
				STF ret = null;
				try
				{
					ret = (STF) this.get_Renamed("STF");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PRA (PRA - practitioner detail segment) - creates it if necessary</summary>
		virtual public PRA PRA
		{
			get
			{
				PRA ret = null;
				try
				{
					ret = (PRA) this.get_Renamed("PRA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new MFN_M02_MFESTFPRA Group.</summary>
		public MFN_M02_MFESTFPRA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(STF), true, false);
				this.add(typeof(PRA), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}