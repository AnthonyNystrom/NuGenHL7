using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 NTE message segment. 
	/// This segment has the following fields:</p><p>
	/// NTE-1: Set ID - NTE (SI)<br> 
	/// NTE-2: Source of Comment (ID)<br> 
	/// NTE-3: Comment (FT)<br> 
	/// NTE-4: Comment Type (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NTE:AbstractSegment
	{
		/// <summary> Returns Set ID - NTE (NTE-1).</summary>
		virtual public SI SetIDNTE
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
		/// <summary> Returns Source of Comment (NTE-2).</summary>
		virtual public ID SourceOfComment
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
		/// <summary> Returns Comment Type (NTE-4).</summary>
		virtual public CE CommentType
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
		
		/// <summary> Creates a NTE (NTE - notes and comments segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NTE(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 105});
				this.add(typeof(FT), false, 0, 65536, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Comment (NTE-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FT getComment(int rep)
		{
			FT ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (FT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Comment (NTE-3).</summary>
		public virtual FT[] getComment()
		{
			FT[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new FT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FT) t[i];
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