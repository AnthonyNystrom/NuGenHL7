using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> <p>Implements CodeMapper using files to store code values.  Files are arranged
	/// in the following directory structure.  The base directory is called "codemap".
	/// This should be created under the hapi.home directory (see Home class; defaults to .).
	/// Under the base directory, there should be one directory for each interface, and
	/// each of these directories should be named after the interface.  For example if you
	/// had interfaces to pharmacy and lab systems you might have the following directories:</p>
	/// <p> <hapi.home>/codemap/pharmacy<br>
	/// <hapi.home>/codemap/lab</p>
	/// <p>Each directory should contain two files per HL7 table, named after the table numbers as
	/// follows: "hl7nnnn.li" and "hl7nnnn.il", where nnnn is the 4 digit table number.  The .il
	/// file contains maps from interface codes to local codes, and the .li file contains maps from
	/// local codes to interface codes (these unfortunately may not be symmetrical).</p>
	/// <p>Each line of a file contains a single code map, with the "from" value and the "to" value
	/// separated by a tab.  For example, the file <hapi.home>/lab/HL70001.li (to map local codes to interface
	/// codes for the HL7 admnistrative sex table in your lab system interface) might contain the
	/// following line: </p>
	/// <p>male&tab;M</p>
	/// <p>This means that the local code "male" maps to the interface code "M".</p>
	/// <p>Lines that start with "//" are treated as comments.</p>
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenFileCodeMapper:NuGenCodeMapper
	{
		private bool throwIfNoMatch = false;
		internal System.IO.FileInfo baseDir;
		private System.Collections.Hashtable interfaceToLocal;
		private System.Collections.Hashtable localToInterface;
		
		/// <summary> Creates a new instance of FileCodeMapper.  You should probably not
		/// construct a FileCodeMapper directly.  Use CodeMapper.getInstance()
		/// instead ... this will ensure that only a single instance is created,
		/// which is important for performance because code maps are loaded from
		/// disk every time this constructor is called.
		/// </summary>
		public NuGenFileCodeMapper()
		{
			baseDir = new System.IO.FileInfo(NuGenHome.getHomeDirectory().FullName + "/codemap");
			refreshCache();
		}
		
		/// <summary> If values are cached in such a way that they are not guaranteed to be current, a call
		/// to this method refreshes the values.
		/// </summary>
		public override void  refreshCache()
		{
			localToInterface = new System.Collections.Hashtable(10);
			interfaceToLocal = new System.Collections.Hashtable(10);
			
			
			try
			{
                System.IO.DirectoryInfo[] interfaceDirs = baseDir.Directory.GetDirectories("hl7*.il*|hl7*.li*");
				
				//loop through directories and set up maps
				for (int i = 0; i < interfaceDirs.Length; i++)
				{
					

                    System.IO.DirectoryInfo[] mapFiles = interfaceDirs[i].GetDirectories("hl7*.il*|hl7*.li*");
					
					System.Collections.Hashtable li = new System.Collections.Hashtable(50);
					System.Collections.Hashtable il = new System.Collections.Hashtable(50);
					for (int j = 0; j < mapFiles.Length; j++)
					{
						
						System.String fName = mapFiles[j].Name;
						System.String tableName = fName.Substring(0, (fName.LastIndexOf('.')) - (0));
						System.String mapDirection = fName.Substring(fName.LastIndexOf('.') + 1);
						
						//read values and store in HashMap
						System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(mapFiles[j].FullName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(mapFiles[j].FullName, System.Text.Encoding.Default).CurrentEncoding);
						System.Collections.Hashtable codeMap = new System.Collections.Hashtable(25);
						while (in_Renamed.Peek() != -1)
						{
							System.String line = in_Renamed.ReadLine();
							if (!line.StartsWith("//"))
							{
								SupportClass.Tokenizer tok = new SupportClass.Tokenizer(line, "\t", false);
								System.String from = null;
								System.String to = null;
								if (tok.HasMoreTokens())
									from = tok.NextToken();
								if (tok.HasMoreTokens())
									to = tok.NextToken();
								if (from != null && to != null)
									codeMap[from] = to;
							}
						}
						
						//add to appropriate map for this interface
						if (mapDirection.Equals("il"))
						{
							il[tableName.ToUpper()] = codeMap;
						}
						else
						{
							li[tableName.ToUpper()] = codeMap;
						}
					}
					
					//add maps for this interface (this directory) to global list
					interfaceToLocal[interfaceDirs[i].Name] = il;
					localToInterface[interfaceDirs[i].Name] = li;
				}
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenHL7Exception("Can't read interface code maps from disk", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
			}
		}
		
		/// <summary> Returns the local code for the given interface code as it appears in
		/// the given interface.
		/// </summary>
		public override System.String getLocalCode(System.String interfaceName, int hl7Table, System.String interfaceCode)
		{
			System.String localCode = null;
			try
			{
				System.Collections.Hashtable interfaceMap = (System.Collections.Hashtable) interfaceToLocal[interfaceName];
				localCode = getCode(interfaceMap, hl7Table, interfaceCode);
			}
			catch (System.NullReferenceException)
			{
				if (this.throwIfNoMatch)
					throw new NuGenHL7Exception("No local mapping for the interface code " + interfaceCode + " for HL7 table " + hl7Table + " for the interface '" + interfaceName + "'", NuGenHL7Exception.TABLE_VALUE_NOT_FOUND);
			}
			return localCode;
		}
		
		/// <summary> Common code for getLocalcode and getInterfaceCode</summary>
		private System.String getCode(System.Collections.Hashtable interfaceMap, int hl7Table, System.String code)
		{
			System.String ret = null;
			
			//get map for the given table
			System.Text.StringBuilder tableName = new System.Text.StringBuilder();
			tableName.Append("HL7");
			if (hl7Table < 1000)
				tableName.Append("0");
			if (hl7Table < 100)
				tableName.Append("0");
			if (hl7Table < 10)
				tableName.Append("0");
			tableName.Append(hl7Table);
			System.Collections.Hashtable tableMap = (System.Collections.Hashtable) interfaceMap[tableName.ToString()];
			
			//get code
			ret = tableMap[code].ToString();
			return ret;
		}
		
		/// <summary> Returns the interface code for the given local code, for use in the context
		/// of the given interface.
		/// </summary>
		public override System.String getInterfaceCode(System.String interfaceName, int hl7Table, System.String localCode)
		{
			System.String interfaceCode = null;
			try
			{
				System.Collections.Hashtable interfaceMap = (System.Collections.Hashtable) localToInterface[interfaceName];
				interfaceCode = getCode(interfaceMap, hl7Table, localCode);
			}
			catch (System.NullReferenceException)
			{
				if (this.throwIfNoMatch)
					throw new NuGenHL7Exception("No interface mapping for the local code " + localCode + " for HL7 table " + hl7Table + " for the interface '" + interfaceName + "'", NuGenHL7Exception.TABLE_VALUE_NOT_FOUND);
			}
			return interfaceCode;
		}
		
		/// <summary> Determines what happens if no matching code is found during a lookup.  If set to true,
		/// an HL7Exception is thrown if there is no match.  If false, null is returned.  The default
		/// is false.
		/// </summary>
		public override void  throwExceptionIfNoMatch(bool throwException)
		{
			this.throwIfNoMatch = throwException;
		}
		
		/// <summary> Test harness.</summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			try
			{
				//FileCodeMapper mapper = new FileCodeMapper();
				NuGenCodeMapper.Instance.throwExceptionIfNoMatch(true);
				System.Console.Out.WriteLine("Local code for M is " + NuGenCodeMapper.getLocal("test", 1, "M"));
				System.Console.Out.WriteLine("Interface code for female is " + NuGenCodeMapper.getInt("test", 1, "female"));
			}
			catch (NuGenHL7Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static NuGenFileCodeMapper()
		{
		}
	}
}