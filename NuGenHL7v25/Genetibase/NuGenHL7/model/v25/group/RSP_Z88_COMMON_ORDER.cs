using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RSP_Z88_COMMON_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RSP_Z88_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: RSP_Z88_ORDER_DETAIL (a Group object) <b>optional </b><br>
	/// 3: RSP_Z88_ORDER_ENCODED (a Group object) <b>optional </b><br>
	/// 4: RXD (Pharmacy/Treatment Dispense) <b></b><br>
	/// 5: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
	/// 6: RXC (Pharmacy/Treatment Component Order) <b>optional repeating</b><br>
	/// 7: RSP_Z88_OBSERVATION (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RSP_Z88_COMMON_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of RSP_Z88_TIMING </summary>
		virtual public int TIMINGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RSP_Z88_ORDER_DETAIL (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z88_ORDER_DETAIL ORDER_DETAIL
		{
			get
			{
				RSP_Z88_ORDER_DETAIL ret = null;
				try
				{
					ret = (RSP_Z88_ORDER_DETAIL) this.get_Renamed("ORDER_DETAIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RSP_Z88_ORDER_ENCODED (a Group object) - creates it if necessary</summary>
		virtual public RSP_Z88_ORDER_ENCODED ORDER_ENCODED
		{
			get
			{
				RSP_Z88_ORDER_ENCODED ret = null;
				try
				{
					ret = (RSP_Z88_ORDER_ENCODED) this.get_Renamed("ORDER_ENCODED");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RXD (Pharmacy/Treatment Dispense) - creates it if necessary</summary>
		virtual public RXD RXD
		{
			get
			{
				RXD ret = null;
				try
				{
					ret = (RXD) this.get_Renamed("RXD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
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
		/// <summary> Returns the number of existing repetitions of RSP_Z88_OBSERVATION </summary>
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
		
		/// <summary> Creates a new RSP_Z88_COMMON_ORDER Group.</summary>
		public RSP_Z88_COMMON_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RSP_Z88_TIMING), false, true);
				this.add(typeof(RSP_Z88_ORDER_DETAIL), false, false);
				this.add(typeof(RSP_Z88_ORDER_ENCODED), false, false);
				this.add(typeof(RXD), true, false);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RXC), false, true);
				this.add(typeof(RSP_Z88_OBSERVATION), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RSP_Z88_TIMING (a Group object) - creates it if necessary</summary>
		public virtual RSP_Z88_TIMING getTIMING()
		{
			RSP_Z88_TIMING ret = null;
			try
			{
				ret = (RSP_Z88_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RSP_Z88_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RSP_Z88_TIMING getTIMING(int rep)
		{
			return (RSP_Z88_TIMING) this.get_Renamed("TIMING", rep);
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
		
		/// <summary> Returns  first repetition of RSP_Z88_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual RSP_Z88_OBSERVATION getOBSERVATION()
		{
			RSP_Z88_OBSERVATION ret = null;
			try
			{
				ret = (RSP_Z88_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RSP_Z88_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RSP_Z88_OBSERVATION getOBSERVATION(int rep)
		{
			return (RSP_Z88_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}