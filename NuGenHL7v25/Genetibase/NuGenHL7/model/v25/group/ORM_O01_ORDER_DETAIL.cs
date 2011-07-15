using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the ORM_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: OBR (Observation Request) <b></b><br>
	/// 1: RQD (Requisition Detail) <b></b><br>
	/// 2: RQ1 (Requisition Detail-1) <b></b><br>
	/// 3: RXO (Pharmacy/Treatment Order) <b></b><br>
	/// 4: ODS (Dietary Orders, Supplements, and Preferences) <b></b><br>
	/// 5: ODT (Diet Tray Instructions) <b></b><br>
	/// 6: NTE (Notes and Comments) <b>optional repeating</b><br>
	/// 7: CTD (Contact Data) <b>optional </b><br>
	/// 8: DG1 (Diagnosis) <b>optional repeating</b><br>
	/// 9: ORM_O01_OBSERVATION (a Group object) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class ORM_O01_ORDER_DETAIL:AbstractGroup
	{
		/// <summary> Returns OBR (Observation Request) - creates it if necessary</summary>
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
		/// <summary> Returns RQD (Requisition Detail) - creates it if necessary</summary>
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
		/// <summary> Returns RQ1 (Requisition Detail-1) - creates it if necessary</summary>
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
		/// <summary> Returns RXO (Pharmacy/Treatment Order) - creates it if necessary</summary>
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
		/// <summary> Returns ODS (Dietary Orders, Supplements, and Preferences) - creates it if necessary</summary>
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
		/// <summary> Returns ODT (Diet Tray Instructions) - creates it if necessary</summary>
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
		/// <summary> Returns CTD (Contact Data) - creates it if necessary</summary>
		virtual public CTD CTD
		{
			get
			{
				CTD ret = null;
				try
				{
					ret = (CTD) this.get_Renamed("CTD");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of DG1 </summary>
		virtual public int DG1Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("DG1").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of ORM_O01_OBSERVATION </summary>
		virtual public int OBSERVATIONReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("OBSERVATION").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ORM_O01_ORDER_DETAIL Group.</summary>
		public ORM_O01_ORDER_DETAIL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(OBR), true, false);
				this.add(typeof(RQD), true, false);
				this.add(typeof(RQ1), true, false);
				this.add(typeof(RXO), true, false);
				this.add(typeof(ODS), true, false);
				this.add(typeof(ODT), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(CTD), false, false);
				this.add(typeof(DG1), false, true);
				this.add(typeof(ORM_O01_OBSERVATION), false, true);
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
		
		/// <summary> Returns  first repetition of DG1 (Diagnosis) - creates it if necessary</summary>
		public virtual DG1 getDG1()
		{
			DG1 ret = null;
			try
			{
				ret = (DG1) this.get_Renamed("DG1");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of DG1
		/// (Diagnosis) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual DG1 getDG1(int rep)
		{
			return (DG1) this.get_Renamed("DG1", rep);
		}
		
		/// <summary> Returns  first repetition of ORM_O01_OBSERVATION (a Group object) - creates it if necessary</summary>
		public virtual ORM_O01_OBSERVATION getOBSERVATION()
		{
			ORM_O01_OBSERVATION ret = null;
			try
			{
				ret = (ORM_O01_OBSERVATION) this.get_Renamed("OBSERVATION");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ORM_O01_OBSERVATION
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ORM_O01_OBSERVATION getOBSERVATION(int rep)
		{
			return (ORM_O01_OBSERVATION) this.get_Renamed("OBSERVATION", rep);
		}
	}
}