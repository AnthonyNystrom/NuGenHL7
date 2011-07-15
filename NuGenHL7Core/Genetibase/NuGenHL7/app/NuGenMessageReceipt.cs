/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "MessageReceipt.java".  Description:
/// "Returned by Connection.reserveResponse() when calling 
/// classes want to wait for a particular response message."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2002.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// </summary>
using System;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> Returned by <code>Connection.reserveResponse()</code> when calling 
	/// classes want to wait for a particular response message.  
	/// When the response is returned by the remote system it is available here.  
	/// MessageReceipt.notifyAll() is called when the message arrives, so it 
	/// is good practice to wait() on a MessageReceipt.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenMessageReceipt
	{
		/// <summary>Returns the message text if it has arrived, otherwise null. </summary>
		/// <summary>Sets the text of the message and notifies waiting threads. </summary>
		virtual public System.String Message
		{
			get
			{
				lock (this)
				{
					return message;
				}
			}
			
			set
			{
				lock (this)
				{
					message = value;
					System.Threading.Monitor.PulseAll(this);
				}
			}
			
		}
		internal System.String message = null;
	}
}