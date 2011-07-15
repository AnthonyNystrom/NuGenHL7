/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Defaultalidation.java".  Description: 
/// "A ValidationContext with a default set of rules initially defined." 
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
using Rule = Genetibase.NuGenHL7.validation.NuGenRule;
namespace Genetibase.NuGenHL7.validation.impl
{
	
	
	/// <summary> A <code>ValidationContext</code> with a default set of rules initially defined.
	/// This can be used as-is for a reasonable level of primitive type validation.   
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2005/06/14 20:13:16 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenDefaultValidation:NuGenValidationContextImpl
	{
		public NuGenDefaultValidation()
		{
			NuGenRule trim = new NuGenTrimLeadingWhitespace();
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "FT", trim));
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "ST", trim));
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "TX", trim));
			
			NuGenRule size200 = new NuGenSizeRule(200);
			NuGenRule size32000 = new NuGenSizeRule(32000);
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "FT", size32000));
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "ID", size200));
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "IS", size200));
			
			NuGenRule nonNegativeInteger = new NuGenRegexPrimitiveRule("\\d*", "");
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "SI", nonNegativeInteger));
			
			NuGenRule number = new NuGenRegexPrimitiveRule("(\\+|\\-)?\\d*\\.?\\d*", "");
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "NM", number));
			
			NuGenRule telephoneNumber = new NuGenRegexPrimitiveRule("(\\d{1,2} )?(\\(\\d{3}\\))?\\d{3}-\\d{4}(X\\d{1,5})?(B\\d{1,5})?(C.*)?", "Version 2.4 Section 2.9.45");
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "TN", telephoneNumber));
			
			System.String datePattern = "(\\d{4}([01]\\d(\\d{2})?)?)?"; //YYYY[MM[DD]]
			NuGenRule date = new NuGenRegexPrimitiveRule(datePattern, "Version 2.5 Section 2.16.24");
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "DT", date));
			
			System.String timePattern = "([012]\\d([0-5]\\d([0-5]\\d(\\.\\d(\\d(\\d(\\d)?)?)?)?)?)?)?([\\+\\-]\\d{4})?";
			NuGenRule time = new NuGenRegexPrimitiveRule(timePattern, "Version 2.5 Section 2.16.79");
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "TM", time));
			
			System.String datetimePattern = "(\\d{4}([01]\\d(\\d{2}([012]\\d([0-5]\\d([0-5]\\d(\\.\\d(\\d(\\d(\\d)?)?)?)?)?)?)?)?)?)?([\\+\\-]\\d{4})?";
			NuGenRule datetime = new NuGenRegexPrimitiveRule(datetimePattern, "Version 2.5 Section 2.16.25");
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "TSComponentOne", datetime));
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "DTM", datetime));
		}
	}
}