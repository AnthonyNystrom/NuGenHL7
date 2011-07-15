using System;
using UseCase = Genetibase.NuGenHL7.conf.spec.usecase.UseCase;
using StaticDef = Genetibase.NuGenHL7.conf.spec.message.StaticDef;
namespace Genetibase.NuGenHL7.conf.spec
{
	
	/// <summary> A conformance specification (see HL7 2.5 section 2.12).  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class Specification
	{
		[System.ComponentModel.Browsable(true)]


		virtual public ImpNote ImpNote
		{
			get
			{
				return this.impNote;
			}
			
			set
			{
				ImpNote oldImpNote = this.impNote;
				SupportClass.PropertyChangingEventArgs ve70 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


				this.impNote = value;
				SupportClass.PropertyChangingEventArgs me70 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


			}
			
		}

		virtual public UseCase UseCase
		{
			get
			{
				return this.useCase;
			}
			
			set
			{
				UseCase oldUseCase = this.useCase;
				SupportClass.PropertyChangingEventArgs ve71 = new SupportClass.PropertyChangingEventArgs("useCase", oldUseCase, value);


				this.useCase = value;
				SupportClass.PropertyChangingEventArgs me71 = new SupportClass.PropertyChangingEventArgs("useCase", oldUseCase, value);


			}
			
		}

		virtual public Conformance Conformance
		{
			get
			{
				return this.conformance;
			}
			
			set
			{
				Conformance oldConformance = this.conformance;
				SupportClass.PropertyChangingEventArgs ve72 = new SupportClass.PropertyChangingEventArgs("conformance", oldConformance, value);


				this.conformance = value;
				SupportClass.PropertyChangingEventArgs me72 = new SupportClass.PropertyChangingEventArgs("conformance", oldConformance, value);


			}
			
		}

		virtual public StaticDef Message
		{
			get
			{
				return this.message;
			}
			
			set
			{
				StaticDef oldMessage = this.message;
				SupportClass.PropertyChangingEventArgs ve74 = new SupportClass.PropertyChangingEventArgs("message", oldMessage, value);


				this.message = value;
				SupportClass.PropertyChangingEventArgs me74 = new SupportClass.PropertyChangingEventArgs("message", oldMessage, value);


			}
			
		}

		virtual public System.String SpecName
		{
			get
			{
				return this.specName;
			}
			
			set
			{
				System.String oldSpecName = this.specName;
				SupportClass.PropertyChangingEventArgs ve75 = new SupportClass.PropertyChangingEventArgs("specName", oldSpecName, value);


				this.specName = value;
				SupportClass.PropertyChangingEventArgs me75 = new SupportClass.PropertyChangingEventArgs("specName", oldSpecName, value);


			}
			
		}

		virtual public System.String OrgName
		{
			get
			{
				return this.orgName;
			}
			
			set
			{
				System.String oldOrgName = this.orgName;
				SupportClass.PropertyChangingEventArgs ve76 = new SupportClass.PropertyChangingEventArgs("orgName", oldOrgName, value);


				this.orgName = value;
				SupportClass.PropertyChangingEventArgs me76 = new SupportClass.PropertyChangingEventArgs("orgName", oldOrgName, value);


			}
			
		}

		virtual public System.String SpecVersion
		{
			get
			{
				return this.specVersion;
			}
			
			set
			{
				System.String oldSpecVersion = this.specVersion;
				SupportClass.PropertyChangingEventArgs ve78 = new SupportClass.PropertyChangingEventArgs("specVersion", oldSpecVersion, value);


				this.specVersion = value;
				SupportClass.PropertyChangingEventArgs me78 = new SupportClass.PropertyChangingEventArgs("specVersion", oldSpecVersion, value);


			}
			
		}

		virtual public System.String Status
		{
			get
			{
				return this.status;
			}
			
			set
			{
				System.String oldStatus = this.status;
				SupportClass.PropertyChangingEventArgs ve79 = new SupportClass.PropertyChangingEventArgs("status", oldStatus, value);


				this.status = value;
				SupportClass.PropertyChangingEventArgs me79 = new SupportClass.PropertyChangingEventArgs("status", oldStatus, value);


			}
			
		}

		virtual public System.String Role
		{
			get
			{
				return this.role;
			}
			
			set
			{
				System.String oldRole = this.role;
				SupportClass.PropertyChangingEventArgs ve80 = new SupportClass.PropertyChangingEventArgs("role", oldRole, value);


				this.role = value;
				SupportClass.PropertyChangingEventArgs me80 = new SupportClass.PropertyChangingEventArgs("role", oldRole, value);


			}
			
		}

		virtual public System.String ConformanceType
		{
			get
			{
				return this.conformanceType;
			}
			
			set
			{
				System.String oldConformanceType = this.conformanceType;
				SupportClass.PropertyChangingEventArgs ve82 = new SupportClass.PropertyChangingEventArgs("conformanceType", oldConformanceType, value);


				this.conformanceType = value;
				SupportClass.PropertyChangingEventArgs me82 = new SupportClass.PropertyChangingEventArgs("conformanceType", oldConformanceType, value);


			}
			
		}
		
		private ImpNote impNote;
		private UseCase useCase;
		private Conformance conformance;
		private Encoding[] encodings = new Encoding[10];		
		
		/// <summary>Holds value of property message. </summary>
		private StaticDef message;
		
		/// <summary>Holds value of property specName. </summary>
		private System.String specName;
		
		/// <summary>Holds value of property orgName. </summary>
		private System.String orgName;
		
		/// <summary>Holds value of property HL7Version. </summary>
		private System.String HL7Version;
		
		/// <summary>Holds value of property specVersion. </summary>
		private System.String specVersion;
		
		/// <summary>Holds value of property status. </summary>
		private System.String status;
		
		/// <summary>Holds value of property role. </summary>
		private System.String role;
		
		/// <summary>Holds value of property HL7OID. </summary>
		private System.String HL7OID;
		
		/// <summary>Holds value of property conformanceType. </summary>
		private System.String conformanceType;
		
		/// <summary>Indexed getter for property encodings.</summary>
		/// <param name="index">Index of the property.
		/// </param>
		/// <returns> Value of the property at <CODE>index</CODE>.
		/// </returns>
		public virtual Encoding getEncodings(int index)
		{
			return this.encodings[index];
		}
		
		/// <summary>Indexed setter for property encodings.</summary>
		/// <param name="index">Index of the property.
		/// </param>
		/// <param name="encodings">New value of the property at <CODE>index</CODE>.
		/// 
		/// </param>
		/// <throws>  PropertyVetoException </throws>
		public virtual void  setEncodings(int index, Encoding encodings)
		{
			Encoding oldEncodings = this.encodings[index];
			this.encodings[index] = encodings;
			try
			{
				SupportClass.PropertyChangingEventArgs ve73 = new SupportClass.PropertyChangingEventArgs("encodings", null, null);


			}
			catch (System.ArgumentOutOfRangeException vetoException)
			{
				this.encodings[index] = oldEncodings;
				throw vetoException;
			}
			SupportClass.PropertyChangingEventArgs me73 = new SupportClass.PropertyChangingEventArgs("encodings", null, null);


		}
		
		/// <summary>Getter for property HL7Version.</summary>
		/// <returns> Value of property HL7Version.
		/// </returns>
		public virtual System.String getHL7Version()
		{
			return this.HL7Version;
		}
		
		/// <summary>Setter for property HL7Version.</summary>
		/// <param name="HL7Version">New value of property HL7Version.
		/// 
		/// </param>
		/// <throws>  PropertyVetoException </throws>
		public virtual void  setHL7Version(System.String HL7Version)
		{
			System.String oldHL7Version = this.HL7Version;
			SupportClass.PropertyChangingEventArgs ve77 = new SupportClass.PropertyChangingEventArgs("HL7Version", oldHL7Version, HL7Version);


			this.HL7Version = HL7Version;
			SupportClass.PropertyChangingEventArgs me77 = new SupportClass.PropertyChangingEventArgs("HL7Version", oldHL7Version, HL7Version);


		}
		
		/// <summary>Getter for property HL7OID.</summary>
		/// <returns> Value of property HL7OID.
		/// </returns>
		public virtual System.String getHL7OID()
		{
			return this.HL7OID;
		}
		
		/// <summary>Setter for property HL7OID.</summary>
		/// <param name="HL7OID">New value of property HL7OID.
		/// 
		/// </param>
		/// <throws>  PropertyVetoException </throws>
		public virtual void  setHL7OID(System.String HL7OID)
		{
			System.String oldHL7OID = this.HL7OID;
			SupportClass.PropertyChangingEventArgs ve81 = new SupportClass.PropertyChangingEventArgs("HL7OID", oldHL7OID, HL7OID);


			this.HL7OID = HL7OID;
			SupportClass.PropertyChangingEventArgs me81 = new SupportClass.PropertyChangingEventArgs("HL7OID", oldHL7OID, HL7OID);


		}
	}
}