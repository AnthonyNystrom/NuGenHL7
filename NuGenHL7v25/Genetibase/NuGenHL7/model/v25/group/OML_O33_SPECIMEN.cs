using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OML_O33_SPECIMEN Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SPM (Specimen) <b></b><br>
	/// 1: OBX (Observation/Result) <b>optional repeating</b><br>
	/// 2: SAC (Specimen Container detail) <b>optional repeating</b><br>
	/// 3: OML_O33_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OML_O33_SPECIMEN:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of SAC </summary>
		virtual public int SACReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SAC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OML_O33_ORDER </summary>
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
		
		/// <summary> Creates a new OML_O33_SPECIMEN Group.</summary>
		public OML_O33_SPECIMEN(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SPM), true, false);
				this.add(typeof(OBX), false, true);
				this.add(typeof(SAC), false, true);
				this.add(typeof(OML_O33_ORDER), true, true);
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
		
		/// <summary> Returns  first repetition of SAC (Specimen Container detail) - creates it if necessary</summary>
		public virtual SAC getSAC()
		{
			SAC ret = null;
			try
			{
				ret = (SAC) this.get_Renamed("SAC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SAC
		/// (Specimen Container detail) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SAC getSAC(int rep)
		{
			return (SAC) this.get_Renamed("SAC", rep);
		}
		
		/// <summary> Returns  first repetition of OML_O33_ORDER (a Group object) - creates it if necessary</summary>
		public virtual OML_O33_ORDER getORDER()
		{
			OML_O33_ORDER ret = null;
			try
			{
				ret = (OML_O33_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O33_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O33_ORDER getORDER(int rep)
		{
			return (OML_O33_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}