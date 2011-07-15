/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "TSComponentOne.java".  Description:
/// "Represents an HL7 timestamp, which is related to the HL7 TS type."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2005.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
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
using AbstractPrimitive = Genetibase.NuGenHL7.model.AbstractPrimitive;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using Message = Genetibase.NuGenHL7.model.Message;
namespace Genetibase.NuGenHL7.model.primitive
{
	
	/// <summary> Represents an HL7 timestamp, which is related to the HL7 TS type.  In version 2.5, 
	/// TS is a composite type.  The first component is type DTM, which corresponds to this class
	/// (actually model.v25.datatype.DTM inherits from this class at time of writing).  In HL7 versions 
	/// 2.2-2.4, it wasn't perfectly clear whether TS was composite or primitive.  HAPI interprets  
	/// it as composite, with the first component having a type that isn't defined by HL7, and we call 
	/// this type TSComponentOne.  In v2.1, TS is primitive, and corresponds one-to-one with this class.   
	/// 
	/// </summary>
	/// <author>  <a href="mailto:neal.acharya@uhn.on.ca">Neal Acharya</a>
	/// </author>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2005/06/14 20:09:39 $ by $Author: bryan_tripp $
	/// </version>
	[Serializable]
	public abstract class TSComponentOne:AbstractPrimitive
	{
		private CommonTS Detail
		{
			get
			{
				if (myDetail == null)
				{
					myDetail = new CommonTS(Value);
				}
				return myDetail;
			}
			
		}
		/// <seealso cref="AbstractPrimitive.getValue">
		/// </seealso>
		/// <seealso cref="AbstractPrimitive.setValue(java.lang.String)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted and either validation is  </throws>
		/// <summary>      enabled for this primitive or detail setters / getters have been called, forcing further
		/// parsing.   
		/// </summary>
		override public System.String Value
		{
			get
			{
				System.String result = base.Value;
				
				if (myDetail != null)
				{
					result = myDetail.Value;
				}
				
				return result;
			}
			
			set
			{
				base.Value = value;
				
				if (myDetail != null)
				{
					myDetail.Value = value;
				}
			}
			
		}
		/// <seealso cref="CommonTS.setOffset(int)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Offset
		{
			set
			{
				Detail.Offset = value;
			}
			
		}
		/// <summary> Returns the year as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Year
		{
			get
			{
				return Detail.Year;
			}
			
		}
		/// <summary> Returns the month as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Month
		{
			get
			{
				return Detail.Month;
			}
			
		}
		/// <summary> Returns the day as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Day
		{
			get
			{
				return Detail.Day;
			}
			
		}
		/// <summary> Returns the hour as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Hour
		{
			get
			{
				return Detail.Hour;
			}
			
		}
		/// <summary> Returns the minute as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Minute
		{
			get
			{
				return Detail.Minute;
			}
			
		}
		/// <summary> Returns the second as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int Second
		{
			get
			{
				return Detail.Second;
			}
			
		}
		/// <summary> Returns the fractional second value as a float.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public float FractSecond
		{
			get
			{
				return Detail.FractSecond;
			}
			
		}
		/// <summary> Returns the GMT offset value as an integer.</summary>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		virtual public int GMTOffset
		{
			get
			{
				return Detail.GMTOffset;
			}
			
			/// <summary>Returns the name of the type (used in XML encoding and profile checking)  </summary>
			//    public String getName() {
			//        return "NM"; //seems to be called an NM in XML representation prior to 2.5  
			//    }
			
		}
		
		private CommonTS myDetail;
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		public TSComponentOne(Message theMessage):base(theMessage)
		{
		}
		
		/// <seealso cref="CommonTS.setDatePrecision(int, int, int)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		public virtual void  setDatePrecision(int yr, int mnth, int dy)
		{
			Detail.setDatePrecision(yr, mnth, dy);
		}
		
		/// <seealso cref="CommonTS.setDateMinutePrecision(int, int, int, int, int)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		public virtual void  setDateMinutePrecision(int yr, int mnth, int dy, int hr, int min)
		{
			Detail.setDateMinutePrecision(yr, mnth, dy, hr, min);
		}
		
		/// <seealso cref="CommonTS.setDateSecondPrecision(int, int, int, int, int, float)">
		/// </seealso>
		/// <throws>  DataTypeException if the value is incorrectly formatted.  If validation is enabled, this  </throws>
		/// <summary>      exception should be thrown at setValue(), but if not, detailed parsing may be deferred until 
		/// this method is called.  
		/// </summary>
		public virtual void  setDateSecondPrecision(int yr, int mnth, int dy, int hr, int min, float sec)
		{
			Detail.setDateSecondPrecision(yr, mnth, dy, hr, min, sec);
		}
	}
}