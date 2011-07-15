using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 QRD message segment. 
	/// This segment has the following fields:</p><p>
	/// QRD-1: Query date / time (TS)<br> 
	/// QRD-2: Query Format Code (ID)<br> 
	/// QRD-3: Query Priority (ID)<br> 
	/// QRD-4: Query ID (ST)<br> 
	/// QRD-5: Deferred Response Type (ID)<br> 
	/// QRD-6: Deferred response date / time (TS)<br> 
	/// QRD-7: Quantity Limited Request (CQ_QUANTITY)<br> 
	/// QRD-8: Who Subject Filter (ST)<br> 
	/// QRD-9: What Subject Filter (ID)<br> 
	/// QRD-10: What Department Data Code (ST)<br> 
	/// QRD-11: What data code value qualifier (ST)<br> 
	/// QRD-12: Query Results Level (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class QRD:AbstractSegment
	{
		/// <summary> Returns Query date / time (QRD-1).</summary>
		virtual public TS QueryDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Query Format Code (QRD-2).</summary>
		virtual public ID QueryFormatCode
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
		/// <summary> Returns Query Priority (QRD-3).</summary>
		virtual public ID QueryPriority
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Query ID (QRD-4).</summary>
		virtual public ST QueryID
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
		/// <summary> Returns Deferred Response Type (QRD-5).</summary>
		virtual public ID DeferredResponseType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Deferred response date / time (QRD-6).</summary>
		virtual public TS DeferredResponseDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Quantity Limited Request (QRD-7).</summary>
		virtual public CQ QuantityLimitedRequest
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Query Results Level (QRD-12).</summary>
		virtual public ID QueryResultsLevel
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
		
		/// <summary> Creates a QRD (QUERY DEFINITION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public QRD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 106});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 91});
				this.add(typeof(ST), true, 1, 10, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 107});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CQ), true, 1, 10, new System.Object[]{message});
				this.add(typeof(ST), true, 0, 20, new System.Object[]{message});
				this.add(typeof(ID), true, 0, 3, new System.Object[]{message, 48});
				this.add(typeof(ST), true, 0, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 108});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Who Subject Filter (QRD-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getWhoSubjectFilter(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Who Subject Filter (QRD-8).</summary>
		public virtual ST[] getWhoSubjectFilter()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
		
		/// <summary> Returns a single repetition of What Subject Filter (QRD-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getWhatSubjectFilter(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of What Subject Filter (QRD-9).</summary>
		public virtual ID[] getWhatSubjectFilter()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
		
		/// <summary> Returns a single repetition of What Department Data Code (QRD-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getWhatDepartmentDataCode(int rep)
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
		
		/// <summary> Returns all repetitions of What Department Data Code (QRD-10).</summary>
		public virtual ST[] getWhatDepartmentDataCode()
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
		
		/// <summary> Returns a single repetition of What data code value qualifier (QRD-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getWhatDataCodeValueQualifier(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of What data code value qualifier (QRD-11).</summary>
		public virtual ST[] getWhatDataCodeValueQualifier()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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