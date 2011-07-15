/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GeneratedPrimitive.java".  Description: 
/// "This Class adds the necessary functionality to a primitive Class" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): James Agnew
/// Paul Brohman
/// Mitch Delachevrotiere
/// Shawn Dyck
/// Cory Metcalf
/// </summary>
/// <summary>Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  ?GPL?), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using Genetibase.NuGenHL7.conf.classes.generator.builders;
namespace Genetibase.NuGenHL7.conf.classes.generator.genclasses
{
	
	/// <summary>This Class adds the necessary functionality to a primitive Class</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class GeneratedPrimitive:GeneratedConformanceContainer
	{
		private DocumentationBuilder docBuilder; // The documentation builder
		
		private bool hasConstantValue;
		
		/// <summary>Genrates a primitive class</summary>
		public GeneratedPrimitive():base()
		{
			
			docBuilder = DocumentationBuilder.getDocumentationBuilder();
			
			hasConstantValue = false;
			
			// Set up constructor
			this.Constructor.addParam("Primitive hapiPrimitive", "Reference to the underlying HAPI <CODE>Primitive</CODE> data type.");
			this.Constructor.addToBody("super( hapiPrimitive );");
			
			GeneratedMethod getMaxLength = new GeneratedMethod();
			getMaxLength.Name = "getMaxLength";
			getMaxLength.addToBody("return MAX_LENGTH;");
			getMaxLength.ReturnType = "long";
			getMaxLength.Visibility = "public";
			docBuilder.decorateMaxLength(getMaxLength);
			this.addMethod(getMaxLength);
			
			GeneratedMethod getConstantValue = new GeneratedMethod();
			getConstantValue.Name = "getConstantValue";
			getConstantValue.addToBody("return CONSTANT_VALUE;");
			getConstantValue.ReturnType = "String";
			getConstantValue.Visibility = "public";
			docBuilder.decorateConstantValue(getConstantValue);
			this.addMethod(getConstantValue);
		}
		
		/// <summary>adds the constant value member variable to the primitive class</summary>
		/// <param name="constantValue">the value to enforce
		/// </param>
		public virtual void  addConstantValue(System.String constantValue)
		{
			hasConstantValue = true;
			
			if (constantValue != null)
			{
				constantValue = "\"" + constantValue + "\"";
			}
			else
				constantValue = "null";
			
			this.addMemberVariable("private final String CONSTANT_VALUE = " + constantValue + ";");
		}
		
		/// <summary>adds the constant member variable to the primitive class representing the maximum length</summary>
		/// <param name="maxLength">the maximum length to enforce
		/// </param>
		public virtual void  addMaxLength(long maxLength)
		{
			this.addMemberVariable("private final int MAX_LENGTH = " + maxLength + ";");
		}
		
		/// <summary>adds the constant value member variable to the primitive class</summary>
		/// <returns> a String representation of the constant value
		/// </returns>
		public override System.String ToString()
		{
			if (!hasConstantValue)
				addConstantValue(null);
			
			return base.ToString();
		}
	}
}