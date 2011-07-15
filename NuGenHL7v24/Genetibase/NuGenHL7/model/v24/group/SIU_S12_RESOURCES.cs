using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v24.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v24.group
{
	/// <summary> <p>Represents the SIU_S12_RESOURCES Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RGS (Resource Group) <b></b><br>
	/// 1: SIU_S12_SERVICE (a Group object) <b>optional repeating</b><br>
	/// 2: SIU_S12_GENERAL_RESOURCE (a Group object) <b>optional repeating</b><br>
	/// 3: SIU_S12_LOCATION_RESOURCE (a Group object) <b>optional repeating</b><br>
	/// 4: SIU_S12_PERSONNEL_RESOURCE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class SIU_S12_RESOURCES:AbstractGroup
	{
		/// <summary> Returns RGS (Resource Group) - creates it if necessary</summary>
		virtual public RGS RGS
		{
			get
			{
				RGS ret = null;
				try
				{
					ret = (RGS) this.get_Renamed("RGS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SIU_S12_SERVICE </summary>
		virtual public int SERVICEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SERVICE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SIU_S12_GENERAL_RESOURCE </summary>
		virtual public int GENERAL_RESOURCEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("GENERAL_RESOURCE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SIU_S12_LOCATION_RESOURCE </summary>
		virtual public int LOCATION_RESOURCEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("LOCATION_RESOURCE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SIU_S12_PERSONNEL_RESOURCE </summary>
		virtual public int PERSONNEL_RESOURCEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PERSONNEL_RESOURCE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SIU_S12_RESOURCES Group.</summary>
		public SIU_S12_RESOURCES(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RGS), true, false);
				this.add(typeof(SIU_S12_SERVICE), false, true);
				this.add(typeof(SIU_S12_GENERAL_RESOURCE), false, true);
				this.add(typeof(SIU_S12_LOCATION_RESOURCE), false, true);
				this.add(typeof(SIU_S12_PERSONNEL_RESOURCE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SIU_S12_SERVICE (a Group object) - creates it if necessary</summary>
		public virtual SIU_S12_SERVICE getSERVICE()
		{
			SIU_S12_SERVICE ret = null;
			try
			{
				ret = (SIU_S12_SERVICE) this.get_Renamed("SERVICE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SIU_S12_SERVICE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SIU_S12_SERVICE getSERVICE(int rep)
		{
			return (SIU_S12_SERVICE) this.get_Renamed("SERVICE", rep);
		}
		
		/// <summary> Returns  first repetition of SIU_S12_GENERAL_RESOURCE (a Group object) - creates it if necessary</summary>
		public virtual SIU_S12_GENERAL_RESOURCE getGENERAL_RESOURCE()
		{
			SIU_S12_GENERAL_RESOURCE ret = null;
			try
			{
				ret = (SIU_S12_GENERAL_RESOURCE) this.get_Renamed("GENERAL_RESOURCE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SIU_S12_GENERAL_RESOURCE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SIU_S12_GENERAL_RESOURCE getGENERAL_RESOURCE(int rep)
		{
			return (SIU_S12_GENERAL_RESOURCE) this.get_Renamed("GENERAL_RESOURCE", rep);
		}
		
		/// <summary> Returns  first repetition of SIU_S12_LOCATION_RESOURCE (a Group object) - creates it if necessary</summary>
		public virtual SIU_S12_LOCATION_RESOURCE getLOCATION_RESOURCE()
		{
			SIU_S12_LOCATION_RESOURCE ret = null;
			try
			{
				ret = (SIU_S12_LOCATION_RESOURCE) this.get_Renamed("LOCATION_RESOURCE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SIU_S12_LOCATION_RESOURCE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SIU_S12_LOCATION_RESOURCE getLOCATION_RESOURCE(int rep)
		{
			return (SIU_S12_LOCATION_RESOURCE) this.get_Renamed("LOCATION_RESOURCE", rep);
		}
		
		/// <summary> Returns  first repetition of SIU_S12_PERSONNEL_RESOURCE (a Group object) - creates it if necessary</summary>
		public virtual SIU_S12_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE()
		{
			SIU_S12_PERSONNEL_RESOURCE ret = null;
			try
			{
				ret = (SIU_S12_PERSONNEL_RESOURCE) this.get_Renamed("PERSONNEL_RESOURCE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SIU_S12_PERSONNEL_RESOURCE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SIU_S12_PERSONNEL_RESOURCE getPERSONNEL_RESOURCE(int rep)
		{
			return (SIU_S12_PERSONNEL_RESOURCE) this.get_Renamed("PERSONNEL_RESOURCE", rep);
		}
	}
}