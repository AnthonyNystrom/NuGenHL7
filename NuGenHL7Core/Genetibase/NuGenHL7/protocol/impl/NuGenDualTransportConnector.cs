/*
* Created on 20-May-2004
*/
using System;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
using TransportLayer = Genetibase.NuGenHL7.protocol.NuGenTransportLayer;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> <p>A utility for connecting separate inbound and outbound 
	/// <code>TransortLayer</code>s in a manner that avoids deadlock.</p>  
	/// 
	/// <p>It is not safe to call connect() on two <code>TransportLayer</code>
	/// in the same thread, because it blocks, and the remote system may be doing 
	/// the same thing, but in the opposite order.  This class provides a method  
	/// that connects two layers in separate threads, and pends until they are
	/// both connected.</p>
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/05/24 16:29:54 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenDualTransportConnector
	{
		/// <returns> one of the underlying <code>TransportLayer</code>s.  
		/// </returns>
		virtual public NuGenTransportLayer TransportA
		{
			get
			{
				return myTransportA;
			}
			
		}
		/// <returns> the other underlying <code>TransportLayer</code>.  
		/// </returns>
		virtual public NuGenTransportLayer TransportB
		{
			get
			{
				return myTransportB;
			}
			
		}
		
		private NuGenTransportLayer myTransportA;
		private NuGenTransportLayer myTransportB;
		private bool isConnecting;
		
		/// <param name="theTransportA">one <code>TransportLayer</code> we will want to connect 
		/// </param>
		/// <param name="theTransportB">another one
		/// </param>
		public NuGenDualTransportConnector(NuGenTransportLayer theTransportA, NuGenTransportLayer theTransportB)
		{
			myTransportA = theTransportA;
			myTransportB = theTransportB;
		}
		
		/// <summary> Connects both <code>TransportLayer</code>s in separate threads,   
		/// and returns when both have been connected, or when cancelConnect() 
		/// is called. 
		/// </summary>
		public virtual void  connect()
		{
			isConnecting = true;
			ConnectThread c1 = new ConnectThread(myTransportA);
			ConnectThread c2 = new ConnectThread(myTransportB);
			c1.Start();
			c2.Start();
			
			while (isConnecting && (!c1.Connected || !c2.Connected) && c1.Exception == null && c2.Exception == null)
			{
				
				try
				{
					System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 1));
				}
				catch (System.Threading.ThreadInterruptedException)
				{
				}
			}
			
			if (c1.Exception != null)
				throw c1.Exception;
			if (c2.Exception != null)
				throw c2.Exception;
		}
		
		public virtual void  disconnect()
		{
			myTransportA.disconnect();
			myTransportB.disconnect();
		}
		
		/// <summary> Cancels a connect() in progress.  Since connect() blocks, this must 
		/// be called from a separate thread.  
		/// </summary>
		public virtual void  cancelConnect()
		{
			isConnecting = false;
		}
		
		/// <summary> A class to facilitate connecting a <code>TransportLayer</code> in 
		/// a separate thread.  This is needed when we want to perform two connections
		/// that are initiated remotely, and we don't know the order in which the 
		/// remote system will initiate the connections. 
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.1 $ updated on $Date: 2004/05/24 16:29:54 $ by $Author: bryan_tripp $
		/// </version>
		private class ConnectThread:SupportClass.ThreadClass
		{
			virtual public bool Connected
			{
				get
				{
					return myTransport.Connected;
				}
				
			}
			/// <returns> an exception encountered during the last run, if any
			/// </returns>
			virtual public NuGenTransportException Exception
			{
				get
				{
					return myException;
				}
				
			}
			
			private NuGenTransportLayer myTransport;
			private NuGenTransportException myException;
			
			public ConnectThread(NuGenTransportLayer theTransport)
			{
				myTransport = theTransport;
			}
			
			override public void  Run()
			{
				myException = null;
				try
				{
					myTransport.connect();
				}
				catch (NuGenTransportException e)
				{
					myException = e;
				}
			}
		}
		static NuGenDualTransportConnector()
		{
		}
	}
}