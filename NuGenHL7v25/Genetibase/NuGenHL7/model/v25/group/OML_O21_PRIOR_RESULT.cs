using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OML_O21_PRIOR_RESULT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OML_O21_PATIENT_PRIOR (a Group object) <b>optional </b><br>
	/// 1: OML_O21_PATIENT_VISIT_PRIOR (a Group object) <b>optional </b><br>
	/// 2: AL1 (Patient Allergy Information) <b>optional repeating</b><br>
	/// 3: OML_O21_ORDER_PRIOR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OML_O21_PRIOR_RESULT:AbstractGroup
	{
		/// <summary> Returns OML_O21_PATIENT_PRIOR (a Group object) - creates it if necessary</summary>
		virtual public OML_O21_PATIENT_PRIOR PATIENT_PRIOR
		{
			get
			{
				OML_O21_PATIENT_PRIOR ret = null;
				try
				{
					ret = (OML_O21_PATIENT_PRIOR) this.get_Renamed("PATIENT_PRIOR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OML_O21_PATIENT_VISIT_PRIOR (a Group object) - creates it if necessary</summary>
		virtual public OML_O21_PATIENT_VISIT_PRIOR PATIENT_VISIT_PRIOR
		{
			get
			{
				OML_O21_PATIENT_VISIT_PRIOR ret = null;
				try
				{
					ret = (OML_O21_PATIENT_VISIT_PRIOR) this.get_Renamed("PATIENT_VISIT_PRIOR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of AL1 </summary>
		virtual public int AL1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AL1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OML_O21_ORDER_PRIOR </summary>
		virtual public int ORDER_PRIORReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER_PRIOR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OML_O21_PRIOR_RESULT Group.</summary>
		public OML_O21_PRIOR_RESULT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OML_O21_PATIENT_PRIOR), false, false);
				this.add(typeof(OML_O21_PATIENT_VISIT_PRIOR), false, false);
				this.add(typeof(AL1), false, true);
				this.add(typeof(OML_O21_ORDER_PRIOR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of AL1 (Patient Allergy Information) - creates it if necessary</summary>
		public virtual AL1 getAL1()
		{
			AL1 ret = null;
			try
			{
				ret = (AL1) this.get_Renamed("AL1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of AL1
		/// (Patient Allergy Information) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual AL1 getAL1(int rep)
		{
			return (AL1) this.get_Renamed("AL1", rep);
		}
		
		/// <summary> Returns  first repetition of OML_O21_ORDER_PRIOR (a Group object) - creates it if necessary</summary>
		public virtual OML_O21_ORDER_PRIOR getORDER_PRIOR()
		{
			OML_O21_ORDER_PRIOR ret = null;
			try
			{
				ret = (OML_O21_ORDER_PRIOR) this.get_Renamed("ORDER_PRIOR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O21_ORDER_PRIOR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O21_ORDER_PRIOR getORDER_PRIOR(int rep)
		{
			return (OML_O21_ORDER_PRIOR) this.get_Renamed("ORDER_PRIOR", rep);
		}
	}
}