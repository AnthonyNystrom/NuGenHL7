using System;
using Genetibase.NuGenHL7.model;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.validation.app
{
	
	/// <summary> A composite test application that delegates to multiple other test applications 
	/// and returns a combined list of problems.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenMultiTestApplication:NuGenTestApplication
	{
		
		private System.Collections.ArrayList tests;
		
		/// <summary>Creates a new instance of MultiTestApplication </summary>
		public NuGenMultiTestApplication()
		{
			tests = new System.Collections.ArrayList(20);
		}
		
		/// <summary> Returns true if ANY of the delegates can accept the message.  </summary>
		public override bool canProcess(Message in_Renamed)
		{
			bool can = false;
			for (int i = 0; !can && i < tests.Count; i++)
			{
				can = ((NuGenTestApplication) tests[i]).canProcess(in_Renamed);
			}
			return can;
		}
		
		/// <summary>Tests the message by passing it to all test apps that have been registered 
		/// using addTest().  
		/// </summary>
		/// <returns> exceptions that describe any identified problems with the message
		/// </returns>
		public override NuGenHL7Exception[] test(Message in_Renamed)
		{
			System.Collections.ArrayList problems = new System.Collections.ArrayList(40);
			for (int i = 0; i < tests.Count; i++)
			{
				NuGenTestApplication app = (NuGenTestApplication) tests[i];
				NuGenHL7Exception[] shortList = app.test(in_Renamed);
				for (int j = 0; j < shortList.Length; j++)
				{
					problems.Add(shortList[i]);
				}
			}

            NuGenHL7Exception[] retVal = new NuGenHL7Exception[problems.Count];
            problems.CopyTo(retVal);

            return retVal;
		}
		
		/// <summary> Registers a test app so that messages will be tested against it.</summary>
		public virtual void  addTest(NuGenTestApplication test)
		{
			tests.Add(test);
		}
	}
}