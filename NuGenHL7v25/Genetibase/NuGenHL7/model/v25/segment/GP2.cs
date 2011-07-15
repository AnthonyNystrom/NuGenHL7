using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 GP2 message segment. 
	/// This segment has the following fields:</p><p>
	/// GP2-1: Revenue Code (IS)<br> 
	/// GP2-2: Number of Service Units (NM)<br> 
	/// GP2-3: Charge (CP)<br> 
	/// GP2-4: Reimbursement Action Code (IS)<br> 
	/// GP2-5: Denial or Rejection Code (IS)<br> 
	/// GP2-6: OCE Edit Code (IS)<br> 
	/// GP2-7: Ambulatory Payment Classification Code (CE)<br> 
	/// GP2-8: Modifier Edit Code (IS)<br> 
	/// GP2-9: Payment Adjustment Code (IS)<br> 
	/// GP2-10: Packaging Status Code (IS)<br> 
	/// GP2-11: Expected CMS Payment Amount (CP)<br> 
	/// GP2-12: Reimbursement Type Code (IS)<br> 
	/// GP2-13: Co-Pay Amount (CP)<br> 
	/// GP2-14: Pay Rate per Service Unit (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class GP2:AbstractSegment
	{
		/// <summary> Returns Revenue Code (GP2-1).</summary>
		virtual public IS RevenueCode
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
		/// <summary> Returns Number of Service Units (GP2-2).</summary>
		virtual public NM NumberOfServiceUnits
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Charge (GP2-3).</summary>
		virtual public CP Charge
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Reimbursement Action Code (GP2-4).</summary>
		virtual public IS ReimbursementActionCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Denial or Rejection Code (GP2-5).</summary>
		virtual public IS DenialOrRejectionCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Ambulatory Payment Classification Code (GP2-7).</summary>
		virtual public CE AmbulatoryPaymentClassificationCode
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
		/// <summary> Returns Payment Adjustment Code (GP2-9).</summary>
		virtual public IS PaymentAdjustmentCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Packaging Status Code (GP2-10).</summary>
		virtual public IS PackagingStatusCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Expected CMS Payment Amount (GP2-11).</summary>
		virtual public CP ExpectedCMSPaymentAmount
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Reimbursement Type Code (GP2-12).</summary>
		virtual public IS ReimbursementTypeCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Co-Pay Amount (GP2-13).</summary>
		virtual public CP CoPayAmount
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Pay Rate per Service Unit (GP2-14).</summary>
		virtual public NM PayRatePerServiceUnit
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
		
		/// <summary> Creates a GP2 (Grouping/Reimbursement - Procedure Line Item) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public GP2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 456});
				this.add(typeof(NM), false, 1, 7, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 459});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 460});
				this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 458});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 467});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 468});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 469});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 470});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of OCE Edit Code (GP2-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getOCEEditCode(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of OCE Edit Code (GP2-6).</summary>
		public virtual IS[] getOCEEditCode()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Modifier Edit Code (GP2-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getModifierEditCode(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Modifier Edit Code (GP2-8).</summary>
		public virtual IS[] getModifierEditCode()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(8);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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