using System;
using Message = Genetibase.NuGenHL7.model.Message;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> An application that returns AA acknowledgements.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenAcceptApplication:NuGenDefaultApplication
	{
		
		/// <summary>Creates a new instance of AcceptApplication </summary>
		public NuGenAcceptApplication()
		{
		}
		
		/// <summary> Supplies details of application accept (AA) acknowledgement. 
		/// Actually this method does nothing, because DefaultApplication.makeACK() 
		/// supplies the desired values (this is just here to override inclusion of the 
		/// default error message).  
		/// </summary>
		public override void  fillDetails(Message ack)
		{
			//do nothing -- no more information needed 
		}
	}
}