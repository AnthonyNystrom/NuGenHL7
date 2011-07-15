using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a RDE_O01 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: RDE_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 (a Group object) <b>optional </b><br>
	/// 3: RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RDE_O01:AbstractMessage
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
		/// <summary> Returns RDE_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 (a Group object) - creates it if necessary</summary>
		virtual public RDE_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1
		{
			get
			{
				RDE_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 ret = null;
				try
				{
					ret = (RDE_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1) this.get_Renamed("PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI </summary>
		virtual public int ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RDE_O01 Group with custom ModelClassFactory.</summary>
		public RDE_O01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new RDE_O01 Group with DefaultModelClassFactory. </summary>
		public RDE_O01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(RDE_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1), false, false);
				this.add(typeof(RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI), true, true);
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
		
		/// <summary> Returns  first repetition of RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI (a Group object) - creates it if necessary</summary>
		public virtual RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI getORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI()
		{
			RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI ret = null;
			try
			{
				ret = (RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI) this.get_Renamed("ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI getORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI(int rep)
		{
			return (RDE_O01_ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI) this.get_Renamed("ORCRXONTERXRRXCNTERXERXRRXCOBXNTECTI", rep);
		}
	}
}