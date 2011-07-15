using System;
namespace Genetibase.NuGenHL7.conf.spec.usecase
{
	
	/// <summary> An abstraction of the parts of a use case (eg EventFlow), all of which have a name and a body.  </summary>
	/// <author>  Bryan Tripp 
	/// </author>
	public class AbstractUseCaseComponent
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
				SupportClass.PropertyChangingEventArgs ve83 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


				this.name = value;
				SupportClass.PropertyChangingEventArgs me83 = new SupportClass.PropertyChangingEventArgs("name", oldName, value);


			}
			
		}

		virtual public System.String Body
		{
			get
			{
				return this.body;
			}
			
			set
			{
				System.String oldBody = this.body;
				SupportClass.PropertyChangingEventArgs ve84 = new SupportClass.PropertyChangingEventArgs("body", oldBody, value);


				this.body = value;
				SupportClass.PropertyChangingEventArgs me84 = new SupportClass.PropertyChangingEventArgs("body", oldBody, value);


			}
			
		}
		
		/// <summary>Holds value of property name. </summary>
		private System.String name;
		
		/// <summary>Holds value of property body. </summary>
		private System.String body;
	}
}