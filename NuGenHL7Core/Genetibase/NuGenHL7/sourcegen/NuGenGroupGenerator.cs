/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GroupGenerator.java".  Description: 
/// "Creates source code for Group classes - these are aggregations of 
/// segments and/or other groups that may repeat together within a message.
/// Source code is generated from the normative database" 
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
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.sourcegen
{
	
	/// <summary> Creates source code for Group classes - these are aggregations of 
	/// segments and/or other groups that may repeat together within a message.
	/// Source code is generated from the normative database.  
	/// 
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	/// <author>  Eric Poiseau
	/// </author>
	public class NuGenGroupGenerator:System.Object
	{
		
		/// <summary>Creates new GroupGenerator </summary>
		public NuGenGroupGenerator()
		{
		}
		
		/// <summary> <p>Creates source code for a Group and returns a GroupDef object that 
		/// describes the Group's name, optionality, repeatability.  The source 
		/// code is written under the given directory.</p>  
		/// <p>The structures list may contain [] and {} pairs representing 
		/// nested groups and their optionality and repeastability.  In these cases
		/// this method is called recursively.</p>
		/// <p>If the given structures list begins and ends with repetition and/or 
		/// optionality markers the repetition and optionality of the returned 
		/// GroupDef are set accordingly.</p>  
		/// </summary>
		/// <param name="structures">a list of the structures that comprise this group - must 
		/// be at least 2 long
		/// </param>
		/// <param name="baseDirectory">the directory to which files should be written
		/// </param>
		/// <param name="message">the message to which this group belongs
		/// </param>
		/// <throws>  HL7Exception if the repetition and optionality markers are not  </throws>
		/// <summary>      properly nested.  
		/// </summary>
		public static NuGenGroupDef writeGroup(NuGenStructureDef[] structures, System.String groupName, System.String baseDirectory, System.String version, System.String message)
		{
			
			//make base directory
			if (!(baseDirectory.EndsWith("\\") || baseDirectory.EndsWith("/")))
			{
				baseDirectory = baseDirectory + "/";
			}
			System.IO.FileInfo targetDir = NuGenSourceGenerator.makeDirectory(baseDirectory + NuGenSourceGenerator.getVersionPackagePath(version) + "group");
			
			NuGenGroupDef group = getGroupDef(structures, groupName, baseDirectory, version, message);
			System.IO.StreamWriter out_Renamed = new System.IO.StreamWriter(new System.IO.StreamWriter(targetDir.FullName + "/" + group.Name + ".java", false, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(targetDir.FullName + "/" + group.Name + ".java", false, System.Text.Encoding.Default).Encoding);
			out_Renamed.Write(makePreamble(group, version));
			out_Renamed.Write(makeConstructor(group, version));
			
			NuGenStructureDef[] shallow = group.Structures;
			for (int i = 0; i < shallow.Length; i++)
			{
				out_Renamed.Write(makeAccessor(group, i));
			}
			out_Renamed.Write("}\r\n");
			out_Renamed.Flush();
			out_Renamed.Close();
			
			return group;
		}
		
		/// <summary> <p>Given a list of structures defining the deep content of a group (as provided in 
		/// the normative database, some being pairs of optionality and repetition markers
		/// and segments nested within) returns a GroupDef including a short list of the shallow contents of the 
		/// group (including segments and groups that are immediate children).</p> 
		/// <p>For example given MSH [PID PV1] {[ERR NTE]}, short list would be something like 
		/// MSH PID_GROUP ERR_GROUP (with PID_GROUP marked as optional and ERR_GROUP marked as 
		/// optional and repeating).</p>
		/// <p>This method calls writeGroup(...) where necessary in order to create source code for 
		/// any nested groups before returning corresponding GroupDefs.</p>
		/// </summary>
		public static NuGenGroupDef getGroupDef(NuGenStructureDef[] structures, System.String groupName, System.String baseDirectory, System.String version, System.String message)
		{
			NuGenGroupDef ret = null;
			bool required = true;
			bool repeating = false;
			bool rep_opt = false;
			
			int len = structures.Length;
			NuGenStructureDef[] shortList = new NuGenStructureDef[len]; //place to put final list of groups/seg's w/o opt & rep markers
			int currShortListPos = 0;
			int currLongListPos = 0;
			
			try
			{
				//check for rep and opt (see if start & end elements are [] or {} AND they are each others' pair) ... 
				//System.out.println(len + " " + structures[0].getName() +structures[1].getName()+ ".." +structures[len-2].getName() + structures[len-1].getName()+ " " + message);
				System.String struct0name = structures[0].Name;
				System.String struct1name = structures[1].Name;
				System.String structLastName = structures[len - 1].Name;
				System.String structSecondLastName = structures[len - 2].Name;
				
				if (optMarkers(struct0name, structLastName) && (findGroupEnd(structures, 0) == len - 1))
					required = false;
				if (repMarkers(struct0name, structLastName) && (findGroupEnd(structures, 0) == len - 1))
					repeating = true;
				if (repoptMarkers(struct0name, structLastName) && (findGroupEnd(structures, 0) == len - 1))
					rep_opt = true;
				
				if (repeating || !required)
				{
					if (optMarkers(struct1name, structSecondLastName) && (findGroupEnd(structures, 1) == len - 2))
						required = false;
					if (repMarkers(struct1name, structSecondLastName) && (findGroupEnd(structures, 1) == len - 2))
						repeating = true;
				}
				
				//loop through, recurse nested groups, and build short list of structures for this group
				int skip = 0;
				if (!required)
					skip++;
				if (repeating)
					skip++;
				if (rep_opt)
					skip++;
				currLongListPos = skip;
				while (currLongListPos < len - skip)
				{
					System.String currSegName = structures[currLongListPos].Name;
					if (currSegName.Equals("[") || currSegName.Equals("{") || currSegName.Equals("[{"))
					{
						//this is the opening of a new group ... 
						System.String name = ((NuGenSegmentDef) structures[currLongListPos]).GroupName;
						int endOfNewGroup = findGroupEnd(structures, currLongListPos);
						NuGenStructureDef[] newGroupStructures = new NuGenStructureDef[endOfNewGroup - currLongListPos + 1];
						Array.Copy(structures, currLongListPos, newGroupStructures, 0, newGroupStructures.Length);
						shortList[currShortListPos] = writeGroup(newGroupStructures, name, baseDirectory, version, message);
						currLongListPos = endOfNewGroup + 1;
					}
					else
					{
						//copy verbatim into short list ... 
						shortList[currShortListPos] = structures[currLongListPos];
						currLongListPos++;
					}
					currShortListPos++;
				}
			}
			catch (System.ArgumentException e)
			{
				throw new NuGenHL7Exception("Problem creating nested group: " + e.GetType().FullName + ": " + e.Message, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			
			if (rep_opt)
			{
				ret = new NuGenGroupDef(message, groupName, false, true, "a Group object");
			}
			else
			{
				ret = new NuGenGroupDef(message, groupName, required, repeating, "a Group object");
			}
			
			NuGenStructureDef[] finalList = new NuGenStructureDef[currShortListPos]; //note: incremented after last assignment
			Array.Copy(shortList, 0, finalList, 0, currShortListPos);
			for (int i = 0; i < finalList.Length; i++)
			{
				ret.addStructure(finalList[i]);
			}
			
			return ret;
		}
		
		/// <summary> Returns true if opening is "[{" and closing is "}]"</summary>
		private static bool repoptMarkers(System.String opening, System.String closing)
		{
			bool ret = false;
			if (opening.Equals("[{") && closing.Equals("}]"))
			{
				ret = true;
			}
			return ret;
		}
		
		
		/// <summary> Returns true if opening is "[" and closing is "]"</summary>
		private static bool optMarkers(System.String opening, System.String closing)
		{
			bool ret = false;
			if (opening.Equals("[") && closing.Equals("]"))
			{
				ret = true;
			}
			return ret;
		}
		
		/// <summary> Returns true if opening is "{" and closing is "}"</summary>
		private static bool repMarkers(System.String opening, System.String closing)
		{
			bool ret = false;
			if (opening.Equals("{") && closing.Equals("}"))
			{
				ret = true;
			}
			return ret;
		}
		
		/// <summary> Returns heading material for class source code (package, imports, JavaDoc, class
		/// declaration).
		/// </summary>
		public static System.String makePreamble(NuGenGroupDef group, System.String version)
		{
			System.Text.StringBuilder preamble = new System.Text.StringBuilder();
			preamble.Append("package ");
			preamble.Append(NuGenSourceGenerator.getVersionPackageName(version));
			preamble.Append("group;\r\n\r\n");
			preamble.Append("import Genetibase.NuGenHL7.parser.ModelClassFactory;\r\n");
			preamble.Append("import Genetibase.NuGenHL7.HL7Exception;\r\n");
			preamble.Append("import ");
			preamble.Append(NuGenSourceGenerator.getVersionPackageName(version));
			preamble.Append("segment.*;\r\n\r\n");
			preamble.Append("import Genetibase.NuGenHL7.model.*;\r\n");
			preamble.Append("/**\r\n");
			preamble.Append(" * <p>Represents the ");
			preamble.Append(group.Name);
			preamble.Append(" Group.  A Group is an ordered collection of message \r\n");
			preamble.Append(" * segments that can repeat together or be optionally in/excluded together.\r\n");
			preamble.Append(" * This Group contains the following elements: </p>\r\n");
			preamble.Append(makeElementsDoc(group.Structures));
			preamble.Append(" */\r\n");
			preamble.Append("public class ");
			preamble.Append(group.Name);
			preamble.Append(" extends AbstractGroup {\r\n\r\n");
			
			return preamble.ToString();
		}
		
		
		/// <summary> Returns source code for the contructor for this Group class. </summary>
		public static System.String makeConstructor(NuGenGroupDef group, System.String version)
		{			
			System.Text.StringBuilder source = new System.Text.StringBuilder();
			
			source.Append("\t/** \r\n");
			source.Append("\t * Creates a new ");
			source.Append(group.Name);
			source.Append(" Group.\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic ");
			source.Append(group.Name);
			source.Append("(Group parent, ModelClassFactory factory) {\r\n");
			source.Append("\t   super(parent, factory);\r\n");
			source.Append("\t   try {\r\n");
			NuGenStructureDef[] structs = group.Structures;
			int numStructs = structs.Length;
			for (int i = 0; i < numStructs; i++)
			{
				NuGenStructureDef def = structs[i];
				
				if (def.Name.Equals("?"))
				{
					source.Append("\t      this.addNonstandardSegment(\"ANY\");\r\n");
				}
				else
				{
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
			}
			source.Append("\t   } catch(HL7Exception e) {\r\n");
			source.Append(group.Name);
			source.Append(" - this is probably a bug in the source code generator.\", e);\r\n");
			source.Append("\t   }\r\n");
			source.Append("\t}\r\n\r\n");
			return source.ToString();
		}
		
		/// <summary> Returns source code for a JavaDoc snippet listing the contents of a Group 
		/// or Message.  
		/// </summary>
		public static System.String makeElementsDoc(NuGenStructureDef[] structures)
		{
			System.Text.StringBuilder elements = new System.Text.StringBuilder();
			for (int i = 0; i < structures.Length; i++)
			{
				NuGenStructureDef def = structures[i];
				elements.Append(" * ");
				elements.Append(i);
				elements.Append(": ");
				elements.Append(def.Name);
				elements.Append(" (");
				elements.Append(def.Description);
				elements.Append(") <b>");
				if (!def.Required)
					elements.Append("optional ");
				if (def.Repeating)
					elements.Append("repeating");
				elements.Append("</b><br>\r\n");
			}
			
			return elements.ToString();
		}
		
		/// <summary> Returns source code for an accessor method for a particular Structure. </summary>
		public static System.String makeAccessor(NuGenGroupDef group, int structure)
		{
			System.Text.StringBuilder source = new System.Text.StringBuilder();
			
			NuGenStructureDef def = group.Structures[structure];
			
			System.String name = def.Name;
			System.String indexName = group.getIndexName(name);
			System.String getterName = indexName;
			if (def is NuGenGroupDef)
			{
				System.String unqualifiedName = ((NuGenGroupDef) def).UnqualifiedName;
				getterName = group.getIndexName(unqualifiedName);
			}
			
			//make accessor for first (or only) rep ... 
			source.Append("\t/**\r\n");
			source.Append("\t * Returns ");
			if (def.Repeating)
				source.Append(" first repetition of ");
			source.Append(indexName);
			source.Append(" (");
			source.Append(def.Description);
			source.Append(") - creates it if necessary\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic ");
			source.Append(def.Name);
			source.Append(" get");
			source.Append(getterName);
			source.Append("() { \r\n");
			source.Append("\t   ");
			source.Append(def.Name);
			source.Append(" ret = null;\r\n");
			source.Append("\t   try {\r\n");
			source.Append("\t      ret = (");
			source.Append(def.Name);
			source.Append(")this.get(\"");
			source.Append(getterName);
			source.Append("\");\r\n");
			source.Append("\t   } catch(HL7Exception e) {\r\n");
			source.Append("\t      throw new Exception();\r\n");
			source.Append("\t   }\r\n");
			source.Append("\t   return ret;\r\n");
			source.Append("\t}\r\n\r\n");
			
			if (def.Repeating)
			{
				//make accessor for specific rep ... 
				source.Append("\t/**\r\n");
				source.Append("\t * Returns a specific repetition of ");
				source.Append(indexName);
				source.Append("\r\n");
				source.Append("\t * (");
				source.Append(def.Description);
				source.Append(") - creates it if necessary\r\n");
				source.Append("\t * throws HL7Exception if the repetition requested is more than one \r\n");
				source.Append("\t *     greater than the number of existing repetitions.\r\n");
				source.Append("\t */\r\n");
				source.Append("\tpublic ");
				source.Append(def.Name);
				source.Append(" get");
				source.Append(getterName);
				source.Append("(int rep) throws HL7Exception { \r\n");
				source.Append("\t   return (");
				source.Append(def.Name);
				source.Append(")this.get(\"");
				source.Append(getterName);
				source.Append("\", rep);\r\n");
				source.Append("\t}\r\n\r\n");
				
				//make accessor for number of reps
				source.Append("\t/** \r\n");
				source.Append("\t * Returns the number of existing repetitions of ");
				source.Append(indexName);
				source.Append(" \r\n");
				source.Append("\t */ \r\n");
				source.Append("\tpublic int get");
				source.Append(getterName);
				source.Append("Reps() { \r\n");
				source.Append("\t    int reps = -1; \r\n");
				source.Append("\t    try { \r\n");
				source.Append("\t        reps = this.getAll(\"");
				source.Append(getterName);
				source.Append("\").length; \r\n");
				source.Append("\t    } catch (HL7Exception e) { \r\n");
				source.Append("\t        String message = \"Unexpected error accessing data - this is probably a bug in the source code generator.\"; \r\n");
				source.Append("\t        throw new Exception(message);\r\n");
				source.Append("\t    } \r\n");
				source.Append("\t    return reps; \r\n");
				source.Append("\t} \r\n\r\n");
			}
			
			return source.ToString();
		}
		
		/// <summary> Given a list of structures and the position of a SegmentDef that 
		/// indicates the start of a group (ie "{" or "["), returns the position
		/// of the corresponding end of the group.  Nested group markers are ignored.  
		/// </summary>
		/// <throws>  IllegalArgumentException if groupStart is out of range or does not  </throws>
		/// <summary>      point to a group opening marker. 
		/// </summary>
		/// <throws>  HL7Exception if the end of the group is not found or if other pairs  </throws>
		/// <summary>      are not properly nested inside this one.  
		/// </summary>
		public static int findGroupEnd(NuGenStructureDef[] structures, int groupStart)
		{
			
			//  {} is rep; [] is optionality
			System.String endMarker = null;
			try
			{
				System.String startMarker = structures[groupStart].Name;
				if (startMarker.Equals("["))
				{
					endMarker = "]";
				}
				else if (startMarker.Equals("{"))
				{
					endMarker = "}";
				}
				else if (startMarker.Equals("[{"))
				{
					endMarker = "}]";
				}
				else
				{
					for (int i = 0; i < structures.Length; i++)
					{
					}
					throw new System.ArgumentException("The segment " + startMarker + " does not begin a group - must be [ or {");
				}
			}
			catch (IndexOutOfRangeException)
			{
				throw new System.ArgumentException("The given start location is out of bounds");
			}
			
			//loop, increment and decrement opening and closing markers until we get back to 0 
			System.String segName = null;
			int offset = 0;
			try
			{
				int nestedInside = 1;
				while (nestedInside > 0)
				{
					offset++;
					segName = structures[groupStart + offset].Name;
					if (segName.Equals("{") || segName.Equals("[") || segName.Equals("[{"))
					{
						nestedInside++;
					}
					else if (segName.Equals("}") || segName.Equals("]") || segName.Equals("}]"))
					{
						nestedInside--;
					}
				}
			}
			catch (IndexOutOfRangeException)
			{
				throw new NuGenHL7Exception("Couldn't find end of group", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			if (!endMarker.Equals(segName))
				throw new NuGenHL7Exception("Group markers are not nested properly", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			return groupStart + offset;
		}
		static NuGenGroupGenerator()
		{
		}
	}
}