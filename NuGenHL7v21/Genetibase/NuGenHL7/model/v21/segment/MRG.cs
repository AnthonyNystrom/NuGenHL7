using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 MRG message segment. 
	/// This segment has the following fields:</p><p>
	/// MRG-1: PRIOR PATIENT ID - INTERNAL (CK)<br> 
	/// MRG-2: PRIOR ALTERNATE PATIENT ID (CK)<br> 
	/// MRG-3: PRIOR PATIENT ACCOUNT NUMBER (CK)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MRG:AbstractSegment
	{
		/// <summary> Returns PRIOR PATIENT ID - INTERNAL (MRG-1).</summary>
		virtual public CK PRIORPATIENTIDINTERNAL
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (CK) t;
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
		/// <summary> Returns PRIOR ALTERNATE PATIENT ID (MRG-2).</summary>
		virtual public CK PRIORALTERNATEPATIENTID
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CK) t;
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
		/// <summary> Returns PRIOR PATIENT ACCOUNT NUMBER (MRG-3).</summary>
		virtual public CK PRIORPATIENTACCOUNTNUMBER
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CK) t;
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
		
		/// <summary> Creates a MRG (MERGE PATIENT INFORMATION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public MRG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CK), true, 1, 16, new System.Object[]{message});
				this.add(typeof(CK), false, 1, 16, new System.Object[]{message});
				this.add(typeof(CK), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}