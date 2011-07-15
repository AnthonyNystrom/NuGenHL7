using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 UB2 message segment. 
	/// This segment has the following fields:</p><p>
	/// UB2-1: Set ID - UB2 (SI)<br> 
	/// UB2-2: Co-Insurance Days (9) (ST)<br> 
	/// UB2-3: Condition Code (24-30) (IS)<br> 
	/// UB2-4: Covered Days (7) (ST)<br> 
	/// UB2-5: Non-Covered Days (8) (ST)<br> 
	/// UB2-6: Value Amount & Code (UVC)<br> 
	/// UB2-7: Occurrence Code & Date (32-35) (OCD)<br> 
	/// UB2-8: Occurrence Span Code/Dates (36) (OSP)<br> 
	/// UB2-9: UB92 Locator 2 (State) (ST)<br> 
	/// UB2-10: UB92 Locator 11 (State) (ST)<br> 
	/// UB2-11: UB92 Locator 31 (National) (ST)<br> 
	/// UB2-12: Document Control Number (ST)<br> 
	/// UB2-13: UB92 Locator 49 (National) (ST)<br> 
	/// UB2-14: UB92 Locator 56 (State) (ST)<br> 
	/// UB2-15: UB92 Locator 57 (National) (ST)<br> 
	/// UB2-16: UB92 Locator 78 (State) (ST)<br> 
	/// UB2-17: Special Visit Count (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class UB2:AbstractSegment
	{
		/// <summary> Returns Set ID - UB2 (UB2-1).</summary>
		virtual public SI SetIDUB2
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
		/// <summary> Returns Co-Insurance Days (9) (UB2-2).</summary>
		virtual public ST CoInsuranceDays9
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
		/// <summary> Returns Covered Days (7) (UB2-4).</summary>
		virtual public ST CoveredDays7
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
		/// <summary> Returns Non-Covered Days (8) (UB2-5).</summary>
		virtual public ST NonCoveredDays8
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
		/// <summary> Returns UB92 Locator 31 (National) (UB2-11).</summary>
		virtual public ST UB92Locator31National
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
		/// <summary> Returns UB92 Locator 57 (National) (UB2-15).</summary>
		virtual public ST UB92Locator57National
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Special Visit Count (UB2-17).</summary>
		virtual public NM SpecialVisitCount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		
		/// <summary> Creates a UB2 (UB2 - UB92 data segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public UB2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(IS), false, 7, 2, new System.Object[]{message, 43});
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 4, new System.Object[]{message});
				this.add(typeof(UVC), false, 12, 11, new System.Object[]{message});
				this.add(typeof(OCD), false, 8, 11, new System.Object[]{message});
				this.add(typeof(OSP), false, 2, 28, new System.Object[]{message});
				this.add(typeof(ST), false, 2, 29, new System.Object[]{message});
				this.add(typeof(ST), false, 2, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 5, new System.Object[]{message});
				this.add(typeof(ST), false, 3, 23, new System.Object[]{message});
				this.add(typeof(ST), false, 23, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 5, 14, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 27, new System.Object[]{message});
				this.add(typeof(ST), false, 2, 2, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Condition Code (24-30) (UB2-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getConditionCode2430(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Condition Code (24-30) (UB2-3).</summary>
		public virtual IS[] getConditionCode2430()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Value Amount & Code (UB2-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual UVC getValueAmountCode(int rep)
		{
			UVC ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (UVC) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Value Amount & Code (UB2-6).</summary>
		public virtual UVC[] getValueAmountCode()
		{
			UVC[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of Occurrence Code & Date (32-35) (UB2-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual OCD getOccurrenceCodeDate3235(int rep)
		{
			OCD ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (OCD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Occurrence Code & Date (32-35) (UB2-7).</summary>
		public virtual OCD[] getOccurrenceCodeDate3235()
		{
			OCD[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of Occurrence Span Code/Dates (36) (UB2-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual OSP getOccurrenceSpanCodeDates(int rep)
		{
			OSP ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (OSP) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Occurrence Span Code/Dates (36) (UB2-8).</summary>
		public virtual OSP[] getOccurrenceSpanCodeDates()
		{
			OSP[] ret = null;
			try
			{
				Type[] t = this.getField(8);
				ret = new OSP[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (OSP) t[i];
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
		
		/// <summary> Returns a single repetition of UB92 Locator 2 (State) (UB2-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getUB92Locator2State(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of UB92 Locator 2 (State) (UB2-9).</summary>
		public virtual ST[] getUB92Locator2State()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of UB92 Locator 11 (State) (UB2-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getUB92Locator11State(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of UB92 Locator 11 (State) (UB2-10).</summary>
		public virtual ST[] getUB92Locator11State()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of Document Control Number (UB2-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getDocumentControlNumber(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Document Control Number (UB2-12).</summary>
		public virtual ST[] getDocumentControlNumber()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(12);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of UB92 Locator 49 (National) (UB2-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getUB92Locator49National(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of UB92 Locator 49 (National) (UB2-13).</summary>
		public virtual ST[] getUB92Locator49National()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(13);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of UB92 Locator 56 (State) (UB2-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getUB92Locator56State(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of UB92 Locator 56 (State) (UB2-14).</summary>
		public virtual ST[] getUB92Locator56State()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(14);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of UB92 Locator 78 (State) (UB2-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getUB92Locator78State(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of UB92 Locator 78 (State) (UB2-16).</summary>
		public virtual ST[] getUB92Locator78State()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(16);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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