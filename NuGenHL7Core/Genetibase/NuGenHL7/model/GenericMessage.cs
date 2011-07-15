using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using Parser = Genetibase.NuGenHL7.parser.NuGenParser;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;

namespace Genetibase.NuGenHL7.model
{
	
	/// <summary> A generic HL7 message, meant for parsing message with unrecognized structures
	/// into a flat list of segments.
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	[Serializable]
	public abstract class GenericMessage:AbstractMessage
	{
		
		/// <summary> Creates a new instance of GenericMessage. 
		/// 
		/// </summary>
		/// <param name="factory">class factory for contained structures 
		/// </param>
		public GenericMessage(ModelClassFactory factory):base(factory)
		{
			try
			{
				this.addNonstandardSegment("MSH");
			}
			catch (NuGenHL7Exception)
			{
				System.String message = "Unexpected error adding GenericSegment to GenericMessage.";
				throw new System.ApplicationException(message);
			}
		}
		
		/// <summary> Returns a subclass of GenericMessage corresponding to a certain version.  
		/// This is needed so that version-specific segments can be added as the message
		/// is parsed.  
		/// </summary>
		public static System.Type getGenericMessageClass(System.String version)
		{
			if (!Parser.validVersion(version))
				throw new System.ArgumentException("The version " + version + " is not recognized");
			
			System.Type c = null;
			if (version.Equals("2.1"))
			{
				c = typeof(V21);
			}
			else if (version.Equals("2.2"))
			{
				c = typeof(V22);
			}
			else if (version.Equals("2.3"))
			{
				c = typeof(V23);
			}
			else if (version.Equals("2.3.1"))
			{
				c = typeof(V231);
			}
			else if (version.Equals("2.4"))
			{
				c = typeof(V24);
			}
			else if (version.Equals("2.5"))
			{
				c = typeof(V25);
			}
			return c;
		}
		
		[Serializable]
		public class V21:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.1";
				}
				
			}
			public V21(ModelClassFactory factory):base(factory)
			{
			}
		}
		
		[Serializable]
		public class V22:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.2";
				}
				
			}
			public V22(ModelClassFactory factory):base(factory)
			{
			}
		}
		
		[Serializable]
		public class V23:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.3";
				}
				
			}
			public V23(ModelClassFactory factory):base(factory)
			{
			}
		}
		
		[Serializable]
		public class V231:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.3.1";
				}
				
			}
			public V231(ModelClassFactory factory):base(factory)
			{
			}
		}
		
		[Serializable]
		public class V24:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.4";
				}
				
			}
			public V24(ModelClassFactory factory):base(factory)
			{
			}
		}
		
		[Serializable]
		public class V25:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.5";
				}
				
			}
			public V25(ModelClassFactory factory):base(factory)
			{
			}
		}
	}
}