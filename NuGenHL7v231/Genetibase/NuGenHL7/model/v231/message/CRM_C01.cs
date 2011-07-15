using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a CRM_C01 message structure (see chapter null). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: CRM_C01_PIDPV1CSRCSP (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CRM_C01:AbstractMessage
	{
		/// <summary> Returns MSH (MSH - message header segment) - creates it if necessary</summary>
		virtual public MSH MSH
		{
			get
			{
				MSH ret = null;
				try
				{
					ret = (MSH) this.get_Renamed("MSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CRM_C01_PIDPV1CSRCSP </summary>
		virtual public int PIDPV1CSRCSPReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PIDPV1CSRCSP").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CRM_C01 Group with custom ModelClassFactory.</summary>
		public CRM_C01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new CRM_C01 Group with DefaultModelClassFactory. </summary>
		public CRM_C01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(CRM_C01_PIDPV1CSRCSP), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CRM_C01_PIDPV1CSRCSP (a Group object) - creates it if necessary</summary>
		public virtual CRM_C01_PIDPV1CSRCSP getPIDPV1CSRCSP()
		{
			CRM_C01_PIDPV1CSRCSP ret = null;
			try
			{
				ret = (CRM_C01_PIDPV1CSRCSP) this.get_Renamed("PIDPV1CSRCSP");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CRM_C01_PIDPV1CSRCSP
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CRM_C01_PIDPV1CSRCSP getPIDPV1CSRCSP(int rep)
		{
			return (CRM_C01_PIDPV1CSRCSP) this.get_Renamed("PIDPV1CSRCSP", rep);
		}
	}
}