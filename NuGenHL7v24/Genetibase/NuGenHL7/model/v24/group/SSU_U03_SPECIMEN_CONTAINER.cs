using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the SSU_U03_SPECIMEN_CONTAINER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SAC (Specimen and container detail) <b></b><br>
	/// 1: OBX (Observation/Result) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class SSU_U03_SPECIMEN_CONTAINER:AbstractGroup
	{
		/// <summary> Returns SAC (Specimen and container detail) - creates it if necessary</summary>
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
		/// <summary> Returns OBX (Observation/Result) - creates it if necessary</summary>
		virtual public OBX OBX
		{
			get
			{
				OBX ret = null;
				try
				{
					ret = (OBX) this.get_Renamed("OBX");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SSU_U03_SPECIMEN_CONTAINER Group.</summary>
		public SSU_U03_SPECIMEN_CONTAINER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SAC), true, false);
				this.add(typeof(OBX), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}