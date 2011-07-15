using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the NMQ_N01_NCKNSTNSC Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NCK (System Clock) <b>optional </b><br>
	/// 1: NST (Application control level statistics) <b>optional </b><br>
	/// 2: NSC (Application status change) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class NMQ_N01_NCKNSTNSC:AbstractGroup
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
		/// <summary> Returns NST (Application control level statistics) - creates it if necessary</summary>
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
		/// <summary> Returns NSC (Application status change) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new NMQ_N01_NCKNSTNSC Group.</summary>
		public NMQ_N01_NCKNSTNSC(Group parent, ModelClassFactory factory):base(parent, factory)
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