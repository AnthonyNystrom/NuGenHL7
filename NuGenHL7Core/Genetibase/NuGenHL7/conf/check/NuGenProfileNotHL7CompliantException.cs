using System;
namespace Genetibase.NuGenHL7.conf.check
{
	
	/// <summary> An exception indicating that a static profile doesn't correspond to HL7 rules.  </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public class NuGenProfileNotHL7CompliantException:Genetibase.NuGenHL7.NuGenHL7Exception
	{
		
		/// <summary> Constructs an instance of <code>ProfileNotHL7CompliantHL7Exception</code> with the specified detail message.</summary>
		/// <param name="msg">the detail message.
		/// </param>
		public NuGenProfileNotHL7CompliantException(System.String msg):base(msg)
		{
		}
		
		/// <summary> Constructs an instance of <code>ProfileNotHL7CompliantHL7Exception</code> with the specified detail message.</summary>
		/// <param name="msg">the detail message.
		/// </param>
		/// <param name="cause">an underlying exception 
		/// </param>
		public NuGenProfileNotHL7CompliantException(System.String msg, System.Exception cause):base(msg, cause)
		{
		}
	}
}