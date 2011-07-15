using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 TQ2 message segment. 
	/// This segment has the following fields:</p><p>
	/// TQ2-1: Set ID - TQ2 (SI)<br> 
	/// TQ2-2: Sequence/Results Flag (ID)<br> 
	/// TQ2-3: Related Placer Number (EI)<br> 
	/// TQ2-4: Related Filler Number (EI)<br> 
	/// TQ2-5: Related Placer Group Number (EI)<br> 
	/// TQ2-6: Sequence Condition Code (ID)<br> 
	/// TQ2-7: Cyclic Entry/Exit Indicator (ID)<br> 
	/// TQ2-8: Sequence Condition Time Interval (CQ)<br> 
	/// TQ2-9: Cyclic Group Maximum Number of Repeats (NM)<br> 
	/// TQ2-10: Special Service Request Relationship (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class TQ2:AbstractSegment
	{
		/// <summary> Returns Set ID - TQ2 (TQ2-1).</summary>
		virtual public SI SetIDTQ2
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
		/// <summary> Returns Sequence/Results Flag (TQ2-2).</summary>
		virtual public ID SequenceResultsFlag
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Sequence Condition Code (TQ2-6).</summary>
		virtual public ID SequenceConditionCode
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
		/// <summary> Returns Cyclic Entry/Exit Indicator (TQ2-7).</summary>
		virtual public ID CyclicEntryExitIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Sequence Condition Time Interval (TQ2-8).</summary>
		virtual public CQ SequenceConditionTimeInterval
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Cyclic Group Maximum Number of Repeats (TQ2-9).</summary>
		virtual public NM CyclicGroupMaximumNumberOfRepeats
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
		/// <summary> Returns Special Service Request Relationship (TQ2-10).</summary>
		virtual public ID SpecialServiceRequestRelationship
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
		
		/// <summary> Creates a TQ2 (Timing/Quantity Relationship) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public TQ2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 503});
				this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
				this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
				this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 504});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 505});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 506});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Related Placer Number (TQ2-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EI getRelatedPlacerNumber(int rep)
		{
			EI ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (EI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Related Placer Number (TQ2-3).</summary>
		public virtual EI[] getRelatedPlacerNumber()
		{
			EI[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new EI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EI) t[i];
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
		
		/// <summary> Returns a single repetition of Related Filler Number (TQ2-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EI getRelatedFillerNumber(int rep)
		{
			EI ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (EI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Related Filler Number (TQ2-4).</summary>
		public virtual EI[] getRelatedFillerNumber()
		{
			EI[] ret = null;
			try
			{
				Type[] t = this.getField(4);
				ret = new EI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EI) t[i];
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
		
		/// <summary> Returns a single repetition of Related Placer Group Number (TQ2-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EI getRelatedPlacerGroupNumber(int rep)
		{
			EI ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (EI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Related Placer Group Number (TQ2-5).</summary>
		public virtual EI[] getRelatedPlacerGroupNumber()
		{
			EI[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new EI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EI) t[i];
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