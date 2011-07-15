using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the OMD_O01_ORCODSNTEOBXNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: OMD_O01_ODSNTEOBXNTE (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OMD_O01_ORCODSNTEOBXNTE:AbstractGroup
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
		/// <summary> Returns OMD_O01_ODSNTEOBXNTE (a Group object) - creates it if necessary</summary>
		virtual public OMD_O01_ODSNTEOBXNTE ODSNTEOBXNTE
		{
			get
			{
				OMD_O01_ODSNTEOBXNTE ret = null;
				try
				{
					ret = (OMD_O01_ODSNTEOBXNTE) this.get_Renamed("ODSNTEOBXNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new OMD_O01_ORCODSNTEOBXNTE Group.</summary>
		public OMD_O01_ORCODSNTEOBXNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OMD_O01_ODSNTEOBXNTE), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}