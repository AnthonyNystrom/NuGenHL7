using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a SUR_P09 message structure (see chapter 7). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SUR_P09_FACILITY (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class SUR_P09:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of SUR_P09_FACILITY </summary>
		virtual public int FACILITYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("FACILITY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new SUR_P09 Group with custom ModelClassFactory.</summary>
		public SUR_P09(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new SUR_P09 Group with DefaultModelClassFactory. </summary>
		public SUR_P09():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SUR_P09_FACILITY), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of SUR_P09_FACILITY (a Group object) - creates it if necessary</summary>
		public virtual SUR_P09_FACILITY getFACILITY()
		{
			SUR_P09_FACILITY ret = null;
			try
			{
				ret = (SUR_P09_FACILITY) this.get_Renamed("FACILITY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of SUR_P09_FACILITY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual SUR_P09_FACILITY getFACILITY(int rep)
		{
			return (SUR_P09_FACILITY) this.get_Renamed("FACILITY", rep);
		}
	}
}