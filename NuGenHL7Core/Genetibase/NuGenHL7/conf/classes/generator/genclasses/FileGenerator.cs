/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "FileGenerator.java".  Description: 
/// "This class writes a GeneratedClass object to a file" 
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
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.conf.classes.generator.genclasses
{
	
	/// <summary>This class writes a GeneratedClass object to a file</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class FileGenerator
	{
		/// <summary>This method returns the Base Path</summary>
		/// <returns> the Base Path
		/// </returns>
		virtual public System.String BasePath
		{
			get
			{
				return basePath;
			}
			
		}
		private System.String basePath;
		
		/// <summary>Initialize member variable setting the base file path</summary>
		/// <param name="basePath">representing base path location
		/// </param>
		public FileGenerator(System.String basePath)
		{
			// make sure there is a \ appended to ouput director path
			System.Console.Out.WriteLine(basePath);
			this.basePath = basePath.Replace('\\', '/');
			if ((basePath[basePath.Length - 1]) != '/')
				basePath = basePath + "/";
		}
		
		/// <summary>this method writes the GeneratedClass object to disk</summary>
		/// <param name="gc">the object to be written to disk
		/// </param>
		/// <param name="packageName">representing the packageName
		/// </param>
		/// <param name="fileName">representing the file name
		/// </param>
		/// <exception cref="IOException">if unable to create file
		/// </exception>
		public virtual void  storeFile(GeneratedClass gc, System.String packageName, System.String fileName)
		{
			
			//format package name
			packageName = packageName.Replace('.', '/');
			
			// set the file path			
            fileName = Regex.Replace(fileName, " ", "") + ".java";
			System.String filePath = basePath + "/" + packageName + "/" + fileName;
			System.IO.FileInfo f = new System.IO.FileInfo(filePath);
			System.Text.StringBuilder dir = new System.Text.StringBuilder();
			
			//check if file exist
			// TODO: Reactivate this once everything works!
			//if(f.exists())
			//	throw new IOException("File already exists");
			
			//create subfolders
			int i = 0;
			while (i < filePath.Length)
			{
				if (filePath[i] != '/')
				{
					dir.Append(filePath[i]);
				}
				else
				{
					dir.Append(filePath[i]);
					System.IO.FileInfo d = new System.IO.FileInfo(dir.ToString());
					System.IO.Directory.CreateDirectory(d.FullName);
				}
				++i;
			}
			
			System.IO.FileStream fstream = new System.IO.FileStream(f.FullName, System.IO.FileMode.Create); /* open file stream */
			System.IO.BinaryWriter ostream = new System.IO.BinaryWriter(fstream); /* open object stream */
			ostream.Write(gc.ToString());
			
			/* clean-up */
			ostream.Flush();
			fstream.Close();
		}
	}
}