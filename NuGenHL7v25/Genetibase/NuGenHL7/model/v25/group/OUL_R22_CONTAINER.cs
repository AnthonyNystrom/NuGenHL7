using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OUL_R22_CONTAINER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SAC (Specimen Container detail) <b></b><br>
	/// 1: INV (Inventory Detail) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OUL_R22_CONTAINER:AbstractGroup
	{
		/// <summary> Returns SAC (Specimen Container detail) - creates it if necessary</summary>
		virtual public SAC SAC
		{
			get
			{
				SAC ret = null;
				try
				{
					ret = (SAC) this.get_Renamed("SAC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns INV (Inventory Detail) - creates it if necessary</summary>
		virtual public INV INV
		{
			get
			{
				INV ret = null;
				try
				{
					ret = (INV) this.get_Renamed("INV");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new OUL_R22_CONTAINER Group.</summary>
		public OUL_R22_CONTAINER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SAC), true, false);
				this.add(typeof(INV), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}