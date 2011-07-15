using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RSP_Z88_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (Patient identification) <b></b><br>
	/// 1: PD1 (patient additional demographic) <b>optional </b><br>
	/// 2: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 3: RSP_Z88_ALLERGY (a Group object) <b>optional </b><br>
	/// 4: RSP_Z88_COMMON_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RSP_Z88_QUERY_RESPONSE:AbstractGroup
	{
		/// <summary> Returns PID (Patient identification) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PD1 (patient additional demographic) - creates it if necessary</summary>
		virtual public PD1 PD1
		{
			get
			{
				PD1 ret = null;
				try
				{
					ret = (PD1) this.get_Renamed("PD1");
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
		/// <summary> Returns RSP_Z88_ALLERGY (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z88_ALLERGY ALLERGY
		{
			get
			{
				RSP_Z88_ALLERGY ret = null;
				try
				{
					ret = (RSP_Z88_ALLERGY) this.get_Renamed("ALLERGY");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RSP_Z88_COMMON_ORDER </summary>
		virtual public int COMMON_ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("COMMON_ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RSP_Z88_QUERY_RESPONSE Group.</summary>
		public RSP_Z88_QUERY_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(RSP_Z88_ALLERGY), false, false);
				this.add(typeof(RSP_Z88_COMMON_ORDER), true, true);
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
		
		/// <summary> Returns  first repetition of RSP_Z88_COMMON_ORDER (a Group object) - creates it if necessary</summary>
		public virtual RSP_Z88_COMMON_ORDER getCOMMON_ORDER()
		{
			RSP_Z88_COMMON_ORDER ret = null;
			try
			{
				ret = (RSP_Z88_COMMON_ORDER) this.get_Renamed("COMMON_ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RSP_Z88_COMMON_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RSP_Z88_COMMON_ORDER getCOMMON_ORDER(int rep)
		{
			return (RSP_Z88_COMMON_ORDER) this.get_Renamed("COMMON_ORDER", rep);
		}
	}
}