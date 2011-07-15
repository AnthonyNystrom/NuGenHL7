/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DBTableRepository.java".  Description: 
/// "This class represents the source specific to a ConformanceMessage class" 
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
namespace Genetibase.NuGenHL7.conf.classes.generator.genclasses
{
	
	/// <summary>This class represents the source specific to a ConformanceMessage class</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class GeneratedConformanceMessage:GeneratedConformanceContainer
	{
		
		/// <summary>Default constructor </summary>
		public GeneratedConformanceMessage()
		{
		}
		
		/// <summary>Adds the member variable to the ConformanceMessage class and
		/// adds a line to the constructor to instantiate that member variable
		/// </summary>
		/// <param name="a">String representing the hl7 message type 
		/// example "Genetibase.NuGenHL7.model.ADT_A01"
		/// </param>
		public virtual void  addHAPIMessage(System.String msgType)
		{
			
			// add member variable
			this.addMemberVariable("private " + msgType + " hapiMessage;");
			
			// add instantiator to the constructor
			GeneratedMethod constructor = this.Constructor;
			constructor.addToBody("hapiMessage = new " + msgType + "();");
			
			// add getter for hapi message
			GeneratedMethod getHAPIMessage = new GeneratedMethod();
			getHAPIMessage.Name = "getHAPIMessage";
			getHAPIMessage.Visibility = "public";
			getHAPIMessage.ReturnType = msgType;
			getHAPIMessage.addToBody("return hapiMessage;");
			getHAPIMessage.addToComments("This method returns the HAPI message object.");
			getHAPIMessage.addToComments("@return A <code>" + msgType + "</code> object representing the type of message");
			this.addMethod(getHAPIMessage);
		}
	}
}