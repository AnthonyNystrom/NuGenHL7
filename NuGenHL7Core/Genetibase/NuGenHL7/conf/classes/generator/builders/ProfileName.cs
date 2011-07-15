/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ProfileName.java".  Description: 
/// "This Class represents the name of a conformance class. It is used to generate
/// names for classes, accessors for those classes, member variable to hold those
/// classes, etc. It is also responsable for tracking the names of all siblings
/// within a package, to ensure that no two classes have the same name."
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): James Agnew
/// Paul Brohman
/// Mitch Delachevrotiere
/// Shawn Dyck
/// Cory Metcalf
/// </summary>
/// <summary>Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  ?GPL?), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using Genetibase.NuGenHL7.sourcegen;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This Class represents the name of a conformance class. It is used to generate
	/// names for classes, accessors for those classes, member variable to hold those
	/// classes, etc. It is also responsable for tracking the names of all siblings
	/// within a package, to ensure that no two classes have the same name.
	/// </summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public sealed class ProfileName
	{
		/// <summary>Returns the accessor name</summary>
		/// <returns> the Accessor name
		/// </returns>
		public System.String AccessorName
		{
			get
			{
				// SegGroup names are a special case because makeAccessorName() chews out the
				// underscores they have to contain.
				if (profileStructureType == PS_SEGG)
					return "get" + this.profileName;
				else
					return new System.Text.StringBuilder(NuGenSourceGenerator.makeAccessorName(this.profileName)).ToString();
			}
			
		}
		/// <summary>Returns the Class name</summary>
		/// <returns> the Class name
		/// </returns>
		public System.String ClassName
		{
			get
			{
				System.String name = AccessorName.Substring(3, (4) - (3)).ToUpper() + AccessorName.Substring(4);
				return PS_TYPES[profileStructureType] + name;
			}
			
		}
		/// <summary>Returns the Member name</summary>
		/// <returns> the Member name
		/// </returns>
		public System.String MemberName
		{
			get
			{
				System.String memberName = AccessorName.Substring(3, (4) - (3)).ToLower() + AccessorName.Substring(4);
				if (!(System.Char.IsLetter(memberName[0]) || memberName[0].CompareTo('$') == 0 || memberName[0].CompareTo('_') == 0))
					memberName = "_" + memberName;
				
				return memberName;
			}
			
		}
		/// <summary>Returns the original name</summary>
		/// <returns> the original name
		/// </returns>
		public System.String OriginalName
		{
			get
			{
				return this.profileName;
			}
			
		}
		/// <summary>Returns the Package name</summary>
		/// <returns> the Package name
		/// </returns>
		public System.String PackageName
		{
			get
			{
				return AccessorName.Substring(3) + "children";
			}
			
		}
		
		/// <summary>Integer value representing the <code>profileName</code> value for Component </summary>
		public const int PS_COMP = 4;
		
		/// <summary>Integer value representing the <code>profileName</code> value for Field </summary>
		public const int PS_FIELD = 3;
		
		/// <summary>Integer value representing the <code>profileName</code> value for Message </summary>
		public const int PS_MSG = 0;
		
		/// <summary>Integer value representing the <code>profileName</code> value for Segment </summary>
		public const int PS_SEG = 2;
		
		/// <summary>Integer value representing the <code>profileName</code> value for SegGroup </summary>
		public const int PS_SEGG = 1;
		
		/// <summary>Integer value representing the <code>profileName</code> value for SubComponent </summary>
		public const int PS_SUBC = 5;
		
		private static readonly System.String[] PS_TYPES = new System.String[]{"Msg", "SegGrp", "Seg", "Field", "Comp", "SubComp"};
		internal System.Collections.Hashtable nameMap; // Map containing the name of the parent and all children at any given level
		private System.String parentName; // The name of the parent name assosiated with this ProfileName
		
		private System.String profileName; // The name that this ProfileName represents
		private int profileStructureType; // The HL7 structure level that this ProfileName represents
		
		/// <summary>Creates a new instance of ProfileName </summary>
		/// <param name="profileName">the name of the profile
		/// </param>
		/// <param name="profileStructureType">The Profile Structure Type for this Name. The
		/// Profile Structure Type is prepended to each class in the class hierarchy
		/// both for clarity and to avoid name collisions.
		/// </param>
		public ProfileName(System.String profileName, int profileStructureType):this(profileName, profileStructureType, new System.Collections.Hashtable(50), profileName)
		{
		}
		
		/// <summary>Creates a new instance of ProfileName </summary>
		/// <param name="profileName">the name of the profile
		/// </param>
		/// <param name="profileStructureType">The Profile Structure Type for this Name. The
		/// Profile Structure Type is prepended to each class in the class hierarchy
		/// both for clarity and to avoid name collisions.
		/// </param>
		/// <param name="nameMap">a list of all the children in ProfileName
		/// </param>
		/// <param name="parentName">the name of the parent to the child 
		/// </param>
		private ProfileName(System.String profileName, int profileStructureType, System.Collections.Hashtable nameMap, System.String parentName)
		{
			this.profileName = new System.Text.StringBuilder(profileName).ToString();
			this.profileStructureType = profileStructureType;
			this.nameMap = nameMap;
			this.parentName = parentName;
			
			// TODO: These are workarounds.. These should probably be resolved somehow.
			if (profileName.Equals("Acknowledgment Code"))
				this.profileName = "Acknowledgement Code";
			if (this.parentName != null && this.parentName.Equals("NK1") && profileName.Equals("Name"))
				this.profileName = "NKName";
			
			// Append a number to the name if there is already a ProfileName with this particular name
			int i = 1;
			while (nameMap.ContainsKey(this.profileStructureType + this.profileName))
			{
				i++;
				this.profileName = new System.Text.StringBuilder(profileName + i).ToString();
			}
			
			// Store the new name in the hashmap 
			nameMap[this.profileStructureType + this.profileName] = null;
		}
		
		/// <summary>This method clears the name map for this Profile Name, meaning that new names
		/// entered after the map was cleared will not collide with names entered
		/// before. This should be used when a ProfileName object is passed to a child
		/// builder class.
		/// </summary>
		/// <returns> ProfileName Returns the ProfileName object
		/// </returns>
		public ProfileName clearNameMap()
		{
			this.nameMap = new System.Collections.Hashtable(50);
			nameMap[this.profileStructureType + this.profileName] = null;
			this.parentName = this.profileName;
			return this;
		}
		
		/// <summary>Compares two ProfileName objects by comparing their <code>getAccessorName()</code>
		/// method return value.
		/// </summary>
		/// <returns> true if the names are equivalent
		/// </returns>
		public bool equals(ProfileName n)
		{
			if (AccessorName.Equals(n.AccessorName))
				return true;
			else
				return false;
		}
		
		/// <summary>creates a new instance of ProfileName</summary>
		/// <returns> the new ProfileName
		/// </returns>
		public ProfileName newInstance(System.String profileName, int profileStructureType)
		{
			ProfileName newPN = new ProfileName(profileName, profileStructureType, this.nameMap, this.profileName);
			return newPN;
		}
	}
}