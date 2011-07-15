using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a RGV_O01 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: RGV_O01_PIDNTEAL1PV1PV2 (a Group object) <b>optional </b><br>
	/// 3: RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RGV_O01:AbstractMessage
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
		/// <summary> Returns RGV_O01_PIDNTEAL1PV1PV2 (a Group object) - creates it if necessary</summary>
		virtual public RGV_O01_PIDNTEAL1PV1PV2 PIDNTEAL1PV1PV2
		{
			get
			{
				RGV_O01_PIDNTEAL1PV1PV2 ret = null;
				try
				{
					ret = (RGV_O01_PIDNTEAL1PV1PV2) this.get_Renamed("PIDNTEAL1PV1PV2");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE </summary>
		virtual public int ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RGV_O01 Group with custom ModelClassFactory.</summary>
		public RGV_O01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new RGV_O01 Group with DefaultModelClassFactory. </summary>
		public RGV_O01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(RGV_O01_PIDNTEAL1PV1PV2), false, false);
				this.add(typeof(RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE), true, true);
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
		
		/// <summary> Returns  first repetition of RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE (a Group object) - creates it if necessary</summary>
		public virtual RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE getORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE()
		{
			RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE ret = null;
			try
			{
				ret = (RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE) this.get_Renamed("ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE getORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE(int rep)
		{
			return (RGV_O01_ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE) this.get_Renamed("ORCRXONTERXRRXCNTERXERXRRXCRXGRXRRXCOBXNTE", rep);
		}
	}
}