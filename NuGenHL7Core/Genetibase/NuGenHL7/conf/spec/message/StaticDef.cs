using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
using MetaData = Genetibase.NuGenHL7.conf.spec.MetaData;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	
	/// <summary> <p>A "static message profile" (see HL7 2.5 section 2.12).  Message profiles are 
	/// a precise method of documenting message constraints, using a standard XML syntax 
	/// defined by HL7 (introduced in version 2.5).  XML message profiles define
	/// constraints on message content and structure in a well-defined manner, so that 
	/// the conformance of a certain message to a certain profile can be tested automatically.  
	/// There are several types of profiles: 
	/// <ul><li>HL7 Profiles - the standard messages (relatively loosely constrained)</li>
	/// <li>Implementable Profiles - profiles with additional constraints such that all optionality 
	/// has been removed (e.g. optional fields marked as "required" or "not supported").   
	/// <li>Constrainable Profiles - any profile with optionality that can be further constrained.</li></ul>
	/// Thus profiles can constrain other profiles.  A typical case would be for a country to create a 
	/// constrainable profile based on an HL7 profile, for a vendor to create a different constrainable 
	/// profile based on the same HL7 profile, and for a hospital to create an implementable profile for 
	/// a particular implementation that constrains both.  </p>
	/// <p>The MessageProfile class is a parsed object representation of the XML profile.</p>
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class StaticDef:AbstractSegmentContainer
	{
		[System.ComponentModel.Browsable(true)]


		virtual public MetaData MetaData
		{
			get
			{
				return this.metaData;
			}
			
			set
			{
				MetaData oldMetaData = this.metaData;
				try
				{
					SupportClass.PropertyChangingEventArgs ve44 = new SupportClass.PropertyChangingEventArgs("metaData", oldMetaData, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.metaData = value;
				SupportClass.PropertyChangingEventArgs me44 = new SupportClass.PropertyChangingEventArgs("metaData", oldMetaData, value);


			}
			
		}

		virtual public System.String MsgType
		{
			get
			{
				return this.msgType;
			}
			
			set
			{
				System.String oldMsgType = this.msgType;
				try
				{
					SupportClass.PropertyChangingEventArgs ve45 = new SupportClass.PropertyChangingEventArgs("msgType", oldMsgType, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.msgType = value;
				SupportClass.PropertyChangingEventArgs me45 = new SupportClass.PropertyChangingEventArgs("msgType", oldMsgType, value);


			}
			
		}

		virtual public System.String EventType
		{
			get
			{
				return this.eventType;
			}
			
			set
			{
				System.String oldEventType = this.eventType;
				try
				{
					SupportClass.PropertyChangingEventArgs ve46 = new SupportClass.PropertyChangingEventArgs("eventType", oldEventType, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.eventType = value;
				SupportClass.PropertyChangingEventArgs me46 = new SupportClass.PropertyChangingEventArgs("eventType", oldEventType, value);


			}
			
		}

		virtual public System.String MsgStructID
		{
			get
			{
				return this.msgStructID;
			}
			
			set
			{
				System.String oldMsgStructID = this.msgStructID;
				try
				{
					SupportClass.PropertyChangingEventArgs ve47 = new SupportClass.PropertyChangingEventArgs("msgStructID", oldMsgStructID, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.msgStructID = value;
				SupportClass.PropertyChangingEventArgs me47 = new SupportClass.PropertyChangingEventArgs("msgStructID", oldMsgStructID, value);


			}
			
		}

		virtual public System.String OrderControl
		{
			get
			{
				return this.orderControl;
			}
			
			set
			{
				System.String oldOrderControl = this.orderControl;
				try
				{
					SupportClass.PropertyChangingEventArgs ve48 = new SupportClass.PropertyChangingEventArgs("orderControl", oldOrderControl, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.orderControl = value;
				SupportClass.PropertyChangingEventArgs me48 = new SupportClass.PropertyChangingEventArgs("orderControl", oldOrderControl, value);


			}
			
		}

		virtual public System.String EventDesc
		{
			get
			{
				return this.eventDesc;
			}
			
			set
			{
				System.String oldEventDesc = this.eventDesc;
				try
				{
					SupportClass.PropertyChangingEventArgs ve49 = new SupportClass.PropertyChangingEventArgs("eventDesc", oldEventDesc, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.eventDesc = value;
				SupportClass.PropertyChangingEventArgs me49 = new SupportClass.PropertyChangingEventArgs("eventDesc", oldEventDesc, value);


			}
			
		}

		virtual public System.String Identifier
		{
			get
			{
				return this.identifier;
			}
			
			set
			{
				System.String oldIdentifier = this.identifier;
				try
				{
					SupportClass.PropertyChangingEventArgs ve50 = new SupportClass.PropertyChangingEventArgs("identifier", oldIdentifier, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.identifier = value;
				SupportClass.PropertyChangingEventArgs me50 = new SupportClass.PropertyChangingEventArgs("identifier", oldIdentifier, value);


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
					SupportClass.PropertyChangingEventArgs ve51 = new SupportClass.PropertyChangingEventArgs("role", oldRole, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.role = value;
				SupportClass.PropertyChangingEventArgs me51 = new SupportClass.PropertyChangingEventArgs("role", oldRole, value);


			}
			
		}
		
		private MetaData metaData;
		private System.String msgType;
		private System.String eventType;
		private System.String msgStructID;
		private System.String orderControl;
		private System.String eventDesc;
		private System.String identifier;
		private System.String role;
	}
}