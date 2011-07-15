using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a NMR_N01 message structure (see chapter 14). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: MSA (MSA - message acknowledgment segment) <b></b><br>
	/// 2: ERR (ERR - error segment) <b>optional repeating</b><br>
	/// 3: QRD (QRD - original-style query definition segment) <b>optional </b><br>
	/// 4: NMR_N01_NCKNTENSTNTENSCNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class NMR_N01:AbstractMessage
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
		/// <summary> Returns MSA (MSA - message acknowledgment segment) - creates it if necessary</summary>
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
		/// <summary> Returns the number of existing repetitions of ERR </summary>
		virtual public int ERRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ERR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns QRD (QRD - original-style query definition segment) - creates it if necessary</summary>
		virtual public QRD QRD
		{
			get
			{
				QRD ret = null;
				try
				{
					ret = (QRD) this.get_Renamed("QRD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NMR_N01_NCKNTENSTNTENSCNTE </summary>
		virtual public int NCKNTENSTNTENSCNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NCKNTENSTNTENSCNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new NMR_N01 Group with custom ModelClassFactory.</summary>
		public NMR_N01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new NMR_N01 Group with DefaultModelClassFactory. </summary>
		public NMR_N01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(ERR), false, true);
				this.add(typeof(QRD), false, false);
				this.add(typeof(NMR_N01_NCKNTENSTNTENSCNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ERR (ERR - error segment) - creates it if necessary</summary>
		public virtual ERR getERR()
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
		
		/// <summary> Returns a specific repetition of ERR
		/// (ERR - error segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ERR getERR(int rep)
		{
			return (ERR) this.get_Renamed("ERR", rep);
		}
		
		/// <summary> Returns  first repetition of NMR_N01_NCKNTENSTNTENSCNTE (a Group object) - creates it if necessary</summary>
		public virtual NMR_N01_NCKNTENSTNTENSCNTE getNCKNTENSTNTENSCNTE()
		{
			NMR_N01_NCKNTENSTNTENSCNTE ret = null;
			try
			{
				ret = (NMR_N01_NCKNTENSTNTENSCNTE) this.get_Renamed("NCKNTENSTNTENSCNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NMR_N01_NCKNTENSTNTENSCNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NMR_N01_NCKNTENSTNTENSCNTE getNCKNTENSTNTENSCNTE(int rep)
		{
			return (NMR_N01_NCKNTENSTNTENSCNTE) this.get_Renamed("NCKNTENSTNTENSCNTE", rep);
		}
	}
}