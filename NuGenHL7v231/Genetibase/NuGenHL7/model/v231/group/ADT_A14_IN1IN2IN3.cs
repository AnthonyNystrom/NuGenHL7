using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the ADT_A14_IN1IN2IN3 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: IN1 (IN1 - insurance segment) <b></b><br>
	/// 1: IN2 (IN2 - insurance additional information segment) <b>optional </b><br>
	/// 2: IN3 (IN3 - insurance additional information, certification segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ADT_A14_IN1IN2IN3:AbstractGroup
	{
		/// <summary> Returns IN1 (IN1 - insurance segment) - creates it if necessary</summary>
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
		/// <summary> Returns IN2 (IN2 - insurance additional information segment) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new ADT_A14_IN1IN2IN3 Group.</summary>
		public ADT_A14_IN1IN2IN3(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(IN1), true, false);
				this.add(typeof(IN2), false, false);
				this.add(typeof(IN3), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of IN3 (IN3 - insurance additional information, certification segment) - creates it if necessary</summary>
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
		/// (IN3 - insurance additional information, certification segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual IN3 getIN3(int rep)
		{
			return (IN3) this.get_Renamed("IN3", rep);
		}
	}
}