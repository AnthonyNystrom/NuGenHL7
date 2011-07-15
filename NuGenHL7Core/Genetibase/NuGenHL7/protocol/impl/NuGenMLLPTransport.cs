/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "MLLPTransport.java".  Description: 
"An implementation of the HL7 Minimal Lower Layer Protocol." 

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
using LLPException = Genetibase.NuGenHL7.llp.NuGenLLPException;
using MinLLPReader = Genetibase.NuGenHL7.llp.NuGenMinLLPReader;
using MinLLPWriter = Genetibase.NuGenHL7.llp.NuGenMinLLPWriter;
using StreamSource = Genetibase.NuGenHL7.protocol.NuGenStreamSource;
using TransportException = Genetibase.NuGenHL7.protocol.NuGenTransportException;
using TransportLayer = Genetibase.NuGenHL7.protocol.NuGenTransportLayer;
using Transportable = Genetibase.NuGenHL7.protocol.NuGenTransportable;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> An implementation of the HL7 Minimal Lower Layer Protocol (see 
	/// HL7 implementation guide appendix C).  Note that this is the most common 
	/// protocol used in HL7 interfaces.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.7 $ updated on $Date: 2005/05/10 23:13:43 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenMLLPTransport:NuGenAbstractTransport, NuGenTransportLayer
	{
		
		private MinLLPReader myReader;
		private MinLLPWriter myWriter;
		
		private NuGenStreamSource myStreamSource;
		private System.Collections.Specialized.NameValueCollection myCharsetMappings;
		
		/// <param name="theStreamSource">the provider of input and output streams connected
		/// to the remote server 
		/// </param>
		public NuGenMLLPTransport(NuGenStreamSource theStreamSource)
		{
			myStreamSource = theStreamSource;
			myCharsetMappings = loadCharsetMappings();
		}
		
		private static System.Collections.Specialized.NameValueCollection loadCharsetMappings()
		{
			System.Collections.Specialized.NameValueCollection mappings = new System.Collections.Specialized.NameValueCollection();

			try
			{
				mappings = new System.Collections.Specialized.NameValueCollection(System.Configuration.ConfigurationSettings.AppSettings);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException("Can't load character set mappings", e);
			}

			return mappings;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.AstractTransport.doSend(Genetibase.NuGenHL7.protocol.Transportable)">
		/// </seealso>
		public override void  doSend(NuGenTransportable theMessage)
		{
			try
			{
				System.String charset = (System.String) theMessage.Metadata["MSH-18"];
				if (charset != null)
				{
					charset = myCharsetMappings[charset] == null?charset:myCharsetMappings[charset]; //default to self if no match
					myWriter.writeMessage(theMessage.Message, charset);
				}
				else
				{
					myWriter.writeMessage(theMessage.Message);
				}
			}
			catch (LLPException e)
			{
				throw new NuGenTransportException(e);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException(e);
			}
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.impl.AbstractTransport.doReceive()">
		/// </seealso>
		public override NuGenTransportable doReceive()
		{
			NuGenTransportable result = null;
			try
			{
				System.String message = myReader.getMessage();
				if (message != null)
				{
					result = new NuGenTransportableImpl(message);
				}
			}
			catch (LLPException e)
			{
				throw new NuGenTransportException(e);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException(e);
			}
			return result;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.protocol.AbstractTransport.doConnect()">
		/// </seealso>
		public override void  doConnect()
		{
			myStreamSource.connect();
			try
			{
				myReader = new MinLLPReader(myStreamSource.InboundStream);
				myWriter = new MinLLPWriter(myStreamSource.OutboundStream);
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
			try
			{
				if (myReader != null)
					myReader.close();
				if (myWriter != null)
					myWriter.close();
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenTransportException(e);
			}
			finally
			{
				myReader = null;
				myWriter = null;
			}
			myStreamSource.disconnect();
		}
	}
}