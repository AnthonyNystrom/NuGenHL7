using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 ORC message segment. 
	/// This segment has the following fields:</p><p>
	/// ORC-1: Order Control (ID)<br> 
	/// ORC-2: Placer Order Number (CM_PLACER)<br> 
	/// ORC-3: Filler Order Number (CM_FILLER)<br> 
	/// ORC-4: Placer Group Number (CM_GROUP_ID)<br> 
	/// ORC-5: Order Status (ID)<br> 
	/// ORC-6: Response Flag (ID)<br> 
	/// ORC-7: Quantity / timing (TQ)<br> 
	/// ORC-8: Parent Order (CM_EIP)<br> 
	/// ORC-9: Date / time of transaction (TS)<br> 
	/// ORC-10: Entered By (CN)<br> 
	/// ORC-11: Verified By (CN)<br> 
	/// ORC-12: Ordering Provider (CN)<br> 
	/// ORC-13: Enterer's Location (CM_PARENT_RESULT)<br> 
	/// ORC-14: Call Back Phone Number (TN)<br> 
	/// ORC-15: Order effective date / time (TS)<br> 
	/// ORC-16: Order Control Code Reason (CE)<br> 
	/// ORC-17: Entering Organization (CE)<br> 
	/// ORC-18: Entering Device (CE)<br> 
	/// ORC-19: Action by (CN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ORC:AbstractSegment
	{
		/// <summary> Returns Order Control (ORC-1).</summary>
		virtual public ID OrderControl
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Placer Order Number (ORC-2).</summary>
		virtual public CM_PLACER PlacerOrderNumber
		{
			get
			{
				CM_PLACER ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CM_PLACER) t;
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
		/// <summary> Returns Filler Order Number (ORC-3).</summary>
		virtual public CM_FILLER FillerOrderNumber
		{
			get
			{
				CM_FILLER ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CM_FILLER) t;
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
		/// <summary> Returns Placer Group Number (ORC-4).</summary>
		virtual public CM_GROUP_ID PlacerGroupNumber
		{
			get
			{
				CM_GROUP_ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CM_GROUP_ID) t;
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
		/// <summary> Returns Order Status (ORC-5).</summary>
		virtual public ID OrderStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Response Flag (ORC-6).</summary>
		virtual public ID ResponseFlag
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
		/// <summary> Returns Parent Order (ORC-8).</summary>
		virtual public CM_EIP ParentOrder
		{
			get
			{
				CM_EIP ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (CM_EIP) t;
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
		/// <summary> Returns Date / time of transaction (ORC-9).</summary>
		virtual public TS DateTimeOfTransaction
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
		/// <summary> Returns Entered By (ORC-10).</summary>
		virtual public CN EnteredBy
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
		/// <summary> Returns Verified By (ORC-11).</summary>
		virtual public CN VerifiedBy
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
		/// <summary> Returns Ordering Provider (ORC-12).</summary>
		virtual public CN OrderingProvider
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
		/// <summary> Returns Enterer's Location (ORC-13).</summary>
		virtual public CM_PARENT_RESULT EntererSLocation
		{
			get
			{
				CM_PARENT_RESULT ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (CM_PARENT_RESULT) t;
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
		/// <summary> Returns Order effective date / time (ORC-15).</summary>
		virtual public TS OrderEffectiveDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Order Control Code Reason (ORC-16).</summary>
		virtual public CE OrderControlCodeReason
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Entering Organization (ORC-17).</summary>
		virtual public CE EnteringOrganization
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Entering Device (ORC-18).</summary>
		virtual public CE EnteringDevice
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Action by (ORC-19).</summary>
		virtual public CN ActionBy
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		
		/// <summary> Creates a ORC (COMMOM ORDER) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ORC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 119});
				this.add(typeof(CM_PLACER), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CM_FILLER), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CM_GROUP_ID), false, 1, 75, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 38});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 121});
				this.add(typeof(TQ), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CM_EIP), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CM_PARENT_RESULT), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TN), false, 2, 40, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Quantity / timing (ORC-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TQ getQuantityTiming(int rep)
		{
			TQ ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (TQ) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Quantity / timing (ORC-7).</summary>
		public virtual TQ[] getQuantityTiming()
		{
			TQ[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new TQ[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TQ) t[i];
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
		
		/// <summary> Returns a single repetition of Call Back Phone Number (ORC-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getCallBackPhoneNumber(int rep)
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
		
		/// <summary> Returns all repetitions of Call Back Phone Number (ORC-14).</summary>
		public virtual TN[] getCallBackPhoneNumber()
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