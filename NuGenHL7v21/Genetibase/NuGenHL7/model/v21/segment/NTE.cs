using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 NTE message segment. 
	/// This segment has the following fields:</p><p>
	/// NTE-1: SET ID - NOTES AND COMMENTS (SI)<br> 
	/// NTE-2: SOURCE OF COMMENT (ID)<br> 
	/// NTE-3: COMMENT (TX)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NTE:AbstractSegment
	{
		/// <summary> Returns SET ID - NOTES AND COMMENTS (NTE-1).</summary>
		virtual public SI SETIDNOTESANDCOMMENTS
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
		/// <summary> Returns SOURCE OF COMMENT (NTE-2).</summary>
		virtual public ID SOURCEOFCOMMENT
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
		
		/// <summary> Creates a NTE (NOTES AND COMMENTS) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 105});
				this.add(typeof(TX), true, 0, 120, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of COMMENT (NTE-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TX getCOMMENT(int rep)
		{
			TX ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (TX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of COMMENT (NTE-3).</summary>
		public virtual TX[] getCOMMENT()
		{
			TX[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
	}
}