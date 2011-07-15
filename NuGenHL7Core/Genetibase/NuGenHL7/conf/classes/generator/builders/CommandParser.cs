/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "CommandParse.java".  Description: 
/// "This class parses the command line argument for the command line tool ConfGen.java" 
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
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This class parses the command line argument for the command line tool ConfGen.java</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class CommandParser
	{
		/// <summary>returns the location where the genrated files are going to be stored into </summary>
		/// <returns> the location where the genrated files are going to be stored into   
		/// </returns>
		virtual public System.String Dest
		{
			get
			{
				return params_Renamed[1].ToString();
			}
			
		}
		/// <summary>returns true if the error flag is set or false if it is not</summary>
		/// <returns> true if the error flag is set or false if it is not  
		/// </returns>
		virtual public bool ErrFlag
		{
			get
			{
				return errFlag;
			}
			
		}
		/// <summary>returns the error type if there is an error in the command line arguments </summary>
		/// <returns> the error type if there is an error in the command line arguments 
		/// </returns>
		virtual public System.String Error
		{
			get
			{
				return errorType;
			}
			
		}
		/// <summary>returns true if the help flag is set or false if it is not</summary>
		/// <returns> true if the help flag is set or false if it is not  
		/// </returns>
		virtual public bool HelpFlag
		{
			get
			{
				return helpFlag;
			}
			
		}
		/// <summary>returns the pakage name to use for the generated source </summary>
		/// <returns> the pakage name to use for the generated source 
		/// </returns>
		virtual public System.String Package
		{
			get
			{
				return params_Renamed[2].ToString();
			}
			
		}
		/// <summary>returns the location of the XML profile </summary>
		/// <returns> the location of the XML profile  
		/// </returns>
		virtual public System.String Source
		{
			get
			{
				return params_Renamed[0].ToString();
			}
			
		}
		/// <summary>returns true if the test flag is set or false if it is not</summary>
		/// <returns> true if the test flag is set or false if it is not  
		/// </returns>
		virtual public bool TestFlag
		{
			get
			{
				return testFlag;
			}
			
		}
		/// <summary>returns true if the verbose flag is set or false if it is not</summary>
		/// <returns> true if the verbose flag is set or false if it is not  
		/// </returns>
		virtual public bool VerbFlag
		{
			get
			{
				return verbFlag;
			}
			
		}
		private bool errFlag = false;
		private System.String errorType;
		private bool helpFlag = false;
		private System.Collections.ArrayList params_Renamed;
		
		// option flags
		private bool testFlag = false;
		private bool verbFlag = false;
		
		/// <summary>creates a new vector to store the command line arguments into </summary>
		public CommandParser()
		{
			this.params_Renamed = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
		}
		
		/// <summary>this method parses the command line for the ConfGen.java command line tool</summary>
		/// <param name="args[]">the commnad line arguments
		/// </param>
		public virtual void  parse(System.String[] args)
		{
			int i = 0;
			System.String arg;
			char flag;
			
			while (i < args.Length && args[i].StartsWith("-"))
			{
				arg = args[i++];
				
				// use this type of check for a series of flag arguments			
				for (int j = 1; j < arg.Length; j++)
				{
					flag = arg[j];
					switch (flag)
					{
						
						case 'v':  // -v = verbose
							verbFlag = true;
							break;
						
						case 'h':  // -h = help
							helpFlag = true;
							break;
						
						case 't':  // -t = test
							testFlag = true;
							break;
						
						default: 
							errFlag = true;
							errorType = "invalid command line argument";
							break;
						
					}
				}
			}
			
			while (i < args.Length && params_Renamed.Count < 3)
			{
				params_Renamed.Add(args[i++]);
			}
			
			if (params_Renamed.Count < 3)
			{
				errFlag = true;
				errorType = "invalid parameters, source destination and package required";
			}
		}
	}
}