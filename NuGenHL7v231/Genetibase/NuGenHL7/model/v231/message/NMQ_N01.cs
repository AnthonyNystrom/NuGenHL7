using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a NMQ_N01 message structure (see chapter 14). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: NMQ_N01_QRDQRF (a Group object) <b>optional </b><br>
	/// 2: NMQ_N01_NCKNSTNSC (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class NMQ_N01:AbstractMessage
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
		/// <summary> Returns NMQ_N01_QRDQRF (a Group object) - creates it if necessary</summary>
		virtual public NMQ_N01_QRDQRF QRDQRF
		{
			get
			{
				NMQ_N01_QRDQRF ret = null;
				try
				{
					ret = (NMQ_N01_QRDQRF) this.get_Renamed("QRDQRF");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NMQ_N01_NCKNSTNSC </summary>
		virtual public int NCKNSTNSCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NCKNSTNSC").Length;
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
				this.add(typeof(NMQ_N01_QRDQRF), false, false);
				this.add(typeof(NMQ_N01_NCKNSTNSC), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NMQ_N01_NCKNSTNSC (a Group object) - creates it if necessary</summary>
		public virtual NMQ_N01_NCKNSTNSC getNCKNSTNSC()
		{
			NMQ_N01_NCKNSTNSC ret = null;
			try
			{
				ret = (NMQ_N01_NCKNSTNSC) this.get_Renamed("NCKNSTNSC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NMQ_N01_NCKNSTNSC
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NMQ_N01_NCKNSTNSC getNCKNSTNSC(int rep)
		{
			return (NMQ_N01_NCKNSTNSC) this.get_Renamed("NCKNSTNSC", rep);
		}
	}
}