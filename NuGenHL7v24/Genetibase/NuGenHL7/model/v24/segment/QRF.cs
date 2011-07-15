using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 QRF message segment. 
	/// This segment has the following fields:</p><p>
	/// QRF-1: Where Subject Filter (ST)<br> 
	/// QRF-2: When Data Start Date/Time (TS)<br> 
	/// QRF-3: When Data End Date/Time (TS)<br> 
	/// QRF-4: What User Qualifier (ST)<br> 
	/// QRF-5: Other QRY Subject Filter (ST)<br> 
	/// QRF-6: Which Date/Time Qualifier (ID)<br> 
	/// QRF-7: Which Date/Time Status Qualifier (ID)<br> 
	/// QRF-8: Date/Time Selection Qualifier (ID)<br> 
	/// QRF-9: When Quantity/Timing Qualifier (TQ)<br> 
	/// QRF-10: Search Confidence Threshold (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class QRF:AbstractSegment
	{
		/// <summary> Returns When Data Start Date/Time (QRF-2).</summary>
		virtual public TS WhenDataStartDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns When Data End Date/Time (QRF-3).</summary>
		virtual public TS WhenDataEndDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns When Quantity/Timing Qualifier (QRF-9).</summary>
		virtual public TQ WhenQuantityTimingQualifier
		{
			get
			{
				TQ ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (TQ) t;
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
		/// <summary> Returns Search Confidence Threshold (QRF-10).</summary>
		virtual public NM SearchConfidenceThreshold
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
		
		/// <summary> Creates a QRF (Original Style Query Filter) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public QRF(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 0, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 156});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 157});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 158});
				this.add(typeof(TQ), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Where Subject Filter (QRF-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getWhereSubjectFilter(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Where Subject Filter (QRF-1).</summary>
		public virtual ST[] getWhereSubjectFilter()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(1);
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
		
		/// <summary> Returns a single repetition of What User Qualifier (QRF-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getWhatUserQualifier(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of What User Qualifier (QRF-4).</summary>
		public virtual ST[] getWhatUserQualifier()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Other QRY Subject Filter (QRF-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getOtherQRYSubjectFilter(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Other QRY Subject Filter (QRF-5).</summary>
		public virtual ST[] getOtherQRYSubjectFilter()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of Which Date/Time Qualifier (QRF-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getWhichDateTimeQualifier(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Which Date/Time Qualifier (QRF-6).</summary>
		public virtual ID[] getWhichDateTimeQualifier()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of Which Date/Time Status Qualifier (QRF-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getWhichDateTimeStatusQualifier(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Which Date/Time Status Qualifier (QRF-7).</summary>
		public virtual ID[] getWhichDateTimeStatusQualifier()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of Date/Time Selection Qualifier (QRF-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getDateTimeSelectionQualifier(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Date/Time Selection Qualifier (QRF-8).</summary>
		public virtual ID[] getDateTimeSelectionQualifier()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
	}
}