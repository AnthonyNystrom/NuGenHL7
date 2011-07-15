/*
The contents of this file are subject to the Mozilla Public License Version 1.1 
(the "License"); you may not use this file except in compliance with the License. 
You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
Software distributed under the License is distributed on an "AS IS" basis, 
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
specific language governing rights and limitations under the License. 

The Original Code is "ReaderThread.java".  Description: 
"read from a Reader into a char[] buffer" 

The Initial Developer of the Original Code is University Health Network. Copyright (C) 
2004.  All Rights Reserved. 

Contributor(s): ______________________________________. 

Alternatively, the contents of this file may be used under the terms of the 
GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
applicable instead of those above.  If you wish to allow use of your version of this 
file only under the terms of the GPL and not to allow others to use your version 
of this file under the MPL, indicate your decision by deleting  the provisions above 
and replace  them with the notice and other provisions required by the GPL License.  
If you do not delete the provisions above, a recipient may use your version of 
this file under either the MPL or the GPL. */
using System;
namespace Genetibase.NuGenHL7.protocol.impl
{
	
	/// <summary> The class <code> ReaderThread </code> read from a Reader into a char[] buffer.
	/// 
	/// </summary>
	/// <author>   Alexei Guevara <mailto:alexei.guevara@uhn.on.ca/>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2004/06/01 20:11:38 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenReaderThread:SupportClass.ThreadClass
	{
		private System.IO.StreamReader myReader;
		private char[] myBuffer;
		private NuGenIntRef myBytesReadRef;
		
		/// <summary> Creates a new instance
		/// 
		/// </summary>
		/// <param name="theReader">the reader for this thread
		/// </param>
		/// <param name="theBuffer">the buffer for reading
		/// </param>
		/// <param name="theBytesReadRef">stores the number of bytes read
		/// </param>
		public NuGenReaderThread(System.IO.StreamReader theReader, char[] theBuffer, NuGenIntRef theBytesReadRef)
		{
			this.myReader = theReader;
			this.myBuffer = theBuffer;
			this.myBytesReadRef = theBytesReadRef;
		}
		
		/// <seealso cref="java.lang.Runnable.run()">
		/// </seealso>
		override public void  Run()
		{
			try
			{
				int _bytesRead = myReader.Read((System.Char[]) myBuffer, 0, myBuffer.Length);
				
				myBytesReadRef.Value = _bytesRead;
			}
			catch (System.IO.IOException)
			{
			}
		}
		static NuGenReaderThread()
		{
		}
	}
}