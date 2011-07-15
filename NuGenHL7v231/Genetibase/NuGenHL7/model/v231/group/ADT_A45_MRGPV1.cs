using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ADT_A45_MRGPV1 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: MRG (MRG - merge patient information segment-) <b></b><br>
	/// 1: PV1 (PV1 - patient visit segment-) <b></b><br>
	/// </summary>
	[Serializable]
	public class ADT_A45_MRGPV1:AbstractGroup
	{
		/// <summary> Returns MRG (MRG - merge patient information segment-) - creates it if necessary</summary>
		virtual public MRG MRG
		{
			get
			{
				MRG ret = null;
				try
				{
					ret = (MRG) this.get_Renamed("MRG");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PV1 (PV1 - patient visit segment-) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ADT_A45_MRGPV1 Group.</summary>
		public ADT_A45_MRGPV1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(MRG), true, false);
				this.add(typeof(PV1), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}