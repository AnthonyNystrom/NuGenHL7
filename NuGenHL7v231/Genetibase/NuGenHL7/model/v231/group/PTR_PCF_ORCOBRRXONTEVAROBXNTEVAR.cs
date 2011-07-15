using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the PTR_PCF_ORCOBRRXONTEVAROBXNTEVAR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: PTR_PCF_OBRRXONTEVAROBXNTEVAR (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class PTR_PCF_ORCOBRRXONTEVAROBXNTEVAR:AbstractGroup
	{
		/// <summary> Returns ORC (ORC - common order segment) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PTR_PCF_OBRRXONTEVAROBXNTEVAR (a Group object) - creates it if necessary</summary>
		virtual public PTR_PCF_OBRRXONTEVAROBXNTEVAR OBRRXONTEVAROBXNTEVAR
		{
			get
			{
				PTR_PCF_OBRRXONTEVAROBXNTEVAR ret = null;
				try
				{
					ret = (PTR_PCF_OBRRXONTEVAROBXNTEVAR) this.get_Renamed("OBRRXONTEVAROBXNTEVAR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new PTR_PCF_ORCOBRRXONTEVAROBXNTEVAR Group.</summary>
		public PTR_PCF_ORCOBRRXONTEVAROBXNTEVAR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(PTR_PCF_OBRRXONTEVAROBXNTEVAR), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}