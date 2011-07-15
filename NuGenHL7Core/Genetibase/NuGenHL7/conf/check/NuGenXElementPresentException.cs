using System;
namespace Genetibase.NuGenHL7.conf.check
{
	
	/// <summary> An element that a profile defines as "not used" (X) is present in the 
	/// message.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public class NuGenXElementPresentException:NuGenProfileNotFollowedException
	{
		
		/// <summary> Constructs an instance of <code>XElementPresentException</code> with the specified detail message.</summary>
		/// <param name="msg">the detail message.
		/// </param>
		public NuGenXElementPresentException(System.String msg):base(msg)
		{
		}
	}
}