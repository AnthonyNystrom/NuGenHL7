/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Segment.java".  Description: 
/// "Represents an HL7 message segment, which is a unit of data that contains multiple fields.
/// </summary>
/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)" 
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
/// </author>
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model
{
	
	
	/// <summary> Represents an HL7 message segment, which is a unit of data that contains multiple fields.</summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public interface Segment:Structure
	{
		
		/// <summary> Returns the array of Fields at the specified index.  The array will be of length 1 for
		/// non-repeating fields, and >1 for repeating fields.  Fields are numbered from 1.
		/// </summary>
		/// <throws>  HL7Exception if field index is out of range. </throws>
		Type[] getField(int number);
		
		/// <summary> Returns a specific repetition of field at the specified index.  If there exist 
		/// fewer repetitions than are required, the number of repetitions can be increased 
		/// by specifying the lowest repetition that does not yet exist.  For example 
		/// if there are two repetitions but three are needed, the third can be created
		/// and accessed using the following code: <br>
		/// <code>Type t = getField(x, 2);</code>
		/// </summary>
		/// <param name="number">the field number 
		/// </param>
		/// <param name="rep">the repetition number (starting at 0)
		/// </param>
		/// <throws>  HL7Exception if field index is out of range, or if the specified   </throws>
		/// <summary>    repetition is more than 1 greater than the highest index of existing repetitions.  
		/// NOTE: to facilitate local extensions, no exception is thrown if 
		/// rep > max cardinality 
		/// </summary>
		Type getField(int number, int rep);
		
		/// <summary> Returns true if the field at the given index is required, false otherwise.</summary>
		/// <throws>  HL7Exception if field index is out of range. </throws>
		bool isRequired(int number);
		
		/// <summary> Returns the maximum length of the field at the given index, in characters.</summary>
		/// <throws>  HL7Exception if field index is out of range. </throws>
		int getLength(int number);
		
		/// <summary> Returns the maximum number of repetitions of this field that are allowed.  
		/// The current cardinality can be obtained by checking the length 
		/// of the array returned by getLength(n).  
		/// </summary>
		/// <throws>  HL7Exception if field index is out of range. </throws>
		int getMaxCardinality(int number);
		
		/// <summary> Returns the number of fields defined by this segment (repeating 
		/// fields are not counted multiple times).  
		/// </summary>
		int numFields();
	}
}