using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a QBP_Q13 message structure (see chapter 5). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: QPD (Query Parameter Definition) <b></b><br>
	/// 2: QBP_Q13_QBP (a Group object) <b>optional </b><br>
	/// 3: RDF (Table Row Definition) <b>optional </b><br>
	/// 4: RCP (Response Control Parameter) <b></b><br>
	/// 5: DSC (Continuation Pointer) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class QBP_Q13:AbstractMessage
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
		/// <summary> Returns QBP_Q13_QBP (a Group object) - creates it if necessary</summary>
		virtual public QBP_Q13_QBP QBP
		{
			get
			{
				QBP_Q13_QBP ret = null;
				try
				{
					ret = (QBP_Q13_QBP) this.get_Renamed("QBP");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RDF (Table Row Definition) - creates it if necessary</summary>
		virtual public RDF RDF
		{
			get
			{
				RDF ret = null;
				try
				{
					ret = (RDF) this.get_Renamed("RDF");
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
		
		/// <summary> Creates a new QBP_Q13 Group with custom ModelClassFactory.</summary>
		public QBP_Q13(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new QBP_Q13 Group with DefaultModelClassFactory. </summary>
		public QBP_Q13():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(QPD), true, false);
				this.add(typeof(QBP_Q13_QBP), false, false);
				this.add(typeof(RDF), false, false);
				this.add(typeof(RCP), true, false);
				this.add(typeof(DSC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}