using System;
using Genetibase.NuGenHL7.model.v25.group;
using Genetibase.NuGenHL7.model.v25.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v25.message
{
	
	/// <summary> <p>Represents a NMD_N02 message structure (see chapter 14.3.2). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SFT (Software Segment) <b>optional repeating</b><br>
	/// 2: NMD_N02_CLOCK_AND_STATS_WITH_NOTES (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class NMD_N02:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of NMD_N02_CLOCK_AND_STATS_WITH_NOTES </summary>
		virtual public int CLOCK_AND_STATS_WITH_NOTESReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CLOCK_AND_STATS_WITH_NOTES").Length;
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
				this.add(typeof(SFT), false, true);
				this.add(typeof(NMD_N02_CLOCK_AND_STATS_WITH_NOTES), true, true);
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
		
		/// <summary> Returns  first repetition of NMD_N02_CLOCK_AND_STATS_WITH_NOTES (a Group object) - creates it if necessary</summary>
		public virtual NMD_N02_CLOCK_AND_STATS_WITH_NOTES getCLOCK_AND_STATS_WITH_NOTES()
		{
			NMD_N02_CLOCK_AND_STATS_WITH_NOTES ret = null;
			try
			{
				ret = (NMD_N02_CLOCK_AND_STATS_WITH_NOTES) this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NMD_N02_CLOCK_AND_STATS_WITH_NOTES
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NMD_N02_CLOCK_AND_STATS_WITH_NOTES getCLOCK_AND_STATS_WITH_NOTES(int rep)
		{
			return (NMD_N02_CLOCK_AND_STATS_WITH_NOTES) this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES", rep);
		}
	}
}