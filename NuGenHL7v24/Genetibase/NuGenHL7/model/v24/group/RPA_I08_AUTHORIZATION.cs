using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RPA_I08_AUTHORIZATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: AUT (Authorization Information) <b></b><br>
	/// 1: CTD (Contact Data) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RPA_I08_AUTHORIZATION:AbstractGroup
	{
		/// <summary> Returns AUT (Authorization Information) - creates it if necessary</summary>
		virtual public AUT AUT
		{
			get
			{
				AUT ret = null;
				try
				{
					ret = (AUT) this.get_Renamed("AUT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns CTD (Contact Data) - creates it if necessary</summary>
		virtual public CTD CTD
		{
			get
			{
				CTD ret = null;
				try
				{
					ret = (CTD) this.get_Renamed("CTD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RPA_I08_AUTHORIZATION Group.</summary>
		public RPA_I08_AUTHORIZATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(AUT), true, false);
				this.add(typeof(CTD), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}