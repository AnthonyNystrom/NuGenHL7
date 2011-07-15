using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a NMD_N02 message structure (see chapter 14). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: NMD_N02_NCKNTENSTNTENSCNTE (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class NMD_N02:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of NMD_N02_NCKNTENSTNTENSCNTE </summary>
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
		
		/// <summary> Creates a new NMD_N02 Group with custom ModelClassFactory.</summary>
		public NMD_N02(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new NMD_N02 Group with DefaultModelClassFactory. </summary>
		public NMD_N02():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NMD_N02_NCKNTENSTNTENSCNTE), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NMD_N02_NCKNTENSTNTENSCNTE (a Group object) - creates it if necessary</summary>
		public virtual NMD_N02_NCKNTENSTNTENSCNTE getNCKNTENSTNTENSCNTE()
		{
			NMD_N02_NCKNTENSTNTENSCNTE ret = null;
			try
			{
				ret = (NMD_N02_NCKNTENSTNTENSCNTE) this.get_Renamed("NCKNTENSTNTENSCNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NMD_N02_NCKNTENSTNTENSCNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NMD_N02_NCKNTENSTNTENSCNTE getNCKNTENSTNTENSCNTE(int rep)
		{
			return (NMD_N02_NCKNTENSTNTENSCNTE) this.get_Renamed("NCKNTENSTNTENSCNTE", rep);
		}
	}
}