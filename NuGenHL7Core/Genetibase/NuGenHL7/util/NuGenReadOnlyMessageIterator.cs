/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "ReadOnlyMessageIterator.java".  Description:
/// "Iterator though existing Stuctures in a message.   "
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2005.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
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
using Group = Genetibase.NuGenHL7.model.Group;
using Segment = Genetibase.NuGenHL7.model.Segment;
using Structure = Genetibase.NuGenHL7.model.Structure;
using EncodingCharacters = Genetibase.NuGenHL7.parser.NuGenEncodingCharacters;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Iterator though existing Stuctures in a message.  No new repetitions or optional 
	/// structures are created during iteration (in contrast to MessageIterator).  
	/// 
	/// Note that some structures are created during parsing, so the iteration may include 
	/// structures which were not present in the original encoded message.  If these are 
	/// not desired they can be skipped using a FilterIterator.  In fact to obtain an  
	/// iterator only over populated segments (not groups or empty segments) use the factory 
	/// method in this class.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2005/02/08 15:02:15 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenReadOnlyMessageIterator : System.Collections.IEnumerator
	{
		private class AnonymousClassPredicate : NuGenFilterIterator.Predicate
		{
			public virtual bool evaluate(System.Object obj)
			{
				if (typeof(Segment).IsAssignableFrom(obj.GetType()))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		private class AnonymousClassPredicate1 : NuGenFilterIterator.Predicate
		{
			public AnonymousClassPredicate1(Genetibase.NuGenHL7.parser.NuGenEncodingCharacters ec)
			{
				InitBlock(ec);
			}
			private void  InitBlock(Genetibase.NuGenHL7.parser.NuGenEncodingCharacters ec)
			{
				this.ec = ec;
			}
			private Genetibase.NuGenHL7.parser.NuGenEncodingCharacters ec;
			public virtual bool evaluate(System.Object obj)
			{
				System.String encoded = PipeParser.encode((Segment) obj, ec);
				if (encoded.Length > 3)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		/// <seealso cref="java.util.Iterator.next()">
		/// </seealso>
		public virtual System.Object Current
		{
			get
			{
				if (!MoveNext())
				{
					throw new System.ArgumentOutOfRangeException("No more nodes in message");
				}
				
				System.Object tempObject;
				tempObject = myRemaining[myRemaining.Count - 1];
				myRemaining.RemoveAt(myRemaining.Count - 1);
				Structure next = (Structure) tempObject;
				
				if (next is Group)
				{
					addChildren((Group) next);
				}
				
				return next;
			}
			
		}
		
		private System.Collections.IList myRemaining; //remaining nodes in reverse order (i.e. last is next)
		
		/// <param name="theRoot">root of depth first iteration, which starts with the first child  
		/// </param>
		public NuGenReadOnlyMessageIterator(Group theRoot)
		{
			myRemaining = new System.Collections.ArrayList(40);
			addChildren(theRoot);
		}
		
		/// <param name="theRoot">root of depth first iteration, which starts with the first child
		/// </param>
		/// <returns> an iterator that skips groups and empty segments, returning only populated 
		/// segments  
		/// </returns>
		public static System.Collections.IEnumerator createPopulatedSegmentIterator(Group theRoot)
		{
			System.Collections.IEnumerator allIterator = new NuGenReadOnlyMessageIterator(theRoot);
			
			NuGenFilterIterator.Predicate segmentsOnly = new AnonymousClassPredicate();
			NuGenFilterIterator segmentIterator = new NuGenFilterIterator(allIterator, segmentsOnly);
			
			EncodingCharacters ec = new EncodingCharacters('|', "^~\\&");
			NuGenFilterIterator.Predicate populatedOnly = new AnonymousClassPredicate1(ec);
			return new NuGenFilterIterator(segmentIterator, populatedOnly);
		}
		
		private void  addChildren(Group theParent)
		{
			System.String[] names = theParent.Names;
			for (int i = names.Length - 1; i >= 0; i--)
			{
				try
				{
					Structure[] reps = theParent.getAll(names[i]);
					for (int j = reps.Length - 1; j >= 0; j--)
					{
						myRemaining.Add(reps[j]);
					}
				}
				catch (NuGenHL7Exception)
				{
					throw new System.ApplicationException("Internal error: an invalid child name was obtained from its parent.");
				}
			}
		}
		
		/// <seealso cref="java.util.Iterator.hasNext()">
		/// </seealso>
		public virtual bool MoveNext()
		{
			return !(myRemaining.Count == 0);
		}

		virtual public void  Reset()
		{
		}
	}
}