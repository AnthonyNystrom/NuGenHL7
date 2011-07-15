using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the RDO_O01_RXONTERXRRXCNTEOBXNTE Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXO (RXO - pharmacy/treatment order segment) <b></b><br>
	/// 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 2: RXR (RXR - pharmacy/treatment route segment) <b>repeating</b><br>
	/// 3: RDO_O01_RXCNTE (a Group object) <b>optional </b><br>
	/// 4: RDO_O01_OBXNTE (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RDO_O01_RXONTERXRRXCNTEOBXNTE:AbstractGroup
	{
		/// <summary> Returns RXO (RXO - pharmacy/treatment order segment) - creates it if necessary</summary>
		virtual public RXO RXO
		{
			get
			{
				RXO ret = null;
				try
				{
					ret = (RXO) this.get_Renamed("RXO");
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
		/// <summary> Returns the number of existing repetitions of RXR </summary>
		virtual public int RXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns RDO_O01_RXCNTE (a Group object) - creates it if necessary</summary>
		virtual public RDO_O01_RXCNTE RXCNTE
		{
			get
			{
				RDO_O01_RXCNTE ret = null;
				try
				{
					ret = (RDO_O01_RXCNTE) this.get_Renamed("RXCNTE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RDO_O01_OBXNTE </summary>
		virtual public int OBXNTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBXNTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RDO_O01_RXONTERXRRXCNTEOBXNTE Group.</summary>
		public RDO_O01_RXONTERXRRXCNTEOBXNTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXO), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RDO_O01_RXCNTE), false, false);
				this.add(typeof(RDO_O01_OBXNTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary</summary>
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
		/// (NTE - notes and comments segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of RXR (RXR - pharmacy/treatment route segment) - creates it if necessary</summary>
		public virtual RXR getRXR()
		{
			RXR ret = null;
			try
			{
				ret = (RXR) this.get_Renamed("RXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RXR
		/// (RXR - pharmacy/treatment route segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXR getRXR(int rep)
		{
			return (RXR) this.get_Renamed("RXR", rep);
		}
		
		/// <summary> Returns  first repetition of RDO_O01_OBXNTE (a Group object) - creates it if necessary</summary>
		public virtual RDO_O01_OBXNTE getOBXNTE()
		{
			RDO_O01_OBXNTE ret = null;
			try
			{
				ret = (RDO_O01_OBXNTE) this.get_Renamed("OBXNTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RDO_O01_OBXNTE
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RDO_O01_OBXNTE getOBXNTE(int rep)
		{
			return (RDO_O01_OBXNTE) this.get_Renamed("OBXNTE", rep);
		}
	}
}