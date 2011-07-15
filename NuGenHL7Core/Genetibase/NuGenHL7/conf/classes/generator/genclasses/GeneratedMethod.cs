/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GeneratedMethod.java".  Description: 
/// "This class will allows the creation of a method.  All members are set, then the 
/// toString method is called to return the String representation of the created method." 
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
namespace Genetibase.NuGenHL7.conf.classes.generator.genclasses
{
	
	/// <summary>This class will allows the creation of a method.  All members
	/// are set, then the toString method is called to return the String
	/// representation of the created method.
	/// </summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class GeneratedMethod
	{
		/// <summary>A method to set the name of the method</summary>
		/// <param name="name">the name of the created method
		/// </param>
		virtual public System.String Name
		{
			set
			{
				this.name = value;
			}
			
		}
		/// <summary>A method to set the return type of the method</summary>
		/// <param name="returnType">the return type of the created method
		/// </param>
		virtual public System.String ReturnType
		{
			set
			{
				this.returnType = value + " ";
			}
			
		}
		/// <summary>A method to set the visibility of the method</summary>
		/// <param name="visibility">the visibility of the created method
		/// </param>
		virtual public System.String Visibility
		{
			set
			{
				this.visibility = value + " ";
			}
			
		}
		private System.Collections.ArrayList body;
		private System.Collections.ArrayList comments;
		private System.Collections.ArrayList description;
    protected internal System.String INDENT = "   ";
		private System.String name;
		private System.Collections.ArrayList params_Renamed;
		private System.String returnType;
		private System.String throwing;
		private System.String visibility;
		/// <summary>Creates a new instance of GeneratedMethod </summary>
		public GeneratedMethod()
		{
			body = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			comments = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			params_Renamed = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			description = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
		}
		
		/// <summary>A method to set the parameters of the method</summary>
		/// <param name="param">the parameters of the created method
		/// </param>
		public virtual void  addParam(System.String param)
		{
			this.params_Renamed.Add(param);
		}
		
		/// <summary>A method to set the parameters of the method</summary>
		/// <param name="param">the parameters of the created method
		/// </param>
		/// <param name="description">the describing this method (for use in the JavaDoc comments)
		/// </param>
		public virtual void  addParam(System.String param, System.String description)
		{
			this.params_Renamed.Add(param);
			this.addToComments("@param " + param + " " + description);
		}
		
		/// <summary>A method to set the body of the method</summary>
		/// <param name="line">a line of code to be added to the body of the created method
		/// </param>
		/// <returns> a reference to the GeneratedMethod object being modified
		/// </returns>
		public virtual GeneratedMethod addToBody(System.String line)
		{
			this.body.Add(line);
			return this;
		}
		
		/// <summary>A method to set the comments of the method</summary>
		/// <param name="comments">a comment to be added the comments of the created method
		/// </param>
		public virtual void  addToComments(System.String comments)
		{
			this.comments.Add(comments);
		}
		
		/// <summary>A method to set the body of the method</summary>
		/// <param name="line">a description to be added to the created method
		/// </param>
		public virtual void  addToDescription(System.String line)
		{
			this.description.Add(line);
		}
		
		/// <summary>A method to set the throws of the method</summary>
		/// <param name="throwing">sets the throws of the created method
		/// </param>
		public virtual void  addToThrows(System.String throwing)
		{
			this.throwing = throwing;
		}
		
		/// <summary>creates a method with the filled member variables</summary>
		/// <returns> the String representation of the created method
		/// </returns>
		public override System.String ToString()
		{
			System.String theMethod;
			
			// add the comments and visibility to the method 
			theMethod = INDENT + "/**\n" + vectorToString(1, description, " * ") + vectorToString(1, comments, " * ") + "    */\n";
			theMethod += (INDENT + visibility);
			
			// check if its a constructor
			if (returnType != null)
				theMethod += returnType;
			
			// add the paramters to the method
			theMethod += name;
			if (params_Renamed.Count > 0)
				theMethod += ("(" + SupportClass.CollectionToString(params_Renamed).Replace('[', ' ').Replace(']', ' ') + ")");
			else
				theMethod += "()";
			
			// check if its throwing an exception
			if (throwing != null)
				theMethod += (" throws " + throwing);
			
			// create the body of the method
			theMethod += (" {\n" + vectorToString(2, body, "") + INDENT + "}\n");
			return theMethod;
		}
		
		/// <summary>Creates a string based on a vector representing the individual lines of a string</summary>
		/// <param name="indentLevel">the indentation level to use. For example, a level of 2 would use two "tabs" before each line.
		/// </param>
		/// <param name="vec">the vector to be converted
		/// </param>
		/// <param name="prefix">a String to prepend to each line 
		/// example " * " for a comment)
		/// </param>
		/// <returns> The generated string
		/// </returns>
		private System.String vectorToString(int indentLevel, System.Collections.ArrayList vec, System.String prefix)
		{
			System.String pString = "";
			System.String indent = System.String.Concat("", prefix);
			
			// Create indentation string
			for (int i = 0; i < indentLevel; i++)
				indent = INDENT + indent;
			
			// Convert the vector to a string
			for (int i = 0; i < vec.Count; i++)
			{
				pString += (indent + vec[i].ToString() + "\n");
			}
			return pString;
		}
	}
}