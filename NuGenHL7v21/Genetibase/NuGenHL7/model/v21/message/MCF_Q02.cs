using System;
using Genetibase.NuGenHL7.model.v21.group;
using Genetibase.NuGenHL7.model.v21.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v21.message
{
	
	/// <summary> <p>Represents a MCF_Q02 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MESSAGE HEADER) <b></b><br>
	/// 1: MSA (MESSAGE ACKNOWLEDGMENT) <b></b><br>
	/// </summary>
	[Serializable]
	public class MCF_Q02:AbstractMessage
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
		/// <summary> Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new MCF_Q02 Group with custom ModelClassFactory.</summary>
		public MCF_Q02(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new MCF_Q02 Group with DefaultModelClassFactory. </summary>
		public MCF_Q02():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}