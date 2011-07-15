using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 ORC message segment. 
	/// This segment has the following fields:</p><p>
	/// ORC-1: ORDER CONTROL (ST)<br> 
	/// ORC-2: PLACER ORDER # (CM)<br> 
	/// ORC-3: FILLER ORDER # (CM)<br> 
	/// ORC-4: PLACER GROUP # (CM)<br> 
	/// ORC-5: ORDER STATUS (ST)<br> 
	/// ORC-6: RESPONSE FLAG (ST)<br> 
	/// ORC-7: TIMING/QUANTITY (CM)<br> 
	/// ORC-8: PARENT (CM)<br> 
	/// ORC-9: DATE/TIME OF TRANSACTION (TS)<br> 
	/// ORC-10: ENTERED BY (CN)<br> 
	/// ORC-11: VERIFIED BY (CN)<br> 
	/// ORC-12: ORDERING PROVIDER (CN)<br> 
	/// ORC-13: ENTERER'S LOCATION (CM)<br> 
	/// ORC-14: CALL BACK PHONE NUMBER (TN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ORC:AbstractSegment
	{
		/// <summary> Returns ORDER CONTROL (ORC-1).</summary>
		virtual public ST ORDERCONTROL
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
		/// <summary> Returns PLACER ORDER # (ORC-2).</summary>
		virtual public CM PLACERORDER
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CM) t;
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
		/// <summary> Returns FILLER ORDER # (ORC-3).</summary>
		virtual public CM FILLERORDER
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CM) t;
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
		/// <summary> Returns PLACER GROUP # (ORC-4).</summary>
		virtual public CM PLACERGROUP
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CM) t;
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
		/// <summary> Returns ORDER STATUS (ORC-5).</summary>
		virtual public ST ORDERSTATUS
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
		/// <summary> Returns RESPONSE FLAG (ORC-6).</summary>
		virtual public ST RESPONSEFLAG
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
		/// <summary> Returns TIMING/QUANTITY (ORC-7).</summary>
		virtual public CM TIMINGQUANTITY
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (CM) t;
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
		/// <summary> Returns PARENT (ORC-8).</summary>
		virtual public CM PARENT
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (CM) t;
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
		/// <summary> Returns DATE/TIME OF TRANSACTION (ORC-9).</summary>
		virtual public TS DATETIMEOFTRANSACTION
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns ENTERED BY (ORC-10).</summary>
		virtual public CN ENTEREDBY
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns VERIFIED BY (ORC-11).</summary>
		virtual public CN VERIFIEDBY
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns ORDERING PROVIDER (ORC-12).</summary>
		virtual public CN ORDERINGPROVIDER
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns ENTERER'S LOCATION (ORC-13).</summary>
		virtual public CM ENTERERSLOCATION
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (CM) t;
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
		
		/// <summary> Creates a ORC (COMMON ORDER) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ORC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 2, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 75, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 1, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TN), false, 2, 40, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of CALL BACK PHONE NUMBER (ORC-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getCALLBACKPHONENUMBER(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of CALL BACK PHONE NUMBER (ORC-14).</summary>
		public virtual TN[] getCALLBACKPHONENUMBER()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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