/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "GeneratedClass.java".  Description: 
/// "This Class generates a Class File which is used by the Conformance Builder Classes" 
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
using Genetibase.NuGenHL7.conf.classes.generator.builders;
namespace Genetibase.NuGenHL7.conf.classes.generator.genclasses
{
	
	/// <summary>This Class generates a Class File which is used by the Conformance Builder Classes</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class GeneratedClass
	{
		virtual public GeneratedMethod Constructor
		{
			get
			{
				return this.constructor;
			}
			
			set
			{
				this.constructor = value;
			}
			
		}

		virtual public System.String Name
		{
			get
			{
				return this.name;
			}
			
			set
			{
				this.name = value + " ";
				this.constructor.Name = value;
			}
			
		}
		/// <summary>This method sets the classPackage for the class contained within the generated Java source file</summary>
		/// <param name="classPackage">the classPackage to set
		/// </param>
		virtual public System.String ClassPackage
		{
			set
			{
				if (value != null)
					this.classPackage = value;
				else
					this.classPackage = "";
			}
			
		}
		/// <summary>This method sets the class properties for the class contained within the generated Java source file</summary>
		/// <param name="propertie">to set
		/// </param>
		virtual public System.String Properties
		{
			set
			{
				if (value != null)
					this.properties = value + " ";
				else
					this.properties = "";
			}
			
		}
		
		private const System.String INDENT = "   ";
		private System.Collections.ArrayList classComments;
		private System.Collections.ArrayList classImports;
		private System.String classPackage;
		private GeneratedMethod constructor;
		private System.Collections.ArrayList license;
		private System.Collections.ArrayList memberVariables;
		private System.Collections.ArrayList methods;
		private System.String name;
		private System.String properties;
		
		/// <summary>Creates a new instance of GeneratedClass,
		/// creates a new instance of the all the memberVariables 
		/// </summary>
		public GeneratedClass()
		{
			classImports = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			memberVariables = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			methods = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			classComments = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			license = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
			constructor = new GeneratedMethod();
			constructor.Visibility = "public";
			classPackage = "";
			properties = "";
		}
		
		/// <summary>This method adds a new comment to the class contained within the generated Java source file</summary>
		/// <param name="classComment">adds a comment to the class
		/// </param>
		public virtual void  addClassComment(System.String classComment)
		{
			this.classComments.Add(classComment);
		}
		
		/// <summary>This method adds a new import statement to the class contained within the generated Java source file</summary>
		/// <param name="classImport">the import path to import
		/// </param>
		public virtual void  addClassImport(System.String classImport)
		{
			this.classImports.Add("import " + classImport + ";");
		}
		
		/// <summary>This method adds a new member variable to the class contained within the generated Java source file</summary>
		/// <param name="memberVariable">the member variable to add
		/// </param>
		public virtual void  addMemberVariable(System.String memberVariable)
		{
			memberVariables.Add(memberVariable);
		}
		
		/// <summary>This method adds a new method to the class contained within the generated Java source file</summary>
		/// <param name="method">the generated method to add
		/// </param>
		public virtual void  addMethod(GeneratedMethod method)
		{
			methods.Add(method);
		}
		
		/// <summary>This method sets the class comments for the class contained within the generated Java source file</summary>
		/// <param name="comments">the comments to add to the class comments
		/// </param>
		public virtual void  addToClassComments(System.String comments)
		{
			this.classComments.Add(comments);
		}
		
		/// <summary>This method will return a String representation of the class contained within the generated 
		/// Java source file 
		/// </summary>
		/// <returns> a String representation of the class
		/// </returns>
		public override System.String ToString()
		{
			System.String theClass = new System.Text.StringBuilder().ToString();
			
			theClass += DocumentationBuilder.getDocumentationBuilder().GeneratedClassHeader;
			theClass += System.String.Concat(vectorToString(0, license, ""), "\n\n"); // License block
			theClass += ("package " + classPackage + ";\n\n"); // Package statement
			theClass += System.String.Concat(vectorToString(0, classImports, ""), "\n\n"); // Package and import statements
			theClass += ("/**\n" + System.String.Concat(vectorToString(0, classComments, " * "), " */\n")); // Class comments
			
			theClass += ("public class " + name + properties + "{\n\n"); // Class statement
			theClass += System.String.Concat(vectorToString(1, memberVariables, ""), "\n\n"); // member variables
			theClass += (constructor.ToString() + "\n\n"); // Constructor
			theClass += System.String.Concat(vectorToString(0, methods, ""), "\n"); // methods (no indentation because methods indent themselves)
			theClass += "}\n";
			return theClass;
		}
		
		/// <summary>Creates a string based on a vector representing the individual lines of a string</summary>
		/// <param name="indentLevel">the indentation level to use. For example, a level of 2 would use two "tabs" before each line.
		/// </param>
		/// <param name="vec">the vector to be converted
		/// </param>
		/// <param name="prefix">a string to prepend to each line (ie <example>" * "</example> for a comment)
		/// </param>
		/// <returns> the generated string
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