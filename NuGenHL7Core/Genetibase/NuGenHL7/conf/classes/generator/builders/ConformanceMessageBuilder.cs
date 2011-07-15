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
using Genetibase.NuGenHL7.conf.spec.message;
using Genetibase.NuGenHL7.conf.spec;
using Genetibase.NuGenHL7.conf.classes.generator.genclasses;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This method builds the Conformance Message Class</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class ConformanceMessageBuilder
	{
		private GeneratedConformanceMessage confMsg;
		private DeploymentManager depManager;
		private StaticDef msg;
		private System.String packageName;
		
		private RuntimeProfile runtimeProfile;
		
		/// <summary>This constructor will create a new ConformanceMessageBuilder</summary>
		/// <param name="packageName">the name of the package
		/// </param>
		public ConformanceMessageBuilder(System.String packageName)
		{
			this.packageName = packageName;
		}
		
		/// <summary>This method builds a Conformance Message Class</summary>
		/// <param name="runtimeProfile">the profile which to genrate Conformance Classes for
		/// </param>
		/// <param name="depManager">the DeploymentManager
		/// </param>
		public virtual void  buildClass(RuntimeProfile runtimeProfile, DeploymentManager depManager)
		{
			this.depManager = depManager;
			this.runtimeProfile = runtimeProfile;
			this.msg = runtimeProfile.Message;
			this.confMsg = new GeneratedConformanceMessage();
			
			ProfileName profileName = new ProfileName(msg.MsgStructID, ProfileName.PS_MSG);
			
            String version = Regex.Replace(runtimeProfile.getHL7Version(), "\\.", "");

			System.String underlyingDataType = "Genetibase.NuGenHL7.model." + version + ".message." + msg.MsgStructID;
			
			ConformanceSegmentBuilder confSegBuilder = new ConformanceSegmentBuilder(packageName, version, depManager);
			ConformanceSegGroupBuilder confSegGroupBuilder = new ConformanceSegGroupBuilder(packageName, version, depManager, msg.MsgStructID);
			DocumentationBuilder docBuilder = DocumentationBuilder.getDocumentationBuilder();
			
			// Add class package and imports
			confMsg.ClassPackage = packageName;
			confMsg.addClassImport("Genetibase.NuGenHL7.conf.classes.abs.*");
			confMsg.addClassImport("Genetibase.NuGenHL7.conf.classes.exceptions.*");
			
			// Set class properties
			confMsg.Name = profileName.ClassName;
			confMsg.Properties = "extends AbstractConformanceContainer";
			
			// Decorate the class with comments
			docBuilder.decorateConformanceMessage(confMsg, runtimeProfile);
			docBuilder.decorateConstructor(confMsg.Constructor, msg.MsgType);
			
			// add hapi message
			confMsg.addHAPIMessage(underlyingDataType);
			
			for (int i = 1; i <= msg.Children; i++)
			{
				//don't build not supported, backward, or unknown types
				System.String usage = msg.getChild(i).Usage;
				if (usage.Equals("X") || usage.Equals("B") || usage.Equals("U"))
					continue;
				
				if (msg.getChild(i) is Seg)
				{
					ProfileName childProfileName = profileName.newInstance(msg.getChild(i).Name, ProfileName.PS_SEG);
					
					// Add the member variable vector to hold them
					confMsg.addMemberVariable("private FiniteList " + childProfileName.MemberName + ";");
					confMsg.Constructor.addToBody(childProfileName.MemberName + " = new FiniteList( " + childProfileName.ClassName + ".class, hapiMessage );");
					
					UnderlyingAccessor childAccessor = new UnderlyingAccessor(underlyingDataType, childProfileName.AccessorName);
					GeneratedRepGetter repGetter = new GeneratedRepGetter(childProfileName, childAccessor.AcceptsRep);
					
					docBuilder.decorateRepGetter(repGetter, (Seg) msg.getChild(i), childProfileName.AccessorName);
					
					confMsg.addMethod(repGetter);
					if (depManager.Verbose)
						System.Console.Out.WriteLine("Generating Segment: " + packageName + "." + confMsg.Name);
					
					confSegBuilder.buildClass((Seg) msg.getChild(i), underlyingDataType, childProfileName.clearNameMap());
				}
				else if (msg.getChild(i) is SegGroup)
				{
					ProfileName childProfileName = profileName.newInstance(msg.getChild(i).Name, ProfileName.PS_SEGG);
					
					// Add the member variable vector to hold them
					confMsg.addMemberVariable("private FiniteList " + childProfileName.MemberName + ";");
					confMsg.Constructor.addToBody(childProfileName.MemberName + " = new FiniteList( " + childProfileName.ClassName + ".class, hapiMessage );");
					
					System.String underlyingAccessorName = "get" + msg.MsgStructID + "_" + ConformanceSegGroupBuilder.generateSegGroupName((SegGroup) msg.getChild(i));
					UnderlyingAccessor childAccessor = new UnderlyingAccessor(underlyingDataType, underlyingAccessorName);
					GeneratedRepGetter repGetter = new GeneratedRepGetter(childProfileName, childAccessor.AcceptsRep);
					
					docBuilder.decorateRepGetter(repGetter, (SegGroup) msg.getChild(i), childProfileName.OriginalName);
					confMsg.addMethod(repGetter);
					if (depManager.Verbose)
						System.Console.Out.WriteLine("Generating SegGroup: " + packageName + "." + confMsg.Name);
					
					confSegGroupBuilder.buildClass((SegGroup) msg.getChild(i), underlyingDataType, childProfileName.clearNameMap());
				}
			}
			
			depManager.generateFile(confMsg, packageName, profileName.ClassName);
		}
	}
}