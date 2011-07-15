/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Structure.java".  Description: 
/// "Part of an HL7 message: either a segment or group" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
namespace Genetibase.NuGenHL7.model
{
	
	/// <summary> Part of an HL7 message: either a segment or group.  There are certain methods (e.g. Group.get())
	/// that will always return either a segment or a group.  This interface allows methods like this
	/// to declare a return type of Structure instead of Object.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public interface Structure
	{
		/// <summary> Returns the Message object to which this structure belongs.  This should normally be set at
		/// construction time.  A Structure can only belong to a single Message.  This is primarily 
		/// to avoid a situation where intended changes in one message cause unintended changes 
		/// in another that shares one of the same Structure objects.  
		/// </summary>
		Message Message
		{
			get;
			
		}
		/// <summary> Returns the parent group within which this structure exists (may be root 
		/// message group).  
		/// </summary>
		Group Parent
		{
			get;
			
		}
		
		/// <summary> Returns the structure's name. </summary>
		System.String getName();
	}
}