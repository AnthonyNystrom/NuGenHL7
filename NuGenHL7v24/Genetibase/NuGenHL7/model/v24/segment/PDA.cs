using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 PDA message segment. 
	/// This segment has the following fields:</p><p>
	/// PDA-1: Death Cause Code (CE)<br> 
	/// PDA-2: Death Location (PL)<br> 
	/// PDA-3: Death Certified Indicator (ID)<br> 
	/// PDA-4: Death Certificate Signed Date/Time (TS)<br> 
	/// PDA-5: Death Certified By (XCN)<br> 
	/// PDA-6: Autopsy Indicator (ID)<br> 
	/// PDA-7: Autopsy Start and End Date/Time (DR)<br> 
	/// PDA-8: Autopsy Performed By (XCN)<br> 
	/// PDA-9: Coroner Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PDA:AbstractSegment
	{
		/// <summary> Returns Death Location (PDA-2).</summary>
		virtual public PL DeathLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Death Certified Indicator (PDA-3).</summary>
		virtual public ID DeathCertifiedIndicator
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
		/// <summary> Returns Death Certificate Signed Date/Time (PDA-4).</summary>
		virtual public TS DeathCertificateSignedDateTime
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
		/// <summary> Returns Death Certified By (PDA-5).</summary>
		virtual public XCN DeathCertifiedBy
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Autopsy Indicator (PDA-6).</summary>
		virtual public ID AutopsyIndicator
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
		/// <summary> Returns Autopsy Start and End Date/Time (PDA-7).</summary>
		virtual public DR AutopsyStartAndEndDateTime
		{
			get
			{
				DR ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (DR) t;
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
		/// <summary> Returns Autopsy Performed By (PDA-8).</summary>
		virtual public XCN AutopsyPerformedBy
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Coroner Indicator (PDA-9).</summary>
		virtual public ID CoronerIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		
		/// <summary> Creates a PDA (Patient death and autopsy) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PDA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(DR), false, 1, 53, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Death Cause Code (PDA-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getDeathCauseCode(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Death Cause Code (PDA-1).</summary>
		public virtual CE[] getDeathCauseCode()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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