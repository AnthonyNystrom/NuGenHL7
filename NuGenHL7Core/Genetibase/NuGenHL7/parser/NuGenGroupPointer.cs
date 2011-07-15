/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GroupPointer.java".  Description: 
/// "A GroupPointer is used when parsing traditionally encoded HL7 messages" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Group = Genetibase.NuGenHL7.model.Group;
namespace Genetibase.NuGenHL7.parser
{
	
	/// <summary> A GroupPointer is used when parsing traditionally encoded HL7 messages. 
	/// It acts as a placeholder for a unique group "slot" in a message structure. 
	/// There is one GroupPointer per unique Group path (even if the group 
	/// repeats, and regardless of whether any instances exist).  
	/// 
	/// </summary>
	/// <deprecated> MessageIterator is now used 
	/// </deprecated>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public class NuGenGroupPointer:NuGenPointer
	{
		
		private NuGenPipeParser parser;
		new private Group parent;
		private System.String name;
		new private bool repeating;
		new private NuGenEncodingCharacters encodingChars;
		private NuGenPointer[] children;
		private Group currentGroup = null;
		private int childAtWhichToStart;
		
		/// <summary> Creates new GroupPointer </summary>
		public NuGenGroupPointer(NuGenPipeParser parser, Group parent, int position, NuGenEncodingCharacters encodingChars)
		{
			this.parser = parser;
			this.parent = parent;
			this.name = parent.Names[position];
			this.repeating = parent.isRepeating(this.name);
			this.encodingChars = encodingChars;
			//this.createNewInstance();  
		}
		
		/// <summary> Parses the given String, which must contain a single traditionally encoded 
		/// message segment, into the current repetition of the message Group  
		/// underlying this Pointer by forwarding it to each of it's children until 
		/// one of them succeeds.    
		/// </summary>
		public override int setSegment(System.String segment, bool orderedCorrectly)
		{
			if (this.currentGroup == null)
				createNewInstance(); //make first instance of the group
			int status = tryToFillChildren(segment, orderedCorrectly);
			if ((status == NuGenPointer.FILL_FAILED_FULL || status == NuGenPointer.FILL_FAILED_OUT_OF_ORDER) && this.repeating && orderedCorrectly)
			{
				createNewInstance();
				status = tryToFillChildren(segment, orderedCorrectly);
			}
			return status;
		}
		
		private int tryToFillChildren(System.String segment, bool orderedCorrectlyInParent)
		{
			int status = NuGenPointer.FILL_FAILED_WRONG_SEGMENT;
			int c = 0;
			bool fullOneExists = false;
			bool rightSegmentWrongOrder = false;
			
			//loop through children ... 
			//note: can't just stop if FILL_FAILED_FULL b/c have to check all nesting levels 
			while (status != NuGenPointer.FILL_OK && c < this.children.Length)
			{
				bool orderedCorrectly = orderedCorrectlyInParent;
				if (c < childAtWhichToStart)
					orderedCorrectly = false;
				
				status = children[c++].setSegment(segment, orderedCorrectly);
				if (status == NuGenPointer.FILL_FAILED_FULL)
					fullOneExists = true;
				if (status == NuGenPointer.FILL_FAILED_OUT_OF_ORDER)
					rightSegmentWrongOrder = true;
			}
			
			//note: but if there was a FILL_FAILED_FULL at any point, can't return FILL_FAILED_WRONG_SEGMENT
			if (fullOneExists && status == NuGenPointer.FILL_FAILED_WRONG_SEGMENT)
				status = NuGenPointer.FILL_FAILED_FULL;
			if (rightSegmentWrongOrder && status == NuGenPointer.FILL_FAILED_WRONG_SEGMENT)
				status = NuGenPointer.FILL_FAILED_OUT_OF_ORDER;
			
			//if filled, update start location so that subsequent segments can't be 
			//parsed into locations prior to this one 
			if (status == NuGenPointer.FILL_OK)
				childAtWhichToStart = c - 1;
			
			return status;
		}
		
		/// <summary> Creates a new, empty repetition of the underlying Group and sets up 
		/// Pointers to it's components.  
		/// </summary>
		/// <thows>  HL7Exception if there is already 1 rep and group is non-repeating </thows>
		private void  createNewInstance()
		{
			//find next rep # ... 
			int nextRepNum = parent.getAll(this.name).Length;
			
			this.currentGroup = (Group) parent.get_Renamed(this.name, nextRepNum);
			this.childAtWhichToStart = 0;
			
			//set up pointers for children ... 
			System.String[] childNames = currentGroup.Names;
			this.children = new NuGenPointer[childNames.Length];
			for (int i = 0; i < childNames.Length; i++)
			{
				NuGenPointer p;
				//make new SegmentPointer or GroupPointer depending on whether child is a Group ... 
				System.Type childClass = currentGroup.getClass(childNames[i]);
				if (typeof(Group).IsAssignableFrom(childClass))
				{
					p = new NuGenGroupPointer(this.parser, currentGroup, i, this.encodingChars);
				}
				else
				{
					p = new NuGenSegmentPointer(this.parser, currentGroup, i, encodingChars);
				}
				
				this.children[i] = p;
			}
		}
	}
}