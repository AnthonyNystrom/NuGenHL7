/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "MessageRuleBinding.java".  Description: 
/// "A RuleBinding that applies to MessageRules." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2004.  All Rights Reserved. 
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
using MessageRule = Genetibase.NuGenHL7.validation.NuGenMessageRule;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.validation.impl
{
	
	/// <summary> A <code>RuleBinding</code> that applies to <code>MessageRule</code>s. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2005/06/14 20:16:01 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenMessageRuleBinding:NuGenRuleBinding
	{
		
		private System.String myMessageType;
		private System.String myTriggerEvent;
		private const System.String delim = "^";
		
		/// <param name="theVersion">see {@link RuleBinding#getVersion()}
		/// </param>
		/// <param name="theMessageType">a value valid for MSH-9-1 or * for all
		/// </param>
		/// <param name="theTriggerEvent">a value valid for MSH-9-2 or * for all
		/// </param>
		/// <param name="theRule">
		/// </param>
		public NuGenMessageRuleBinding(System.String theVersion, System.String theMessageType, System.String theTriggerEvent, NuGenMessageRule theRule):base(theVersion, theMessageType + "^" + theTriggerEvent, theRule)
		{
			myMessageType = theMessageType;
			myTriggerEvent = theTriggerEvent;
		}
		
		/// <param name="theScope">must be in the form type^event (ie message type and trigger event separated
		/// by a carat)
		/// </param>
		public override bool appliesToScope(System.String theScope)
		{			
			if (!Regex.IsMatch(theScope, ".*\\^.*"))
			{
				throw new System.ArgumentException("arg theScope must be of the form type^event");
			}
			
			SupportClass.Tokenizer tok = new SupportClass.Tokenizer(theScope, delim, false);
			System.String itemType = tok.NextToken();
			System.String itemEvent = tok.NextToken();

            throw new Exception("This method is invalid");
			
			//return applies;
		}
	}
}