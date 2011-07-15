using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.spec.message
{
	
	/// <summary> An explicit data value specified in a message profile.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class DataValue
	{
		[System.ComponentModel.Browsable(true)]


		virtual public System.String ExValue
		{
			get
			{
				return this.exValue;
			}
			
			set
			{
				System.String oldExValue = this.exValue;
				try
				{
					SupportClass.PropertyChangingEventArgs ve23 = new SupportClass.PropertyChangingEventArgs("exValue", oldExValue, value);


				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException(null, e);
				}
				this.exValue = value;
				SupportClass.PropertyChangingEventArgs me23 = new SupportClass.PropertyChangingEventArgs("exValue", oldExValue, value);


			}
			
		}
		
		/// <summary>Holds value of property exValue. </summary>
		private System.String exValue;
	}
}