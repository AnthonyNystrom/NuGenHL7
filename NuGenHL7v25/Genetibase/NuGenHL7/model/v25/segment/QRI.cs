using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 QRI message segment. 
	/// This segment has the following fields:</p><p>
	/// QRI-1: Candidate Confidence (NM)<br> 
	/// QRI-2: Match Reason Code (IS)<br> 
	/// QRI-3: Algorithm Descriptor (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class QRI:AbstractSegment
	{
		/// <summary> Returns Candidate Confidence (QRI-1).</summary>
		virtual public NM CandidateConfidence
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
		/// <summary> Returns Algorithm Descriptor (QRI-3).</summary>
		virtual public CE AlgorithmDescriptor
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
		
		/// <summary> Creates a QRI (Query Response Instance) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public QRI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 392});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Match Reason Code (QRI-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getMatchReasonCode(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Match Reason Code (QRI-2).</summary>
		public virtual IS[] getMatchReasonCode()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(2);
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
	}
}