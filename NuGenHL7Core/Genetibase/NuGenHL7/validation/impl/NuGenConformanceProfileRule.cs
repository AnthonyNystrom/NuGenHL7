/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ConformanceProfileRule.java".  Description: 
/// "A MessageRule that checks conformance to message profiles." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2005.  All Rights Reserved. 
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
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
using DefaultValidator = Genetibase.NuGenHL7.conf.check.NuGenDefaultValidator;
using ProfileParser = Genetibase.NuGenHL7.conf.parser.NuGenProfileParser;
using RuntimeProfile = Genetibase.NuGenHL7.conf.spec.RuntimeProfile;
using ProfileStoreFactory = Genetibase.NuGenHL7.conf.store.ProfileStoreFactory;
using Message = Genetibase.NuGenHL7.model.Message;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
using MessageRule = Genetibase.NuGenHL7.validation.NuGenMessageRule;
using ValidationException = Genetibase.NuGenHL7.validation.NuGenValidationException;
namespace Genetibase.NuGenHL7.validation.impl
{
	
	/// <summary> A MessageRule that checks conformance to message profiles. Messges can either be tested 
	/// agaist the profiles they declare, or against a pre-defined profile. If you want both, 
	/// use two <code>ConformanceProfileRule</code>s.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.1 $ updated on $Date: 2005/06/27 21:28:52 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenConformanceProfileRule : NuGenMessageRule
	{
		/// <seealso cref="Genetibase.NuGenHL7.validation.Rule.getDescription()">
		/// </seealso>
		virtual public System.String Description
		{
			get
			{
				return "Checks conformance to declared or predefined message profiles";
			}
			
		}
		/// <seealso cref="Genetibase.NuGenHL7.validation.Rule.getSectionReference()">
		/// </seealso>
		virtual public System.String SectionReference
		{
			get
			{
				return "HL7 2.5 section 2.12";
			}
			
		}
		
		private System.String myProfileID;
		
		/// <summary> Creates an instance that tests messages against whatever profiles they declare in 
		/// MSH-21. 
		/// </summary>
		public NuGenConformanceProfileRule()
		{
		}
		
		/// <param name="theProfileID">the ID of a constant profile against which to test all messages
		/// (instead of the profiles they declare in MSH-21) 
		/// </param>
		public NuGenConformanceProfileRule(System.String theProfileID)
		{
			myProfileID = theProfileID;
		}
		
		
		/// <seealso cref="Genetibase.NuGenHL7.validation.MessageRule.test(Genetibase.NuGenHL7.model.Message)">
		/// </seealso>
		public virtual NuGenValidationException[] test(Message msg)
		{
			System.Collections.ArrayList problems = new System.Collections.ArrayList(20);
			System.String[] ids = new System.String[]{myProfileID};
			
			try
			{
				if (myProfileID == null)
				{
					ids = getDeclaredProfileIDs(msg);
				}
				
				for (int i = 0; i < ids.Length; i++)
				{
					try
					{
						NuGenValidationException[] shortList = testAgainstProfile(msg, ids[i]);
						for (int j = 0; j < shortList.Length; j++)
						{
							problems.Add(shortList[j]);
						}
					}
					catch (ProfileException e)
					{
						problems.Add(new NuGenValidationException("Can't validate", e));
					}
				}
			}
			catch (NuGenHL7Exception e)
			{
				problems.Add(new NuGenValidationException("Can't validate", e));
			}

            NuGenValidationException[] retVal = new NuGenValidationException[problems.Count];
            problems.CopyTo(retVal);

            return retVal;
		}
		
		private System.String[] getDeclaredProfileIDs(Message theMessage)
		{
			Terser t = new Terser(theMessage);
			bool noMore = false;
			int c = 0;
			System.Collections.ArrayList declaredProfiles = new System.Collections.ArrayList(8);
			while (!noMore)
			{
				System.String path = "MSH-21(" + c++ + ")";
				System.String idRep = t.get_Renamed(path);
				//FIXME fails if empty rep precedes full rep ... should add getAll() to Terser and use that
				if (idRep == null || idRep.Equals(""))
				{
					noMore = true;
				}
				else
				{
					declaredProfiles.Add(idRep);
				}
			}

            String[] retVal = new String[declaredProfiles.Count];
            declaredProfiles.CopyTo(retVal);

            return retVal;
		}
		
		private NuGenValidationException[] testAgainstProfile(Message message, System.String id)
		{
			NuGenHL7Exception[] exceptions = null;
			DefaultValidator val = new DefaultValidator();
			try
			{
				System.String profileString = ProfileStoreFactory.ProfileStore.getProfile(id);
				if (profileString != null)
				{
					ProfileParser profParser = new ProfileParser(true);
					RuntimeProfile profile = profParser.parse(profileString);
					
					exceptions = val.validate(message, profile.Message);
				}
				else
				{
					throw new ProfileException("Unable to find the profile " + id);
				}
			}
			catch (System.IO.IOException e)
			{
				throw new ProfileException("Error retreiving profile " + id, e);
			}
			
			NuGenValidationException[] result = new NuGenValidationException[exceptions.Length];
			for (int i = 0; i < exceptions.Length; i++)
			{
				result[i] = new NuGenValidationException(exceptions[i].Message, exceptions[i]);
			}
			return result;
		}
		static NuGenConformanceProfileRule()
		{
		}
	}
}