/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ConformanceComponentBuilder.java".  Description: 
/// "This method builds Conformance Component Classes" 
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
using Genetibase.NuGenHL7.conf.spec.message;
using Genetibase.NuGenHL7.conf.classes.exceptions;
using Genetibase.NuGenHL7.conf;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This class builds Conformance Component Classes</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class ConformanceComponentBuilder
	{
		private DeploymentManager depManager; // The deployment manager
		private DocumentationBuilder docBuilder;
		private System.String packageName;
		private System.String versionString;
		
		/// <summary>This constructor will create a new ConformanceComponentBuilder</summary>
		/// <param name="packageName">the name of the package
		/// </param>
		/// <param name="versionString">the version of HL7 which these classes are conforming to
		/// </param>
		/// <param name="depManager">the instance of DeploymentManager
		/// </param>
		public ConformanceComponentBuilder(System.String packageName, DeploymentManager depManager, System.String versionString)
		{
			this.packageName = packageName;
			this.docBuilder = DocumentationBuilder.getDocumentationBuilder();
			this.depManager = depManager;
			this.versionString = versionString;
		}
		
		/// <summary>This method builds a Conformance Component Class</summary>
		/// <param name="comp">the Component to build
		/// </param>
		public virtual void  buildClass(Component comp)
		{
			
			ProfileName profileName = new ProfileName(comp.Name, ProfileName.PS_COMP);
			GeneratedConformanceContainer gcc = new GeneratedConformanceContainer();
			
			gcc.ClassPackage = packageName;
			
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.abs.*");
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.exceptions.*");
			gcc.addClassImport("Genetibase.NuGenHL7.model.*");
			gcc.addClassImport(packageName + "." + profileName.PackageName + ".*");
			
			gcc.Name = profileName.ClassName;
			gcc.Properties = "extends AbstractConformanceContainer";
			gcc.addMemberVariable("private Composite hapiType;");
			
			gcc.Constructor.addToComments("Creates new instances of all SubComponents contained in this Component");
			gcc.Constructor.addToBody("this.hapiType = hapiType;");
			
			docBuilder.decorateConstructor(gcc.Constructor, profileName.ClassName);
			// Add member variables and getters for subcomponents
			gcc.Constructor.addToBody("try{");
			for (int i = 1; i <= comp.SubComponents; i++)
			{
				//don't build not supported, backward, or unknown types
				System.String usage = comp.getSubComponent(i).Usage;
				if (usage != null && (usage.Equals("X") || usage.Equals("B") || usage.Equals("U")))
					continue;
				
				// The following is a workaround to allow for composite subcomponents. 
				System.Type c;
				System.Object instance;
				try
				{
					c = System.Type.GetType("Genetibase.NuGenHL7.model." + versionString + ".datatype." + comp.getSubComponent(i).Datatype);
					instance = c.GetConstructor(null).Invoke(null);
				}
				catch (System.Exception e)
				{
					throw new ConformanceError("Could not find underlying SubComponent datatype. This is a bug. Exception: " + e.ToString());
				}
				
				if (instance is Composite)
				{
					// In this case, the child is a composite subcomponent
					Component generatedComponent = createSubComponentProfile(c, comp.getSubComponent(i).Name);
					gcc.addComponent(new ProfileName(comp.getSubComponent(i).Name, ProfileName.PS_COMP), i - 1, true);
					ConformanceComponentBuilder childBuilder = new ConformanceComponentBuilder(packageName + "." + profileName.PackageName, depManager, versionString);
					childBuilder.buildClass(generatedComponent);
				}
				else
				{
					// In this case, the child is a primitive (this is the normal case)
					gcc.addSubComponent(new ProfileName(comp.getSubComponent(i).Name, ProfileName.PS_SUBC), i - 1);
					ConformancePrimitiveBuilder childBuilder = new ConformancePrimitiveBuilder(packageName + "." + profileName.PackageName, depManager);
					childBuilder.buildClass(comp.getSubComponent(i), ProfileName.PS_SUBC);
				}
			}
			
			gcc.Constructor.addParam("Composite hapiType", "Reference to the underlying HAPI Composite data type.");
			gcc.Constructor.addToBody("} catch ( DataTypeException e ) {");
			gcc.Constructor.addToBody("   throw new ConformanceError(\"Invalid Attempt to access a rep. This is a Conformance Class Bug\");");
			gcc.Constructor.addToBody("}");
			
			// Decorate with comments
			docBuilder.decorateComponent(gcc, comp);
			
			if (depManager.Verbose)
				System.Console.Out.WriteLine("Generating Component: " + packageName + "." + gcc.Name);
			
			depManager.generateFile(gcc, packageName, gcc.Name);
		}
		
		/// <summary>This method creates a Sub Component profile </summary>
		/// <param name="compositeClass">- the Class
		/// </param>
		/// <param name="name">- the Component name
		/// </param>
		/// <returns> Component - the Component
		/// </returns>
		private Component createSubComponentProfile(System.Type compositeClass, System.String name)
		{
			Component theComponent = new Component();
			int numSubComponents = 0;
			
			try
			{
				theComponent.Name = name;
				theComponent.Datatype = compositeClass.FullName.Substring(compositeClass.FullName.LastIndexOf('.') + 1);
				System.Reflection.MethodInfo[] methods = compositeClass.GetMethods();
				
				for (int i = 0; i < methods.Length; i++)
				{
					
					if (methods[i].ReturnType.FullName.Length > 18 && methods[i].ReturnType.FullName.Substring(0, (18) - (0)).Equals("Genetibase.NuGenHL7.model") && methods[i].GetParameters().Length == 0 && methods[i].Name.Substring(0,3).Equals("get"))
					{
						
						SubComponent sc = new SubComponent();
						sc.Name = methods[i].Name.Substring(3);
						sc.Datatype = methods[i].ReturnType.FullName.Substring(methods[i].ReturnType.FullName.LastIndexOf('.') + 1);
						sc.ConstantValue = "";
						
						numSubComponents++;
						theComponent.setSubComponent(numSubComponents, sc);
					}
				}
				
				/* Workaround for the TS datatype, as it does not currently
				* provide named getters for its subcomponents. */
				if (theComponent.Datatype.Equals("TS") && theComponent.SubComponents == 0)
				{
					SubComponent sc = new SubComponent();
					sc.Name = "DateTime";
					sc.Datatype = "NM";
					sc.ConstantValue = "";
					theComponent.setSubComponent(1, sc);
					
					sc = new SubComponent();
					sc.Name = "DegreeOfPrecision";
					sc.Datatype = "ST";
					sc.ConstantValue = "";
					theComponent.setSubComponent(2, sc);
				}
			}
			catch (NuGenProfileException e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
			
			return theComponent;
		}
	}
}