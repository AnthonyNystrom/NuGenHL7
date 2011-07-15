using System;
using Genetibase.NuGenHL7.parser;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
namespace Genetibase.NuGenHL7.util
{
	
	/// <summary> Tests correctness of message parsing by testing equivalence of re-encoded
	/// form with original.
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenParseTester
	{
		/// <summary> Sets the source of message data (messages must be delimited by blank lines)</summary>
		virtual public System.IO.StreamReader Source
		{
			set
			{
				this.source = new System.IO.StreamReader(new CommentFilterReader(value).BaseStream, new CommentFilterReader(value).CurrentEncoding);
			}
			
		}
		/// <summary> Sets a description of the context of the messages (e.g. file name) that can be 
		/// reported within error messages.  
		/// </summary>
		virtual public System.String Context
		{
			set
			{
				this.context = value;
			}
			
		}
		/// <summary> Retrieves the next message (setSource() must be called first).  The next message
		/// is interpreted as everything up to the next blank line, not including
		/// C or C++ style comments (or blank lines themselves).  An empty string
		/// indicates that there are no more messages.
		/// </summary>
		virtual public System.String NextMessage
		{
			get
			{
				if (this.source == null)
					throw new System.IO.IOException("Message source is null -- call setSource() first");
				
				System.Text.StringBuilder message = new System.Text.StringBuilder();
				bool started = false; //got at least one non-blank line
				bool finished = false; //got a blank line after started, or end of stream
				while (!finished)
				{
					System.String line = this.source.ReadLine();
					if (line == null || (started && line.Trim().Length == 0))
					{
						finished = true;
					}
					else
					{
						if (line.Trim().Length > 0)
						{
							started = true;
							message.Append(line);
							message.Append("\r");
						}
					}
				}
				if (message.ToString().Trim().Length == 0)
				{
					return "";
				}
				else
				{
					return message.ToString(); // can't trim by default (will omit final end-segment)
				}
			}
			
		}
		
		private static NuGenGenericParser parser = new NuGenGenericParser();
		private System.IO.StreamReader source;
		private System.String context;
		
		/// <summary>Creates a new instance of ParseTester </summary>
		public NuGenParseTester()
		{
		}
		
		/// <summary> Checks whether the given message parses correctly with a GenericParser.
		/// Failure indicates that the parsed and re-encoded message is semantically
		/// different than the original, or that the message could not be parsed.  This 
		/// may stem from an error in the parser, or from an error in the message.  This 
		/// may also arise from unexpected message components (e.g. Z-segments) although 
		/// in future HAPI versions these will be parsed as well.
		/// </summary>
		/// <param name="message">an XML or ER7 encoded message string
		/// </param>
		/// <returns> null if it parses correctly, an HL7Exception otherwise
		/// </returns>
		public static NuGenHL7Exception parsesCorrectly(System.String context, System.String message)
		{
			NuGenHL7Exception problem = null;
			try
			{
				Message m = parser.parse(message);
				System.String encoding = parser.getEncoding(message);
				System.String result = parser.encode(m, encoding);
				if (!NuGenEncodedMessageComparator.equivalent(message, result))
				{
					problem = new NuGenHL7Exception(context + ": Original differs semantically from parsed/encoded message.\r\n-----Original:------------\r\n" + message + " \r\n------ Parsed/Encoded: ----------\r\n" + result + " \r\n-----Original Standardized: ---------\r\n" + NuGenEncodedMessageComparator.standardize(message) + " \r\n---------------------\r\n");
				}
			}
			catch (System.Exception e)
			{
				problem = new NuGenHL7Exception(context + ": " + e.Message + " in message: \r\n-------------\r\n" + message + "\r\n-------------");
				;
			}
			return problem;
		}
		
		/// <summary> Sets the source reader to point to the given file, and tests
		/// all the messages therein (if a directory, processes all contained
		/// files recursively).
		/// </summary>
		public virtual NuGenHL7Exception[] testAll(System.IO.FileInfo source)
		{
			System.Collections.ArrayList list = new System.Collections.ArrayList();
			System.Console.Out.WriteLine("Testing " + source.FullName);
			if (System.IO.Directory.Exists(source.FullName))
			{
				System.IO.FileInfo[] contents = SupportClass.FileSupport.GetFiles(source);
				for (int i = 0; i < contents.Length; i++)
				{
					NuGenHL7Exception[] exceptions = testAll(contents[i]);
					for (int j = 0; j < exceptions.Length; j++)
					{
						list.Add(exceptions[j]);
					}
				}
			}
			else if (System.IO.File.Exists(source.FullName))
			{
				System.IO.StreamReader in_Renamed = new System.IO.StreamReader(source.FullName, System.Text.Encoding.Default);
				Source = in_Renamed;
				Context = source.FullName;
				NuGenHL7Exception[] exceptions = testAll();
				for (int i = 0; i < exceptions.Length; i++)
				{
					list.Add(exceptions[i]);
				}
			}
			else
			{
				System.Console.Out.WriteLine("Warning: " + source.FullName + " is not a normal file");
			}

            NuGenHL7Exception[] retVal = new NuGenHL7Exception[list.Count];
            list.CopyTo(retVal);

            return retVal;
		}
		
		/// <summary> Tests all remaining messages available from the currrent source.</summary>
		public virtual NuGenHL7Exception[] testAll()
		{
			System.Collections.ArrayList list = new System.Collections.ArrayList();
			
			System.String message = null;
			while ((message = NextMessage).Length > 0)
			{
				NuGenHL7Exception e = parsesCorrectly(this.context, message);
				if (e != null)
					list.Add(e);
			}

            NuGenHL7Exception[] retVal = new NuGenHL7Exception[list.Count];
            list.CopyTo(retVal);

            return retVal;
		}
		
		/// <summary> Command line tool for testing messages in files.</summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length != 1 || args[0].ToUpper().Equals("-?".ToUpper()) || args[0].ToUpper().Equals("-h".ToUpper()) || args[0].ToUpper().Equals("-help".ToUpper()))
			{
				System.Console.Out.WriteLine("USAGE:");
				System.Console.Out.WriteLine("  ParseTester <source>");
				System.Console.Out.WriteLine();
				System.Console.Out.WriteLine("  <source> must be either a file containing HL7 messages or a directory containing such files");
				System.Console.Out.WriteLine();
				System.Console.Out.WriteLine("Notes:");
				System.Console.Out.WriteLine(" - Messages can be XML or ER7 encoded. ");
				System.Console.Out.WriteLine(" - If there are multiple messages in a file they must be delimited by blank lines");
				System.Console.Out.WriteLine(" - C and C++ style comments are skipped");
			}
			else
			{
				try
				{
					System.Console.Out.WriteLine("Testing ... ");
					System.IO.FileInfo source = new System.IO.FileInfo(args[0]);
					NuGenParseTester tester = new NuGenParseTester();
					NuGenHL7Exception[] exceptions = tester.testAll(source);
					if (exceptions.Length > 0)
						System.Console.Out.WriteLine("Parsing problems with tested messages: ");
					for (int i = 0; i < exceptions.Length; i++)
					{
						System.Console.Out.WriteLine("PROBLEM #" + (i + 1));
						System.Console.Out.WriteLine(exceptions[i].Message);
					}
				}
				catch (System.IO.IOException e)
				{
					System.Console.Out.WriteLine("Testing failed to complete because of a problem reading source file(s) ... \r\n");
					SupportClass.WriteStackTrace(e, Console.Error);
				}
			}
		}
		
		/// <summary> Removes C and C++ style comments from a reader stream.  C style comments are
		/// distinguished from URL protocol delimiters by the preceding colon in the
		/// latter.
		/// </summary>
		public class CommentFilterReader:SupportClass.BackReader
		{
			
			private char[] startCPPComment = new char[]{'/', '*'};
			private char[] endCPPComment = new char[]{'*', '/'};
			private char[] startCComment = new char[]{'/', '/'};
			private char[] endCComment = new char[]{'\n'};
			private char[] protocolDelim = new char[]{':', '/', '/'};
			
			public CommentFilterReader(System.IO.StreamReader in_Renamed):base(in_Renamed.BaseStream, 5, in_Renamed.CurrentEncoding)
			{
			}
			
			/// <summary> Returns the next character, not including comments.</summary>
			public int read()
			{
				if (atSequence(protocolDelim))
				{
					//proceed normally
				}
				else if (atSequence(startCPPComment))
				{
					//skip() doesn't seem to work for some reason
					while (!atSequence(endCPPComment))
						base.Read();
					for (int i = 0; i < endCPPComment.Length; i++)
						base.Read();
				}
				else if (atSequence(startCComment))
				{
					while (!atSequence(endCComment))
						base.Read();
					for (int i = 0; i < endCComment.Length; i++)
						base.Read();
				}
				return base.Read();
			}
			
			public int read(char[] cbuf, int off, int len)
			{
				int i = - 1;
				bool done = false;
				while (++i < len)
				{
					int next = read();
					if (next == 65535 || next == - 1)
					{
						//Pushback causes -1 to convert to 65535
						done = true;
						break;
					}
					cbuf[off + i] = (char) next;
				}
				if (i == 0 && done)
					i = - 1;
				return i;
			}
			
			/// <summary> Tests incoming data for match with char sequence, resets reader when done.</summary>
			private bool atSequence(char[] sequence)
			{
				bool result = true;
				int i = - 1;
				int[] data = new int[sequence.Length];
				while (++i < sequence.Length && result == true)
				{
					data[i] = base.Read();
					if ((char) data[i] != sequence[i])
						result = false; //includes case where end of stream reached
				}
				for (int j = i - 1; j >= 0; j--)
				{
					this.UnRead(data[j]);
				}
				return result;
			}
		}
	}
}