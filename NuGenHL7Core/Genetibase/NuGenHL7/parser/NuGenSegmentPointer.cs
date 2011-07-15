/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "SegmentPointer.java".  Description: 
/// "A SegmentPointer is used when parsing traditionally encoded HL7 messages" 
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

/*
* Created on October 15, 2001, 3:19 PM
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Group = Genetibase.NuGenHL7.model.Group;
using Segment = Genetibase.NuGenHL7.model.Segment;
namespace Genetibase.NuGenHL7.parser
{
	
	/// <summary> A SegmentPointer is used when parsing traditionally encoded HL7 messages. 
	/// It acts as a placeholder for a unique segment "slot" in a message structure. 
	/// There is one SegmentPointer per unique segment path (even if the segment 
	/// repeats, and regardless of whether any instances exist).  
	/// 
	/// </summary>
	/// <deprecated> PipeParser now uses MessageIterator
	/// </deprecated>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public class NuGenSegmentPointer:NuGenPointer
	{
		private NuGenPipeParser parser;
		new private Group parent;
		private System.String name;
		new private NuGenEncodingCharacters encodingChars;
		new private bool repeating;
		private Segment currSegment = null;
		private bool currSegmentFull = true;
		
		/// <summary> Creates new SegmentPointer </summary>
		/// <param name="parser">the PipeParser used to parse segments 
		/// </param>
		/// <param name="parent">the Group object that would be the parent of any instances of the 
		/// Segment underlying this SegmentPointer
		/// </param>
		/// <param name="position">the position (among siblings; from 0) of the underlying Segment 
		/// </param>
		/// <param name="encodingChars">array of encoding characters, starting w/ field delim
		/// </param>
		public NuGenSegmentPointer(NuGenPipeParser parser, Group parent, int position, NuGenEncodingCharacters encodingChars)
		{
			this.parser = parser;
			this.parent = parent;
			this.encodingChars = encodingChars;
			this.name = parent.Names[position];
			this.repeating = parent.isRepeating(this.name);
		}
		
		/// <summary> Parses the given String, which must contain a single traditionally encoded 
		/// message segment, into the current repetition of the message Structure 
		/// underlying this Pointer.  See Pointer static fields for return values. 
		/// </summary>
		/// <throws>  HL7Exception if there is an error during parsing  </throws>
		public override int setSegment(System.String segment, bool correctOrder)
		{
			int status = NuGenPointer.FILL_FAILED_WRONG_SEGMENT;
			
			//make sure segment is right kind
			if (segment.Substring(0, (3) - (0)).Equals(this.name))
			{
				if (correctOrder)
				{
					//make sure empty rep exists
					if (prepEmptyInstance())
					{
						try
						{
							this.parser.parse(this.currSegment, segment, this.encodingChars);
						}
						catch (NuGenHL7Exception e)
						{
							//add segment name info and re-throw
							e.SegmentName = this.name;
							throw e;
						}
						this.currSegmentFull = true;
						status = NuGenPointer.FILL_OK;
					}
					else
					{
						status = NuGenPointer.FILL_FAILED_FULL;
					}
				}
				else
				{
					status = NuGenPointer.FILL_FAILED_OUT_OF_ORDER;
				}
			}
			return status;
		}
		
		/// <summary> Ensures that there is an empty repetition of the underlying message Structure.  </summary>
		/// <returns>s true if successful, false if structure is non-repeating and full. 
		/// </returns>
		private bool prepEmptyInstance()
		{
			bool success = false;
			
			if (this.currSegment == null || (this.repeating && this.currSegmentFull))
			{
				int numExisting = parent.getAll(this.name).Length;
				this.currSegment = (Segment) parent.get_Renamed(this.name, numExisting); //get next rep            
				this.currSegmentFull = false;
				success = true;
			}
			else if (!this.currSegmentFull)
			{
				success = true;
			}
			
			return success;
		}
		static NuGenSegmentPointer()
		{
		}
	}
}