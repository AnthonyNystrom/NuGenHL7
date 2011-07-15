using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 NK1 message segment. 
	/// This segment has the following fields:</p><p>
	/// NK1-1: Set ID - NK1 (SI)<br> 
	/// NK1-2: NK Name (XPN)<br> 
	/// NK1-3: Relationship (CE)<br> 
	/// NK1-4: Address (XAD)<br> 
	/// NK1-5: Phone Number (XTN)<br> 
	/// NK1-6: Business Phone Number (XTN)<br> 
	/// NK1-7: Contact Role (CE)<br> 
	/// NK1-8: Start Date (DT)<br> 
	/// NK1-9: End Date (DT)<br> 
	/// NK1-10: Next of Kin / Associated Parties Job Title (ST)<br> 
	/// NK1-11: Next of Kin / Associated Parties Job Code/Class (JCC)<br> 
	/// NK1-12: Next of Kin / Associated Parties Employee Number (CX)<br> 
	/// NK1-13: Organization Name - NK1 (XON)<br> 
	/// NK1-14: Marital Status (CE)<br> 
	/// NK1-15: Administrative Sex (IS)<br> 
	/// NK1-16: Date/Time Of Birth (TS)<br> 
	/// NK1-17: Living Dependency (IS)<br> 
	/// NK1-18: Ambulatory Status (IS)<br> 
	/// NK1-19: Citizenship (CE)<br> 
	/// NK1-20: Primary Language (CE)<br> 
	/// NK1-21: Living Arrangement (IS)<br> 
	/// NK1-22: Publicity Code (CE)<br> 
	/// NK1-23: Protection Indicator (ID)<br> 
	/// NK1-24: Student Indicator (IS)<br> 
	/// NK1-25: Religion (CE)<br> 
	/// NK1-26: Mother's Maiden Name (XPN)<br> 
	/// NK1-27: Nationality (CE)<br> 
	/// NK1-28: Ethnic Group (CE)<br> 
	/// NK1-29: Contact Reason (CE)<br> 
	/// NK1-30: Contact Person's Name (XPN)<br> 
	/// NK1-31: Contact Person's Telephone Number (XTN)<br> 
	/// NK1-32: Contact Person's Address (XAD)<br> 
	/// NK1-33: Next of Kin/Associated Party's Identifiers (CX)<br> 
	/// NK1-34: Job Status (IS)<br> 
	/// NK1-35: Race (CE)<br> 
	/// NK1-36: Handicap (IS)<br> 
	/// NK1-37: Contact Person Social Security Number (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NK1:AbstractSegment
	{
		/// <summary> Returns Set ID - NK1 (NK1-1).</summary>
		virtual public SI SetIDNK1
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
		/// <summary> Returns Relationship (NK1-3).</summary>
		virtual public CE Relationship
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
		/// <summary> Returns Contact Role (NK1-7).</summary>
		virtual public CE ContactRole
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Start Date (NK1-8).</summary>
		virtual public DT StartDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns End Date (NK1-9).</summary>
		virtual public DT EndDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Next of Kin / Associated Parties Job Title (NK1-10).</summary>
		virtual public ST NextOfKinAssociatedPartiesJobTitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Next of Kin / Associated Parties Job Code/Class (NK1-11).</summary>
		virtual public JCC NextOfKinAssociatedPartiesJobCodeClass
		{
			get
			{
				JCC ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (JCC) t;
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
		/// <summary> Returns Next of Kin / Associated Parties Employee Number (NK1-12).</summary>
		virtual public CX NextOfKinAssociatedPartiesEmployeeNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CX) t;
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
		/// <summary> Returns Marital Status (NK1-14).</summary>
		virtual public CE MaritalStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Administrative Sex (NK1-15).</summary>
		virtual public IS AdministrativeSex
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Date/Time Of Birth (NK1-16).</summary>
		virtual public TS DateTimeOfBirth
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Primary Language (NK1-20).</summary>
		virtual public CE PrimaryLanguage
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
		/// <summary> Returns Living Arrangement (NK1-21).</summary>
		virtual public IS LivingArrangement
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Publicity Code (NK1-22).</summary>
		virtual public CE PublicityCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Protection Indicator (NK1-23).</summary>
		virtual public ID ProtectionIndicator
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
		/// <summary> Returns Student Indicator (NK1-24).</summary>
		virtual public IS StudentIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Religion (NK1-25).</summary>
		virtual public CE Religion
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Nationality (NK1-27).</summary>
		virtual public CE Nationality
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Job Status (NK1-34).</summary>
		virtual public IS JobStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(34, 0);
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
		/// <summary> Returns Handicap (NK1-36).</summary>
		virtual public IS Handicap
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Contact Person Social Security Number (NK1-37).</summary>
		virtual public ST ContactPersonSocialSecurityNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(37, 0);
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
		
		/// <summary> Creates a NK1 (Next of kin / associated parties) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NK1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(JCC), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 223});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 9});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 311});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295});
				this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of NK Name (NK1-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getNKName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of NK Name (NK1-2).</summary>
		public virtual XPN[] getNKName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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
		
		/// <summary> Returns a single repetition of Address (NK1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Address (NK1-4).</summary>
		public virtual XAD[] getAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Phone Number (NK1-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone Number (NK1-5).</summary>
		public virtual XTN[] getPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of Business Phone Number (NK1-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getBusinessPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Business Phone Number (NK1-6).</summary>
		public virtual XTN[] getBusinessPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of Organization Name - NK1 (NK1-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getOrganizationNameNK1(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Organization Name - NK1 (NK1-13).</summary>
		public virtual XON[] getOrganizationNameNK1()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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
		
		/// <summary> Returns a single repetition of Living Dependency (NK1-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getLivingDependency(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Living Dependency (NK1-17).</summary>
		public virtual IS[] getLivingDependency()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(17);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Ambulatory Status (NK1-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getAmbulatoryStatus(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ambulatory Status (NK1-18).</summary>
		public virtual IS[] getAmbulatoryStatus()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(18);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Citizenship (NK1-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCitizenship(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Citizenship (NK1-19).</summary>
		public virtual CE[] getCitizenship()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(19);
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
		
		/// <summary> Returns a single repetition of Mother's Maiden Name (NK1-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getMotherSMaidenName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Mother's Maiden Name (NK1-26).</summary>
		public virtual XPN[] getMotherSMaidenName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(26);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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
		
		/// <summary> Returns a single repetition of Ethnic Group (NK1-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getEthnicGroup(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ethnic Group (NK1-28).</summary>
		public virtual CE[] getEthnicGroup()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(28);
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
		
		/// <summary> Returns a single repetition of Contact Reason (NK1-29).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getContactReason(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(29, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Reason (NK1-29).</summary>
		public virtual CE[] getContactReason()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(29);
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
		
		/// <summary> Returns a single repetition of Contact Person's Name (NK1-30).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getContactPersonSName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(30, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Person's Name (NK1-30).</summary>
		public virtual XPN[] getContactPersonSName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(30);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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
		
		/// <summary> Returns a single repetition of Contact Person's Telephone Number (NK1-31).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getContactPersonSTelephoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(31, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Person's Telephone Number (NK1-31).</summary>
		public virtual XTN[] getContactPersonSTelephoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(31);
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
		
		/// <summary> Returns a single repetition of Contact Person's Address (NK1-32).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getContactPersonSAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(32, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact Person's Address (NK1-32).</summary>
		public virtual XAD[] getContactPersonSAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(32);
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
		
		/// <summary> Returns a single repetition of Next of Kin/Associated Party's Identifiers (NK1-33).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getNextOfKinAssociatedPartySIdentifiers(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(33, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Next of Kin/Associated Party's Identifiers (NK1-33).</summary>
		public virtual CX[] getNextOfKinAssociatedPartySIdentifiers()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(33);
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CX) t[i];
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
		
		/// <summary> Returns a single repetition of Race (NK1-35).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getRace(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(35, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Race (NK1-35).</summary>
		public virtual CE[] getRace()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(35);
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