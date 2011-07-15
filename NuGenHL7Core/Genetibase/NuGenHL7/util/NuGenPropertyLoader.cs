using System;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Loads system properties from a file.  This is intended as a convenient way 
	/// of setting multiple system properties. 
	/// </summary>
	public class NuGenPropertyLoader
	{
		private static SupportClass.HashSetSupport files = new SupportClass.HashSetSupport();
		
		private NuGenPropertyLoader()
		{
		}
		
		/// <summary> Calls <code>loadProperties()</code> if it has not been called before for
		/// the given file.  If the given property file has already been loaded, this
		/// method does nothing.
		/// </summary>
		public static void  loadOnce(System.String propertyFileName)
		{
			if (!files.Contains(propertyFileName))
			{
				loadProperties(propertyFileName);
				files.Add(propertyFileName);
			}
		}
		
		/// <summary> Reads given "property file" and sets system properties accordingly.  In the property file,
		/// there should be one property per line.  A line should consist of 1) the fully qualified property name,
		/// 2) one or more tabs, and 3) the value (everything after the first group of tabs and before any subsequent
		/// groups will be considered "the value").
		/// Lines in the file are consdidered comments if they begin with "%".
		/// </summary>
		public static void  loadProperties(System.String propertyFileName)
		{
			
			//open stream from given property file
			System.IO.StreamReader in_Renamed = null;
			in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(propertyFileName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(propertyFileName, System.Text.Encoding.Default).CurrentEncoding);
			
			System.String line, key, value_Renamed, delim = "\t";
			SupportClass.Tokenizer tok;
			while ((line = in_Renamed.ReadLine()) != null)
			{
				//ignore comments
				if (!line.StartsWith("%"))
				{
					key = null; value_Renamed = null;
					
					//get property key and value
					tok = new SupportClass.Tokenizer(line, delim, false);
					if (tok.HasMoreTokens())
						key = tok.NextToken();
					if (tok.HasMoreTokens())
						value_Renamed = tok.NextToken();
				}
			}
			in_Renamed.Close();
		}
		
		static NuGenPropertyLoader()
		{
		}
	}
}