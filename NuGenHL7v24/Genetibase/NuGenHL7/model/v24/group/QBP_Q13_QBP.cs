using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the QBP_Q13_QBP Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: Zxx (any Z segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class QBP_Q13_QBP:AbstractGroup
	{
		/// <summary> Returns Zxx (any Z segment) - creates it if necessary</summary>
		virtual public Zxx Zxx
		{
			get
			{
				Zxx ret = null;
				try
				{
					ret = (Zxx) this.get_Renamed("Zxx");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new QBP_Q13_QBP Group.</summary>
		public QBP_Q13_QBP(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(Zxx), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}