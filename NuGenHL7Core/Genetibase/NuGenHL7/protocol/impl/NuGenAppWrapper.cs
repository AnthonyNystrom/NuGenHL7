/*
* Created on 16-May-2005
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Application = Genetibase.NuGenHL7.app.NuGenApplication;
using ApplicationException = Genetibase.NuGenHL7.app.NuGenApplicationException;
using Message = Genetibase.NuGenHL7.model.Message;
using ReceivingApplication = Genetibase.NuGenHL7.protocol.NuGenReceivingApplication;
using ReceivingApplicationException = Genetibase.NuGenHL7.protocol.NuGenReceivingApplicationException;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> Wraps a Genetibase.NuGenHL7.app.Application as a Genetibase.NuGenHL7.protocol.ReceivingApplication. 
	/// ReceivingApplication replaces Application with HAPI 0.5.
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2005/05/16 16:51:24 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenAppWrapper : NuGenReceivingApplication
	{
		
		private Application myApplication;
		
		/// <param name="theApplication">an Application to wrap as a ReceivingApplication.  
		/// </param>
		public NuGenAppWrapper(Application theApplication)
		{
			myApplication = theApplication;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ReceivingApplication.processMessage(Genetibase.NuGenHL7.model.Message, java.util.Map)">
		/// </seealso>
		public virtual Message processMessage(Message theMessage, System.Collections.IDictionary theMetadata)
		{
			Message result = null;
			
			try
			{
				result = myApplication.processMessage(theMessage);
			}
			catch (ApplicationException e)
			{
				throw new NuGenReceivingApplicationException(e);
			}
			
			return result;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.ReceivingApplication.canProcess(Genetibase.NuGenHL7.model.Message)">
		/// </seealso>
		public virtual bool canProcess(Message theMessage)
		{
			return myApplication.canProcess(theMessage);
		}
	}
}