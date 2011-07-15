using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 FHS message segment. 
	/// This segment has the following fields:</p><p>
	/// FHS-1: File Field Separator (ST)<br> 
	/// FHS-2: File Encoding Characters (ST)<br> 
	/// FHS-3: File Sending Application (HD)<br> 
	/// FHS-4: File Sending Facility (HD)<br> 
	/// FHS-5: File Receiving Application (HD)<br> 
	/// FHS-6: File Receiving Facility (HD)<br> 
	/// FHS-7: File Creation Date/Time (TS)<br> 
	/// FHS-8: File Security (ST)<br> 
	/// FHS-9: File Name/ID (ST)<br> 
	/// FHS-10: File Header Comment (ST)<br> 
	/// FHS-11: File Control ID (ST)<br> 
	/// FHS-12: Reference File Control ID (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class FHS:AbstractSegment
	{
		/// <summary> Returns File Field Separator (FHS-1).</summary>
		virtual public ST FileFieldSeparator
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
		/// <summary> Returns File Encoding Characters (FHS-2).</summary>
		virtual public ST FileEncodingCharacters
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
		/// <summary> Returns File Sending Application (FHS-3).</summary>
		virtual public HD FileSendingApplication
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
		/// <summary> Returns File Sending Facility (FHS-4).</summary>
		virtual public HD FileSendingFacility
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
		/// <summary> Returns File Receiving Application (FHS-5).</summary>
		virtual public HD FileReceivingApplication
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
		/// <summary> Returns File Receiving Facility (FHS-6).</summary>
		virtual public HD FileReceivingFacility
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
		/// <summary> Returns File Creation Date/Time (FHS-7).</summary>
		virtual public TS FileCreationDateTime
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
		/// <summary> Returns File Security (FHS-8).</summary>
		virtual public ST FileSecurity
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
		/// <summary> Returns File Name/ID (FHS-9).</summary>
		virtual public ST FileNameID
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
		/// <summary> Returns File Header Comment (FHS-10).</summary>
		virtual public ST FileHeaderComment
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
		/// <summary> Returns File Control ID (FHS-11).</summary>
		virtual public ST FileControlID
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
		/// <summary> Returns Reference File Control ID (FHS-12).</summary>
		virtual public ST ReferenceFileControlID
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
		
		/// <summary> Creates a FHS (File Header) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public FHS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 1, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 4, new System.Object[]{message});
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