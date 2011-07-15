using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RDS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXDRXRRXCOBXNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RDS_O01_RXONTERXRRXCNTE (a Group object) <b>optional </b><br>
	/// 2: RDS_O01_RXERXRRXC (a Group object) <b>optional </b><br>
	/// 3: RXD (RXD - pharmacy/treatment dispense segment) <b></b><br>
	/// 4: RXR (RXR - pharmacy/treatment route segment) <b>repeating</b><br>
	/// 5: RXC (RXC - pharmacy/treatment component order segment) <b>optional repeating</b><br>
	/// 6: RDS_O01_OBXNTE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RDS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXDRXRRXCOBXNTE:AbstractGroup
	{
		/// <summary> Returns ORC (ORC - common order segment) - creates it if necessary</summary>
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
		/// <summary> Returns RDS_O01_RXONTERXRRXCNTE (a Group object) - creates it if necessary</summary>
		virtual public RDS_O01_RXONTERXRRXCNTE RXONTERXRRXCNTE
		{
			get
			{
				RDS_O01_RXONTERXRRXCNTE ret = null;
				try
				{
					ret = (RDS_O01_RXONTERXRRXCNTE) this.get_Renamed("RXONTERXRRXCNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RDS_O01_RXERXRRXC (a Group object) - creates it if necessary</summary>
		virtual public RDS_O01_RXERXRRXC RXERXRRXC
		{
			get
			{
				RDS_O01_RXERXRRXC ret = null;
				try
				{
					ret = (RDS_O01_RXERXRRXC) this.get_Renamed("RXERXRRXC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RXD (RXD - pharmacy/treatment dispense segment) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of RDS_O01_OBXNTE </summary>
		virtual public int OBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RDS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXDRXRRXCOBXNTE Group.</summary>
		public RDS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXDRXRRXCOBXNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RDS_O01_RXONTERXRRXCNTE), false, false);
				this.add(typeof(RDS_O01_RXERXRRXC), false, false);
				this.add(typeof(RXD), true, false);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RXC), false, true);
				this.add(typeof(RDS_O01_OBXNTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RXR (RXR - pharmacy/treatment route segment) - creates it if necessary</summary>
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
		/// (RXR - pharmacy/treatment route segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXR getRXR(int rep)
		{
			return (RXR) this.get_Renamed("RXR", rep);
		}
		
		/// <summary> Returns  first repetition of RXC (RXC - pharmacy/treatment component order segment) - creates it if necessary</summary>
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
		/// (RXC - pharmacy/treatment component order segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXC getRXC(int rep)
		{
			return (RXC) this.get_Renamed("RXC", rep);
		}
		
		/// <summary> Returns  first repetition of RDS_O01_OBXNTE (a Group object) - creates it if necessary</summary>
		public virtual RDS_O01_OBXNTE getOBXNTE()
		{
			RDS_O01_OBXNTE ret = null;
			try
			{
				ret = (RDS_O01_OBXNTE) this.get_Renamed("OBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RDS_O01_OBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RDS_O01_OBXNTE getOBXNTE(int rep)
		{
			return (RDS_O01_OBXNTE) this.get_Renamed("OBXNTE", rep);
		}
	}
}