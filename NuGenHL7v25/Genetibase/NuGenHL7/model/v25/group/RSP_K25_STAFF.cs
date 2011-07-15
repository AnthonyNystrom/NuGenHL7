using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RSP_K25_STAFF Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: STF (Staff Identification) <b></b><br>
	/// 1: PRA (Practitioner Detail) <b>optional repeating</b><br>
	/// 2: ORG (Practitioner Organization Unit) <b>optional repeating</b><br>
	/// 3: AFF (Professional Affiliation) <b>optional repeating</b><br>
	/// 4: LAN (Language Detail) <b>optional repeating</b><br>
	/// 5: EDU (Educational Detail) <b>optional repeating</b><br>
	/// 6: CER (Certificate Detail) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RSP_K25_STAFF:AbstractGroup
	{
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
		/// <summary> Returns the number of existing repetitions of AFF </summary>
		virtual public int AFFReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("AFF").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of LAN </summary>
		virtual public int LANReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("LAN").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of EDU </summary>
		virtual public int EDUReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("EDU").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of CER </summary>
		virtual public int CERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RSP_K25_STAFF Group.</summary>
		public RSP_K25_STAFF(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(STF), true, false);
				this.add(typeof(PRA), false, true);
				this.add(typeof(ORG), false, true);
				this.add(typeof(AFF), false, true);
				this.add(typeof(LAN), false, true);
				this.add(typeof(EDU), false, true);
				this.add(typeof(CER), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
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
		
		/// <summary> Returns  first repetition of AFF (Professional Affiliation) - creates it if necessary</summary>
		public virtual AFF getAFF()
		{
			AFF ret = null;
			try
			{
				ret = (AFF) this.get_Renamed("AFF");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of AFF
		/// (Professional Affiliation) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual AFF getAFF(int rep)
		{
			return (AFF) this.get_Renamed("AFF", rep);
		}
		
		/// <summary> Returns  first repetition of LAN (Language Detail) - creates it if necessary</summary>
		public virtual LAN getLAN()
		{
			LAN ret = null;
			try
			{
				ret = (LAN) this.get_Renamed("LAN");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of LAN
		/// (Language Detail) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual LAN getLAN(int rep)
		{
			return (LAN) this.get_Renamed("LAN", rep);
		}
		
		/// <summary> Returns  first repetition of EDU (Educational Detail) - creates it if necessary</summary>
		public virtual EDU getEDU()
		{
			EDU ret = null;
			try
			{
				ret = (EDU) this.get_Renamed("EDU");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of EDU
		/// (Educational Detail) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual EDU getEDU(int rep)
		{
			return (EDU) this.get_Renamed("EDU", rep);
		}
		
		/// <summary> Returns  first repetition of CER (Certificate Detail) - creates it if necessary</summary>
		public virtual CER getCER()
		{
			CER ret = null;
			try
			{
				ret = (CER) this.get_Renamed("CER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CER
		/// (Certificate Detail) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CER getCER(int rep)
		{
			return (CER) this.get_Renamed("CER", rep);
		}
	}
}