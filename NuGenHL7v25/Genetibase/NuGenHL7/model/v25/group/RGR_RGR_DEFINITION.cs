using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RGR_RGR_DEFINITION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: QRD (Original-Style Query Definition) <b></b><br>
	/// 1: QRF (Original style query filter) <b>optional </b><br>
	/// 2: RGR_RGR_PATIENT (a Group object) <b>optional </b><br>
	/// 3: RGR_RGR_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RGR_RGR_DEFINITION:AbstractGroup
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
		/// <summary> Returns QRF (Original style query filter) - creates it if necessary</summary>
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
		/// <summary> Returns RGR_RGR_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public RGR_RGR_PATIENT PATIENT
		{
			get
			{
				RGR_RGR_PATIENT ret = null;
				try
				{
					ret = (RGR_RGR_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RGR_RGR_ORDER </summary>
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
		
		/// <summary> Creates a new RGR_RGR_DEFINITION Group.</summary>
		public RGR_RGR_DEFINITION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(RGR_RGR_PATIENT), false, false);
				this.add(typeof(RGR_RGR_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RGR_RGR_ORDER (a Group object) - creates it if necessary</summary>
		public virtual RGR_RGR_ORDER getORDER()
		{
			RGR_RGR_ORDER ret = null;
			try
			{
				ret = (RGR_RGR_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGR_RGR_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGR_RGR_ORDER getORDER(int rep)
		{
			return (RGR_RGR_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}