using System;
using Genetibase.NuGenHL7.model.v22.group;
using Genetibase.NuGenHL7.model.v22.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v22.message
{
	
	/// <summary> <p>Represents a ORF_R04 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MESSAGE HEADER) <b></b><br>
	/// 1: MSA (MESSAGE ACKNOWLEDGMENT) <b></b><br>
	/// 2: ORF_R04_QUERY_RESPONSE (a Group object) <b>repeating</b><br>
	/// 3: ORF_R04_ORDER (a Group object) <b>repeating</b><br>
	/// 4: DSC (CONTINUATION POINTER) <b>optional </b><br>
	/// </summary>
	[Serializable]
	public class ORF_R04:AbstractMessage
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
		/// <summary> Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary</summary>
		virtual public MSA MSA
		{
			get
			{
				MSA ret = null;
				try
				{
					ret = (MSA) this.get_Renamed("MSA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORF_R04_QUERY_RESPONSE </summary>
		virtual public int QUERY_RESPONSEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("QUERY_RESPONSE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORF_R04_ORDER </summary>
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
		/// <summary> Returns DSC (CONTINUATION POINTER) - creates it if necessary</summary>
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
		
		/// <summary> Creates a new ORF_R04 Group with custom ModelClassFactory.</summary>
		public ORF_R04(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ORF_R04 Group with DefaultModelClassFactory. </summary>
		public ORF_R04():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(ORF_R04_QUERY_RESPONSE), true, true);
				this.add(typeof(ORF_R04_ORDER), true, true);
				this.add(typeof(DSC), false, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ORF_R04_QUERY_RESPONSE (a Group object) - creates it if necessary</summary>
		public virtual ORF_R04_QUERY_RESPONSE getQUERY_RESPONSE()
		{
			ORF_R04_QUERY_RESPONSE ret = null;
			try
			{
				ret = (ORF_R04_QUERY_RESPONSE) this.get_Renamed("QUERY_RESPONSE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORF_R04_QUERY_RESPONSE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORF_R04_QUERY_RESPONSE getQUERY_RESPONSE(int rep)
		{
			return (ORF_R04_QUERY_RESPONSE) this.get_Renamed("QUERY_RESPONSE", rep);
		}
		
		/// <summary> Returns  first repetition of ORF_R04_ORDER (a Group object) - creates it if necessary</summary>
		public virtual ORF_R04_ORDER getORDER()
		{
			ORF_R04_ORDER ret = null;
			try
			{
				ret = (ORF_R04_ORDER) this.get_Renamed("ORDER");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORF_R04_ORDER
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORF_R04_ORDER getORDER(int rep)
		{
			return (ORF_R04_ORDER) this.get_Renamed("ORDER", rep);
		}
	}
}