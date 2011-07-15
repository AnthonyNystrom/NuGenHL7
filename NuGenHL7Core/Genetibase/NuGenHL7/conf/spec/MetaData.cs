using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec
{
	
	/// <summary> Conformance Profile meta data (an element of ConformanceProfile and StaticDef).  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class MetaData
	{
		[System.ComponentModel.Browsable(true)]


		virtual public System.String Name
		{
			get
			{
				return this.name;
			}
			
			set
			{
				System.String oldName = this.name;
				try
				{
					SupportClass.PropertyChangingEventArgs ve52 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.name = value;
				SupportClass.PropertyChangingEventArgs me52 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


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
					SupportClass.PropertyChangingEventArgs ve53 = new SupportClass.PropertyChangingEventArgs("orgName", oldOrgName, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.orgName = value;
				SupportClass.PropertyChangingEventArgs me53 = new SupportClass.PropertyChangingEventArgs("orgName", oldOrgName, value);


			}
			
		}

		virtual public System.String Version
		{
			get
			{
				return this.version;
			}
			
			set
			{
				System.String oldVersion = this.version;
				try
				{
					SupportClass.PropertyChangingEventArgs ve54 = new SupportClass.PropertyChangingEventArgs("version", oldVersion, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.version = value;
				SupportClass.PropertyChangingEventArgs me54 = new SupportClass.PropertyChangingEventArgs("version", oldVersion, value);


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
					SupportClass.PropertyChangingEventArgs ve55 = new SupportClass.PropertyChangingEventArgs("status", oldStatus, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.status = value;
				SupportClass.PropertyChangingEventArgs me55 = new SupportClass.PropertyChangingEventArgs("status", oldStatus, value);


			}
			
		}

		virtual public System.String Topics
		{
			get
			{
				return this.topics;
			}
			
			set
			{
				System.String oldTopics = this.topics;
				try
				{
					SupportClass.PropertyChangingEventArgs ve56 = new SupportClass.PropertyChangingEventArgs("topics", oldTopics, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.topics = value;
				SupportClass.PropertyChangingEventArgs me56 = new SupportClass.PropertyChangingEventArgs("topics", oldTopics, value);


			}
			
		}
		
		/// <summary>Holds value of property name. </summary>
		private System.String name;
		
		/// <summary>Holds value of property orgName. </summary>
		private System.String orgName;
		
		/// <summary>Holds value of property version. </summary>
		private System.String version;
		
		/// <summary>Holds value of property status. </summary>
		private System.String status;
		
		/// <summary>Holds value of property topics. </summary>
		private System.String topics;
	}
}