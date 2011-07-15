using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 NK1 message segment. 
	/// This segment has the following fields:</p><p>
	/// NK1-1: Set ID - Next of Kin (SI)<br> 
	/// NK1-2: NK Name (PN)<br> 
	/// NK1-3: Relationship (CE)<br> 
	/// NK1-4: Address (AD)<br> 
	/// NK1-5: Phone Number (TN)<br> 
	/// NK1-6: Business Phone Number (TN)<br> 
	/// NK1-7: Contact Role (CE)<br> 
	/// NK1-8: Start Date (DT)<br> 
	/// NK1-9: End Date (DT)<br> 
	/// NK1-10: Next of Kin (ST)<br> 
	/// NK1-11: Next of kin job code / class (CM_JOB_CODE)<br> 
	/// NK1-12: Next of Kin Employee Number (ST)<br> 
	/// NK1-13: Organization Name (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NK1:AbstractSegment
	{
		/// <summary> Returns Set ID - Next of Kin (NK1-1).</summary>
		virtual public SI SetIDNextOfKin
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
		/// <summary> Returns NK Name (NK1-2).</summary>
		virtual public PN NKName
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (PN) t;
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
		/// <summary> Returns Relationship (NK1-3).</summary>
		virtual public CE Relationship
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Address (NK1-4).</summary>
		virtual public AD Address
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (AD) t;
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
		/// <summary> Returns Business Phone Number (NK1-6).</summary>
		virtual public TN BusinessPhoneNumber
		{
			get
			{
				TN ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (TN) t;
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
		/// <summary> Returns Contact Role (NK1-7).</summary>
		virtual public CE ContactRole
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Start Date (NK1-8).</summary>
		virtual public DT StartDate
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
		/// <summary> Returns End Date (NK1-9).</summary>
		virtual public DT EndDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Next of Kin (NK1-10).</summary>
		virtual public ST NextOfKin
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
		/// <summary> Returns Next of kin job code / class (NK1-11).</summary>
		virtual public CM_JOB_CODE NextOfKinJobCodeClass
		{
			get
			{
				CM_JOB_CODE ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CM_JOB_CODE) t;
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
		/// <summary> Returns Next of Kin Employee Number (NK1-12).</summary>
		virtual public ST NextOfKinEmployeeNumber
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
		/// <summary> Returns Organization Name (NK1-13).</summary>
		virtual public ST OrganizationName
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		
		/// <summary> Creates a NK1 (NEXT OF KIN) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NK1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(TN), false, 1, 40, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CM_JOB_CODE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Phone Number (NK1-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getPhoneNumber(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone Number (NK1-5).</summary>
		public virtual TN[] getPhoneNumber()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new TN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TN) t[i];
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