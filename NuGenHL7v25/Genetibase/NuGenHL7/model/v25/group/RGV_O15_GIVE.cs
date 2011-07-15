using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RGV_O15_GIVE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXG (Pharmacy/Treatment Give) <b></b><br>
	/// 1: RGV_O15_TIMING_GIVE (a Group object) <b>repeating</b><br>
	/// 2: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
	/// 3: RXC (Pharmacy/Treatment Component Order) <b>optional repeating</b><br>
	/// 4: RGV_O15_OBSERVATION (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RGV_O15_GIVE:AbstractGroup
	{
		/// <summary> Returns RXG (Pharmacy/Treatment Give) - creates it if necessary</summary>
		virtual public RXG RXG
		{
			get
			{
				RXG ret = null;
				try
				{
					ret = (RXG) this.get_Renamed("RXG");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RGV_O15_TIMING_GIVE </summary>
		virtual public int TIMING_GIVEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING_GIVE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RXR </summary>
		virtual public int RXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RXC </summary>
		virtual public int RXCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RGV_O15_OBSERVATION </summary>
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
		
		/// <summary> Creates a new RGV_O15_GIVE Group.</summary>
		public RGV_O15_GIVE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXG), true, false);
				this.add(typeof(RGV_O15_TIMING_GIVE), true, true);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RXC), false, true);
				this.add(typeof(RGV_O15_OBSERVATION), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RGV_O15_TIMING_GIVE (a Group object) - creates it if necessary</summary>
		public virtual RGV_O15_TIMING_GIVE getTIMING_GIVE()
		{
			RGV_O15_TIMING_GIVE ret = null;
			try
			{
				ret = (RGV_O15_TIMING_GIVE) this.get_Renamed("TIMING_GIVE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGV_O15_TIMING_GIVE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGV_O15_TIMING_GIVE getTIMING_GIVE(int rep)
		{
			return (RGV_O15_TIMING_GIVE) this.get_Renamed("TIMING_GIVE", rep);
		}
		
		/// <summary> Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary</summary>
		public virtual RXR getRXR()
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
		
		/// <summary> Returns a specific repetition of RXR
		/// (Pharmacy/Treatment Route) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXR getRXR(int rep)
		{
			return (RXR) this.get_Renamed("RXR", rep);
		}
		
		/// <summary> Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary</summary>
		public virtual RXC getRXC()
		{
			RXC ret = null;
			try
			{
				ret = (RXC) this.get_Renamed("RXC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RXC
		/// (Pharmacy/Treatment Component Order) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXC getRXC(int rep)
		{
			return (RXC) this.get_Renamed("RXC", rep);
		}
		
		/// <summary> Returns  first repetition of RGV_O15_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual RGV_O15_OBSERVATION getOBSERVATION()
		{
			RGV_O15_OBSERVATION ret = null;
			try
			{
				ret = (RGV_O15_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGV_O15_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGV_O15_OBSERVATION getOBSERVATION(int rep)
		{
			return (RGV_O15_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}