using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RDS_O01_RXCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXC (RXC - pharmacy/treatment component order segment) <b>repeating</b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RDS_O01_RXCNTE:AbstractGroup
	{
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
		
		/// <summary> Creates a new RDS_O01_RXCNTE Group.</summary>
		public RDS_O01_RXCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXC), true, true);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
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
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
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
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
	}
}