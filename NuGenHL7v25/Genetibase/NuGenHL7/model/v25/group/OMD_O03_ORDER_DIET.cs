using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OMD_O03_ORDER_DIET Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: OMD_O03_TIMING_DIET (a Group object) <b>optional repeating</b><br>
	/// 2: OMD_O03_DIET (a Group object) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OMD_O03_ORDER_DIET:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of OMD_O03_TIMING_DIET </summary>
		virtual public int TIMING_DIETReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING_DIET").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns OMD_O03_DIET (a Group object) - creates it if necessary</summary>
		virtual public OMD_O03_DIET DIET
		{
			get
			{
				OMD_O03_DIET ret = null;
				try
				{
					ret = (OMD_O03_DIET) this.get_Renamed("DIET");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new OMD_O03_ORDER_DIET Group.</summary>
		public OMD_O03_ORDER_DIET(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OMD_O03_TIMING_DIET), false, true);
				this.add(typeof(OMD_O03_DIET), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of OMD_O03_TIMING_DIET (a Group object) - creates it if necessary</summary>
		public virtual OMD_O03_TIMING_DIET getTIMING_DIET()
		{
			OMD_O03_TIMING_DIET ret = null;
			try
			{
				ret = (OMD_O03_TIMING_DIET) this.get_Renamed("TIMING_DIET");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O03_TIMING_DIET
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O03_TIMING_DIET getTIMING_DIET(int rep)
		{
			return (OMD_O03_TIMING_DIET) this.get_Renamed("TIMING_DIET", rep);
		}
	}
}