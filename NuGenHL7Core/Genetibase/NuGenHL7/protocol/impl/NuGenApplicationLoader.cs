/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "ApplicationLoader.java".  Description: 
"A utility for loading Application bindings from configuration files." 

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
using Application = Genetibase.NuGenHL7.app.NuGenApplication;
using ApplicationRouter = Genetibase.NuGenHL7.protocol.NuGenApplicationRouter;
using ReceivingApplication = Genetibase.NuGenHL7.protocol.NuGenReceivingApplication;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A utility for loading <code>Applicaiton</code> and <code>ReceivingApplication</code> bindings 
	/// from configuration files.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2005/05/16 16:52:05 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenApplicationLoader
	{
		
		/// <summary> <p>A convenience method for binding applications to an <code>ApplicationRouter</code>
		/// Information about bindings is read from a file at a specified URL.  Each line in the 
		/// file should have the following format (entries TAB delimited):</p>
		/// 
		/// <p>message_type &#009; trigger_event &#009; processing_id &#009; version_id &#009; app_class</p>
		/// 
		/// <p>Note that the first four fields can be the wildcard "*", which means any.</p>
		/// 
		/// <p>For example, if you write an Application called org.yourorganiztion.ADTProcessor
		/// that processes several types of ADT messages, and another called 
		/// org.yourorganization.ResultProcessor that processes result messages, you might have a 
		/// file that looks like this: </p>
		/// 
		/// <p>ADT &#009; * &#009; * &#009; * &#009; org.yourorganization.ADTProcessor<br>
		/// ORU &#009; R01 &#009; * &#009; * &#009; org.yourorganization.ResultProcessor</p>
		/// 
		/// <p>Each class listed in this file must implement either Genetibase.NuGenHL7.app.Application or 
		/// Genetibase.NuGenHL7.protocol.ReceivingApplication, and must have a zero-argument constructor.</p>
		/// 
		/// </summary>
		/// <param name="theRouter">the <code>ApplicationRouter</code> on which to make the binding
		/// </param>
		/// <param name="theSource">a URL pointing to the bindings file 
		/// </param>
		public static void  loadApplications(NuGenApplicationRouter theRouter, System.Uri theSource)
		{
			
			if (theSource == null)
			{
				throw new NuGenHL7Exception("Can't load application bindings: the given URL is null");
			}
			
			System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(System.Net.WebRequest.Create(theSource).GetResponse().GetResponseStream(), System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(System.Net.WebRequest.Create(theSource).GetResponse().GetResponseStream(), System.Text.Encoding.Default).CurrentEncoding);
			System.String line = null;
			while ((line = in_Renamed.ReadLine()) != null)
			{
				//parse application registration information 
				SupportClass.Tokenizer tok = new SupportClass.Tokenizer(line, "\t", false);
				System.String type = null, event_Renamed = null, procId = null, verId = null, className = null;
				
				if (tok.HasMoreTokens())
				{
					//skip blank lines 
					try
					{
						type = tok.NextToken();
						event_Renamed = tok.NextToken();
						procId = tok.NextToken();
						verId = tok.NextToken();
						className = tok.NextToken();
					}
					catch (System.ArgumentOutOfRangeException)
					{
						throw new NuGenHL7Exception("Can't register applications from " + theSource.ToString() + ". The line '" + line + "' is not of the form: message_type [tab] trigger_event " + "[tab] processing ID [tab] version ID [tab] application_class. " + "*** NOTE TWO NEW FIELDS AS OF HAPI 0.5 ****. ", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
					}
					
					System.Type appClass = System.Type.GetType(className); //may throw ClassNotFoundException 
					System.Object appObject = System.Activator.CreateInstance(appClass);
					NuGenReceivingApplication app = null;
					if (appObject is NuGenReceivingApplication)
					{
						app = (NuGenReceivingApplication) appObject;
					}
					else if (appObject is Application)
					{
						app = new NuGenAppWrapper((Application) appObject);
					}
					else
					{
						throw new NuGenHL7Exception("The specified class, " + appClass.FullName + ", doesn't implement Application or ReceivingApplication.", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
					}
					
					Genetibase.NuGenHL7.protocol.AppRoutingData rd = new NuGenAppRoutingDataImpl(type, event_Renamed, procId, verId);
					theRouter.bindApplication(rd, app);
				}
			}
		}
	}
}