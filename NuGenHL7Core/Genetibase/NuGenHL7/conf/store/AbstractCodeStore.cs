using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;


namespace Genetibase.NuGenHL7.conf.store
{
	
	/// <summary> Created on 27-Aug-2003</summary>
	/// <author>  Neal Acharya
	/// Abstract class for used retreiving and validating codes from user defined and HL7 specific tables
	/// that correspond to a conformance profile.
	/// </author>
	public abstract class AbstractCodeStore : CodeStore
	{
		
		/// <param name="codeSystem">
		/// </param>
		/// <param name="code">
		/// </param>
		/// <returns> boolean
		/// </returns>
		/// <seealso cref="Genetibase.NuGenHL7.conf.store.CodeStore.isValidCode(java.lang.String, java.lang.String, java.lang.String)">
		/// 
		/// Validates the input code value against the input conformance profile and corresponding input
		/// codeSystem. Returns true if the code is valid and false if it isn't.
		/// </seealso>
		public virtual bool isValidCode(System.String codeSystem, System.String code)
		{
			try
			{
				System.String[] validCodes = getValidCodes(codeSystem);
				bool found = false;
				for (int i = 0; i < validCodes.Length && !found; i++)
				{
					if (checkCode(code, validCodes[i]))
					{
						found = true;
					} //end if
				} //end for
				return found;
			}
			//end try
			catch (System.Exception)
			{
				return false;
			} //end catch
		} //end method
		
		/// <summary> Checks a code for an exact match, and using certain sequences where some 
		/// characters are wildcards (e.g. HL7nnnn).  If the pattern contains one of 
		/// " or ", " OR ", or "," each operand is checked.
		/// </summary>
		private bool checkCode(System.String code, System.String pattern)
		{
			bool match = false;
			//mod by Neal acharya - Do full match on with the pattern.  If code matches pattern then return true
			//else parse pattern to look for wildcard characters
			if (code.Equals(pattern))
			{
				match = true;
			}
			//end if 
			else
			{
				if (pattern.IndexOf(' ') >= 0 || pattern.IndexOf(',') >= 0)
				{
					SupportClass.Tokenizer tok = new SupportClass.Tokenizer(pattern, ", ", false);
					while (tok.HasMoreTokens() && !match)
					{
						System.String t = tok.NextToken();
						if (!t.ToUpper().Equals("or".ToUpper()))
							match = checkCode(code, t);
					} //end while
				}
				//end if
				else
				{
					if (code.Equals(pattern))
					{
						match = true;
					}
				} //end else
			} //end else 
			return match;
		} //end method
		
		public abstract System.String[] getValidCodes(System.String param1);
		public abstract bool knowsCodes(System.String param1);
		static AbstractCodeStore()
		{
		}
	} //end class
}