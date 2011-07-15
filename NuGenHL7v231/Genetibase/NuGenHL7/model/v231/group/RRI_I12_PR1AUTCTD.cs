using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRI_I12_PR1AUTCTD Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PR1 (PR1 - procedures segment) <b></b><br>
	/// 1: RRI_I12_AUTCTD (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class RRI_I12_PR1AUTCTD:AbstractGroup
	{
		/// <summary> Returns PR1 (PR1 - procedures segment) - creates it if necessary</summary>
		virtual public PR1 PR1
		{
			get
			{
				PR1 ret = null;
				try
				{
					ret = (PR1) this.get_Renamed("PR1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RRI_I12_AUTCTD (a Group object) - creates it if necessary</summary>
		virtual public RRI_I12_AUTCTD AUTCTD
		{
			get
			{
				RRI_I12_AUTCTD ret = null;
				try
				{
					ret = (RRI_I12_AUTCTD) this.get_Renamed("AUTCTD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RRI_I12_PR1AUTCTD Group.</summary>
		public RRI_I12_PR1AUTCTD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PR1), true, false);
				this.add(typeof(RRI_I12_AUTCTD), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}