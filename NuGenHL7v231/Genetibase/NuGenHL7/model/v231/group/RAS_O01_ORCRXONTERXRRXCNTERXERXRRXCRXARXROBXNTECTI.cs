using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RAS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXARXROBXNTECTI Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RAS_O01_RXONTERXRRXCNTE (a Group object) <b>optional </b><br>
	/// 2: RAS_O01_RXERXRRXC (a Group object) <b>optional </b><br>
	/// 3: RXA (RXA - pharmacy/treatment administration segment) <b>repeating</b><br>
	/// 4: RXR (RXR - pharmacy/treatment route segment) <b></b><br>
	/// 5: RAS_O01_OBXNTE (a Group object) <b>optional repeating</b><br>
	/// 6: CTI (CTI - clinical trial identification segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RAS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXARXROBXNTECTI:AbstractGroup
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
		/// <summary> Returns RAS_O01_RXONTERXRRXCNTE (a Group object) - creates it if necessary</summary>
		virtual public RAS_O01_RXONTERXRRXCNTE RXONTERXRRXCNTE
		{
			get
			{
				RAS_O01_RXONTERXRRXCNTE ret = null;
				try
				{
					ret = (RAS_O01_RXONTERXRRXCNTE) this.get_Renamed("RXONTERXRRXCNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RAS_O01_RXERXRRXC (a Group object) - creates it if necessary</summary>
		virtual public RAS_O01_RXERXRRXC RXERXRRXC
		{
			get
			{
				RAS_O01_RXERXRRXC ret = null;
				try
				{
					ret = (RAS_O01_RXERXRRXC) this.get_Renamed("RXERXRRXC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
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
		/// <summary> Returns RXR (RXR - pharmacy/treatment route segment) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of RAS_O01_OBXNTE </summary>
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
		/// <summary> Returns the number of existing repetitions of CTI </summary>
		virtual public int CTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RAS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXARXROBXNTECTI Group.</summary>
		public RAS_O01_ORCRXONTERXRRXCNTERXERXRRXCRXARXROBXNTECTI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RAS_O01_RXONTERXRRXCNTE), false, false);
				this.add(typeof(RAS_O01_RXERXRRXC), false, false);
				this.add(typeof(RXA), true, true);
				this.add(typeof(RXR), true, false);
				this.add(typeof(RAS_O01_OBXNTE), false, true);
				this.add(typeof(CTI), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RXA (RXA - pharmacy/treatment administration segment) - creates it if necessary</summary>
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
		/// (RXA - pharmacy/treatment administration segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXA getRXA(int rep)
		{
			return (RXA) this.get_Renamed("RXA", rep);
		}
		
		/// <summary> Returns  first repetition of RAS_O01_OBXNTE (a Group object) - creates it if necessary</summary>
		public virtual RAS_O01_OBXNTE getOBXNTE()
		{
			RAS_O01_OBXNTE ret = null;
			try
			{
				ret = (RAS_O01_OBXNTE) this.get_Renamed("OBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RAS_O01_OBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RAS_O01_OBXNTE getOBXNTE(int rep)
		{
			return (RAS_O01_OBXNTE) this.get_Renamed("OBXNTE", rep);
		}
		
		/// <summary> Returns  first repetition of CTI (CTI - clinical trial identification segment) - creates it if necessary</summary>
		public virtual CTI getCTI()
		{
			CTI ret = null;
			try
			{
				ret = (CTI) this.get_Renamed("CTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CTI
		/// (CTI - clinical trial identification segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CTI getCTI(int rep)
		{
			return (CTI) this.get_Renamed("CTI", rep);
		}
	}
}