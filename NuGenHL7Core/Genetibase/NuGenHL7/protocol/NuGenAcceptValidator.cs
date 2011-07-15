/*
* Created on 16-Apr-2004
*/
using System;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> <p>Determines whether messages are acceptable for storage.  See HL7 
	/// v2.5 chapter 2 for relevant specifications.  In original-mode 
	/// processing, validation at this level includes checking whether 
	/// MSH-9, 11, and 12 have appropriate values.</p>  
	/// 
	/// <p>In enhanced mode, the above checks are optional.  Checking for 
	/// syntactical correctness is also optional.  However storage availability 
	/// and interface status must be checked.</p>   
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2004/05/17 19:26:18 $ by $Author: bryan_tripp $
	/// </version>
	public interface NuGenAcceptValidator
	{
		
		/// <summary> Returns a ruling regarding whether the given message can be accepted  
		/// for further processing (ie determines CE, CR, or CA for enhanced mode, 
		/// and AR for original mode).  
		/// 
		/// </summary>
		/// <param name="theMessage">the message to check for acceptability.  
		/// </param>
		/// <returns>
		/// </returns>
		AcceptRuling check(NuGenTransportable theMessage);
		
	}
	public struct AcceptRuling_Fields{
		public readonly static System.String ACK_AR = "AR";
		public readonly static System.String ACK_CA = "CA";
		public readonly static System.String ACK_CE = "CE";
		public readonly static System.String ACK_CR = "CR";
	}
	/// <summary> Represents a decision regarding whether a message can be initially 
	/// accepted for further processing.  As per HL7 specs, for original-mode
	/// messages, a message should be accepted at this stage if the system thinks it can handle 
	/// the message based on MSH-9, 11, and 12 values (assuming these can be parsed). 
	/// 
	/// In enhanced mode, the above checks are optional.  Also optional is a check for 
	/// syntactical correctness.  Mandatory checks include availability of safe storage
	/// and "interface status".  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2004/05/17 19:26:18 $ by $Author: bryan_tripp $
	/// </version>
	public interface AcceptRuling
	{
		/// <returns> true if the message can be accepted at the protocol stage.
		/// </returns>
		bool Acceptable
		{
			get;
			
		}
		/// <returns> the ACK code corresponding to the ruling, if any.  Ie "AR", 
		/// "CE", "CR", or "CA".  If in original mode, null is returned for non-"AR" 
		/// situations.  This is because only the application layer can tell whether the 
		/// answer is "AE" or "AA". 
		/// </returns>
		System.String AckCode
		{
			get;
			
		}
		/// <returns> an error code from among the static fields of HL7Exception 
		/// (if no error, HL7Exception.MESSAGE_ACCEPTED)
		/// </returns>
		int ErrorCode
		{
			get;
			
		}
		/// <returns> zero or more reasons for rejecting a message (suitable for inclusion
		/// in a reply).  
		/// </returns>
		System.String[] Reasons
		{
			get;
			
		}
	}
}