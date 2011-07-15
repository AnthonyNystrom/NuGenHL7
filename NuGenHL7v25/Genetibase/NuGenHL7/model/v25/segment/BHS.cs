using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 BHS message segment. 
	/// This segment has the following fields:</p><p>
	/// BHS-1: Batch Field Separator (ST)<br> 
	/// BHS-2: Batch Encoding Characters (ST)<br> 
	/// BHS-3: Batch Sending Application (HD)<br> 
	/// BHS-4: Batch Sending Facility (HD)<br> 
	/// BHS-5: Batch Receiving Application (HD)<br> 
	/// BHS-6: Batch Receiving Facility (HD)<br> 
	/// BHS-7: Batch Creation Date/Time (TS)<br> 
	/// BHS-8: Batch Security (ST)<br> 
	/// BHS-9: Batch Name/ID/Type (ST)<br> 
	/// BHS-10: Batch Comment (ST)<br> 
	/// BHS-11: Batch Control ID (ST)<br> 
	/// BHS-12: Reference Batch Control ID (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class BHS:AbstractSegment
	{
		/// <summary> Returns Batch Field Separator (BHS-1).</summary>
		virtual public ST BatchFieldSeparator
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Batch Encoding Characters (BHS-2).</summary>
		virtual public ST BatchEncodingCharacters
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
		/// <summary> Returns Batch Sending Application (BHS-3).</summary>
		virtual public HD BatchSendingApplication
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Batch Sending Facility (BHS-4).</summary>
		virtual public HD BatchSendingFacility
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Batch Receiving Application (BHS-5).</summary>
		virtual public HD BatchReceivingApplication
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Batch Receiving Facility (BHS-6).</summary>
		virtual public HD BatchReceivingFacility
		{
			get
			{
				HD ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Batch Creation Date/Time (BHS-7).</summary>
		virtual public TS BatchCreationDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Batch Security (BHS-8).</summary>
		virtual public ST BatchSecurity
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Batch Name/ID/Type (BHS-9).</summary>
		virtual public ST BatchNameIDType
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Batch Comment (BHS-10).</summary>
		virtual public ST BatchComment
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Batch Control ID (BHS-11).</summary>
		virtual public ST BatchControlID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Reference Batch Control ID (BHS-12).</summary>
		virtual public ST ReferenceBatchControlID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		
		/// <summary> Creates a BHS (Batch Header) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public BHS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 1, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 3, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 227, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 227, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 227, new System.Object[]{message});
				this.add(typeof(HD), false, 1, 227, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}