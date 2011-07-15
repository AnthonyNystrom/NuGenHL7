using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 ABS message segment. 
	/// This segment has the following fields:</p><p>
	/// ABS-1: Discharge Care Provider (XCN)<br> 
	/// ABS-2: Transfer Medical Service Code (CE)<br> 
	/// ABS-3: Severity of Illness Code (CE)<br> 
	/// ABS-4: Date/Time of Attestation (TS)<br> 
	/// ABS-5: Attested By (XCN)<br> 
	/// ABS-6: Triage Code (CE)<br> 
	/// ABS-7: Abstract Completion Date/Time (TS)<br> 
	/// ABS-8: Abstracted By (XCN)<br> 
	/// ABS-9: Case Category Code (CE)<br> 
	/// ABS-10: Caesarian Section Indicator (ID)<br> 
	/// ABS-11: Gestation Category Code (CE)<br> 
	/// ABS-12: Gestation Period - Weeks (NM)<br> 
	/// ABS-13: Newborn Code (CE)<br> 
	/// ABS-14: Stillborn Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ABS:AbstractSegment
	{
		/// <summary> Returns Discharge Care Provider (ABS-1).</summary>
		virtual public XCN DischargeCareProvider
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Transfer Medical Service Code (ABS-2).</summary>
		virtual public CE TransferMedicalServiceCode
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
		/// <summary> Returns Severity of Illness Code (ABS-3).</summary>
		virtual public CE SeverityOfIllnessCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Date/Time of Attestation (ABS-4).</summary>
		virtual public TS DateTimeOfAttestation
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
		/// <summary> Returns Attested By (ABS-5).</summary>
		virtual public XCN AttestedBy
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
		/// <summary> Returns Triage Code (ABS-6).</summary>
		virtual public CE TriageCode
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
		/// <summary> Returns Abstract Completion Date/Time (ABS-7).</summary>
		virtual public TS AbstractCompletionDateTime
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
		/// <summary> Returns Abstracted By (ABS-8).</summary>
		virtual public XCN AbstractedBy
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
		/// <summary> Returns Case Category Code (ABS-9).</summary>
		virtual public CE CaseCategoryCode
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
		/// <summary> Returns Caesarian Section Indicator (ABS-10).</summary>
		virtual public ID CaesarianSectionIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Gestation Category Code (ABS-11).</summary>
		virtual public CE GestationCategoryCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Gestation Period - Weeks (ABS-12).</summary>
		virtual public NM GestationPeriodWeeks
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
		/// <summary> Returns Newborn Code (ABS-13).</summary>
		virtual public CE NewbornCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Stillborn Indicator (ABS-14).</summary>
		virtual public ID StillbornIndicator
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
		
		/// <summary> Creates a ABS (Abstract) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ABS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}