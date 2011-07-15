/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DataTypeGenerator.java".  Description: 
/// "Generates skeletal source code for Datatype classes based on the 
/// HL7 database" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s):  Eric Poiseau. 
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
using NormativeDatabase = Genetibase.NuGenHL7.NuGenNormativeDatabase;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using DataTypeException = Genetibase.NuGenHL7.model.DataTypeException;
namespace Genetibase.NuGenHL7.sourcegen
{
	
	
	/// <summary> Generates skeletal source code for Datatype classes based on the 
	/// HL7 database.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	/// <author>  Eric Poiseau
	/// </author>
	public class NuGenDataTypeGenerator:System.Object
	{
		
		/// <summary> <p>Creates skeletal source code (without correct data structure but no business
		/// logic) for all data types found in the normative database.  For versions > 2.2, Primitive data types
		/// are not generated, because they are coded manually (as of HAPI 0.3).  
		/// </summary>
		public static void  makeAll(System.String baseDirectory, System.String version)
		{
			//make base directory
			if (!(baseDirectory.EndsWith("\\") || baseDirectory.EndsWith("/")))
			{
				baseDirectory = baseDirectory + "/";
			}
			System.IO.FileInfo targetDir = NuGenSourceGenerator.makeDirectory(baseDirectory + NuGenSourceGenerator.getVersionPackagePath(version) + "datatype");
			
			//get list of data types
			System.Collections.ArrayList types = new System.Collections.ArrayList();
			System.Data.OleDb.OleDbConnection conn = NuGenNormativeDatabase.Instance.Connection;
			System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
			//get normal data types ... 
			System.Data.OleDb.OleDbCommand temp_OleDbCommand;
			temp_OleDbCommand = stmt;
			temp_OleDbCommand.CommandText = "select data_type_code from HL7DataTypes, HL7Versions where HL7Versions.version_id = HL7DataTypes.version_id and HL7Versions.hl7_version = '" + version + "'";
			System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
			while (rs.Read())
			{
				types.Add(System.Convert.ToString(rs[1 - 1]));
			}
			
			//get CF, CK, CM, CN, CQ sub-types ... 
			
			System.Data.OleDb.OleDbCommand temp_OleDbCommand2;
			temp_OleDbCommand2 = stmt;
			temp_OleDbCommand2.CommandText = "select data_structure from HL7DataStructures, HL7Versions where (" + "data_type_code  = 'CF' or " + "data_type_code  = 'CK' or " + "data_type_code  = 'CM' or " + "data_type_code  = 'CN' or " + "data_type_code  = 'CQ') and " + "HL7Versions.version_id = HL7DataStructures.version_id and  HL7Versions.hl7_version = '" + version + "'";
			rs = temp_OleDbCommand2.ExecuteReader();
			while (rs.Read())
			{
				types.Add(System.Convert.ToString(rs[1 - 1]));
			}
			
			NuGenNormativeDatabase.Instance.returnConnection(conn);
			
			System.Console.Out.WriteLine("Generating " + types.Count + " datatypes for version " + version);
			if (types.Count == 0)
			{
			}
			
			for (int i = 0; i < types.Count; i++)
			{
				try
				{
					make(targetDir, (System.String) types[i], version);
				}
				catch (DataTypeException)
				{
				}
				catch (System.Exception)
				{
				}
			}
		}
		
		/// <summary> Creates source code for a single data type in the HL7 normative
		/// database. 
		/// </summary>
		/// <param name="targetDirectory">the directory into which the file will be written
		/// </param>
		/// <param name="datatype">the name (e.g. ST, ID, etc.) of the data type to be created
		/// </param>
		/// <param name="version">the HL7 version of the intended data type
		/// </param>
		public static void  make(System.IO.FileInfo targetDirectory, System.String dataType, System.String version)
		{
			//make sure that targetDirectory is a directory ... 
			if (!System.IO.Directory.Exists(targetDirectory.FullName))
				throw new System.IO.IOException("Can't create file in " + targetDirectory.ToString() + " - it is not a directory.");
			
			//get any components for this data type
			System.Data.OleDb.OleDbConnection conn = NuGenNormativeDatabase.Instance.Connection;
			System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
			System.Text.StringBuilder sql = new System.Text.StringBuilder();
			//this query is adapted from the XML SIG informative document
			sql.Append("SELECT HL7DataStructures.data_structure, HL7DataStructureComponents.seq_no, HL7DataStructures.description, HL7DataStructureComponents.table_id,  ");
			sql.Append("HL7Components.description, HL7Components.table_id, HL7Components.data_type_code, HL7Components.data_structure ");
			sql.Append("FROM HL7Versions LEFT JOIN (HL7DataStructures LEFT JOIN (HL7DataStructureComponents LEFT JOIN HL7Components ");
			sql.Append("ON HL7DataStructureComponents.comp_no = HL7Components.comp_no AND ");
			sql.Append("HL7DataStructureComponents.version_id = HL7Components.version_id) ");
			sql.Append("ON HL7DataStructures.version_id = HL7DataStructureComponents.version_id ");
			sql.Append("AND HL7DataStructures.data_structure = HL7DataStructureComponents.data_structure) ");
			sql.Append("ON HL7DataStructures.version_id = HL7Versions.version_id ");
			sql.Append("WHERE HL7DataStructures.data_structure = '");
			sql.Append(dataType);
			sql.Append("' AND HL7Versions.hl7_version = '");
			sql.Append(version);
			sql.Append("' ORDER BY HL7DataStructureComponents.seq_no");
			//System.out.println(sql.toString());  //for debugging
			System.Data.OleDb.OleDbCommand temp_OleDbCommand;
			temp_OleDbCommand = stmt;
			temp_OleDbCommand.CommandText = sql.ToString();
			System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
			
			System.Collections.ArrayList dataTypes = new System.Collections.ArrayList(20);
			System.Collections.ArrayList descriptions = new System.Collections.ArrayList(20);
			System.Collections.ArrayList tables = new System.Collections.ArrayList(20);
			System.String description = null;
			while (rs.Read())
			{
				if (description == null)
					description = System.Convert.ToString(rs[3 - 1]);
				
				System.String de = System.Convert.ToString(rs[5 - 1]);
				System.String dt = System.Convert.ToString(rs[8 - 1]);
				int ta = rs.GetInt32(4 - 1);
				//trim all CE_x to CE
				if (dt != null)
					if (dt.StartsWith("CE"))
						dt = "CE";
				//System.out.println("Component: " + de + "  Data Type: " + dt);  //for debugging
				dataTypes.Add(dt);
				descriptions.Add(de);
				tables.Add((System.Int32) ta);
			}
			NuGenNormativeDatabase.Instance.returnConnection(conn);
			
			//if there is only one component make a Primitive, otherwise make a Composite
			System.String source = null;
			if (dataTypes.Count == 1)
			{
				if (dataType.Equals("FT") || dataType.Equals("ST") || dataType.Equals("TX") || dataType.Equals("NM") || dataType.Equals("SI") || dataType.Equals("TN") || dataType.Equals("GTS"))
				{
					source = makePrimitive(dataType, description, version);
				}
				else
				{
					source = null; //note: IS, ID, DT, DTM, and TM are coded manually
				}
			}
			else if (dataTypes.Count > 1)
			{
				int numComponents = dataTypes.Count;
				//copy data into arrays ... 
				System.String[] type = new System.String[numComponents];
				System.String[] desc = new System.String[numComponents];
				int[] table = new int[numComponents];
				for (int i = 0; i < numComponents; i++)
				{
					type[i] = ((System.String) dataTypes[i]);
					desc[i] = ((System.String) descriptions[i]);
					table[i] = ((System.Int32) tables[i]);
				}
				source = makeComposite(dataType, description, type, desc, table, version);
			}
			else
			{
				//no components?  
				throw new DataTypeException("The data type " + dataType + " could not be found");
			}
			
			//System.out.println(source);
			
			//write to file ... 
			if (source != null)
			{
				System.String targetFile = targetDirectory.ToString() + "/" + dataType + ".java";
				System.IO.StreamWriter writer = new System.IO.StreamWriter(new System.IO.StreamWriter(targetFile, false, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(targetFile, false, System.Text.Encoding.Default).Encoding);
				writer.Write(source);
				writer.Flush();
			}
		}
		
		/// <summary> Returns a String containing the complete source code for a Primitive HL7 data
		/// type.  Note: this method is no longer used, as all Primitives are now coded manually.  
		/// </summary>
		private static System.String makePrimitive(System.String datatype, System.String description, System.String version)
		{
			//System.out.println("Making primitive: " + datatype);
			System.Text.StringBuilder source = new System.Text.StringBuilder();
			
			source.Append("package ");
			source.Append(NuGenSourceGenerator.getVersionPackageName(version));
			source.Append("datatype;\r\n\r\n");
			source.Append("import Genetibase.NuGenHL7.model.Primitive;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.DataTypeException;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.Message;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.Type;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.AbstractPrimitive;\r\n\r\n");
			source.Append("/**\r\n");
			source.Append(" * <p>Represents the HL7 ");
			source.Append(datatype);
			source.Append(" (");
			source.Append(description);
			source.Append(") datatype.  A ");
			source.Append(datatype);
			source.Append(" contains a single String value.\r\n");
			source.Append(" */\r\n");
			source.Append("public class ");
			source.Append(datatype);
			source.Append(" extends AbstractPrimitive ");
			source.Append(" {\r\n\r\n");
			//source.append("\tprotected String value;\r\n\r\n");
			source.Append("\t/**\r\n");
			source.Append("\t * Constructs an uninitialized ");
			source.Append(datatype);
			source.Append(".\r\n");
			source.Append("\t * @param message the Message to which this Type belongs\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic ");
			source.Append(datatype);
			source.Append("(Message message) {\r\n");
			source.Append("\t\tsuper(message);\r\n");
			source.Append("\t}\r\n\r\n");
			//source.append("\t/**\r\n");
			//source.append("\t * Constructs a ");
			//source.append(datatype);
			//source.append(" with the given value.\r\n");
			//source.append("\t */\r\n");
			//source.append("\tpublic ");
			//source.append(datatype);
			//source.append("(String value) {\r\n");
			//source.append("\t\tthis.value = value;\r\n");
			//source.append("\t}\r\n\r\n");
			//        source.append("\t/**\r\n");
			//        source.append("\t * Sets the value (a private field), which implementing classes should validate.\r\n");
			//        source.append("\t */\r\n");
			//        source.append("\tpublic void setValue(String value) throws DataTypeException { \r\n");
			//        source.append("\t\tthis.value = value;\r\n\t}\r\n\r\n");
			//        source.append("\t/**\r\n");
			//        source.append("\t * Returns the value.\r\n");
			//        source.append("\t */\r\n");
			//        source.append("\tpublic String getValue() {\r\n");
			//        source.append("\t\treturn this.value;\r\n");
			//        source.append("\t}\r\n");
			/*if (correspondingControlInterface != null) {
			source.append(Control.getImplementation(correspondingControlInterface, version));
			}*/
			source.Append("\t/**\r\n");
			source.Append("\t * @return \"");
			source.Append(version);
			source.Append("\"\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic String getVersion() {\r\n");
			source.Append("\t    return \"");
			source.Append(version);
			source.Append("\";\r\n");
			source.Append("\t}\r\n\r\n");
			source.Append("}\r\n");
			
			return source.ToString();
		}
		
		/// <summary> Returns a String containing source code for a Composite data type. The 
		/// dataTypes array contains the data type names (e.g. ST) of each component. 
		/// The descriptions array contains the corresponding descriptions (e.g. string).
		/// </summary>
		private static System.String makeComposite(System.String dataType, System.String description, System.String[] dataTypes, System.String[] descriptions, int[] tables, System.String version)
		{
			System.Text.StringBuilder source = new System.Text.StringBuilder();
			source.Append("package ");
			source.Append(NuGenSourceGenerator.getVersionPackageName(version));
			source.Append("datatype;\r\n\r\n");
			source.Append("import Genetibase.NuGenHL7.model.Composite;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.DataTypeException;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.Message;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.Type;\r\n");
			source.Append("import Genetibase.NuGenHL7.model.AbstractType;\r\n");
			source.Append("/**\r\n");
			source.Append(" * <p>The HL7 ");
			source.Append(dataType);
			source.Append(" (");
			source.Append(description);
			source.Append(") data type.  Consists of the following components: </p><ol>\r\n");
			for (int i = 0; i < dataTypes.Length; i++)
			{
				source.Append(" * <li>");
				source.Append(descriptions[i]);
				source.Append(" (");
				source.Append(dataTypes[i]);
				source.Append(")</li>\r\n");
			}
			source.Append(" * </ol>\r\n");
			source.Append(" */\r\n");
			source.Append("public class ");
			source.Append(dataType);
			source.Append(" extends AbstractType implements ");
			
			//implement interface from model.control package if required
			//Class correspondingControlInterface = Control.getInterfaceImplementedBy(dataType);
			//if (correspondingControlInterface == null) {
			source.Append("Composite");
			//} else { 
			//            source.append(correspondingControlInterface.getName());
			//}
			
			source.Append(" {\r\n\r\n");
			source.Append("\tprivate Type[] data;\r\n\r\n");
			source.Append("\t/**\r\n");
			source.Append("\t * Creates a ");
			source.Append(dataType);
			source.Append(".\r\n");
			source.Append("\t * @param message the Message to which this Type belongs\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic ");
			source.Append(dataType);
			source.Append("(Message message) {\r\n");
			source.Append("\t\tsuper(message);\r\n");
			source.Append("\t\tdata = new Type[");
			source.Append(dataTypes.Length);
			source.Append("];\r\n");
			for (int i = 0; i < dataTypes.Length; i++)
			{
				source.Append("\t\tdata[");
				source.Append(i);
				source.Append("] = new ");
				source.Append(NuGenSourceGenerator.getAlternateType(dataTypes[i], version));
				if (dataTypes[i].Equals("ID") || dataTypes[i].Equals("IS"))
				{
					source.Append("(message, ");
					source.Append(tables[i]);
					source.Append(")");
				}
				else
				{
					source.Append("(message)");
				}
				source.Append(";\r\n");
			}
			source.Append("\t}\r\n\r\n");
			source.Append("\t/**\r\n");
			source.Append("\t * Returns an array containing the data elements.\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic Type[] getComponents() { \r\n");
			source.Append("\t\treturn this.data; \r\n");
			source.Append("\t}\r\n\r\n");
			source.Append("\t/**\r\n");
			source.Append("\t * Returns an individual data component.\r\n");
			source.Append("\t * @throws DataTypeException if the given element number is out of range.\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic Type getComponent(int number) throws DataTypeException { \r\n\r\n");
			source.Append("\t\ttry { \r\n");
			source.Append("\t\t\treturn this.data[number]; \r\n");
			source.Append("\t\t} catch (ArrayIndexOutOfBoundsException e) { \r\n");
			source.Append("\t\t\tthrow new DataTypeException(\"Element \" + number + \" doesn't exist in ");
			source.Append(dataTypes.Length);
			source.Append(" element ");
			source.Append(dataType);
			source.Append(" composite\"); \r\n");
			source.Append("\t\t} \r\n");
			source.Append("\t} \r\n");
			
			//make type-specific accessors ... 
			for (int i = 0; i < dataTypes.Length; i++)
			{
				System.String dtName = NuGenSourceGenerator.getAlternateType(dataTypes[i], version);
				source.Append("\t/**\r\n");
				source.Append("\t * Returns ");
				source.Append(descriptions[i]);
				source.Append(" (component #");
				source.Append(i);
				source.Append(").  This is a convenience method that saves you from \r\n");
				source.Append("\t * casting and handling an exception.\r\n");
				source.Append("\t */\r\n");
				source.Append("\tpublic ");
				source.Append(dtName);
				source.Append(" ");
				source.Append(NuGenSourceGenerator.makeAccessorName(descriptions[i]));
				source.Append("() {\r\n");
				source.Append("\t   ");
				source.Append(dtName);
				source.Append(" ret = null;\r\n");
				source.Append("\t   try {\r\n");
				source.Append("\t      ret = (");
				source.Append(dtName);
				source.Append(")getComponent(");
				source.Append(i);
				source.Append(");\r\n");
				source.Append("\t   } catch (DataTypeException e) {\r\n");
				source.Append("\t      throw new Exception();\r\n");
				source.Append("\t   }\r\n");
				source.Append("\t   return ret;\r\n");
				source.Append("\t}\r\n\r\n");
			}
			/*if (correspondingControlInterface != null) {
			source.append(Control.getImplementation(correspondingControlInterface, version));
			} */
			source.Append("}");
			
			return source.ToString();
		}
		
		static NuGenDataTypeGenerator()
		{
		}
	}
}