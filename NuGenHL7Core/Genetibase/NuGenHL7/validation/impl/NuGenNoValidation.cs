/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "NoValidation.java".  Description: 
/// "A ValidationContext with no validation initially defined" 
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
	
	
	/// <summary> A <code>ValidationContext</code> with no validation initially defined.  This 
	/// can be used as-is for fast message processing.  Although no validation is 
	/// performed per se, a <code>TrimLeadingWhitespace</code> rule is bound to types 
	/// FT, ST, and TX.    
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2005/06/14 20:12:48 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenNoValidation:NuGenValidationContextImpl
	{
		public NuGenNoValidation()
		{
			NuGenRule trim = new NuGenTrimLeadingWhitespace();
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "FT", trim));
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "ST", trim));
			PrimitiveRuleBindings.Add(new NuGenRuleBinding("*", "TX", trim));
		}
	}
}