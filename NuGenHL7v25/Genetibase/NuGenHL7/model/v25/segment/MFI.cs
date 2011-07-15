using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 MFI message segment. 
	/// This segment has the following fields:</p><p>
	/// MFI-1: Master File Identifier (CE)<br> 
	/// MFI-2: Master File Application Identifier (HD)<br> 
	/// MFI-3: File-Level Event Code (ID)<br> 
	/// MFI-4: Entered Date/Time (TS)<br> 
	/// MFI-5: Effective Date/Time (TS)<br> 
	/// MFI-6: Response Level Code (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MFI:AbstractSegment
	{
		/// <summary> Returns Master File Identifier (MFI-1).</summary>
		virtual public CE MasterFileIdentifier
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Master File Application Identifier (MFI-2).</summary>
		virtual public HD MasterFileApplicationIdentifier
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (HD) t;
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
		/// <summary> Returns File-Level Event Code (MFI-3).</summary>
		virtual public ID FileLevelEventCode
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
		/// <summary> Returns Entered Date/Time (MFI-4).</summary>
		virtual public TS EnteredDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Effective Date/Time (MFI-5).</summary>
		virtual public TS EffectiveDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Response Level Code (MFI-6).</summary>
		virtual public ID ResponseLevelCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		
		/// <summary> Creates a MFI (Master File Identification) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public MFI(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 180, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 3, new System.Object[]{message, 178});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 179});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}