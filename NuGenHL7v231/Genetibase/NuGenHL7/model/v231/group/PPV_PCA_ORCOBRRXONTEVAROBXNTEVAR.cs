using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the PPV_PCA_ORCOBRRXONTEVAROBXNTEVAR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: PPV_PCA_OBRRXONTEVAROBXNTEVAR (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class PPV_PCA_ORCOBRRXONTEVAROBXNTEVAR:AbstractGroup
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
		/// <summary> Returns PPV_PCA_OBRRXONTEVAROBXNTEVAR (a Group object) - creates it if necessary</summary>
		virtual public PPV_PCA_OBRRXONTEVAROBXNTEVAR OBRRXONTEVAROBXNTEVAR
		{
			get
			{
				PPV_PCA_OBRRXONTEVAROBXNTEVAR ret = null;
				try
				{
					ret = (PPV_PCA_OBRRXONTEVAROBXNTEVAR) this.get_Renamed("OBRRXONTEVAROBXNTEVAR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new PPV_PCA_ORCOBRRXONTEVAROBXNTEVAR Group.</summary>
		public PPV_PCA_ORCOBRRXONTEVAROBXNTEVAR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(PPV_PCA_OBRRXONTEVAROBXNTEVAR), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}