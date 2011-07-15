using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a EAC_U07 message structure (see chapter 13). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: EQU (Equipment Detail) <b></b><br>
	/// 2: ECD (Equipment Command) <b>repeating</b><br>
	/// 3: SAC (Specimen and container detail) <b>optional </b><br>
	/// 4: CNS (Clear Notification) <b>optional </b><br>
	/// 5: ROL (Role) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class EAC_U07:AbstractMessage
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
		/// <summary> Returns EQU (Equipment Detail) - creates it if necessary</summary>
		virtual public EQU EQU
		{
			get
			{
				EQU ret = null;
				try
				{
					ret = (EQU) this.get_Renamed("EQU");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ECD </summary>
		virtual public int ECDReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ECD").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns SAC (Specimen and container detail) - creates it if necessary</summary>
		virtual public SAC SAC
		{
			get
			{
				SAC ret = null;
				try
				{
					ret = (SAC) this.get_Renamed("SAC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns CNS (Clear Notification) - creates it if necessary</summary>
		virtual public CNS CNS
		{
			get
			{
				CNS ret = null;
				try
				{
					ret = (CNS) this.get_Renamed("CNS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ROL (Role) - creates it if necessary</summary>
		virtual public ROL ROL
		{
			get
			{
				ROL ret = null;
				try
				{
					ret = (ROL) this.get_Renamed("ROL");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new EAC_U07 Group with custom ModelClassFactory.</summary>
		public EAC_U07(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new EAC_U07 Group with DefaultModelClassFactory. </summary>
		public EAC_U07():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EQU), true, false);
				this.add(typeof(ECD), true, true);
				this.add(typeof(SAC), false, false);
				this.add(typeof(CNS), false, false);
				this.add(typeof(ROL), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ECD (Equipment Command) - creates it if necessary</summary>
		public virtual ECD getECD()
		{
			ECD ret = null;
			try
			{
				ret = (ECD) this.get_Renamed("ECD");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ECD
		/// (Equipment Command) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ECD getECD(int rep)
		{
			return (ECD) this.get_Renamed("ECD", rep);
		}
	}
}