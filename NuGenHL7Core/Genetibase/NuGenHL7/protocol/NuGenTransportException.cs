/*
* Created on 15-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> Represents a problem that has occured during transport of a 
	/// message string to / from some other server.
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/19 22:08:24 $ by $Author: bryan_tripp $
	/// </version>
	[Serializable]
	public class NuGenTransportException:NuGenHL7Exception
	{
		
		/// <param name="message">
		/// </param>
		/// <param name="cause">
		/// </param>
		public NuGenTransportException(System.String message, System.Exception cause):base(message, cause)
		{
		}
		
		/// <param name="cause">
		/// </param>
		public NuGenTransportException(System.Exception cause):base(cause)
		{
		}
		
		/// <param name="message">
		/// </param>
		public NuGenTransportException(System.String message):base(message)
		{
		}
	}
}