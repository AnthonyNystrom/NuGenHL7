using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the EAC_U07_COMMAND Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ECD (Equipment Command) <b></b><br>
	/// 1: TQ1 (Timing/Quantity) <b>optional </b><br>
	/// 2: EAC_U07_SPECIMEN_CONTAINER (a Group object) <b>optional </b><br>
	/// 3: CNS (Clear Notification) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class EAC_U07_COMMAND:AbstractGroup
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
		/// <summary> Returns TQ1 (Timing/Quantity) - creates it if necessary</summary>
		virtual public TQ1 TQ1
		{
			get
			{
				TQ1 ret = null;
				try
				{
					ret = (TQ1) this.get_Renamed("TQ1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns EAC_U07_SPECIMEN_CONTAINER (a Group object) - creates it if necessary</summary>
		virtual public EAC_U07_SPECIMEN_CONTAINER SPECIMEN_CONTAINER
		{
			get
			{
				EAC_U07_SPECIMEN_CONTAINER ret = null;
				try
				{
					ret = (EAC_U07_SPECIMEN_CONTAINER) this.get_Renamed("SPECIMEN_CONTAINER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns CNS (Clear Notification) - creates it if necessary</summary>
		virtual public CNS CNS
		{
			get
			{
				CNS ret = null;
				try
				{
					ret = (CNS) this.get_Renamed("CNS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new EAC_U07_COMMAND Group.</summary>
		public EAC_U07_COMMAND(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ECD), true, false);
				this.add(typeof(TQ1), false, false);
				this.add(typeof(EAC_U07_SPECIMEN_CONTAINER), false, false);
				this.add(typeof(CNS), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}