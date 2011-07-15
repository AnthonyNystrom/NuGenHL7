using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 DB1 message segment. 
	/// This segment has the following fields:</p><p>
	/// DB1-1: Set ID - DB1 (SI)<br> 
	/// DB1-2: Disabled Person Code (IS)<br> 
	/// DB1-3: Disabled Person Identifier (CX)<br> 
	/// DB1-4: Disabled Indicator (ID)<br> 
	/// DB1-5: Disability Start Date (DT)<br> 
	/// DB1-6: Disability End Date (DT)<br> 
	/// DB1-7: Disability Return to Work Date (DT)<br> 
	/// DB1-8: Disability Unable to Work Date (DT)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class DB1:AbstractSegment
	{
		/// <summary> Returns Set ID - DB1 (DB1-1).</summary>
		virtual public SI SetIDDB1
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI) t;
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
		/// <summary> Returns Disabled Person Code (DB1-2).</summary>
		virtual public IS DisabledPersonCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Disabled Indicator (DB1-4).</summary>
		virtual public ID DisabledIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Disability Start Date (DB1-5).</summary>
		virtual public DT DisabilityStartDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (DT) t;
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
		/// <summary> Returns Disability End Date (DB1-6).</summary>
		virtual public DT DisabilityEndDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (DT) t;
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
		/// <summary> Returns Disability Return to Work Date (DB1-7).</summary>
		virtual public DT DisabilityReturnToWorkDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (DT) t;
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
		/// <summary> Returns Disability Unable to Work Date (DB1-8).</summary>
		virtual public DT DisabilityUnableToWorkDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (DT) t;
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
		
		/// <summary> Creates a DB1 (Disability) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public DB1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 334});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Disabled Person Identifier (DB1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getDisabledPersonIdentifier(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Disabled Person Identifier (DB1-3).</summary>
		public virtual CX[] getDisabledPersonIdentifier()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CX) t[i];
				}
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
}