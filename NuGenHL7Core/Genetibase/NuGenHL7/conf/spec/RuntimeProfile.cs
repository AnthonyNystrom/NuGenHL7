using System;
using UseCase = Genetibase.NuGenHL7.conf.spec.usecase.UseCase;
using StaticDef = Genetibase.NuGenHL7.conf.spec.message.StaticDef;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec
{
	
	/// <summary> A conformance specification (see HL7 2.5 section 2.12).  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class RuntimeProfile
	{
		[System.ComponentModel.Browsable(true)]


		virtual public System.String ImpNote
		{
			get
			{
				return this.impNote;
			}
			
			set
			{
				System.String oldImpNote = this.impNote;
				try
				{
					SupportClass.PropertyChangingEventArgs ve57 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.impNote = value;
				SupportClass.PropertyChangingEventArgs me57 = new SupportClass.PropertyChangingEventArgs("impNote", oldImpNote, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve58 = new SupportClass.PropertyChangingEventArgs("useCase", oldUseCase, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.useCase = value;
				SupportClass.PropertyChangingEventArgs me58 = new SupportClass.PropertyChangingEventArgs("useCase", oldUseCase, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve59 = new SupportClass.PropertyChangingEventArgs("conformance", oldConformance, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.conformance = value;
				SupportClass.PropertyChangingEventArgs me59 = new SupportClass.PropertyChangingEventArgs("conformance", oldConformance, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve61 = new SupportClass.PropertyChangingEventArgs("message", oldMessage, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.message = value;
				SupportClass.PropertyChangingEventArgs me61 = new SupportClass.PropertyChangingEventArgs("message", oldMessage, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve62 = new SupportClass.PropertyChangingEventArgs("specName", oldSpecName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.specName = value;
				SupportClass.PropertyChangingEventArgs me62 = new SupportClass.PropertyChangingEventArgs("specName", oldSpecName, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve63 = new SupportClass.PropertyChangingEventArgs("orgName", oldOrgName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.orgName = value;
				SupportClass.PropertyChangingEventArgs me63 = new SupportClass.PropertyChangingEventArgs("orgName", oldOrgName, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve65 = new SupportClass.PropertyChangingEventArgs("specVersion", oldSpecVersion, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.specVersion = value;
				SupportClass.PropertyChangingEventArgs me65 = new SupportClass.PropertyChangingEventArgs("specVersion", oldSpecVersion, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve66 = new SupportClass.PropertyChangingEventArgs("status", oldStatus, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.status = value;
				SupportClass.PropertyChangingEventArgs me66 = new SupportClass.PropertyChangingEventArgs("status", oldStatus, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve67 = new SupportClass.PropertyChangingEventArgs("role", oldRole, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.role = value;
				SupportClass.PropertyChangingEventArgs me67 = new SupportClass.PropertyChangingEventArgs("role", oldRole, value);


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
				try
				{
					SupportClass.PropertyChangingEventArgs ve69 = new SupportClass.PropertyChangingEventArgs("conformanceType", oldConformanceType, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.conformanceType = value;
				SupportClass.PropertyChangingEventArgs me69 = new SupportClass.PropertyChangingEventArgs("conformanceType", oldConformanceType, value);


			}
			
		}
		
		private System.String impNote;
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
		/// <throws>  ProfileException </throws>
		public virtual void  setEncodings(int index, Encoding encodings)
		{
			Encoding oldEncodings = this.encodings[index];
			this.encodings[index] = encodings;
			try
			{
				SupportClass.PropertyChangingEventArgs ve60 = new SupportClass.PropertyChangingEventArgs("encodings", null, null);


			}
			catch (System.ArgumentOutOfRangeException vetoException)
			{
				this.encodings[index] = oldEncodings;
				throw new NuGenProfileException(null, vetoException);
			}
			SupportClass.PropertyChangingEventArgs me60 = new SupportClass.PropertyChangingEventArgs("encodings", null, null);


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
		/// <throws>  ProfileException </throws>
		public virtual void  setHL7Version(System.String HL7Version)
		{
			System.String oldHL7Version = this.HL7Version;
			try
			{
				SupportClass.PropertyChangingEventArgs ve64 = new SupportClass.PropertyChangingEventArgs("HL7Version", oldHL7Version, HL7Version);


			}
			catch (System.Exception e)
			{
				throw new NuGenProfileException(null, e);
			}
			this.HL7Version = HL7Version;
			SupportClass.PropertyChangingEventArgs me64 = new SupportClass.PropertyChangingEventArgs("HL7Version", oldHL7Version, HL7Version);


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
		/// <throws>  ProfileException </throws>
		public virtual void  setHL7OID(System.String HL7OID)
		{
			System.String oldHL7OID = this.HL7OID;
			try
			{
				SupportClass.PropertyChangingEventArgs ve68 = new SupportClass.PropertyChangingEventArgs("HL7OID", oldHL7OID, HL7OID);


			}
			catch (System.Exception e)
			{
				throw new NuGenProfileException(null, e);
			}
			this.HL7OID = HL7OID;
			SupportClass.PropertyChangingEventArgs me68 = new SupportClass.PropertyChangingEventArgs("HL7OID", oldHL7OID, HL7OID);


		}
	}
}