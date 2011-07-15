using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the RTB_Q13_ROW_DEFINITION Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RDF (Table Row Definition) <b></b><br>
	/// 1: RDT (Table Row Data) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RTB_Q13_ROW_DEFINITION:AbstractGroup
	{
		/// <summary> Returns RDF (Table Row Definition) - creates it if necessary</summary>
		virtual public RDF RDF
		{
			get
			{
				RDF ret = null;
				try
				{
					ret = (RDF) this.get_Renamed("RDF");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RDT </summary>
		virtual public int RDTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RDT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RTB_Q13_ROW_DEFINITION Group.</summary>
		public RTB_Q13_ROW_DEFINITION(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RDF), true, false);
				this.add(typeof(RDT), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RDT (Table Row Data) - creates it if necessary</summary>
		public virtual RDT getRDT()
		{
			RDT ret = null;
			try
			{
				ret = (RDT) this.get_Renamed("RDT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RDT
		/// (Table Row Data) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RDT getRDT(int rep)
		{
			return (RDT) this.get_Renamed("RDT", rep);
		}
	}
}