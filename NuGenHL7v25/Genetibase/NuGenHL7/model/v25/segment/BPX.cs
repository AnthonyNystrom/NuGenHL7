using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 BPX message segment. 
	/// This segment has the following fields:</p><p>
	/// BPX-1: Set ID _ BPX (SI)<br> 
	/// BPX-2: BP Dispense Status (CWE)<br> 
	/// BPX-3: BP Status (ID)<br> 
	/// BPX-4: BP Date/Time of Status (TS)<br> 
	/// BPX-5: BC Donation ID (EI)<br> 
	/// BPX-6: BC Component (CNE)<br> 
	/// BPX-7: BC Donation Type / Intended Use (CNE)<br> 
	/// BPX-8: CP Commercial Product (CWE)<br> 
	/// BPX-9: CP Manufacturer (XON)<br> 
	/// BPX-10: CP Lot Number (EI)<br> 
	/// BPX-11: BP Blood Group (CNE)<br> 
	/// BPX-12: BC Special Testing (CNE)<br> 
	/// BPX-13: BP Expiration Date/Time (TS)<br> 
	/// BPX-14: BP Quantity (NM)<br> 
	/// BPX-15: BP Amount (NM)<br> 
	/// BPX-16: BP Units (CE)<br> 
	/// BPX-17: BP Unique ID (EI)<br> 
	/// BPX-18: BP Actual Dispensed To Location (PL)<br> 
	/// BPX-19: BP Actual Dispensed To Address (XAD)<br> 
	/// BPX-20: BP Dispensed to Receiver (XCN)<br> 
	/// BPX-21: BP Dispensing Individual (XCN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class BPX:AbstractSegment
	{
		/// <summary> Returns Set ID _ BPX (BPX-1).</summary>
		virtual public SI SetIDBPX
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
		/// <summary> Returns BP Dispense Status (BPX-2).</summary>
		virtual public CWE BPDispenseStatus
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns BP Status (BPX-3).</summary>
		virtual public ID BPStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns BP Date/Time of Status (BPX-4).</summary>
		virtual public TS BPDateTimeOfStatus
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
		/// <summary> Returns BC Donation ID (BPX-5).</summary>
		virtual public EI BCDonationID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns BC Component (BPX-6).</summary>
		virtual public CNE BCComponent
		{
			get
			{
				CNE ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (CNE) t;
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
		/// <summary> Returns BC Donation Type / Intended Use (BPX-7).</summary>
		virtual public CNE BCDonationTypeIntendedUse
		{
			get
			{
				CNE ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (CNE) t;
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
		/// <summary> Returns CP Commercial Product (BPX-8).</summary>
		virtual public CWE CPCommercialProduct
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns CP Manufacturer (BPX-9).</summary>
		virtual public XON CPManufacturer
		{
			get
			{
				XON ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (XON) t;
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
		/// <summary> Returns CP Lot Number (BPX-10).</summary>
		virtual public EI CPLotNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns BP Blood Group (BPX-11).</summary>
		virtual public CNE BPBloodGroup
		{
			get
			{
				CNE ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CNE) t;
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
		/// <summary> Returns BP Expiration Date/Time (BPX-13).</summary>
		virtual public TS BPExpirationDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns BP Quantity (BPX-14).</summary>
		virtual public NM BPQuantity
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
		/// <summary> Returns BP Amount (BPX-15).</summary>
		virtual public NM BPAmount
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
		/// <summary> Returns BP Units (BPX-16).</summary>
		virtual public CE BPUnits
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
		/// <summary> Returns BP Unique ID (BPX-17).</summary>
		virtual public EI BPUniqueID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns BP Actual Dispensed To Location (BPX-18).</summary>
		virtual public PL BPActualDispensedToLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns BP Actual Dispensed To Address (BPX-19).</summary>
		virtual public XAD BPActualDispensedToAddress
		{
			get
			{
				XAD ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (XAD) t;
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
		/// <summary> Returns BP Dispensed to Receiver (BPX-20).</summary>
		virtual public XCN BPDispensedToReceiver
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (XCN) t;
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
		/// <summary> Returns BP Dispensing Individual (BPX-21).</summary>
		virtual public XCN BPDispensingIndividual
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (XCN) t;
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
		
		/// <summary> Creates a BPX (Blood product dispense status) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public BPX(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CWE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 511});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XON), false, 1, 250, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CNE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 5, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XAD), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of BC Special Testing (BPX-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CNE getBCSpecialTesting(int rep)
		{
			CNE ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (CNE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of BC Special Testing (BPX-12).</summary>
		public virtual CNE[] getBCSpecialTesting()
		{
			CNE[] ret = null;
			try
			{
				Type[] t = this.getField(12);
				ret = new CNE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CNE) t[i];
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