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
using Genetibase.NuGenHL7.conf.classes.generator.genclasses;
using Genetibase.NuGenHL7.conf.spec;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This Class contains some of the Documentation for the Class to be generated</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public sealed class DocumentationBuilder
	{
		/// <summary>Contains the License agreement for the Generated Classes</summary>
		/// <returns> Generated Class Lincense agreement
		/// </returns>
		public System.String GeneratedClassHeader
		{
			get
			{
				return ("/**\n" + "The following code was automatically genearated by the Conformance Class Generation System\n" + "Contributor(s):The Conformance Class Generation System was developed by\n" + "                --------------.:JH6 Solutions:.--------------\n" + "                James Agnew - jait214@yahoo.ca\n" + "                Paul Brohman - pbrohman@rogers.com\n" + "                Mitch Delachevrotiere - hapimgd@hotmail.com\n" + "                Shawn Dyck - sdyck613@yahoo.ca\n" + "                Cory Metcalf - cory_metcalf@hotmail.com\n" + "\n" + "*/");
			}
			
		}
		
		private static DocumentationBuilder documentationBuilder;
		
		/// <summary>Returns the singleton instance of the DocumentationBuilder</summary>
		/// <returns> the singleton instance of the DocumentationBuilder
		/// </returns>
		public static DocumentationBuilder getDocumentationBuilder()
		{
			if (documentationBuilder == null)
				documentationBuilder = new DocumentationBuilder();
			
			return documentationBuilder;
		}
		
		/// <summary>Default Constructor </summary>
		private DocumentationBuilder()
		{
		}
		
		/// <summary>Adds a label and it data value to GeneratedClass Comments in a table format</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="label">optional comment label to add to the class header document table
		/// </param>
		/// <param name="data">the data value to add to the class header document table
		/// </param>
		private void  addOptionalComment(GeneratedConformanceContainer genClass, System.String label, System.String data)
		{
			if (data != null && (System.Object) data != (System.Object) "")
				genClass.addClassComment("   <tr><td>" + label + "</td><td>" + data + "</td></tr>");
		}
		
		/// <summary>Adds a label and it data value to Primitive GeneratedClass Comments in a table format</summary>
		/// <param name="genClass">a GeneratedPrimitive
		/// </param>
		/// <param name="label">optional comment label to add to the class header document table
		/// </param>
		/// <param name="data">the data value to add to the class header document table
		/// </param>
		private void  addOptionalComment(GeneratedPrimitive genClass, System.String label, System.String data)
		{
			if (data != null && (System.Object) data != (System.Object) "")
				genClass.addClassComment("   <tr><td>" + label + "</td><td>" + data + "</td></tr>");
		}
		
		/// <summary>Adds a table of comments to a Generated Component Class</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="comp">the component for which the comments are being added to
		/// </param>
		public void  decorateComponent(GeneratedConformanceContainer genClass, Component comp)
		{
			genClass.addClassComment("This class contains and provides access to all SubComponents");
			genClass.addClassComment("<table>");
			addOptionalComment(genClass, "Name", comp.Name);
			addOptionalComment(genClass, "Usage", comp.Usage);
			addOptionalComment(genClass, "Data Type", comp.Datatype);
			addOptionalComment(genClass, "Constant Value", comp.ConstantValue);
			addOptionalComment(genClass, "Description", comp.Description);
			addOptionalComment(genClass, "Implementation Note", comp.ImpNote);
			addOptionalComment(genClass, "Predicate", comp.Predicate);
			addOptionalComment(genClass, "Reference", comp.Reference);
			addOptionalComment(genClass, "Length", comp.Length + "");
			if (comp.Length != 0)
				addOptionalComment(genClass, "Table", comp.Table + "");
			genClass.addClassComment("</table>");
		}
		
		/// <summary>Adds a table of comments to a Conformance Message Class</summary>
		/// <param name="genClass">a GeneratedConformanceMessage
		/// </param>
		/// <param name="runtimeProfile">the runtimeProfile for which the comments are being added to
		/// </param>
		public void  decorateConformanceMessage(GeneratedConformanceMessage genClass, RuntimeProfile runtimeProfile)
		{
			genClass.addToClassComments("This class is the primary access class for the HL7 " + runtimeProfile.getHL7Version() + " " + runtimeProfile.Message.MsgType + " Conformance");
			genClass.addToClassComments("Class Set. This message has the following attributes:<br>");
			genClass.addToClassComments("<table>");
			genClass.addToClassComments("<tr><td>Message Type</td><td>" + runtimeProfile.Message.MsgType + "</td></tr>");
			genClass.addToClassComments("<tr><td>Event Type</td><td>" + runtimeProfile.Message.EventType + "</td></tr>");
			genClass.addToClassComments("<tr><td>HL7 Version</td><td>" + runtimeProfile.getHL7Version() + "</td></tr>");
			genClass.addToClassComments("</table><br><br>");
			genClass.addToClassComments("<b>Purpose</b><br>");
			genClass.addToClassComments(runtimeProfile.Message.EventDesc);
		}
		
		/// <summary>Adds Class Comments to a getMaxLength method</summary>
		/// <param name="genMethod">the Generated Method to add the constant value comments to
		/// </param>
		public void  decorateConstantValue(GeneratedMethod genMethod)
		{
			genMethod.addToDescription("Returns the constant value associated with this Data Type");
			genMethod.addToComments("@return the constant value associated with this Data Type, or <code>null</code> if there is none");
		}
		
		/// <summary>Adds comments to a generated constructor</summary>
		/// <param name="constructor">a constructor to add comments to
		/// </param>
		/// <param name="msg">the message
		/// </param>
		public void  decorateConstructor(GeneratedMethod constructor, System.String className)
		{
			constructor.addToDescription("Default constructor for Conformance_HL7_" + className + ". Has the");
			constructor.addToDescription("following functions:");
			constructor.addToDescription("<ul><li>Instantiating all required Conformance Classes in the structure");
			constructor.addToDescription("    <li>Instantiating the underlying HAPI Message object");
			constructor.addToDescription("    <li>Populating any constant values");
			constructor.addToDescription("</ul>");
		}
		
		/// <summary>Adds Class Comments to a Generated Field Class</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="field">the field for which the comments are being added to
		/// </param>
		public void  decorateField(GeneratedConformanceContainer genClass, Field field)
		{
			genClass.addClassComment("This represents a constrained " + field.Name + " field, with the following proerties:");
			genClass.addClassComment("<table>");
			addOptionalComment(genClass, "Name", field.Name);
			addOptionalComment(genClass, "Usage", field.Usage);
			addOptionalComment(genClass, "Description", field.Description);
			addOptionalComment(genClass, "Implementation Note", field.ImpNote);
			addOptionalComment(genClass, "Predicate", field.Predicate);
			addOptionalComment(genClass, "Reference", field.Reference);
			addOptionalComment(genClass, "Minimum Repetitions ", field.Min + "");
			addOptionalComment(genClass, "Maximum Repetitions ", field.Max + "");
			genClass.addClassComment("</table>");
		}
		
		/// <summary>Adds Class Comments to a getMaxLength method</summary>
		/// <param name="genMethod">a GeneratedMethod
		/// </param>
		public void  decorateMaxLength(GeneratedMethod genMethod)
		{
			genMethod.addToDescription("Returns the Maximum allowable length for the Data Type");
			genMethod.addToComments("@return the maximum allowable length of the Data Type");
		}
		
		/// <summary>Adds Class Comments to a Maximum Repition Method</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="genMethod">the GeneratedMethod for which the comments are being added to
		/// </param>
		public void  decorateMaxReps(GeneratedMethod genMethod)
		{
			
			genMethod.addToDescription("This method returns the maximum allowable");
			genMethod.addToComments("repetitions of this object.");
			genMethod.addToComments("@return maximum allowable repetitions");
		}
		
		/// <summary>Adds Class Comments to a Minimum Repition Method</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="genMethod">the GeneratedMethod for which the comments are being added to
		/// </param>
		public void  decorateMinReps(GeneratedMethod genMethod)
		{
			
			genMethod.addToDescription("This method returns the minimum allowable");
			genMethod.addToComments("repetitions of this object.");
			genMethod.addToComments("@return minimum allowable repetitions");
		}
		
		/// <summary>Adds Class Comments to a Generated Primitive Class</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="ac">the AbstractComponent for which the comments are being added to
		/// </param>
		public void  decoratePrimitive(GeneratedPrimitive genClass, AbstractComponent ac)
		{
			genClass.addClassComment("This represents a constrained " + ac.Name + " field, with the following properties:");
			genClass.addClassComment("<table>");
			addOptionalComment(genClass, "Name", ac.Name);
			addOptionalComment(genClass, "Usage", ac.Usage);
			addOptionalComment(genClass, "Data Type", ac.Datatype);
			addOptionalComment(genClass, "Constant Value", ac.ConstantValue);
			addOptionalComment(genClass, "Description", ac.Description);
			addOptionalComment(genClass, "Implementation Note", ac.ImpNote);
			addOptionalComment(genClass, "Predicate", ac.Predicate);
			addOptionalComment(genClass, "Reference", ac.Reference);
			addOptionalComment(genClass, "Length", ac.Length + "");
			if (ac.Table != null && Regex.IsMatch(ac.Table, "[^0]"))
				addOptionalComment(genClass, "Table", ac.Table + "");
			genClass.addClassComment("</table>");
		}
		
		/// <summary>Adds Class Comments to a Generated Class</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="ps">the Profile Structure for which the comments are being added to
		/// </param>
		public void  decorateProfileStructure(GeneratedConformanceContainer genClass, ProfileStructure ps)
		{
			genClass.addClassComment("This represents a constrained " + ps.Name + " segment, with the following properties:");
			genClass.addClassComment("<table>");
			addOptionalComment(genClass, "Name", ps.Name);
			addOptionalComment(genClass, "Usage", ps.Usage);
			addOptionalComment(genClass, "Description", ps.Description);
			addOptionalComment(genClass, "Implementation Note", ps.ImpNote);
			addOptionalComment(genClass, "Predicate", ps.Predicate);
			addOptionalComment(genClass, "Reference", ps.Reference);
			addOptionalComment(genClass, "Minimum Repetitions ", ps.Min + "");
			addOptionalComment(genClass, "Maximum Repetitions ", ps.Max + "");
			genClass.addClassComment("</table>");
		}
		
		/// <summary>Adds Class Comments to a Generated Method</summary>
		/// <param name="genMethod">a GeneratedRepGetter
		/// </param>
		/// <param name="field">the field for which the comments are being added to
		/// </param>
		/// <param name="repType">the repetition Type
		/// </param>
		public void  decorateRepGetter(GeneratedRepGetter genMethod, Field field, System.String repType)
		{
			
			genMethod.addToDescription("This method returns a reference to the " + field.Name + " field belonging to this segment.");
			genMethod.addToComments("Min Repetitions " + field.Min);
			genMethod.addToComments("Max Repetitions " + field.Max);
			if (field.Max == - 1)
				genMethod.addToComments("@param rep The desired repetition number");
			genMethod.addToComments("@return the child object reference. <b>rep must fall between " + field.Min + " and " + field.Max + "</b>");
			genMethod.addToComments("@throws Genetibase.NuGenHL7.conf.classes.exceptions.ConfRepException");
		}
		
		/// <summary>Adds Class Comments to a Generated Method</summary>
		/// <param name="genMethod">a GeneratedRepGetter
		/// </param>
		/// <param name="profileStructure">the Profile Structure for which the comments are being added to
		/// </param>
		/// <param name="repType">the repetition Type
		/// </param>
		public void  decorateRepGetter(GeneratedRepGetter genMethod, ProfileStructure profileStructure, System.String repType)
		{
			
			genMethod.addToDescription("This method returns a reference to the " + profileStructure.Name + " child.");
			genMethod.addToComments("Min Repetitions" + profileStructure.Min);
			genMethod.addToComments("Max Repetitions" + profileStructure.Max);
			if (profileStructure.Max == - 1)
				genMethod.addToComments("@param rep The desired repetition number");
			genMethod.addToComments("@return the child object reference. <b>rep must fall between " + profileStructure.Min + " and " + profileStructure.Max + "</b>");
			genMethod.addToComments("@throws Genetibase.NuGenHL7.conf.classes.exceptions.ConfRepException");
		}
		
		/// <summary>Adds Class Comments to a Generated SegGroup Class</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="segGroup">the SegGroup for which the comments are being added to
		/// </param>
		public void  decorateSegGroup(GeneratedConformanceContainer genClass, SegGroup segGroup)
		{
			this.decorateProfileStructure(genClass, segGroup);
		}
		
		/// <summary>Adds Class Comments to a Generated Segment Class</summary>
		/// <param name="genClass">a GeneratedConformanceContainer
		/// </param>
		/// <param name="seg">the Segment for which the comments are being added to
		/// </param>
		public void  decorateSegment(GeneratedConformanceContainer genClass, Seg seg)
		{
			this.decorateProfileStructure(genClass, seg);
		}
		
		public void  decorateSetValue(GeneratedMethod genMethod, long maxLength)
		{
			genMethod.addToDescription("This method validates the <code>String</code> value passed in to be no greater then the");
			genMethod.addToDescription("maximum allowable length for the extending class.  If the <code>String</code> value is valid, this");
			genMethod.addToDescription("method will set the underlying HAPI class's value. If the data passed in is invalid for the given");
			genMethod.addToDescription("data type, a ConformanceException is thrown.");
			genMethod.addToDescription("@throws ConfDataException if the data is invalid for the given datatype");
			//TODO: this probably isn't the right exception type
			genMethod.addToDescription("@param value The value to be set.");
			if (maxLength > 0)
				genMethod.addToDescription("Note: The value has a maximum length of " + maxLength);
		}
	}
}