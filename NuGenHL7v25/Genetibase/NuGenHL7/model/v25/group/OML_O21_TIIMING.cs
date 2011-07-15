using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the OML_O21_TIIMING Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: TQ1 (Timing/Quantity) <b></b><br>
	/// 1: TQ2 (Timing/Quantity Relationship) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OML_O21_TIIMING:AbstractGroup
	{
		/// <summary> Returns TQ1 (Timing/Quantity) - creates it if necessary</summary>
		virtual public TQ1 TQ1
		{
			get
			{
				TQ1 ret = null;
				try
				{
					ret = (TQ1) this.get_Renamed("TQ1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of TQ2 </summary>
		virtual public int TQ2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TQ2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OML_O21_TIIMING Group.</summary>
		public OML_O21_TIIMING(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(TQ1), true, false);
				this.add(typeof(TQ2), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of TQ2 (Timing/Quantity Relationship) - creates it if necessary</summary>
		public virtual TQ2 getTQ2()
		{
			TQ2 ret = null;
			try
			{
				ret = (TQ2) this.get_Renamed("TQ2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of TQ2
		/// (Timing/Quantity Relationship) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual TQ2 getTQ2(int rep)
		{
			return (TQ2) this.get_Renamed("TQ2", rep);
		}
	}
}