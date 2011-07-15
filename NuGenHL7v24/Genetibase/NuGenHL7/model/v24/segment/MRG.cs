using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 MRG message segment. 
	/// This segment has the following fields:</p><p>
	/// MRG-1: Prior Patient Identifier List (CX)<br> 
	/// MRG-2: Prior Alternate Patient ID (CX)<br> 
	/// MRG-3: Prior Patient Account Number (CX)<br> 
	/// MRG-4: Prior Patient ID (CX)<br> 
	/// MRG-5: Prior Visit Number (CX)<br> 
	/// MRG-6: Prior Alternate Visit ID (CX)<br> 
	/// MRG-7: Prior Patient Name (XPN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MRG:AbstractSegment
	{
		/// <summary> Returns Prior Patient Account Number (MRG-3).</summary>
		virtual public CX PriorPatientAccountNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CX) t;
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
		/// <summary> Returns Prior Patient ID (MRG-4).</summary>
		virtual public CX PriorPatientID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CX) t;
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
		/// <summary> Returns Prior Visit Number (MRG-5).</summary>
		virtual public CX PriorVisitNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CX) t;
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
		/// <summary> Returns Prior Alternate Visit ID (MRG-6).</summary>
		virtual public CX PriorAlternateVisitID
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (CX) t;
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
		
		/// <summary> Creates a MRG (Merge patient information) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public MRG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CX), true, 0, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Prior Patient Identifier List (MRG-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getPriorPatientIdentifierList(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Prior Patient Identifier List (MRG-1).</summary>
		public virtual CX[] getPriorPatientIdentifierList()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CX) t[i];
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
		
		/// <summary> Returns a single repetition of Prior Alternate Patient ID (MRG-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getPriorAlternatePatientID(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Prior Alternate Patient ID (MRG-2).</summary>
		public virtual CX[] getPriorAlternatePatientID()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CX) t[i];
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
		
		/// <summary> Returns a single repetition of Prior Patient Name (MRG-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getPriorPatientName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Prior Patient Name (MRG-7).</summary>
		public virtual XPN[] getPriorPatientName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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