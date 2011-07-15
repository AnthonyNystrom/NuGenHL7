/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ConformanceSegmentBuilder.java".  Description: 
/// "This Class builds Conformance Segment Classes" 
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
	
	/// <summary>This Class builds Conformance Segment Classes</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class ConformanceSegmentBuilder
	{
		private DeploymentManager depManager; // The deployment manager
		private DocumentationBuilder docBuilder; // The documentation builder
		private System.String packageName; // Represents the Package that this Segment will go in
		
		private System.String versionString; // The HAPI version
		
		/// <summary>This constructor will create a new ConformanceSegmentBuilder</summary>
		/// <param name="packageName">the name of the package
		/// </param>
		/// <param name="versionString">the version of HL7 which these classes are conforming to
		/// </param>
		/// <param name="depManager">the instance of DeploymentManager
		/// </param>
		public ConformanceSegmentBuilder(System.String packageName, System.String versionString, DeploymentManager depManager):base()
		{
			this.packageName = packageName;
			this.versionString = versionString;
			this.docBuilder = DocumentationBuilder.getDocumentationBuilder();
			this.depManager = depManager;
		}
		
		/// <summary>This method builds a Conformance Segment Class</summary>
		/// <param name="seg">the Segment to build
		/// </param>
		/// <param name="parentUnderlyingType">the data type of the parent Message or SegGroup for this segment
		/// example "Genetibase.NuGenHL7.model.v24.group.ADR_A19_..."    
		/// </param>
		/// <param name="profileName">this is the profile name associated with this Class
		/// </param>
		public virtual void  buildClass(Seg seg, System.String parentUnderlyingType, ProfileName profileName)
		{
			GeneratedConformanceContainer gcc = new GeneratedConformanceContainer();
			System.String underlyingDataType; // The underlying HAPI Type
			
			// Check for possible snags in the Runtime Profile Segment
			if (seg.Name == null || seg.Name.Length < 1)
				throw new ConformanceError("Error building ConformanceSegment: Runtime Segment does not contain a name.");
			
			// Set up class
			gcc.ClassPackage = packageName;
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.abs.*");
			gcc.addClassImport("Genetibase.NuGenHL7.conf.classes.exceptions.*");
			gcc.addClassImport("Genetibase.NuGenHL7.*");
			gcc.addClassImport(packageName + "." + profileName.PackageName + ".*");
			
			gcc.Name = profileName.ClassName;
			gcc.Properties = "extends AbstractConformanceContainer implements Repeatable";
			gcc.setMinMaxReps(seg.Min, seg.Max);
			underlyingDataType = "Genetibase.NuGenHL7.model." + versionString + ".segment." + seg.Name;
			
			System.String segClassName = UnderlyingAccessor.getHapiModelClass(underlyingDataType).FullName;
			gcc.addMemberVariable("private " + segClassName + " hapiSegment;");
			
			docBuilder.decorateConstructor(gcc.Constructor, profileName.ClassName);
			
			// Set up underlying Segment type
			GeneratedMethod theConstructor = gcc.Constructor;
			theConstructor.addParam(parentUnderlyingType + " underlyingMessage", "The underlying message object");
			theConstructor.addParam("int rep", "The underlying rep number");
			UnderlyingAccessor underlyingAccessor = new UnderlyingAccessor(parentUnderlyingType, profileName.AccessorName);
			theConstructor.addToBody("this.hapiSegment = (" + segClassName + ") underlyingMessage." + underlyingAccessor.ToString() + ";");
			theConstructor.addToThrows("HL7Exception");
			
			// Loop through each child. Note that array is 1-offset
			for (int i = 1; i <= seg.Fields; i++)
			{
				//don't build not supported, backward, or unknown types
				System.String usage = seg.getField(i).Usage;
				if (usage != null && (usage.Equals("X") || usage.Equals("B") || usage.Equals("U")))
					continue;
				
				// Create the names for each type of child
				//         //CHANGED to use field # instead of name, in support of Z-segments 
				//         ProfileName childProfileName = profileName.newInstance(String.valueOf(i), ProfileName.PS_FIELD);
				ProfileName childProfileName = profileName.newInstance(seg.getField(i).Name, ProfileName.PS_FIELD);
				
				// Add the member variable vector to hold them
				gcc.addMemberVariable("private FiniteList " + childProfileName.MemberName + ";");
				
				// Set up the constructor
				theConstructor.addToBody(childProfileName.MemberName + " = new FiniteList( " + childProfileName.ClassName + ".class, hapiSegment );");
				
				// Add the getter
				UnderlyingAccessor childAccessor = new UnderlyingAccessor(underlyingDataType, childProfileName.AccessorName);
				GeneratedRepGetter repGetter = new GeneratedRepGetter(childProfileName, childAccessor.AcceptsRep);
				docBuilder.decorateRepGetter(repGetter, seg.getField(i), childProfileName.ClassName);
				gcc.addMethod(repGetter);
				
				// If the field has no components it is a primitive, so build as such.
				if (seg.getField(i).Components > 0)
				{
					ConformanceFieldBuilder childBuilder = new ConformanceFieldBuilder(packageName + "." + profileName.PackageName, versionString, depManager);
					childBuilder.buildClass(seg.getField(i), segClassName, childProfileName.clearNameMap());
				}
				else
				{
					ConformancePrimitiveBuilder childBuilder = new ConformancePrimitiveBuilder(packageName + "." + profileName.PackageName, depManager);
					childBuilder.buildClass(seg.getField(i), segClassName, childProfileName.clearNameMap());
				}
			}
			
			// Decorate with comments
			docBuilder.decorateSegment(gcc, seg);
			
			if (depManager.Verbose)
				System.Console.Out.WriteLine("Generating Segment: " + packageName + "." + gcc.Name);
			
			depManager.generateFile(gcc, packageName, profileName.ClassName);
		}
	}
}