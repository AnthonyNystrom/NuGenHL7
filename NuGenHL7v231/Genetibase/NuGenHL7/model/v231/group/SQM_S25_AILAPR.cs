using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SQM_S25_AILAPR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: AIL (AIL - appointment information - location resource segment) <b></b><br>
	/// 1: APR (APR - appointment preferences segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class SQM_S25_AILAPR:AbstractGroup
	{
		/// <summary> Returns AIL (AIL - appointment information - location resource segment) - creates it if necessary</summary>
		virtual public AIL AIL
		{
			get
			{
				AIL ret = null;
				try
				{
					ret = (AIL) this.get_Renamed("AIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns APR (APR - appointment preferences segment) - creates it if necessary</summary>
		virtual public APR APR
		{
			get
			{
				APR ret = null;
				try
				{
					ret = (APR) this.get_Renamed("APR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SQM_S25_AILAPR Group.</summary>
		public SQM_S25_AILAPR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(AIL), true, false);
				this.add(typeof(APR), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}