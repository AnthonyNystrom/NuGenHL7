using System;
using Genetibase.NuGenHL7.model.v25.group;
using Genetibase.NuGenHL7.model.v25.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v25.message
{
	
	/// <summary> <p>Represents a PMU_B04 message structure (see chapter 15.3.4). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SFT (Software Segment) <b>optional repeating</b><br>
	/// 2: EVN (Event Type) <b></b><br>
	/// 3: STF (Staff Identification) <b></b><br>
	/// 4: PRA (Practitioner Detail) <b>optional repeating</b><br>
	/// 5: ORG (Practitioner Organization Unit) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PMU_B04:AbstractMessage
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
		/// <summary> Returns EVN (Event Type) - creates it if necessary</summary>
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
		/// <summary> Returns STF (Staff Identification) - creates it if necessary</summary>
		virtual public STF STF
		{
			get
			{
				STF ret = null;
				try
				{
					ret = (STF) this.get_Renamed("STF");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRA </summary>
		virtual public int PRAReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRA").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORG </summary>
		virtual public int ORGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORG").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PMU_B04 Group with custom ModelClassFactory.</summary>
		public PMU_B04(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new PMU_B04 Group with DefaultModelClassFactory. </summary>
		public PMU_B04():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SFT), false, true);
				this.add(typeof(EVN), true, false);
				this.add(typeof(STF), true, false);
				this.add(typeof(PRA), false, true);
				this.add(typeof(ORG), false, true);
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
		
		/// <summary> Returns  first repetition of PRA (Practitioner Detail) - creates it if necessary</summary>
		public virtual PRA getPRA()
		{
			PRA ret = null;
			try
			{
				ret = (PRA) this.get_Renamed("PRA");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRA
		/// (Practitioner Detail) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRA getPRA(int rep)
		{
			return (PRA) this.get_Renamed("PRA", rep);
		}
		
		/// <summary> Returns  first repetition of ORG (Practitioner Organization Unit) - creates it if necessary</summary>
		public virtual ORG getORG()
		{
			ORG ret = null;
			try
			{
				ret = (ORG) this.get_Renamed("ORG");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORG
		/// (Practitioner Organization Unit) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORG getORG(int rep)
		{
			return (ORG) this.get_Renamed("ORG", rep);
		}
	}
}