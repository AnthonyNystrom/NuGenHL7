using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OML_O35_ORDER_PRIOR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b>optional </b><br>
	/// 1: OBR (Observation Request) <b></b><br>
	/// 2: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 3: OML_O35_TIMING_PRIOR (a Group object) <b>optional repeating</b><br>
	/// 4: OML_O35_OBSERVATION_PRIOR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OML_O35_ORDER_PRIOR:AbstractGroup
	{
		/// <summary> Returns ORC (Common Order) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OBR (Observation Request) - creates it if necessary</summary>
		virtual public OBR OBR
		{
			get
			{
				OBR ret = null;
				try
				{
					ret = (OBR) this.get_Renamed("OBR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OML_O35_TIMING_PRIOR </summary>
		virtual public int TIMING_PRIORReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING_PRIOR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OML_O35_OBSERVATION_PRIOR </summary>
		virtual public int OBSERVATION_PRIORReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBSERVATION_PRIOR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OML_O35_ORDER_PRIOR Group.</summary>
		public OML_O35_ORDER_PRIOR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), false, false);
				this.add(typeof(OBR), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OML_O35_TIMING_PRIOR), false, true);
				this.add(typeof(OML_O35_OBSERVATION_PRIOR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (Notes and Comments) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (Notes and Comments) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of OML_O35_TIMING_PRIOR (a Group object) - creates it if necessary</summary>
		public virtual OML_O35_TIMING_PRIOR getTIMING_PRIOR()
		{
			OML_O35_TIMING_PRIOR ret = null;
			try
			{
				ret = (OML_O35_TIMING_PRIOR) this.get_Renamed("TIMING_PRIOR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O35_TIMING_PRIOR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O35_TIMING_PRIOR getTIMING_PRIOR(int rep)
		{
			return (OML_O35_TIMING_PRIOR) this.get_Renamed("TIMING_PRIOR", rep);
		}
		
		/// <summary> Returns  first repetition of OML_O35_OBSERVATION_PRIOR (a Group object) - creates it if necessary</summary>
		public virtual OML_O35_OBSERVATION_PRIOR getOBSERVATION_PRIOR()
		{
			OML_O35_OBSERVATION_PRIOR ret = null;
			try
			{
				ret = (OML_O35_OBSERVATION_PRIOR) this.get_Renamed("OBSERVATION_PRIOR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O35_OBSERVATION_PRIOR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O35_OBSERVATION_PRIOR getOBSERVATION_PRIOR(int rep)
		{
			return (OML_O35_OBSERVATION_PRIOR) this.get_Renamed("OBSERVATION_PRIOR", rep);
		}
	}
}