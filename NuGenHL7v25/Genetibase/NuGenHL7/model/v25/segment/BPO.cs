using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 BPO message segment. 
	/// This segment has the following fields:</p><p>
	/// BPO-1: Set ID _ BPO (SI)<br> 
	/// BPO-2: BP Universal Service ID (CWE)<br> 
	/// BPO-3: BP  Processing Requirements (CWE)<br> 
	/// BPO-4: BP Quantity (NM)<br> 
	/// BPO-5: BP Amount (NM)<br> 
	/// BPO-6: BP Units (CE)<br> 
	/// BPO-7: BP Intended Use Date/Time (TS)<br> 
	/// BPO-8: BP Intended Dispense From Location (PL)<br> 
	/// BPO-9: BP Intended Dispense From Address (XAD)<br> 
	/// BPO-10: BP Requested Dispense Date/Time (TS)<br> 
	/// BPO-11: BP Requested Dispense To Location (PL)<br> 
	/// BPO-12: BP Requested Dispense To Address (XAD)<br> 
	/// BPO-13: BP Indication for Use (CWE)<br> 
	/// BPO-14: BP Informed Consent Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class BPO:AbstractSegment
	{
		/// <summary> Returns Set ID _ BPO (BPO-1).</summary>
		virtual public SI SetIDBPO
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
		/// <summary> Returns BP Universal Service ID (BPO-2).</summary>
		virtual public CWE BPUniversalServiceID
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
		/// <summary> Returns BP Quantity (BPO-4).</summary>
		virtual public NM BPQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns BP Amount (BPO-5).</summary>
		virtual public NM BPAmount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns BP Units (BPO-6).</summary>
		virtual public CE BPUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns BP Intended Use Date/Time (BPO-7).</summary>
		virtual public TS BPIntendedUseDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns BP Intended Dispense From Location (BPO-8).</summary>
		virtual public PL BPIntendedDispenseFromLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns BP Intended Dispense From Address (BPO-9).</summary>
		virtual public XAD BPIntendedDispenseFromAddress
		{
			get
			{
				XAD ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns BP Requested Dispense Date/Time (BPO-10).</summary>
		virtual public TS BPRequestedDispenseDateTime
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
		/// <summary> Returns BP Requested Dispense To Location (BPO-11).</summary>
		virtual public PL BPRequestedDispenseToLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns BP Requested Dispense To Address (BPO-12).</summary>
		virtual public XAD BPRequestedDispenseToAddress
		{
			get
			{
				XAD ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns BP Informed Consent Indicator (BPO-14).</summary>
		virtual public ID BPInformedConsentIndicator
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
		
		/// <summary> Creates a BPO (Blood product order) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public BPO(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CWE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 5, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XAD), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XAD), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of BP  Processing Requirements (BPO-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getBPProcessingRequirements(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of BP  Processing Requirements (BPO-3).</summary>
		public virtual CWE[] getBPProcessingRequirements()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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
		
		/// <summary> Returns a single repetition of BP Indication for Use (BPO-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getBPIndicationForUse(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of BP Indication for Use (BPO-13).</summary>
		public virtual CWE[] getBPIndicationForUse()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(13);
				ret = new CWE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CWE) t[i];
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