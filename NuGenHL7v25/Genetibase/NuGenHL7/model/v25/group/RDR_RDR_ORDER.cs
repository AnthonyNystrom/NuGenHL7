using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RDR_RDR_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RDR_RDR_ENCODING (a Group object) <b>optional </b><br>
	/// 2: RDR_RDR_DISPENSE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RDR_RDR_ORDER:AbstractGroup
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
		/// <summary> Returns RDR_RDR_ENCODING (a Group object) - creates it if necessary</summary>
		virtual public RDR_RDR_ENCODING ENCODING
		{
			get
			{
				RDR_RDR_ENCODING ret = null;
				try
				{
					ret = (RDR_RDR_ENCODING) this.get_Renamed("ENCODING");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RDR_RDR_DISPENSE </summary>
		virtual public int DISPENSEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DISPENSE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RDR_RDR_ORDER Group.</summary>
		public RDR_RDR_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RDR_RDR_ENCODING), false, false);
				this.add(typeof(RDR_RDR_DISPENSE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RDR_RDR_DISPENSE (a Group object) - creates it if necessary</summary>
		public virtual RDR_RDR_DISPENSE getDISPENSE()
		{
			RDR_RDR_DISPENSE ret = null;
			try
			{
				ret = (RDR_RDR_DISPENSE) this.get_Renamed("DISPENSE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RDR_RDR_DISPENSE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RDR_RDR_DISPENSE getDISPENSE(int rep)
		{
			return (RDR_RDR_DISPENSE) this.get_Renamed("DISPENSE", rep);
		}
	}
}