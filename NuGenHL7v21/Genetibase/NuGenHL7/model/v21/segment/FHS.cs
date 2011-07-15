using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 FHS message segment. 
	/// This segment has the following fields:</p><p>
	/// FHS-1: FILE FIELD SEPARATOR (ST)<br> 
	/// FHS-2: FILE ENCODING CHARACTERS (ST)<br> 
	/// FHS-3: FILE SENDING APPLICATION (ST)<br> 
	/// FHS-4: FILE SENDING FACILITY (ST)<br> 
	/// FHS-5: FILE RECEIVING APPLICATION (ST)<br> 
	/// FHS-6: FILE RECEIVING FACILITY (ST)<br> 
	/// FHS-7: DATE/TIME OF FILE CREATION (TS)<br> 
	/// FHS-8: FILE SECURITY (ST)<br> 
	/// FHS-9: FILE NAME/ID (ST)<br> 
	/// FHS-10: FILE HEADER COMMENT (ST)<br> 
	/// FHS-11: FILE CONTROL ID (ST)<br> 
	/// FHS-12: REFERENCE FILE CONTROL ID (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class FHS:AbstractSegment
	{
		/// <summary> Returns FILE FIELD SEPARATOR (FHS-1).</summary>
		virtual public ST FILEFIELDSEPARATOR
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
		/// <summary> Returns FILE ENCODING CHARACTERS (FHS-2).</summary>
		virtual public ST FILEENCODINGCHARACTERS
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
		/// <summary> Returns FILE SENDING APPLICATION (FHS-3).</summary>
		virtual public ST FILESENDINGAPPLICATION
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
		/// <summary> Returns FILE SENDING FACILITY (FHS-4).</summary>
		virtual public ST FILESENDINGFACILITY
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
		/// <summary> Returns FILE RECEIVING APPLICATION (FHS-5).</summary>
		virtual public ST FILERECEIVINGAPPLICATION
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
		/// <summary> Returns FILE RECEIVING FACILITY (FHS-6).</summary>
		virtual public ST FILERECEIVINGFACILITY
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
		/// <summary> Returns DATE/TIME OF FILE CREATION (FHS-7).</summary>
		virtual public TS DATETIMEOFFILECREATION
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
		/// <summary> Returns FILE SECURITY (FHS-8).</summary>
		virtual public ST FILESECURITY
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
		/// <summary> Returns FILE NAME/ID (FHS-9).</summary>
		virtual public ST FILENAMEID
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
		/// <summary> Returns FILE HEADER COMMENT (FHS-10).</summary>
		virtual public ST FILEHEADERCOMMENT
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
		/// <summary> Returns FILE CONTROL ID (FHS-11).</summary>
		virtual public ST FILECONTROLID
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
		/// <summary> Returns REFERENCE FILE CONTROL ID (FHS-12).</summary>
		virtual public ST REFERENCEFILECONTROLID
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
		
		/// <summary> Creates a FHS (FILE HEADER) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public FHS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 1, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
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