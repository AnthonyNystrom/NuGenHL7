using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 OM7 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM7-1: Sequence Number - Test/ Observation Master File (NM)<br> 
	/// OM7-2: Universal Service Identifier (CE)<br> 
	/// OM7-3: Category Identifier (CE)<br> 
	/// OM7-4: Category Description (TX)<br> 
	/// OM7-5: Category Synonym (ST)<br> 
	/// OM7-6: Effective Test/Service Start Date/Time (TS)<br> 
	/// OM7-7: Effective Test/Service End Date/Time (TS)<br> 
	/// OM7-8: Test/Service Default Duration Quantity (NM)<br> 
	/// OM7-9: Test/Service Default Duration Units (CE)<br> 
	/// OM7-10: Test/Service Default Frequency (IS)<br> 
	/// OM7-11: Consent Indicator (ID)<br> 
	/// OM7-12: Consent Identifier (CE)<br> 
	/// OM7-13: Consent Effective Start Date/Time (TS)<br> 
	/// OM7-14: Consent Effective End Date/Time (TS)<br> 
	/// OM7-15: Consent Interval Quantity (NM)<br> 
	/// OM7-16: Consent Interval Units (CE)<br> 
	/// OM7-17: Consent Waiting Period Quantity (NM)<br> 
	/// OM7-18: Consent Waiting Period Units (CE)<br> 
	/// OM7-19: Effective Date/Time of Change (TS)<br> 
	/// OM7-20: Entered By (XCN)<br> 
	/// OM7-21: Orderable-at Location (PL)<br> 
	/// OM7-22: Formulary Status (IS)<br> 
	/// OM7-23: Special Order Indicator (ID)<br> 
	/// OM7-24: Primary Key Value - CDM (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM7:AbstractSegment
	{
		/// <summary> Returns Sequence Number - Test/ Observation Master File (OM7-1).</summary>
		virtual public NM SequenceNumberTestObservationMasterFile
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Universal Service Identifier (OM7-2).</summary>
		virtual public CE UniversalServiceIdentifier
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
		/// <summary> Returns Category Description (OM7-4).</summary>
		virtual public TX CategoryDescription
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (TX) t;
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
		/// <summary> Returns Effective Test/Service Start Date/Time (OM7-6).</summary>
		virtual public TS EffectiveTestServiceStartDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Effective Test/Service End Date/Time (OM7-7).</summary>
		virtual public TS EffectiveTestServiceEndDateTime
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
		/// <summary> Returns Test/Service Default Duration Quantity (OM7-8).</summary>
		virtual public NM TestServiceDefaultDurationQuantity
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
		/// <summary> Returns Test/Service Default Duration Units (OM7-9).</summary>
		virtual public CE TestServiceDefaultDurationUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Test/Service Default Frequency (OM7-10).</summary>
		virtual public IS TestServiceDefaultFrequency
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
		/// <summary> Returns Consent Indicator (OM7-11).</summary>
		virtual public ID ConsentIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Consent Identifier (OM7-12).</summary>
		virtual public CE ConsentIdentifier
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Consent Effective Start Date/Time (OM7-13).</summary>
		virtual public TS ConsentEffectiveStartDateTime
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
		/// <summary> Returns Consent Effective End Date/Time (OM7-14).</summary>
		virtual public TS ConsentEffectiveEndDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Consent Interval Quantity (OM7-15).</summary>
		virtual public NM ConsentIntervalQuantity
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
		/// <summary> Returns Consent Interval Units (OM7-16).</summary>
		virtual public CE ConsentIntervalUnits
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
		/// <summary> Returns Consent Waiting Period Quantity (OM7-17).</summary>
		virtual public NM ConsentWaitingPeriodQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Consent Waiting Period Units (OM7-18).</summary>
		virtual public CE ConsentWaitingPeriodUnits
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
		/// <summary> Returns Effective Date/Time of Change (OM7-19).</summary>
		virtual public TS EffectiveDateTimeOfChange
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Entered By (OM7-20).</summary>
		virtual public XCN EnteredBy
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
		/// <summary> Returns Formulary Status (OM7-22).</summary>
		virtual public IS FormularyStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Special Order Indicator (OM7-23).</summary>
		virtual public ID SpecialOrderIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		
		/// <summary> Creates a OM7 (Additional Basic Attributes) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM7(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 200, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 60, new System.Object[]{message, 335});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(PL), false, 0, 200, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 473});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Category Identifier (OM7-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCategoryIdentifier(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Category Identifier (OM7-3).</summary>
		public virtual CE[] getCategoryIdentifier()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Category Synonym (OM7-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getCategorySynonym(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Category Synonym (OM7-5).</summary>
		public virtual ST[] getCategorySynonym()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of Orderable-at Location (OM7-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual PL getOrderableAtLocation(int rep)
		{
			PL ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (PL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Orderable-at Location (OM7-21).</summary>
		public virtual PL[] getOrderableAtLocation()
		{
			PL[] ret = null;
			try
			{
				Type[] t = this.getField(21);
				ret = new PL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PL) t[i];
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
		
		/// <summary> Returns a single repetition of Primary Key Value - CDM (OM7-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getPrimaryKeyValueCDM(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(24, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Primary Key Value - CDM (OM7-24).</summary>
		public virtual CE[] getPrimaryKeyValueCDM()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(24);
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