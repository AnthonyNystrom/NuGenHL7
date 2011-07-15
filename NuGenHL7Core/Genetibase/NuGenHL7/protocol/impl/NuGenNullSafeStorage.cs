/*
* Created on 19-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using SafeStorage = Genetibase.NuGenHL7.protocol.NuGenSafeStorage;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A non-functional implementation of <code>SafeStorage</code>.  This is 
	/// intended as a placeholder pending release of UHN's Simple Record Store
	/// project.   
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/19 23:07:49 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenNullSafeStorage : NuGenSafeStorage
	{
		
		/// <summary> Does nothing. </summary>
		public virtual void  store(NuGenTransportable theMessage)
		{
		}
		
		/// <summary> Does nothing. </summary>
		public virtual void  discard(NuGenTransportable theMessage)
		{
		}
		
		/// <summary> Returns an empty array. </summary>
		public virtual NuGenTransportable[] restore()
		{
			return new NuGenTransportable[0];
		}
	}
}