using System;
namespace Genetibase.NuGenHL7.conf.check
{
	
	/// <summary> An exception indicating that some message contents don't reflect a static profile.   </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public class NuGenProfileNotFollowedException:Genetibase.NuGenHL7.NuGenHL7Exception
	{
		
		/// <summary> Constructs an instance of <code>ProfileNotFollowedException</code> with the specified detail message.</summary>
		/// <param name="msg">the detail message.
		/// </param>
		public NuGenProfileNotFollowedException(System.String msg):base(msg)
		{
		}
		
		/// <summary> Constructs an instance of <code>ProfileNotFollowedException</code> with the specified detail message.</summary>
		/// <param name="msg">the detail message.
		/// </param>
		/// <param name="cause">an underlying exception 
		/// </param>
		/*public ProfileNotFollowedException(String msg, Throwable cause) {
		super(msg, cause);
		}*/
	}
}