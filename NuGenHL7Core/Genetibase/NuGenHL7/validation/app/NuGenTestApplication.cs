using System;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
using Genetibase.NuGenHL7.model;
using PipeParser = Genetibase.NuGenHL7.parser.NuGenPipeParser;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.validation.app
{
	
	/// <summary> An application intended for testing messages.  The intended use is to route a copy 
	/// of (selected) messages to a test application, which identifies and acts on problems independently 
	/// of the normal error acknowledgement path (for example by notifying an administrator).  
	/// This makes the most sense when used within an interface engine, for example if the 
	/// sending nor receiving system use HAPI, but it is desired to route messages to HAPI in 
	/// parallel so that they can be fully validated.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public abstract class NuGenTestApplication : Genetibase.NuGenHL7.app.NuGenApplication
	{
		
		private PipeParser parser;
		
		/// <summary>Creates a new instance of TestApplication </summary>
		public NuGenTestApplication()
		{
			parser = new PipeParser();
		}
		
		/// <summary> Returns true if this Application wishes to accept the message.  By returning
		/// true, this Application declares itself the recipient of the message, accepts
		/// responsibility for it, and must be able to respond appropriately to the sending system.
		/// </summary>
		public abstract bool canProcess(Message in_Renamed);
		
		
		/// <summary> <p>Calls test(Message in), routes resulting exceptions to configured destinations, and 
		/// returns an ack (which should not normally be used since the test app is intended 
		/// to operate in parallel with system-to-system communication).  </p>
		/// config file (by default, ./log4j.properties).  Different types of exceptions 
		/// are all given the same severity (ERROR) but they have different loggers, based 
		/// on the exception class name.  Specifically, the loggers will be named 
		/// Genetibase.NuGenHL7.validation.error.{exception class name}.  For example: 
		/// "Genetibase.NuGenHL7.validation.error.DataTypeException".  Note that this allows default 
		/// The intent is for different exceptions to result in different actions, e.g. a 
		/// ProfileNotHL7CompliantException should probably just be logged or ignored, while a
		/// ProfileNotFollowedException should probably be emailed to an administrator. </p>
		/// </summary>
		public virtual Message processMessage(Message in_Renamed)
		{
			System.String context = null;
			try
			{
				context = this.parser.encode(in_Renamed);
			}
			catch (NuGenHL7Exception)
			{
				context = "message not encodable";
			}
			
			NuGenHL7Exception[] problems = test(in_Renamed);
			sendNotifications(problems);
			
			Message ack = null;
			try
			{
				ack = Genetibase.NuGenHL7.app.NuGenDefaultApplication.makeACK((Segment) in_Renamed.get_Renamed("MSH"));
				addProblemsToACK(ack, problems);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenHL7Exception(e);
			}
			return ack;
		}
		
		/// <summary> <p>Send notification of problems to specified destinations (e.g. log file, email).  </summary>
		private void  sendNotifications(NuGenHL7Exception[] problems)
		{
			for (int i = 0; i < problems.Length; i++)
			{
				System.String exName = problems[i].GetType().FullName;
				System.String logName = "Genetibase.NuGenHL7.validation.error" + exName.Substring(exName.LastIndexOf('.'));
			}
		}
		
		private void  addProblemsToACK(Message ack, NuGenHL7Exception[] problems)
		{
			Terser t = new Terser(ack);
			
			if (problems.Length > 0)
			{
				t.set_Renamed("MSA-1", "AE");
				t.set_Renamed("MSA-3", "Errors were encountered while testing the message");
			}
			
			Segment err = (Segment) ack.get_Renamed("ERR");
			for (int i = 0; i < problems.Length; i++)
			{
				problems[i].populate(err);
			}
		}
		
		/// <summary> Tests the message in some way (as defined by implementing class).  </summary>
		/// <returns> exceptions that describe any identified problems with the message 
		/// </returns>
		/// <throws>  HL7Exception if the message can't be tested (not for errors disovered </throws>
		/// <summary>      during testing)
		/// </summary>
		public abstract NuGenHL7Exception[] test(Message in_Renamed);
	}
}