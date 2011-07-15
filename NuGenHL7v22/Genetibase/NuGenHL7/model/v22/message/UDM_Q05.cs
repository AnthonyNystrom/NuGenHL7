using System;
using Genetibase.NuGenHL7.model.v22.group;
using Genetibase.NuGenHL7.model.v22.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v22.message
{
	
	/// <summary> <p>Represents a UDM_Q05 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MESSAGE HEADER) <b></b><br>
	/// 1: URD (RESULTS/UPDATE DEFINITION) <b></b><br>
	/// 2: URS (UNSOLICITED SELECTION) <b>optional </b><br>
	/// 3: DSP (DISPLAY DATA) <b>repeating</b><br>
	/// 4: DSC (CONTINUATION POINTER) <b></b><br>
	/// </summary>
	[Serializable]
	public class UDM_Q05:AbstractMessage
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
		/// <summary> Returns URD (RESULTS/UPDATE DEFINITION) - creates it if necessary</summary>
		virtual public URD URD
		{
			get
			{
				URD ret = null;
				try
				{
					ret = (URD) this.get_Renamed("URD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns URS (UNSOLICITED SELECTION) - creates it if necessary</summary>
		virtual public URS URS
		{
			get
			{
				URS ret = null;
				try
				{
					ret = (URS) this.get_Renamed("URS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DSP </summary>
		virtual public int DSPReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DSP").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns DSC (CONTINUATION POINTER) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new UDM_Q05 Group with custom ModelClassFactory.</summary>
		public UDM_Q05(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new UDM_Q05 Group with DefaultModelClassFactory. </summary>
		public UDM_Q05():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(URD), true, false);
				this.add(typeof(URS), false, false);
				this.add(typeof(DSP), true, true);
				this.add(typeof(DSC), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of DSP (DISPLAY DATA) - creates it if necessary</summary>
		public virtual DSP getDSP()
		{
			DSP ret = null;
			try
			{
				ret = (DSP) this.get_Renamed("DSP");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DSP
		/// (DISPLAY DATA) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DSP getDSP(int rep)
		{
			return (DSP) this.get_Renamed("DSP", rep);
		}
	}
}