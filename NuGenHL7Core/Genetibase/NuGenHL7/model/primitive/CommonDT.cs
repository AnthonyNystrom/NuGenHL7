/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "CommonDT.java".  Description:
/// "Note: The class description below has been excerpted from the Hl7 2.4 documentation"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
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
/// 
/// </summary>
using System;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
using DataTypeUtil = Genetibase.NuGenHL7.model.DataTypeUtil;
namespace Genetibase.NuGenHL7.model.primitive
{
	
	/// <summary> This class contains functionality used by the DT class
	/// in the version 2.3.0, 2.3.1, and 2.4 packages
	/// 
	/// Note: The class description below has been excerpted from the Hl7 2.4 documentation. Sectional
	/// references made below also refer to the same documentation.
	/// 
	/// Format: YYYY[MM[DD]]
	/// In prior versions of HL7, this data type was always specified to be in the format YYYYMMDD. In the current and future
	/// versions, the precision of a date may be expressed by limiting the number of digits used with the format specification
	/// YYYY[MM[DD]]. Thus, YYYY is used to specify a precision of "year," YYYYMM specifies a precision of "month,"
	/// and YYYYMMDD specifies a precision of "day."
	/// By site-specific agreement, YYYYMMDD may be used where backward compatibility must be maintained.
	/// Examples:   |19880704|  |199503|
	/// </summary>
	/// <author>  Neal Acharya
	/// </author>
	
	public class CommonDT
	{
		virtual public System.String Value
		{
			get
			{
				return value_Renamed;
			}
			//end method
			
			set
			{
				
				if (value != null && !value.Equals("") && !value.Equals("\"\""))
				{
					try
					{
						System.Globalization.GregorianCalendar cal = new System.Globalization.GregorianCalendar();
						SupportClass.CalendarManager.manager.Clear(cal);

						//check the length, must be either four, six, or eight digits
						if ((value.Length != 4) && (value.Length != 6) && (value.Length != 8))
						{
							System.String msg = "The length of the DT datatype value does not conform to an allowable" + " format. Format should conform to YYYY[MM[DD]]";
							DataTypeException e = new DataTypeException(msg);
							throw e;
						}
						
						if (value.Length >= 4)
						{
							//extract the year from the input value
							int yrInt = System.Int32.Parse(value.Substring(0, (4) - (0)));
							//check to see if the year is valid by creating a Gregorian calendar object with
							//this value.  If an error occurs then processing will stop in this try block
							SupportClass.CalendarManager.manager.Set(cal, yrInt, 0, 1);
							SupportClass.CalendarManager.manager.GetDateTime(cal); //for error detection
							year = yrInt;
						}
						
						if (value.Length >= 6)
						{
							//extract the month from the input value
							int mnthInt = System.Int32.Parse(value.Substring(4, (6) - (4)));
							//check to see if the month is valid by creating a Gregorian calendar object with
							//this value.  If an error occurs then processing will stop in this try block
							SupportClass.CalendarManager.manager.Set(cal, year, mnthInt - 1, 1);
							SupportClass.CalendarManager.manager.GetDateTime(cal); //for error detection
							month = mnthInt;
						}
						
						if (value.Length == 8)
						{
							//extract the day from the input value
							int dayInt = System.Int32.Parse(value.Substring(6, (8) - (6)));
							//check to see if the day is valid by creating a Gregorian calendar object with
							//the year/month/day combination.  If an error occurs then processing will stop
							// in this try block
							SupportClass.CalendarManager.manager.Set(cal, year, month - 1, dayInt);
							SupportClass.CalendarManager.manager.GetDateTime(cal); //for error detection
							day = dayInt;
						}
						//validations are complete now store the input value into the private value field
						value_Renamed = value;
					}
					//end try
					catch (DataTypeException e)
					{
						throw e;
					}
					//end catch
					catch (System.Exception e)
					{
						throw new DataTypeException(e);
					} //end catch
				}
				//end if
				else
				{
					//set the private value field to null or empty space.
					value_Renamed = value;
				} //end else       
			}
			//end method
			
		}
		/// <summary> This method takes in an integer value for the year and performs validations,
		/// it then sets the value field formatted as an HL7 date.
		/// value with year precision (YYYY)
		/// </summary>
		virtual public int YearPrecision
		{
			set
			{
				try
				{
					System.Globalization.GregorianCalendar cal = new System.Globalization.GregorianCalendar();
					SupportClass.CalendarManager.manager.Clear(cal);
					
					//ensure that the year field is four digits long
					if (System.Convert.ToString(value).Length != 4)
					{
						System.String msg = "The input year value must be four digits long";
						DataTypeException e = new DataTypeException(msg);
						throw e;
					}
					//check is input year is valid
					//GregorianCalendar cal = new GregorianCalendar(yr,0,1);
					SupportClass.CalendarManager.manager.Set(cal, value, 0, 1);
					SupportClass.CalendarManager.manager.GetDateTime(cal); //for error detection
					year = value;
					month = 0;
					day = 0;
					value_Renamed = System.Convert.ToString(value);
				}
				//end try
				catch (DataTypeException e)
				{
					throw e;
				}
				//end catch
				catch (System.Exception e)
				{
					throw new DataTypeException(e);
				} //end catch
			}
			//end method
			
		}
		/// <summary> Returns the year as an integer.</summary>
		virtual public int Year
		{
			get
			{
				return year;
			}
			//end method
			
		}
		/// <summary> Returns the month as an integer.</summary>
		virtual public int Month
		{
			get
			{
				return month;
			}
			//end method
			
		}
		/// <summary> Returns the day as an integer.</summary>
		virtual public int Day
		{
			get
			{
				return day;
			}
			//end method
			
		}
		
		private System.String value_Renamed;
		private int year;
		private int month;
		private int day;
		
		/// <summary> Constructs a DT datatype with fields initialzed to zero and value initialized
		/// to null.
		/// </summary>
		public CommonDT()
		{
			//initialize all DT fields
			value_Renamed = null;
			year = 0;
			month = 0;
			day = 0;
		} //end constructor
		
		/// <summary> Constructs a DT object with the given value.
		/// The stored value will be in the following
		/// format YYYY[MM[DD]].
		/// </summary>
		public CommonDT(System.String val)
		{
			this.Value = val;
		} //end constructor
		
		/// <summary> This method takes in integer values for the year and month and performs validations,
		/// it then sets the value field formatted as an HL7 date
		/// value with year&month precision (YYYYMM).
		/// Note: The first month = 1 = January.
		/// </summary>
		public virtual void  setYearMonthPrecision(int yr, int mnth)
		{
			try
			{
				System.Globalization.GregorianCalendar cal = new System.Globalization.GregorianCalendar();
				SupportClass.CalendarManager.manager.Clear(cal);

				//ensure that the year field is four digits long
				if (System.Convert.ToString(yr).Length != 4)
				{
					System.String msg = "The input year value must be four digits long";
					DataTypeException e = new DataTypeException(msg);
					throw e;
				}
				//validate the input month
				//GregorianCalendar cal = new GregorianCalendar(yr,(mnth-1),1);
				SupportClass.CalendarManager.manager.Set(cal, yr, (mnth - 1), 1);
				SupportClass.CalendarManager.manager.GetDateTime(cal); //for error detection
				year = yr;
				month = mnth;
				day = 0;
				value_Renamed = System.Convert.ToString(yr) + DataTypeUtil.preAppendZeroes(mnth, 2);
			}
			catch (DataTypeException e)
			{
				throw e;
			}
			//end catch
			catch (System.Exception e)
			{
				throw new DataTypeException(e);
			} //end catch
		} //end method
		
		/// <summary> This method takes in integer values for the year and month and day
		/// and performs validations, it then sets the value in the object
		/// formatted as an HL7 date value with year&month&day precision (YYYYMMDD).
		/// </summary>
		public virtual void  setYearMonthDayPrecision(int yr, int mnth, int dy)
		{
			try
			{
				System.Globalization.GregorianCalendar cal = new System.Globalization.GregorianCalendar();
				SupportClass.CalendarManager.manager.Clear(cal);
				
				//ensure that the year field is four digits long
				if (System.Convert.ToString(yr).Length != 4)
				{
					System.String msg = "The input year value must be four digits long";
					DataTypeException e = new DataTypeException(msg);
					throw e;
				}
				//validate the input month/day combination
				SupportClass.CalendarManager.manager.Set(cal, yr, (mnth - 1), dy);
				SupportClass.CalendarManager.manager.GetDateTime(cal); //for error detection
				year = yr;
				month = mnth;
				day = dy;
				value_Renamed = System.Convert.ToString(yr) + DataTypeUtil.preAppendZeroes(mnth, 2) + DataTypeUtil.preAppendZeroes(dy, 2);
			}
			catch (DataTypeException e)
			{
				throw e;
			}
			//end catch
			catch (System.Exception e)
			{
				throw new DataTypeException(e);
			} //end catch
		} //end method
		
		/// <summary> Returns a string value representing the input Gregorian Calendar object in
		/// an Hl7 Date Format.
		/// </summary>
		public static System.String toHl7DTFormat(System.Globalization.GregorianCalendar cal)
		{
			System.String val = "";
			try
			{
				//set the input cal object so that it can report errors
				//on it's value

				int calYear = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.YEAR);
				int calMonth = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.MONTH) + 1;
				int calDay = SupportClass.CalendarManager.manager.Get(cal, SupportClass.CalendarManager.DAY_OF_MONTH);
				CommonDT dt = new CommonDT();
				dt.setYearMonthDayPrecision(calYear, calMonth, calDay);
				val = dt.Value;
			}
			//end try
			catch (DataTypeException e)
			{
				throw e;
			}
			//end catch
			catch (System.Exception e)
			{
				throw new DataTypeException(e);
			} //end catch
			return val;
		} //end method
		static CommonDT()
		{
		}
	} //end class
}