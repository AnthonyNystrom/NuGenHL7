using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RDR_RDR_DEFINITION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: QRD (Original-Style Query Definition) <b></b><br>
	/// 1: QRF (Original Style Query Filter) <b>optional </b><br>
	/// 2: RDR_RDR_PATIENT (a Group object) <b>optional </b><br>
	/// 3: RDR_RDR_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RDR_RDR_DEFINITION:AbstractGroup
	{
		/// <summary> Returns QRD (Original-Style Query Definition) - creates it if necessary</summary>
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
		/// <summary> Returns QRF (Original Style Query Filter) - creates it if necessary</summary>
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
		/// <summary> Returns RDR_RDR_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public RDR_RDR_PATIENT PATIENT
		{
			get
			{
				RDR_RDR_PATIENT ret = null;
				try
				{
					ret = (RDR_RDR_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RDR_RDR_ORDER </summary>
		virtual public int ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RDR_RDR_DEFINITION Group.</summary>
		public RDR_RDR_DEFINITION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(RDR_RDR_PATIENT), false, false);
				this.add(typeof(RDR_RDR_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RDR_RDR_ORDER (a Group object) - creates it if necessary</summary>
		public virtual RDR_RDR_ORDER getORDER()
		{
			RDR_RDR_ORDER ret = null;
			try
			{
				ret = (RDR_RDR_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RDR_RDR_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RDR_RDR_ORDER getORDER(int rep)
		{
			return (RDR_RDR_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}