/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "LLPException.java".  Description: 
/// "Represents a problem encountered while using a Lower Layer Protocol" 
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
/// </summary>
using System;
namespace Genetibase.NuGenHL7.llp
{
	
	/// <summary> Represents a problem encountered while using a Lower Layer Protocol.  This exception  
	/// serves to wrap the wide variety of other exceptions that might be encountered with 
	/// various protocols.  
	/// </summary>
	/// <author>   Bryan Tripp
	/// </author>
	[Serializable]
	public class NuGenLLPException:System.Exception
	{
		/// <summary> Returns the embedded exception (if any) - this  
		/// would normally represent the underlying cause of this LLPException.  For example, 
		/// an UnsupportedEncodingException may be raised in a MinLowerLayerProtocol - if this  
		/// happened the MinLowerLayerProtocol would throw an LLPException, wrapping the original 
		/// UnsupportedEncodingException, and a call to <code>getException()</code> would return
		/// the UnsupportedEncodingException.  
		/// </summary>
		virtual public System.Exception Exception
		{
			get
			{
				return this.embeddedException;
			}
			
		}
		
		private System.Exception embeddedException;
		/// <summary> Constructs an <code>LLPException</code> with the specified detail message.</summary>
		/// <param name="msg">the detail message.
		/// </param>
		public NuGenLLPException(System.String msg):base(msg)
		{
		}
		
		/// <summary> Constructs an <code>LLPException</code> with the specified detail message 
		/// and embedded exception.  
		/// </summary>
		/// <param name="msg">the detail message.
		/// </param>
		/// <param name="e">an embedded exception (should normally represent the cause of the LLPException)
		/// </param>
		public NuGenLLPException(System.String msg, System.Exception e):base(msg)
		{
			this.embeddedException = e;
		}
	}
}