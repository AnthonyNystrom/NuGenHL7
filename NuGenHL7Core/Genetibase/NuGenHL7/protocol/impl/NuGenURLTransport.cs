/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "URLTransport.java".  Description: 
"A TransportLayer that reads and writes from an URL." 

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
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
using TransportLayer = Genetibase.NuGenHL7.protocol.NuGenTransportLayer;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A <code>TransportLayer</code> that reads and writes from an URL (for example
	/// over HTTP).    
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <author>  <a href="mailto:alexei.guevara@uhn.on.ca">Alexei Guevara</a>
	/// </author>
	/// <version>  $Revision: 1.6 $ updated on $Date: 2004/06/01 20:11:38 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenURLTransport:NuGenAbstractTransport, NuGenTransportLayer
	{
		virtual public System.String ContentType
		{
			get
			{
				return myContentType;
			}
			
			set
			{
				myContentType = value;
			}
			
		}
		
		/// <summary> Key in Transportable metadata map under which URL is stored.  </summary>
		public const System.String URL_KEY = "URL";
		
		private System.String myContentType = "application/hl7+doc+xml";
		private System.Uri myURL;
		private System.Net.HttpWebRequest myConnection;
		protected internal int myBufferSize = 3000;
		
		private bool myConnectOnSend;
		private bool myConnectOnReceive;
		private bool myConnectOnConnect;
		
		/// <summary> The boolean configuration flags determine when new connections are made.  For example if this 
		/// transport is being used for query/response, you might set connectOnSend to true and
		/// the others to false, so that each query/response is done over a fresh connection.  If 
		/// you are using a transport just to read data from a URL, you might set connectOnReceive to 
		/// true and the others to false.  
		/// 
		/// </summary>
		/// <param name="theURL">the URL at which messages are to be read and written 
		/// </param>
		/// <param name="connectOnSend">makes a new connection before each send  
		/// </param>
		/// <param name="connectOnReceive">makes a new connection before each receive 
		/// </param>
		/// <param name="connectOnConnect">makes a new connection when connect() is called 
		/// </param>
		public NuGenURLTransport(System.Uri theURL, bool connectOnSend, bool connectOnReceive, bool connectOnConnect)
		{
			myURL = theURL;
			CommonMetadata[URL_KEY] = theURL;
			
			myConnectOnSend = connectOnSend;
			myConnectOnReceive = connectOnReceive;
			myConnectOnConnect = connectOnConnect;
		}
		
		/// <summary> Writes the given message to the URL. 
		/// 
		/// </summary>
		/// <param name="theMessage">the message to send 
		/// </param>
		/// <seealso cref="Genetibase.NuGenHL7.protocol.AbstractTransport.doSend(Genetibase.NuGenHL7.protocol.Transportable)">
		/// </seealso>
		public override void  doSend(NuGenTransportable theMessage)
		{
			if (myConnectOnSend)
			{
				makeConnection();
			}
			
			try
			{
				System.IO.StreamWriter out_Renamed = new System.IO.StreamWriter(new System.IO.BufferedStream(myConnection.GetRequestStream()), System.Text.Encoding.Default);
				out_Renamed.Write(theMessage.Message);
				out_Renamed.Flush();
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException(e);
			}
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.AbstractTransport.doReceive()">
		/// </seealso>
		public override NuGenTransportable doReceive()
		{
			
			if (myConnectOnReceive)
			{
				makeConnection();
			}
			
			System.Text.StringBuilder response = new System.Text.StringBuilder();
			
			try
			{
				System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.BufferedStream(myConnection.GetResponse().GetResponseStream()), System.Text.Encoding.Default);
				
				char[] buf = new char[myBufferSize];
				int bytesRead = 0;
				
				NuGenIntRef bytesReadRef = new NuGenIntRef();
				
				while (bytesRead >= 0)
				{
					
					try
					{
						NuGenReaderThread readerThread = new NuGenReaderThread(in_Renamed, buf, bytesReadRef);
						readerThread.Start();
						readerThread.Join(10000);
						
						bytesRead = bytesReadRef.Value;
						
						if (bytesRead == 0)
						{
							throw new NuGenTransportException("Timeout waiting for response");
						}
					}
					catch (System.Threading.ThreadInterruptedException)
					{
					}
					
					if (bytesRead > 0)
					{
						response.Append(buf, 0, bytesRead);
					}
				}
				
				in_Renamed.Close();
			}
			catch (System.IO.IOException)
			{
			}
			
			if (response.Length == 0)
			{
				throw new NuGenTransportException("Timeout waiting for response");
			}
			
			return new NuGenTransportableImpl(response.ToString());
		}
		
		
		/// <summary> Calls openConnection() on the underlying URL and configures the connection, 
		/// if this transport is configured to connect when connect() is called (see 
		/// constructor params).
		/// 
		/// </summary>
		/// <seealso cref="Genetibase.NuGenHL7.protocol.AbstractTransport.doConnect()">
		/// </seealso>
		public override void  doConnect()
		{
			if (myConnectOnConnect)
			{
				makeConnection();
			}
		}
		
		//makes new connection 
		private void  makeConnection()
		{
			try
			{
				myConnection = (System.Net.HttpWebRequest) System.Net.WebRequest.Create(myURL);
				SupportClass.URLConnectionSupport.SetRequestProperty(myConnection, "Content-Type", ContentType);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException(e);
			}
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.TransportLayer.disconnect()">
		/// </seealso>
		public override void  doDisconnect()
		{
			myConnection = null;
		}
		static NuGenURLTransport()
		{
		}
	}
}