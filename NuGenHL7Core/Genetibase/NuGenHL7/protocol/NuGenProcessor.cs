/*
* Created on 16-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> Encapsulates both the client and server roles of the HL7-defined 
	/// "original mode" and "enhanced mode" processing rules.  See 
	/// HL7 v2.5 chapter 2 for specifications.    
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2004/05/24 16:20:05 $ by $Author: bryan_tripp $
	/// </version>
	public struct Processor_Fields{
		/// <summary> Always send acknowledgement (in MSH-15 and 16)</summary>
		public readonly static System.String AL = "AL";
		/// <summary> Never send acknowledgement (in MSH-15 and 16)</summary>
		public readonly static System.String NE = "NE";
		/// <summary> Send acknowledgement only on error / reject (in MSH-15 and 16)</summary>
		public readonly static System.String ER = "ER";
		/// <summary> Send acknowledgement only on successful receipt (in MSH-15 and 16)</summary>
		public readonly static System.String SU = "SU";
		/// <summary> Original mode: Application Accept - Enhanced mode: Application acknowledgment: Accept</summary>
		public readonly static System.String AA = "AA";
		/// <summary> Original mode: Application Error - Enhanced mode: Application acknowledgment: Error </summary>
		public readonly static System.String AE = "AE";
		/// <summary> Original mode: Application Reject - Enhanced mode: Application acknowledgment: Reject</summary>
		public readonly static System.String AR = "AR";
		/// <summary> Enhanced mode: Accept acknowledgment: Commit Accept</summary>
		public readonly static System.String CA = "CA";
		/// <summary> Enhanced mode: Accept acknow ledgment: Commit Error</summary>
		public readonly static System.String CE = "CE";
		/// <summary> Enhanced mode: Accept acknowledgment: Commit Reject</summary>
		public readonly static System.String CR = "CR";
	}
	public interface NuGenProcessor
	{
		/// <returns> the operational context of this protocol instance 
		/// </returns>
		NuGenProcessorContext Context
		{
			get;
			
		}
		
		
		/// <summary> Sends a message to a remote system via an underlying 
		/// <code>TransportLayer</code>.  
		/// 
		/// If the message specifies that an accept ACK is required (under enhanced mode 
		/// processing rules) then this method may retry if transmission does not appear 
		/// to be successful.  The call to this method blocks while this is happening.  
		/// Retries are attempted if a CR message is received, or if no message is received
		/// in the specified time frame.  If a CE is received, an exception is thrown.  If 
		/// a CA is received, the call returns quietly.  
		/// 
		/// If no accept ack is required, this method returns immediately after attempting to 
		/// send a message, throwing an exception only if there is an immediate problem (eg the
		/// server can't be contacted).  
		/// 
		/// If an accept ack is required only on error, the method waits for maxRetries * 
		/// retryItervalMillis for an error to be returned, and assumes that there is no error
		/// if none appears in that time.  The message is not actually resent while waiting for an 
		/// error ACK. 
		/// 
		/// </summary>
		/// <param name="theMessage">the message to send 
		/// </param>
		/// <param name="maxRetries">note that this should be a small value if you demand an accept ack only
		/// on error
		/// </param>
		/// <param name="retryIntervalMillis">note that this should be a small value if you demand an accept ack only
		/// on error
		/// </param>
		/// <throws>  TransportException if there is an immediate problem trying to send the  </throws>
		/// <summary>      message.  
		/// </summary>
		void  send(NuGenTransportable theMessage, int maxRetries, long retryIntervalMillis);
		
		/// <summary> Indicates that the calling thread expects a message with a certain ack
		/// ID.  If this message arrives within the specified period of time, it will 
		/// be held in an inbound list instead of being passed on to an 
		/// <code>Application</code>.  If a message is in this list it <code>isAvailable()</code>
		/// and can be had via <code>receive()</code>
		/// 
		/// </summary>
		/// <param name="theAckId">the acknowledgement ID of the message 
		/// </param>
		/// <param name="thePeriodMillis">time span during which the message should be kept if received
		/// </param>
		void  reserve(System.String theAckId, long thePeriodMillis);
		
		/// <summary> <p>Performs a single iteration of the receiving-side 
		/// of the HL7 original mode or enhanced mode processing rules
		/// (see HL7 Standard v2.5 Chapter 2; the choice of rules
		/// is determined by message values).  Steps in the process are 
		/// as follows: </p>
		/// 
		/// 1. TransportLayer.receive() is called to get the next message <br> 
		/// 2. Validation is performed and the message is stored locally. <br>
		/// 2. If the message requires an accept ACK, then an accept, reject, 
		/// or error message is returned as appropriate  <br>
		/// 3. If the message is an accept ack, it is added to a local list that 
		/// can be accessed by the send() method <br>
		/// 4. If the message has been reserved, it is added to the available message
		/// list.  <br>
		/// 5. Otherwise it is sent to an Application.   
		/// 
		/// </summary>
		/// <param name="expectingAck">is passed to TransportLayer.receive(), and may determine 
		/// where the message is read from (eg different sockets may be used for 
		/// commit-level ACKs).  Note that this call blocks until a message is ready
		/// at the specified location, so to run the Processor continuously,  
		/// separate threads are needed to call cycle() with true and false args.   
		/// </param>
		void  cycle(bool expectingAck);
		
		/// <param name="theAckId">the acknowledgement ID of an expected message 
		/// </param>
		/// <returns> true if the message has come in and has been saved in the 
		/// inbound message list 
		/// </returns>
		bool isAvailable(System.String theAckId);
		
		/// <summary> Gets the message with the given acknowledgement ID from 
		/// the incoming message list.  This method blocks until the 
		/// message appears on the list.  If you don't want to block, 
		/// call <code>isAvailable()</code> to see if it is there.
		/// 
		/// Note also that the message has no way of arriving on the list 
		/// during this call unless the <code>Processor</code> is running 
		/// as a thread, or unless some other thread is calling cycle().   
		/// 
		/// </summary>
		/// <param name="theAckId">
		/// </param>
		/// <param name="theTimeoutMillis">milliseconds until the call times out
		/// and returns null if the desired message is not available. 
		/// </param>
		/// <returns> the incoming message with the given ack ID, or null 
		/// if the call times out. 
		/// </returns>
		NuGenTransportable receive(System.String theAckId, long theTimeoutMillis);
	}
}