using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a QVR_Q17 message structure (see chapter 5). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: QPD (Query Parameter Definition) <b></b><br>
	/// 2: Zxx (any Z segment) <b>optional </b><br>
	/// 3: RCP (Response Control Parameter) <b></b><br>
	/// 4: DSC (Continuation Pointer) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class QVR_Q17:AbstractMessage
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
		/// <summary> Returns Zxx (any Z segment) - creates it if necessary</summary>
		virtual public Zxx Zxx
		{
			get
			{
				Zxx ret = null;
				try
				{
					ret = (Zxx) this.get_Renamed("Zxx");
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
		
		/// <summary> Creates a new QVR_Q17 Group with custom ModelClassFactory.</summary>
		public QVR_Q17(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new QVR_Q17 Group with DefaultModelClassFactory. </summary>
		public QVR_Q17():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(QPD), true, false);
				this.add(typeof(Zxx), false, false);
				this.add(typeof(RCP), true, false);
				this.add(typeof(DSC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}