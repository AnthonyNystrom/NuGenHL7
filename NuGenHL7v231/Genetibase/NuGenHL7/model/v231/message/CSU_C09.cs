using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a CSU_C09 message structure (see chapter null). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class CSU_C09:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR </summary>
		virtual public int PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new CSU_C09 Group with custom ModelClassFactory.</summary>
		public CSU_C09(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new CSU_C09 Group with DefaultModelClassFactory. </summary>
		public CSU_C09():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR (a Group object) - creates it if necessary</summary>
		public virtual CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR getPIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR()
		{
			CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR ret = null;
			try
			{
				ret = (CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR) this.get_Renamed("PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR getPIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR(int rep)
		{
			return (CSU_C09_PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR) this.get_Renamed("PIDPD1NTEPV1PV2CSRCSPCSSORCOBROBXORCRXARXR", rep);
		}
	}
}