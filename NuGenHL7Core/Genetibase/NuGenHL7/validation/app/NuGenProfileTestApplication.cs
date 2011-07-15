using System;
using Genetibase.NuGenHL7.model;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ValidationException = Genetibase.NuGenHL7.validation.NuGenValidationException;
using ConformanceProfileRule = Genetibase.NuGenHL7.validation.impl.NuGenConformanceProfileRule;
namespace Genetibase.NuGenHL7.validation.app
{
	
	/// <summary> <p>Tests messages against conformance profiles.  A constant profile
	/// can be used, or each message can be tested against the profiles
	/// that it declares.</p>
	/// <p>Note that profiles are referenced by ID, and that the Genetibase.NuGenHL7.conf.store
	/// package is used to get the actual profiles. </p>
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenProfileTestApplication:NuGenTestApplication
	{
		virtual public System.String ProfileID
		{
			get
			{
				return this.profileID;
			}
			
		}
		
		private System.String profileID;
		private ConformanceProfileRule rule;
		
		/// <summary> Creates a new instance of ProfileTestApplication that tests using profiles 
		/// declared in each message (if any)
		/// </summary>
		public NuGenProfileTestApplication()
		{
			rule = new ConformanceProfileRule();
		}
		
		/// <summary> Creates a new instance of ProfileTestApplication.</summary>
		/// <param name="profileID">the ID of the profile against which to test messages;
		/// null means use profiles declared in the message (if any)
		/// </param>
		public NuGenProfileTestApplication(System.String profileID)
		{
			this.profileID = profileID;
			rule = new ConformanceProfileRule(profileID);
		}
		
		/// <summary> Returns true if this Application wishes to accept the message.  By returning
		/// true, this Application declares itself the recipient of the message, accepts
		/// responsibility for it, and must be able to respond appropriately to the sending system.
		/// </summary>
		public override bool canProcess(Message in_Renamed)
		{
			return true;
		}
		
		/// <summary> Tests the message against a profile or profiles.  A constant profile
		/// is used if one was provided to the constructor, otherwise any profiles
		/// declared in the message are used.
		/// </summary>
		public override NuGenHL7Exception[] test(Message in_Renamed)
		{
			NuGenValidationException[] errors = rule.test(in_Renamed);
			
			NuGenHL7Exception[] result = new NuGenHL7Exception[errors.Length];
			for (int i = 0; i < errors.Length; i++)
			{
                System.Exception t = errors[i].InnerException;
				if ((t != null) && (t is NuGenHL7Exception))
				{
					result[i] = (NuGenHL7Exception) t;
				}
				else
				{
					result[i] = new NuGenHL7Exception(errors[i]);
				}
			}
			
			return result;
		}
		static NuGenProfileTestApplication()
		{
		}
	}
}