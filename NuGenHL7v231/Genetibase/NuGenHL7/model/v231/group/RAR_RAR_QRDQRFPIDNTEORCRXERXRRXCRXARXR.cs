using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RAR_RAR_QRDQRFPIDNTEORCRXERXRRXCRXARXR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: QRD (QRD - original-style query definition segment) <b></b><br>
	/// 1: QRF (QRF - original style query filter segment) <b>optional </b><br>
	/// 2: RAR_RAR_PIDNTE (a Group object) <b>optional </b><br>
	/// 3: RAR_RAR_ORCRXERXRRXCRXARXR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RAR_RAR_QRDQRFPIDNTEORCRXERXRRXCRXARXR:AbstractGroup
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
		/// <summary> Returns RAR_RAR_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public RAR_RAR_PIDNTE PIDNTE
		{
			get
			{
				RAR_RAR_PIDNTE ret = null;
				try
				{
					ret = (RAR_RAR_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RAR_RAR_ORCRXERXRRXCRXARXR </summary>
		virtual public int ORCRXERXRRXCRXARXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXERXRRXCRXARXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RAR_RAR_QRDQRFPIDNTEORCRXERXRRXCRXARXR Group.</summary>
		public RAR_RAR_QRDQRFPIDNTEORCRXERXRRXCRXARXR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(RAR_RAR_PIDNTE), false, false);
				this.add(typeof(RAR_RAR_ORCRXERXRRXCRXARXR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RAR_RAR_ORCRXERXRRXCRXARXR (a Group object) - creates it if necessary</summary>
		public virtual RAR_RAR_ORCRXERXRRXCRXARXR getORCRXERXRRXCRXARXR()
		{
			RAR_RAR_ORCRXERXRRXCRXARXR ret = null;
			try
			{
				ret = (RAR_RAR_ORCRXERXRRXCRXARXR) this.get_Renamed("ORCRXERXRRXCRXARXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RAR_RAR_ORCRXERXRRXCRXARXR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RAR_RAR_ORCRXERXRRXCRXARXR getORCRXERXRRXCRXARXR(int rep)
		{
			return (RAR_RAR_ORCRXERXRRXCRXARXR) this.get_Renamed("ORCRXERXRRXCRXARXR", rep);
		}
	}
}