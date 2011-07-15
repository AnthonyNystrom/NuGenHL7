/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DBTableRepository.java".  Description: 
/// "Implements TableRepository by looking up values from the default HL7
/// normative database" 
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
using Genetibase.NuGenHL7.conf.classes.generator.genclasses;
using Genetibase.NuGenHL7.conf.classes.exceptions;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This Class builds Conformance Primitive Classes</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class ConformancePrimitiveBuilder
	{
		private DeploymentManager depManager; // The deployment manager
		private DocumentationBuilder docBuilder; // The documentation builder
		
		private System.String packageName; // Represents the Package that this Segment will go in
		
		/// <summary>This constructor will create a new ConformancePrimitiveBuilder</summary>
		public ConformancePrimitiveBuilder(System.String packageName, DeploymentManager depManager):base()
		{
			this.packageName = packageName;
			this.docBuilder = DocumentationBuilder.getDocumentationBuilder();
			this.depManager = depManager;
		}
		
		/// <summary>This method will build a primitive conformance class (ST, NM, etc) which is
		/// a Component or Subcomponent. 
		/// </summary>
		public virtual void  buildClass(Genetibase.NuGenHL7.conf.spec.message.AbstractComponent primitive, int profileType)
		{
			GeneratedPrimitive genClass = new GeneratedPrimitive();
			ProfileName profileName = new ProfileName(primitive.Name, profileType);
			
			// Set up class
			genClass.ClassPackage = packageName;
			genClass.addClassImport("Genetibase.NuGenHL7.model.*");
			genClass.addClassImport("Genetibase.NuGenHL7.conf.classes.abs.*");
			genClass.Properties = "extends AbstractConformanceDataType";
			
			genClass.Name = profileName.ClassName;
			docBuilder.decorateConstructor(genClass.Constructor, profileName.ClassName);
			
			if (primitive.ConstantValue != null && primitive.ConstantValue.Length > 0)
			{
				// Add constant value constraints if there are any
				genClass.addConstantValue(primitive.ConstantValue);
			}
			else
			{
				// if no constant value, then we add a setter method
				GeneratedMethod setter = new GeneratedMethod();
				setter.addParam("java.lang.String value");
				setter.addToThrows("ConfDataException");
				setter.addToBody("super.setValue( value );");
				setter.ReturnType = "void";
				setter.Visibility = "public";
				setter.Name = "setValue";
				docBuilder.decorateSetValue(setter, primitive.Length);
				genClass.addMethod(setter);
				
				genClass.addClassImport("Genetibase.NuGenHL7.conf.classes.exceptions.*");
			}
			genClass.addMaxLength(primitive.Length);
			
			// Decorate with comments
			docBuilder.decoratePrimitive(genClass, primitive);
			if (depManager.Verbose)
				System.Console.Out.WriteLine("Generating Primitive: " + packageName + "." + genClass.Name);
			
			depManager.generateFile(genClass, packageName, genClass.Name);
		}
		
		/// <summary>This method will build a primitive conformance class (ST, NM, etc) which is
		/// a Field. 
		/// </summary>
		public virtual void  buildClass(Genetibase.NuGenHL7.conf.spec.message.Field primitive, System.String parentUnderlyingType, ProfileName profileName)
		{
			GeneratedPrimitive genClass = new GeneratedPrimitive();
			
			// Check for possible snags in the Runtime Profile Component
			if (primitive.Name == null || primitive.Name.Length < 1)
				throw new ConformanceError("Error building ConformanceSegment: Runtime AbstractComponent does not contain a name.");
			
			GeneratedMethod theConstructor = new GeneratedMethod();
			genClass.Constructor = theConstructor;
			genClass.addClassImport("Genetibase.NuGenHL7.model.*");
			
			UnderlyingAccessor underlyingAccessor = new UnderlyingAccessor(parentUnderlyingType, profileName.AccessorName);
			theConstructor.addParam(parentUnderlyingType + " parentSeg", "The parent underlying data type");
			theConstructor.addParam("int rep", "The desired repetition");
			theConstructor.Name = profileName.ClassName;
			theConstructor.Visibility = "public ";
			theConstructor.addToThrows("Genetibase.NuGenHL7.HL7Exception");
			theConstructor.addToBody("super( (Primitive)parentSeg." + underlyingAccessor + " );");
			theConstructor.addToBody("if ( parentSeg." + underlyingAccessor + " == null )");
			theConstructor.addToBody("   throw new Genetibase.NuGenHL7.HL7Exception( \"Error accussing underlying object. This is a bug.\", 0 );");
			
			// Set up class
			genClass.ClassPackage = packageName;
			//genClass.addClassImport("Genetibase.NuGenHL7.model.*");
			genClass.addClassImport("Genetibase.NuGenHL7.conf.classes.abs.*");
			//genClass.addClassImport( "Genetibase.NuGenHL7.conf.classes.exceptions.*" );
			genClass.Properties = "extends AbstractConformanceDataType implements Repeatable";
			
			// Add min and max reps stuff
			genClass.setMinMaxReps(primitive.Min, primitive.Max);
			
			genClass.Name = profileName.ClassName;
			docBuilder.decorateConstructor(genClass.Constructor, profileName.ClassName);
			
			// Add constant value constraints if there are any, if not, add a setter method
			if (primitive.ConstantValue != null && primitive.ConstantValue.Length > 0)
			{
				genClass.addConstantValue(primitive.ConstantValue);
			}
			else
			{
				GeneratedMethod setter = new GeneratedMethod();
				setter.addParam("java.lang.String value");
				setter.addToThrows("ConfDataException");
				setter.addToBody("super.setValue( value );");
				setter.ReturnType = "void";
				setter.Visibility = "public";
				setter.Name = "setValue";
				docBuilder.decorateSetValue(setter, primitive.Length);
				genClass.addMethod(setter);
				
				genClass.addClassImport("Genetibase.NuGenHL7.conf.classes.exceptions.*");
			}
			genClass.addMaxLength(primitive.Length);
			
			// Decorate with comments
			docBuilder.decoratePrimitive(genClass, primitive);
			if (depManager.Verbose)
				System.Console.Out.WriteLine("Generating Primitive: " + packageName + "." + genClass.Name);
			
			depManager.generateFile(genClass, packageName, genClass.Name);
		}
	}
}