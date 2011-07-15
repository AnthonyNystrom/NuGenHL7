using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 UB1 message segment. 
	/// This segment has the following fields:</p><p>
	/// UB1-1: Set ID - UB1 (SI)<br> 
	/// UB1-2: Blood Deductible  (43) (NM)<br> 
	/// UB1-3: Blood Furnished-Pints Of (40) (NM)<br> 
	/// UB1-4: Blood Replaced-Pints (41) (NM)<br> 
	/// UB1-5: Blood Not Replaced-Pints(42) (NM)<br> 
	/// UB1-6: Co-Insurance Days (25) (NM)<br> 
	/// UB1-7: Condition Code (35-39) (IS)<br> 
	/// UB1-8: Covered Days - (23) (NM)<br> 
	/// UB1-9: Non Covered Days - (24) (NM)<br> 
	/// UB1-10: Value Amount & Code (46-49) (UVC)<br> 
	/// UB1-11: Number Of Grace Days (90) (NM)<br> 
	/// UB1-12: Special Program Indicator (44) (CE)<br> 
	/// UB1-13: PSRO/UR Approval Indicator (87) (CE)<br> 
	/// UB1-14: PSRO/UR Approved Stay-Fm (88) (DT)<br> 
	/// UB1-15: PSRO/UR Approved Stay-To (89) (DT)<br> 
	/// UB1-16: Occurrence (28-32) (OCD)<br> 
	/// UB1-17: Occurrence Span (33) (CE)<br> 
	/// UB1-18: Occur Span Start Date(33) (DT)<br> 
	/// UB1-19: Occur Span End Date (33) (DT)<br> 
	/// UB1-20: UB-82 Locator 2 (ST)<br> 
	/// UB1-21: UB-82 Locator 9 (ST)<br> 
	/// UB1-22: UB-82 Locator 27 (ST)<br> 
	/// UB1-23: UB-82 Locator 45 (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class UB1:AbstractSegment
	{
		/// <summary> Returns Set ID - UB1 (UB1-1).</summary>
		virtual public SI SetIDUB1
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
		/// <summary> Returns Blood Deductible  (43) (UB1-2).</summary>
		virtual public NM BloodDeductible
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Blood Furnished-Pints Of (40) (UB1-3).</summary>
		virtual public NM BloodFurnishedPintsOf
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Blood Replaced-Pints (41) (UB1-4).</summary>
		virtual public NM BloodReplacedPints
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Blood Not Replaced-Pints(42) (UB1-5).</summary>
		virtual public NM BloodNotReplacedPints
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Co-Insurance Days (25) (UB1-6).</summary>
		virtual public NM CoInsuranceDays
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Covered Days - (23) (UB1-8).</summary>
		virtual public NM CoveredDays
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
		/// <summary> Returns Non Covered Days - (24) (UB1-9).</summary>
		virtual public NM NonCoveredDays
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Number Of Grace Days (90) (UB1-11).</summary>
		virtual public NM NumberOfGraceDays
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
		/// <summary> Returns Special Program Indicator (44) (UB1-12).</summary>
		virtual public CE SpecialProgramIndicator
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns PSRO/UR Approval Indicator (87) (UB1-13).</summary>
		virtual public CE PSROURApprovalIndicator
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
		/// <summary> Returns PSRO/UR Approved Stay-Fm (88) (UB1-14).</summary>
		virtual public DT PSROURApprovedStayFm
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
		/// <summary> Returns PSRO/UR Approved Stay-To (89) (UB1-15).</summary>
		virtual public DT PSROURApprovedStayTo
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
		/// <summary> Returns Occurrence Span (33) (UB1-17).</summary>
		virtual public CE OccurrenceSpan
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Occur Span Start Date(33) (UB1-18).</summary>
		virtual public DT OccurSpanStartDate
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
		/// <summary> Returns Occur Span End Date (33) (UB1-19).</summary>
		virtual public DT OccurSpanEndDate
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
		/// <summary> Returns UB-82 Locator 2 (UB1-20).</summary>
		virtual public ST UB82Locator2
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
		/// <summary> Returns UB-82 Locator 9 (UB1-21).</summary>
		virtual public ST UB82Locator9
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
		/// <summary> Returns UB-82 Locator 27 (UB1-22).</summary>
		virtual public ST UB82Locator27
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
		/// <summary> Returns UB-82 Locator 45 (UB1-23).</summary>
		virtual public ST UB82Locator45
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
		
		/// <summary> Creates a UB1 (UB1 - UB82 data segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public UB1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 1, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(IS), false, 5, 14, new System.Object[]{message, 43});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(UVC), false, 8, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(OCD), false, 5, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
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
		
		/// <summary> Returns a single repetition of Condition Code (35-39) (UB1-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getConditionCode3539(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Condition Code (35-39) (UB1-7).</summary>
		public virtual IS[] getConditionCode3539()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Value Amount & Code (46-49) (UB1-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual UVC getValueAmountCode4649(int rep)
		{
			UVC ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (UVC) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Value Amount & Code (46-49) (UB1-10).</summary>
		public virtual UVC[] getValueAmountCode4649()
		{
			UVC[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new UVC[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (UVC) t[i];
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
		
		/// <summary> Returns a single repetition of Occurrence (28-32) (UB1-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual OCD getOccurrence2832(int rep)
		{
			OCD ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (OCD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Occurrence (28-32) (UB1-16).</summary>
		public virtual OCD[] getOccurrence2832()
		{
			OCD[] ret = null;
			try
			{
				Type[] t = this.getField(16);
				ret = new OCD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (OCD) t[i];
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