using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the QVR_Q17_QBP Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: Hxx (any HL7 segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class QVR_Q17_QBP:AbstractGroup
	{
		/// <summary> Returns Hxx (any HL7 segment) - creates it if necessary</summary>
		virtual public Hxx Hxx
		{
			get
			{
				Hxx ret = null;
				try
				{
					ret = (Hxx) this.get_Renamed("Hxx");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new QVR_Q17_QBP Group.</summary>
		public QVR_Q17_QBP(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(Hxx), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}