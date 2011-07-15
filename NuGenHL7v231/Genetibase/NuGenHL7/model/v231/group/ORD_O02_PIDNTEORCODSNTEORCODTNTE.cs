using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ORD_O02_PIDNTEORCODSNTEORCODTNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORD_O02_PIDNTE (a Group object) <b>optional </b><br>
	/// 1: ORD_O02_ORCODSNTE (a Group object) <b>repeating</b><br>
	/// 2: ORD_O02_ORCODTNTE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORD_O02_PIDNTEORCODSNTEORCODTNTE:AbstractGroup
	{
		/// <summary> Returns ORD_O02_PIDNTE (a Group object) - creates it if necessary</summary>
		virtual public ORD_O02_PIDNTE PIDNTE
		{
			get
			{
				ORD_O02_PIDNTE ret = null;
				try
				{
					ret = (ORD_O02_PIDNTE) this.get_Renamed("PIDNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORD_O02_ORCODSNTE </summary>
		virtual public int ORCODSNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCODSNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORD_O02_ORCODTNTE </summary>
		virtual public int ORCODTNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCODTNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORD_O02_PIDNTEORCODSNTEORCODTNTE Group.</summary>
		public ORD_O02_PIDNTEORCODSNTEORCODTNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORD_O02_PIDNTE), false, false);
				this.add(typeof(ORD_O02_ORCODSNTE), true, true);
				this.add(typeof(ORD_O02_ORCODTNTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORD_O02_ORCODSNTE (a Group object) - creates it if necessary</summary>
		public virtual ORD_O02_ORCODSNTE getORCODSNTE()
		{
			ORD_O02_ORCODSNTE ret = null;
			try
			{
				ret = (ORD_O02_ORCODSNTE) this.get_Renamed("ORCODSNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORD_O02_ORCODSNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORD_O02_ORCODSNTE getORCODSNTE(int rep)
		{
			return (ORD_O02_ORCODSNTE) this.get_Renamed("ORCODSNTE", rep);
		}
		
		/// <summary> Returns  first repetition of ORD_O02_ORCODTNTE (a Group object) - creates it if necessary</summary>
		public virtual ORD_O02_ORCODTNTE getORCODTNTE()
		{
			ORD_O02_ORCODTNTE ret = null;
			try
			{
				ret = (ORD_O02_ORCODTNTE) this.get_Renamed("ORCODTNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORD_O02_ORCODTNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORD_O02_ORCODTNTE getORCODTNTE(int rep)
		{
			return (ORD_O02_ORCODTNTE) this.get_Renamed("ORCODTNTE", rep);
		}
	}
}