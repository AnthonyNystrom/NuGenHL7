using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 FT1 message segment. 
	/// This segment has the following fields:</p><p>
	/// FT1-1: SET ID - FINANCIAL TRANSACTION (SI)<br> 
	/// FT1-2: TRANSACTION ID (ST)<br> 
	/// FT1-3: TRANSACTION BATCH ID (ST)<br> 
	/// FT1-4: TRANSACTION DATE (DT)<br> 
	/// FT1-5: TRANSACTION POSTING DATE (DT)<br> 
	/// FT1-6: TRANSACTION TYPE (ID)<br> 
	/// FT1-7: TRANSACTION CODE (ID)<br> 
	/// FT1-8: TRANSACTION DESCRIPTION (ST)<br> 
	/// FT1-9: TRANSACTION DESCRIPTION - ALT (ST)<br> 
	/// FT1-10: TRANSACTION AMOUNT - EXTENDED (NM)<br> 
	/// FT1-11: TRANSACTION QUANTITY (NM)<br> 
	/// FT1-12: TRANSACTION AMOUNT - UNIT (NM)<br> 
	/// FT1-13: DEPARTMENT CODE (ST)<br> 
	/// FT1-14: INSURANCE PLAN ID (ID)<br> 
	/// FT1-15: INSURANCE AMOUNT (NM)<br> 
	/// FT1-16: PATIENT LOCATION (ST)<br> 
	/// FT1-17: FEE SCHEDULE (ID)<br> 
	/// FT1-18: PATIENT TYPE (ID)<br> 
	/// FT1-19: DIAGNOSIS CODE (ID)<br> 
	/// FT1-20: PERFORMED BY CODE (CN)<br> 
	/// FT1-21: ORDERED BY CODE (CN)<br> 
	/// FT1-22: UNIT COST (NM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class FT1:AbstractSegment
	{
		/// <summary> Returns SET ID - FINANCIAL TRANSACTION (FT1-1).</summary>
		virtual public SI SETIDFINANCIALTRANSACTION
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
		/// <summary> Returns TRANSACTION ID (FT1-2).</summary>
		virtual public ST TRANSACTIONID
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
		/// <summary> Returns TRANSACTION BATCH ID (FT1-3).</summary>
		virtual public ST TRANSACTIONBATCHID
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
		/// <summary> Returns TRANSACTION DATE (FT1-4).</summary>
		virtual public DT TRANSACTIONDATE
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns TRANSACTION POSTING DATE (FT1-5).</summary>
		virtual public DT TRANSACTIONPOSTINGDATE
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
		/// <summary> Returns TRANSACTION TYPE (FT1-6).</summary>
		virtual public ID TRANSACTIONTYPE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns TRANSACTION CODE (FT1-7).</summary>
		virtual public ID TRANSACTIONCODE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns TRANSACTION DESCRIPTION (FT1-8).</summary>
		virtual public ST TRANSACTIONDESCRIPTION
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
		/// <summary> Returns TRANSACTION DESCRIPTION - ALT (FT1-9).</summary>
		virtual public ST TRANSACTIONDESCRIPTIONALT
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
		/// <summary> Returns TRANSACTION AMOUNT - EXTENDED (FT1-10).</summary>
		virtual public NM TRANSACTIONAMOUNTEXTENDED
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
		/// <summary> Returns TRANSACTION QUANTITY (FT1-11).</summary>
		virtual public NM TRANSACTIONQUANTITY
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
		/// <summary> Returns TRANSACTION AMOUNT - UNIT (FT1-12).</summary>
		virtual public NM TRANSACTIONAMOUNTUNIT
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
		/// <summary> Returns DEPARTMENT CODE (FT1-13).</summary>
		virtual public ST DEPARTMENTCODE
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
		/// <summary> Returns INSURANCE PLAN ID (FT1-14).</summary>
		virtual public ID INSURANCEPLANID
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns INSURANCE AMOUNT (FT1-15).</summary>
		virtual public NM INSURANCEAMOUNT
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
		/// <summary> Returns PATIENT LOCATION (FT1-16).</summary>
		virtual public ST PATIENTLOCATION
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns FEE SCHEDULE (FT1-17).</summary>
		virtual public ID FEESCHEDULE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns PATIENT TYPE (FT1-18).</summary>
		virtual public ID PATIENTTYPE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns DIAGNOSIS CODE (FT1-19).</summary>
		virtual public ID DIAGNOSISCODE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns PERFORMED BY CODE (FT1-20).</summary>
		virtual public CN PERFORMEDBYCODE
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (CN) t;
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
		/// <summary> Returns ORDERED BY CODE (FT1-21).</summary>
		virtual public CN ORDEREDBYCODE
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (CN) t;
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
		/// <summary> Returns UNIT COST (FT1-22).</summary>
		virtual public NM UNITCOST
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		
		/// <summary> Creates a FT1 (FINANCIAL TRANSACTION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public FT1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 5, new System.Object[]{message});
				this.add(typeof(DT), true, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 17});
				this.add(typeof(ID), true, 1, 20, new System.Object[]{message, 96});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 72});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 24});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 51});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}