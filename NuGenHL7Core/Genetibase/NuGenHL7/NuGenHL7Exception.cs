/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "HL7Exception.java".  Description: 
/// "Represents an exception encountered while processing 
/// an HL7 message" 
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

using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
using Segment = Genetibase.NuGenHL7.model.Segment;
namespace Genetibase.NuGenHL7
{
	
	/// <summary> Represents an exception encountered while processing 
	/// an HL7 message.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	[Serializable]
	public class NuGenHL7Exception:System.Exception
	{
		/// <summary> Returns the name of the segment where the error occured, if this has been set
		/// (null otherwise).
		/// </summary>
		virtual public System.String SegmentName
		{
			get
			{
				return this.segment;
			}
			
			set
			{
				this.segment = value;
			}
			
		}
		/// <summary> Modifies the sequence number of the segment where the error occured if there 
		/// are multiplt segments with the same name (ie the sequenceNum'th segment 
		/// with the name specified in <code>setSegmentName</code>).  Numbering 
		/// starts at 1.
		/// </summary>
		virtual public int SegmentRepetition
		{
			get
			{
				return this.segmentRep;
			}
			
			set
			{
				this.segmentRep = value;
			}
			
		}
		/// <summary> Modifies the field number (within a segment) where the error occured; numbering 
		/// starts at 1. 
		/// </summary>
		virtual public int FieldPosition
		{
			get
			{
				return this.fieldPosition;
			}
			
			set
			{
				this.fieldPosition = value;
			}
			
		}
		/// <summary> Overrides Throwable.getMessage() to add the field location of the problem if 
		/// available.
		/// </summary>
		public override System.String Message
		{
			get
			{
				System.Text.StringBuilder msg = new System.Text.StringBuilder();
				msg.Append(base.Message);
				if (SegmentName != null)
				{
					msg.Append(": Segment: ");
					msg.Append(SegmentName);
				}
				if (SegmentRepetition != - 1)
				{
					msg.Append(" (rep ");
					msg.Append(SegmentRepetition);
					msg.Append(")");
				}
				if (FieldPosition != - 1)
				{
					msg.Append(" Field #");
					msg.Append(FieldPosition);
				}
				return msg.ToString();
			}
			
		}
		
		public const int ACK_AA = 1;
		public const int ACK_AE = 2;
		public const int ACK_AR = 3;
		
		public const int MESSAGE_ACCEPTED = 0;
		public const int SEGMENT_SEQUENCE_ERROR = 100;
		public const int REQUIRED_FIELD_MISSING = 101;
		public const int DATA_TYPE_ERROR = 102;
		public const int TABLE_VALUE_NOT_FOUND = 103;
		public const int UNSUPPORTED_MESSAGE_TYPE = 200;
		public const int UNSUPPORTED_EVENT_CODE = 201;
		public const int UNSUPPORTED_PROCESSING_ID = 202;
		public const int UNSUPPORTED_VERSION_ID = 203;
		public const int UNKNOWN_KEY_IDENTIFIER = 204;
		public const int DUPLICATE_KEY_IDENTIFIER = 205;
		public const int APPLICATION_RECORD_LOCKED = 206;
		public const int APPLICATION_INTERNAL_ERROR = 207;
		
		private System.String segment = null;
		private int segmentRep = - 1;
		private int fieldPosition = - 1;
		private int errCode = - 1;
		
		/// <summary> Creates an HL7Exception.
		/// 
		/// </summary>
		/// <param name="errorCondition">a code describing the the error condition, from HL7
		/// table 0357 (see section 2.16.8 of standard v 2.4) - HL7Exception defines 
		/// these codes as integer constants that can be used here (e.g. 
		/// HL7Exception.UNSUPPORTED_MESSAGE_TYPE)
		/// 
		/// </param>
		/// <param name="cause">The excption that caused this exception tobe thrown.
		/// </param>
		public NuGenHL7Exception(System.String message, int errorCondition, System.Exception cause):base(message, cause)
		{
			this.errCode = errorCondition;
		}
		
		/// <summary> Creates an HL7Exception.
		/// 
		/// </summary>
		/// <param name="errorCondition">a code describing the the error condition, from HL7
		/// table 0357 (see section 2.16.8 of standard v 2.4) - HL7Exception defines 
		/// these codes as integer constants that can be used here (e.g. 
		/// HL7Exception.UNSUPPORTED_MESSAGE_TYPE)
		/// </param>
		public NuGenHL7Exception(System.String message, int errorCondition):base(message)
		{
			this.errCode = errorCondition;
		}
		
		/// <summary> Creates an HL7Exception with the code APPLICATION_INTERNAL_ERROR
		/// 
		/// </summary>
		/// <param name="cause">The excption that caused this exception tobe thrown.
		/// </param>
		public NuGenHL7Exception(System.String message, System.Exception cause):base(message, cause)
		{
			this.errCode = NuGenHL7Exception.APPLICATION_INTERNAL_ERROR;
		}
		
		/// <summary> Creates an HL7Exception with the code APPLICATION_INTERNAL_ERROR
		/// 
		/// </summary>
		/// <param name="cause">The excption that caused this exception tobe thrown.
		/// </param>
		public NuGenHL7Exception(System.Exception cause):base(cause.Message, cause)
		{
			this.errCode = NuGenHL7Exception.APPLICATION_INTERNAL_ERROR;
		}
		
		/// <summary> Creates an HL7Exception with the code APPLICATION_INTERNAL_ERROR</summary>
		public NuGenHL7Exception(System.String message):base(message)
		{
			this.errCode = NuGenHL7Exception.APPLICATION_INTERNAL_ERROR;
		}
		
		/// <summary> Populates the given error segment with information from this Exception.</summary>
		public virtual void  populate(Segment errorSegment)
		{
			//make sure it's an ERR
			if (!errorSegment.getName().Equals("ERR"))
				throw new NuGenHL7Exception("Can only populate an ERR segment with an exception -- got: " + errorSegment.GetType().FullName);
			
			int rep = errorSegment.getField(1).Length; //append after existing reps
			
			if (this.SegmentName != null)
				Terser.set_Renamed(errorSegment, 1, rep, 1, 1, this.SegmentName);
			
			if (this.SegmentRepetition >= 0)
				Terser.set_Renamed(errorSegment, 1, rep, 2, 1, System.Convert.ToString(this.SegmentRepetition));
			
			if (this.FieldPosition >= 0)
				Terser.set_Renamed(errorSegment, 1, rep, 3, 1, System.Convert.ToString(this.FieldPosition));
			
			Terser.set_Renamed(errorSegment, 1, rep, 4, 1, System.Convert.ToString(this.errCode));
			Terser.set_Renamed(errorSegment, 1, rep, 4, 3, "hl70357");
			Terser.set_Renamed(errorSegment, 1, rep, 4, 5, this.Message);
			
			//try to get error condition text
			try
			{
				System.String desc = NuGenTableRepository.Instance.getDescription(357, System.Convert.ToString(this.errCode));
				Terser.set_Renamed(errorSegment, 1, rep, 4, 2, desc);
			}
			catch (NuGenLookupException)
			{

			}
		}
		static NuGenHL7Exception()
		{
		}
	}
}