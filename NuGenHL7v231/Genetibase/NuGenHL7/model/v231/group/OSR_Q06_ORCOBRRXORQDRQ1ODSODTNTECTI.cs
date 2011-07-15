using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v231.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v231.group
{
	/// <summary> <p>Represents the OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: ORC (ORC - common order segment) <b></b><br>
	/// 1: OBR (OBR - observation request segment) <b></b><br>
	/// 2: RXO (RXO - pharmacy/treatment order segment) <b></b><br>
	/// 3: RQD (RQD - requisition detail segment) <b></b><br>
	/// 4: RQ1 (RQ1 - requisition detail-1 segment) <b></b><br>
	/// 5: ODS (ODS - dietary orders, supplements, and preferences segment) <b></b><br>
	/// 6: ODT (ODT - diet tray instructions segment) <b></b><br>
	/// 7: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
	/// 8: CTI (CTI - clinical trial identification segment) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI:AbstractGroup
	{
		/// <summary> Returns ORC (ORC - common order segment) - creates it if necessary</summary>
		virtual public ORC ORC
		{
			get
			{
				ORC ret = null;
				try
				{
					ret = (ORC) this.get_Renamed("ORC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns OBR (OBR - observation request segment) - creates it if necessary</summary>
		virtual public OBR OBR
		{
			get
			{
				OBR ret = null;
				try
				{
					ret = (OBR) this.get_Renamed("OBR");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
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
		/// <summary> Returns RQD (RQD - requisition detail segment) - creates it if necessary</summary>
		virtual public RQD RQD
		{
			get
			{
				RQD ret = null;
				try
				{
					ret = (RQD) this.get_Renamed("RQD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RQ1 (RQ1 - requisition detail-1 segment) - creates it if necessary</summary>
		virtual public RQ1 RQ1
		{
			get
			{
				RQ1 ret = null;
				try
				{
					ret = (RQ1) this.get_Renamed("RQ1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ODS (ODS - dietary orders, supplements, and preferences segment) - creates it if necessary</summary>
		virtual public ODS ODS
		{
			get
			{
				ODS ret = null;
				try
				{
					ret = (ODS) this.get_Renamed("ODS");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ODT (ODT - diet tray instructions segment) - creates it if necessary</summary>
		virtual public ODT ODT
		{
			get
			{
				ODT ret = null;
				try
				{
					ret = (ODT) this.get_Renamed("ODT");
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
		/// <summary> Returns the number of existing repetitions of CTI </summary>
		virtual public int CTIReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("CTI").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI Group.</summary>
		public OSR_Q06_ORCOBRRXORQDRQ1ODSODTNTECTI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(OBR), true, false);
				this.add(typeof(RXO), true, false);
				this.add(typeof(RQD), true, false);
				this.add(typeof(RQ1), true, false);
				this.add(typeof(ODS), true, false);
				this.add(typeof(ODT), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(CTI), false, true);
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
		
		/// <summary> Returns  first repetition of CTI (CTI - clinical trial identification segment) - creates it if necessary</summary>
		public virtual CTI getCTI()
		{
			CTI ret = null;
			try
			{
				ret = (CTI) this.get_Renamed("CTI");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of CTI
		/// (CTI - clinical trial identification segment) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual CTI getCTI(int rep)
		{
			return (CTI) this.get_Renamed("CTI", rep);
		}
	}
}