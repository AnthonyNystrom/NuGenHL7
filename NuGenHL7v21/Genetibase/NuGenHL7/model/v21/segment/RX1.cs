using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 RX1 message segment. 
	/// This segment has the following fields:</p><p>
	/// RX1-1: UNUSED (ST)<br> 
	/// RX1-2: UNUSED (ST)<br> 
	/// RX1-3: ROUTE (ST)<br> 
	/// RX1-4: SITE ADMINISTERED (ST)<br> 
	/// RX1-5: IV SOLUTION RATE (CQ)<br> 
	/// RX1-6: DRUG STRENGTH (CQ)<br> 
	/// RX1-7: FINAL CONCENTRATION (NM)<br> 
	/// RX1-8: FINAL VOLUME IN ML. (NM)<br> 
	/// RX1-9: DRUG DOSE (CM)<br> 
	/// RX1-10: DRUG ROLE (ID)<br> 
	/// RX1-11: PRESCRIPTION SEQUENCE # (NM)<br> 
	/// RX1-12: QUANTITY DISPENSED (CQ)<br> 
	/// RX1-13: UNUSED (ST)<br> 
	/// RX1-14: DRUG ID (CE)<br> 
	/// RX1-15: COMPONENT DRUG IDS (ID)<br> 
	/// RX1-16: PRESCRIPTION TYPE (ID)<br> 
	/// RX1-17: SUBSTITUTION STATUS (ID)<br> 
	/// RX1-18: RX ORDER STATUS (ID)<br> 
	/// RX1-19: NUMBER OF REFILLS (NM)<br> 
	/// RX1-20: UNUSED (ST)<br> 
	/// RX1-21: REFILLS REMAINING (NM)<br> 
	/// RX1-22: DEA CLASS (ID)<br> 
	/// RX1-23: ORDERING MD'S DEA NUMBER (NM)<br> 
	/// RX1-24: UNUSED (ST)<br> 
	/// RX1-25: LAST REFILL DATE/TIME (TS)<br> 
	/// RX1-26: RX NUMBER (ST)<br> 
	/// RX1-27: PRN STATUS (ID)<br> 
	/// RX1-28: PHARMACY INSTRUCTIONS (TX)<br> 
	/// RX1-29: PATIENT INSTRUCTIONS (TX)<br> 
	/// RX1-30: INSTRUCTIONS (SIG) (TX)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RX1:AbstractSegment
	{
		/// <summary> Returns ROUTE (RX1-3).</summary>
		virtual public ST ROUTE
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns SITE ADMINISTERED (RX1-4).</summary>
		virtual public ST SITEADMINISTERED
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns IV SOLUTION RATE (RX1-5).</summary>
		virtual public CQ IVSOLUTIONRATE
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CQ) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns DRUG STRENGTH (RX1-6).</summary>
		virtual public CQ DRUGSTRENGTH
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (CQ) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns FINAL CONCENTRATION (RX1-7).</summary>
		virtual public NM FINALCONCENTRATION
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns FINAL VOLUME IN ML. (RX1-8).</summary>
		virtual public NM FINALVOLUMEINML
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns DRUG DOSE (RX1-9).</summary>
		virtual public CM DRUGDOSE
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (CM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns DRUG ROLE (RX1-10).</summary>
		virtual public ID DRUGROLE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PRESCRIPTION SEQUENCE # (RX1-11).</summary>
		virtual public NM PRESCRIPTIONSEQUENCE
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns QUANTITY DISPENSED (RX1-12).</summary>
		virtual public CQ QUANTITYDISPENSED
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CQ) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns DRUG ID (RX1-14).</summary>
		virtual public CE DRUGID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PRESCRIPTION TYPE (RX1-16).</summary>
		virtual public ID PRESCRIPTIONTYPE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(16, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns SUBSTITUTION STATUS (RX1-17).</summary>
		virtual public ID SUBSTITUTIONSTATUS
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RX ORDER STATUS (RX1-18).</summary>
		virtual public ID RXORDERSTATUS
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns NUMBER OF REFILLS (RX1-19).</summary>
		virtual public NM NUMBEROFREFILLS
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns REFILLS REMAINING (RX1-21).</summary>
		virtual public NM REFILLSREMAINING
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns DEA CLASS (RX1-22).</summary>
		virtual public ID DEACLASS
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(22, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns ORDERING MD'S DEA NUMBER (RX1-23).</summary>
		virtual public NM ORDERINGMDSDEANUMBER
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns LAST REFILL DATE/TIME (RX1-25).</summary>
		virtual public TS LASTREFILLDATETIME
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(25, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns RX NUMBER (RX1-26).</summary>
		virtual public ST RXNUMBER
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(26, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PRN STATUS (RX1-27).</summary>
		virtual public ID PRNSTATUS
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(27, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a RX1 (PHARMACY ORDER) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RX1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 10, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 14, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 5, new System.Object[]{message});
				this.add(typeof(ID), false, 5, 5, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 38});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 0});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 0});
				this.add(typeof(TX), false, 5, 80, new System.Object[]{message});
				this.add(typeof(TX), false, 5, 80, new System.Object[]{message});
				this.add(typeof(TX), false, 0, 500, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of COMPONENT DRUG IDS (RX1-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getCOMPONENTDRUGIDS(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of COMPONENT DRUG IDS (RX1-15).</summary>
		public virtual ID[] getCOMPONENTDRUGIDS()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(15);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of PHARMACY INSTRUCTIONS (RX1-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TX getPHARMACYINSTRUCTIONS(int rep)
		{
			TX ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (TX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of PHARMACY INSTRUCTIONS (RX1-28).</summary>
		public virtual TX[] getPHARMACYINSTRUCTIONS()
		{
			TX[] ret = null;
			try
			{
				Type[] t = this.getField(28);
				ret = new TX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TX) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of PATIENT INSTRUCTIONS (RX1-29).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TX getPATIENTINSTRUCTIONS(int rep)
		{
			TX ret = null;
			try
			{
				Type t = this.getField(29, rep);
				ret = (TX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of PATIENT INSTRUCTIONS (RX1-29).</summary>
		public virtual TX[] getPATIENTINSTRUCTIONS()
		{
			TX[] ret = null;
			try
			{
				Type[] t = this.getField(29);
				ret = new TX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TX) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of INSTRUCTIONS (SIG) (RX1-30).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TX getINSTRUCTIONS(int rep)
		{
			TX ret = null;
			try
			{
				Type t = this.getField(30, rep);
				ret = (TX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of INSTRUCTIONS (SIG) (RX1-30).</summary>
		public virtual TX[] getINSTRUCTIONS()
		{
			TX[] ret = null;
			try
			{
				Type[] t = this.getField(30);
				ret = new TX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TX) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
	}
}