using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the MFN_M02_MF_STAFF Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MFE (Master File Entry) <b></b><br>
	/// 1: STF (Staff Identification) <b></b><br>
	/// 2: PRA (Practitioner Detail) <b>optional </b><br>
	/// 3: ORG (Practitioner Organization Unit) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class MFN_M02_MF_STAFF:AbstractGroup
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
		/// <summary> Returns STF (Staff Identification) - creates it if necessary</summary>
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
		/// <summary> Returns PRA (Practitioner Detail) - creates it if necessary</summary>
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
		/// <summary> Returns ORG (Practitioner Organization Unit) - creates it if necessary</summary>
		virtual public ORG ORG
		{
			get
			{
				ORG ret = null;
				try
				{
					ret = (ORG) this.get_Renamed("ORG");
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
				this.add(typeof(STF), true, false);
				this.add(typeof(PRA), false, false);
				this.add(typeof(ORG), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}