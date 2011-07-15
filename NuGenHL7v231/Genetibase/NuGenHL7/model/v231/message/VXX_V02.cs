using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a VXX_V02 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: MSA (MSA - message acknowledgment segment) <b></b><br>
	/// 2: QRD (QRD - original-style query definition segment) <b></b><br>
	/// 3: QRF (QRF - original style query filter segment) <b>optional </b><br>
	/// 4: VXX_V02_PIDNK1 (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class VXX_V02:AbstractMessage
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
		/// <summary> Returns QRF (QRF - original style query filter segment) - creates it if necessary</summary>
		virtual public QRF QRF
		{
			get
			{
				QRF ret = null;
				try
				{
					ret = (QRF) this.get_Renamed("QRF");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of VXX_V02_PIDNK1 </summary>
		virtual public int PIDNK1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PIDNK1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new VXX_V02 Group with custom ModelClassFactory.</summary>
		public VXX_V02(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new VXX_V02 Group with DefaultModelClassFactory. </summary>
		public VXX_V02():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(VXX_V02_PIDNK1), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of VXX_V02_PIDNK1 (a Group object) - creates it if necessary</summary>
		public virtual VXX_V02_PIDNK1 getPIDNK1()
		{
			VXX_V02_PIDNK1 ret = null;
			try
			{
				ret = (VXX_V02_PIDNK1) this.get_Renamed("PIDNK1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of VXX_V02_PIDNK1
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual VXX_V02_PIDNK1 getPIDNK1(int rep)
		{
			return (VXX_V02_PIDNK1) this.get_Renamed("PIDNK1", rep);
		}
	}
}