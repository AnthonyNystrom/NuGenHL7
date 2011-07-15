/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "HL7Service.java".  Description: 
/// "Accepts incoming TCP/IP connections and creates Connection objects" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): Kyle Buza 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using LowerLayerProtocol = Genetibase.NuGenHL7.llp.NuGenLowerLayerProtocol;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.parser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> <p>An HL7 service.  Accepts incoming TCP/IP connections and creates Connection 
	/// objects.  Uses a single MessageTypeRouter object (for all Connections) to define 
	/// the Applications to which message are sent.  To configure, use registerApplication() 
	/// or loadApplicationsFromFile().  </p>
	/// </p>A separate thread looks for Connections that have been closed (locally or remotely) 
	/// and discards them. </p>
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public abstract class NuGenHL7Service : IThreadRunnable
	{
		/// <summary>Returns all currently active connections. </summary>
		virtual public System.Collections.ArrayList RemoteConnections
		{
			get
			{
				lock (this)
				{
					return connections;
				}
			}
			
		}

        public virtual void Run() { }
		
		private System.Collections.ArrayList connections;
		private bool keepRunning_Renamed_Field;
		protected internal NuGenParser parser;
		protected internal LowerLayerProtocol llp;
		private NuGenMessageTypeRouter router;
		private System.Collections.ArrayList listeners;
		
		/// <summary>Creates a new instance of Server </summary>
		public NuGenHL7Service(NuGenParser parser, LowerLayerProtocol llp)
		{
			connections = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			listeners = new System.Collections.ArrayList();
			this.parser = parser;
			this.llp = llp;
			this.router = new NuGenMessageTypeRouter();
		}
		
		/// <summary>Returns true if the thread should continue to run, false otherwise (ie if stop() has been called). </summary>
		protected internal virtual bool keepRunning()
		{
			return keepRunning_Renamed_Field;
		}

        private SupportClass.ThreadClass thd;
		
		/// <summary> Starts the server listening for connections in a new thread.  This continues 
		/// until <code>stop()</code> is called.  
		/// </summary>
		public virtual void  start()
		{
			thd = new SupportClass.ThreadClass(new System.Threading.ThreadStart(this.Run));
			this.keepRunning_Renamed_Field = true;
			thd.Start();            
			//Fix for bug 960101:  Don't start the cleaner thread until the server is started.
			SupportClass.ThreadClass cleaner = new SupportClass.ThreadClass(new System.Threading.ThreadStart(new NuGenHL7Service.ConnectionCleaner(this, this).Run));
			cleaner.Start();
		}
		
		/// <summary> Stops the server from listening for new connections, and closes all existing
		/// Connections.  
		/// </summary>
		public virtual void  stop()
		{
			this.keepRunning_Renamed_Field = false;
			for (int i = 0; i < connections.Count; i++)
			{
				((NuGenConnection) connections[i]).close();
			}
		}
		
		/// <summary> Called by subclasses when a new Connection is made.  Registers the 
		/// MessageTypeRouter with the given Connection and stores it. 
		/// </summary>
		public virtual void  newConnection(NuGenConnection c)
		{
			lock (this)
			{
				c.Responder.registerApplication(router);
				this.connections.Add(c); //keep track of connections  
				notifyListeners(c);
			}
		}
		
		private void  discardConnection(NuGenConnection c)
		{
			lock (this)
			{
				this.connections.Remove(c);
				notifyListeners(c);
			}
		}
		
		/// <summary> Returns a connection to a remote host that was initiated by the given remote host.  
		/// If the connection has not been made, this method blocks until the remote host 
		/// connects.  
		/// </summary>
		public virtual NuGenConnection getRemoteConnection(System.String IP)
		{
			NuGenConnection conn = null;
			while (conn == null)
			{
				//check all connections ...
				int c = 0;
				lock (this)
				{
					while (conn == null && c < connections.Count)
					{
						NuGenConnection nextConn = (NuGenConnection) connections[c];
						if (nextConn.RemoteAddress.ToString().Equals(IP))
							conn = nextConn;
						c++;
					}
				}
				
				if (conn == null)
				{
					try
					{
						System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 100));
					}
					catch (System.Threading.ThreadInterruptedException)
					{
					}
				}
			}
			return conn;
		}
		
		/// <summary> Registers the given ConnectionListener with the HL7Service - when a remote host
		/// makes a new Connection, all registered listeners will be notified.  
		/// </summary>
		public virtual void  registerConnectionListener(NuGenConnectionListener listener)
		{
			lock (this)
			{
				this.listeners.Add(listener);
			}
		}
		
		/// <summary>Notifies all listeners that a Connection is new or discarded. </summary>
		private void  notifyListeners(NuGenConnection c)
		{
			for (int i = 0; i < listeners.Count; i++)
			{
				NuGenConnectionListener cl = (NuGenConnectionListener) listeners[i];
				if (c.Open)
				{
					cl.connectionReceived(c);
				}
				else
				{
					cl.connectionDiscarded(c);
				}
			}
		}
		
		/// <summary> Registers the given application to handle messages corresponding to the given type
		/// and trigger event.  Only one application can be registered for a given message type
		/// and trigger event combination.  A repeated registration for a particular combination 
		/// of type and trigger event over-writes the previous one.  Note that the wildcard "*" 
		/// for messageType or triggerEvent means any type or event, respectively.   
		/// </summary>
		public virtual void  registerApplication(System.String messageType, System.String triggerEvent, NuGenApplication handler)
		{
			lock (this)
			{
				this.router.registerApplication(messageType, triggerEvent, handler);
			}
		}
		
		/// <summary> <p>A convenience method for registering applications (using <code>registerApplication()
		/// </code>) with this service.  Information about which Applications should handle which 
		/// messages is read from the given text file.  Each line in the file should have the 
		/// following format (entries tab delimited):</p>
		/// <p>message_type &#009; trigger_event &#009; application_class</p>
		/// <p>message_type &#009; trigger_event &#009; application_class</p>
		/// <p>Note that message type and event can be the wildcard "*", which means any.</p>
		/// <p>For example, if you write an Application called org.yourorganiztion.ADTProcessor
		/// that processes several types of ADT messages, and another called 
		/// org.yourorganization.ResultProcessor that processes result messages, you might have a 
		/// file that looks like this: </p>
		/// <p>ADT &#009; * &#009; org.yourorganization.ADTProcessor<br>
		/// ORU &#009; R01 &#009; org.yourorganization.ResultProcessor</p>
		/// <p>Each class listed in this file must implement Application and must have a zero-argument
		/// constructor.</p>
		/// </summary>
		public virtual void  loadApplicationsFromFile(System.IO.FileInfo f)
		{
			System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(f.FullName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(f.FullName, System.Text.Encoding.Default).CurrentEncoding);
			System.String line = null;
			while ((line = in_Renamed.ReadLine()) != null)
			{
				//parse application registration information 
				SupportClass.Tokenizer tok = new SupportClass.Tokenizer(line, "\t", false);
				System.String type = null, event_Renamed = null, className = null;
				
				if (tok.HasMoreTokens())
				{
					//skip blank lines 
					try
					{
						type = tok.NextToken();
						event_Renamed = tok.NextToken();
						className = tok.NextToken();
					}
					catch (System.ArgumentOutOfRangeException)
					{
						throw new NuGenHL7Exception("Can't register applications from file " + f.Name + ". The line '" + line + "' is not of the form: message_type [tab] trigger_event [tab] application_class.", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
					}
					
					System.Type appClass = System.Type.GetType(className); //may throw ClassNotFoundException 
					System.Object appObject = System.Activator.CreateInstance(appClass);
					NuGenApplication app = null;
					try
					{
						app = (NuGenApplication) appObject;
					}
					catch (System.InvalidCastException )
					{
						throw new NuGenHL7Exception("The specified class, " + appClass.FullName + ", doesn't implement Application.", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
					}
					
					this.registerApplication(type, event_Renamed, app);
				}
			}
		}
		
		/// <summary> Runnable that looks for closed Connections and discards them. 
		/// It would be nice to find a way to externalize this safely so that it could be 
		/// re-used by (for example) TestPanel.  It could take a Vector of Connections
		/// as an argument, instead of an HL7Service, but some problems might arise if 
		/// other threads were iterating through the Vector while this one was removing
		/// elements from it.  
		/// </summary>
		private class ConnectionCleaner : IThreadRunnable
		{
			private void  InitBlock(NuGenHL7Service enclosingInstance)
			{
				this.enclosingInstance = enclosingInstance;
			}
			private NuGenHL7Service enclosingInstance;
			public NuGenHL7Service Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			
			internal NuGenHL7Service service;
			
			public ConnectionCleaner(NuGenHL7Service enclosingInstance, NuGenHL7Service service)
			{
				InitBlock(enclosingInstance);
				this.service = service;
			}
			
			public virtual void  Run()
			{
				while (Enclosing_Instance.keepRunning())
				{
					try
					{
						System.Threading.Thread.Sleep(new System.TimeSpan((System.Int64) 10000 * 500));
					}
					catch (System.Threading.ThreadInterruptedException)
					{
					}
					
					lock (service)
					{
						System.Collections.IEnumerator it = service.RemoteConnections.GetEnumerator();
                        System.Collections.IList remove = new System.Collections.ArrayList();
						while (it.MoveNext())
						{
							NuGenConnection conn = (NuGenConnection) it.Current;
							if (!conn.Open)
							{
                                //service.RemoteConnections.Remove(it.Current);
                                remove.Add(it.Current);
								service.notifyListeners(conn);
							}
						}

                        foreach (object item in remove)
                        {
                            service.RemoteConnections.Remove(item);
                        }
					}
				}
			}
		}
	}
}