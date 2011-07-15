using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 AUT message segment. 
	/// This segment has the following fields:</p><p>
	/// AUT-1: Authorizing Payor, Plan ID (CE)<br> 
	/// AUT-2: Authorizing Payor, Company ID (CE)<br> 
	/// AUT-3: Authorizing Payor, Company Name (ST)<br> 
	/// AUT-4: Authorization Effective Date (TS)<br> 
	/// AUT-5: Authorization Expiration Date (TS)<br> 
	/// AUT-6: Authorization Identifier (EI)<br> 
	/// AUT-7: Reimbursement Limit (CP)<br> 
	/// AUT-8: Requested Number of Treatments (NM)<br> 
	/// AUT-9: Authorized Number of Treatments (NM)<br> 
	/// AUT-10: Process Date (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class AUT:AbstractSegment
	{
		/// <summary> Returns Authorizing Payor, Plan ID (AUT-1).</summary>
		virtual public CE AuthorizingPayorPlanID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Authorizing Payor, Company ID (AUT-2).</summary>
		virtual public CE AuthorizingPayorCompanyID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Authorizing Payor, Company Name (AUT-3).</summary>
		virtual public ST AuthorizingPayorCompanyName
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
		/// <summary> Returns Authorization Effective Date (AUT-4).</summary>
		virtual public TS AuthorizationEffectiveDate
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
		/// <summary> Returns Authorization Expiration Date (AUT-5).</summary>
		virtual public TS AuthorizationExpirationDate
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
		/// <summary> Returns Authorization Identifier (AUT-6).</summary>
		virtual public EI AuthorizationIdentifier
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (EI) t;
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
		/// <summary> Returns Reimbursement Limit (AUT-7).</summary>
		virtual public CP ReimbursementLimit
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (CP) t;
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
		/// <summary> Returns Requested Number of Treatments (AUT-8).</summary>
		virtual public NM RequestedNumberOfTreatments
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
		/// <summary> Returns Authorized Number of Treatments (AUT-9).</summary>
		virtual public NM AuthorizedNumberOfTreatments
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
		/// <summary> Returns Process Date (AUT-10).</summary>
		virtual public TS ProcessDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		
		/// <summary> Creates a AUT (Authorization Information) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public AUT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 45, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 30, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 25, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}