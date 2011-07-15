/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "MessageValidator.java".  Description: 
/// "Validates parsed message against MessageRules that are enabled according to runtime 
/// configuration information."
/// </summary>
/// <summary>The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2002.  All Rights Reserved. 
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
using Message = Genetibase.NuGenHL7.model.Message;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.validation
{
	
	/// <summary> Validation utilities for parsed and encoded messages.  
	/// 
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenMessageValidator
	{
		
		private NuGenValidationContext myContext;
		private bool failOnError;
		
		/// <param name="theContext">context that determines which validation rules apply 
		/// </param>
		/// <param name="theFailOnErrorFlag">
		/// </param>
		public NuGenMessageValidator(NuGenValidationContext theContext, bool theFailOnErrorFlag)
		{
			myContext = theContext;
			failOnError = theFailOnErrorFlag;
		}
		
		/// <param name="message">a parsed message to validate (note that MSH-9-1 and MSH-9-2 must be valued)
		/// </param>
		/// <returns> true if the message is OK
		/// </returns>
		/// <throws>  HL7Exception if there is at least one error and this validator is set to fail on errors </throws>
		public virtual bool validate(Message message)
		{
			Terser t = new Terser(message);
			NuGenMessageRule[] rules = myContext.getMessageRules(message.Version, t.get_Renamed("MSH-9-1"), t.get_Renamed("MSH-9-2"));
			
			NuGenValidationException toThrow = null;
			bool result = true;
			for (int i = 0; i < rules.Length; i++)
			{
				NuGenValidationException[] ex = rules[i].test(message);
				for (int j = 0; j < ex.Length; j++)
				{
					result = false;
					if (failOnError && toThrow == null)
					{
						toThrow = ex[j];
					}
				}
			}
			
			if (toThrow != null)
			{
				throw new NuGenHL7Exception("Invalid message", toThrow);
			}
			
			return result;
		}
		
		/// <param name="message">an ER7 or XML encoded message to validate 
		/// </param>
		/// <param name="isXML">true if XML, false if ER7
		/// </param>
		/// <param name="version">HL7 version (e.g. "2.2") to which the message belongs
		/// </param>
		/// <returns> true if the message is OK
		/// </returns>
		/// <throws>  HL7Exception if there is at least one error and this validator is set to fail on errors </throws>
		public virtual bool validate(System.String message, bool isXML, System.String version)
		{
			NuGenEncodingRule[] rules = myContext.getEncodingRules(version, isXML?"XML":"ER7");
			NuGenValidationException toThrow = null;
			bool result = true;
			for (int i = 0; i < rules.Length; i++)
			{
				NuGenValidationException[] ex = rules[i].test(message);
				for (int j = 0; j < ex.Length; j++)
				{
					result = false;
					if (failOnError && toThrow == null)
					{
						toThrow = ex[j];
					}
				}
			}
			
			if (toThrow != null)
			{
				throw new NuGenHL7Exception("Invalid message", toThrow);
			}
			
			return result;
		}
		static NuGenMessageValidator()
		{
		}
	}
}