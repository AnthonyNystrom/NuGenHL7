using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.preparser
{
	
	public class NuGenXML
	{
		[Serializable]
		protected internal class StopParsingException:System.Xml.XmlException
		{
			public StopParsingException():base("ca.uhn.hl7.....StopParsingException")
			{
			}
		}
		
		/// <summary>the SAXParser reports parsing events to an object of this class.
		/// We keep track of some parsing state, and the Properties object that 
		/// we're supposed to write our data to.
		/// </summary>
		protected internal class HL7MessageHandler:XmlSaxDefaultHandler
		{
			/* m_props & m_msgMask should be set by the user of this handler before
			they pass this handler to SAXParser.parse() or whatever */
			
			/// <summary>The data that is found while parsing, and which passes m_msgMask, 
			/// will be dumped to m_props, as (DatumPath.toString() / text) key/value
			/// pairs 
			/// </summary>
			public System.Collections.Specialized.NameValueCollection m_props = null;
			
			/// <summary>Specifies what parts of a message should be dumped to m_props. </summary>
			public System.Collections.ICollection m_msgMask = null;
			
			/* All other fields are parser state. */
			
			protected internal bool m_startedDocument = false;

			internal System.Text.StringBuilder m_msgID = new System.Text.StringBuilder();
			internal NuGenDatumPath m_curPath = new NuGenDatumPath();
			
			/* the location in the document of the last datum we dumped to m_props. */
			internal NuGenDatumPath m_lastDumpedPath = new NuGenDatumPath();
			
			/// <summary>For handling repeat segments.   segmentID (String) -> next repeat idx
			/// (Integer).  So when we hit a segment ZYX, we'll know how many times we've
			/// hit a ZYX before, and set the segmentRepIdx part of m_curPath
			/// appropriately. 
			/// </summary>
			internal System.Collections.SortedList m_segmentId2nextRepIdx = new System.Collections.SortedList();
			
			/* m_depthWithinUselessElement and m_depthWithinUsefulElement 
			reflect what m_msgMask thinks about our location in the document at any
			given time.  
			
			Both should always be >= -1.  Note that both can be >= 0 at the same time
			-- explained in a minute....
			
			If m_depthWithinUsefulElement >= 0, this means that we are however deep
			(in terms of nested elements: 0 => just within) within an area of the
			message that passes m_msgMask.  We should should dump whatever we find
			there to m_props.  As we move around within such an element, we will still
			update m_curPath appropriately.
			
			If m_depthWithinUsefulElement >= 0, we are however deep within an element
			which either made no sense (eg. <ZZZ.1> where we were expecting a <ZYX.1>
			-- a few other things maybe), or more importantly that we're within an
			element that otherwise has no hope of having any useful elements within it
			according to m_msgMask.  (eg. m_msgMask says it wants only ZYX segment
			contents, we're in an <MSH>).  So we can safely ignore all content within,
			and just keep track of how deep we are within this useless element (with
			m_depthWithinUselessElement, of course.)  We don't update m_curPath when
			m_depthWithinUselessElement >= 0, there's no point and how would we
			extract information for the DatumPath out of nonsensical element names
			anyway.
			
			If they are both >= 0, this means that there we've found some useless
			stuff (nonsensical element names?) within a known-useful element.
			*/
			internal int m_depthWithinUsefulElement = - 1, m_depthWithinUselessElement = - 1;
			
			/* With this we keep the text that we've found within a certain element.
			It's cleared whenever we enter a (sub) element or leave an element. */
			internal System.Text.StringBuilder m_chars = new System.Text.StringBuilder(10);
			
			public HL7MessageHandler()
			{
				this.clear();
			}
			
			internal virtual void  clear()
			{
				// reset the state (m_props & m_msgMask are not state)
				m_startedDocument = false;
				m_msgID.Remove(0, m_msgID.Length - 0);
				m_curPath.clear();
				// will always be "less than" (according to DatumPath.numbersLessThan)
				// any sensible DatumPath: 
				m_lastDumpedPath.clear().add(new System.Text.StringBuilder().ToString()).add(- 42).add(- 42).add(- 42).add(- 42).add(- 42);
				m_segmentId2nextRepIdx.Clear();
				m_depthWithinUsefulElement = - 1;
				m_depthWithinUselessElement = - 1;
				m_chars.Remove(0, m_chars.Length - 0);
			}
			
			public override void  startDocument()
			{
				bool ok = false;
				if (!m_startedDocument && (m_props != null))
				{
					m_startedDocument = true;
					ok = true;
				}
				
				if (!ok)
				{
					clear();
					throw new StopParsingException();
				}
			}
			
			public override void  endDocument()
			{
				bool ok = false;
				if (m_startedDocument)
				{
					this.clear();
					ok = true;
				}
				
				if (!ok)
				{
					clear();
					throw new StopParsingException();
				}
			}
			
			public override void  startElement(System.String uri, System.String localName, System.String qName, SaxAttributesSupport attributes)
			{
				//System.err.println("startelem: " + qName + " curpathsize; " +
				//m_curPath.size());
				bool ok = false;
				if (m_startedDocument)
				{
					// A single unit of text data will be within a single element, 
					// -- none of it will be in sub-elements and there will be no 
					// sub-elements fragmenting the data text.
					// Right now we're entering a new element: this means that anything
					// in m_chars will be whitespace (likely), or text left over from, 
					// say, the last field, or text that was somewhere it shouldn't have been.
					// (ex. "<ZYX.9> shouldn't be here <PT.1> P </PT.1> </ZYX.9>"
					m_chars.Remove(0, m_chars.Length - 0);
					
					if (m_depthWithinUselessElement >= 0)
					{
						++m_depthWithinUselessElement;
					}
					else
					{
						int oldCurPathSize = m_curPath.size();
						if (tryToGrowDocLocationFromElementName(m_msgID, m_curPath, m_segmentId2nextRepIdx, m_lastDumpedPath, qName))
						{
							if (m_curPath.size() > oldCurPathSize)
							{
								// assert (m_depthWithinUselessElement == -1) // m_curPath
								// should not have grown if we're within a useless element.
								if (m_depthWithinUsefulElement == - 1)
								{
									// this new element could match one of the DatumPaths in
									// m_msgMask -- if that's the case, we've just entered a
									// useful element.
									// TODO: functional stylee (a la C++'s std::accumulate) ? 
									bool curPathStartsWithAMaskElem = false;
									for (System.Collections.IEnumerator maskIt = m_msgMask.GetEnumerator(); !curPathStartsWithAMaskElem && maskIt.MoveNext(); )
									{
										curPathStartsWithAMaskElem = m_curPath.startsWith((NuGenDatumPath) maskIt.Current);
									}
									
									if (curPathStartsWithAMaskElem)
										m_depthWithinUsefulElement = 0;
									else
									{
										// so this element we're entering is not specified by m_msgMask
										// to be useful -- but might it contains elements that
										// are?
										bool aMaskElemStartsWithCurPath = false;
										for (System.Collections.IEnumerator maskIt = m_msgMask.GetEnumerator(); !aMaskElemStartsWithCurPath && maskIt.MoveNext(); )
										{
											aMaskElemStartsWithCurPath = ((NuGenDatumPath) maskIt.Current).startsWith(m_curPath);
										}
										
										if (!aMaskElemStartsWithCurPath)
										{
											// ... nope!  useless.
											m_depthWithinUselessElement = 0;
											m_curPath.setSize(oldCurPathSize);
										} // else => ok, carry on, m_depthWithinUse{less,ful}Element
										// still both -1.
									}
								}
								// else => already within a useful element, don't need to compare 
								// against m_msgMask.
							}
						}
						else
							m_depthWithinUselessElement = 0;
					}
					ok = true;
				}
				
				if (!ok)
				{
					clear();
					throw new StopParsingException();
				}
			}
			
			/* doc location == msgID & curPath together.  
			If we've encountered an element called "elementNam", then this tries 
			to determine what it is, based on what we already know about the document.
			returns true if we can make sense of this new element name given the
			position we're at (represented by msgID / curPath), 
			false if we can't (which probably means this should be a useless element). 
			returning true doesn't mean that we actually changed msgID or curPath, it
			might mean that we just passed through a segment group element OK.
			*/
			protected internal static bool tryToGrowDocLocationFromElementName(System.Text.StringBuilder msgID, NuGenDatumPath curPath, System.Collections.IDictionary segmentId2nextRepIdx, NuGenDatumPath lastDumpedPath, System.String elementName)
			{
				bool ok = false; // ok == can we make sense of this new element?
				// hmm ... where are we in the document: 
				if ((msgID.Length == 0) && (curPath.size() == 0))
				{
					// we're entering a message
					msgID.Replace(msgID.ToString(0, msgID.Length - 0), elementName, 0, msgID.Length - 0);
					segmentId2nextRepIdx.Clear();
					ok = true;
				}
				else if ((msgID.Length > 0) && (curPath.size() == 0))
				{
					// we're entering either a segment-group element (eg. <ADT_A01.PROCEDURE>)
					// or an actual segment element.
					if (!(elementName.StartsWith("" + msgID + '.')))
					{
						// must be an actual segment.
						curPath.add(elementName);
						
						if (segmentId2nextRepIdx.Contains(elementName))
							curPath.add(segmentId2nextRepIdx[elementName]);
						else
							curPath.add((System.Object) 0);
						
						segmentId2nextRepIdx[elementName] = (System.Int32) (((System.Int32) curPath.get_Renamed(curPath.size() - 1)) + 1);
					}
					ok = true;
				}
				else if ((msgID.Length > 0) && (curPath.size() > 0))
				{
					// we're entering a field or a component or a subcomponent.
					if (curPath.size() == 2)
					{
						// we're entering a field element
						// all fields should start with segment-ID + '.' 
						if (elementName.StartsWith("" + curPath.get_Renamed(0) + '.'))
						{
							try
							{
								int fieldIdxFromElementName = System.Int32.Parse(elementName.Substring(elementName.IndexOf('.') + 1));
								
								curPath.add((System.Object) fieldIdxFromElementName);
								
								// now add the repetition idx to curPath: 
								if ((lastDumpedPath.size() >= 4) && (((System.Int32) lastDumpedPath.get_Renamed(2)) == fieldIdxFromElementName))
								{
									// lastDumpedPath has a fieldIdx and a fieldRepIdx.
									curPath.add((System.Object) (((System.Int32) lastDumpedPath.get_Renamed(3)) + 1));
								}
								else
									curPath.add((System.Object) 0);
								
								ok = true;
							}
							catch (System.FormatException)
							{
							}
						} // else => this isn't a field -- must be useless.
					}
					else if ((curPath.size() == 4) || (curPath.size() == 5))
					{
						// we're entering a component or subcomponent element
						try
						{
							int idxFromElementName = System.Int32.Parse(elementName.Substring(elementName.IndexOf('.') + 1));
							curPath.add((System.Object) idxFromElementName);
							ok = true;
						}
						catch (System.FormatException)
						{
						}
					}
				}
				return ok;
			}
			
			public override void  endElement(System.String uri, System.String localName, System.String qName)
			{
				//System.err.println("endElement: " + qName);
				bool ok = false;
				if (m_startedDocument)
				{
					if (m_depthWithinUselessElement >= 0)
					{
						--m_depthWithinUselessElement;
						ok = true;
					}
					else
					{
						if ((m_msgID.Length > 0) && (m_curPath.size() == 0))
						{
							// we're exiting either a message element or a 
							// segment group element.
							if (String.CompareOrdinal(("" + qName), "" + m_msgID) == 0)
							{
								m_msgID.Remove(0, m_msgID.Length - 0);
							} // => exiting message element
							// else => segment group element -- do nothing.
							
							ok = true;
						}
						else if ((m_msgID.Length > 0) && (m_curPath.size() > 0))
						{
							tryToDumpDataToProps();
							
							if (m_curPath.size() == 2)
							{
								// exiting a segment element
								m_curPath.setSize(0);
								ok = true;
							}
							else if (m_curPath.size() == 4)
							{
								// exiting a field element 
								m_curPath.setSize(2);
								ok = true;
							}
							else if ((m_curPath.size() == 5) || (m_curPath.size() == 6))
							{
								// exiting a component or a subcomponent
								m_curPath.setSize(m_curPath.size() - 1);
								ok = true;
							}
						}
						
						if (m_depthWithinUsefulElement >= 0)
							--m_depthWithinUsefulElement;
					}
				}
				
				if (!ok)
				{
					clear();
					throw new StopParsingException();
				}
			}
			
			/// <summary>try to dump whatever we've got in m_chars to m_props, 
			/// with a key of m_curPath.toString(). 
			/// </summary>
			protected internal virtual void  tryToDumpDataToProps()
			{
				if ((m_curPath.size() >= 2) && (m_depthWithinUselessElement == - 1))
				{
					/* m_curPath.toString() will be the property key whose value will be
					m_chars.
					
					This is (part of) what m_lastDumpedPath is for: With, for example "<ZYX.9>
					<PT.1>P</PT.1> </ZYX.9>" we might have had a m_curPath containing something
					like [ZYX, 0, 9, 0, 0] when we exited the PT.1 element.  (note: internal
					DatumPath elements are 0-indexed, string representations of DatumPaths and
					the XML text is 1-indexed.)  So in m_props the key for "P" would have been
					"ZYX[0]-9[0]-1-1".  (the last "-1" is a default that got added by
					toString()).
					
					Then we would have exited the PT.3 element, changed m_curPath to [ZYX, 0,
					9, 0], picked up the whitespace between </PT.3> and </ZYX.9>, and when
					exiting the ZYX.9 element, we might have written that whitespace to m_props
					with a key of the toString() of [ZYX, 0, 9, 0]; that is, "ZYX[0]-9[0]-1-1":
					the same as the key for the "P" ... clobbering "P" in m_props with
					whitespace.
					
					But since we know that HL7 fields / components / etc are always in order
					(numerically), we can count on m_lastDumpedPath and use
					DatumPath.numbersLessThan to avoid the clobbering.
					*/
					if ((m_lastDumpedPath.get_Renamed(0).Equals(m_curPath.get_Renamed(0)))?(m_lastDumpedPath.numbersLessThan(m_curPath)):true)
					{
						if (m_depthWithinUsefulElement >= 0)
						{
							// TODO: remove!  or assert 
							if (SupportClass.ContainsKeySupport(m_props, "" + m_curPath))
								System.Console.Error.WriteLine("ALAAAARM: CLOBBERING PROPERTY in " + GetType());
							
							m_props["" + m_curPath] = "" + m_chars;
							m_lastDumpedPath.copy(m_curPath);
							m_chars.Remove(0, m_chars.Length - 0);
						}
					}
				}
			}
			
			public override void  characters(System.Char[] chars, int start, int length)
			{
				// note that a contiguous run of characters in the document 
				// might get reported to us in several chunks. 
				// (In the order that the text appears in the document, 
				// non-overlapping and with no gaps between chunks.) 
				// An entity like &amp; will reach us as an actual & character.
				
				if ((m_msgID.Length > 0) && (m_curPath.size() >= 4))
				{
					m_chars.Append(chars, start, length);
				}
			}
			
			public virtual void  ignoreableWhitespace(char[] chars, int start, int length)
			{
				// it's unclear which whitespace is considered ignorable for us.  
				// what the heck, add it to m_chars. 
				characters(chars, start, length);
			}
			
			public override void  error(System.Xml.XmlException e)
			{
				// TODO: remove.
				System.Console.Error.WriteLine("Error in " + GetType() + ": " + e);
			}
			
			public override void  fatalError(System.Xml.XmlException e)
			{
				throw e;
			}
		}
		
		/// <summary>parse message according to our HL7 XML handler, and dump the data found
		/// to props.  
		/// </summary>
		/// <summary>returns true if we parsed ok, which means well-formed XML, and
		/// that's about it.  We just barely check against HL7 structure, and ignore any
		/// elements / text that is unexpected (that is, impossible in any HL7 message:
		/// independant of any message / segment definitions).
		/// "message" should be an XML document with one top-level element -- that being
		/// the message.  (<ACK> or whatever).  We're only expecting one message to be in
		/// "message".
		/// props can be null if you don't want the data (we still parse).  The message
		/// data found in message (that passes msgMask) will be added to props as key /
		/// value pairs with the key a toString() of the appropriate DatumPath for the
		/// location where the data is found (i.e. in the ZYX[a]-b[c]-d-e style), and
		/// the value the corresponding text.  So, after calling parseMessage
		/// successfully, if you wanted to retrieve the message data from props you
		/// might call something like 
		/// props.getProperty((new DatumPath()).add("MSH").add(1).toString())
		/// and that would return a String with "|", probably.
		/// Note that this package facilitates the extraction of message data in a way
		/// independent of message version (i.e. components and whatever getting added):
		/// With a message of "<FOO><ZYX><ZYX.42>fieldy-field-field</ZYX.42></ZYX></FOO>",
		/// "ZYX[0]-1[0]-1-1" will be the key that ends up in props (see notes at
		/// DatumPath.toString())
		/// So if you, coding for a future version of the FOO message but
		/// recieving old-version message data, tried
		/// props.getProperty((new DatumPath()).add("ZYX").add(0).add(42).add(0).add(1).toString()) 
		/// with the message above (that is, trying to extract a repetition and
		/// component that aren't there), you would get "ZYX[0]-42[0]-1-1" mapping to 
		/// "fieldy-field-field" in the resulting props.  
		/// If the message was
		/// "<FOO><ZYX><ZYX.42><ARG.1>component data</ARG.1></ZYX.42></ZYX></FOO>"
		/// and you, coding for an old version of this FOO message but recieving
		/// new-version FOO message data, tried 
		/// props.getProperty((new DatumPath()).add("ZYX").add(0).add(42).toString())
		/// you would get "ZYX[0]-42[0]-1-1" mapping to "component data" in the resulting 
		/// props.
		/// msgMask lets you specify which parts of the message you want dumped to props.
		/// Passing in null gets you everything.  Otherwise, msgMask's elements should
		/// all be DatumPaths (! => ClassCastException), and a particular part of the
		/// message will be dumped to props only if it's location, as represented by a
		/// DatumPath, startsWith (as in DatumPath.startsWith()) at least one element of
		/// msgMask.  So if one element of msgMask was a (new DatumPath()).add(new
		/// String("ZYX")), then everything in all ZYX segment would get dumped to props.
		/// A (new DatumPath()).add(new String("ZYX")).add(1) would get only the first
		/// repetitions of same (if there is one) dumped to props.  etc. etc.  Note that
		/// a DatumPath of size() == 0 in msgMask will get you everything, no matter what
		/// the other elements of msgMask are, because all DatumPaths startsWith the
		/// zero-length DatumPath.
		/// Segment group elements (eg. ADT_A01.PROCEDURE) are handled fine, but they
		/// aren't addressed in msgMask or in the output in props -- basically any
		/// element tags at the level immediately inside the message element, and having
		/// a name that starts with the message element name + '.', is ignored (meaning
		/// it's contents are dealt with the same as if the start and end tags' just 
		/// wasn't there.)
		/// </summary>
		public static bool parseMessage(System.Collections.Specialized.NameValueCollection props, System.String message, System.Collections.ICollection msgMask)
		{
			bool ret = false;
			try
			{
				XmlSAXDocumentManager factory = XmlSAXDocumentManager.NewInstance();
				XmlSAXDocumentManager parser = XmlSAXDocumentManager.CloneInstance(factory);
				
				XmlSourceSupport inSrc = new XmlSourceSupport(new System.IO.MemoryStream(new System.Text.ASCIIEncoding().GetBytes(message)));
				
				HL7MessageHandler handler = new HL7MessageHandler();
				handler.m_props = (props != null?props:new System.Collections.Specialized.NameValueCollection()); // it's expecting a props.
				
				if (msgMask != null)
					handler.m_msgMask = msgMask;
				else
				{
					handler.m_msgMask = System.Collections.ArrayList.Synchronized(new System.Collections.ArrayList(10));
					SupportClass.ICollectionSupport.Add(handler.m_msgMask, new NuGenDatumPath());
				}
				
				parser.parse(inSrc, handler);
				ret = true;
			}
			catch (System.IO.IOException e)
			{
				throw new NuGenHL7Exception(e);
			}
			catch (StopParsingException e)
			{
				throw new NuGenHL7Exception(e);
			}
			catch (System.Xml.XmlException e)
			{
				throw new NuGenHL7Exception(e);
			}
			
			return ret;
		}
	}
}