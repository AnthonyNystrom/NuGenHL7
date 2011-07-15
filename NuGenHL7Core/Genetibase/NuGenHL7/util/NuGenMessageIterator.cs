using System;
using Genetibase.NuGenHL7.model;

using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Iterates over all defined nodes (ie segments, groups) in a message, 
	/// regardless of whether they have been instantiated previously.  This is a 
	/// tricky process, because the number of nodes is infinite, due to infinitely 
	/// repeating segments and groups.  See <code>next()</code> for details on 
	/// how this is handled. 
	/// 
	/// This implementation assumes that the first segment in each group is present (as per
	/// HL7 rules).  Specifically, when looking for a segment location, an empty group that has 
	/// a spot for the segment will be overlooked if there is anything else before that spot. 
	/// This may result in surprising (but sensible) behaviour if a message is missing the 
	/// first segment in a group. 
	/// 
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenMessageIterator : System.Collections.IEnumerator
	{
		/// <summary> <p>Returns the next node in the message.  Sometimes the next node is 
		/// ambiguous.  For example at the end of a repeating group, the next node 
		/// may be the first segment in the next repetition of the group, or the 
		/// next sibling, or an undeclared segment locally added to the group's end.  
		/// Cases like this are disambiguated using getDirection(), which returns  
		/// the name of the structure that we are "iterating towards".  
		/// Usually we are "iterating towards" a segment of a certain name because we 
		/// have a segment string that we would like to parse into that node. 
		/// Here are the rules: </p>
		/// <ol><li>If at a group, next means first child.</li>
		/// <li>If at a non-repeating segment, next means next "position"</li>
		/// <li>If at a repeating segment: if segment name matches 
		/// direction then next means next rep, otherwise next means next "position".</li>
		/// <li>If at a segment within a group (not at the end of the group), next "position" 
		/// means next sibling</li>
		/// <li>If at the end of a group: If name of group or any of its "first 
		/// decendents" matches direction, then next position means next rep of group.  Otherwise 
		/// if direction matches name of next sibling of the group, or any of its first 
		/// descendents, next position means next sibling of the group.  Otherwise, next means a 
		/// new segment added to the group (with a name that matches "direction").  </li>
		/// <li>"First descendents" means first child, or first child of the first child, 
		/// or first child of the first child of the first child, etc. </li> </ol>
		/// </summary>
		public virtual System.Object Current
		{
			get
			{
				if (!MoveNext())
				{
					throw new System.ArgumentOutOfRangeException("No more nodes in message");
				}
				try
				{
					this.currentStructure = next_Renamed_Field.parent.get_Renamed(next_Renamed_Field.index.name, next_Renamed_Field.index.rep);
				}
				catch (NuGenHL7Exception e)
				{
					throw new System.ArgumentOutOfRangeException("HL7Exception: " + e.Message);
				}
				clearNext();
				return this.currentStructure;
			}
			
		}
		virtual public System.String Direction
		{
			get
			{
				return this.direction;
			}
			
			set
			{
				clearNext();
				this.direction = value;
			}
			
		}
		
		private Structure currentStructure;
		private System.String direction;
		private Position next_Renamed_Field;
		private bool handleUnexpectedSegments;

		/// <summary>Creates a new instance of MessageIterator </summary>
		public NuGenMessageIterator(Structure start, System.String direction, bool handleUnexpectedSegments)
		{
			this.currentStructure = start;
			this.direction = direction;
			this.handleUnexpectedSegments = handleUnexpectedSegments;
		}
		
		
		/// <summary> Returns true if another object exists in the iteration sequence.  </summary>
		public virtual bool MoveNext()
		{
			bool has = true;
			if (next_Renamed_Field == null)
			{
				if (typeof(Group).IsAssignableFrom(currentStructure.GetType()))
				{
					groupNext((Group) currentStructure);
				}
				else
				{
					Group parent = currentStructure.Parent;
					Index i = getIndex(parent, currentStructure);
					Position currentPosition = new Position(parent, i);
					
					try
					{
						if (parent.isRepeating(i.name) && currentStructure.getName().Equals(direction))
						{
							nextRep(currentPosition);
						}
						else
						{
							has = nextPosition(currentPosition, this.direction, this.handleUnexpectedSegments);
						}
					}
					catch (NuGenHL7Exception e)
					{
						throw new System.ApplicationException("HL7Exception arising from bad index: " + e.Message);
					}
				}
			}
			return has;
		}
		
		/// <summary> Sets next to the first child of the given group (iteration 
		/// always proceeds from group to first child). 
		/// </summary>
		private void  groupNext(Group current)
		{
			next_Renamed_Field = new Position(current, ((Group) current).Names[0], 0);
		}
		
		/// <summary> Sets next to the next repetition of the current structure.  </summary>
		private void  nextRep(Position current)
		{
			next_Renamed_Field = new Position(current.parent, current.index.name, current.index.rep + 1);
		}
		
		/// <summary> Sets this.next to the next position in the message (from the given position), 
		/// which could be the next sibling, a new segment, or the next rep 
		/// of the parent.  See next() for details. 
		/// </summary>
		private bool nextPosition(Position currPos, System.String direction, bool makeNewSegmentIfNeeded)
		{
			bool nextExists = true;
			if (isLast(currPos))
			{
				nextExists = nextFromGroupEnd(currPos, direction, makeNewSegmentIfNeeded);
			}
			else
			{
				nextSibling(currPos);
			}
			return nextExists;
		}
		
		/// <summary>Navigates from end of group </summary>
		private bool nextFromGroupEnd(Position currPos, System.String direction, bool makeNewSegmentIfNeeded)
		{
			bool nextExists = true;
			
			//the following conditional logic is a little convoluted -- its meant as an optimization 
			// i.e. trying to avoid calling matchExistsAfterCurrentPosition
			
			if (!makeNewSegmentIfNeeded && typeof(Message).IsAssignableFrom(currPos.parent.GetType()))
			{
				nextExists = false;
			}
			else if (!makeNewSegmentIfNeeded || matchExistsAfterPosition(currPos, direction, false, true))
			{
				Group grandparent = currPos.parent.Parent;
				Index parentIndex = getIndex(grandparent, currPos.parent);
				Position parentPos = new Position(grandparent, parentIndex);
				
				try
				{
					bool parentRepeats = parentPos.parent.isRepeating(parentPos.index.name);
					if (parentRepeats && contains(parentPos.parent.get_Renamed(parentPos.index.name, 0), direction, false, true))
					{
						nextRep(parentPos);
					}
					else
					{
						nextExists = nextPosition(parentPos, direction, makeNewSegmentIfNeeded);
					}
				}
				catch (NuGenHL7Exception e)
				{
					throw new System.ApplicationException("HL7Exception arising from bad index: " + e.Message);
				}
			}
			else
			{
				newSegment(currPos.parent, direction);
			}
			return nextExists;
		}
		
		/// <summary> A match exists for the given name somewhere after the given position (in the 
		/// normal serialization order).  
		/// </summary>
		/// <param name="pos">the message position after which to look (note that this specifies 
		/// the message instance)
		/// </param>
		/// <param name="name">the name of the structure to look for
		/// </param>
		/// <param name="firstDescendentsOnly">only searches the first children of a group 
		/// </param>
		/// <param name="upToFirstRequired">only searches the children of a group up to the first 
		/// required child (normally the first one).  This is used when we are parsing 
		/// a message in order and looking for a place to parse a particular segment -- 
		/// if the message is correct then it can't go after a required position of a 
		/// different name. 
		/// </param>
		public static bool matchExistsAfterPosition(Position pos, System.String name, bool firstDescendentsOnly, bool upToFirstRequired)
		{
			bool matchExists = false;
			
			//check next rep of self (if any)
			if (pos.parent.isRepeating(pos.index.name))
			{
				Structure s = pos.parent.get_Renamed(pos.index.name, pos.index.rep);
				matchExists = contains(s, name, firstDescendentsOnly, upToFirstRequired);
			}
			
			//check later siblings (if any) 
			if (!matchExists)
			{
				System.String[] siblings = pos.parent.Names;
				bool after = false;
				for (int i = 0; i < siblings.Length && !matchExists; i++)
				{
					if (after)
					{
						matchExists = contains(pos.parent.get_Renamed(siblings[i]), name, firstDescendentsOnly, upToFirstRequired);
						if (upToFirstRequired && pos.parent.isRequired(siblings[i]))
							break;
					}
					if (pos.index.name.Equals(siblings[i]))
						after = true;
				}
			}
			
			//recurse to parent (if parent is not message root)
			if (!matchExists && !typeof(Message).IsAssignableFrom(pos.parent.GetType()))
			{
				Group grandparent = pos.parent.Parent;
				Position parentPos = new Position(grandparent, getIndex(grandparent, pos.parent));
				matchExists = matchExistsAfterPosition(parentPos, name, firstDescendentsOnly, upToFirstRequired);
			}
			return matchExists;
		}
		
		/// <summary> Sets the next position to a new segment of the given name, within the 
		/// given group. 
		/// </summary>
		private void  newSegment(Group parent, System.String name)
		{
			parent.addNonstandardSegment(name);
			next_Renamed_Field = new Position(parent, parent.Names[parent.Names.Length - 1], 0);
		}
		
		/// <summary> Determines whether the given structure matches the given name, or contains 
		/// a child that does.  
		/// </summary>
		/// <param name="s">the structure to check 
		/// </param>
		/// <param name="name">the name to look for 
		/// </param>
		/// <param name="firstDescendentsOnly">only checks first descendents (i.e. first 
		/// child, first child of first child, etc.)  In theory the first child 
		/// of a group should always be present, and we don't use this method with 
		/// subsequent children because finding the next position within a group is 
		/// straightforward.  
		/// </param>
		/// <param name="upToFirstRequired">only checks first descendents and of their siblings 
		/// up to the first required one.  This may be needed because in practice 
		/// some first children of groups are not required.  
		/// </param>
		public static bool contains(Structure s, System.String name, bool firstDescendentsOnly, bool upToFirstRequired)
		{
			bool contains = false;
			if (typeof(Segment).IsAssignableFrom(s.GetType()))
			{
				if (s.getName().Equals(name))
					contains = true;
			}
			else
			{
				Group g = (Group) s;
				System.String[] names = g.Names;
				for (int i = 0; i < names.Length && !contains; i++)
				{
					try
					{
                        contains = NuGenMessageIterator.contains(g.get_Renamed(names[i], 0), name, firstDescendentsOnly, upToFirstRequired);   
						if (firstDescendentsOnly)
							break;
						if (upToFirstRequired && g.isRequired(names[i]))
							break;
					}
					catch (NuGenHL7Exception e)
					{
						throw new System.ApplicationException("HL7Exception due to bad index: " + e.Message);
					}
				}
			}
			return contains;
		}
		
		/// <summary> Tests whether the name of the given Index matches 
		/// the name of the last child of the given group. 
		/// </summary>
		public static bool isLast(Position p)
		{
			System.String[] names = p.parent.Names;
			return names[names.Length - 1].Equals(p.index.name);
		}
		
		/// <summary> Sets the next location to the next sibling of the given 
		/// index.  
		/// </summary>
		private void  nextSibling(Position pos)
		{
			System.String[] names = pos.parent.Names;
			int i = 0;
			for (; i < names.Length && !names[i].Equals(pos.index.name); i++)
			{
			}
			System.String nextName = names[i + 1];
			
			this.next_Renamed_Field = new Position(pos.parent, nextName, 0);
		}
		
		private void  clearNext()
		{
			next_Renamed_Field = null;
		}
		
		/// <summary> Returns the index of the given structure as a child of the 
		/// given parent.  Returns null if the child isn't found. 
		/// </summary>
		public static Index getIndex(Group parent, Structure child)
		{
			Index index = null;
			System.String[] names = parent.Names;
			for (int i = 0; i < names.Length; i++)
			{
				if (names[i].StartsWith(child.getName()))
				{
					try
					{
						Structure[] reps = parent.getAll(names[i]);
						for (int j = 0; j < reps.Length; j++)
						{
							if (child == reps[j])
							{
								index = new Index(names[i], j);
								goto findChild_brk;
							}
						}
					}
					catch (NuGenHL7Exception e)
					{
						throw new System.ApplicationException("Internal HL7Exception finding structure index: " + e.Message);
					}
				}
			}

findChild_brk: ;
			
			return index;
		}
		
		/// <summary> An index of a child structure within a group, consisting of the name and rep of 
		/// of the child.
		/// </summary>
		public class Index
		{
			public System.String name;
			public int rep;
			public Index(System.String name, int rep)
			{
				this.name = name;
				this.rep = rep;
			}
			
			/// <seealso cref="Object.equals">
			/// </seealso>
			public  override bool Equals(System.Object o)
			{
				bool equals = false;
				if (o != null && o is Index)
				{
					Index i = (Index) o;
					if (i.rep == rep && i.name.Equals(name))
						equals = true;
				}
				return equals;
			}
			
			/// <seealso cref="Object.hashCode">
			/// </seealso>
			public override int GetHashCode()
			{
				return name.GetHashCode() + 700 * rep;
			}
			
			/// <seealso cref="Object.toString">
			/// </seealso>
			public override System.String ToString()
			{
				return this.name + ":" + this.rep;
			}
		}
		
		/// <summary> A structure position within a message. </summary>
		public class Position
		{
			public Group parent;
			public Index index;
			public Position(Group parent, System.String name, int rep)
			{
				this.parent = parent;
				this.index = new Index(name, rep);
			}
			public Position(Group parent, Index i)
			{
				this.parent = parent;
				this.index = i;
			}
			
			/// <seealso cref="Object.equals">
			/// </seealso>
			public  override bool Equals(System.Object o)
			{
				bool equals = false;
				if (o != null && o is Position)
				{
					Position p = (Position) o;
					if (p.parent.Equals(parent) && p.index.Equals(index))
						equals = true;
				}
				return equals;
			}
			
			/// <seealso cref="Object.hashCode">
			/// </seealso>
			public override int GetHashCode()
			{
				return parent.GetHashCode() + index.GetHashCode();
			}
			
			public override System.String ToString()
			{
				System.Text.StringBuilder ret = new System.Text.StringBuilder(parent.getName());
				ret.Append(":");
				ret.Append(index.name);
				ret.Append("(");
				ret.Append(index.rep);
				ret.Append(")");
				return ret.ToString();
			}
		}
		virtual public void  Reset()
		{
		}
		static NuGenMessageIterator()
		{
		}
	}
}