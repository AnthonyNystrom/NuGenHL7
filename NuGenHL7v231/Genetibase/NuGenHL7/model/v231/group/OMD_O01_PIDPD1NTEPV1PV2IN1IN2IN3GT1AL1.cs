using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: PID (PID - patient identification segment) <b></b><br>
	/// 1: PD1 (PD1 - patient additional demographic segment) <b>optional </b><br>
	/// 2: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 3: OMD_O01_PV1PV2 (a Group object) <b>optional </b><br>
	/// 4: OMD_O01_IN1IN2IN3 (a Group object) <b>optional repeating</b><br>
	/// 5: GT1 (GT1 - guarantor segment) <b>optional </b><br>
	/// 6: AL1 (AL1 - patient allergy information segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1:AbstractGroup
	{
		/// <summary> Returns PID (PID - patient identification segment) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary</summary>
		virtual public PD1 PD1
		{
			get
			{
				PD1 ret = null;
				try
				{
					ret = (PD1) this.get_Renamed("PD1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns OMD_O01_PV1PV2 (a Group object) - creates it if necessary</summary>
		virtual public OMD_O01_PV1PV2 PV1PV2
		{
			get
			{
				OMD_O01_PV1PV2 ret = null;
				try
				{
					ret = (OMD_O01_PV1PV2) this.get_Renamed("PV1PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OMD_O01_IN1IN2IN3 </summary>
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
		/// <summary> Returns GT1 (GT1 - guarantor segment) - creates it if necessary</summary>
		virtual public GT1 GT1
		{
			get
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
			
		}
		/// <summary> Returns the number of existing repetitions of AL1 </summary>
		virtual public int AL1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AL1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 Group.</summary>
		public OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OMD_O01_PV1PV2), false, false);
				this.add(typeof(OMD_O01_IN1IN2IN3), false, true);
				this.add(typeof(GT1), false, false);
				this.add(typeof(AL1), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of OMD_O01_IN1IN2IN3 (a Group object) - creates it if necessary</summary>
		public virtual OMD_O01_IN1IN2IN3 getIN1IN2IN3()
		{
			OMD_O01_IN1IN2IN3 ret = null;
			try
			{
				ret = (OMD_O01_IN1IN2IN3) this.get_Renamed("IN1IN2IN3");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O01_IN1IN2IN3
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O01_IN1IN2IN3 getIN1IN2IN3(int rep)
		{
			return (OMD_O01_IN1IN2IN3) this.get_Renamed("IN1IN2IN3", rep);
		}
		
		/// <summary> Returns  first repetition of AL1 (AL1 - patient allergy information segment) - creates it if necessary</summary>
		public virtual AL1 getAL1()
		{
			AL1 ret = null;
			try
			{
				ret = (AL1) this.get_Renamed("AL1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of AL1
		/// (AL1 - patient allergy information segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual AL1 getAL1(int rep)
		{
			return (AL1) this.get_Renamed("AL1", rep);
		}
	}
}