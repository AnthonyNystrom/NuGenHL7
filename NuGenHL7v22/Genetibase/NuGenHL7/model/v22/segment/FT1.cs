using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 FT1 message segment. 
	/// This segment has the following fields:</p><p>
	/// FT1-1: Set ID - financial transaction (SI)<br> 
	/// FT1-2: Transaction ID (ST)<br> 
	/// FT1-3: Transaction batch ID (ST)<br> 
	/// FT1-4: Transaction date (DT)<br> 
	/// FT1-5: Transaction posting date (DT)<br> 
	/// FT1-6: Transaction type (ID)<br> 
	/// FT1-7: Transaction code (CE)<br> 
	/// FT1-8: Transaction description (ST)<br> 
	/// FT1-9: Transaction description - alternate (ST)<br> 
	/// FT1-10: Transaction quantity (NM)<br> 
	/// FT1-11: Transaction amount - extended (NM)<br> 
	/// FT1-12: Transaction amount - unit (NM)<br> 
	/// FT1-13: Department code (CE)<br> 
	/// FT1-14: Insurance plan ID (ID)<br> 
	/// FT1-15: Insurance amount (NM)<br> 
	/// FT1-16: Assigned Patient Location (CM_INTERNAL_LOCATION)<br> 
	/// FT1-17: Fee schedule (ID)<br> 
	/// FT1-18: Patient type (ID)<br> 
	/// FT1-19: Diagnosis code (CE)<br> 
	/// FT1-20: Performed by code (CN)<br> 
	/// FT1-21: Ordered by code (CN)<br> 
	/// FT1-22: Unit cost (NM)<br> 
	/// FT1-23: Filler Order Number (CM_FILLER)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class FT1:AbstractSegment
	{
		/// <summary> Returns Set ID - financial transaction (FT1-1).</summary>
		virtual public SI SetIDFinancialTransaction
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
		/// <summary> Returns Transaction batch ID (FT1-3).</summary>
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
		/// <summary> Returns Transaction date (FT1-4).</summary>
		virtual public DT TransactionDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Transaction posting date (FT1-5).</summary>
		virtual public DT TransactionPostingDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Transaction type (FT1-6).</summary>
		virtual public ID TransactionType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Transaction code (FT1-7).</summary>
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
		/// <summary> Returns Transaction description (FT1-8).</summary>
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
		/// <summary> Returns Transaction description - alternate (FT1-9).</summary>
		virtual public ST TransactionDescriptionAlternate
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
		/// <summary> Returns Transaction quantity (FT1-10).</summary>
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
		/// <summary> Returns Transaction amount - extended (FT1-11).</summary>
		virtual public NM TransactionAmountExtended
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
		/// <summary> Returns Transaction amount - unit (FT1-12).</summary>
		virtual public NM TransactionAmountUnit
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Department code (FT1-13).</summary>
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
		/// <summary> Returns Insurance plan ID (FT1-14).</summary>
		virtual public ID InsurancePlanID
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Insurance amount (FT1-15).</summary>
		virtual public NM InsuranceAmount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Assigned Patient Location (FT1-16).</summary>
		virtual public CM_INTERNAL_LOCATION AssignedPatientLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(16, 0);
					ret = (CM_INTERNAL_LOCATION) t;
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
		/// <summary> Returns Fee schedule (FT1-17).</summary>
		virtual public ID FeeSchedule
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
		/// <summary> Returns Patient type (FT1-18).</summary>
		virtual public ID PatientType
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
		/// <summary> Returns Performed by code (FT1-20).</summary>
		virtual public CN PerformedByCode
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (CN) t;
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
		/// <summary> Returns Ordered by code (FT1-21).</summary>
		virtual public CN OrderedByCode
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (CN) t;
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
		/// <summary> Returns Unit cost (FT1-22).</summary>
		virtual public NM UnitCost
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Filler Order Number (FT1-23).</summary>
		virtual public CM_FILLER FillerOrderNumber
		{
			get
			{
				CM_FILLER ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (CM_FILLER) t;
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
		
		/// <summary> Creates a FT1 (FINANCIAL TRANSACTION) segment object that belongs to the given 
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
				this.add(typeof(DT), true, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 17});
				this.add(typeof(CE), true, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 72});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 24});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18});
				this.add(typeof(CE), false, 0, 8, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CM_FILLER), false, 1, 75, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Diagnosis code (FT1-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getDiagnosisCode(int rep)
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
		
		/// <summary> Returns all repetitions of Diagnosis code (FT1-19).</summary>
		public virtual CE[] getDiagnosisCode()
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
	}
}