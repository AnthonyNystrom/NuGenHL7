/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GeneratedConformanceContainer.java".  Description: 
/// "This Class is used to addChildren of types Component, SubComponent and to set min and max reps" 
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
	
	/// <summary>This class is used to addChildren of types Component, SubComponent and to set min and max reps</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class GeneratedConformanceContainer:GeneratedClass
	{
		
		/// <summary>Default constructor </summary>
		public GeneratedConformanceContainer()
		{
		}
		
		/// <summary>Adds a Component to a conformance Message
		/// adds a line to the constructor to instantiate that member variable
		/// </summary>
		/// <param name="profileName">this is the profile name associated with this Class
		/// </param>
		/// <param name="componentNumber">the number associated with the component in the profile 
		/// </param>
		/// <param name="childGetter">adds this line to the constructor to instantiate Conformance Component class
		/// </param>
		private void  addChild(ProfileName profileName, int componentNumber, System.String childGetter)
		{
			
			// Add member variable to class for holding Conformance Component class
			this.addMemberVariable("private " + profileName.ClassName + " " + profileName.MemberName + ";");
			
			// Add line to constructor to instantiate Conformance Component class
			this.Constructor.addToBody(childGetter);
			
			// Add method for retrieving Conformance Component Class
			GeneratedMethod getChildMethod = new GeneratedMethod();
			getChildMethod.addToComments("Provides access to the " + profileName.OriginalName + " component child");
			getChildMethod.addToComments("@return " + profileName.ClassName + " The " + profileName.OriginalName + " component child");
			getChildMethod.Visibility = "public";
			getChildMethod.ReturnType = profileName.ClassName;
			getChildMethod.Name = profileName.AccessorName;
			getChildMethod.addToBody("return " + profileName.MemberName + ";");
			this.addMethod(getChildMethod);
		}
		
		/// <summary>Adds a Component to a conformance Message
		/// adds a line to the constructor to instantiate that member variable
		/// </summary>
		/// <param name="profileName">this is the profile name associated with this Class
		/// </param>
		public virtual void  addComponent(ProfileName profileName, int componentNumber, bool hasChildren)
		{
			System.String underlyingType = hasChildren?"Composite":"Primitive";
			System.String childGetter = "   " + profileName.MemberName + " = new " + profileName.ClassName + "( (" + underlyingType + ")hapiType.getComponent(" + componentNumber + ") );";
			this.addChild(profileName, componentNumber, childGetter);
		}
		
		/// <summary>Adds a SubComponent to a conformance class
		/// adds a line to the constructor to instantiate that member variable
		/// </summary>
		/// <param name="profileName">this is the profile name associated with this Class
		/// </param>
		/// <param name="subComponentNumber">representing the number representing the subComponent to add
		/// </param>
		public virtual void  addSubComponent(ProfileName profileName, int subComponentNumber)
		{
			this.addComponent(profileName, subComponentNumber, false);
		}
		
		/// <summary>Special case for adding a subcomponent which is a TS type, because the TS
		/// underlying type is represented as a Composite, which shouldn't exist at
		/// the SubComponent level, but does due to ambiguity in the HL7 spec.
		/// </summary>
		/// <param name="profileName">this is the profile name associated with this Class
		/// </param>
		public virtual void  addTSSubComponent(ProfileName profileName, int componentNumber, System.String hl7Version)
		{
			
			System.String componentOneAccessor = "(Primitive)((Genetibase.NuGenHL7.model." + hl7Version + ".datatype.TS)(hapiType.getComponent(" + componentNumber + "))).getComponent(0)";
			System.String childGetter = "   " + profileName.MemberName + " = new " + profileName.ClassName + "( " + componentOneAccessor + " );";
			this.addChild(profileName, componentNumber, childGetter);
		}
		
		/// <summary>Adds min and max reps to the genrated classes</summary>
		/// <param name="minReps">the Minimum Repetitions
		/// </param>
		/// <param name="maxReps">Maximum Repetitions
		/// </param>
		public virtual void  setMinMaxReps(short minReps, short maxReps)
		{
			
			GeneratedMethod maxRepsMethod = new GeneratedMethod();
			GeneratedMethod minRepsMethod = new GeneratedMethod();
			
			this.addMemberVariable("private final short MAX_REPS = " + maxReps + ";");
			this.addMemberVariable("private final short MIN_REPS = " + minReps + ";");
			
			// Creates the methos to return the maximum number of repitions for the generated Class
			DocumentationBuilder.getDocumentationBuilder().decorateMaxReps(maxRepsMethod);
			maxRepsMethod.Visibility = "public";
			maxRepsMethod.ReturnType = "short";
			maxRepsMethod.Name = "getMaxReps";
			maxRepsMethod.addToBody("return this.MAX_REPS;");
			this.addMethod(maxRepsMethod);
			
			// Creates the method to return the maximum number of repitions for the generated Class
			DocumentationBuilder.getDocumentationBuilder().decorateMaxReps(minRepsMethod);
			minRepsMethod.Visibility = "public";
			minRepsMethod.ReturnType = "short";
			minRepsMethod.Name = "getMinReps";
			minRepsMethod.addToBody("return this.MIN_REPS;");
			this.addMethod(minRepsMethod);
		}
	}
}