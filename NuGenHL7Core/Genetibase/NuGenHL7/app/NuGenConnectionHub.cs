/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ConnectionHub.java".  Description: 
/// "Provides access to shared HL7 Connections" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
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
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using LLPException = Genetibase.NuGenHL7.llp.NuGenLLPException;
using LowerLayerProtocol = Genetibase.NuGenHL7.llp.NuGenLowerLayerProtocol;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> Provides access to shared HL7 Connections.  The ConnectionHub 
	/// has at most one connection to any given address at any time.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenConnectionHub
	{
		/// <summary>Returns the singleton instance of ConnectionHub </summary>
		public static NuGenConnectionHub Instance
		{
			get
			{
				lock (typeof(Genetibase.NuGenHL7.app.NuGenConnectionHub))
				{
					if (instance == null)
					{
						instance = new NuGenConnectionHub();
					}
					return instance;
				}
			}
			
		}
		private static NuGenConnectionHub instance = null;
		private System.Collections.Hashtable connections;
		private System.Collections.Hashtable sockets;
		private System.Collections.Hashtable numRefs;
		
		/// <summary>Creates a new instance of ConnectionHub </summary>
		private NuGenConnectionHub()
		{
			connections = new System.Collections.Hashtable(20);
			sockets = new System.Collections.Hashtable(20);
			numRefs = new System.Collections.Hashtable(20);
		}
		
		/// <summary> Returns a Connection to the given address, opening this 
		/// Connection if necessary. The given Parser will only be used if a new Connection 
		/// is opened, so there is no guarantee that the Connection returnd will be using the 
		/// Parser you provide.  If you need explicit access to the Parser the Connection 
		/// is using, call <code>Connection.getParser()</code>. 
		/// </summary>
		public virtual NuGenConnection attach(System.String host, int port, Parser parser, System.Type llpClass)
		{
			NuGenConnection conn = getExisting(host, port, parser.GetType(), llpClass);
			if (conn == null)
			{
				try
				{
					//Parser p = (Parser) parserClass.newInstance();
					LowerLayerProtocol llp = (LowerLayerProtocol) System.Activator.CreateInstance(llpClass);
					conn = connect(host, port, parser, llp);
				}
				catch (System.InvalidCastException e)
				{
					//Log.tryToLog(, "Problem opening new connection to " + host + " port " + port);
					throw new NuGenHL7Exception("ClassCastException - need a LowerLayerProtocol class to get an Inititator", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
				}
				catch (System.Exception e)
				{
					//Log.tryToLog(e, "Problem opening new connection to " + host + " port " + port);
					throw new NuGenHL7Exception("Can't connect to " + host + " port " + port + ": " + e.GetType().FullName + ": " + e.Message, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
				}
			}
			incrementRefs(conn);
			return conn;
		}
		
		/// <summary>Returns an existing connection if one exists, null otherwise </summary>
		private NuGenConnection getExisting(System.String host, int port, System.Type parserClass, System.Type llpClass)
		{
			NuGenConnection existing = null;
			System.Object o = connections[makeHashKey(host, port, parserClass, llpClass)];
			if (o != null)
				existing = (NuGenConnection) o;
			return existing;
		}
		
		/// <summary> Opens a connection to the given address, and stores it in the 
		/// connections Hash. 
		/// </summary>
		private NuGenConnection connect(System.String host, int port, Parser parser, LowerLayerProtocol llp)
		{
			System.Net.Sockets.TcpClient s = new System.Net.Sockets.TcpClient(host, port);
			NuGenConnection i = new NuGenConnection(parser, llp, s);
			connections[makeHashKey(host, port, parser.GetType(), llp.GetType())] = i;
			sockets[makeHashKey(host, port, parser.GetType(), llp.GetType())] = s;
			return i;
		}
		
		/// <summary> Informs the ConnectionHub that you are done with the given Connection - 
		/// if no other code is using it, it will be closed, so you should not 
		/// attempt to use a Connection after detaching from it.  
		/// </summary>
		public virtual void  detach(NuGenConnection c)
		{
			int refs = decrementRefs(c);
			if (refs == 0)
			{
				close(c);
			}
		}
		
		/// <summary> Closes and discards the given Concection so that it can not be returned 
		/// in subsequent calls to attach().  This method is to be used when there 
		/// is a problem with a Connection, e.g. socket connection closed by remote host.  
		/// </summary>
		public virtual void  discard(NuGenConnection c)
		{
			close(c);
		}
		
		/// <summary>Closes the given connection & removes from hash - to be called when there are 0 references to it </summary>
		private void  close(NuGenConnection c)
		{
			c.close();
			
			//remove from "connections"  
			System.Collections.IEnumerator keys = new SupportClass.HashSetSupport(connections.Keys).GetEnumerator();
			bool removed = false;
			while (keys.MoveNext() && !removed)
			{
				System.Object key = keys.Current;
				System.Object val = connections[key];
				if (val.GetHashCode() == c.GetHashCode())
				{
					connections.Remove(key);
					numRefs.Remove(key);
					removed = true;
				}
			}
		}
		
		/// <summary> This should be called to indicate that a new party is using the 
		/// given Connection. 
		/// </summary>
		/// <returns>s the number of times this Connection is referenced
		/// </returns>
		private int incrementRefs(NuGenConnection c)
		{
			return updateRefs(c, 1);
		}
		
		/// <summary> This should be called to indicate that some party is ceasing use of the 
		/// given Connection. 
		/// </summary>
		/// <returns>s the number of times this Connection is referenced
		/// </returns>
		private int decrementRefs(NuGenConnection c)
		{
			return updateRefs(c, - 1);
		}
		
		/// <summary>Updates the number of references to i - used by incrementRefs and decrementRefs </summary>
		private int updateRefs(NuGenConnection c, int change)
		{
			System.Int32 hashCode = (System.Int32) c.GetHashCode();
			System.Object o = numRefs[hashCode];
			int existingRefs = 0;
			if (o != null)
			{
				existingRefs = ((System.Int32) o);
			}
			System.Int32 newRefs = (System.Int32) (existingRefs + change);
			numRefs[hashCode] = newRefs;
			return newRefs;
		}
		
		/// <summary> Creates a consistent hash key using a host (recommend use IP address, not host name),  
		/// port number, and the class names of a Parser and LowerLayerProtocol.  In other words, 
		/// allows us to store and retrieve remote connections using a hash map. 
		/// </summary>
		private static System.String makeHashKey(System.String IP, int port, System.Type parserClass, System.Type llpClass)
		{
			System.Text.StringBuilder key = new System.Text.StringBuilder();
			key.Append(IP);
			key.Append(":");
			key.Append(port);
			key.Append(":");
			key.Append(parserClass.FullName);
			key.Append(":");
			key.Append(llpClass.FullName);
			return key.ToString();
		}
		static NuGenConnectionHub()
		{
		}
	}
}