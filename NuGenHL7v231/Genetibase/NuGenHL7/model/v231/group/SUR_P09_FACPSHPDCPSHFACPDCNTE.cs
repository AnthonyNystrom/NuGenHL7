using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the SUR_P09_FACPSHPDCPSHFACPDCNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: FAC (FAC - facility segment) <b></b><br>
	/// 1: SUR_P09_PSHPDC (a Group object) <b>repeating</b><br>
	/// 2: PSH (PSH - product summary header segment) <b></b><br>
	/// 3: SUR_P09_FACPDCNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SUR_P09_FACPSHPDCPSHFACPDCNTE:AbstractGroup
	{
		/// <summary> Returns FAC (FAC - facility segment) - creates it if necessary</summary>
		virtual public FAC FAC
		{
			get
			{
				FAC ret = null;
				try
				{
					ret = (FAC) this.get_Renamed("FAC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SUR_P09_PSHPDC </summary>
		virtual public int PSHPDCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PSHPDC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns PSH (PSH - product summary header segment) - creates it if necessary</summary>
		virtual public PSH PSH
		{
			get
			{
				PSH ret = null;
				try
				{
					ret = (PSH) this.get_Renamed("PSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of SUR_P09_FACPDCNTE </summary>
		virtual public int FACPDCNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("FACPDCNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SUR_P09_FACPSHPDCPSHFACPDCNTE Group.</summary>
		public SUR_P09_FACPSHPDCPSHFACPDCNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(FAC), true, false);
				this.add(typeof(SUR_P09_PSHPDC), true, true);
				this.add(typeof(PSH), true, false);
				this.add(typeof(SUR_P09_FACPDCNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SUR_P09_PSHPDC (a Group object) - creates it if necessary</summary>
		public virtual SUR_P09_PSHPDC getPSHPDC()
		{
			SUR_P09_PSHPDC ret = null;
			try
			{
				ret = (SUR_P09_PSHPDC) this.get_Renamed("PSHPDC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SUR_P09_PSHPDC
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SUR_P09_PSHPDC getPSHPDC(int rep)
		{
			return (SUR_P09_PSHPDC) this.get_Renamed("PSHPDC", rep);
		}
		
		/// <summary> Returns  first repetition of SUR_P09_FACPDCNTE (a Group object) - creates it if necessary</summary>
		public virtual SUR_P09_FACPDCNTE getFACPDCNTE()
		{
			SUR_P09_FACPDCNTE ret = null;
			try
			{
				ret = (SUR_P09_FACPDCNTE) this.get_Renamed("FACPDCNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SUR_P09_FACPDCNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SUR_P09_FACPDCNTE getFACPDCNTE(int rep)
		{
			return (SUR_P09_FACPDCNTE) this.get_Renamed("FACPDCNTE", rep);
		}
	}
}