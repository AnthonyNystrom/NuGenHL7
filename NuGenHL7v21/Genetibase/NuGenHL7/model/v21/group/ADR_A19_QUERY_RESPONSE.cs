using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v21.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v21.group
{
	/// <summary> <p>Represents the ADR_A19_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: EVN (EVENT TYPE) <b>optional </b><br>
	/// 1: PID (PATIENT IDENTIFICATION) <b></b><br>
	/// 2: PV1 (PATIENT VISIT) <b></b><br>
	/// </summary>
	[Serializable]
	public class ADR_A19_QUERY_RESPONSE:AbstractGroup
	{
		/// <summary> Returns EVN (EVENT TYPE) - creates it if necessary</summary>
		virtual public EVN EVN
		{
			get
			{
				EVN ret = null;
				try
				{
					ret = (EVN) this.get_Renamed("EVN");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PID (PATIENT IDENTIFICATION) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PV1 (PATIENT VISIT) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new ADR_A19_QUERY_RESPONSE Group.</summary>
		public ADR_A19_QUERY_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(EVN), false, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PV1), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}