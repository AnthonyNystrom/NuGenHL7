/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "UnderlyingAccessor.java".  Description:
/// "This class is used to determine the name of the accessor method on the
/// underlying object for a given conformance class. It is used to determine
/// whether underlying accessors require a "rep" parameter. For instance,
/// a message type might provide an accessor <code>getMSH()</code> to return
/// its MSH segment. The runtime profile may not provide any clue as to whether
/// the MSH segment in the HAPI library for the given message type is repeatable
/// or not. This class determines this information."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s): James Agnew
/// Paul Brohman
/// Mitch Delachevrotiere
/// Shawn Dyck
/// Cory Metcalf
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  ?GPL?), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using Genetibase.NuGenHL7.conf.classes.exceptions;
using Composite = Genetibase.NuGenHL7.model.Composite;
using GenericSegment = Genetibase.NuGenHL7.model.GenericSegment;
using Group = Genetibase.NuGenHL7.model.Group;
using Segment = Genetibase.NuGenHL7.model.Segment;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary> This class is used to determine the name of the accessor method on the
	/// underlying object for a given conformance class. It is used to determine
	/// whether underlying accessors require a "rep" parameter. For instance,
	/// a message type might provide an accessor <code>getMSH()</code> to return
	/// its MSH segment. The runtime profile may not provide any clue as to whether
	/// the MSH segment in the HAPI library for the given message type is repeatable
	/// or not. This class determines this information.
	/// 
	/// </summary>
	/// <author>  <table><tr><td>James Agnew</td></tr>
	/// <tr><td>Paul Brohman</td></tr>
	/// <tr><td>Mitch Delachevrotiere</td></tr>
	/// <tr><td>Shawn Dyck</td></tr>
	/// <tr><td>Cory Metcalf</td></tr></table>
	/// </author>
	public class UnderlyingAccessor
	{
		/// <summary> Returns true if the underlying accessor accepts a rep argument, or
		/// false if the underlying accessor does not.
		/// </summary>
		/// <returns> boolean Returns true if the underlying accessor accepts a rep argument, or
		/// false if the underlying accessor does not.
		/// </returns>
		virtual public bool AcceptsRep
		{
			get
			{
				return acceptsRep;
			}
			
		}
		
		internal bool acceptsRep;
		internal System.String theAccessor;
		
		//these are used to keep track of child numbers in case we can't find
		//a name-based getter 
		private static System.String ourCurrentParent = "";
		private static int ourCurrentChild = 0;
		
		/// <summary> Determines the name of the accessor method on the underlying object for a given
		/// conformance class. It is used to determine whether underlying accessors require
		/// a "rep" parameter.
		/// </summary>
		/// <param name="className">the Class name
		/// </param>
		/// <param name="accessorName">the Accessor ame
		/// </param>
		public UnderlyingAccessor(System.String className, System.String accessorName)
		{
			acceptsRep = false;
			
			track(className);
			
			try
			{
				System.Type c = getHapiModelClass(className);
				theAccessor = makeName(c, accessorName);
				
				//children of groups & segments repeat; children of composites don't 
				if (typeof(Group).IsAssignableFrom(c))
				{
					acceptsRep = true;
				}
				else if (typeof(Segment).IsAssignableFrom(c))
				{
					System.Reflection.MethodInfo m = getMethod(c, accessorName);
					if (m == null || m.GetParameters().Length == 1)
					{
						acceptsRep = true;
					}
				}
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
				throw new ConformanceError("Underlying class/method " + className + "." + accessorName + "() can not be found. The complete HAPI API must be installed prior to using this system.");
			}
		}
		
		/// <summary> Keeps track of the child number that is being processed.  We assume 
		/// they are processed in order.   
		/// </summary>
		/// <param name="theParent">
		/// </param>
		private static void  track(System.String theParent)
		{
			if (ourCurrentParent.Equals(theParent))
			{
				ourCurrentChild++;
			}
			else
			{
				ourCurrentParent = theParent;
				ourCurrentChild = 0;
			}
		}
		
		/// <param name="theUnderlyingClassName">the name of a HAPI model class
		/// </param>
		/// <returns> the Java class by that name if one is on the classpath; otherwise it is assumed 
		/// that we are dealing with a Z-segment, and GenericSegment.class is returned
		/// </returns>
		public static System.Type getHapiModelClass(System.String theUnderlyingClassName)
		{
			System.Type c = null;
			try
			{
				c = System.Type.GetType(theUnderlyingClassName);
			}
			catch (System.Exception)
			{
				c = typeof(GenericSegment);
			}
			return c;
		}
		
		/// <param name="theParentClass">
		/// </param>
		/// <param name="theChildName">must be an integer when the parent is a composite  
		/// </param>
		/// <returns> the accessor name on the given parent that returns the the given child 
		/// </returns>
		private System.String makeName(System.Type theParentClass, System.String theChildName)
		{
			System.String result = null;
			if (typeof(Group).IsAssignableFrom(theParentClass))
			{
				result = "get(\"" + guessCompName(theChildName) + "\", rep)";
			}
			else if (typeof(Segment).IsAssignableFrom(theParentClass))
			{
				System.Reflection.MethodInfo method = getMethod(theParentClass, theChildName);
				
				//use number if we can't find the field by name (could be site-defined)
				if (method == null)
				{
					result = "getField(" + ourCurrentChild + ", rep)";
				}
				else
				{
					result = (method.GetParameters().Length == 1)?theChildName + "( rep )":theChildName + "()";
				}
			}
			else if (typeof(Composite).IsAssignableFrom(theParentClass))
			{
				result = "get(" + theChildName + ")";
			}
			else
			{
				throw new ConformanceError("The parent class " + theParentClass + " is not recognized as a Group, Segment, or Composite");
			}
			return result;
		}
		
		private static System.String guessCompName(System.String theAccessorName)
		{
			return theAccessorName.Substring(3);
		}
		
		private static System.Reflection.MethodInfo getMethod(System.Type theParentClass, System.String theChildName)
		{
			System.Reflection.MethodInfo result = null;
			System.Reflection.MethodInfo[] methods = theParentClass.GetMethods();
			for (int i = 0; i < methods.Length; i++)
			{
				if (methods[i].Name.Equals(theChildName))
				{
					result = methods[i];
					if (result.GetParameters().Length == 1)
						break;
				}
			}
			return result;
		}
		
		/// <summary>This method returns a string representation of the Accessor</summary>
		/// <returns> a String representation of the Accessor
		/// </returns>
		/// <seealso cref="java.lang.Object.toString()">
		/// </seealso>
		public override System.String ToString()
		{
			return theAccessor;
		}
		static UnderlyingAccessor()
		{
		}
	}
}