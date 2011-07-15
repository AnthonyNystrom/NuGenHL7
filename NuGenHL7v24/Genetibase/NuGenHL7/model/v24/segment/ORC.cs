using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 ORC message segment. 
	/// This segment has the following fields:</p><p>
	/// ORC-1: Order Control (ID)<br> 
	/// ORC-2: Placer Order Number (EI)<br> 
	/// ORC-3: Filler Order Number (EI)<br> 
	/// ORC-4: Placer Group Number (EI)<br> 
	/// ORC-5: Order Status (ID)<br> 
	/// ORC-6: Response Flag (ID)<br> 
	/// ORC-7: Quantity/Timing (TQ)<br> 
	/// ORC-8: Parent Order (EIP)<br> 
	/// ORC-9: Date/Time of Transaction (TS)<br> 
	/// ORC-10: Entered By (XCN)<br> 
	/// ORC-11: Verified By (XCN)<br> 
	/// ORC-12: Ordering Provider (XCN)<br> 
	/// ORC-13: Enterer's Location (PL)<br> 
	/// ORC-14: Call Back Phone Number (XTN)<br> 
	/// ORC-15: Order Effective Date/Time (TS)<br> 
	/// ORC-16: Order Control Code Reason (CE)<br> 
	/// ORC-17: Entering Organization (CE)<br> 
	/// ORC-18: Entering Device (CE)<br> 
	/// ORC-19: Action By (XCN)<br> 
	/// ORC-20: Advanced Beneficiary Notice Code (CE)<br> 
	/// ORC-21: Ordering Facility Name (XON)<br> 
	/// ORC-22: Ordering Facility Address (XAD)<br> 
	/// ORC-23: Ordering Facility Phone Number (XTN)<br> 
	/// ORC-24: Ordering Provider Address (XAD)<br> 
	/// ORC-25: Order Status Modifier (CWE)<br> 
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
		virtual public EI PlacerOrderNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Filler Order Number (ORC-3).</summary>
		virtual public EI FillerOrderNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Placer Group Number (ORC-4).</summary>
		virtual public EI PlacerGroupNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		virtual public EIP ParentOrder
		{
			get
			{
				EIP ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (EIP) t;
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
		/// <summary> Returns Date/Time of Transaction (ORC-9).</summary>
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
		/// <summary> Returns Enterer's Location (ORC-13).</summary>
		virtual public PL EntererSLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (PL) t;
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
		/// <summary> Returns Order Effective Date/Time (ORC-15).</summary>
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
		/// <summary> Returns Advanced Beneficiary Notice Code (ORC-20).</summary>
		virtual public CE AdvancedBeneficiaryNoticeCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Order Status Modifier (ORC-25).</summary>
		virtual public CWE OrderStatusModifier
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(25, 0);
					ret = (CWE) t;
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
		
		/// <summary> Creates a ORC (Common Order) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ORC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 119});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 38});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 121});
				this.add(typeof(TQ), false, 0, 200, new System.Object[]{message});
				this.add(typeof(EIP), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XTN), false, 2, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Quantity/Timing (ORC-7).</summary>
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
		
		/// <summary> Returns all repetitions of Quantity/Timing (ORC-7).</summary>
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
		
		/// <summary> Returns a single repetition of Entered By (ORC-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getEnteredBy(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Entered By (ORC-10).</summary>
		public virtual XCN[] getEnteredBy()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Verified By (ORC-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getVerifiedBy(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Verified By (ORC-11).</summary>
		public virtual XCN[] getVerifiedBy()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Ordering Provider (ORC-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getOrderingProvider(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ordering Provider (ORC-12).</summary>
		public virtual XCN[] getOrderingProvider()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(12);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		public virtual XTN getCallBackPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Call Back Phone Number (ORC-14).</summary>
		public virtual XTN[] getCallBackPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(14);
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XTN) t[i];
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
		
		/// <summary> Returns a single repetition of Action By (ORC-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getActionBy(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Action By (ORC-19).</summary>
		public virtual XCN[] getActionBy()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(19);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
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
		
		/// <summary> Returns a single repetition of Ordering Facility Name (ORC-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getOrderingFacilityName(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ordering Facility Name (ORC-21).</summary>
		public virtual XON[] getOrderingFacilityName()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(21);
				ret = new XON[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XON) t[i];
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
		
		/// <summary> Returns a single repetition of Ordering Facility Address (ORC-22).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getOrderingFacilityAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(22, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ordering Facility Address (ORC-22).</summary>
		public virtual XAD[] getOrderingFacilityAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(22);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
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
		
		/// <summary> Returns a single repetition of Ordering Facility Phone Number (ORC-23).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getOrderingFacilityPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(23, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ordering Facility Phone Number (ORC-23).</summary>
		public virtual XTN[] getOrderingFacilityPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(23);
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XTN) t[i];
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
		
		/// <summary> Returns a single repetition of Ordering Provider Address (ORC-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getOrderingProviderAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(24, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ordering Provider Address (ORC-24).</summary>
		public virtual XAD[] getOrderingProviderAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(24);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
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