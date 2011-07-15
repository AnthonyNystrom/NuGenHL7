using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RRA_O02_RXARXR Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXA (RXA - pharmacy/treatment administration segment) <b>repeating</b><br>
	/// 1: RXR (RXR - pharmacy/treatment route segment) <b></b><br>
	/// </summary>
	[Serializable]
	public class RRA_O02_RXARXR:AbstractGroup
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
		
		/// <summary> Creates a new RRA_O02_RXARXR Group.</summary>
		public RRA_O02_RXARXR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXA), true, true);
				this.add(typeof(RXR), true, false);
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
	}
}