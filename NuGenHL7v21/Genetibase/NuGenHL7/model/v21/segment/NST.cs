using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 NST message segment. 
	/// This segment has the following fields:</p><p>
	/// NST-1: STATISTICS AVAILABLE (ID)<br> 
	/// NST-2: SOURCE IDENTIFIER (ST)<br> 
	/// NST-3: SOURCE TYPE (ID)<br> 
	/// NST-4: STATISTICS START (TS)<br> 
	/// NST-5: STATISTICS END (TS)<br> 
	/// NST-6: RECEIVE CHARACTER COUNT (NM)<br> 
	/// NST-7: SEND CHARACTER COUNT (NM)<br> 
	/// NST-8: MESSAGES RECEIVED (NM)<br> 
	/// NST-9: MESSAGES SENT (NM)<br> 
	/// NST-10: CHECKSUM ERRORS RECEIVED (NM)<br> 
	/// NST-11: LENGTH ERRORS RECEIVED (NM)<br> 
	/// NST-12: OTHER ERRORS RECEIVED (NM)<br> 
	/// NST-13: CONNECT TIMEOUTS (NM)<br> 
	/// NST-14: RECEIVE TIMEOUTS (NM)<br> 
	/// NST-15: NETWORK ERRORS (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NST:AbstractSegment
	{
		/// <summary> Returns STATISTICS AVAILABLE (NST-1).</summary>
		virtual public ID STATISTICSAVAILABLE
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
		/// <summary> Returns SOURCE IDENTIFIER (NST-2).</summary>
		virtual public ST SOURCEIDENTIFIER
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
		/// <summary> Returns SOURCE TYPE (NST-3).</summary>
		virtual public ID SOURCETYPE
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
		/// <summary> Returns STATISTICS START (NST-4).</summary>
		virtual public TS STATISTICSSTART
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
		/// <summary> Returns STATISTICS END (NST-5).</summary>
		virtual public TS STATISTICSEND
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
		/// <summary> Returns RECEIVE CHARACTER COUNT (NST-6).</summary>
		virtual public NM RECEIVECHARACTERCOUNT
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
		/// <summary> Returns SEND CHARACTER COUNT (NST-7).</summary>
		virtual public NM SENDCHARACTERCOUNT
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
		/// <summary> Returns MESSAGES RECEIVED (NST-8).</summary>
		virtual public NM MESSAGESRECEIVED
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
		/// <summary> Returns MESSAGES SENT (NST-9).</summary>
		virtual public NM MESSAGESSENT
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
		/// <summary> Returns CHECKSUM ERRORS RECEIVED (NST-10).</summary>
		virtual public NM CHECKSUMERRORSRECEIVED
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
		/// <summary> Returns LENGTH ERRORS RECEIVED (NST-11).</summary>
		virtual public NM LENGTHERRORSRECEIVED
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
		/// <summary> Returns OTHER ERRORS RECEIVED (NST-12).</summary>
		virtual public NM OTHERERRORSRECEIVED
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
		/// <summary> Returns CONNECT TIMEOUTS (NST-13).</summary>
		virtual public NM CONNECTTIMEOUTS
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
		/// <summary> Returns RECEIVE TIMEOUTS (NST-14).</summary>
		virtual public NM RECEIVETIMEOUTS
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
		/// <summary> Returns NETWORK ERRORS (NST-15).</summary>
		virtual public NM NETWORKERRORS
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
		
		/// <summary> Creates a NST (STATISTICS) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NST(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 0});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 0});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
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