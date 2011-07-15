using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the OUL_R21_CONTAINER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: SAC (Specimen and container detail) <b></b><br>
	/// 1: SID (Substance Identifier) <b>optional </b><br>
	/// 2: OBX (Observation/Result) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OUL_R21_CONTAINER:AbstractGroup
	{
		/// <summary> Returns SAC (Specimen and container detail) - creates it if necessary</summary>
		virtual public SAC SAC
		{
			get
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
			
		}
		/// <summary> Returns SID (Substance Identifier) - creates it if necessary</summary>
		virtual public SID SID
		{
			get
			{
				SID ret = null;
				try
				{
					ret = (SID) this.get_Renamed("SID");
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
		
		/// <summary> Creates a new OUL_R21_CONTAINER Group.</summary>
		public OUL_R21_CONTAINER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(SAC), true, false);
				this.add(typeof(SID), false, false);
				this.add(typeof(OBX), false, true);
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
	}
}