/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "MessageGenerator.java".  Description:
/// "Creates source code for HL7 Message objects, using the normative DB"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s):  Eric Poiseau. 
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using NormativeDatabase = Genetibase.NuGenHL7.NuGenNormativeDatabase;
namespace Genetibase.NuGenHL7.sourcegen
{
	
	/// <summary> Creates source code for HL7 Message objects, using the normative DB.  HL7 Group
	/// objects are also created as a byproduct.
	/// 
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	/// <author>  Eric Poiseau
	/// </author>
	public class NuGenMessageGenerator:System.Object
	{
		
		/// <summary> If the system property by this name is true, groups are generated to use a ModelClassFactory
		/// for segment class lookup.  This makes segment creation more flexible, but may slow down parsing 
		/// substantially.  
		/// </summary>
		public static System.String MODEL_CLASS_FACTORY_KEY = "Genetibase.NuGenHL7.sourcegen.modelclassfactory";
		
		/// <summary>Creates new MessageGenerator </summary>
		public NuGenMessageGenerator()
		{
		}
		
		/// <summary> Creates and writes source code for all Messages and Groups.</summary>
		public static void  makeAll(System.String baseDirectory, System.String version)
		{
			//get list of messages ...
			System.Data.OleDb.OleDbConnection conn = NuGenNormativeDatabase.Instance.Connection;
			System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
			System.String sql = getMessageListQuery(version);
			System.Data.OleDb.OleDbCommand temp_OleDbCommand;
			temp_OleDbCommand = stmt;
			temp_OleDbCommand.CommandText = sql;
			System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
			System.Collections.ArrayList messages = new System.Collections.ArrayList();
			System.Collections.ArrayList chapters = new System.Collections.ArrayList();
			while (rs.Read())
			{
				messages.Add(System.Convert.ToString(rs[1 - 1]));
				chapters.Add(System.Convert.ToString(rs[2 - 1]));
			}
			NuGenNormativeDatabase.Instance.returnConnection(conn);
			
			if (messages.Count == 0)
			{
			}
			
			for (int i = 0; i < messages.Count; i++)
			{
				make((System.String) messages[i], baseDirectory, (System.String) chapters[i], version);
			}
		}
		
		/// <summary> Returns an SQL query with which to get a list of messages from the normative
		/// database.  
		/// </summary>
		private static System.String getMessageListQuery(System.String version)
		{
			// UNION because the messages are defined in different tables for different versions.
			return "SELECT distinct  [message_type]+'_'+[event_code] AS msg_struct, '?'" + " FROM HL7Versions RIGHT JOIN HL7EventMessageTypeSegments ON HL7EventMessageTypeSegments.version_id = HL7Versions.version_id " + "WHERE HL7Versions.hl7_version ='" + version + "' and Not (message_type='ACK') " + "UNION " + "select distinct HL7MsgStructIDs.message_structure, section from HL7Versions RIGHT JOIN (HL7MsgStructIDSegments " + " inner join HL7MsgStructIDs on HL7MsgStructIDSegments.message_structure = HL7MsgStructIDs.message_structure " + " and HL7MsgStructIDSegments.version_id = HL7MsgStructIDs.version_id) " + " ON HL7MsgStructIDSegments.version_id = HL7Versions.version_id " + " where HL7Versions.hl7_version = '" + version + "' and HL7MsgStructIDs.message_structure not like 'ACK_%'"; //note: allows "ACK" itself
		}
		
		/// <summary> Creates source code for a specific message structure and
		/// writes it under the specified directory.
		/// throws IllegalArgumentException if there is no message structure
		/// for this message in the normative database
		/// </summary>
		public static void  make(System.String message, System.String baseDirectory, System.String chapter, System.String version)
		{
			
			try
			{
				NuGenSegmentDef[] segments = getSegments(message, version);
				//System.out.println("Making: " + message + " with " + segments.length + " segments (not writing message code - just groups)");
				
				NuGenGroupDef group = NuGenGroupGenerator.getGroupDef(segments, null, baseDirectory, version, message);
				NuGenStructureDef[] contents = group.Structures;
				
				//make base directory
				if (!(baseDirectory.EndsWith("\\") || baseDirectory.EndsWith("/")))
				{
					baseDirectory = baseDirectory + "/";
				}
				System.IO.FileInfo targetDir = NuGenSourceGenerator.makeDirectory(baseDirectory + NuGenSourceGenerator.getVersionPackagePath(version) + "message");
				System.Console.Out.WriteLine("Writing " + message + " to " + targetDir.FullName);
				System.IO.StreamWriter out_Renamed = new System.IO.StreamWriter(new System.IO.StreamWriter(targetDir.FullName + "/" + message + ".java", false, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(targetDir.FullName + "/" + message + ".java", false, System.Text.Encoding.Default).Encoding);
				out_Renamed.Write(makePreamble(contents, message, chapter, version));
				out_Renamed.Write(makeConstructor(contents, message, version));
				for (int i = 0; i < contents.Length; i++)
				{
					out_Renamed.Write(NuGenGroupGenerator.makeAccessor(group, i));
				}
				
				//add implementation of model.control interface, if any
				//out.write(Control.getImplementation(Control.getInterfaceImplementedBy(message), version));            
				out_Renamed.Write("}\r\n");
				out_Renamed.Flush();
				out_Renamed.Close();
			}
			catch (System.Exception)
			{
				
			}
		}
		
		/// <summary> Queries the normative database for a list of segments comprising
		/// the message structure.  The returned list may also contain strings
		/// that denote repetition and optionality.  Choice indicators (i.e. begin choice,
		/// next choice, end choice) for alternative segments are ignored, so that the class
		/// structure allows all choices.  The matter of enforcing that only a single choice is
		/// populated can't be handled by the class structure, and should be handled elsewhere.
		/// </summary>
		private static NuGenSegmentDef[] getSegments(System.String message, System.String version)
		{
			/*String sql = "select HL7Segments.seg_code, repetitional, optional, description " +
			"from (HL7MsgStructIDSegments inner join HL7Segments on HL7MsgStructIDSegments.seg_code = HL7Segments.seg_code " +
			"and HL7MsgStructIDSegments.version_id = HL7Segments.version_id) " +
			"where HL7Segments.version_id = 6 and message_structure = '" + message + "' order by seq_no";*/
			System.String sql = getSegmentListQuery(message, version);
			//System.out.println(sql.toString()); 	
			NuGenSegmentDef[] segments = new NuGenSegmentDef[200]; //presumably there won't be more than 200
			System.Data.OleDb.OleDbConnection conn = NuGenNormativeDatabase.Instance.Connection;
			System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
			System.Data.OleDb.OleDbCommand temp_OleDbCommand;
			temp_OleDbCommand = stmt;
			temp_OleDbCommand.CommandText = sql;
			System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
			int c = - 1;
			while (rs.Read())
			{
				System.String name = NuGenSegmentGenerator.altSegName(System.Convert.ToString(rs[1 - 1]));
				bool repeating = rs.GetBoolean(2 - 1);
				bool optional = rs.GetBoolean(3 - 1);
				System.String desc = System.Convert.ToString(rs[4 - 1]);
				System.String groupName = version.ToUpper().Equals("2.3.1".ToUpper())?null:System.Convert.ToString(rs[6 - 1]); //group names are defined in DB for 2.3.1 but not used in the schema
				
				//ignore the "choice" directives ... the message class structure has to include all choices ...
				//  if this is enforced (i.e. exception thrown if >1 choice populated) this will have to be done separately.
				if (!(name.Equals("<") || name.Equals("|") || name.Equals(">")))
				{
					c++;
					segments[c] = new NuGenSegmentDef(name, groupName, !optional, repeating, desc);
				}
			}
			NuGenSegmentDef[] ret = new NuGenSegmentDef[c + 1];
			Array.Copy(segments, 0, ret, 0, c + 1);
			
			return ret;
		}
		
		/// <summary> Returns an SQL query with which to get a list of the segments that
		/// are part of the given message from the normative database.  The query
		/// varies with different versions.  The fields returned are as follows:
		/// segment_code, repetitional, optional, description
		/// </summary>
		private static System.String getSegmentListQuery(System.String message, System.String version)
		{
			System.String sql = null;
			
			sql = "SELECT HL7Segments.seg_code, repetitional, optional, HL7Segments.description, seq_no, groupname " + "FROM HL7Versions RIGHT JOIN (HL7Segments INNER JOIN HL7EventMessageTypeSegments ON (HL7Segments.version_id = HL7EventMessageTypeSegments.version_id) " + "AND (HL7Segments.seg_code = HL7EventMessageTypeSegments.seg_code)) " + "ON HL7Segments.version_id = HL7Versions.version_id " + "WHERE (((HL7Versions.hl7_version)= '" + version + "') " + "AND (([message_type]+'_'+[event_code])='" + message + "')) order by seq_no UNION " + "select HL7Segments.seg_code, repetitional, optional, HL7Segments.description, seq_no, groupname  " + "from HL7Versions RIGHT JOIN (HL7MsgStructIDSegments inner join HL7Segments on HL7MsgStructIDSegments.seg_code = HL7Segments.seg_code " + "and HL7MsgStructIDSegments.version_id = HL7Segments.version_id) " + "ON HL7Segments.version_id = HL7Versions.version_id " + "where HL7Versions.hl7_version = '" + version + "' and message_structure = '" + message + "' order by seq_no";
			return sql;
		}
		
		/// <summary> Returns header material for the source code of a Message class (including
		/// package, imports, JavaDoc, and class declaration).
		/// </summary>
		public static System.String makePreamble(NuGenStructureDef[] contents, System.String message, System.String chapter, System.String version)
		{
			System.Text.StringBuilder preamble = new System.Text.StringBuilder();
			preamble.Append("package ");
			preamble.Append(NuGenSourceGenerator.getVersionPackageName(version));
			preamble.Append("message;\r\n\r\n");
			preamble.Append("import ");
			preamble.Append(NuGenSourceGenerator.getVersionPackageName(version));
			preamble.Append("group.*;\r\n\r\n");
			preamble.Append("import ");
			preamble.Append(NuGenSourceGenerator.getVersionPackageName(version));
			preamble.Append("segment.*;\r\n\r\n");
			preamble.Append("import Genetibase.NuGenHL7.HL7Exception;\r\n\r\n");
			preamble.Append("import Genetibase.NuGenHL7.parser.ModelClassFactory;\r\n\r\n");
			preamble.Append("import Genetibase.NuGenHL7.parser.DefaultModelClassFactory;\r\n\r\n");
			preamble.Append("import Genetibase.NuGenHL7.model.AbstractMessage;\r\n\r\n");
			preamble.Append("/**\r\n");
			preamble.Append(" * <p>Represents a ");
			preamble.Append(message);
			preamble.Append(" message structure (see chapter ");
			preamble.Append(chapter);
			preamble.Append("). This structure contains the \r\n");
			preamble.Append(" * following elements: </p>\r\n");
			preamble.Append(NuGenGroupGenerator.makeElementsDoc(contents));
			preamble.Append(" */\r\n");
			preamble.Append("public class ");
			preamble.Append(message);
			preamble.Append(" extends AbstractMessage ");
			
			//implement interface from model.control package if required
			/*Class correspondingControlInterface = Control.getInterfaceImplementedBy(message);
			if (correspondingControlInterface != null) {
			preamble.append("implements ");
			preamble.append(correspondingControlInterface.getName());
			}*/
			
			preamble.Append(" {\r\n\r\n");
			
			return preamble.ToString();
		}
		
		/// <summary> Returns source code for the contructor for this Message class.</summary>
		public static System.String makeConstructor(NuGenStructureDef[] structs, System.String messageName, System.String version)
		{
			
			System.Text.StringBuilder source = new System.Text.StringBuilder();
			
			source.Append("\t/** \r\n");
			source.Append("\t * Creates a new ");
			source.Append(messageName);
			source.Append(" Group with custom ModelClassFactory.\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic ");
			source.Append(messageName);
			source.Append("(ModelClassFactory factory) {\r\n");
			source.Append("\t   super(factory);\r\n");
			source.Append("\t   init(factory);\r\n");
			source.Append("\t}\r\n\r\n");
			source.Append("\t/**\r\n");
			source.Append("\t * Creates a new ");
			source.Append(messageName);
			source.Append(" Group with DefaultModelClassFactory. \r\n");
			source.Append("\t */ \r\n");
			source.Append("\tpublic ");
			source.Append(messageName);
			source.Append("() { \r\n");
			source.Append("\t   super(new DefaultModelClassFactory());\r\n");
			source.Append("\t   init(new DefaultModelClassFactory());\r\n");
			source.Append("\t}\r\n\r\n");
			source.Append("\tprivate void init(ModelClassFactory factory) {\r\n");
			source.Append("\t   try {\r\n");
			int numStructs = structs.Length;
			for (int i = 0; i < numStructs; i++)
			{
				NuGenStructureDef def = structs[i];
				source.Append("\t      this.add(factory.get");
				source.Append((def is NuGenGroupDef)?"Group":"Segment");
				source.Append("Class(\"");
				source.Append(def.Name);
				source.Append("\", \"");
				source.Append(version);
				source.Append("\"), ");

				source.Append(def.Required);
				source.Append(", ");
				source.Append(def.Repeating);
				source.Append(");\r\n");
			}
			source.Append("\t   } catch(HL7Exception e) {\r\n");
			source.Append(messageName);
			source.Append(" - this is probably a bug in the source code generator.\", e);\r\n");
			source.Append("\t   }\r\n");
			source.Append("\t}\r\n\r\n");
			return source.ToString();
		}
		
		/// <summary> Test harness ...</summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length != 3)
			{
				System.Console.Out.WriteLine("Usage: MessageGenerator message_name version source_dir");
				System.Environment.Exit(1);
			}
			System.String mess = args[0];
			System.Console.Out.WriteLine("Testing source gen for message " + mess);
			//System.setProperty("ca.on.uhn.hl7.database.url", "jdbc:odbc:hl7");
			try
			{
				System.Type.GetType("sun.jdbc.odbc.JdbcOdbcDriver");
				make(mess, args[2], "0", args[1]);
				//makeAll(args[2], args[1]);            
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static NuGenMessageGenerator()
		{
		}
	}
}