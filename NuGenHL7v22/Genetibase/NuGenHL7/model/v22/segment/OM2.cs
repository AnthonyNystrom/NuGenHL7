using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 OM2 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM2-1: Segment Type ID (ST)<br> 
	/// OM2-2: Sequence Number - Test/ Observation Master File (NM)<br> 
	/// OM2-3: Units of Measure (CE)<br> 
	/// OM2-4: Range of Decimal Precision (NM)<br> 
	/// OM2-5: Corresponding SI Units of Measure (CE)<br> 
	/// OM2-6: SI Conversion Factor (TX)<br> 
	/// OM2-7: Reference (normal) range - ordinal & continuous observations (CM_RFR)<br> 
	/// OM2-8: Critical range for ordinal and continuous observations (CM_RANGE)<br> 
	/// OM2-9: Absolute range for ordinal and continuous observations (CM_ABS_RANGE)<br> 
	/// OM2-10: Delta Check Criteria (CM_DLT)<br> 
	/// OM2-11: Minimum Meaningful Increments (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM2:AbstractSegment
	{
		/// <summary> Returns Segment Type ID (OM2-1).</summary>
		virtual public ST SegmentTypeID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Sequence Number - Test/ Observation Master File (OM2-2).</summary>
		virtual public NM SequenceNumberTestObservationMasterFile
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
		/// <summary> Returns Units of Measure (OM2-3).</summary>
		virtual public CE UnitsOfMeasure
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Range of Decimal Precision (OM2-4).</summary>
		virtual public NM RangeOfDecimalPrecision
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
		/// <summary> Returns Corresponding SI Units of Measure (OM2-5).</summary>
		virtual public CE CorrespondingSIUnitsOfMeasure
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Critical range for ordinal and continuous observations (OM2-8).</summary>
		virtual public CM_RANGE CriticalRangeForOrdinalAndContinuousObservations
		{
			get
			{
				CM_RANGE ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (CM_RANGE) t;
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
		/// <summary> Returns Absolute range for ordinal and continuous observations (OM2-9).</summary>
		virtual public CM_ABS_RANGE AbsoluteRangeForOrdinalAndContinuousObservations
		{
			get
			{
				CM_ABS_RANGE ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (CM_ABS_RANGE) t;
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
		/// <summary> Returns Minimum Meaningful Increments (OM2-11).</summary>
		virtual public NM MinimumMeaningfulIncrements
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
		
		/// <summary> Creates a OM2 (NUMERIC OBSERVATION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TX), true, 0, 20, new System.Object[]{message});
				this.add(typeof(CM_RFR), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CM_RANGE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CM_ABS_RANGE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CM_DLT), false, 0, 200, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of SI Conversion Factor (OM2-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TX getSIConversionFactor(int rep)
		{
			TX ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (TX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of SI Conversion Factor (OM2-6).</summary>
		public virtual TX[] getSIConversionFactor()
		{
			TX[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of Reference (normal) range - ordinal & continuous observations (OM2-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_RFR getReferenceNormalRangeOrdinalContinuousObservations(int rep)
		{
			CM_RFR ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (CM_RFR) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Reference (normal) range - ordinal & continuous observations (OM2-7).</summary>
		public virtual CM_RFR[] getReferenceNormalRangeOrdinalContinuousObservations()
		{
			CM_RFR[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new CM_RFR[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_RFR) t[i];
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
		
		/// <summary> Returns a single repetition of Delta Check Criteria (OM2-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_DLT getDeltaCheckCriteria(int rep)
		{
			CM_DLT ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (CM_DLT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Delta Check Criteria (OM2-10).</summary>
		public virtual CM_DLT[] getDeltaCheckCriteria()
		{
			CM_DLT[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new CM_DLT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_DLT) t[i];
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