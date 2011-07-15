/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "AbstractGroup.java".  Description: 
/// "A partial implementation of Group" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
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
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
namespace Genetibase.NuGenHL7.model
{
	
	
	/// <summary> A partial implementation of Group.  Subclasses correspond to specific
	/// groups of segments (and/or other sub-groups) that are implicitely defined by message structures  
	/// in the HL7 specification.  A subclass should define it's group structure by putting repeated calls to 
	/// the add(...) method in it's constructor.  Each call to add(...) adds a specific component to the 
	/// Group.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	[Serializable]
	public abstract class AbstractGroup : Group
	{
		/// <summary> Returns an ordered array of the names of the Structures in this 
		/// Group.  These names can be used to iterate through the group using 
		/// repeated calls to <code>get(name)</code>. 
		/// </summary>
		virtual public System.String[] Names
		{
			get
			{
				System.String[] retVal = new System.String[this.names.Count];
				for (int i = 0; i < this.names.Count; i++)
				{
					retVal[i] = ((System.String) this.names[i]);
				}
				return retVal;
			}
			
		}
		/// <summary> Returns the Message to which this segment belongs.</summary>
		virtual public Message Message
		{
			get
			{
				Structure s = this;
				while (!typeof(Message).IsAssignableFrom(s.GetType()))
				{
					s = s.Parent;
				}
				return (Message) s;
			}
			
		}
		/// <summary>Returns the parent group within which this structure exists (may be root
		/// message group).
		/// </summary>
		virtual public Group Parent
		{
			get
			{
				return this.parent;
			}
			
		}
		private System.Collections.ArrayList names;
		private System.Collections.Hashtable structures;
		private System.Collections.Hashtable required;
		private System.Collections.Hashtable repeating;
		private System.Collections.Hashtable classes;
		//protected Message message;
		private Group parent;
		private ModelClassFactory myFactory;
		
		/// <summary> This constructor should be used by implementing classes that do not 
		/// also implement Message.
		/// 
		/// </summary>
		/// <param name="parent">the group to which this Group belongs.
		/// </param>
		/// <param name="factory">the factory for classes of segments, groups, and datatypes under this group
		/// </param>
		protected internal AbstractGroup(Group parent, ModelClassFactory factory)
		{
			this.parent = parent;
			this.myFactory = factory;
			init();
		}
		
		/// <summary> This constructor should only be used by classes that implement Message directly.
		/// 
		/// </summary>
		/// <param name="factory">the factory for classes of segments, groups, and datatypes under this group
		/// </param>
		protected internal AbstractGroup(ModelClassFactory factory)
		{
			this.myFactory = factory;
			init();
		}
		
		private void  init()
		{
			names = new System.Collections.ArrayList();
			structures = new System.Collections.Hashtable();
			required = new System.Collections.Hashtable();
			repeating = new System.Collections.Hashtable();
			classes = new System.Collections.Hashtable();
		}
		
		/// <summary> Returns the named structure.  If this Structure is repeating then the first 
		/// repetition is returned.  Creates the Structure if necessary.  
		/// </summary>
		/// <throws>  HL7Exception if the named Structure is not part of this Group.  </throws>
		public virtual Structure get_Renamed(System.String name)
		{
			return get_Renamed(name, 0);
		}
		
		/// <summary> Returns a particular repetition of the named Structure. If the given repetition
		/// number is one greater than the existing number of repetitions then a new  
		/// Structure is created.  
		/// </summary>
		/// <throws>  HL7Exception if the named Structure is not part of this group,  </throws>
		/// <summary>    if the structure is not repeatable and the given rep is > 0,  
		/// or if the given repetition number is more than one greater than the 
		/// existing number of repetitions.  
		/// </summary>
		public virtual Structure get_Renamed(System.String name, int rep)
		{
			System.Object o = structures[name];
			if (o == null)
				throw new NuGenHL7Exception(name + " does not exist in the group " + this.GetType().FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			
			System.Collections.ArrayList list = (System.Collections.ArrayList) o;
			
			Structure ret;
			if (rep < list.Count)
			{
				// return existng Structure if it exists 
				ret = (Structure) list[rep];
			}
			else if (rep == list.Count)
			{
				//verify that Structure is repeating ... 
				System.Boolean repeats = (System.Boolean) this.repeating[name];
				if (!repeats && list.Count > 0)
					throw new NuGenHL7Exception("Can't create repetition #" + rep + " of Structure " + name + " - this Structure is non-repeating", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
				
				//create a new Structure, add it to the list, and return it
				System.Type c = (System.Type) classes[name]; //get class 
				ret = tryToInstantiateStructure(c, name);
				list.Add(ret);
			}
			else
			{
				throw new NuGenHL7Exception("Can't return repetition #" + rep + " of " + name + " - there are only " + list.Count + " repetitions.", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			}
			return ret;
		}
		
		/// <summary> Expands the group definition to include a segment that is not 
		/// defined by HL7 to be part of this group (eg an unregistered Z segment). 
		/// The new segment is slotted at the end of the group.  Thenceforward if 
		/// such a segment is encountered it will be parsed into this location. 
		/// If the segment name is unrecognized a GenericSegment is used.  The 
		/// segment is defined as repeating and not required.  
		/// </summary>
		public virtual System.String addNonstandardSegment(System.String name)
		{
			System.String version = this.Message.Version;
			if (version == null)
				throw new NuGenHL7Exception("Need message version to add segment by name; message.getVersion() returns null");
			System.Type c = myFactory.getSegmentClass(name, version);
			if (c == null)
				c = typeof(GenericSegment);
			
			int index = this.Names.Length;
			
			tryToInstantiateStructure(c, name); //may throw exception
			
			return insert(c, false, true, index, name);
		}
		
		/// <summary> Adds a new Structure (group or segment) to this Group.  A place for the  
		/// Structure is added to the group but there are initially zero repetitions.  
		/// This method should be used by the constructors of implementing classes 
		/// to specify which Structures the Group contains - Structures should be 
		/// added in the order in which they appear.  
		/// Note that the class is supplied instead of an instance because we want 
		/// there initially to be zero instances of each structure but we want the 
		/// AbstractGroup code to be able to create instances as necessary to support
		/// get(...) calls.
		/// </summary>
		/// <returns> the actual name used to store this structure (may be appended with 
		/// an integer if there are duplcates in the same Group).  
		/// </returns>
		protected internal virtual System.String add(System.Type c, bool required, bool repeating)
		{
			System.String name = getName(c);
			
			return insert(c, required, repeating, this.names.Count, name);
		}
		
		/// <summary> Returns true if the class name is already being used. </summary>
		private bool nameExists(System.String name)
		{
			bool exists = false;
			System.Object o = this.classes[name];
			if (o != null)
				exists = true;
			return exists;
		}
		
		/// <summary> Attempts to create an instance of the given class and return 
		/// it as a Structure. 
		/// </summary>
		/// <param name="c">the Structure implementing class
		/// </param>
		/// <param name="name">an optional name of the structure (used by Generic structures; may be null)
		/// </param>
		private Structure tryToInstantiateStructure(System.Type c, System.String name)
		{
			Structure s = null;
			try
			{
				System.Object o = null;
				if (typeof(GenericSegment).IsAssignableFrom(c))
				{
					s = new GenericSegment(this, name);
				}
				else if (typeof(GenericGroup).IsAssignableFrom(c))
				{
					s = new GenericGroup(this, name, myFactory);
				}
				else
				{
					//first try to instantiate using contructor w/ Message arg ...
					try
					{
						System.Type[] argClasses = new System.Type[]{typeof(Group), typeof(ModelClassFactory)};
						System.Object[] argObjects = new System.Object[]{this, myFactory};
						System.Reflection.ConstructorInfo con = c.GetConstructor(argClasses);
						o = con.Invoke(argObjects);
					}
					catch (System.MethodAccessException)
					{
						o = System.Activator.CreateInstance(c);
					}
					if (!(o is Structure))
					{
						throw new NuGenHL7Exception("Class " + c.FullName + " does not implement " + "ca.on.uhn.hl7.message.Structure", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
					}
					s = (Structure) o;
				}
			}
			catch (System.Exception e)
			{
				if (e is NuGenHL7Exception)
				{
					throw (NuGenHL7Exception) e;
				}
				else
				{
					throw new NuGenHL7Exception("Can't instantiate class " + c.FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
				}
			}
			return s;
		}
		
		/// <summary> Returns true if the named structure is required. </summary>
		public virtual bool isRequired(System.String name)
		{
			System.Object o = required[name];
			if (o == null)
				throw new NuGenHL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			System.Boolean req = (System.Boolean) o;
			return req;
		}
		
		/// <summary> Returns true if the named structure is required. </summary>
		public virtual bool isRepeating(System.String name)
		{
			System.Object o = repeating[name];
			if (o == null)
				throw new NuGenHL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			System.Boolean rep = (System.Boolean) o;
			return rep;
		}
		
		/// <summary> Returns the number of existing repetitions of the named structure.</summary>
		public virtual int currentReps(System.String name)
		{
			System.Object o = structures[name];
			if (o == null)
				throw new NuGenHL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			System.Collections.ArrayList list = (System.Collections.ArrayList) o;
			return list.Count;
		}
		
		/// <summary> Returns an array of Structure objects by name.  For example, if the Group contains
		/// an MSH segment and "MSH" is supplied then this call would return a 1-element array 
		/// containing the MSH segment.  Multiple elements are returned when the segment or 
		/// group repeats.  The array may be empty if no repetitions have been accessed
		/// yet using the get(...) methods. 
		/// </summary>
		/// <throws>  HL7Exception if the named Structure is not part of this Group.  </throws>
		public virtual Structure[] getAll(System.String name)
		{
			System.Object o = structures[name];
			if (o == null)
				throw new NuGenHL7Exception("The structure " + name + " does not exist in the group " + this.GetType().FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			System.Collections.ArrayList list = (System.Collections.ArrayList) o;
			Structure[] all = new Structure[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				all[i] = (Structure) list[i];
			}
			return all;
		}
		
		/// <summary> Returns the Class of the Structure at the given name index.  </summary>
		public virtual System.Type getClass(System.String name)
		{
			return (System.Type) classes[name];
		}
		
		/// <summary> Returns the class name (excluding package). </summary>
		/// <seealso cref="Structure.getName()">
		/// </seealso>
		public virtual System.String getName()
		{
			return getName(this.GetType());
		}
		
		//returns a name for a class of a Structure in this Message  
		private System.String getName(System.Type c)
		{
			System.String fullName = c.FullName;
			int dotLoc = fullName.LastIndexOf('.');
			System.String name = fullName.Substring(dotLoc + 1, (fullName.Length) - (dotLoc + 1));
			
			//remove message name prefix from group names for compatibility with getters ...
			if (typeof(Group).IsAssignableFrom(c) && !typeof(Message).IsAssignableFrom(c))
			{
				System.String messageName = Message.getName();
				if (name.StartsWith(messageName) && name.Length > messageName.Length)
				{
					name = name.Substring(messageName.Length + 1);
				}
			}
			
			return name;
		}
		
		/// <summary> Inserts the given structure into this group, at the
		/// indicated index number.  This method is used to support handling 
		/// of unexpected segments (e.g. Z-segments).  In contrast, specification 
		/// of the group's normal children should be done at construction time, using the 
		/// add(...) method. 
		/// </summary>
		private System.String insert(System.Type c, bool required, bool repeating, int index, System.String name)
		{
			//tryToInstantiateStructure(c, name);   //may throw exception
			
			//see if there is already something by this name and make a new name if necessary ... 
			if (nameExists(name))
			{
				int version = 2;
				System.String newName = name;
				while (nameExists(newName))
				{
					newName = name + version++;
				}
				name = newName;
			}
			
			this.names.Insert(index, name);
			this.required[name] = required;
			this.repeating[name] = repeating;
			this.classes[name] = c;
			this.structures[name] = new System.Collections.ArrayList();
			
			return name;
		}
		static AbstractGroup()
		{
		}
	}
}