using System;
namespace Genetibase.NuGenHL7.conf.spec
{
	
	/// <summary> An implementation note.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class ImpNote
	{
		[System.ComponentModel.Browsable(true)]


		virtual public System.String Text
		{
			get
			{
				return this.text;
			}
			
			set
			{
				System.String oldText = this.text;
				SupportClass.PropertyChangingEventArgs ve6 = new SupportClass.PropertyChangingEventArgs("text", oldText, value);


				this.text = value;
				SupportClass.PropertyChangingEventArgs me6 = new SupportClass.PropertyChangingEventArgs("text", oldText, value);


			}
			
		}
		
		/// <summary>Holds value of property text. </summary>
		private System.String text;
	}
}