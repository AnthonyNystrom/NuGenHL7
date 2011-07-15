using System;
using Genetibase.NuGenHL7.model.v21.group;
using Genetibase.NuGenHL7.model.v21.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v21.message
{
	
	/// <summary> <p>Represents a ADT_A17 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MESSAGE HEADER) <b></b><br>
	/// 1: EVN (EVENT TYPE) <b></b><br>
	/// 2: ADT_A17_PATIENT (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ADT_A17:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of ADT_A17_PATIENT </summary>
		virtual public int PATIENTReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PATIENT").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ADT_A17 Group with custom ModelClassFactory.</summary>
		public ADT_A17(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A17 Group with DefaultModelClassFactory. </summary>
		public ADT_A17():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(ADT_A17_PATIENT), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ADT_A17_PATIENT (a Group object) - creates it if necessary</summary>
		public virtual ADT_A17_PATIENT getPATIENT()
		{
			ADT_A17_PATIENT ret = null;
			try
			{
				ret = (ADT_A17_PATIENT) this.get_Renamed("PATIENT");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ADT_A17_PATIENT
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ADT_A17_PATIENT getPATIENT(int rep)
		{
			return (ADT_A17_PATIENT) this.get_Renamed("PATIENT", rep);
		}
	}
}