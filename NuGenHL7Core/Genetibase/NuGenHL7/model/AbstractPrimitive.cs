/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "AbstractPrimitive.java".  Description:
/// "Base class for Primitives.  Performs validation in setValue()."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001-2005.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using PrimitiveTypeRule = Genetibase.NuGenHL7.validation.NuGenPrimitiveTypeRule;
using ValidationContext = Genetibase.NuGenHL7.validation.NuGenValidationContext;
namespace Genetibase.NuGenHL7.model
{
	
	/// <summary> Base class for Primitives.  Performs validation in setValue().
	/// 
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public abstract class AbstractPrimitive:AbstractType, Primitive
	{
		/// <seealso cref="Genetibase.NuGenHL7.model.Primitive.getValue()">
		/// </seealso>
		/// <summary> Sets the value of this Primitive, first performing validation as specified 
		/// by <code>getMessage().getValidationContext()</code>.  No validation is performed 
		/// if getMessage() returns null. 
		/// 
		/// </summary>
		/// <seealso cref="Genetibase.NuGenHL7.model.Primitive.setValue(String)">
		/// </seealso>
		virtual public System.String Value
		{
			get
			{
				return myValue;
			}
			
			set
			{
				Message message = Message;
				
				if (message != null)
				{
					ValidationContext context = message.ValidationContext;
					System.String version = message.Version;
					
					if (context != null)
					{
						PrimitiveTypeRule[] rules = context.getPrimitiveRules(version, Name, this);
						
						for (int i = 0; i < rules.Length; i++)
						{
							value = rules[i].correct(value);
							if (!rules[i].test(value))
							{
								throw new DataTypeException("Failed validation rule: " + rules[i].Description);
							}
						}
					}
				}
				
				myValue = value;
			}
			
		}
		
		/// <param name="message">message to which this type belongs
		/// </param>
		public AbstractPrimitive(Message message):base(message)
		{
		}
		
		private System.String myValue;
		
		/// <summary> Returns the value of getValue() </summary>
		/// <seealso cref="java.lang.Object.toString">
		/// </seealso>
		public override System.String ToString()
		{
			return this.Value;
		}
	}
}