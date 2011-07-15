using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a VQQ_Q07 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: VTQ (VTQ - virtual table query request segment) <b></b><br>
	/// 2: RDF (RDF - table row definition segment) <b>optional </b><br>
	/// 3: DSC (DSC - Continuation pointer segment) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class VQQ_Q07:AbstractMessage
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
		/// <summary> Returns VTQ (VTQ - virtual table query request segment) - creates it if necessary</summary>
		virtual public VTQ VTQ
		{
			get
			{
				VTQ ret = null;
				try
				{
					ret = (VTQ) this.get_Renamed("VTQ");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RDF (RDF - table row definition segment) - creates it if necessary</summary>
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
		/// <summary> Returns DSC (DSC - Continuation pointer segment) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new VQQ_Q07 Group with custom ModelClassFactory.</summary>
		public VQQ_Q07(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new VQQ_Q07 Group with DefaultModelClassFactory. </summary>
		public VQQ_Q07():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(VTQ), true, false);
				this.add(typeof(RDF), false, false);
				this.add(typeof(DSC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}