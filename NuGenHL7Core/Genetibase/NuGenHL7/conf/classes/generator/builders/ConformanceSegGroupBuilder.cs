/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ConformanceSegGroupBuilder.java".  Description: 
/// "This Class builds Conformance SegGroup Classes" 
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
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This Class builds Conformance SegGroup Classes</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class ConformanceSegGroupBuilder
	{
		
		private DeploymentManager depManager; // The deployment manager
		private DocumentationBuilder docBuilder; // The documentation builder
		
		private System.String packageName; // Represents the Package that this Segment will go in
		private System.String structID; // The struct ID of the message type
		private System.String version; // The HAPI version
		
		/// <summary>This constructor will create a new ConformanceSegmentBuilder</summary>
		/// <param name="packageName">the name of the package
		/// </param>
		/// <param name="versionString">the version of HL7 which these classes are conforming to
		/// </param>
		/// <param name="depManager">the instance of DeploymentManager
		/// </param>
		public ConformanceSegGroupBuilder(System.String packageName, System.String version, DeploymentManager depManager, System.String structID):base()
		{
			this.packageName = packageName;
			this.version = version;
			this.docBuilder = DocumentationBuilder.getDocumentationBuilder();
			this.depManager = depManager;
			this.structID = structID;
		}
		
		/// <summary>This method will build all the field children for this Segment</summary>
		/// <param name="segGroup">the SegGroup to build
		/// </param>
		/// <param name="parentUnderlyingType">the data type of the parent Message for this field
		/// example "Genetibase.NuGenHL7.model.v24.group.ADR_A19_..."  
		/// </param>
		/// <param name="profileName">this is the profile name associated with this Class
		/// </param>
		public virtual void  buildClass(SegGroup segGroup, System.String parentUnderlyingType, ProfileName profileName)
		{
			GeneratedConformanceContainer gcc = new GeneratedConformanceContainer();
			ConformanceSegmentBuilder confSegBuilder = new ConformanceSegmentBuilder(packageName + "." + profileName.PackageName, version, depManager);
			ConformanceSegGroupBuilder confSegGroupBuilder = new ConformanceSegGroupBuilder(packageName + "." + profileName.PackageName, version, depManager, structID);
			
			System.String underlyingDataType = structID + "_" + generateSegGroupName(segGroup);
			System.String underlyingPackageType = "Genetibase.NuGenHL7.model." + version + ".group." + underlyingDataType;
			
			// Set up class
			gcc.ClassPackage = packageName;
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.abs.*");
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.exceptions.*");
			gcc.addClassImport("Genetibase.NuGenHL7.*");
			gcc.addClassImport(packageName + "." + profileName.PackageName + ".*");
			
			gcc.Name = profileName.ClassName;
			gcc.Properties = "extends AbstractConformanceContainer implements Repeatable";
			gcc.setMinMaxReps(segGroup.Min, segGroup.Max);
			gcc.addMemberVariable("private " + underlyingPackageType + " hapiSegGroup;");
			
			// Set up underlying Segment type
			GeneratedMethod theConstructor = gcc.Constructor;
			docBuilder.decorateConstructor(theConstructor, profileName.ClassName);
			theConstructor.addParam(parentUnderlyingType + " underlyingMessage", "The underlying message object");
			theConstructor.addParam("int rep", "The underlying rep number");
			theConstructor.addToThrows("HL7Exception");
			
			UnderlyingAccessor underlyingAccessor = new UnderlyingAccessor(parentUnderlyingType, "get" + underlyingDataType);
			theConstructor.addToBody("this.hapiSegGroup = underlyingMessage." + underlyingAccessor.ToString() + ";");
			
			for (int i = 1; i <= segGroup.Children; i++)
			{
				//don't build not supported, backward, or unknown types
				System.String usage = segGroup.getChild(i).Usage;
				if (usage != null && (usage.Equals("X") || usage.Equals("B") || usage.Equals("U")))
					continue;
				
				if (segGroup.getChild(i) is Seg)
				{
					ProfileName childProfileName = profileName.newInstance(segGroup.getChild(i).Name, ProfileName.PS_SEG);
					
					// Add the member variable vector to hold them
					gcc.addMemberVariable("private FiniteList " + childProfileName.MemberName + ";");
					theConstructor.addToBody(childProfileName.MemberName + " = new FiniteList( " + childProfileName.ClassName + ".class, hapiSegGroup );");
					UnderlyingAccessor childAccessor = new UnderlyingAccessor(underlyingPackageType, childProfileName.AccessorName);
					GeneratedRepGetter repGetter = new GeneratedRepGetter(childProfileName, childAccessor.AcceptsRep);
					
					docBuilder.decorateRepGetter(repGetter, (Seg) segGroup.getChild(i), childProfileName.OriginalName);
					gcc.addMethod(repGetter);
					if (depManager.Verbose)
						System.Console.Out.WriteLine("Generating Segment: " + packageName + "." + gcc.Name);
					
					confSegBuilder.buildClass((Seg) segGroup.getChild(i), underlyingPackageType, childProfileName.clearNameMap());
				}
				else if (segGroup.getChild(i) is SegGroup)
				{
					ProfileName childProfileName = profileName.newInstance(segGroup.getChild(i).Name, ProfileName.PS_SEGG);
					
					// Add the member variable vector to hold them
					gcc.addMemberVariable("private FiniteList " + childProfileName.MemberName + ";");
					theConstructor.addToBody(childProfileName.MemberName + " = new FiniteList( " + childProfileName.ClassName + ".class, hapiSegGroup );");
					
					System.String underlyingAccessorName = "get" + structID + "_" + ConformanceSegGroupBuilder.generateSegGroupName((SegGroup) segGroup.getChild(i));
					UnderlyingAccessor childAccessor = new UnderlyingAccessor(underlyingPackageType, underlyingAccessorName);
					GeneratedRepGetter repGetter = new GeneratedRepGetter(childProfileName, childAccessor.AcceptsRep);
					
					docBuilder.decorateRepGetter(repGetter, (SegGroup) segGroup.getChild(i), childProfileName.OriginalName);
					gcc.addMethod(repGetter);
					if (depManager.Verbose)
						System.Console.Out.WriteLine("Generating SegGroup: " + packageName + "." + gcc.Name);
					
					confSegGroupBuilder.buildClass((SegGroup) segGroup.getChild(i), underlyingPackageType, childProfileName.clearNameMap());
				}
			}
			
			depManager.generateFile(gcc, packageName, profileName.ClassName);
		}
		
		/// <summary>This method creates the segment group name which is comprised of all the 
		/// underlying segments names put together
		/// </summary>
		/// <param name="segGroup">the SegGroup to build
		/// </param>
		public static System.String generateSegGroupName(SegGroup segGroup)
		{
			System.String name = new System.Text.StringBuilder().ToString();
			
			for (int i = 1; i <= segGroup.Children; i++)
			{
				ProfileStructure child = segGroup.getChild(i);
				if (child is Seg)
					name += child.Name;
				else
					name += generateSegGroupName((SegGroup) child);
			}
			
			return name;
		}
	}
}