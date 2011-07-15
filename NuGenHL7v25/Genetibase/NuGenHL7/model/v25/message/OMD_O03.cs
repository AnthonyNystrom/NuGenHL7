using System;
using Genetibase.NuGenHL7.model.v25.group;
using Genetibase.NuGenHL7.model.v25.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v25.message
{
	
	/// <summary> <p>Represents a OMD_O03 message structure (see chapter 4.7.1). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SFT (Software Segment) <b>optional repeating</b><br>
	/// 2: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 3: OMD_O03_PATIENT (a Group object) <b>optional </b><br>
	/// 4: OMD_O03_ORDER_DIET (a Group object) <b>repeating</b><br>
	/// 5: OMD_O03_ORDER_TRAY (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OMD_O03:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns OMD_O03_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public OMD_O03_PATIENT PATIENT
		{
			get
			{
				OMD_O03_PATIENT ret = null;
				try
				{
					ret = (OMD_O03_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OMD_O03_ORDER_DIET </summary>
		virtual public int ORDER_DIETReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER_DIET").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OMD_O03_ORDER_TRAY </summary>
		virtual public int ORDER_TRAYReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER_TRAY").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OMD_O03 Group with custom ModelClassFactory.</summary>
		public OMD_O03(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new OMD_O03 Group with DefaultModelClassFactory. </summary>
		public OMD_O03():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SFT), false, true);
				this.add(typeof(NTE), false, true);
				this.add(typeof(OMD_O03_PATIENT), false, false);
				this.add(typeof(OMD_O03_ORDER_DIET), true, true);
				this.add(typeof(OMD_O03_ORDER_TRAY), false, true);
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
		
		/// <summary> Returns  first repetition of NTE (Notes and Comments) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (Notes and Comments) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of OMD_O03_ORDER_DIET (a Group object) - creates it if necessary</summary>
		public virtual OMD_O03_ORDER_DIET getORDER_DIET()
		{
			OMD_O03_ORDER_DIET ret = null;
			try
			{
				ret = (OMD_O03_ORDER_DIET) this.get_Renamed("ORDER_DIET");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O03_ORDER_DIET
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O03_ORDER_DIET getORDER_DIET(int rep)
		{
			return (OMD_O03_ORDER_DIET) this.get_Renamed("ORDER_DIET", rep);
		}
		
		/// <summary> Returns  first repetition of OMD_O03_ORDER_TRAY (a Group object) - creates it if necessary</summary>
		public virtual OMD_O03_ORDER_TRAY getORDER_TRAY()
		{
			OMD_O03_ORDER_TRAY ret = null;
			try
			{
				ret = (OMD_O03_ORDER_TRAY) this.get_Renamed("ORDER_TRAY");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OMD_O03_ORDER_TRAY
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OMD_O03_ORDER_TRAY getORDER_TRAY(int rep)
		{
			return (OMD_O03_ORDER_TRAY) this.get_Renamed("ORDER_TRAY", rep);
		}
	}
}