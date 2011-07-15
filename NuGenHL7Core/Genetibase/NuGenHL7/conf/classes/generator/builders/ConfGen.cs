/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ConfGen.java".  Description: 
/// "This Class is used to Generate a Class" 
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
using Genetibase.NuGenHL7.conf.classes.exceptions;
namespace Genetibase.NuGenHL7.conf.classes.generator.builders
{
	
	/// <summary>This Class is used to Generate a Class</summary>
	/// <author>  <table><tr>James Agnew</tr>
	/// <tr>Paul Brohman</tr>
	/// <tr>Mitch Delachevrotiere</tr>
	/// <tr>Shawn Dyck</tr>
	/// <tr>Cory Metcalf</tr></table>
	/// </author>
	public class ConfGen
	{
		
		/// <summary>this is the main method to start the Conformance Generator </summary>
		/// <param name="args">the command line argument
		/// </param>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			ConfGen gc = new ConfGen();
			CommandParser cp = new CommandParser();
			
			cp.parse(args);
			
			if (cp.HelpFlag)
			{
				System.Console.Out.WriteLine("Usage: ConfGen [-vht] SOURCE DESTINATION PACKAGENAME");
				return ;
			}
			
			if (cp.ErrFlag)
			{
				System.Console.Out.WriteLine("ConfGen: command line parse error");
				System.Console.Out.WriteLine("ConfGen: " + cp.Error);
				return ;
			}
			
			DeploymentManager dm = new DeploymentManager(cp.Dest, cp.Package);
			if (cp.TestFlag)
			{
				System.Console.Out.WriteLine("ConfGen: system test enabled");
				gc.test();
				return ;
			}
			if (cp.VerbFlag)
			{
				System.Console.Out.WriteLine("ConfGen: verbose display enabled");
				dm.Verbose = true;
			}
			
			System.Console.Out.WriteLine("Generating Source...");
			gc.generateConf(dm, cp);
			System.Console.Out.WriteLine("Done.");
		}
		
		/// <summary>this method generates conformance</summary>
		/// <param name="dm">the DeploymentManager
		/// </param>
		/// <param name="cp">the CommandParser which parses the command line argument of ConfGen 
		/// </param>
		public virtual void  generateConf(DeploymentManager dm, CommandParser cp)
		{
			try
			{
				System.IO.FileInfo f = new System.IO.FileInfo(cp.Source);
				System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(f.FullName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(f.FullName, System.Text.Encoding.Default).CurrentEncoding);
				char[] cbuf = new char[(int) SupportClass.FileLength(f)];
				in_Renamed.Read(cbuf, 0, (int) SupportClass.FileLength(f));
				dm.generate(System.Convert.ToString(cbuf));
			}
			catch (System.IO.FileNotFoundException e)
			{
				System.Console.Out.WriteLine("Filenotfoundexception: " + e.ToString());
			}
			catch (System.IO.IOException e)
			{
				System.Console.Out.WriteLine("IOexception:\n" + e.ToString() + "\n");
			}
			catch (ConformanceError e)
			{
				System.Console.Out.WriteLine("ConformanceError:\n" + e.ToString() + "\n");
			}
			catch (ConformanceException e)
			{
				System.Console.Out.WriteLine("ConformanceException:\n" + e.ToString() + "\n");
			}
		}
		
		/// <summary>this method tests the conformance generator to see if it is working</summary>
		public virtual void  test()
		{
			try
			{
				System.Console.Out.Write("Checking for XML Parser:");
				System.Type.GetType("org.w3c.dom.Element");
				System.Console.Out.WriteLine("           PASS");
			}
			catch (System.Exception)
			{
				System.Console.Out.WriteLine("           FAIL");
			}
			
			try
			{
				System.Console.Out.Write("Checking for Xerces:");
				System.Type.GetType("org.apache.xerces.parsers.DOMParser");
				System.Console.Out.WriteLine("               PASS");
			}
			catch (System.Exception)
			{
				System.Console.Out.WriteLine("               FAIL");
			}
			
			try
			{
				System.Console.Out.Write("Checking for Conformance Classes:");
				System.Type.GetType("Genetibase.NuGenHL7.conf.classes.generator.builders.ConformanceMessageBuilder");
				System.Console.Out.WriteLine("  PASS");
			}
			catch (System.Exception)
			{
				System.Console.Out.WriteLine("  FAIL");
			}
			
			try
			{
				System.Console.Out.Write("Checking for Apache Ant:");
				System.Type.GetType("org.apache.tools.ant.Main");
				System.Console.Out.WriteLine("           PASS");
			}
			catch (System.Exception)
			{
				System.Console.Out.WriteLine("           FAIL");
			}
		}
	}
}