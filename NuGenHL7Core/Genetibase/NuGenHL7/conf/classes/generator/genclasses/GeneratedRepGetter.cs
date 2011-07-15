/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GeneratedRepGetter.java".  Description: 
/// "This Class represents a method to access a repeatable child" 
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
	
	/// <summary>This Class represents a method to access a repeatable child</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class GeneratedRepGetter:GeneratedMethod
	{
		
		/// <summary>A method used to access a reatable child</summary>
		/// <param name="profileName">this is the profile name associated with this Class
		/// </param>
		public GeneratedRepGetter(ProfileName profileName, bool isRepeatable):base()
		{
			
			if (isRepeatable)
				this.addParam("int rep");
			System.String repSuperParam = isRepeatable?"rep":"1";
			
			this.Visibility = "public";
			this.ReturnType = profileName.ClassName;
			this.Name = profileName.AccessorName;
			this.addToThrows("ConfRepException");
			this.addToBody("return (" + profileName.ClassName + ")super.getChild( " + profileName.MemberName + ", " + repSuperParam + " );");
		}
	}
}