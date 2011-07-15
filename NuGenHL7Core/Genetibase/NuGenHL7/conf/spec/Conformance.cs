using System;
namespace Genetibase.NuGenHL7.conf.spec
{
	
	/// <summary> Part of a specification that defines application behavior and IDs 
	/// for other parts of the spec.   
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class Conformance
	{
		[System.ComponentModel.Browsable(true)]
		virtual public System.String AcceptAck
		{
			get
			{
				return this.acceptAck;
			}
			
			set
			{
				System.String oldAcceptAck = this.acceptAck;
				SupportClass.PropertyChangingEventArgs ve = new SupportClass.PropertyChangingEventArgs("acceptAck", oldAcceptAck, value);


				this.acceptAck = value;
				SupportClass.PropertyChangingEventArgs me = new SupportClass.PropertyChangingEventArgs("acceptAck", oldAcceptAck, value);
			}
			
		}

		virtual public System.String ApplicationAck
		{
			get
			{
				return this.applicationAck;
			}
			
			set
			{
				System.String oldApplicationAck = this.applicationAck;
				SupportClass.PropertyChangingEventArgs ve2 = new SupportClass.PropertyChangingEventArgs("applicationAck", oldApplicationAck, value);


				this.applicationAck = value;
				SupportClass.PropertyChangingEventArgs me2 = new SupportClass.PropertyChangingEventArgs("applicationAck", oldApplicationAck, value);
			}
			
		}

		virtual public System.String StaticID
		{
			get
			{
				return this.staticID;
			}
			
			set
			{
				System.String oldStaticID = this.staticID;
				SupportClass.PropertyChangingEventArgs ve3 = new SupportClass.PropertyChangingEventArgs("staticID", oldStaticID, value);


				this.staticID = value;
				SupportClass.PropertyChangingEventArgs me3 = new SupportClass.PropertyChangingEventArgs("staticID", oldStaticID, value);
			}
			
		}

		virtual public System.String DnamicID
		{
			get
			{
				return this.dnamicID;
			}
			
			set
			{
				System.String oldDnamicID = this.dnamicID;
				SupportClass.PropertyChangingEventArgs ve4 = new SupportClass.PropertyChangingEventArgs("dnamicID", oldDnamicID, value);


				this.dnamicID = value;
				SupportClass.PropertyChangingEventArgs me4 = new SupportClass.PropertyChangingEventArgs("dnamicID", oldDnamicID, value);
			}
			
		}

		virtual public System.String MsgAckMode
		{
			get
			{
				return this.msgAckMode;
			}
			
			set
			{
				System.String oldMsgAckMode = this.msgAckMode;
				SupportClass.PropertyChangingEventArgs ve5 = new SupportClass.PropertyChangingEventArgs("msgAckMode", oldMsgAckMode, value);


				this.msgAckMode = value;
				SupportClass.PropertyChangingEventArgs me5 = new SupportClass.PropertyChangingEventArgs("msgAckMode", oldMsgAckMode, value);
			}
			
		}
		
		/// <summary>Holds value of property acceptAck. </summary>
		private System.String acceptAck;
		
		/// <summary>Holds value of property applicationAck. </summary>
		private System.String applicationAck;
		
		/// <summary>Holds value of property staticID. </summary>
		private System.String staticID;
		
		/// <summary>Holds value of property dnamicID. </summary>
		private System.String dnamicID;
		
		/// <summary>Holds value of property msgAckMode. </summary>
		private System.String msgAckMode;
	}
}