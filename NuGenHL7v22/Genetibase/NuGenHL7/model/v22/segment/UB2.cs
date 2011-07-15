using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 UB2 message segment. 
	/// This segment has the following fields:</p><p>
	/// UB2-1: Set ID - UB92 (SI)<br> 
	/// UB2-2: Co-insurance days (9) (ST)<br> 
	/// UB2-3: Condition code (24-30) (ID)<br> 
	/// UB2-4: Covered days (7) (ST)<br> 
	/// UB2-5: Non-covered days (8) (ST)<br> 
	/// UB2-6: Value amount and code (39-41) (CM_UVC)<br> 
	/// UB2-7: Occurrence code and date (32-35) (CM_OCD)<br> 
	/// UB2-8: Occurrence span code / dates (36) (CM_OSP)<br> 
	/// UB2-9: UB92 locator 2 (state) (ST)<br> 
	/// UB2-10: UB92 locator 11 (state) (ST)<br> 
	/// UB2-11: UB92 locator 31 (national) (ST)<br> 
	/// UB2-12: Document control number (37) (ST)<br> 
	/// UB2-13: UB92 locator 49 (national) (ST)<br> 
	/// UB2-14: UB92 locator 56 (state) (ST)<br> 
	/// UB2-15: UB92 locator 57 (national) (ST)<br> 
	/// UB2-16: UB92 Locator 78 (state) (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class UB2:AbstractSegment
	{
		/// <summary> Returns Set ID - UB92 (UB2-1).</summary>
		virtual public SI SetIDUB92
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
		/// <summary> Returns Co-insurance days (9) (UB2-2).</summary>
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
		/// <summary> Returns Covered days (7) (UB2-4).</summary>
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
		/// <summary> Returns Non-covered days (8) (UB2-5).</summary>
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
		/// <summary> Returns UB92 locator 31 (national) (UB2-11).</summary>
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
		/// <summary> Returns UB92 locator 57 (national) (UB2-15).</summary>
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
		
		/// <summary> Creates a UB2 (UB92 DATA) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public UB2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(ID), false, 7, 2, new System.Object[]{message, 43});
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CM_UVC), false, 12, 11, new System.Object[]{message});
				this.add(typeof(CM_OCD), false, 8, 11, new System.Object[]{message});
				this.add(typeof(CM_OSP), false, 2, 28, new System.Object[]{message});
				this.add(typeof(ST), false, 2, 29, new System.Object[]{message});
				this.add(typeof(ST), false, 2, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 5, new System.Object[]{message});
				this.add(typeof(ST), false, 3, 23, new System.Object[]{message});
				this.add(typeof(ST), false, 23, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 5, 14, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 27, new System.Object[]{message});
				this.add(typeof(ST), false, 2, 2, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Condition code (24-30) (UB2-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getConditionCode2430(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Condition code (24-30) (UB2-3).</summary>
		public virtual ID[] getConditionCode2430()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Value amount and code (39-41) (UB2-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_UVC getValueAmountAndCode3941(int rep)
		{
			CM_UVC ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (CM_UVC) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Value amount and code (39-41) (UB2-6).</summary>
		public virtual CM_UVC[] getValueAmountAndCode3941()
		{
			CM_UVC[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new CM_UVC[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_UVC) t[i];
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
		
		/// <summary> Returns a single repetition of Occurrence code and date (32-35) (UB2-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_OCD getOccurrenceCodeAndDate3235(int rep)
		{
			CM_OCD ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (CM_OCD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Occurrence code and date (32-35) (UB2-7).</summary>
		public virtual CM_OCD[] getOccurrenceCodeAndDate3235()
		{
			CM_OCD[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new CM_OCD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_OCD) t[i];
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
		
		/// <summary> Returns a single repetition of Occurrence span code / dates (36) (UB2-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_OSP getOccurrenceSpanCodeDates(int rep)
		{
			CM_OSP ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (CM_OSP) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Occurrence span code / dates (36) (UB2-8).</summary>
		public virtual CM_OSP[] getOccurrenceSpanCodeDates()
		{
			CM_OSP[] ret = null;
			try
			{
				Type[] t = this.getField(8);
				ret = new CM_OSP[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_OSP) t[i];
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
		
		/// <summary> Returns a single repetition of UB92 locator 2 (state) (UB2-9).</summary>
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
		
		/// <summary> Returns all repetitions of UB92 locator 2 (state) (UB2-9).</summary>
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
		
		/// <summary> Returns a single repetition of UB92 locator 11 (state) (UB2-10).</summary>
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
		
		/// <summary> Returns all repetitions of UB92 locator 11 (state) (UB2-10).</summary>
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
		
		/// <summary> Returns a single repetition of Document control number (37) (UB2-12).</summary>
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
		
		/// <summary> Returns all repetitions of Document control number (37) (UB2-12).</summary>
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
		
		/// <summary> Returns a single repetition of UB92 locator 49 (national) (UB2-13).</summary>
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
		
		/// <summary> Returns all repetitions of UB92 locator 49 (national) (UB2-13).</summary>
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
		
		/// <summary> Returns a single repetition of UB92 locator 56 (state) (UB2-14).</summary>
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
		
		/// <summary> Returns all repetitions of UB92 locator 56 (state) (UB2-14).</summary>
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
		
		/// <summary> Returns a single repetition of UB92 Locator 78 (state) (UB2-16).</summary>
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
		
		/// <summary> Returns all repetitions of UB92 Locator 78 (state) (UB2-16).</summary>
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