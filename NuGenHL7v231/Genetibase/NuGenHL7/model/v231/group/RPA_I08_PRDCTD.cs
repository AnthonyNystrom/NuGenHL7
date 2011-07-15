using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RPA_I08_PRDCTD Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PRD (Provider Data) <b></b><br>
	/// 1: CTD (Contact Data) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RPA_I08_PRDCTD:AbstractGroup
	{
		/// <summary> Returns PRD (Provider Data) - creates it if necessary</summary>
		virtual public PRD PRD
		{
			get
			{
				PRD ret = null;
				try
				{
					ret = (PRD) this.get_Renamed("PRD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CTD </summary>
		virtual public int CTDReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CTD").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RPA_I08_PRDCTD Group.</summary>
		public RPA_I08_PRDCTD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PRD), true, false);
				this.add(typeof(CTD), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CTD (Contact Data) - creates it if necessary</summary>
		public virtual CTD getCTD()
		{
			CTD ret = null;
			try
			{
				ret = (CTD) this.get_Renamed("CTD");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CTD
		/// (Contact Data) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CTD getCTD(int rep)
		{
			return (CTD) this.get_Renamed("CTD", rep);
		}
	}
}