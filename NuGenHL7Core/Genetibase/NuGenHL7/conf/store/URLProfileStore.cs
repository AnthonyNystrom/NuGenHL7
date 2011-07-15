/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "URLProfileStore.java".  Description:
/// "A read-only profile store that loads profiles from URLs."
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2003.  All Rights Reserved.
/// 
/// Contributor(s): ______________________________________.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
namespace Genetibase.NuGenHL7.conf.store
{
	
	/// <summary> A read-only profile store that loads profiles from URLs.  The URL 
	/// for a profile is determined by the method getURL().  An 
	/// attempt is also made to write 
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public abstract class URLProfileStore : ProfileStore
	{
		
		/// <summary>Creates a new instance of URLProfileStore </summary>
		public URLProfileStore()
		{
		}
		
		/// <summary>Retrieves profile from persistent storage (by ID).</summary>
		public virtual System.String getProfile(System.String ID)
		{
			System.String profile = null;
			try
			{
				System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(System.Net.WebRequest.Create(getURL(ID)).GetResponse().GetResponseStream(), System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(System.Net.WebRequest.Create(getURL(ID)).GetResponse().GetResponseStream(), System.Text.Encoding.Default).CurrentEncoding);
				System.Text.StringBuilder buf = new System.Text.StringBuilder();
				int c = - 1;
				while ((c = in_Renamed.Read()) != - 1)
				{
					buf.Append((char) c);
				}
				in_Renamed.Close();
				profile = buf.ToString();
			}
			catch (System.UriFormatException e)
			{
				throw new System.IO.IOException("MalformedURLException: " + e.Message);
			}
			return profile;
		}
		
		/// <summary>Stores profile in persistent storage with given ID.</summary>
		public virtual void  persistProfile(System.String ID, System.String profile)
		{
			throw new System.IO.IOException("Can't persist profile -- this profile store is read-only");
		}
		
		/// <summary> Returns the URL from which to read a profile given the profile ID.  For example
		/// given "123" it could return ftp://hospital_x.org/hl7/123.xml, or 
		/// http://hl7_conformance_service.com?profile=123.  
		/// </summary>
		public abstract System.Uri getURL(System.String ID);
	}
}