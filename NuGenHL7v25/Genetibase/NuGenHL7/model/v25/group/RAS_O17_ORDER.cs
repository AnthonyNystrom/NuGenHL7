using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RAS_O17_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (Common Order) <b></b><br>
	/// 1: RAS_O17_TIMING (a Group object) <b>optional repeating</b><br>
	/// 2: RAS_O17_ORDER_DETAIL (a Group object) <b>optional </b><br>
	/// 3: RAS_O17_ENCODING (a Group object) <b>optional </b><br>
	/// 4: RAS_O17_ADMINISTRATION (a Group object) <b>repeating</b><br>
	/// 5: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RAS_O17_ORDER:AbstractGroup
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
		/// <summary> Returns the number of existing repetitions of RAS_O17_TIMING </summary>
		virtual public int TIMINGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RAS_O17_ORDER_DETAIL (a Group object) - creates it if necessary</summary>
		virtual public RAS_O17_ORDER_DETAIL ORDER_DETAIL
		{
			get
			{
				RAS_O17_ORDER_DETAIL ret = null;
				try
				{
					ret = (RAS_O17_ORDER_DETAIL) this.get_Renamed("ORDER_DETAIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RAS_O17_ENCODING (a Group object) - creates it if necessary</summary>
		virtual public RAS_O17_ENCODING ENCODING
		{
			get
			{
				RAS_O17_ENCODING ret = null;
				try
				{
					ret = (RAS_O17_ENCODING) this.get_Renamed("ENCODING");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RAS_O17_ADMINISTRATION </summary>
		virtual public int ADMINISTRATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ADMINISTRATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CTI </summary>
		virtual public int CTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RAS_O17_ORDER Group.</summary>
		public RAS_O17_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RAS_O17_TIMING), false, true);
				this.add(typeof(RAS_O17_ORDER_DETAIL), false, false);
				this.add(typeof(RAS_O17_ENCODING), false, false);
				this.add(typeof(RAS_O17_ADMINISTRATION), true, true);
				this.add(typeof(CTI), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RAS_O17_TIMING (a Group object) - creates it if necessary</summary>
		public virtual RAS_O17_TIMING getTIMING()
		{
			RAS_O17_TIMING ret = null;
			try
			{
				ret = (RAS_O17_TIMING) this.get_Renamed("TIMING");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RAS_O17_TIMING
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RAS_O17_TIMING getTIMING(int rep)
		{
			return (RAS_O17_TIMING) this.get_Renamed("TIMING", rep);
		}
		
		/// <summary> Returns  first repetition of RAS_O17_ADMINISTRATION (a Group object) - creates it if necessary</summary>
		public virtual RAS_O17_ADMINISTRATION getADMINISTRATION()
		{
			RAS_O17_ADMINISTRATION ret = null;
			try
			{
				ret = (RAS_O17_ADMINISTRATION) this.get_Renamed("ADMINISTRATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RAS_O17_ADMINISTRATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RAS_O17_ADMINISTRATION getADMINISTRATION(int rep)
		{
			return (RAS_O17_ADMINISTRATION) this.get_Renamed("ADMINISTRATION", rep);
		}
		
		/// <summary> Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary</summary>
		public virtual CTI getCTI()
		{
			CTI ret = null;
			try
			{
				ret = (CTI) this.get_Renamed("CTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CTI
		/// (Clinical Trial Identification) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CTI getCTI(int rep)
		{
			return (CTI) this.get_Renamed("CTI", rep);
		}
	}
}