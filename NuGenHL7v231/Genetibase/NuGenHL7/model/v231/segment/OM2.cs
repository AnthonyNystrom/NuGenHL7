using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 OM2 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM2-1: Sequence Number - Test/Observation Master File (NM)<br> 
	/// OM2-2: Units of Measure (CE)<br> 
	/// OM2-3: Range of Decimal Precision (NM)<br> 
	/// OM2-4: Corresponding SI Units of Measure (CE)<br> 
	/// OM2-5: SI Conversion Factor (TX)<br> 
	/// OM2-6: Reference (Normal) Range - Ordinal & Continuous Obs (RFR)<br> 
	/// OM2-7: Critical Range for Ordinal & Continuous Obs (NR)<br> 
	/// OM2-8: Absolute Range for Ordinal & Continuous Obs (RFR)<br> 
	/// OM2-9: Delta Check Criteria (DLT)<br> 
	/// OM2-10: Minimum Meaningful Increments (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM2:AbstractSegment
	{
		/// <summary> Returns Sequence Number - Test/Observation Master File (OM2-1).</summary>
		virtual public NM SequenceNumberTestObservationMasterFile
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Units of Measure (OM2-2).</summary>
		virtual public CE UnitsOfMeasure
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Corresponding SI Units of Measure (OM2-4).</summary>
		virtual public CE CorrespondingSIUnitsOfMeasure
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns SI Conversion Factor (OM2-5).</summary>
		virtual public TX SIConversionFactor
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Reference (Normal) Range - Ordinal & Continuous Obs (OM2-6).</summary>
		virtual public RFR ReferenceNormalRangeOrdinalContinuousObs
		{
			get
			{
				RFR ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (RFR) t;
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
		/// <summary> Returns Critical Range for Ordinal & Continuous Obs (OM2-7).</summary>
		virtual public NR CriticalRangeForOrdinalContinuousObs
		{
			get
			{
				NR ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (NR) t;
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
		/// <summary> Returns Absolute Range for Ordinal & Continuous Obs (OM2-8).</summary>
		virtual public RFR AbsoluteRangeForOrdinalContinuousObs
		{
			get
			{
				RFR ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (RFR) t;
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
		/// <summary> Returns Minimum Meaningful Increments (OM2-10).</summary>
		virtual public NM MinimumMeaningfulIncrements
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
		
		/// <summary> Creates a OM2 (OM2 - numeric observation segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 0, 10, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 60, new System.Object[]{message});
				this.add(typeof(RFR), false, 1, 200, new System.Object[]{message});
				this.add(typeof(NR), false, 1, 200, new System.Object[]{message});
				this.add(typeof(RFR), false, 1, 200, new System.Object[]{message});
				this.add(typeof(DLT), false, 0, 200, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Range of Decimal Precision (OM2-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NM getRangeOfDecimalPrecision(int rep)
		{
			NM ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (NM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Range of Decimal Precision (OM2-3).</summary>
		public virtual NM[] getRangeOfDecimalPrecision()
		{
			NM[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new NM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NM) t[i];
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
		
		/// <summary> Returns a single repetition of Delta Check Criteria (OM2-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DLT getDeltaCheckCriteria(int rep)
		{
			DLT ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (DLT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Delta Check Criteria (OM2-9).</summary>
		public virtual DLT[] getDeltaCheckCriteria()
		{
			DLT[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new DLT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (DLT) t[i];
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