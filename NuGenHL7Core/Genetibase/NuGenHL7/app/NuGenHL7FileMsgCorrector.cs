/*
* Created on Apr 14, 2005
* HL7FileMsgCorrector.java
* 
*/
using System;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> This is an application that will perform specific translations on the
	/// hl7 messages stored within a flat file.  It will output the new messages to 
	/// "./correctedMessageFile.txt"  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:neal.acharya@uhn.on.ca">Neal Acharya</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2005/12/01 19:58:03 $ by $Author: nacharya $
	/// </version>
	public class NuGenHL7FileMsgCorrector
	{
		
		/// <summary> </summary>
		public NuGenHL7FileMsgCorrector():base()
		{
		}
		
		/// <param name="theFileString">..
		/// </param>
		/// <returns> ...
		/// Adds two carriage returns before each MSH segment
		/// we expect the file to be used by the HL7ServerTestHelper         
		/// </returns>
		private static System.String addPreMshCarriageReturns(System.String theFileString)
		{
            theFileString = Regex.Replace(theFileString, ".MSH\\|", "\rMSH|");
            theFileString = Regex.Replace(theFileString, "MSH\\|", "\rMSH|");
            theFileString = Regex.Replace(theFileString, "//", "");
			return theFileString;
		}
	}
}