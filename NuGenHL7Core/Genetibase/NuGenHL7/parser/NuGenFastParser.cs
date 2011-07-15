/*
* Created on 16-May-2005
*/
using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using Primitive = Genetibase.NuGenHL7.model.Primitive;
using Segment = Genetibase.NuGenHL7.model.Segment;
using Type = Genetibase.NuGenHL7.model.Type;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
using System.Text.RegularExpressions;
namespace Genetibase.NuGenHL7.parser
{
	
	/// <summary> A Parser for the ER7 encoding, which is faster than PipeParser, but fussier and harder to use.
	/// It's harder to use in that you must tell it ahead of time which segments and fields to parse 
	/// for each event, as well as where in a message structure to find each segment.  It's fussier in 
	/// that each segment you identify as to-be-parsed must always be present in the message (although 
	/// it can be empty -- the minimum needed is the segment name and a carriage return).  
	/// 
	/// Note that an instance of configuration data (see StructRef below) takes on some state during parsing, 
	/// so it can only be used to parse one message at a time.  There is a synchronized block to ensure this, 
	/// but if parallel parsing with the same configuration (e.g. parsing multiple messages of the same event 
	/// at once) is needed, you may want to pool some FastParsers or use separate ones in separate threads. 
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.3 $ updated on $Date: 2005/06/14 20:21:02 $ by $Author: bryan_tripp $
	/// </version>
	public class NuGenFastParser:NuGenParser
	{
		/// <returns> the preferred encoding of this Parser
		/// </returns>
		override public System.String DefaultEncoding
		{
			get
			{
				return "VB";
			}
			
		}
		
		private static char ourSegmentSeparator = '\r';
		private System.Collections.IDictionary myEventGuideMap;
		private NuGenPipeParser myPipeParser;
		
		/// <param name="theEventGuideMap">a map with keys in the form "type^event" (like MSH-9 
		/// components 1 and 2).  Values are corresponding parsing guides for those events.  
		/// A parsing guide is a group of StructRef that identify which segments to parse, 
		/// the relationships between them, and where to find them in a message hierarchy.
		/// The value in the map is the RootRef of the message root.  It must return the 
		/// StructRef for the MSH segment from getSuccessor("MSH").  References to other 
		/// segments can be included as needed.   
		/// </param>
		public NuGenFastParser(System.Collections.IDictionary theEventGuideMap)
		{
			myEventGuideMap = theEventGuideMap;
			myPipeParser = new NuGenPipeParser();
		}
		
		/// <summary> Loads a parsing guide map (as required for FastParser instantiation).  The URL should 
		/// point to a file with one or more guides in sections delimited by blank lines.  Within 
		/// a section, the first line must contain an event name of the for "type^event".  Subsequent 
		/// lines define the parsed parts of messages with that event.  Each line begins with either 
		/// a segment name or "{" (indicating group start) or "}" (indicating group end).  Group  
		/// start lines then have whitespace and a Terser path to the group (relative to the closest 
		/// ancestor group listed in the parsin guide).  Segment lines then have whitespace and a 
		/// relative Terser path to the segment, followed by a colon and a comma-delimited list of field 
		/// numbers, which indicates which fields for that segment are to be parsed.  Within Terser
		/// paths, repetition numbers must be replaced with asterisks. An example follows: 
		/// 
		/// ORU^R01
		/// MSH MSH:9,12
		/// { ORU_R01_PIDNTEPV1ORCOBRNTEOBXNTE(*)
		/// { ORU_R01_PIDNTEPV1
		/// PID PID:3-5
		/// }
		/// { ORU_R01_ORCOBRNTEOBXNTE(*)
		/// { ORU_R01_OBXNTE(*)
		/// OBX OBX:2,5
		/// }
		/// }
		/// }
		/// 
		/// ADT^A01
		/// MSH MSH:9,12
		/// PID PID:3
		/// PV1 PV1:7-9
		/// 
		/// </summary>
		/// <param name="theMapURL">an URL to a file of the form desribed above
		/// </param>
		/// <returns> the corresponding Map 
		/// </returns>
		public static System.Collections.IDictionary loadEventGuideMap(System.Uri theMapURL)
		{
			System.Collections.IDictionary result = new System.Collections.Hashtable();
			
			try
			{
				System.Net.HttpWebRequest conn = (System.Net.HttpWebRequest) System.Net.WebRequest.Create(theMapURL);
				System.IO.StreamReader reader = new System.IO.StreamReader(new System.IO.StreamReader(conn.GetResponse().GetResponseStream(), System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(conn.GetResponse().GetResponseStream(), System.Text.Encoding.Default).CurrentEncoding);
				
				System.String eventName = null;
				System.Text.StringBuilder spec = new System.Text.StringBuilder();
				System.String line = null;
				while ((line = reader.ReadLine()) != null)
				{
					if (line.Length == 0)
					{
						finish(eventName, spec, result);
						eventName = null;
						spec = new System.Text.StringBuilder();
					}
					else
					{
						if (eventName == null)
						{
							eventName = line;
						}
						else
						{
							spec.Append(line + "\r");
						}
					}
				}
				reader.Close();
				finish(eventName, spec, result);
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenHL7Exception(e);
			}
			
			return result;
		}
		
		private static void  finish(System.String theEventName, System.Text.StringBuilder theSpec, System.Collections.IDictionary theMap)
		{
			if (theEventName != null)
			{
				RootRef root = parseGuide(theSpec.ToString());
				theMap[theEventName] = root;
			}
		}
		
		private static RootRef parseGuide(System.String theSpec)
		{
			SupportClass.Tokenizer lines = new SupportClass.Tokenizer(theSpec, "\r", false);
			RootRef result = new RootRef();
			System.Collections.ArrayList ancestry = new System.Collections.ArrayList();
			ancestry.Add(result);
			System.Collections.IDictionary successors = new System.Collections.Hashtable();
			
			StructRef previous = result;
			while (lines.HasMoreTokens())
			{
				System.String line = lines.NextToken();
				SupportClass.Tokenizer parts = new SupportClass.Tokenizer(line, "\t ", false);
				System.String segName = parts.NextToken();
				System.String path = parts.HasMoreTokens()?parts.NextToken():"";
				parts = new SupportClass.Tokenizer(path, ":", false);
				path = parts.HasMoreTokens()?parts.NextToken():null;
				
				int[] fields = getFieldList(parts.HasMoreTokens()?parts.NextToken():"");
				
				if (segName.Equals("}"))
				{
					StructRef parent = (StructRef) SupportClass.StackSupport.Pop(ancestry);
					if (parent.ChildName != null && parent.RelativePath.IndexOf('*') >= 0)
					{
						//repeating group
						previous.setSuccessor(parent.ChildName, parent);
					}
				}
				else
				{
					bool isSegment = !(segName.Equals("{"));
					StructRef ref_Renamed = new StructRef((StructRef) ancestry[ancestry.Count - 1], path, isSegment, fields);
					if (isSegment)
					{
						previous.setSuccessor(segName, ref_Renamed);
						if (path.IndexOf('*') >= 0)
							ref_Renamed.setSuccessor(segName, ref_Renamed);
						setGroupSuccessors(successors, segName);
					}
					else
					{
						successors[previous] = ref_Renamed;
					}
					if (!isSegment)
						ancestry.Add(ref_Renamed);
					previous = ref_Renamed;
				}
			}
			
			return result;
		}
		
		private static void  setGroupSuccessors(System.Collections.IDictionary theSuccessors, System.String theSegName)
		{
			for (System.Collections.IEnumerator it = new SupportClass.HashSetSupport(theSuccessors.Keys).GetEnumerator(); it.MoveNext(); )
			{
				StructRef from = (StructRef) it.Current;
				StructRef to = (StructRef) theSuccessors[from];
				from.setSuccessor(theSegName, to);
			}
			theSuccessors.Clear();
		}
		
		private static int[] getFieldList(System.String theSpec)
		{
			SupportClass.Tokenizer tok = new SupportClass.Tokenizer(theSpec, ",", false);
			System.Collections.IList fieldList = new System.Collections.ArrayList(30);
			while (tok.HasMoreTokens())
			{
				System.String token = tok.NextToken();
				int index = token.IndexOf('-');
				if (index >= 0)
				{
					//it's a range
					int start = System.Int32.Parse(token.Substring(0, (index) - (0)));
					int end = System.Int32.Parse(token.Substring(index + 1));
					for (int i = start; i <= end; i++)
					{
						fieldList.Add((System.Int32) i);
					}
				}
				else
				{
					fieldList.Add(System.Int32.Parse(token));
				}
			}
			
			int[] result = new int[fieldList.Count];
			for (int i = 0; i < result.Length; i++)
			{
				result[i] = ((System.Int32) fieldList[i]);
			}
			
			return result;
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.getEncoding(java.lang.String)">
		/// </seealso>
		public override System.String getEncoding(System.String message)
		{
			return myPipeParser.getEncoding(message);
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.supportsEncoding(java.lang.String)">
		/// </seealso>
		public override bool supportsEncoding(System.String encoding)
		{
			return myPipeParser.supportsEncoding(encoding);
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.doParse(java.lang.String, java.lang.String)">
		/// </seealso>
		protected internal override Message doParse(System.String message, System.String version)
		{
			Message result = null;
			
			char fieldSep = message[3];
			NuGenEncodingCharacters ec = new NuGenEncodingCharacters(fieldSep, message.Substring(4, (8) - (4)));
			
			SupportClass.Tokenizer tok = new SupportClass.Tokenizer(message.Substring(4), System.Convert.ToString(new char[]{fieldSep, ourSegmentSeparator}), true);
			
			System.String[] mshFields = getMSHFields(tok, fieldSep);
			System.Object[] structure = getStructure(mshFields[8], ec.ComponentSeparator);
			
			StructRef root = (StructRef) myEventGuideMap[structure[0]];
			if (root == null)
			{
				result = myPipeParser.parse(message);
			}
			else
			{
				int csIndex = mshFields[11].IndexOf((System.Char) ec.ComponentSeparator);
				result = instantiateMessage((System.String) structure[1], version, ((System.Boolean) structure[2]));
				
				StructRef mshRef = null;
				lock (root)
				{
					mshRef = root.getSuccessor("MSH");
					root.reset();
				}
				Segment msh = (Segment) result.get_Renamed("MSH");
				for (int i = 0; i < mshRef.Fields.Length; i++)
				{
					int fieldNum = mshRef.Fields[i];
					parse(mshFields[fieldNum - 1], msh, fieldNum, ec);
				}
				
				parse(tok, result, root, ec);
			}
			
			return result;
		}
		
		private System.String[] getMSHFields(SupportClass.Tokenizer tok, char fieldSep)
		{
			System.String[] result = new System.String[21];
			result[0] = System.Convert.ToString(fieldSep);
			System.String token = null;
			int field = 1;
			while (tok.HasMoreTokens() && (token = tok.NextToken())[0] != ourSegmentSeparator)
			{
				if (token[0] == fieldSep)
				{
					field++;
				}
				else
				{
					result[field] = token;
				}
			}
			return result;
		}
		
		private void  parse(SupportClass.Tokenizer tok, Message message, StructRef root, NuGenEncodingCharacters ec)
		{
			
			Terser t = new Terser(message);
			
			lock (root)
			{
				StructRef ref_Renamed = root.getSuccessor("MSH");
				
				int field = 0;
				Segment segment = null;
				int[] fields = new int[0];
				
				while (tok.HasMoreTokens())
				{
					System.String token = tok.NextToken();
					if (token[0] == ec.FieldSeparator)
					{
						field++;
					}
					else if (token[0] == ourSegmentSeparator)
					{
						field = 0;
					}
					else if (field == 0)
					{
						StructRef newref = drill(ref_Renamed, token);
						if (newref == null)
						{
							segment = null;
							fields = new int[0];
						}
						else
						{
							ref_Renamed = newref;
							segment = t.getSegment(ref_Renamed.FullPath);
							fields = ref_Renamed.Fields;
						}
					}
					else if (segment != null && System.Array.BinarySearch(fields, (System.Object) field) >= 0)
					{
						parse(token, segment, field, ec);
					}
				}
				root.reset();
			}
		}
		
		//drill through groups to a segment 
		private StructRef drill(StructRef ref_Renamed, System.String name)
		{
			ref_Renamed = ref_Renamed.getSuccessor(name);
			while (ref_Renamed != null && !ref_Renamed.Segment)
			{
				ref_Renamed = ref_Renamed.getSuccessor(name);
			}
			return ref_Renamed;
		}
		
		private void  parse(System.String field, Segment segment, int num, NuGenEncodingCharacters ec)
		{
			if (field != null)
			{
				int rep = 0;
				int component = 1;
				int subcomponent = 1;
				Type type = segment.getField(num, rep);
				
				System.String delim = System.Convert.ToString(new char[]{ec.RepetitionSeparator, ec.ComponentSeparator, ec.SubcomponentSeparator});
				for (SupportClass.Tokenizer tok = new SupportClass.Tokenizer(field, delim, true); tok.HasMoreTokens(); )
				{
					System.String token = tok.NextToken();
					char c = token[0];
					if (c == ec.RepetitionSeparator)
					{
						rep++;
						component = 1;
						subcomponent = 1;
						type = segment.getField(num, rep);
					}
					else if (c == ec.ComponentSeparator)
					{
						component++;
						subcomponent = 1;
					}
					else if (c == ec.SubcomponentSeparator)
					{
						subcomponent++;
					}
					else
					{
						Primitive p = Terser.getPrimitive(type, component, subcomponent);
						p.Value = token;
					}
				}
			}
		}
		
		/// <returns>s the message structure from MSH-9-3
		/// </returns>
		private System.Object[] getStructure(System.String msh9, char compSep)
		{
			System.String structure = null;
			System.String event_Renamed = null;
			
			System.String[] components = new System.String[3];
			SupportClass.Tokenizer tok = new SupportClass.Tokenizer(msh9, System.Convert.ToString(compSep), true);
			for (int i = 0; tok.HasMoreTokens() && i < components.Length; )
			{
				System.String token = tok.NextToken();
				if (token[0] == compSep)
				{
					i++;
				}
				else
				{
					components[i] = token;
				}
			}
			
			bool explicitlyDefined = (components[2] == null)?false:true;
			
			if (explicitlyDefined)
			{
				structure = components[2];
			}
			else if (components[0] != null && components[0].Equals("ACK"))
			{
				structure = "ACK";
			}
			else if (components[0] != null && components[1] != null)
			{
				structure = components[0] + "_" + components[1];
			}
			else
			{
				throw new NuGenHL7Exception("Can't determine message structure from MSH-9: " + msh9, NuGenHL7Exception.UNSUPPORTED_MESSAGE_TYPE);
			}
			
			if (components[1] == null)
			{
				event_Renamed = components[0];
			}
			else
			{
				event_Renamed = components[0] + "^" + components[1];
			}
			
			return new System.Object[]{event_Renamed, structure, (Boolean)explicitlyDefined};
		}
		
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.encode(Genetibase.NuGenHL7.model.Message, java.lang.String)">
		/// </seealso>
		protected internal override System.String doEncode(Message source, System.String encoding)
		{
			return myPipeParser.doEncode(source, encoding);
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.encode(Genetibase.NuGenHL7.model.Message)">
		/// </seealso>
		protected internal override System.String doEncode(Message source)
		{
			return myPipeParser.doEncode(source);
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.getCriticalResponseData(java.lang.String)">
		/// </seealso>
		public override Segment getCriticalResponseData(System.String message)
		{
			return myPipeParser.getCriticalResponseData(message);
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.getAckID(java.lang.String)">
		/// </seealso>
		public override System.String getAckID(System.String message)
		{
			return myPipeParser.getAckID(message);
		}
		
		/// <seealso cref="Genetibase.NuGenHL7.parser.Parser.getVersion(java.lang.String)">
		/// </seealso>
		public override System.String getVersion(System.String message)
		{
			return myPipeParser.getVersion(message);
		}
		
		/// <summary> A pointer to a distinct segment or group position in a message.  
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.3 $ updated on $Date: 2005/06/14 20:21:02 $ by $Author: bryan_tripp $
		/// </version>
		public class StructRef
		{
			/// <returns> full Terser path, including parent and repetition information.  
			/// </returns>
			virtual public System.String FullPath
			{
				get
				{
                    return myParent.FullPath + Regex.Replace(myRelativePath, "\\*", myRep.ToString());
				}
				
			}
			/// <returns> relative Terser path as defined in constructor
			/// </returns>
			virtual public System.String RelativePath
			{
				get
				{
					return myRelativePath;
				}
				
			}
			/// <returns> name of first successor, if available and if this is not a segment reference, 
			/// otherwise null 
			/// </returns>
			virtual public System.String ChildName
			{
				get
				{
					System.String result = null;
					if (!mySegmentFlag && !(mySuccessors.Count == 0))
					{
						result = ((System.String) new SupportClass.HashSetSupport(mySuccessors.Keys).GetEnumerator().Current);
					}
					return result;
				}
				
			}
			/// <returns> true iff referenced Structure is a Segment 
			/// </returns>
			virtual public bool Segment
			{
				get
				{
					return mySegmentFlag;
				}
				
			}
			/// <returns> an ordered list of fields to be parsed for this segment (empty if not a segment)
			/// </returns>
			virtual public int[] Fields
			{
				get
				{
					return myFields;
				}
				
			}
			
			private StructRef myParent;
			private System.String myRelativePath;
			private System.Collections.IDictionary mySuccessors;
			private int myRep;
			private bool mySegmentFlag;
			//private boolean myResettableFlag;
			private int[] myFields;
			private System.Collections.IList myChildren;
			
			/// <param name="theParent">a StructRef for the parent Group of the referenced Structure
			/// </param>
			/// <param name="theRelativePath">the relative (from the parent) Terser path to the referenced 
			/// structure.  If the structure repeats, the rep number should be replaced with "*"
			/// (it will be incremented as needed). 
			/// </param>
			/// <param name="isSegment">true iff the referenced Structure is a Segment (rather than a Group)
			/// </param>
			/// <param name="theFields">a list of fields to be parsed for this segment (null or empty for groups)
			/// </param>
			public StructRef(StructRef theParent, System.String theRelativePath, bool isSegment, int[] theFields)
			{
				myParent = theParent;
				myChildren = new System.Collections.ArrayList();
				if (myParent != null)
					myParent.addChild(this);
				
				myRelativePath = theRelativePath;
				if (!myRelativePath.StartsWith("/"))
				{
					myRelativePath = "/" + myRelativePath;
				}
				mySegmentFlag = isSegment;
				mySuccessors = new System.Collections.Hashtable();
				myRep = - 1;
				if (mySegmentFlag)
				{
					myFields = theFields;
					System.Array.Sort(myFields);
				}
				else
				{
					myFields = new int[0];
				}
				//myResettableFlag = (myParent == null) ? true : false;
			}
			
			/// <summary> Indicates an immediately subsequent structure in parsing order.  A Structure in a list 
			/// should point to the next Structure in the list.  A Structure that repeats should point to 
			/// itself.  A Structure at the end of a repeating Group should point to the Group. 
			/// A Group should point to its first child.  
			/// 
			/// </summary>
			/// <param name="theName">name of the next Segment in this direction (ie if the next structure is a group, 
			/// not that one)
			/// </param>
			/// <param name="theSuccessor">the immediately next StructRef in that direction
			/// </param>
			public virtual void  setSuccessor(System.String theName, StructRef theSuccessor)
			{
				mySuccessors[theName] = theSuccessor;
			}
			
			/// <param name="theName">name of a successor in parse order, as set in setSuccessor()
			/// </param>
			/// <returns> the StructRef under that name 
			/// </returns>
			public virtual StructRef getSuccessor(System.String theName)
			{
				StructRef ref_Renamed = (StructRef) mySuccessors[theName];
				if (ref_Renamed != null)
				{
					ref_Renamed.next();
				}
				return ref_Renamed;
			}
			
			/// <summary> Increments the repetition number of the underlying Structure, which is used in getFullPath() </summary>
			private void  next()
			{
				myRep++;
				resetChildren();
			}
			
			private void  addChild(StructRef theChild)
			{
				if (!Segment)
				{
					myChildren.Add(theChild);
				}
			}
			
			/// <summary> Resets the StructRef to its starting state, before its first iteration, and resets 
			/// its children as well.  
			/// </summary>
			public virtual void  reset()
			{
				myRep = - 1;
				resetChildren();
			}
			
			private void  resetChildren()
			{
				for (int i = 0; i < myChildren.Count; i++)
				{
					StructRef child = (StructRef) myChildren[i];
					child.reset();
				}
			}
		}
		
		/// <summary> A convenience StructRef that points to a message root.  
		/// 
		/// </summary>
		/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
		/// </author>
		/// <version>  $Revision: 1.3 $ updated on $Date: 2005/06/14 20:21:02 $ by $Author: bryan_tripp $
		/// </version>
		public class RootRef:StructRef
		{
			override public System.String FullPath
			{
				get
				{
					return "";
				}
				
			}
			public RootRef():base(null, "", false, null)
			{
			}
		}
		static NuGenFastParser()
		{
		}
	}
}