using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a OMS_O01 message structure (see chapter 4.7). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: OMS_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 (a Group object) <b>optional </b><br>
	/// 3: OMS_O01_ORCRQDNTEOBXNTEBLG (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class OMS_O01:AbstractMessage
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
		/// <summary> Returns OMS_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 (a Group object) - creates it if necessary</summary>
		virtual public OMS_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1
		{
			get
			{
				OMS_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 ret = null;
				try
				{
					ret = (OMS_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1) this.get_Renamed("PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OMS_O01_ORCRQDNTEOBXNTEBLG </summary>
		virtual public int ORCRQDNTEOBXNTEBLGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRQDNTEOBXNTEBLG").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OMS_O01 Group with custom ModelClassFactory.</summary>
		public OMS_O01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new OMS_O01 Group with DefaultModelClassFactory. </summary>
		public OMS_O01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OMS_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1), false, false);
				this.add(typeof(OMS_O01_ORCRQDNTEOBXNTEBLG), true, true);
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
		
		/// <summary> Returns  first repetition of OMS_O01_ORCRQDNTEOBXNTEBLG (a Group object) - creates it if necessary</summary>
		public virtual OMS_O01_ORCRQDNTEOBXNTEBLG getORCRQDNTEOBXNTEBLG()
		{
			OMS_O01_ORCRQDNTEOBXNTEBLG ret = null;
			try
			{
				ret = (OMS_O01_ORCRQDNTEOBXNTEBLG) this.get_Renamed("ORCRQDNTEOBXNTEBLG");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMS_O01_ORCRQDNTEOBXNTEBLG
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMS_O01_ORCRQDNTEOBXNTEBLG getORCRQDNTEOBXNTEBLG(int rep)
		{
			return (OMS_O01_ORCRQDNTEOBXNTEBLG) this.get_Renamed("ORCRQDNTEOBXNTEBLG", rep);
		}
	}
}