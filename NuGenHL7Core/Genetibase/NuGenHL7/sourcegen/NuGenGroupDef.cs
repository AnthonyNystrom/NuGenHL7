/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GroupDef.java".  Description: 
/// "Contains the information needed to create source code for a Group (a 
/// Group is a part of a message that may repeat, and that contains two or 
/// more segments or other groups)" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
namespace Genetibase.NuGenHL7.sourcegen
{
	
	/// <summary> Contains the information needed to create source code for a Group (a 
	/// Group is a part of a message that may repeat, and that contains two or 
	/// more segments or other groups).   
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public class NuGenGroupDef : NuGenStructureDef
	{
		/// <summary> Returns the Java class name of this Group.  This is derived from the 
		/// message structure and the group elements.  This should only be called 
		/// after all the elements are added.  
		/// </summary>
		virtual public System.String Name
		{
			get
			{
				System.String result = null;
				
				if (groupName != null && groupName.Length > 0)
				{
					result = messageName + "_" + groupName;
				}
				else
				{
					System.Text.StringBuilder name = new System.Text.StringBuilder();
					name.Append(messageName);
					name.Append("_");
					System.String[] children = ChildSegments;
					for (int i = 0; i < children.Length; i++)
					{
						name.Append(children[i]);
					}
					result = name.ToString();
				}
				
				return result;
			}
			
		}
		/// <returns> group name without message name prepended  
		/// </returns>
		virtual public System.String UnqualifiedName
		{
			get
			{
				System.String name = Name;
				return name.Substring(messageName.Length + 1);
			}
			
		}
		/// <summary> Returns the structures in this group. </summary>
		virtual public NuGenStructureDef[] Structures
		{
			get
			{
				NuGenStructureDef[] ret = new NuGenStructureDef[elements.Count];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NuGenStructureDef) elements[i];
				}
				return ret;
			}
			
		}
		/// <summary> Returns true if this structure is required in the Group.  </summary>
		virtual public bool Required
		{
			get
			{
				return this.required;
			}
			
		}
		/// <summary> Returns true if this structure can repeat in the Group.  </summary>
		virtual public bool Repeating
		{
			get
			{
				return this.repeating;
			}
			
		}
		/// <summary> Returns a text description of the structure.</summary>
		virtual public System.String Description
		{
			get
			{
				return this.description;
			}
			
		}
		/// <summary> Returns a list of the names of the segments that are children of this Structure.
		/// If the structure is a Segment, a 1-element array is returned containing the segment
		/// name.  If a Group, an array of all the segments in the Group, including those nested
		/// in subgroups (depth first).  This method is used to support the XML SIG's convention
		/// for deriving group names.
		/// </summary>
		virtual public System.String[] ChildSegments
		{
			get
			{
				System.Collections.ArrayList deepChildList = new System.Collections.ArrayList();
				for (int i = 0; i < elements.Count; i++)
				{
					NuGenStructureDef childStruct = (NuGenStructureDef) elements[i];
					System.String[] childStructChildren = childStruct.ChildSegments;
					for (int j = 0; j < childStructChildren.Length; j++)
					{
						deepChildList.Add(childStructChildren[j]);
					}
				}
				System.String[] result = new System.String[deepChildList.Count];
				for (int i = 0; i < result.Length; i++)
				{
					result[i] = ((System.String) deepChildList[i]);
				}
				return result;
			}
			
		}
		
		private System.Collections.ArrayList elements;
		private System.String messageName;
		private System.String groupName;
		private System.String description;
		private bool required;
		private bool repeating;
		private System.Collections.Hashtable existingNames;
		
		
		/// <summary>Creates new GroupDef </summary>
		public NuGenGroupDef(System.String messageName, System.String groupName, bool required, bool repeating, System.String description)
		{
			this.messageName = messageName;
			this.groupName = groupName;
			this.elements = new System.Collections.ArrayList();
			this.required = required;
			this.repeating = repeating;
			this.description = description;
			this.existingNames = new System.Collections.Hashtable();
		}
		
		/// <summary> Adds an element (segment or group) to this group.  </summary>
		public virtual void  addStructure(NuGenStructureDef s)
		{
			elements.Add(s);
		}
		
		/// <summary> Returns the name by which a particular structure can be accessed (eg for use 
		/// in writing accessor source code).  This may differ from the class name of the 
		/// structure of there are >1 structures in the same group with the same class.  
		/// For example in ADT_A01 there are two ROL's that are not in sub-groups - AbstractGroup 
		/// stores the first one under the name ROL and the second under the name ROL2.  This 
		/// method returns names using the same naming scheme.  The order in which this 
		/// method is called matters: it should be called ONCE for each element of the group in the 
		/// order in which they appear.  
		/// </summary>
		protected internal virtual System.String getIndexName(System.String name)
		{
			//see if this name is already being used 
			System.Object o = existingNames[name];
			int c = 2;
			System.String newName = name;
			while (o != null)
			{
				newName = name + c++;
				o = existingNames[newName];
			}
			name = newName;
			existingNames[name] = name;
			return name;
		}
		
		/// <summary> Test harness ... </summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			/*GroupDef def = new GroupDef("ADT_FAKE", true, false);
			def.addStructure(new SegmentDef("MSH", true, false));
			def.addStructure(new SegmentDef("PID", false, false));
			def.addStructure(new SegmentDef("PV1", false, true));
			System.out.println(def.makeConstructor());
			System.out.println(def.makeAccessor(0));
			System.out.println(def.makeAccessor(1));
			System.out.println(def.makeAccessor(2));
			*/
			try
			{
				System.Type.GetType("sun.jdbc.odbc.JdbcOdbcDriver");
				NuGenMessageGenerator.makeAll("c:/java/adapter/source/", "2.4");
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
	}
}