using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the NMQ_N02_CLOCK_AND_STATISTICS Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NCK (System Clock) <b>optional </b><br>
	/// 1: NST (Statistics) <b>optional </b><br>
	/// 2: NSC (STATUS CHANGE) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class NMQ_N02_CLOCK_AND_STATISTICS:AbstractGroup
	{
		/// <summary> Returns NCK (System Clock) - creates it if necessary</summary>
		virtual public NCK NCK
		{
			get
			{
				NCK ret = null;
				try
				{
					ret = (NCK) this.get_Renamed("NCK");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NST (Statistics) - creates it if necessary</summary>
		virtual public NST NST
		{
			get
			{
				NST ret = null;
				try
				{
					ret = (NST) this.get_Renamed("NST");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NSC (STATUS CHANGE) - creates it if necessary</summary>
		virtual public NSC NSC
		{
			get
			{
				NSC ret = null;
				try
				{
					ret = (NSC) this.get_Renamed("NSC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new NMQ_N02_CLOCK_AND_STATISTICS Group.</summary>
		public NMQ_N02_CLOCK_AND_STATISTICS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(NCK), false, false);
				this.add(typeof(NST), false, false);
				this.add(typeof(NSC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}