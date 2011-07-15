using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the ORD_O04_RESPONSE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORD_O04_PATIENT (a Group object) <b>optional </b><br>
	/// 1: ORD_O04_ORDER_DIET (a Group object) <b>repeating</b><br>
	/// 2: ORD_O04_ORDER_TRAY (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORD_O04_RESPONSE:AbstractGroup
	{
		/// <summary> Returns ORD_O04_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public ORD_O04_PATIENT PATIENT
		{
			get
			{
				ORD_O04_PATIENT ret = null;
				try
				{
					ret = (ORD_O04_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORD_O04_ORDER_DIET </summary>
		virtual public int ORDER_DIETReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER_DIET").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORD_O04_ORDER_TRAY </summary>
		virtual public int ORDER_TRAYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER_TRAY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORD_O04_RESPONSE Group.</summary>
		public ORD_O04_RESPONSE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORD_O04_PATIENT), false, false);
				this.add(typeof(ORD_O04_ORDER_DIET), true, true);
				this.add(typeof(ORD_O04_ORDER_TRAY), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORD_O04_ORDER_DIET (a Group object) - creates it if necessary</summary>
		public virtual ORD_O04_ORDER_DIET getORDER_DIET()
		{
			ORD_O04_ORDER_DIET ret = null;
			try
			{
				ret = (ORD_O04_ORDER_DIET) this.get_Renamed("ORDER_DIET");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORD_O04_ORDER_DIET
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORD_O04_ORDER_DIET getORDER_DIET(int rep)
		{
			return (ORD_O04_ORDER_DIET) this.get_Renamed("ORDER_DIET", rep);
		}
		
		/// <summary> Returns  first repetition of ORD_O04_ORDER_TRAY (a Group object) - creates it if necessary</summary>
		public virtual ORD_O04_ORDER_TRAY getORDER_TRAY()
		{
			ORD_O04_ORDER_TRAY ret = null;
			try
			{
				ret = (ORD_O04_ORDER_TRAY) this.get_Renamed("ORDER_TRAY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORD_O04_ORDER_TRAY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORD_O04_ORDER_TRAY getORDER_TRAY(int rep)
		{
			return (ORD_O04_ORDER_TRAY) this.get_Renamed("ORDER_TRAY", rep);
		}
	}
}