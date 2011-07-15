using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
namespace Genetibase.NuGenHL7.conf.store
{
	
	/// <summary> Created on 27-Aug-2003</summary>
	/// <author>  Neal Acharya
	/// Interface used retreiving and validating codes from user defined and HL7 specific tables
	/// that correspond to a conformance profile.
	/// </author>
	public interface CodeStore
	{
		
		/// <param name="codeSystem">a table of codes (for example, HL70001 for administrative sex)
		/// valid tables are defined in the HL7 table 0396
		/// </param>
		/// <returns> a list of valid codes 
		/// </returns>
		/// <throws>  ProfileException </throws>
		/// <summary> 
		/// Retreives all codes for a given conformance profile and codeSystem.
		/// </summary>
		System.String[] getValidCodes(System.String codeSystem);
		
		/// <param name="codeSystem">
		/// </param>
		/// <returns> boolean
		/// boolean
		/// 
		/// Validates the codeSystem against the input conformance profile. If valid then
		/// output is 'true' else 'false'.
		/// </returns>
		bool knowsCodes(System.String codeSystem);
		
		/// <param name="codeSystem">
		/// </param>
		/// <param name="code">
		/// </param>
		/// <returns> boolean
		/// boolean
		/// 
		/// Validates the input code value against the input conformance profile and corresponding input
		/// codeSystem. Returns true if the code is valid and false if it isn't.
		/// </returns>
		bool isValidCode(System.String codeSystem, System.String code);
	} //end interface
}