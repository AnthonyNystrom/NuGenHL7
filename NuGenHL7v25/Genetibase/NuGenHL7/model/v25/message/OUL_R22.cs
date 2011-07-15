using System;
using Genetibase.NuGenHL7.model.v25.group;
using Genetibase.NuGenHL7.model.v25.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v25.message
{
	
	/// <summary> <p>Represents a OUL_R22 message structure (see chapter 7.3.7). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: SFT (Software Segment) <b>optional repeating</b><br>
	/// 2: NTE (Notes and Comments) <b>optional </b><br>
	/// 3: OUL_R22_PATIENT (a Group object) <b>optional </b><br>
	/// 4: OUL_R22_VISIT (a Group object) <b>optional </b><br>
	/// 5: OUL_R22_SPECIMEN (a Group object) <b>repeating</b><br>
	/// 6: DSC (Continuation Pointer) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class OUL_R22:AbstractMessage
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
		/// <summary> Returns NTE (Notes and Comments) - creates it if necessary</summary>
		virtual public NTE NTE
		{
			get
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
			
		}
		/// <summary> Returns OUL_R22_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public OUL_R22_PATIENT PATIENT
		{
			get
			{
				OUL_R22_PATIENT ret = null;
				try
				{
					ret = (OUL_R22_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OUL_R22_VISIT (a Group object) - creates it if necessary</summary>
		virtual public OUL_R22_VISIT VISIT
		{
			get
			{
				OUL_R22_VISIT ret = null;
				try
				{
					ret = (OUL_R22_VISIT) this.get_Renamed("VISIT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OUL_R22_SPECIMEN </summary>
		virtual public int SPECIMENReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("SPECIMEN").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns DSC (Continuation Pointer) - creates it if necessary</summary>
		virtual public DSC DSC
		{
			get
			{
				DSC ret = null;
				try
				{
					ret = (DSC) this.get_Renamed("DSC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new OUL_R22 Group with custom ModelClassFactory.</summary>
		public OUL_R22(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new OUL_R22 Group with DefaultModelClassFactory. </summary>
		public OUL_R22():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SFT), false, true);
				this.add(typeof(NTE), false, false);
				this.add(typeof(OUL_R22_PATIENT), false, false);
				this.add(typeof(OUL_R22_VISIT), false, false);
				this.add(typeof(OUL_R22_SPECIMEN), true, true);
				this.add(typeof(DSC), false, false);
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
		
		/// <summary> Returns  first repetition of OUL_R22_SPECIMEN (a Group object) - creates it if necessary</summary>
		public virtual OUL_R22_SPECIMEN getSPECIMEN()
		{
			OUL_R22_SPECIMEN ret = null;
			try
			{
				ret = (OUL_R22_SPECIMEN) this.get_Renamed("SPECIMEN");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OUL_R22_SPECIMEN
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OUL_R22_SPECIMEN getSPECIMEN(int rep)
		{
			return (OUL_R22_SPECIMEN) this.get_Renamed("SPECIMEN", rep);
		}
	}
}