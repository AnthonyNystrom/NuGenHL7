using System;
using Genetibase.NuGenHL7.model.v24.group;
using Genetibase.NuGenHL7.model.v24.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v24.message
{
	
	/// <summary> <p>Represents a RGV_O15 message structure (see chapter 4). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (Message Header) <b></b><br>
	/// 1: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 2: RGV_O15_PATIENT (a Group object) <b>optional </b><br>
	/// 3: RGV_O15_ORDER (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class RGV_O15:AbstractMessage
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
		/// <summary> Returns RGV_O15_PATIENT (a Group object) - creates it if necessary</summary>
		virtual public RGV_O15_PATIENT PATIENT
		{
			get
			{
				RGV_O15_PATIENT ret = null;
				try
				{
					ret = (RGV_O15_PATIENT) this.get_Renamed("PATIENT");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RGV_O15_ORDER </summary>
		virtual public int ORDERReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ORDER").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RGV_O15 Group with custom ModelClassFactory.</summary>
		public RGV_O15(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new RGV_O15 Group with DefaultModelClassFactory. </summary>
		public RGV_O15():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(RGV_O15_PATIENT), false, false);
				this.add(typeof(RGV_O15_ORDER), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
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
		
		/// <summary> Returns  first repetition of RGV_O15_ORDER (a Group object) - creates it if necessary</summary>
		public virtual RGV_O15_ORDER getORDER()
		{
			RGV_O15_ORDER ret = null;
			try
			{
				ret = (RGV_O15_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RGV_O15_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RGV_O15_ORDER getORDER(int rep)
		{
			return (RGV_O15_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}