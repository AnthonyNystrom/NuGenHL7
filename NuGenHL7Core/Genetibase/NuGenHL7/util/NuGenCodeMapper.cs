using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> <p>Maps local codes to interface codes and vice versa.  The default implementation
	/// of CodeMapper is FileCodeMapper.  An instance of FileCodeMapper can be obtained  
	/// by calling <code>CodeMapper.getInstance()</code>.  See FileCodeMapper for instructions
	/// on how to set up code map files.  </p>
	/// <p>Please note that this class is not intended for the purpose of enumerating valid codes. 
	/// If that is what you are looking for please see <code>Genetibase.NuGenHL7.TableRepository</code></p>
	/// </summary>
	/// <author>  Bryan Tripp  
	/// </author>
	public abstract class NuGenCodeMapper
	{
		/// <summary> Returns a singleton instance of CodeMapper.  This is currently 
		/// a FileCodeMapper by default.  
		/// </summary>
		public static NuGenCodeMapper Instance
		{
			get
			{
				lock (typeof(Genetibase.NuGenHL7.util.NuGenCodeMapper))
				{
					if (codeMapper == null)
					{
						//create new file code mapper 
						codeMapper = new NuGenFileCodeMapper();
					}
					return codeMapper;
				}
			}
			
		}
		
		private static NuGenCodeMapper codeMapper = null;
		
		/// <summary> A convenience method that returns a local code from an underlying 
		/// CodeMapper instance by calling <code>CodeMapper.getInstance().getLocalCode(...)</code>
		/// </summary>
		public static System.String getLocal(System.String interfaceName, int hl7Table, System.String interfaceCode)
		{
			return NuGenCodeMapper.Instance.getLocalCode(interfaceName, hl7Table, interfaceCode);
		}
		
		/// <summary> A convenience method that returns an interface code from an underlying 
		/// CodeMapper instance by calling <code>CodeMapper.getInstance().getInterfaceCode(...)</code>
		/// </summary>
		public static System.String getInt(System.String interfaceName, int hl7Table, System.String localCode)
		{
			return NuGenCodeMapper.Instance.getInterfaceCode(interfaceName, hl7Table, localCode);
		}
		
		/// <summary> Returns the interface code for the given local code, for use in the context 
		/// of the given interface.  
		/// </summary>
		public abstract System.String getInterfaceCode(System.String interfaceName, int hl7Table, System.String localCode);
		
		/// <summary> Returns the local code for the given interface code as it appears in  
		/// the given interface.  
		/// </summary>
		public abstract System.String getLocalCode(System.String interfaceName, int hl7Table, System.String interfaceCode);
		
		/// <summary> Determines what happens if no matching code is found during a lookup.  If set to true, 
		/// an HL7Exception is thrown if there is no match.  If false, null is returned.  The default
		/// is false. 
		/// </summary>
		public abstract void  throwExceptionIfNoMatch(bool throwException);
		
		/// <summary> If values are cached in such a way that they are not guaranteed to be current, a call 
		/// to this method refreshes the values.  
		/// </summary>
		public abstract void  refreshCache();
		
		/* may add these functions later to allow consistent maintenance e.g via a UI ... 
		public abstract String[] getInterfaceNames();
		public abstract void addInterface(String name);
		public abstract void addCodeMap(String interface, int hl7table, String localCode, String interfaceCode);
		*/
	}
}