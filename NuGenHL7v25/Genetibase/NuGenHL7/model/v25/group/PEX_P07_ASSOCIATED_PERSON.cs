using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the PEX_P07_ASSOCIATED_PERSON Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NK1 (Next of Kin / Associated Parties) <b></b><br>
	/// 1: PEX_P07_ASSOCIATED_RX_ORDER (a Group object) <b>optional </b><br>
	/// 2: PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) <b>optional repeating</b><br>
	/// 3: PRB (Problem Details) <b>optional repeating</b><br>
	/// 4: OBX (Observation/Result) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_ASSOCIATED_PERSON:AbstractGroup
	{
		/// <summary> Returns NK1 (Next of Kin / Associated Parties) - creates it if necessary</summary>
		virtual public NK1 NK1
		{
			get
			{
				NK1 ret = null;
				try
				{
					ret = (NK1) this.get_Renamed("NK1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PEX_P07_ASSOCIATED_RX_ORDER (a Group object) - creates it if necessary</summary>
		virtual public PEX_P07_ASSOCIATED_RX_ORDER ASSOCIATED_RX_ORDER
		{
			get
			{
				PEX_P07_ASSOCIATED_RX_ORDER ret = null;
				try
				{
					ret = (PEX_P07_ASSOCIATED_RX_ORDER) this.get_Renamed("ASSOCIATED_RX_ORDER");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PEX_P07_ASSOCIATED_RX_ADMIN </summary>
		virtual public int ASSOCIATED_RX_ADMINReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("ASSOCIATED_RX_ADMIN").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PRB </summary>
		virtual public int PRBReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PRB").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of OBX </summary>
		virtual public int OBXReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBX").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new PEX_P07_ASSOCIATED_PERSON Group.</summary>
		public PEX_P07_ASSOCIATED_PERSON(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(NK1), true, false);
				this.add(typeof(PEX_P07_ASSOCIATED_RX_ORDER), false, false);
				this.add(typeof(PEX_P07_ASSOCIATED_RX_ADMIN), false, true);
				this.add(typeof(PRB), false, true);
				this.add(typeof(OBX), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) - creates it if necessary</summary>
		public virtual PEX_P07_ASSOCIATED_RX_ADMIN getASSOCIATED_RX_ADMIN()
		{
			PEX_P07_ASSOCIATED_RX_ADMIN ret = null;
			try
			{
				ret = (PEX_P07_ASSOCIATED_RX_ADMIN) this.get_Renamed("ASSOCIATED_RX_ADMIN");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PEX_P07_ASSOCIATED_RX_ADMIN
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PEX_P07_ASSOCIATED_RX_ADMIN getASSOCIATED_RX_ADMIN(int rep)
		{
			return (PEX_P07_ASSOCIATED_RX_ADMIN) this.get_Renamed("ASSOCIATED_RX_ADMIN", rep);
		}
		
		/// <summary> Returns  first repetition of PRB (Problem Details) - creates it if necessary</summary>
		public virtual PRB getPRB()
		{
			PRB ret = null;
			try
			{
				ret = (PRB) this.get_Renamed("PRB");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PRB
		/// (Problem Details) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRB getPRB(int rep)
		{
			return (PRB) this.get_Renamed("PRB", rep);
		}
		
		/// <summary> Returns  first repetition of OBX (Observation/Result) - creates it if necessary</summary>
		public virtual OBX getOBX()
		{
			OBX ret = null;
			try
			{
				ret = (OBX) this.get_Renamed("OBX");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of OBX
		/// (Observation/Result) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OBX getOBX(int rep)
		{
			return (OBX) this.get_Renamed("OBX", rep);
		}
	}
}