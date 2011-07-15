/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "MinLowerLayerProtocol.java".  Description: 
/// "Implements the "Minimal Lower Layer Protocol" from the HL7 Implementation 
/// Guide, Appendix C" 
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
	
	/// <summary> Implements the "Minimal Lower Layer Protocol" from the HL7 Implementation 
	/// Guide, Appendix C.  In other words, provides a reader and a writer that can be 
	/// used to communicate with a server that uses the minimal LLP.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenMinLowerLayerProtocol:NuGenLowerLayerProtocol
	{
		
		
		/// <summary> Creates new MinLowerLayerProtocol </summary>
		public NuGenMinLowerLayerProtocol()
		{
		}
		
		/// <summary> Creates an HL7Reader that implements message reading according to 
		/// this protocol.  
		/// </summary>
		public override NuGenHL7Reader getReader(System.IO.Stream in_Renamed)
		{
			try
			{
				return new NuGenMinLLPReader(in_Renamed);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenLLPException("Can't create MinLLPReader with the given input stream: " + e.Message, e);
			}
		}
		
		/// <summary> Creates an HL7Writer that implements message writing according to 
		/// this protocol.  
		/// </summary>
		public override NuGenHL7Writer getWriter(System.IO.Stream out_Renamed)
		{
			try
			{
				return new NuGenMinLLPWriter(out_Renamed);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenLLPException("Can't create MinLLPWriter with the given output stream: " + e.Message, e);
			}
		}
	}
}