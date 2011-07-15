using System;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> <p>Handles output of status messages.  Authors are encouraged to provide status 
	/// information using the methods: </p>
	/// <p><code>writeStatus(String message);<br>
	/// writeVerboseStatus(String message);</code></p>
	/// <p>... instead of using <code>System.out.println(...)</code>.  This allows the user
	/// to control the output of status messages in one place. </p>
	/// <p>By default, messages are written to std out, and only "standard" messages are 
	/// written (i.e. from calls to <code>writeStatus()</code>, not <code>writeVerboseStatus()</code>).
	/// This can be changed at startup by setting the following system properties: </p>
	/// <p>Genetibase.NuGenHL7.util.status.out = ["STANDARD_OUT" | "FILE"]<br>
	/// Genetibase.NuGenHL7.util.status.level = ["NONE" | "STANDARD" | "VERBOSE"]</p>
	/// <p>If a programmer wishes to log status messages more reliably and without user control, (s)he
	/// should use <code>Genetibase.NuGenHL7.Log</code> instead.</p>
	/// 
	/// </summary>
	/// <deprecated> use ca.uhn.log package
	/// </deprecated>
	/// <author>  Bryan Tripp
	/// 
	/// </author>
	public class NuGenStatus
	{
		/// <summary> Sets the location where status messages are output.  Valid values include 
		/// Status.STANDARD_OUT (std out) and Status.FILE (messages output to <hapi.home>/status.log)
		/// </summary>
		virtual public int Output
		{
			set
			{
				lock (this)
				{
					if (value == NuGenStatus.STANDARD_OUT || value == NuGenStatus.FILE)
					{
						this.dest = value;
						if (dest == NuGenStatus.STANDARD_OUT)
						{
							System.Console.Out.WriteLine("Outputting status messages to standard out.");
						}
						else
						{
							System.String file = NuGenHome.getHomeDirectory().FullName + "/status.log";
							System.Console.Out.WriteLine("Outputting status messages to the file " + file);
							try
							{
								this.fileOut = new System.IO.StreamWriter(new System.IO.StreamWriter(file, true, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(file, true, System.Text.Encoding.Default).Encoding);
							}
							catch (System.IO.IOException)
							{
								System.Console.Error.WriteLine("Couldn't open file status.log for status output - using std out instead.");
								this.dest = NuGenStatus.STANDARD_OUT;
							}
						}
					}
				}
			}
			
		}
		/// <summary> Sets the level of detail of status messages.  Valid values include 
		/// Status.NONE, Status.STANDARD, and Status.VERBOSE (detailed).
		/// </summary>
		virtual public int Verbosity
		{
			set
			{
				lock (this)
				{
					if (value == NuGenStatus.NONE || value == NuGenStatus.STANDARD || value == NuGenStatus.VERBOSE)
					{
						this.detail = value;
						if (detail == NuGenStatus.NONE)
						{
							System.Console.Out.WriteLine("Genetibase.NuGenHL7.util.Status: No status messages will be output.");
						}
						else if (detail == NuGenStatus.STANDARD)
						{
							System.Console.Out.WriteLine("Genetibase.NuGenHL7.util.Status: Standard status messages will be output.");
						}
						else
						{
							System.Console.Out.WriteLine("Genetibase.NuGenHL7.util.Status: Verbose status messages will be output.");
						}
					}
				}
			}
			
		}
		
		private int dest = 0;
		private int detail = 0;
		private System.IO.StreamWriter fileOut;
		
		private static NuGenStatus singleton = null;
		
		/// <summary> Used as an argument to setOutput(), causes status information to be printed 
		/// to standard out.
		/// </summary>
		public const int STANDARD_OUT = 1;
		
		/// <summary> Used as an argument to setOutput(), causes status information to be printed 
		/// to the file "status.log" in the working directory. 
		/// </summary>
		public const int FILE = 2;
		
		/// <summary> Used as an argument to setVerbosity(), causes no status information to 
		/// be output.  
		/// </summary>
		public const int NONE = 3;
		
		/// <summary> Used as an argument to setVerbosity(), causes standard status information to 
		/// be output.  
		/// </summary>
		public const int STANDARD = 4;
		
		/// <summary> Used as an argument to setVerbosity(), causes detailed status information to 
		/// be output.  
		/// </summary>
		public const int VERBOSE = 5;
		
		/// <summary> Creates a new instance of Status </summary>
		private NuGenStatus()
		{
			/*PETETODO::CHECK PROPERTIES//check system properties for configuration info
			System.String out_Renamed = System_Renamed.getProperty("Genetibase.NuGenHL7.util.status.out");
			System.String level = System_Renamed.getProperty("Genetibase.NuGenHL7.util.status.level");
			
			if (out_Renamed != null && out_Renamed.Equals("FILE"))
			{
				Output = Status.FILE;
			}
			else
			{
				Output = Status.STANDARD_OUT;
			}
			
			if (level != null && level.Equals("NONE"))
			{
				Verbosity = Status.NONE;
			}
			else if (level != null && level.Equals("VERBOSE"))
			{
				Verbosity = Status.VERBOSE;
			}
			else
			{
				Verbosity = Status.STANDARD;
			}*/
		}
		
		/// <summary> Outputs a standard status message as per configuration. </summary>
		public static void  writeStatus(System.String message)
		{
			if (singleton == null)
			{
				//initialize instance
				singleton = new NuGenStatus();
			}
			
			singleton.writeStatus(message, false);
		}
		
		/// <summary> Outputs a detail status message as per configuration. </summary>
		public static void  writeVerboseStatus(System.String message)
		{
			if (singleton == null)
			{
				//initialize instance
				singleton = new NuGenStatus();
			}
			
			singleton.writeStatus(message, true);
		}
		
		/// <summary> Should be called only through static method of same name.</summary>
		private void  writeStatus(System.String message, bool verbose)
		{
			lock (this)
			{
				bool output = true;
				if (this.detail == NuGenStatus.NONE || (verbose && this.detail != NuGenStatus.VERBOSE))
					output = false;
				
				System.Globalization.GregorianCalendar now = new System.Globalization.GregorianCalendar();
				SupportClass.CalendarManager.manager.SetDateTime(now, System.DateTime.Now);
				System.Text.StringBuilder mess = new System.Text.StringBuilder();
				mess.Append(SupportClass.CalendarManager.manager.Get(now, SupportClass.CalendarManager.DAY_OF_MONTH));
				mess.Append("/");
				mess.Append(SupportClass.CalendarManager.manager.Get(now, SupportClass.CalendarManager.MONTH + 1));
				mess.Append("/");
				mess.Append(SupportClass.CalendarManager.manager.Get(now, SupportClass.CalendarManager.YEAR));
				mess.Append(" ");
				mess.Append(SupportClass.CalendarManager.manager.Get(now, SupportClass.CalendarManager.HOUR_OF_DAY));
				mess.Append(":");
				mess.Append(SupportClass.CalendarManager.manager.Get(now, SupportClass.CalendarManager.MINUTE));
				mess.Append(":");
				mess.Append(SupportClass.CalendarManager.manager.Get(now, SupportClass.CalendarManager.SECOND));
				mess.Append(".");
				mess.Append(SupportClass.CalendarManager.manager.Get(now, SupportClass.CalendarManager.MILLISECOND));
				mess.Append("  ");
				mess.Append(message);
				
				if (output)
				{
					if (this.dest == NuGenStatus.STANDARD_OUT)
					{
						System.Console.Out.WriteLine(mess.ToString());
					}
					else
					{
						try
						{
							this.fileOut.Write(mess.ToString());
							this.fileOut.Write("\r\n");
							this.fileOut.Flush();
						}
						catch (System.IO.IOException e)
						{
							System.Console.Error.WriteLine("Error writing status message to file: " + e.Message);
							System.Console.Out.WriteLine(mess.ToString());
						}
					}
				}
			}
		}
	}
}