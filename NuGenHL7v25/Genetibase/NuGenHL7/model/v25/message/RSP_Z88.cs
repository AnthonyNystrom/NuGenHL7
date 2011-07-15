using System;
using Genetibase.NuGenHL7.model.v25.group;
using Genetibase.NuGenHL7.model.v25.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v25.message
{
	
	/// <summary> <p>Represents a RSP_Z88 message structure (see chapter 5.9.2.1.1). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SFT (Software Segment) <b>optional repeating</b><br>
	/// 2: MSA (Message Acknowledgment) <b></b><br>
	/// 3: ERR (Error) <b>optional </b><br>
	/// 4: QAK (Query Acknowledgment) <b></b><br>
	/// 5: QPD (Query Parameter Definition) <b></b><br>
	/// 6: RCP (Response Control Parameter) <b></b><br>
	/// 7: RSP_Z88_QUERY_RESPONSE (a Group object) <b>repeating</b><br>
	/// 8: DSC (Continuation Pointer) <b></b><br>
	/// </summary>
	[Serializable]
	public class RSP_Z88:AbstractMessage
	{
		/// <summary> Returns MSH (Message Header) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of SFT </summary>
		virtual public int SFTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SFT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns MSA (Message Acknowledgment) - creates it if necessary</summary>
		virtual public MSA MSA
		{
			get
			{
				MSA ret = null;
				try
				{
					ret = (MSA) this.get_Renamed("MSA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ERR (Error) - creates it if necessary</summary>
		virtual public ERR ERR
		{
			get
			{
				ERR ret = null;
				try
				{
					ret = (ERR) this.get_Renamed("ERR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns QAK (Query Acknowledgment) - creates it if necessary</summary>
		virtual public QAK QAK
		{
			get
			{
				QAK ret = null;
				try
				{
					ret = (QAK) this.get_Renamed("QAK");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns QPD (Query Parameter Definition) - creates it if necessary</summary>
		virtual public QPD QPD
		{
			get
			{
				QPD ret = null;
				try
				{
					ret = (QPD) this.get_Renamed("QPD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RCP (Response Control Parameter) - creates it if necessary</summary>
		virtual public RCP RCP
		{
			get
			{
				RCP ret = null;
				try
				{
					ret = (RCP) this.get_Renamed("RCP");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RSP_Z88_QUERY_RESPONSE </summary>
		virtual public int QUERY_RESPONSEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("QUERY_RESPONSE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns DSC (Continuation Pointer) - creates it if necessary</summary>
		virtual public DSC DSC
		{
			get
			{
				DSC ret = null;
				try
				{
					ret = (DSC) this.get_Renamed("DSC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new RSP_Z88 Group with custom ModelClassFactory.</summary>
		public RSP_Z88(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new RSP_Z88 Group with DefaultModelClassFactory. </summary>
		public RSP_Z88():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SFT), false, true);
				this.add(typeof(MSA), true, false);
				this.add(typeof(ERR), false, false);
				this.add(typeof(QAK), true, false);
				this.add(typeof(QPD), true, false);
				this.add(typeof(RCP), true, false);
				this.add(typeof(RSP_Z88_QUERY_RESPONSE), true, true);
				this.add(typeof(DSC), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SFT (Software Segment) - creates it if necessary</summary>
		public virtual SFT getSFT()
		{
			SFT ret = null;
			try
			{
				ret = (SFT) this.get_Renamed("SFT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SFT
		/// (Software Segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SFT getSFT(int rep)
		{
			return (SFT) this.get_Renamed("SFT", rep);
		}
		
		/// <summary> Returns  first repetition of RSP_Z88_QUERY_RESPONSE (a Group object) - creates it if necessary</summary>
		public virtual RSP_Z88_QUERY_RESPONSE getQUERY_RESPONSE()
		{
			RSP_Z88_QUERY_RESPONSE ret = null;
			try
			{
				ret = (RSP_Z88_QUERY_RESPONSE) this.get_Renamed("QUERY_RESPONSE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RSP_Z88_QUERY_RESPONSE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RSP_Z88_QUERY_RESPONSE getQUERY_RESPONSE(int rep)
		{
			return (RSP_Z88_QUERY_RESPONSE) this.get_Renamed("QUERY_RESPONSE", rep);
		}
	}
}