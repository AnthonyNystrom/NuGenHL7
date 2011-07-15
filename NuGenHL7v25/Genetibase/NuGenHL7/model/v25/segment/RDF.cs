using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 RDF message segment. 
	/// This segment has the following fields:</p><p>
	/// RDF-1: Number of Columns per Row (NM)<br> 
	/// RDF-2: Column Description (RCD)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RDF:AbstractSegment
	{
		/// <summary> Returns Number of Columns per Row (RDF-1).</summary>
		virtual public NM NumberOfColumnsPerRow
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
		
		/// <summary> Creates a RDF (Table Row Definition) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RDF(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), true, 1, 3, new System.Object[]{message});
				this.add(typeof(RCD), true, 0, 40, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Column Description (RDF-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual RCD getColumnDescription(int rep)
		{
			RCD ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (RCD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Column Description (RDF-2).</summary>
		public virtual RCD[] getColumnDescription()
		{
			RCD[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new RCD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (RCD) t[i];
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