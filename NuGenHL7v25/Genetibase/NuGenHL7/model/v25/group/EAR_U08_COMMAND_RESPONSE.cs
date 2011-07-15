using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the EAR_U08_COMMAND_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ECD (Equipment Command) <b></b><br>
	/// 1: EAR_U08_SPECIMEN_CONTAINER (a Group object) <b>optional </b><br>
	/// 2: ECR (Equipment Command Response) <b></b><br>
	/// </summary>
	[Serializable]
	public class EAR_U08_COMMAND_RESPONSE:AbstractGroup
	{
		/// <summary> Returns ECD (Equipment Command) - creates it if necessary</summary>
		virtual public ECD ECD
		{
			get
			{
				ECD ret = null;
				try
				{
					ret = (ECD) this.get_Renamed("ECD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns EAR_U08_SPECIMEN_CONTAINER (a Group object) - creates it if necessary</summary>
		virtual public EAR_U08_SPECIMEN_CONTAINER SPECIMEN_CONTAINER
		{
			get
			{
				EAR_U08_SPECIMEN_CONTAINER ret = null;
				try
				{
					ret = (EAR_U08_SPECIMEN_CONTAINER) this.get_Renamed("SPECIMEN_CONTAINER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ECR (Equipment Command Response) - creates it if necessary</summary>
		virtual public ECR ECR
		{
			get
			{
				ECR ret = null;
				try
				{
					ret = (ECR) this.get_Renamed("ECR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new EAR_U08_COMMAND_RESPONSE Group.</summary>
		public EAR_U08_COMMAND_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ECD), true, false);
				this.add(typeof(EAR_U08_SPECIMEN_CONTAINER), false, false);
				this.add(typeof(ECR), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}