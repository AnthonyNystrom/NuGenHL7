using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: RGV_O01_RXONTERXRRXCNTE (a Group object) <b>optional </b><br>
	/// 2: RGV_O01_RXERXRRXC (a Group object) <b>optional </b><br>
	/// 3: RGV_O01_RXGRXRRXCOBXNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE:AbstractGroup
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
		/// <summary> Returns RGV_O01_RXONTERXRRXCNTE (a Group object) - creates it if necessary</summary>
		virtual public RGV_O01_RXONTERXRRXCNTE RXONTERXRRXCNTE
		{
			get
			{
				RGV_O01_RXONTERXRRXCNTE ret = null;
				try
				{
					ret = (RGV_O01_RXONTERXRRXCNTE) this.get_Renamed("RXONTERXRRXCNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RGV_O01_RXERXRRXC (a Group object) - creates it if necessary</summary>
		virtual public RGV_O01_RXERXRRXC RXERXRRXC
		{
			get
			{
				RGV_O01_RXERXRRXC ret = null;
				try
				{
					ret = (RGV_O01_RXERXRRXC) this.get_Renamed("RXERXRRXC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RGV_O01_RXGRXRRXCOBXNTE </summary>
		virtual public int RXGRXRRXCOBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXGRXRRXCOBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE Group.</summary>
		public RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RGV_O01_RXONTERXRRXCNTE), false, false);
				this.add(typeof(RGV_O01_RXERXRRXC), false, false);
				this.add(typeof(RGV_O01_RXGRXRRXCOBXNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RGV_O01_RXGRXRRXCOBXNTE (a Group object) - creates it if necessary</summary>
		public virtual RGV_O01_RXGRXRRXCOBXNTE getRXGRXRRXCOBXNTE()
		{
			RGV_O01_RXGRXRRXCOBXNTE ret = null;
			try
			{
				ret = (RGV_O01_RXGRXRRXCOBXNTE) this.get_Renamed("RXGRXRRXCOBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGV_O01_RXGRXRRXCOBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGV_O01_RXGRXRRXCOBXNTE getRXGRXRRXCOBXNTE(int rep)
		{
			return (RGV_O01_RXGRXRRXCOBXNTE) this.get_Renamed("RXGRXRRXCOBXNTE", rep);
		}
	}
}