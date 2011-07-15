using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 OM3 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM3-1: Sequence Number - Test/Observation Master File (NM)<br> 
	/// OM3-2: Preferred Coding System (CE)<br> 
	/// OM3-3: Valid Coded "Answers" (CE)<br> 
	/// OM3-4: Normal Text/Codes for Categorical Observations (CE)<br> 
	/// OM3-5: Abnormal Text/Codes for Categorical Observations (CE)<br> 
	/// OM3-6: Critical Text/Codes for Categorical Observations (CE)<br> 
	/// OM3-7: Value Type (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM3:AbstractSegment
	{
		/// <summary> Returns Sequence Number - Test/Observation Master File (OM3-1).</summary>
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
		/// <summary> Returns Preferred Coding System (OM3-2).</summary>
		virtual public CE PreferredCodingSystem
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
		/// <summary> Returns Valid Coded "Answers" (OM3-3).</summary>
		virtual public CE ValidCodedAnswers
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
		/// <summary> Returns Value Type (OM3-7).</summary>
		virtual public ID ValueType
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
		
		/// <summary> Creates a OM3 (Categorical Service/Test/Observation) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM3(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 125});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Normal Text/Codes for Categorical Observations (OM3-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getNormalTextCodesForCategoricalObservations(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Normal Text/Codes for Categorical Observations (OM3-4).</summary>
		public virtual CE[] getNormalTextCodesForCategoricalObservations()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Abnormal Text/Codes for Categorical Observations (OM3-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getAbnormalTextCodesForCategoricalObservations(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Abnormal Text/Codes for Categorical Observations (OM3-5).</summary>
		public virtual CE[] getAbnormalTextCodesForCategoricalObservations()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of Critical Text/Codes for Categorical Observations (OM3-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCriticalTextCodesForCategoricalObservations(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Critical Text/Codes for Categorical Observations (OM3-6).</summary>
		public virtual CE[] getCriticalTextCodesForCategoricalObservations()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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