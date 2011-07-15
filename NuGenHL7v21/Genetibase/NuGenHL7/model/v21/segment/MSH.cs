using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 MSH message segment. 
	/// This segment has the following fields:</p><p>
	/// MSH-1: FIELD SEPARATOR (ST)<br> 
	/// MSH-2: ENCODING CHARACTERS (ST)<br> 
	/// MSH-3: SENDING APPLICATION (ST)<br> 
	/// MSH-4: SENDING FACILITY (ST)<br> 
	/// MSH-5: RECEIVING APPLICATION (ST)<br> 
	/// MSH-6: RECEIVING FACILITY (ST)<br> 
	/// MSH-7: DATE/TIME OF MESSAGE (TS)<br> 
	/// MSH-8: Security (ST)<br> 
	/// MSH-9: MESSAGE TYPE (CM_MSG)<br> 
	/// MSH-10: MESSAGE CONTROL ID (ST)<br> 
	/// MSH-11: PROCESSING ID (ID)<br> 
	/// MSH-12: VERSION ID (NM)<br> 
	/// MSH-13: SEQUENCE NUMBER (NM)<br> 
	/// MSH-14: CONTINUATION POINTER (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class MSH:AbstractSegment
	{
		/// <summary> Returns FIELD SEPARATOR (MSH-1).</summary>
		virtual public ST FIELDSEPARATOR
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
		/// <summary> Returns ENCODING CHARACTERS (MSH-2).</summary>
		virtual public ST ENCODINGCHARACTERS
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
		/// <summary> Returns SENDING APPLICATION (MSH-3).</summary>
		virtual public ST SENDINGAPPLICATION
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns SENDING FACILITY (MSH-4).</summary>
		virtual public ST SENDINGFACILITY
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns RECEIVING APPLICATION (MSH-5).</summary>
		virtual public ST RECEIVINGAPPLICATION
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns RECEIVING FACILITY (MSH-6).</summary>
		virtual public ST RECEIVINGFACILITY
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns DATE/TIME OF MESSAGE (MSH-7).</summary>
		virtual public TS DATETIMEOFMESSAGE
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
		/// <summary> Returns Security (MSH-8).</summary>
		virtual public ST Security
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
		/// <summary> Returns MESSAGE TYPE (MSH-9).</summary>
		virtual public CM_MSG MESSAGETYPE
		{
			get
			{
				CM_MSG ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (CM_MSG) t;
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
		/// <summary> Returns MESSAGE CONTROL ID (MSH-10).</summary>
		virtual public ST MESSAGECONTROLID
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
		/// <summary> Returns PROCESSING ID (MSH-11).</summary>
		virtual public ID PROCESSINGID
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns VERSION ID (MSH-12).</summary>
		virtual public NM VERSIONID
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
		/// <summary> Returns SEQUENCE NUMBER (MSH-13).</summary>
		virtual public NM SEQUENCENUMBER
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
		/// <summary> Returns CONTINUATION POINTER (MSH-14).</summary>
		virtual public ST CONTINUATIONPOINTER
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		
		/// <summary> Creates a MSH (MESSAGE HEADER) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public MSH(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 1, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(CM_MSG), true, 1, 7, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 103});
				this.add(typeof(NM), true, 1, 8, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 180, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}