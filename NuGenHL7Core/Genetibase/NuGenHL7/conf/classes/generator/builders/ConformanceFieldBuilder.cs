/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ConformanceFieldBuilder.java".  Description: 
/// "/** This class is builds Conformance Field Classes" 
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
using Genetibase.NuGenHL7.conf.spec.message;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This class builds Conformance Field Classes</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class ConformanceFieldBuilder
	{
		private DeploymentManager depManager;
		private DocumentationBuilder docBuilder; // The documentation builder
		
		private System.String packageName; // Represents the Package that this Segment will go in
		private System.String underlyingType; // The underlying HAPI Type
		private System.String versionString; // The HAPI version
		
		/// <summary>This constructor will create a new ConformanceFieldBuilder</summary>
		/// <param name="packageName">the name of the package
		/// </param>
		/// <param name="versionString">the version of HL7 which these classes are conforming to
		/// </param>
		/// <param name="depManager">the instance of DeploymentManager
		/// </param>
		public ConformanceFieldBuilder(System.String packageName, System.String versionString, DeploymentManager depManager):base()
		{
			this.packageName = packageName;
			this.docBuilder = DocumentationBuilder.getDocumentationBuilder();
			this.depManager = depManager;
			this.versionString = versionString;
		}
		
		/// <summary>This method builds a Conformance Field Class</summary>
		/// <param name="field">the Field to build
		/// </param>
		/// <param name="parentUnderlyingType">the data type of the parent Segment for this field
		/// example "Genetibase.NuGenHL7.model.v24.segment.MSH"  
		/// </param>
		/// <param name="profileName"> ProfileName
		/// </param>
		public virtual void  buildClass(Field field, System.String parentUnderlyingType, ProfileName profileName)
		{
			GeneratedConformanceContainer gcc = new GeneratedConformanceContainer();
			GeneratedMethod gm = new GeneratedMethod();
			
			// Check for possible snags in the Runtime Profile Segment
			if (field.Name == null || field.Name.Length < 1)
				throw new ConformanceError("Error building ConformanceField: Runtime Field does not contain a name.");
			
			// Set up class
			gcc.ClassPackage = packageName;
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.abs.*");
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.exceptions.*");
			gcc.addClassImport("Genetibase.NuGenHL7.model.*");
			gcc.addClassImport("Genetibase.NuGenHL7.*");
			
			if (field.Components > 0)
				gcc.addClassImport(packageName + "." + profileName.PackageName + ".*");
			
			gcc.Name = profileName.ClassName;
			
			gcc.Properties = "extends AbstractConformanceContainer implements Repeatable";
			gcc.setMinMaxReps(field.Min, field.Max);
			underlyingType = "Genetibase.NuGenHL7.model." + versionString + ".datatype." + field.Datatype;
			gcc.addMemberVariable(underlyingType + " hapiType;");
			gcc.addMemberVariable("private final short MAX_LENGTH = " + field.Length + ";");
			gm.ReturnType = "long";
			gm.Visibility = "public";
			gm.Name = "getMaxLength";
			gm.addToBody("return this.MAX_LENGTH;");
			docBuilder.decorateMaxLength(gm);
			gcc.addMethod(gm);
			
			// Set up underlying Field type
			gcc.Constructor.addParam(parentUnderlyingType + " hapiSegment", "The underlying HAPI field object");
			
			gcc.Constructor.addParam("int rep", "The desired repetition");
			gcc.Constructor.addToBody("try {");
			
			UnderlyingAccessor underlyingAccessor = new UnderlyingAccessor(parentUnderlyingType, profileName.AccessorName);
			gcc.Constructor.addToBody("   this.hapiType = hapiSegment." + underlyingAccessor + ";");
			
			docBuilder.decorateConstructor(gcc.Constructor, profileName.ClassName);
			
			// Create the getters and member variables associated with each child
			for (int i = 1; i <= field.Components; i++)
			{
				//don't build not supported, backward, or unknown types
				System.String usage = field.getComponent(i).Usage;
				if (usage != null && (usage.Equals("X") || usage.Equals("B") || usage.Equals("U")))
					continue;
				
				bool hasChildren = (field.getComponent(i).SubComponents > 0)?true:false;
				ProfileName childProfileName = new ProfileName(field.getComponent(i).Name, ProfileName.PS_COMP);
				gcc.addComponent(childProfileName, (short) (i - 1), hasChildren);
			}
			
			gcc.Constructor.addToBody("} catch ( HL7Exception e ) {");
			gcc.Constructor.addToBody("   throw new ConformanceError( \"Invalid Attempt to access a rep. This is a bug.\" );");
			gcc.Constructor.addToBody("}");
			
			// Decorate with comments
			docBuilder.decorateField(gcc, field);
			
			if (depManager.Verbose)
				System.Console.Out.WriteLine("Generating Field: " + packageName + "." + gcc.Name);
			
			// Create the components
			for (int i = 1; i <= field.Components; i++)
			{
				if (field.getComponent(i).SubComponents == 0)
				{
					ConformancePrimitiveBuilder childBuilder = new ConformancePrimitiveBuilder(packageName + "." + profileName.PackageName, depManager);
					childBuilder.buildClass(field.getComponent(i), ProfileName.PS_COMP);
				}
				else
				{
					ConformanceComponentBuilder childBuilder = new ConformanceComponentBuilder(packageName + "." + profileName.PackageName, depManager, versionString);
					childBuilder.buildClass(field.getComponent(i));
				}
			}
			depManager.generateFile(gcc, packageName, gcc.Name);
		}
	}
}