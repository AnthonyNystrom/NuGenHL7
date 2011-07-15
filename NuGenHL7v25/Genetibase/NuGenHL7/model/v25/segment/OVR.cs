using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 OVR message segment. 
	/// This segment has the following fields:</p><p>
	/// OVR-1: Business Rule Override Type (CWE)<br> 
	/// OVR-2: Business Rule Override Code (CWE)<br> 
	/// OVR-3: Override Comments (TX)<br> 
	/// OVR-4: Override Entered By (XCN)<br> 
	/// OVR-5: Override Authorized By (XCN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OVR:AbstractSegment
	{
		/// <summary> Returns Business Rule Override Type (OVR-1).</summary>
		virtual public CWE BusinessRuleOverrideType
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Business Rule Override Code (OVR-2).</summary>
		virtual public CWE BusinessRuleOverrideCode
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CWE) t;
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
		/// <summary> Returns Override Comments (OVR-3).</summary>
		virtual public TX OverrideComments
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (TX) t;
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
		/// <summary> Returns Override Entered By (OVR-4).</summary>
		virtual public XCN OverrideEnteredBy
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (XCN) t;
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
		/// <summary> Returns Override Authorized By (OVR-5).</summary>
		virtual public XCN OverrideAuthorizedBy
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (XCN) t;
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
		
		/// <summary> Creates a OVR (Override Segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OVR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CWE), false, 1, 705, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 705, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}