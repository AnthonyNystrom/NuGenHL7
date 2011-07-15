using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ADT_A06_INSURANCE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: IN1 (Insurance) <b></b><br>
	/// 1: IN2 (Insurance Additional Information) <b>optional </b><br>
	/// 2: IN3 (Insurance Additional Information, Certification) <b>optional repeating</b><br>
	/// 3: ROL (Role) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ADT_A06_INSURANCE:AbstractGroup
	{
		/// <summary> Returns IN1 (Insurance) - creates it if necessary</summary>
		virtual public IN1 IN1
		{
			get
			{
				IN1 ret = null;
				try
				{
					ret = (IN1) this.get_Renamed("IN1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns IN2 (Insurance Additional Information) - creates it if necessary</summary>
		virtual public IN2 IN2
		{
			get
			{
				IN2 ret = null;
				try
				{
					ret = (IN2) this.get_Renamed("IN2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of IN3 </summary>
		virtual public int IN3Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("IN3").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ROL </summary>
		virtual public int ROLReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ROL").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ADT_A06_INSURANCE Group.</summary>
		public ADT_A06_INSURANCE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(IN1), true, false);
				this.add(typeof(IN2), false, false);
				this.add(typeof(IN3), false, true);
				this.add(typeof(ROL), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of IN3 (Insurance Additional Information, Certification) - creates it if necessary</summary>
		public virtual IN3 getIN3()
		{
			IN3 ret = null;
			try
			{
				ret = (IN3) this.get_Renamed("IN3");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of IN3
		/// (Insurance Additional Information, Certification) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual IN3 getIN3(int rep)
		{
			return (IN3) this.get_Renamed("IN3", rep);
		}
		
		/// <summary> Returns  first repetition of ROL (Role) - creates it if necessary</summary>
		public virtual ROL getROL()
		{
			ROL ret = null;
			try
			{
				ret = (ROL) this.get_Renamed("ROL");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ROL
		/// (Role) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ROL getROL(int rep)
		{
			return (ROL) this.get_Renamed("ROL", rep);
		}
	}
}