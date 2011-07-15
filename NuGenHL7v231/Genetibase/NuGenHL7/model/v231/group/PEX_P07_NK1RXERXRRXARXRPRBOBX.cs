using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the PEX_P07_NK1RXERXRRXARXRPRBOBX Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NK1 (NK1 - next of kin / associated parties segment-) <b></b><br>
	/// 1: PEX_P07_RXERXR (a Group object) <b>optional </b><br>
	/// 2: PEX_P07_RXARXR (a Group object) <b>optional repeating</b><br>
	/// 3: PRB (Problem Detail) <b>optional repeating</b><br>
	/// 4: OBX (OBX - observation/result segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class PEX_P07_NK1RXERXRRXARXRPRBOBX:AbstractGroup
	{
		/// <summary> Returns NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary</summary>
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
		/// <summary> Returns PEX_P07_RXERXR (a Group object) - creates it if necessary</summary>
		virtual public PEX_P07_RXERXR RXERXR
		{
			get
			{
				PEX_P07_RXERXR ret = null;
				try
				{
					ret = (PEX_P07_RXERXR) this.get_Renamed("RXERXR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of PEX_P07_RXARXR </summary>
		virtual public int RXARXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXARXR").Length;
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
		
		/// <summary> Creates a new PEX_P07_NK1RXERXRRXARXRPRBOBX Group.</summary>
		public PEX_P07_NK1RXERXRRXARXRPRBOBX(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(NK1), true, false);
				this.add(typeof(PEX_P07_RXERXR), false, false);
				this.add(typeof(PEX_P07_RXARXR), false, true);
				this.add(typeof(PRB), false, true);
				this.add(typeof(OBX), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of PEX_P07_RXARXR (a Group object) - creates it if necessary</summary>
		public virtual PEX_P07_RXARXR getRXARXR()
		{
			PEX_P07_RXARXR ret = null;
			try
			{
				ret = (PEX_P07_RXARXR) this.get_Renamed("RXARXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of PEX_P07_RXARXR
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PEX_P07_RXARXR getRXARXR(int rep)
		{
			return (PEX_P07_RXARXR) this.get_Renamed("RXARXR", rep);
		}
		
		/// <summary> Returns  first repetition of PRB (Problem Detail) - creates it if necessary</summary>
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
		/// (Problem Detail) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual PRB getPRB(int rep)
		{
			return (PRB) this.get_Renamed("PRB", rep);
		}
		
		/// <summary> Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary</summary>
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
		/// (OBX - observation/result segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual OBX getOBX(int rep)
		{
			return (OBX) this.get_Renamed("OBX", rep);
		}
	}
}