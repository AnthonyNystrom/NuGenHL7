using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 IAM message segment. 
	/// This segment has the following fields:</p><p>
	/// IAM-1: Set ID - IAM (SI)<br> 
	/// IAM-2: Allergen Type Code (CE)<br> 
	/// IAM-3: Allergen Code/Mnemonic/Description (CE)<br> 
	/// IAM-4: Allergy Severity Code (CE)<br> 
	/// IAM-5: Allergy Reaction Code (ST)<br> 
	/// IAM-6: Allergy Action Code (CNE)<br> 
	/// IAM-7: Allergy Unique Identifier (EI)<br> 
	/// IAM-8: Action Reason (ST)<br> 
	/// IAM-9: Sensitivity to Causative Agent Code (CE)<br> 
	/// IAM-10: Allergen Group Code/Mnemonic/Description (CE)<br> 
	/// IAM-11: Onset Date (DT)<br> 
	/// IAM-12: Onset Date Text (ST)<br> 
	/// IAM-13: Reported Date/Time (TS)<br> 
	/// IAM-14: Reported By (XPN)<br> 
	/// IAM-15: Relationship to Patient Code (CE)<br> 
	/// IAM-16: Alert Device Code (CE)<br> 
	/// IAM-17: Allergy Clinical Status Code (CE)<br> 
	/// IAM-18: Statused by Person (XCN)<br> 
	/// IAM-19: Statused by Organization (XON)<br> 
	/// IAM-20: Statused at Date/Time (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class IAM:AbstractSegment
	{
		/// <summary> Returns Set ID - IAM (IAM-1).</summary>
		virtual public SI SetIDIAM
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
		/// <summary> Returns Allergen Type Code (IAM-2).</summary>
		virtual public CE AllergenTypeCode
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
		/// <summary> Returns Allergen Code/Mnemonic/Description (IAM-3).</summary>
		virtual public CE AllergenCodeMnemonicDescription
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
		/// <summary> Returns Allergy Severity Code (IAM-4).</summary>
		virtual public CE AllergySeverityCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Allergy Action Code (IAM-6).</summary>
		virtual public CNE AllergyActionCode
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
		/// <summary> Returns Allergy Unique Identifier (IAM-7).</summary>
		virtual public EI AllergyUniqueIdentifier
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Action Reason (IAM-8).</summary>
		virtual public ST ActionReason
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
		/// <summary> Returns Sensitivity to Causative Agent Code (IAM-9).</summary>
		virtual public CE SensitivityToCausativeAgentCode
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
		/// <summary> Returns Allergen Group Code/Mnemonic/Description (IAM-10).</summary>
		virtual public CE AllergenGroupCodeMnemonicDescription
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Onset Date (IAM-11).</summary>
		virtual public DT OnsetDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Onset Date Text (IAM-12).</summary>
		virtual public ST OnsetDateText
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Reported Date/Time (IAM-13).</summary>
		virtual public TS ReportedDateTime
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
		/// <summary> Returns Reported By (IAM-14).</summary>
		virtual public XPN ReportedBy
		{
			get
			{
				XPN ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (XPN) t;
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
		/// <summary> Returns Relationship to Patient Code (IAM-15).</summary>
		virtual public CE RelationshipToPatientCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Alert Device Code (IAM-16).</summary>
		virtual public CE AlertDeviceCode
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
		/// <summary> Returns Allergy Clinical Status Code (IAM-17).</summary>
		virtual public CE AllergyClinicalStatusCode
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
		/// <summary> Returns Statused by Person (IAM-18).</summary>
		virtual public XCN StatusedByPerson
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Statused by Organization (IAM-19).</summary>
		virtual public XON StatusedByOrganization
		{
			get
			{
				XON ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Statused at Date/Time (IAM-20).</summary>
		virtual public TS StatusedAtDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		
		/// <summary> Creates a IAM (Patient adverse reaction information - unique iden) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public IAM(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 15, new System.Object[]{message});
				this.add(typeof(CNE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(EI), true, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 8, new System.Object[]{message});
				this.add(typeof(XPN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XON), false, 1, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 8, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Allergy Reaction Code (IAM-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getAllergyReactionCode(int rep)
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
		
		/// <summary> Returns all repetitions of Allergy Reaction Code (IAM-5).</summary>
		public virtual ST[] getAllergyReactionCode()
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
	}
}