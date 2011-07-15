using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the MFN_M02_MF_STAFF Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (MASTER FILE ENTRY) <b></b><br>
	/// 1: Zxx (any Z segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class MFN_M02_MF_STAFF:AbstractGroup
	{
		/// <summary> Returns MFE (MASTER FILE ENTRY) - creates it if necessary</summary>
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
		/// <summary> Returns Zxx (any Z segment) - creates it if necessary</summary>
		virtual public Zxx Zxx
		{
			get
			{
				Zxx ret = null;
				try
				{
					ret = (Zxx) this.get_Renamed("Zxx");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new MFN_M02_MF_STAFF Group.</summary>
		public MFN_M02_MF_STAFF(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(Zxx), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}