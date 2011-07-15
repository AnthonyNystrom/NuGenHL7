using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the NMQ_N02_QRY_WITH_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: QRD (QUERY DEFINITION) <b></b><br>
	/// 1: QRF (QUERY FILTER) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class NMQ_N02_QRY_WITH_DETAIL:AbstractGroup
	{
		/// <summary> Returns QRD (QUERY DEFINITION) - creates it if necessary</summary>
		virtual public QRD QRD
		{
			get
			{
				QRD ret = null;
				try
				{
					ret = (QRD) this.get_Renamed("QRD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns QRF (QUERY FILTER) - creates it if necessary</summary>
		virtual public QRF QRF
		{
			get
			{
				QRF ret = null;
				try
				{
					ret = (QRF) this.get_Renamed("QRF");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new NMQ_N02_QRY_WITH_DETAIL Group.</summary>
		public NMQ_N02_QRY_WITH_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}