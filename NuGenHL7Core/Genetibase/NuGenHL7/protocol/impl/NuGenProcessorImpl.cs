/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "ProcessorImpl.java".  Description: 
"A default implementation of Processor." 

The Initial Developer of the Original Code is University Health Network. Copyright (C) 
2004.  All Rights Reserved. 

Contributor(s): ______________________________________. 

Alternatively, the contents of this file may be used under the terms of the 
GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
applicable instead of those above.  If you wish to allow use of your version of this 
file only under the terms of the GPL and not to allow others to use your version 
of this file under the MPL, indicate your decision by deleting  the provisions above 
and replace  them with the notice and other provisions required by the GPL License.  
If you do not delete the provisions above, a recipient may use your version of 
this file under either the MPL or the GPL. */
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using PreParser = Genetibase.NuGenHL7.preparser.NuGenPreParser;
using Processor = Genetibase.NuGenHL7.protocol.NuGenProcessor;
using ProcessorContext = Genetibase.NuGenHL7.protocol.NuGenProcessorContext;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
using TransportLayer = Genetibase.NuGenHL7.protocol.NuGenTransportLayer;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A default implementation of <code>Processor</code>.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.7 $ updated on $Date: 2006/12/12 01:01:36 $ by $Author: jamesagnew $
	/// </version>
	public class NuGenProcessorImpl : NuGenProcessor
	{
		private class AnonymousClassRunnable : IThreadRunnable
		{
			public AnonymousClassRunnable(Genetibase.NuGenHL7.protocol.impl.NuGenProcessorImpl processor, Genetibase.NuGenHL7.protocol.NuGenTransportable theResponse, NuGenProcessorImpl enclosingInstance)
			{
				InitBlock(processor, theResponse, enclosingInstance);
			}
			private void  InitBlock(Genetibase.NuGenHL7.protocol.impl.NuGenProcessorImpl processor, Genetibase.NuGenHL7.protocol.NuGenTransportable theResponse, NuGenProcessorImpl enclosingInstance)
			{
				this.processor = processor;
				this.theResponse = theResponse;
				this.enclosingInstance = enclosingInstance;
			}
			private Genetibase.NuGenHL7.protocol.impl.NuGenProcessorImpl processor;
			private Genetibase.NuGenHL7.protocol.NuGenTransportable theResponse;
			private NuGenProcessorImpl enclosingInstance;
			public NuGenProcessorImpl Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			public virtual void  Run()
			{
				try
				{
					//TODO: make configurable 
					processor.send(theResponse, 2, 3000);
				}
				catch (NuGenHL7Exception)
				{
				}
			}
		}
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Processor.getContext()">
		/// </seealso>
		virtual public NuGenProcessorContext Context
		{
			get
			{
				return myContext;
			}
			
		}
		
		private NuGenProcessorContext myContext;
		private System.Collections.IDictionary myAcceptAcks;
		private System.Collections.IDictionary myReservations;
		private System.Collections.IDictionary myAvailableMessages;
		private bool myThreaded; //true if separate threads are calling cycle()  
		private Cycler ackCycler;
		private Cycler nonAckCycler;
		
		/// <param name="theContext">source of supporting services 
		/// </param>
		/// <param name="isThreaded">true if this class should create threads in which to call cycle(), and 
		/// in which to send responses from Applications.  This is the preferred mode.  Use false 
		/// if threading is not allowed, eg you are running the code in an EJB container.  In this case, 
		/// the send() and receive() methods will call cycle() themselves as needed.  However, cycle() 
		/// makes potentially blocking calls, so these methods may not return until the next message 
		/// is received from the remote server, regardless of timeout.  Probably the worst example of this
		/// would be if receive() was called to wait for an application ACK that was specified as "RE" (ie
		/// required on error).  No response will be returned if the message is processed without error, 
		/// and in a non-threaded environment, receive() will block forever.  Use true if you can, otherwise
		/// study this class carefully.
		/// 
		/// TODO: write a MLLPTransport with non-blocking IO  
		/// TODO: reconnect transport layers on error and retry 
		/// </param>
		public NuGenProcessorImpl(NuGenProcessorContext theContext, bool isThreaded)
		{
			myContext = theContext;
			myThreaded = isThreaded;
			myAcceptAcks = new System.Collections.Hashtable();
			myReservations = new System.Collections.Hashtable();
			myAvailableMessages = new System.Collections.Hashtable();
			
			if (isThreaded)
			{
				ackCycler = new Cycler(this, true);
				SupportClass.ThreadClass ackThd = new SupportClass.ThreadClass(new System.Threading.ThreadStart(ackCycler.Run));
				ackThd.Start();
				nonAckCycler = new Cycler(this, false);
				SupportClass.ThreadClass nonAckThd = new SupportClass.ThreadClass(new System.Threading.ThreadStart(nonAckCycler.Run));
				nonAckThd.Start();
			}
		}
		
		/// <summary> If self-threaded, stops threads that have been created.  </summary>
		public virtual void  stop()
		{
			if (myThreaded)
			{
				ackCycler.stop();
				nonAckCycler.stop();
			}
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Processor.send(Genetibase.NuGenHL7.protocol.Transportable, int, long)">
		/// </seealso>
		public virtual void  send(NuGenTransportable theMessage, int maxRetries, long retryIntervalMillis)
		{
			System.String[] fieldPaths = new System.String[]{"MSH-10", "MSH-15", "MSH-16"};
			System.String[] fields = PreParser.getFields(theMessage.Message, fieldPaths);
			System.String controlId = fields[0];
			System.String needAcceptAck = fields[1];
			System.String needAppAck = fields[2];
			
			checkValidAckNeededCode(needAcceptAck);
			
			trySend(myContext.LocallyDrivenTransportLayer, theMessage);
			
			bool originalMode = (needAcceptAck == null && needAppAck == null);
			if (originalMode || !needAcceptAck.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.NE))
			{
				
				NuGenTransportable response = null;
				int retries = 0;
				do 
				{
					long until = (System.DateTime.Now.Ticks - 621355968000000000) / 10000 + retryIntervalMillis;
					while (response == null && (System.DateTime.Now.Ticks - 621355968000000000) / 10000 < until)
					{
						lock (this)
						{
							System.Object tempObject;
							tempObject = myAcceptAcks[controlId];
							myAcceptAcks.Remove(controlId);
							ExpiringTransportable et = (ExpiringTransportable) tempObject;
							if (et == null)
							{
								cycleIfNeeded(true);
							}
							else
							{
								response = et.transportable;
							}
						}
						sleepIfNeeded();
					}
					
					if ((response == null && needAcceptAck != null && needAcceptAck.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.AL)) || (response != null && isReject(response)))
					{
						trySend(myContext.LocallyDrivenTransportLayer, theMessage);
						response = null;
					}
					
					if (response != null && isError(response))
					{
						System.String[] errMsgPath = new System.String[]{"MSA-3"};
						System.String[] errMsg = PreParser.getFields(response.Message, errMsgPath);
						throw new NuGenHL7Exception("Error message received: " + errMsg[0]);
					}
				}
				while (response == null && ++retries <= maxRetries);
			}
		}
		
		private void  checkValidAckNeededCode(System.String theCode)
		{
			//must be one of the below ... 
			if (!(theCode == null || theCode.Equals("") || theCode.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.AL) || theCode.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.ER) || theCode.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.NE) || theCode.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.SU)))
			{
				throw new NuGenHL7Exception("MSH-15 must be AL, ER, NE, or SU in the outgoing message");
			}
		}
		
		/// <summary> Calls cycle() if we do not expect another thread to be doing so</summary>
		/// <param name="expectingAck">as in cycle
		/// </param>
		private void  cycleIfNeeded(bool expectingAck)
		{
			if (!myThreaded)
			{
				cycle(expectingAck);
			}
		}
		
		/// <summary> Sleeps for 1 ms if externally threaded (this is to let the CPU idle).   </summary>
		private void  sleepIfNeeded()
		{
			if (myThreaded)
			{
				try
				{
					System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 1));
				}
				catch (System.Threading.ThreadInterruptedException)
				{
					/* no problem */
				}
			}
		}
		
		/// <summary>Returns true if a CR or AR ACK </summary>
		private static bool isReject(NuGenTransportable theMessage)
		{
			bool reject = false;
			System.String[] fieldPaths = new System.String[]{"MSA-1"};
			System.String[] fields = PreParser.getFields(theMessage.Message, fieldPaths);
			if (fields[0] != null && (fields[0].Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.CR) || fields[0].Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.AR)))
			{
				reject = true;
			}
			return reject;
		}
		
		/// <summary>Returns true if a CE or AE ACK </summary>
		private static bool isError(NuGenTransportable theMessage)
		{
			bool error = false;
			System.String[] fieldPaths = new System.String[]{"MSA-1"};
			System.String[] fields = PreParser.getFields(theMessage.Message, fieldPaths);
			if (fields[0] != null && (fields[0].Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.CE) || fields[0].Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.AE)))
			{
				error = true;
			}
			return error;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Processor.reserve(java.lang.String, long)">
		/// </seealso>
		public virtual void  reserve(System.String theAckId, long thePeriodMillis)
		{
			lock (this)
			{
				System.Int64 expiry = (long) ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 + thePeriodMillis);
				myReservations[theAckId] = expiry;
			}
		}
		
		/// <summary> Tries to send the message, and if there is an error reconnects and tries again. </summary>
		private void  trySend(NuGenTransportLayer theTransport, NuGenTransportable theTransportable)
		{
			try
			{
				theTransport.send(theTransportable);
			}
			catch (NuGenTransportException)
			{
				theTransport.disconnect();
				theTransport.connect();
				theTransport.send(theTransportable);
			}
		}
		
		
		/// <summary> Tries to receive a message, and if there is an error reconnects and tries again. </summary>
		private NuGenTransportable tryReceive(NuGenTransportLayer theTransport)
		{
			NuGenTransportable message = null;
			try
			{
				message = theTransport.receive();
			}
			catch (NuGenTransportException)
			{
				theTransport.disconnect();
				theTransport.connect();
				message = theTransport.receive();
			}
			return message;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Processor.cycle(boolean)">
		/// </seealso>
		public virtual void  cycle(bool expectingAck)
		{
			cleanReservations();
			cleanAcceptAcks();
			cleanReservedMessages();
			
			NuGenTransportable in_Renamed = null;
			try
			{
				if (expectingAck)
				{
					in_Renamed = tryReceive(myContext.LocallyDrivenTransportLayer);
				}
				else
				{
					in_Renamed = tryReceive(myContext.RemotelyDrivenTransportLayer);
				}
			}
			catch (NuGenTransportException e)
			{
				try
				{
					System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 1000));
				}
				catch (System.Threading.ThreadInterruptedException)
				{
				}
				throw e;
			}
			
			if (in_Renamed != null)
			{
				System.String[] fieldPaths = new System.String[]{"MSH-15", "MSH-16", "MSA-1", "MSA-2"};
				System.String[] fields = PreParser.getFields(in_Renamed.Message, fieldPaths);
				System.String acceptAckNeeded = fields[0];
				System.String appAckNeeded = fields[1];
				System.String ackCode = fields[2];
				System.String ackId = fields[3];
				
				if (ackId != null && ackCode != null && ackCode.StartsWith("C"))
				{
					long expiryTime = (System.DateTime.Now.Ticks - 621355968000000000) / 10000 + 1000 * 60;
					myAcceptAcks[ackId] = new ExpiringTransportable(this, in_Renamed, expiryTime);
				}
				else
				{
					NuGenAcceptAcknowledger.AcceptACK ack = NuGenAcceptAcknowledger.validate(Context, in_Renamed);
					
					if ((acceptAckNeeded != null && acceptAckNeeded.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.AL)) || (acceptAckNeeded != null && acceptAckNeeded.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.ER) && !ack.Acceptable) || (acceptAckNeeded != null && acceptAckNeeded.Equals(Genetibase.NuGenHL7.protocol.Processor_Fields.SU) && ack.Acceptable))
					{
						trySend(myContext.RemotelyDrivenTransportLayer, ack.Message);
					}
					
					if (ack.Acceptable)
					{
						if (isReserved(ackId))
						{
							removeReservation(ackId);
							long expiryTime = (System.DateTime.Now.Ticks - 621355968000000000) / 10000 + 1000 * 60 * 5;
							myAvailableMessages[ackId] = new ExpiringTransportable(this, in_Renamed, expiryTime);
						}
						else
						{
							NuGenTransportable out_Renamed = myContext.Router.processMessage(in_Renamed);
							sendAppResponse(out_Renamed);
						}
					}
				}
			}
			else
			{
				System.String transport = expectingAck?" Locally driven ":"Remotely driven";
			}
			
			sleepIfNeeded();
		}
		
		/// <summary>Sends in a new thread if isThreaded, otherwise in current thread </summary>
		private void  sendAppResponse(NuGenTransportable theResponse)
		{
			NuGenProcessorImpl processor = this;
			IThreadRunnable sender = new AnonymousClassRunnable(processor, theResponse, this);
			
			if (myThreaded)
			{
				SupportClass.ThreadClass thd = new SupportClass.ThreadClass(new System.Threading.ThreadStart(sender.Run));
				thd.Start();
			}
			else
			{
				sender.Run();
			}
		}
		
		/// <summary> Removes expired message reservations from the reservation list.  </summary>
		private void  cleanReservations()
		{
			lock (this)
			{
				System.Collections.IEnumerator it = new SupportClass.HashSetSupport(myReservations.Keys).GetEnumerator();
                System.Collections.IList remove = new System.Collections.ArrayList();
				while (it.MoveNext())
				{
					System.String ackId = (System.String) it.Current;
					System.Int64 expiry = (System.Int64) myReservations[ackId];
					if ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 > (long) expiry)
					{
                        //myReservations.Remove(it.Current);
                        remove.Add(it.Current);
					}
				}

                foreach (object item in remove)
                {
                    myReservations.Remove(item);
                }
			}
		}
		
		/// <summary> Discards expired accept acknowledgements (these are used in retry protocol; see send()).   </summary>
		private void  cleanAcceptAcks()
		{
			lock (this)
			{
				System.Collections.IEnumerator it = new SupportClass.HashSetSupport(myAcceptAcks.Keys).GetEnumerator();
                System.Collections.IList remove = new System.Collections.ArrayList();
				while (it.MoveNext())
				{
					System.String ackId = (System.String) it.Current;
					ExpiringTransportable et = (ExpiringTransportable) myAcceptAcks[ackId];
					if ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 > et.expiryTime)
					{                    
                        //myAcceptAcks.Remove(it.Current);
                        remove.Add(it.Current);
                    }
				}

                foreach (object item in remove)
                {
                    myAcceptAcks.Remove(item);
                }
			}
		}
		
		private void  cleanReservedMessages()
		{
			lock (this)
			{
				System.Collections.IEnumerator it = new SupportClass.HashSetSupport(myAvailableMessages.Keys).GetEnumerator();
                System.Collections.IList remove = new System.Collections.ArrayList();
				while (it.MoveNext())
				{
					System.String ackId = (System.String) it.Current;
					ExpiringTransportable et = (ExpiringTransportable) myAvailableMessages[ackId];
					if ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 > et.expiryTime)
					{
                        //myAvailableMessages.Remove(it.Current);
                        remove.Add(it.Current);
						
						//send to an Application 
						NuGenTransportable out_Renamed = myContext.Router.processMessage(et.transportable);
						sendAppResponse(out_Renamed);
					}

                    foreach (object item in remove)
                    {
                        myAvailableMessages.Remove(item);
                    }
				}
			}
		}
		
		private bool isReserved(System.String ackId)
		{
			lock (this)
			{
				bool reserved = false;
				if (myReservations.Contains(ackId))
				{
					reserved = true;
				}
				return reserved;
			}
		}
		
		private void  removeReservation(System.String ackId)
		{
			lock (this)
			{
				myReservations.Remove(ackId);
			}
		}
		
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Processor.isAvailable(java.lang.String)">
		/// </seealso>
		public virtual bool isAvailable(System.String theAckId)
		{
			bool available = false;
			if (myAvailableMessages.Contains(theAckId))
			{
				available = true;
			}
			return available;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.Processor.receive(java.lang.String, long)">
		/// </seealso>
		public virtual NuGenTransportable receive(System.String theAckId, long theTimeoutMillis)
		{
			if (!isReserved(theAckId))
			{
				reserve(theAckId, theTimeoutMillis);
			}
			
			NuGenTransportable in_Renamed = null;
			long until = (System.DateTime.Now.Ticks - 621355968000000000) / 10000 + theTimeoutMillis;
			do 
			{
				lock (this)
				{
					ExpiringTransportable et = (ExpiringTransportable) myAvailableMessages[theAckId];
					if (et == null)
					{
						cycleIfNeeded(false);
					}
					else
					{
						in_Renamed = et.transportable;
					}
				}
				sleepIfNeeded();
			}
			while (in_Renamed == null && (System.DateTime.Now.Ticks - 621355968000000000) / 10000 < until);
			return in_Renamed;
		}
		
		/// <summary> A struct for Transportable collection entries that time out.  
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.7 $ updated on $Date: 2006/12/12 01:01:36 $ by $Author: jamesagnew $
		/// </version>
		internal class ExpiringTransportable
		{
			private void  InitBlock(NuGenProcessorImpl enclosingInstance)
			{
				this.enclosingInstance = enclosingInstance;
			}
			private NuGenProcessorImpl enclosingInstance;
			public NuGenProcessorImpl Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			public NuGenTransportable transportable;
			public long expiryTime;
			
			public ExpiringTransportable(NuGenProcessorImpl enclosingInstance, NuGenTransportable theTransportable, long theExpiryTime)
			{
				InitBlock(enclosingInstance);
				transportable = theTransportable;
				expiryTime = theExpiryTime;
			}
		}
		
		/// <summary> A Runnable that repeatedly calls the cycle() method of this class.  
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.7 $ updated on $Date: 2006/12/12 01:01:36 $ by $Author: jamesagnew $
		/// </version>
		private class Cycler : IThreadRunnable
		{
			
			private NuGenProcessor myProcessor;
			private bool myExpectingAck;
			private bool isRunning;
			
			/// <param name="theProcessor">the processor on which to call cycle()
			/// </param>
			/// <param name="isExpectingAck">passed to cycle()
			/// </param>
			public Cycler(NuGenProcessor theProcessor, bool isExpectingAck)
			{
				myProcessor = theProcessor;
				myExpectingAck = isExpectingAck;
				isRunning = true;
			}
			
			/// <summary> Execution will stop at the end of the next cycle.  </summary>
			public virtual void  stop()
			{
				isRunning = false;
			}
			
			/// <summary> Calls cycle() repeatedly on the Processor given in the 
			/// constructor, until stop() is called.  
			/// 
			/// </summary>
			/// <seealso cref="java.lang.Runnable.run()">
			/// </seealso>
			public virtual void  Run()
			{
				while (isRunning)
				{
					try
					{
						myProcessor.cycle(myExpectingAck);
					}
					catch (NuGenHL7Exception)
					{
					}
				}
			}
		}
		static NuGenProcessorImpl()
		{
		}
	}
}