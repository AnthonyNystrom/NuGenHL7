using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the OMD_O01_ODSNTEOBXNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ODS (ODS - dietary orders, supplements, and preferences segment) <b>repeating</b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: OMD_O01_OBXNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OMD_O01_ODSNTEOBXNTE:AbstractGroup
	{
		/// <summary> Returns the number of existing repetitions of ODS </summary>
		virtual public int ODSReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ODS").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
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
		/// <summary> Returns the number of existing repetitions of OMD_O01_OBXNTE </summary>
		virtual public int OBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OMD_O01_ODSNTEOBXNTE Group.</summary>
		public OMD_O01_ODSNTEOBXNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ODS), true, true);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OMD_O01_OBXNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ODS (ODS - dietary orders, supplements, and preferences segment) - creates it if necessary</summary>
		public virtual ODS getODS()
		{
			ODS ret = null;
			try
			{
				ret = (ODS) this.get_Renamed("ODS");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ODS
		/// (ODS - dietary orders, supplements, and preferences segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ODS getODS(int rep)
		{
			return (ODS) this.get_Renamed("ODS", rep);
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
		
		/// <summary> Returns  first repetition of OMD_O01_OBXNTE (a Group object) - creates it if necessary</summary>
		public virtual OMD_O01_OBXNTE getOBXNTE()
		{
			OMD_O01_OBXNTE ret = null;
			try
			{
				ret = (OMD_O01_OBXNTE) this.get_Renamed("OBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O01_OBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O01_OBXNTE getOBXNTE(int rep)
		{
			return (OMD_O01_OBXNTE) this.get_Renamed("OBXNTE", rep);
		}
	}
}