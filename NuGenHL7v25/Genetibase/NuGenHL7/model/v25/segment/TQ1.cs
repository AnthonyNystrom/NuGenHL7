using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 TQ1 message segment. 
	/// This segment has the following fields:</p><p>
	/// TQ1-1: Set ID - TQ1 (SI)<br> 
	/// TQ1-2: Quantity (CQ)<br> 
	/// TQ1-3: Repeat Pattern (RPT)<br> 
	/// TQ1-4: Explicit Time (TM)<br> 
	/// TQ1-5: Relative Time and Units (CQ)<br> 
	/// TQ1-6: Service Duration (CQ)<br> 
	/// TQ1-7: Start date/time (TS)<br> 
	/// TQ1-8: End date/time (TS)<br> 
	/// TQ1-9: Priority (CWE)<br> 
	/// TQ1-10: Condition text (TX)<br> 
	/// TQ1-11: Text instruction (TX)<br> 
	/// TQ1-12: Conjunction (ID)<br> 
	/// TQ1-13: Occurrence duration (CQ)<br> 
	/// TQ1-14: Total occurrence's (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class TQ1:AbstractSegment
	{
		/// <summary> Returns Set ID - TQ1 (TQ1-1).</summary>
		virtual public SI SetIDTQ1
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
		/// <summary> Returns Quantity (TQ1-2).</summary>
		virtual public CQ Quantity
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Service Duration (TQ1-6).</summary>
		virtual public CQ ServiceDuration
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
		/// <summary> Returns Start date/time (TQ1-7).</summary>
		virtual public TS StartDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns End date/time (TQ1-8).</summary>
		virtual public TS EndDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Condition text (TQ1-10).</summary>
		virtual public TX ConditionText
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (TX) t;
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
		/// <summary> Returns Text instruction (TQ1-11).</summary>
		virtual public TX TextInstruction
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (TX) t;
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
		/// <summary> Returns Conjunction (TQ1-12).</summary>
		virtual public ID Conjunction
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
		/// <summary> Returns Occurrence duration (TQ1-13).</summary>
		virtual public CQ OccurrenceDuration
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Total occurrence's (TQ1-14).</summary>
		virtual public NM TotalOccurrenceS
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		
		/// <summary> Creates a TQ1 (Timing/Quantity) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public TQ1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(RPT), false, 0, 540, new System.Object[]{message});
				this.add(typeof(TM), false, 0, 20, new System.Object[]{message});
				this.add(typeof(CQ), false, 0, 20, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 427});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Repeat Pattern (TQ1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual RPT getRepeatPattern(int rep)
		{
			RPT ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (RPT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Repeat Pattern (TQ1-3).</summary>
		public virtual RPT[] getRepeatPattern()
		{
			RPT[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new RPT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (RPT) t[i];
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
		
		/// <summary> Returns a single repetition of Explicit Time (TQ1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TM getExplicitTime(int rep)
		{
			TM ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (TM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Explicit Time (TQ1-4).</summary>
		public virtual TM[] getExplicitTime()
		{
			TM[] ret = null;
			try
			{
				Type[] t = this.getField(4);
				ret = new TM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TM) t[i];
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
		
		/// <summary> Returns a single repetition of Relative Time and Units (TQ1-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CQ getRelativeTimeAndUnits(int rep)
		{
			CQ ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (CQ) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Relative Time and Units (TQ1-5).</summary>
		public virtual CQ[] getRelativeTimeAndUnits()
		{
			CQ[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new CQ[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CQ) t[i];
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
		
		/// <summary> Returns a single repetition of Priority (TQ1-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getPriority(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Priority (TQ1-9).</summary>
		public virtual CWE[] getPriority()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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