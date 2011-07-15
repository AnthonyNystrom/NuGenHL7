using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 FT1 message segment. 
	/// This segment has the following fields:</p><p>
	/// FT1-1: Set ID - FT1 (SI)<br> 
	/// FT1-2: Transaction ID (ST)<br> 
	/// FT1-3: Transaction Batch ID (ST)<br> 
	/// FT1-4: Transaction Date (DR)<br> 
	/// FT1-5: Transaction Posting Date (TS)<br> 
	/// FT1-6: Transaction Type (IS)<br> 
	/// FT1-7: Transaction Code (CE)<br> 
	/// FT1-8: Transaction Description (ST)<br> 
	/// FT1-9: Transaction Description - Alt (ST)<br> 
	/// FT1-10: Transaction Quantity (NM)<br> 
	/// FT1-11: Transaction Amount - Extended (CP)<br> 
	/// FT1-12: Transaction Amount - Unit (CP)<br> 
	/// FT1-13: Department Code (CE)<br> 
	/// FT1-14: Insurance Plan ID (CE)<br> 
	/// FT1-15: Insurance Amount (CP)<br> 
	/// FT1-16: Assigned Patient Location (PL)<br> 
	/// FT1-17: Fee Schedule (IS)<br> 
	/// FT1-18: Patient Type (IS)<br> 
	/// FT1-19: Diagnosis Code - FT1 (CE)<br> 
	/// FT1-20: Performed By Code (XCN)<br> 
	/// FT1-21: Ordered By Code (XCN)<br> 
	/// FT1-22: Unit Cost (CP)<br> 
	/// FT1-23: Filler Order Number (EI)<br> 
	/// FT1-24: Entered By Code (XCN)<br> 
	/// FT1-25: Procedure Code (CE)<br> 
	/// FT1-26: Procedure Code Modifier (CE)<br> 
	/// FT1-27: Advanced Beneficiary Notice Code (CE)<br> 
	/// FT1-28: Medically Necessary Duplicate Procedure Reason. (CWE)<br> 
	/// FT1-29: NDC Code (CNE)<br> 
	/// FT1-30: Payment Reference ID (CX)<br> 
	/// FT1-31: Transaction Reference Key (SI)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class FT1:AbstractSegment
	{
		/// <summary> Returns Set ID - FT1 (FT1-1).</summary>
		virtual public SI SetIDFT1
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
		/// <summary> Returns Transaction ID (FT1-2).</summary>
		virtual public ST TransactionID
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
		/// <summary> Returns Transaction Batch ID (FT1-3).</summary>
		virtual public ST TransactionBatchID
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
		/// <summary> Returns Transaction Date (FT1-4).</summary>
		virtual public DR TransactionDate
		{
			get
			{
				DR ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (DR) t;
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
		/// <summary> Returns Transaction Posting Date (FT1-5).</summary>
		virtual public TS TransactionPostingDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Transaction Type (FT1-6).</summary>
		virtual public IS TransactionType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (IS) t;
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
		/// <summary> Returns Transaction Code (FT1-7).</summary>
		virtual public CE TransactionCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Transaction Description (FT1-8).</summary>
		virtual public ST TransactionDescription
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
		/// <summary> Returns Transaction Description - Alt (FT1-9).</summary>
		virtual public ST TransactionDescriptionAlt
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
		/// <summary> Returns Transaction Quantity (FT1-10).</summary>
		virtual public NM TransactionQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Transaction Amount - Extended (FT1-11).</summary>
		virtual public CP TransactionAmountExtended
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CP) t;
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
		/// <summary> Returns Transaction Amount - Unit (FT1-12).</summary>
		virtual public CP TransactionAmountUnit
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CP) t;
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
		/// <summary> Returns Department Code (FT1-13).</summary>
		virtual public CE DepartmentCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Insurance Plan ID (FT1-14).</summary>
		virtual public CE InsurancePlanID
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
		/// <summary> Returns Insurance Amount (FT1-15).</summary>
		virtual public CP InsuranceAmount
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (CP) t;
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
		/// <summary> Returns Assigned Patient Location (FT1-16).</summary>
		virtual public PL AssignedPatientLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(16, 0);
					ret = (PL) t;
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
		/// <summary> Returns Fee Schedule (FT1-17).</summary>
		virtual public IS FeeSchedule
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (IS) t;
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
		/// <summary> Returns Patient Type (FT1-18).</summary>
		virtual public IS PatientType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (IS) t;
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
		/// <summary> Returns Unit Cost (FT1-22).</summary>
		virtual public CP UnitCost
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(22, 0);
					ret = (CP) t;
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
		/// <summary> Returns Filler Order Number (FT1-23).</summary>
		virtual public EI FillerOrderNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (EI) t;
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
		/// <summary> Returns Procedure Code (FT1-25).</summary>
		virtual public CE ProcedureCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Advanced Beneficiary Notice Code (FT1-27).</summary>
		virtual public CE AdvancedBeneficiaryNoticeCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Medically Necessary Duplicate Procedure Reason. (FT1-28).</summary>
		virtual public CWE MedicallyNecessaryDuplicateProcedureReason
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(28, 0);
					ret = (CWE) t;
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
		/// <summary> Returns NDC Code (FT1-29).</summary>
		virtual public CNE NDCCode
		{
			get
			{
				CNE ret = null;
				try
				{
					Type t = this.getField(29, 0);
					ret = (CNE) t;
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
		/// <summary> Returns Payment Reference ID (FT1-30).</summary>
		virtual public CX PaymentReferenceID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(30, 0);
					ret = (CX) t;
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
		
		/// <summary> Creates a FT1 (Financial Transaction) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public FT1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 10, new System.Object[]{message});
				this.add(typeof(DR), true, 1, 53, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), true, 1, 8, new System.Object[]{message, 17});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 6, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 24});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 18});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(SI), false, 0, 4, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Diagnosis Code - FT1 (FT1-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getDiagnosisCodeFT1(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Diagnosis Code - FT1 (FT1-19).</summary>
		public virtual CE[] getDiagnosisCodeFT1()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(19);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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
		
		/// <summary> Returns a single repetition of Performed By Code (FT1-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getPerformedByCode(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Performed By Code (FT1-20).</summary>
		public virtual XCN[] getPerformedByCode()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(20);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Ordered By Code (FT1-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getOrderedByCode(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ordered By Code (FT1-21).</summary>
		public virtual XCN[] getOrderedByCode()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(21);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Entered By Code (FT1-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getEnteredByCode(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(24, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Entered By Code (FT1-24).</summary>
		public virtual XCN[] getEnteredByCode()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(24);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Procedure Code Modifier (FT1-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProcedureCodeModifier(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Procedure Code Modifier (FT1-26).</summary>
		public virtual CE[] getProcedureCodeModifier()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(26);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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
		
		/// <summary> Returns a single repetition of Transaction Reference Key (FT1-31).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual SI getTransactionReferenceKey(int rep)
		{
			SI ret = null;
			try
			{
				Type t = this.getField(31, rep);
				ret = (SI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Transaction Reference Key (FT1-31).</summary>
		public virtual SI[] getTransactionReferenceKey()
		{
			SI[] ret = null;
			try
			{
				Type[] t = this.getField(31);
				ret = new SI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (SI) t[i];
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