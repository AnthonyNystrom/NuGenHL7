using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a NMQ_N01 message structure (see chapter 14). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: NMQ_N01_QRY_WITH_DETAIL (a Group object) <b>optional </b><br>
	/// 2: NMQ_N01_CLOCK_AND_STATISTICS (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class NMQ_N01:AbstractMessage
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
		/// <summary> Returns NMQ_N01_QRY_WITH_DETAIL (a Group object) - creates it if necessary</summary>
		virtual public NMQ_N01_QRY_WITH_DETAIL QRY_WITH_DETAIL
		{
			get
			{
				NMQ_N01_QRY_WITH_DETAIL ret = null;
				try
				{
					ret = (NMQ_N01_QRY_WITH_DETAIL) this.get_Renamed("QRY_WITH_DETAIL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NMQ_N01_CLOCK_AND_STATISTICS </summary>
		virtual public int CLOCK_AND_STATISTICSReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CLOCK_AND_STATISTICS").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new NMQ_N01 Group with custom ModelClassFactory.</summary>
		public NMQ_N01(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new NMQ_N01 Group with DefaultModelClassFactory. </summary>
		public NMQ_N01():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NMQ_N01_QRY_WITH_DETAIL), false, false);
				this.add(typeof(NMQ_N01_CLOCK_AND_STATISTICS), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NMQ_N01_CLOCK_AND_STATISTICS (a Group object) - creates it if necessary</summary>
		public virtual NMQ_N01_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS()
		{
			NMQ_N01_CLOCK_AND_STATISTICS ret = null;
			try
			{
				ret = (NMQ_N01_CLOCK_AND_STATISTICS) this.get_Renamed("CLOCK_AND_STATISTICS");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NMQ_N01_CLOCK_AND_STATISTICS
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NMQ_N01_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS(int rep)
		{
			return (NMQ_N01_CLOCK_AND_STATISTICS) this.get_Renamed("CLOCK_AND_STATISTICS", rep);
		}
	}
}