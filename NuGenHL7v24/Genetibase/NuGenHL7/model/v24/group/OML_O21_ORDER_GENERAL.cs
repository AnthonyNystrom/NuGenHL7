using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the OML_O21_ORDER_GENERAL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OML_O21_CONTAINER_1 (a Group object) <b>optional </b><br>
	/// 1: OML_O21_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OML_O21_ORDER_GENERAL:AbstractGroup
	{
		/// <summary> Returns OML_O21_CONTAINER_1 (a Group object) - creates it if necessary</summary>
		virtual public OML_O21_CONTAINER_1 CONTAINER_1
		{
			get
			{
				OML_O21_CONTAINER_1 ret = null;
				try
				{
					ret = (OML_O21_CONTAINER_1) this.get_Renamed("CONTAINER_1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OML_O21_ORDER </summary>
		virtual public int ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OML_O21_ORDER_GENERAL Group.</summary>
		public OML_O21_ORDER_GENERAL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OML_O21_CONTAINER_1), false, false);
				this.add(typeof(OML_O21_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OML_O21_ORDER (a Group object) - creates it if necessary</summary>
		public virtual OML_O21_ORDER getORDER()
		{
			OML_O21_ORDER ret = null;
			try
			{
				ret = (OML_O21_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OML_O21_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OML_O21_ORDER getORDER(int rep)
		{
			return (OML_O21_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}