using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a OMD_O01 message structure (see chapter 4.6). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 (a Group object) <b>optional </b><br>
	/// 3: OMD_O01_ORCODSNTEOBXNTE (a Group object) <b>repeating</b><br>
	/// 4: OMD_O01_ORCODTNTE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OMD_O01:AbstractMessage
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
		/// <summary> Returns OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 (a Group object) - creates it if necessary</summary>
		virtual public OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1
		{
			get
			{
				OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1 ret = null;
				try
				{
					ret = (OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1) this.get_Renamed("PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OMD_O01_ORCODSNTEOBXNTE </summary>
		virtual public int ORCODSNTEOBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCODSNTEOBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OMD_O01_ORCODTNTE </summary>
		virtual public int ORCODTNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORCODTNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OMD_O01 Group with custom ModelClassFactory.</summary>
		public OMD_O01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new OMD_O01 Group with DefaultModelClassFactory. </summary>
		public OMD_O01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OMD_O01_PIDPD1NTEPV1PV2IN1IN2IN3GT1AL1), false, false);
				this.add(typeof(OMD_O01_ORCODSNTEOBXNTE), true, true);
				this.add(typeof(OMD_O01_ORCODTNTE), false, true);
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
		
		/// <summary> Returns  first repetition of OMD_O01_ORCODSNTEOBXNTE (a Group object) - creates it if necessary</summary>
		public virtual OMD_O01_ORCODSNTEOBXNTE getORCODSNTEOBXNTE()
		{
			OMD_O01_ORCODSNTEOBXNTE ret = null;
			try
			{
				ret = (OMD_O01_ORCODSNTEOBXNTE) this.get_Renamed("ORCODSNTEOBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O01_ORCODSNTEOBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O01_ORCODSNTEOBXNTE getORCODSNTEOBXNTE(int rep)
		{
			return (OMD_O01_ORCODSNTEOBXNTE) this.get_Renamed("ORCODSNTEOBXNTE", rep);
		}
		
		/// <summary> Returns  first repetition of OMD_O01_ORCODTNTE (a Group object) - creates it if necessary</summary>
		public virtual OMD_O01_ORCODTNTE getORCODTNTE()
		{
			OMD_O01_ORCODTNTE ret = null;
			try
			{
				ret = (OMD_O01_ORCODTNTE) this.get_Renamed("ORCODTNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O01_ORCODTNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O01_ORCODTNTE getORCODTNTE(int rep)
		{
			return (OMD_O01_ORCODTNTE) this.get_Renamed("ORCODTNTE", rep);
		}
	}
}