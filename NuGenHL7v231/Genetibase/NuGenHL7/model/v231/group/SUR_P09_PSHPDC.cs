using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SUR_P09_PSHPDC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PSH (PSH - product summary header segment) <b></b><br>
	/// 1: PDC (PDC - product detail country segment) <b></b><br>
	/// </summary>
	[Serializable]
	public class SUR_P09_PSHPDC:AbstractGroup
	{
		/// <summary> Returns PSH (PSH - product summary header segment) - creates it if necessary</summary>
		virtual public PSH PSH
		{
			get
			{
				PSH ret = null;
				try
				{
					ret = (PSH) this.get_Renamed("PSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PDC (PDC - product detail country segment) - creates it if necessary</summary>
		virtual public PDC PDC
		{
			get
			{
				PDC ret = null;
				try
				{
					ret = (PDC) this.get_Renamed("PDC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new SUR_P09_PSHPDC Group.</summary>
		public SUR_P09_PSHPDC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PSH), true, false);
				this.add(typeof(PDC), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}