using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RQA_I08_GT1IN1IN2IN3 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: GT1 (GT1 - guarantor segment) <b>optional repeating</b><br>
	/// 1: RQA_I08_IN1IN2IN3 (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RQA_I08_GT1IN1IN2IN3:AbstractGroup
	{
		/// <summary> Returns the number of existing repetitions of GT1 </summary>
		virtual public int GT1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GT1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RQA_I08_IN1IN2IN3 </summary>
		virtual public int IN1IN2IN3Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("IN1IN2IN3").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RQA_I08_GT1IN1IN2IN3 Group.</summary>
		public RQA_I08_GT1IN1IN2IN3(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(GT1), false, true);
				this.add(typeof(RQA_I08_IN1IN2IN3), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of GT1 (GT1 - guarantor segment) - creates it if necessary</summary>
		public virtual GT1 getGT1()
		{
			GT1 ret = null;
			try
			{
				ret = (GT1) this.get_Renamed("GT1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of GT1
		/// (GT1 - guarantor segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual GT1 getGT1(int rep)
		{
			return (GT1) this.get_Renamed("GT1", rep);
		}
		
		/// <summary> Returns  first repetition of RQA_I08_IN1IN2IN3 (a Group object) - creates it if necessary</summary>
		public virtual RQA_I08_IN1IN2IN3 getIN1IN2IN3()
		{
			RQA_I08_IN1IN2IN3 ret = null;
			try
			{
				ret = (RQA_I08_IN1IN2IN3) this.get_Renamed("IN1IN2IN3");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RQA_I08_IN1IN2IN3
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RQA_I08_IN1IN2IN3 getIN1IN2IN3(int rep)
		{
			return (RQA_I08_IN1IN2IN3) this.get_Renamed("IN1IN2IN3", rep);
		}
	}
}