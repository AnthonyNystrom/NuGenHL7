using System;
using Genetibase.NuGenHL7.model.v21.group;
using Genetibase.NuGenHL7.model.v21.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v21.message
{
	
	/// <summary> <p>Represents a ADT_A20 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MESSAGE HEADER) <b></b><br>
	/// 1: EVN (EVENT TYPE) <b></b><br>
	/// 2: NPU (NON-PATIENT UPDATE) <b></b><br>
	/// </summary>
	[Serializable]
	public class ADT_A20:AbstractMessage
	{
		/// <summary> Returns MSH (MESSAGE HEADER) - creates it if necessary</summary>
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
		/// <summary> Returns EVN (EVENT TYPE) - creates it if necessary</summary>
		virtual public EVN EVN
		{
			get
			{
				EVN ret = null;
				try
				{
					ret = (EVN) this.get_Renamed("EVN");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NPU (NON-PATIENT UPDATE) - creates it if necessary</summary>
		virtual public NPU NPU
		{
			get
			{
				NPU ret = null;
				try
				{
					ret = (NPU) this.get_Renamed("NPU");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new ADT_A20 Group with custom ModelClassFactory.</summary>
		public ADT_A20(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A20 Group with DefaultModelClassFactory. </summary>
		public ADT_A20():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(NPU), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}