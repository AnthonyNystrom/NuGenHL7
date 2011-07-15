using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 NSC message segment. 
	/// This segment has the following fields:</p><p>
	/// NSC-1: Network Change Type (IS)<br> 
	/// NSC-2: Current CPU (ST)<br> 
	/// NSC-3: Current Fileserver (ST)<br> 
	/// NSC-4: Current Application (ST)<br> 
	/// NSC-5: Current Facility (ST)<br> 
	/// NSC-6: New CPU (ST)<br> 
	/// NSC-7: New Fileserver (ST)<br> 
	/// NSC-8: New Application (ST)<br> 
	/// NSC-9: New Facility (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NSC:AbstractSegment
	{
		/// <summary> Returns Network Change Type (NSC-1).</summary>
		virtual public IS NetworkChangeType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (IS) t;
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
		/// <summary> Returns Current CPU (NSC-2).</summary>
		virtual public ST CurrentCPU
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
		/// <summary> Returns Current Fileserver (NSC-3).</summary>
		virtual public ST CurrentFileserver
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
		/// <summary> Returns Current Application (NSC-4).</summary>
		virtual public ST CurrentApplication
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
		/// <summary> Returns Current Facility (NSC-5).</summary>
		virtual public ST CurrentFacility
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
		/// <summary> Returns New CPU (NSC-6).</summary>
		virtual public ST NewCPU
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
		/// <summary> Returns New Fileserver (NSC-7).</summary>
		virtual public ST NewFileserver
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns New Application (NSC-8).</summary>
		virtual public ST NewApplication
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
		/// <summary> Returns New Facility (NSC-9).</summary>
		virtual public ST NewFacility
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
		
		/// <summary> Creates a NSC (Application status change) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NSC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(IS), false, 1, 0, new System.Object[]{message, 333});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 0, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}