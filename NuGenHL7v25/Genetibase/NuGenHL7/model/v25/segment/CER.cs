using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 CER message segment. 
	/// This segment has the following fields:</p><p>
	/// CER-1: Set ID _ CER (SI)<br> 
	/// CER-2: Serial Number (ST)<br> 
	/// CER-3: Version (ST)<br> 
	/// CER-4: Granting Authority (XON)<br> 
	/// CER-5: Issuing Authority (XCN)<br> 
	/// CER-6: Signature of Issuing Authority (ED)<br> 
	/// CER-7: Granting Country (ID)<br> 
	/// CER-8: Granting State/Province (CWE)<br> 
	/// CER-9: Granting County/Parish (CWE)<br> 
	/// CER-10: Certificate Type (CWE)<br> 
	/// CER-11: Certificate Domain (CWE)<br> 
	/// CER-12: Subject ID (ID)<br> 
	/// CER-13: Subject Name (ST)<br> 
	/// CER-14: Subject Directory Attribute Extension (Health Professional Data) (CWE)<br> 
	/// CER-15: Subject Public Key Info (CWE)<br> 
	/// CER-16: Authority Key Identifier (CWE)<br> 
	/// CER-17: Basic Constraint (ID)<br> 
	/// CER-18: CRL Distribution Point (CWE)<br> 
	/// CER-19: Jurisdiction Country (ID)<br> 
	/// CER-20: Jurisdiction State/Province (CWE)<br> 
	/// CER-21: Jurisdiction County/Parish (CWE)<br> 
	/// CER-22: Jurisdiction Breadth (CWE)<br> 
	/// CER-23: Granting Date (TS)<br> 
	/// CER-24: Issuing Date (TS)<br> 
	/// CER-25: Activation Date (TS)<br> 
	/// CER-26: Inactivation Date (TS)<br> 
	/// CER-27: Expiration Date (TS)<br> 
	/// CER-28: Renewal Date (TS)<br> 
	/// CER-29: Revocation Date (TS)<br> 
	/// CER-30: Revocation Reason Code (CE)<br> 
	/// CER-31: Certificate Status (CWE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class CER:AbstractSegment
	{
		/// <summary> Returns Set ID _ CER (CER-1).</summary>
		virtual public SI SetIDCER
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
		/// <summary> Returns Serial Number (CER-2).</summary>
		virtual public ST SerialNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Version (CER-3).</summary>
		virtual public ST Version
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Granting Authority (CER-4).</summary>
		virtual public XON GrantingAuthority
		{
			get
			{
				XON ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Issuing Authority (CER-5).</summary>
		virtual public XCN IssuingAuthority
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
		/// <summary> Returns Signature of Issuing Authority (CER-6).</summary>
		virtual public ED SignatureOfIssuingAuthority
		{
			get
			{
				ED ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (ED) t;
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
		/// <summary> Returns Granting Country (CER-7).</summary>
		virtual public ID GrantingCountry
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Granting State/Province (CER-8).</summary>
		virtual public CWE GrantingStateProvince
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
		/// <summary> Returns Granting County/Parish (CER-9).</summary>
		virtual public CWE GrantingCountyParish
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Certificate Type (CER-10).</summary>
		virtual public CWE CertificateType
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Certificate Domain (CER-11).</summary>
		virtual public CWE CertificateDomain
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Subject ID (CER-12).</summary>
		virtual public ID SubjectID
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Subject Name (CER-13).</summary>
		virtual public ST SubjectName
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Subject Public Key Info (CER-15).</summary>
		virtual public CWE SubjectPublicKeyInfo
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Authority Key Identifier (CER-16).</summary>
		virtual public CWE AuthorityKeyIdentifier
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Basic Constraint (CER-17).</summary>
		virtual public ID BasicConstraint
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Jurisdiction Country (CER-19).</summary>
		virtual public ID JurisdictionCountry
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Jurisdiction State/Province (CER-20).</summary>
		virtual public CWE JurisdictionStateProvince
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Jurisdiction County/Parish (CER-21).</summary>
		virtual public CWE JurisdictionCountyParish
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Granting Date (CER-23).</summary>
		virtual public TS GrantingDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Issuing Date (CER-24).</summary>
		virtual public TS IssuingDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Activation Date (CER-25).</summary>
		virtual public TS ActivationDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Inactivation Date (CER-26).</summary>
		virtual public TS InactivationDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns Expiration Date (CER-27).</summary>
		virtual public TS ExpirationDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Renewal Date (CER-28).</summary>
		virtual public TS RenewalDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(28, 0);
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
		/// <summary> Returns Revocation Date (CER-29).</summary>
		virtual public TS RevocationDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(29, 0);
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
		/// <summary> Returns Revocation Reason Code (CER-30).</summary>
		virtual public CE RevocationReasonCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(30, 0);
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
		/// <summary> Returns Certificate Status (CER-31).</summary>
		virtual public CWE CertificateStatus
		{
			get
			{
				CWE ret = null;
				try
				{
					Type t = this.getField(31, 0);
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
		
		/// <summary> Creates a CER (Certificate Detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public CER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XON), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ED), false, 1, 65536, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 399});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 250, new System.Object[]{message, 0});
				this.add(typeof(ST), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 250, new System.Object[]{message, 136});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 399});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Subject Directory Attribute Extension (Health Professional Data) (CER-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getSubjectDirectoryAttributeExtensionHealthProfessionalData(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Subject Directory Attribute Extension (Health Professional Data) (CER-14).</summary>
		public virtual CWE[] getSubjectDirectoryAttributeExtensionHealthProfessionalData()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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
		
		/// <summary> Returns a single repetition of CRL Distribution Point (CER-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getCRLDistributionPoint(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of CRL Distribution Point (CER-18).</summary>
		public virtual CWE[] getCRLDistributionPoint()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(18);
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
		
		/// <summary> Returns a single repetition of Jurisdiction Breadth (CER-22).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CWE getJurisdictionBreadth(int rep)
		{
			CWE ret = null;
			try
			{
				Type t = this.getField(22, rep);
				ret = (CWE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Jurisdiction Breadth (CER-22).</summary>
		public virtual CWE[] getJurisdictionBreadth()
		{
			CWE[] ret = null;
			try
			{
				Type[] t = this.getField(22);
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