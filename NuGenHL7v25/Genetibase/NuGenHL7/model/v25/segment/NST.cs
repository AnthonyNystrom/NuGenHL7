using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 NST message segment. 
	/// This segment has the following fields:</p><p>
	/// NST-1: Statistics Available (ID)<br> 
	/// NST-2: Source Identifier (ST)<br> 
	/// NST-3: Source Type (ID)<br> 
	/// NST-4: Statistics Start (TS)<br> 
	/// NST-5: Statistics End (TS)<br> 
	/// NST-6: Receive Character Count (NM)<br> 
	/// NST-7: Send Character Count (NM)<br> 
	/// NST-8: Messages Received (NM)<br> 
	/// NST-9: Messages Sent (NM)<br> 
	/// NST-10: Checksum Errors Received (NM)<br> 
	/// NST-11: Length Errors Received (NM)<br> 
	/// NST-12: Other Errors Received (NM)<br> 
	/// NST-13: Connect Timeouts (NM)<br> 
	/// NST-14: Receive Timeouts (NM)<br> 
	/// NST-15: Application control-level Errors (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NST:AbstractSegment
	{
		/// <summary> Returns Statistics Available (NST-1).</summary>
		virtual public ID StatisticsAvailable
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Source Identifier (NST-2).</summary>
		virtual public ST SourceIdentifier
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
		/// <summary> Returns Source Type (NST-3).</summary>
		virtual public ID SourceType
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
		/// <summary> Returns Statistics Start (NST-4).</summary>
		virtual public TS StatisticsStart
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
		/// <summary> Returns Statistics End (NST-5).</summary>
		virtual public TS StatisticsEnd
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
		/// <summary> Returns Receive Character Count (NST-6).</summary>
		virtual public NM ReceiveCharacterCount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Send Character Count (NST-7).</summary>
		virtual public NM SendCharacterCount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Messages Received (NST-8).</summary>
		virtual public NM MessagesReceived
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Messages Sent (NST-9).</summary>
		virtual public NM MessagesSent
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Checksum Errors Received (NST-10).</summary>
		virtual public NM ChecksumErrorsReceived
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Length Errors Received (NST-11).</summary>
		virtual public NM LengthErrorsReceived
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Other Errors Received (NST-12).</summary>
		virtual public NM OtherErrorsReceived
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Connect Timeouts (NST-13).</summary>
		virtual public NM ConnectTimeouts
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Receive Timeouts (NST-14).</summary>
		virtual public NM ReceiveTimeouts
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Application control-level Errors (NST-15).</summary>
		virtual public NM ApplicationControlLevelErrors
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		
		/// <summary> Creates a NST (Application control level statistics) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NST(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 332});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}