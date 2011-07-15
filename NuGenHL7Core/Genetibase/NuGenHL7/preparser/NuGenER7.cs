using System;
using Genetibase.NuGenHL7.parser;
namespace Genetibase.NuGenHL7.preparser
{
	
	/*
	The point of this class (all static members, not instantiatable) is to take a
	traditionally-encoded HL7 message and add all it's contents to a Properties
	object, via the parseMessage() method.
	
	The key-value pairs added to the Properties argument have keys that represent a
	datum's location in the message.  (in the ZYX-1-2[0] style.  TODO: define
	exactly.)  See Datum, particularly the toString() of that class.
	Anyway, the Properties keys are those and the values are the tokens found.
	
	Note: we accept useless field repetition separators at the end of a 
	field repetition sequence.  i.e. |855-4545~555-3792~~~| , and interpret this
	as definining repetitions 0 and 1.  This might not be allowed.  (HL7 2.3.1
	section 2.10 explicitly allows this behaviour for fields / components /
	subcomponents, but the allowance is notably absent for repetitions.  TODO:
	nail down.)  We allow it anyway.
	
	Also, we accept things like |855-4545~~555-3792|, and interpret it as defining
	repetitions 0 and 2.  The spec would seem to disallow this too, but there's no
	harm.  :D  */
	
	public class NuGenER7
	{
		
		private NuGenER7()
		{
		}
		
		/// <summary>characters that delimit segments.  for use with StringTokenizer.
		/// We are forgiving: HL7 2.3.1 section 2.7 says that carriage return ('\r') is
		/// the only segment delimiter.  TODO: check other versions. 
		/// </summary>
		internal const System.String segmentSeparators = "\r\n\f";
		
		/// <summary>Parses message and dumps contents to props, with keys in the 
		/// ZYX[a]-b[c]-d-e style.
		/// </summary>
		public static bool parseMessage(System.Collections.Specialized.NameValueCollection props, System.Collections.ArrayList msgMask, System.String message)
		{
			bool ok = false;
			if (message != null)
			{
				if (props == null)
				{
					props = new System.Collections.Specialized.NameValueCollection();
				}
				
				SupportClass.Tokenizer messageTokenizer = new SupportClass.Tokenizer(message, segmentSeparators);
				if (messageTokenizer.HasMoreTokens())
				{
					System.String firstSegment = messageTokenizer.NextToken();
					NuGenEncodingCharacters encodingChars = new NuGenEncodingCharacters('0', "0000");
					if (parseMSHSegmentWhole(props, msgMask, encodingChars, firstSegment))
					{
						ok = true;
						System.Collections.SortedList segmentId2nextRepIdx = new System.Collections.SortedList();
						segmentId2nextRepIdx[new System.Text.StringBuilder("MSH").ToString()] = 1;
						// in case we find another MSH segment, heh.
						while (messageTokenizer.HasMoreTokens())
						{
							parseSegmentWhole(props, segmentId2nextRepIdx, msgMask, encodingChars, messageTokenizer.NextToken());
						}
					}
				}
			}
			return ok;
		}
		
		/// <summary>given segment, starting with "MSH", then encoding characters, etc...
		/// put MSH[0]-1[0]-1-1 (== MSH-1) and MSH[0]-2[0]-1-1 (== MSH-2) into props, if found,
		/// plus everything else found in 'segment' 
		/// </summary>
		protected internal static bool parseMSHSegmentWhole(System.Collections.Specialized.NameValueCollection props, System.Collections.ArrayList msgMask, NuGenEncodingCharacters encodingChars, System.String segment)
		{
			bool ret = false;
			try
			{
				ER7SegmentHandler handler = new ER7SegmentHandler();
				handler.m_props = props;
				handler.m_encodingChars = encodingChars;
				handler.m_segmentId = "MSH";
				handler.m_segmentRepIdx = 0;
				if (msgMask != null)
					handler.m_msgMask = msgMask;
				else
				{
					handler.m_msgMask = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
					handler.m_msgMask.Add(new NuGenDatumPath()); // everything will pass this
					// (every DatumPath startsWith the zero-length DatumPath)
				}
				
				encodingChars.FieldSeparator = segment[3];
				System.Collections.ArrayList nodeKey = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
				nodeKey.Add(0);
				handler.putDatum(nodeKey, System.Convert.ToString(encodingChars.FieldSeparator));
				encodingChars.ComponentSeparator = segment[4];
				encodingChars.RepetitionSeparator = segment[5];
				encodingChars.EscapeCharacter = segment[6];
				encodingChars.SubcomponentSeparator = segment[7];
				nodeKey[0] = 1;
				handler.putDatum(nodeKey, encodingChars.ToString());
				
				if (segment[8] == encodingChars.FieldSeparator)
				{
					ret = true;
					// now -- we recurse 
					// through fields / field-repetitions / components / subcomponents.
					nodeKey.Clear();
					nodeKey.Add(2);
					parseSegmentGuts(handler, segment.Substring(9), nodeKey);
				}
			}
			catch (System.IndexOutOfRangeException)
			{
			}
			catch (System.NullReferenceException)
			{
			}
			
			return ret;
		}
		
		/// <summary>pass in a whole segment (of type other than MSH), including message type
		/// at the start, according to encodingChars, and we'll parse the contents and
		/// put them in props. 
		/// </summary>
		protected internal static void  parseSegmentWhole(System.Collections.Specialized.NameValueCollection props, System.Collections.IDictionary segmentId2nextRepIdx, System.Collections.ArrayList msgMask, NuGenEncodingCharacters encodingChars, System.String segment)
		{
			try
			{
				System.String segmentId = segment.Substring(0, (3) - (0));
				
				int currentSegmentRepIdx = 0;
				if (segmentId2nextRepIdx.Contains(segmentId))
					currentSegmentRepIdx = ((System.Int32) segmentId2nextRepIdx[segmentId]);
				else
					currentSegmentRepIdx = 0;
				segmentId2nextRepIdx[segmentId] = (System.Int32) (currentSegmentRepIdx + 1);
				
				// will only bother to parse this segment if any of it's contents will 
				// be dumped to props.
				bool parseThisSegment = false;
				NuGenDatumPath segmentIdAsDatumPath = (new NuGenDatumPath()).add(segmentId);
				for (System.Collections.IEnumerator maskIt = msgMask.GetEnumerator(); !parseThisSegment && maskIt.MoveNext(); )
				{
					parseThisSegment = segmentIdAsDatumPath.startsWith((NuGenDatumPath) (maskIt.Current));
				}
				for (System.Collections.IEnumerator maskIt = msgMask.GetEnumerator(); !parseThisSegment && maskIt.MoveNext(); )
				{
					parseThisSegment = ((NuGenDatumPath) (maskIt.Current)).startsWith(segmentIdAsDatumPath);
				}
				
				if (parseThisSegment && (segment[3] == encodingChars.FieldSeparator))
				{
					ER7SegmentHandler handler = new ER7SegmentHandler();
					handler.m_props = props;
					handler.m_encodingChars = encodingChars;
					handler.m_segmentId = segmentId;
					if (msgMask != null)
						handler.m_msgMask = msgMask;
					else
					{
						handler.m_msgMask = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
						handler.m_msgMask.Add(new NuGenDatumPath()); // everything will pass this
						// (every DatumPath startsWith the zero-length DatumPath)
					}
					handler.m_segmentRepIdx = currentSegmentRepIdx;
					
					System.Collections.ArrayList nodeKey = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
					nodeKey.Add(0);
					parseSegmentGuts(handler, segment.Substring(4), nodeKey);
				}
			}
			catch (System.NullReferenceException)
			{
			}
			catch (System.IndexOutOfRangeException)
			{
			}
		}
		
		protected internal interface Handler
		{
			int specDepth();
			char delim(int level);
			
			void  putDatum(System.Collections.ArrayList nodeKey, System.String value_Renamed);
		}
		
		protected internal class ER7SegmentHandler : NuGenER7.Handler
		{
			internal System.Collections.Specialized.NameValueCollection m_props;
			
			internal NuGenEncodingCharacters m_encodingChars;
			
			internal System.String m_segmentId;
			internal int m_segmentRepIdx;
			
			internal System.Collections.ArrayList m_msgMask;
			
			public virtual int specDepth()
			{
				return 4;
			}
			
			public virtual char delim(int level)
			{
				if (level == 0)
					return m_encodingChars.FieldSeparator;
				else if (level == 1)
					return m_encodingChars.RepetitionSeparator;
				else if (level == 2)
					return m_encodingChars.ComponentSeparator;
				else if (level == 3)
					return m_encodingChars.SubcomponentSeparator;
				else
					throw new System.ApplicationException();
			}
			
			public virtual void  putDatum(System.Collections.ArrayList valNodeKey, System.String value_Renamed)
			{
				// make a DatumPath from valNodeKey and info in this: 
				NuGenDatumPath valDatumPath = new NuGenDatumPath();
				valDatumPath.add(m_segmentId).add(m_segmentRepIdx);
				for (int i = 0; i < valNodeKey.Count; ++i)
				{
					// valNodeKey: everything counts from 0 -- not so with DatumPath ... sigh. 
					int itval = ((System.Int32) valNodeKey[i]);
					valDatumPath.add((System.Object) (i == 1?itval:itval + 1));
				}
				
				// see if valDatumPath passes m_msgMask: 
				bool valDatumPathPassesMask = false;
				for (System.Collections.IEnumerator maskIt = m_msgMask.GetEnumerator(); !valDatumPathPassesMask && maskIt.MoveNext(); )
				{
					valDatumPathPassesMask = valDatumPath.startsWith((NuGenDatumPath) (maskIt.Current));
				}
				
				if (valDatumPathPassesMask)
				{
					m_props[valDatumPath.ToString()] = value_Renamed;
				}
			}
		}
		
		/// <summary>recursively tokenize "guts" (a segment, or part of one) into tokens, 
		/// according to separators (aka delimiters) which are different at each level
		/// of recursion, and to a recursive depth which is discovered through "handler"
		/// via handler.delim(int) and handler.specDepth()  As tokens are found, they
		/// are reported to handler via handler.putDatum(), which presumably stashes them
		/// away somewhere.  We tell the handler about the location in the message via
		/// putDatum()'s key argument, which is a List of Integers representing the 
		/// position in the parse tree (size() == depth of recursion).
		/// TODO: say more.
		/// </summary>
		protected internal static void  parseSegmentGuts(NuGenER7.Handler handler, System.String guts, System.Collections.ArrayList nodeKey)
		{
			char thisDepthsDelim = handler.delim(nodeKey.Count - 1);
			//nodeKey.add(new Integer(0)); // will change nodeKey back before function exits
			
			SupportClass.Tokenizer gutsTokenizer = new SupportClass.Tokenizer(guts, System.Convert.ToString(thisDepthsDelim), true);
			while (gutsTokenizer.HasMoreTokens())
			{
				System.String gutsToken = gutsTokenizer.NextToken();
				
				if (gutsToken[0] == thisDepthsDelim)
				{
					// gutsToken is all delims -- skipping over as many fields or
					// components or whatevers as there are characters in the token: 
					int oldvalue = ((System.Int32) nodeKey[nodeKey.Count - 1]);
					nodeKey[nodeKey.Count - 1] = (System.Int32) (oldvalue + gutsToken.Length);
				}
				else
				{
					if (nodeKey.Count < handler.specDepth())
					{
						nodeKey.Add(0);
						parseSegmentGuts(handler, gutsToken, nodeKey);
						SupportClass.SetCapacity(nodeKey, nodeKey.Count - 1);
					}
					else
						handler.putDatum(nodeKey, gutsToken);
				}
			}
			//nodeKey.setSize(nodeKey.size()-1); // undoing add done at top of this func
		}
	}
}