using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 FTS message segment. 
	/// This segment has the following fields:</p><p>
	/// FTS-1: File Batch Count (NM)<br> 
	/// FTS-2: File Trailer Comment (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class FTS:AbstractSegment
	{
		/// <summary> Returns File Batch Count (FTS-1).</summary>
		virtual public NM FileBatchCount
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
		/// <summary> Returns File Trailer Comment (FTS-2).</summary>
		virtual public ST FileTrailerComment
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		
		/// <summary> Creates a FTS (File Trailer) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public FTS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}