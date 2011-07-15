using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RAS_O17_ADMINISTRATION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXA (Pharmacy/Treatment Administration) <b>repeating</b><br>
	/// 1: RXR (Pharmacy/Treatment Route) <b></b><br>
	/// 2: RAS_O17_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RAS_O17_ADMINISTRATION:AbstractGroup
	{
		/// <summary> Returns the number of existing repetitions of RXA </summary>
		virtual public int RXAReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXA").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RXR (Pharmacy/Treatment Route) - creates it if necessary</summary>
		virtual public RXR RXR
		{
			get
			{
				RXR ret = null;
				try
				{
					ret = (RXR) this.get_Renamed("RXR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RAS_O17_OBSERVATION </summary>
		virtual public int OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RAS_O17_ADMINISTRATION Group.</summary>
		public RAS_O17_ADMINISTRATION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXA), true, true);
				this.add(typeof(RXR), true, false);
				this.add(typeof(RAS_O17_OBSERVATION), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RXA (Pharmacy/Treatment Administration) - creates it if necessary</summary>
		public virtual RXA getRXA()
		{
			RXA ret = null;
			try
			{
				ret = (RXA) this.get_Renamed("RXA");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RXA
		/// (Pharmacy/Treatment Administration) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXA getRXA(int rep)
		{
			return (RXA) this.get_Renamed("RXA", rep);
		}
		
		/// <summary> Returns  first repetition of RAS_O17_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual RAS_O17_OBSERVATION getOBSERVATION()
		{
			RAS_O17_OBSERVATION ret = null;
			try
			{
				ret = (RAS_O17_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RAS_O17_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RAS_O17_OBSERVATION getOBSERVATION(int rep)
		{
			return (RAS_O17_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}