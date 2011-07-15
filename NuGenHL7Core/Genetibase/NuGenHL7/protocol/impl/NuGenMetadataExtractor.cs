/*
* Created on 19-Apr-2004
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> A utility for getting a list of fields from a <code>Message</code>, 
	/// e.g. for inclusion in a <code>Transportable</code>. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2004/04/19 22:08:24 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenMetadataExtractor
	{
		
		/// <param name="theMessage">a message from which to extract fields
		/// </param>
		/// <param name="theTerserPaths">a list of paths to desired fields, in the 
		/// form required by <code>Terser</code>.  
		/// </param>
		/// <returns> a Map from Terser paths to field values 
		/// </returns>
		public static System.Collections.IDictionary getFields(Message theMessage, System.Collections.IList theTerserPaths)
		{
			System.Collections.IDictionary fields = new System.Collections.Hashtable();
			Terser terser = new Terser(theMessage);
			for (int i = 0; i < theTerserPaths.Count; i++)
			{
				System.String path = (System.String) theTerserPaths[i];
				System.String fieldValue = terser.get_Renamed(path);
				fields[path] = fieldValue;
			}
			return fields;
		}
	}
}