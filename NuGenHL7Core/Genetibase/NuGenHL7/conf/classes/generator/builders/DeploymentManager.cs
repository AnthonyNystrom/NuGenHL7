/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DeploymentManager.java".  Description: 
/// "This Class Starts the build process and generates the Class files" 
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
using ProfileParser = Genetibase.NuGenHL7.conf.parser.NuGenProfileParser;
using Genetibase.NuGenHL7.conf.spec;
using Genetibase.NuGenHL7.conf.classes.generator.genclasses;
using Genetibase.NuGenHL7.conf.classes.exceptions;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This Class Starts the build process and generates the Class files</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class DeploymentManager
	{
		virtual public bool Verbose
		{
			get
			{
				return this.verbose;
			}
			
			set
			{
				this.verbose = value;
			}
			
		}
		
		private ConformanceMessageBuilder confMsgBuilder;
		private FileGenerator fg;
		private System.String packageName;
		private bool verbose = false;
		
		/// <summary>Creates a new instance of DeploymentManager </summary>
		public DeploymentManager(System.String dest, System.String packageName)
		{
			this.fg = new FileGenerator(dest);
			this.packageName = packageName;
			this.confMsgBuilder = new ConformanceMessageBuilder(packageName);
		}
		
		/// <summary>This method generates a Java representation of an XML profile message</summary>
		/// <param name="xml">an XML representation of a profile message
		/// </param>
		public virtual void  generate(System.String xml)
		{
			try
			{
				ProfileParser pp = new ProfileParser(false);
				AntGenerator an = new AntGenerator();
				RuntimeProfile spec = pp.parse(xml);
				
				if (spec.getHL7Version() == null || spec.getHL7Version().Equals(""))
					throw new ConformanceException("Error: Runtime Profile does not specify HL7Version");
				
				if (spec.Message.MsgStructID == null || spec.Message.MsgStructID.Equals(""))
					throw new ConformanceException("Error: Runtime Profile does not specify MsgStructID");
				
				this.confMsgBuilder.buildClass(spec, this);
				an.createAnt(fg.BasePath, packageName);
			}
			catch (Genetibase.NuGenHL7.conf.NuGenProfileException e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
				System.Console.Out.WriteLine(e.InnerException);
				System.Console.Out.WriteLine("ProfileException: " + e.ToString());
			}
		}
		
		/// <summary>This method is used to generate a file containng the Generated Class</summary>
		/// <param name="gc">the Generated Class
		/// </param>
		/// <param name="packageName">the name of the package
		/// </param>
		/// <param name="filename">the name to save the generated class under
		/// </param>
		public virtual void  generateFile(GeneratedClass gc, System.String packageName, System.String filename)
		{
			//fg.storeFile(gc, filename, packageName);
			try
			{
				fg.storeFile(gc, packageName, filename);
			}
			catch (System.IO.IOException e)
			{
				System.Console.Error.WriteLine(e.Message);
			}
		}
	}
}