using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 UB1 message segment. 
	/// This segment has the following fields:</p><p>
	/// UB1-1: SET ID - UB82 (SI)<br> 
	/// UB1-2: BLOOD DEDUCTIBLE (ST)<br> 
	/// UB1-3: BLOOD FURN.-PINTS OF (40) (ST)<br> 
	/// UB1-4: BLOOD REPLACED-PINTS (41) (ST)<br> 
	/// UB1-5: BLOOD NOT RPLCD-PINTS(42) (ST)<br> 
	/// UB1-6: CO-INSURANCE DAYS (25) (ST)<br> 
	/// UB1-7: CONDITION CODE (ID)<br> 
	/// UB1-8: COVERED DAYS - (23) (ST)<br> 
	/// UB1-9: NON COVERED DAYS - (24) (ST)<br> 
	/// UB1-10: VALUE AMOUNT & CODE (CM)<br> 
	/// UB1-11: NUMBER OF GRACE DAYS (90) (ST)<br> 
	/// UB1-12: SPEC. PROG. INDICATOR(44) (ID)<br> 
	/// UB1-13: PSRO/UR APPROVAL IND. (87) (ID)<br> 
	/// UB1-14: PSRO/UR APRVD STAY-FM(88) (DT)<br> 
	/// UB1-15: PSRO/UR APRVD STAY-TO(89) (DT)<br> 
	/// UB1-16: OCCURRENCE (28-32) (ID)<br> 
	/// UB1-17: OCCURRENCE SPAN (33) (ID)<br> 
	/// UB1-18: OCCURRENCE SPAN START DATE(33) (DT)<br> 
	/// UB1-19: OCCUR. SPAN END DATE (33) (DT)<br> 
	/// UB1-20: UB-82 LOCATOR 2 (ST)<br> 
	/// UB1-21: UB-82 LOCATOR 9 (ST)<br> 
	/// UB1-22: UB-82 LOCATOR 27 (ST)<br> 
	/// UB1-23: UB-82 LOCATOR 45 (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class UB1:AbstractSegment
	{
		/// <summary> Returns SET ID - UB82 (UB1-1).</summary>
		virtual public SI SETIDUB82
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI) t;
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
		/// <summary> Returns BLOOD DEDUCTIBLE (UB1-2).</summary>
		virtual public ST BLOODDEDUCTIBLE
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns BLOOD FURN.-PINTS OF (40) (UB1-3).</summary>
		virtual public ST BLOODFURNPINTSOF
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
		/// <summary> Returns BLOOD REPLACED-PINTS (41) (UB1-4).</summary>
		virtual public ST BLOODREPLACEDPINTS
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
		/// <summary> Returns BLOOD NOT RPLCD-PINTS(42) (UB1-5).</summary>
		virtual public ST BLOODNOTRPLCDPINTS
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns CO-INSURANCE DAYS (25) (UB1-6).</summary>
		virtual public ST COINSURANCEDAYS
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns COVERED DAYS - (23) (UB1-8).</summary>
		virtual public ST COVEREDDAYS
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns NON COVERED DAYS - (24) (UB1-9).</summary>
		virtual public ST NONCOVEREDDAYS
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns NUMBER OF GRACE DAYS (90) (UB1-11).</summary>
		virtual public ST NUMBEROFGRACEDAYS
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns SPEC. PROG. INDICATOR(44) (UB1-12).</summary>
		virtual public ID SPECPROGINDICATOR
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns PSRO/UR APPROVAL IND. (87) (UB1-13).</summary>
		virtual public ID PSROURAPPROVALIND
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns PSRO/UR APRVD STAY-FM(88) (UB1-14).</summary>
		virtual public DT PSROURAPRVDSTAYFM
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (DT) t;
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
		/// <summary> Returns PSRO/UR APRVD STAY-TO(89) (UB1-15).</summary>
		virtual public DT PSROURAPRVDSTAYTO
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (DT) t;
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
		/// <summary> Returns OCCURRENCE SPAN (33) (UB1-17).</summary>
		virtual public ID OCCURRENCESPAN
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
		/// <summary> Returns OCCURRENCE SPAN START DATE(33) (UB1-18).</summary>
		virtual public DT OCCURRENCESPANSTARTDATE
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (DT) t;
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
		/// <summary> Returns OCCUR. SPAN END DATE (33) (UB1-19).</summary>
		virtual public DT OCCURSPANENDDATE
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (DT) t;
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
		/// <summary> Returns UB-82 LOCATOR 2 (UB1-20).</summary>
		virtual public ST UB82LOCATOR2
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns UB-82 LOCATOR 9 (UB1-21).</summary>
		virtual public ST UB82LOCATOR9
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns UB-82 LOCATOR 27 (UB1-22).</summary>
		virtual public ST UB82LOCATOR27
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns UB-82 LOCATOR 45 (UB1-23).</summary>
		virtual public ST UB82LOCATOR45
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		
		/// <summary> Creates a UB1 (UB82 DATA) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public UB1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 1, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ID), false, 5, 2, new System.Object[]{message, 43});
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CM), false, 8, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 5, 20, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 7, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 17, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of CONDITION CODE (UB1-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getCONDITIONCODE(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of CONDITION CODE (UB1-7).</summary>
		public virtual ID[] getCONDITIONCODE()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of VALUE AMOUNT & CODE (UB1-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM getVALUEAMOUNTCODE(int rep)
		{
			CM ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (CM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of VALUE AMOUNT & CODE (UB1-10).</summary>
		public virtual CM[] getVALUEAMOUNTCODE()
		{
			CM[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new CM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM) t[i];
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
		
		/// <summary> Returns a single repetition of OCCURRENCE (28-32) (UB1-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getOCCURRENCE2832(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of OCCURRENCE (28-32) (UB1-16).</summary>
		public virtual ID[] getOCCURRENCE2832()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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
	}
}