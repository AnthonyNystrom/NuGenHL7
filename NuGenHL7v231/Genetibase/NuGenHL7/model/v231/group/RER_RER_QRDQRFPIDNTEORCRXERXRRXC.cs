using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RER_RER_QRDQRFPIDNTEORCRXERXRRXC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: QRD (QRD - original-style query definition segment) <b></b><br>
	/// 1: QRF (QRF - original style query filter segment) <b>optional </b><br>
	/// 2: RER_RER_PIDNTE (a Group object) <b>optional </b><br>
	/// 3: RER_RER_ORCRXERXRRXC (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RER_RER_QRDQRFPIDNTEORCRXERXRRXC:AbstractGroup
	{
		/// <summary> Returns QRD (QRD - original-style query definition segment) - creates it if necessary</summary>
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
		/// <summary> Returns QRF (QRF - original style query filter segment) - creates it if necessary</summary>
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
		/// <summary> Returns RER_RER_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public RER_RER_PIDNTE PIDNTE
		{
			get
			{
				RER_RER_PIDNTE ret = null;
				try
				{
					ret = (RER_RER_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RER_RER_ORCRXERXRRXC </summary>
		virtual public int ORCRXERXRRXCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXERXRRXC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RER_RER_QRDQRFPIDNTEORCRXERXRRXC Group.</summary>
		public RER_RER_QRDQRFPIDNTEORCRXERXRRXC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(RER_RER_PIDNTE), false, false);
				this.add(typeof(RER_RER_ORCRXERXRRXC), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RER_RER_ORCRXERXRRXC (a Group object) - creates it if necessary</summary>
		public virtual RER_RER_ORCRXERXRRXC getORCRXERXRRXC()
		{
			RER_RER_ORCRXERXRRXC ret = null;
			try
			{
				ret = (RER_RER_ORCRXERXRRXC) this.get_Renamed("ORCRXERXRRXC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RER_RER_ORCRXERXRRXC
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RER_RER_ORCRXERXRRXC getORCRXERXRRXC(int rep)
		{
			return (RER_RER_ORCRXERXRRXC) this.get_Renamed("ORCRXERXRRXC", rep);
		}
	}
}