/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Type.java".  Description: 
/// "An HL7 datatype" 
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
	
	/// <summary> An HL7 datatype.  Datatypes normally implement either Composite or Primitive.    </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public interface Type
	{
		/// <summary>Returns the name of the type (used in XML encoding and profile checking) </summary>
		System.String Name
		{
			get;
			
		}
		/// <summary> Returns an object containing any extra (non-standard) components that 
		/// have been added to this type at run-time.  This object can also be used
		/// to add components.  
		/// </summary>
		ExtraComponents ExtraComponents
		{
			get;
			
		}
		/// <returns> the message to which this Type belongs
		/// </returns>
		Message Message
		{
			get;
			
		}
	}
}