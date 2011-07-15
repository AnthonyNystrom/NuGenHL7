/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ReceivingApplicationException.java".  Description: 
/// "Represents any problem encountered during processing of a message by a 
/// ReceivingApplication" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2002, 2005.  All Rights Reserved. 
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
namespace Genetibase.NuGenHL7.protocol
{
	
	/// <summary> Represents any problem encountered during processing of a message by a 
	/// <code>ReceivingApplication</code>.
	/// 
	/// Note that this replaces Genetibase.NuGenHL7.app.ApplicationException in HAPI 0.5.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2005/05/16 16:51:10 $ by $Author: bryan_tripp $
	/// </version>
	[Serializable]
	public class NuGenReceivingApplicationException:System.Exception
	{
		
		/// <summary> Constructs an instance of <code>ReceivingApplicationException</code> with the specified detail message.</summary>
		public NuGenReceivingApplicationException(System.String msg):base(msg)
		{
		}
		
		/// <summary> Constructs a new exception with the specified underlying cause.
		/// 
		/// </summary>
		/// <param name="cause">an exception that is the reason for this exception
		/// </param>
		public NuGenReceivingApplicationException(System.Exception cause):base(cause.Message, cause)
		{
		}
		
		/// <summary> Constructs a new exception with the specified underlying cause
		/// and detail message.
		/// 
		/// </summary>
		/// <param name="msg">detail message 
		/// </param>
		/// <param name="cause">an exception that is the reason for this exception
		/// </param>
		public NuGenReceivingApplicationException(System.String msg, System.Exception cause):base(msg, cause)
		{
		}
	}
}