using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OUL_R22_SPECIMEN Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SPM (Specimen) <b></b><br>
	/// 1: OBX (Observation/Result) <b>optional repeating</b><br>
	/// 2: OUL_R22_CONTAINER (a Group object) <b>optional repeating</b><br>
	/// 3: OUL_R22_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OUL_R22_SPECIMEN:AbstractGroup
	{
		/// <summary> Returns SPM (Specimen) - creates it if necessary</summary>
		virtual public SPM SPM
		{
			get
			{
				SPM ret = null;
				try
				{
					ret = (SPM) this.get_Renamed("SPM");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OBX </summary>
		virtual public int OBXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBX").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OUL_R22_CONTAINER </summary>
		virtual public int CONTAINERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CONTAINER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OUL_R22_ORDER </summary>
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
		
		/// <summary> Creates a new OUL_R22_SPECIMEN Group.</summary>
		public OUL_R22_SPECIMEN(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SPM), true, false);
				this.add(typeof(OBX), false, true);
				this.add(typeof(OUL_R22_CONTAINER), false, true);
				this.add(typeof(OUL_R22_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OBX (Observation/Result) - creates it if necessary</summary>
		public virtual OBX getOBX()
		{
			OBX ret = null;
			try
			{
				ret = (OBX) this.get_Renamed("OBX");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OBX
		/// (Observation/Result) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OBX getOBX(int rep)
		{
			return (OBX) this.get_Renamed("OBX", rep);
		}
		
		/// <summary> Returns  first repetition of OUL_R22_CONTAINER (a Group object) - creates it if necessary</summary>
		public virtual OUL_R22_CONTAINER getCONTAINER()
		{
			OUL_R22_CONTAINER ret = null;
			try
			{
				ret = (OUL_R22_CONTAINER) this.get_Renamed("CONTAINER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OUL_R22_CONTAINER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OUL_R22_CONTAINER getCONTAINER(int rep)
		{
			return (OUL_R22_CONTAINER) this.get_Renamed("CONTAINER", rep);
		}
		
		/// <summary> Returns  first repetition of OUL_R22_ORDER (a Group object) - creates it if necessary</summary>
		public virtual OUL_R22_ORDER getORDER()
		{
			OUL_R22_ORDER ret = null;
			try
			{
				ret = (OUL_R22_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OUL_R22_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OUL_R22_ORDER getORDER(int rep)
		{
			return (OUL_R22_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}