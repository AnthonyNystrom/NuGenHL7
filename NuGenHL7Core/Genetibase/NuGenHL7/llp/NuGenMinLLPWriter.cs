/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "MinLLPWriter.java".  Description: 
/// "Title:        MinLLPWriter
/// Description:  Writes HL7 messages to an OutputStream
/// Copyright:    Copyright (c) 2001
/// Company:      University Health Network
/// </summary>
/// <author>        Damian Horton
/// </author>
/// <version>  1.1" 
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
/// </version>
using System;
namespace Genetibase.NuGenHL7.llp
{
	
	/// <summary> Title:        MinLLPWriter
	/// Description:  Writes HL7 messages to an OutputStream.  The character set defaults to US-ASCII.  
	/// It can be chaged by setting the system property Genetibase.NuGenHL7.llp.charset to another value that 
	/// is the name of a valid java.nio.charset.Charset.  If this property is set to "default", then 
	/// the system default is used. 
	/// 
	/// Copyright:    Copyright (c) 2001
	/// Company:      University Health Network
	/// </summary>
	/// <author>        Damian Horton; mods by Bryan Tripp
	/// </author>
	/// <version>  1.1
	/// </version>
	
	public class NuGenMinLLPWriter : NuGenHL7Writer
	{
		public const System.String CHARSET_KEY = "Genetibase.NuGenHL7.llp.charset";
		
		internal System.IO.StreamWriter myWriter; //reads from the input stream given in the
		//constructor
		internal bool messageStarted = false; //whether or not the necessary characters to
		//initialize the message have already been buffered
		
		private System.IO.Stream myOutputStream;
		
		/// <summary> Creates a MinLLPWriter with no output stream specified - <code>setOutputStream</code>
		/// must be called before attempting to write any messages. 
		/// </summary>
		public NuGenMinLLPWriter()
		{
		}
		
		/// <summary> Creates a MinLLPWriter, specifying the underlying output stream.</summary>
		public NuGenMinLLPWriter(System.IO.Stream out_Renamed)
		{
			setOutputStream(out_Renamed);
		}
		
		/// <summary> Sets the underlying output stream to which messages are written. </summary>
		public virtual void  setOutputStream(System.IO.Stream out_Renamed)
		{
			lock (this)
			{
				myOutputStream = out_Renamed;
				myWriter = new System.IO.StreamWriter(getWriter(out_Renamed).BaseStream, getWriter(out_Renamed).Encoding);
			}
		}
		
		/// <summary> Sends a complete message to the underlying output stream, delimited 
		/// according to the minimal lower layer protocol.  
		/// </summary>
		public virtual void  writeMessage(System.String message)
		{
			lock (this)
			{
				myWriter.Write((System.Char) '\u000b');
				myWriter.Write(message);
				myWriter.Write('\u001c' + "\r");
				myWriter.Flush();
			}
		}
		
		/// <summary> Sends a complete message to the underlying output stream, delimited 
		/// according to the minimal lower layer protocol, using the specified character set. 
		/// </summary>
		public virtual void  writeMessage(System.String message, System.String charset)
		{
			lock (this)
			{
				System.IO.StreamWriter writer = new System.IO.StreamWriter(new System.IO.StreamWriter(myOutputStream, System.Text.Encoding.GetEncoding(charset)).BaseStream, new System.IO.StreamWriter(myOutputStream, System.Text.Encoding.GetEncoding(charset)).Encoding);
				writer.Write((System.Char) '\u000b');
				writer.Write(message);
				writer.Write('\u001c' + "\r");
				writer.Flush();
			}
		}
		
		public virtual void  close()
		{
			lock (this)
			{
				myWriter.Close();
			}
		}
		
		private static System.IO.StreamWriter getWriter(System.IO.Stream theStream)
		{
			return new System.IO.StreamWriter(theStream, System.Text.Encoding.Default);
		}
	}
}