using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the VXR_V03_ORCRXARXROBXNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b>optional </b><br>
	/// 1: RXA (RXA - pharmacy/treatment administration segment) <b></b><br>
	/// 2: RXR (RXR - pharmacy/treatment route segment) <b>optional </b><br>
	/// 3: VXR_V03_OBXNTE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class VXR_V03_ORCRXARXROBXNTE:AbstractGroup
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
		/// <summary> Returns RXA (RXA - pharmacy/treatment administration segment) - creates it if necessary</summary>
		virtual public RXA RXA
		{
			get
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
		/// <summary> Returns the number of existing repetitions of VXR_V03_OBXNTE </summary>
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
		
		/// <summary> Creates a new VXR_V03_ORCRXARXROBXNTE Group.</summary>
		public VXR_V03_ORCRXARXROBXNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), false, false);
				this.add(typeof(RXA), true, false);
				this.add(typeof(RXR), false, false);
				this.add(typeof(VXR_V03_OBXNTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of VXR_V03_OBXNTE (a Group object) - creates it if necessary</summary>
		public virtual VXR_V03_OBXNTE getOBXNTE()
		{
			VXR_V03_OBXNTE ret = null;
			try
			{
				ret = (VXR_V03_OBXNTE) this.get_Renamed("OBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of VXR_V03_OBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual VXR_V03_OBXNTE getOBXNTE(int rep)
		{
			return (VXR_V03_OBXNTE) this.get_Renamed("OBXNTE", rep);
		}
	}
}