using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SRR_S01_PIDPV1PV2DG1 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (PID - patient identification segment) <b></b><br>
	/// 1: PV1 (PV1 - patient visit segment-) <b>optional </b><br>
	/// 2: PV2 (PV2 - patient visit - additional information segment) <b>optional </b><br>
	/// 3: DG1 (DG1 - diagnosis segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class SRR_S01_PIDPV1PV2DG1:AbstractGroup
	{
		/// <summary> Returns PID (PID - patient identification segment) - creates it if necessary</summary>
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
		/// <summary> Returns PV1 (PV1 - patient visit segment-) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary</summary>
		virtual public PV2 PV2
		{
			get
			{
				PV2 ret = null;
				try
				{
					ret = (PV2) this.get_Renamed("PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DG1 </summary>
		virtual public int DG1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DG1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SRR_S01_PIDPV1PV2DG1 Group.</summary>
		public SRR_S01_PIDPV1PV2DG1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PV1), false, false);
				this.add(typeof(PV2), false, false);
				this.add(typeof(DG1), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary</summary>
		public virtual DG1 getDG1()
		{
			DG1 ret = null;
			try
			{
				ret = (DG1) this.get_Renamed("DG1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DG1
		/// (DG1 - diagnosis segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DG1 getDG1(int rep)
		{
			return (DG1) this.get_Renamed("DG1", rep);
		}
	}
}