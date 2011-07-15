using System;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Group = Genetibase.NuGenHL7.model.Group;
using Message = Genetibase.NuGenHL7.model.Message;
using Segment = Genetibase.NuGenHL7.model.Segment;
using Structure = Genetibase.NuGenHL7.model.Structure;
namespace Genetibase.NuGenHL7.parser
{
	
	/// <summary> <p>A default XMLParser.  This class assigns segment elements (in an XML-encoded message) 
	/// to Segment objects (in a Message object) using the name of a segment and the names 
	/// of any groups in which the segment is nested.  The names of group classes must correspond
	/// to the names of group elements (they must be identical except that a dot in the element 
	/// name, following the message name, is replaced with an underscore, in order to consitute a 
	/// valid class name). </p>
	/// <p>At the time of writing, the group names in the XML spec are changing.  Many of the group 
	/// names have been automatically generated based on the group contents.  However, these automatic 
	/// names are gradually being replaced with manually assigned names.  This process is expected to 
	/// be complete by November 2002.  As a result, mismatches are likely.  Messages could be  
	/// transformed prior to parsing (using XSLT) as a work-around.  Alternatively the group class names 
	/// could be changed to reflect updates in the XML spec.  Ultimately, HAPI group classes will be 
	/// changed to correspond with the official group names, once these are all assigned.  </p>
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenDefaultXMLParser:NuGenXMLParser
	{
		
		/// <summary>Creates a new instance of DefaultXMLParser </summary>
		public NuGenDefaultXMLParser()
		{
		}
		
		/// <summary> <p>Creates an XML Document that corresponds to the given Message object. </p>
		/// <p>If you are implementing this method, you should create an XML Document, and insert XML Elements
		/// into it that correspond to the groups and segments that belong to the message type that your subclass
		/// of XMLParser supports.  Then, for each segment in the message, call the method
		/// <code>encode(Segment segmentObject, Element segmentElement)</code> using the Element for
		/// that segment and the corresponding Segment object from the given Message.</p>
		/// </summary>
		public override System.Xml.XmlDocument encodeDocument(Message source)
		{
			System.String messageClassName = source.GetType().FullName;
			System.String messageName = messageClassName.Substring(messageClassName.LastIndexOf('.') + 1);
			System.Xml.XmlDocument doc = null;
			try
			{
				doc = new System.Xml.XmlDocument();
				System.Xml.XmlElement root = doc.CreateElement(messageName);
				doc.AppendChild(root);
			}
			catch (System.Exception e)
			{
				throw new NuGenHL7Exception("Can't create XML document - " + e.GetType().FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
			}
			encode(source, (System.Xml.XmlElement) doc.DocumentElement);
			return doc;
		}
		
		/// <summary> Copies data from a group object into the corresponding group element, creating any 
		/// necessary child nodes.  
		/// </summary>
		private void  encode(Genetibase.NuGenHL7.model.Group groupObject, System.Xml.XmlElement groupElement)
		{
			System.String[] childNames = groupObject.Names;
			System.String messageName = groupObject.Message.getName();
			
			try
			{
				for (int i = 0; i < childNames.Length; i++)
				{
					Structure[] reps = groupObject.getAll(childNames[i]);
					for (int j = 0; j < reps.Length; j++)
					{
						System.Xml.XmlElement childElement = groupElement.OwnerDocument.CreateElement(makeGroupElementName(messageName, childNames[i]));
						groupElement.AppendChild(childElement);
						if (reps[j] is Group)
						{
							encode((Group) reps[j], childElement);
						}
						else if (reps[j] is Segment)
						{
							encode((Segment) reps[j], childElement);
						}
					}
				}
			}
			catch (System.Exception e)
			{
				throw new NuGenHL7Exception("Can't encode group " + groupObject.GetType().FullName, NuGenHL7Exception.APPLICATION_INTERNAL_ERROR, e);
			}
		}
		
		/// <summary> <p>Creates and populates a Message object from an XML Document that contains an XML-encoded HL7 message.</p>
		/// <p>The easiest way to implement this method for a particular message structure is as follows:
		/// <ol><li>Create an instance of the Message type you are going to handle with your subclass
		/// of XMLParser</li>
		/// <li>Go through the given Document and find the Elements that represent the top level of
		/// each message segment. </li>
		/// <li>For each of these segments, call <code>parse(Segment segmentObject, Element segmentElement)</code>,
		/// providing the appropriate Segment from your Message object, and the corresponding Element.</li></ol>
		/// At the end of this process, your Message object should be populated with data from the XML
		/// Document.</p>
		/// </summary>
		/// <throws>  HL7Exception if the message is not correctly formatted. </throws>
		/// <throws>  EncodingNotSupportedException if the message encoded </throws>
		/// <summary>     is not supported by this parser.
		/// </summary>
		public override Message parseDocument(System.Xml.XmlDocument XMLMessage, System.String version)
		{
			System.String messageName = ((System.Xml.XmlElement) XMLMessage.DocumentElement).Name;
			Message message = instantiateMessage(messageName, version, true);
			parse(message, (System.Xml.XmlElement) XMLMessage.DocumentElement);
			return message;
		}
		
		/// <summary> Populates the given group object with data from the given group element, ignoring 
		/// any unrecognized nodes.  
		/// </summary>
		private void  parse(Genetibase.NuGenHL7.model.Group groupObject, System.Xml.XmlElement groupElement)
		{
			System.String[] childNames = groupObject.Names;
			System.String messageName = groupObject.Message.getName();
			
			System.Xml.XmlNodeList allChildNodes = groupElement.ChildNodes;
			System.Collections.ArrayList unparsedElementList = new System.Collections.ArrayList();
			for (int i = 0; i < allChildNodes.Count; i++)
			{
				System.Xml.XmlNode node = allChildNodes.Item(i);
				System.String name = node.Name;
				if (System.Convert.ToInt16(node.NodeType) == (short) System.Xml.XmlNodeType.Element && !unparsedElementList.Contains(name))
				{
					unparsedElementList.Add(name);
				}
			}
			
			//we're not too fussy about order here (all occurances get parsed as repetitions) ... 
			for (int i = 0; i < childNames.Length; i++)
			{
				SupportClass.ICollectionSupport.Remove(unparsedElementList, childNames[i]);
				parseReps(groupElement, groupObject, messageName, childNames[i], childNames[i]);
			}
			
			for (int i = 0; i < unparsedElementList.Count; i++)
			{
				System.String segName = (System.String) unparsedElementList[i];
				System.String segIndexName = groupObject.addNonstandardSegment(segName);
				parseReps(groupElement, groupObject, messageName, segName, segIndexName);
			}
		}
		
		//param childIndexName may have an integer on the end if >1 sibling with same name (e.g. NTE2) 
		private void  parseReps(System.Xml.XmlElement groupElement, Group groupObject, System.String messageName, System.String childName, System.String childIndexName)
		{
			
			System.Collections.IList reps = getChildElementsByTagName(groupElement, makeGroupElementName(messageName, childName));
			
			if (groupObject.isRepeating(childIndexName))
			{
				for (int i = 0; i < reps.Count; i++)
				{
					parseRep((System.Xml.XmlElement) reps[i], groupObject.get_Renamed(childIndexName, i));
				}
			}
			else
			{
				if (reps.Count > 0)
				{
					parseRep((System.Xml.XmlElement) reps[0], groupObject.get_Renamed(childIndexName, 0));
				}
				
				if (reps.Count > 1)
				{
					System.String newIndexName = groupObject.addNonstandardSegment(childName);
					for (int i = 1; i < reps.Count; i++)
					{
						parseRep((System.Xml.XmlElement) reps[i], groupObject.get_Renamed(newIndexName, i - 1));
					}
				}
			}
		}
		
		private void  parseRep(System.Xml.XmlElement theElem, Structure theObj)
		{
			if (theObj is Group)
			{
				parse((Group) theObj, theElem);
			}
			else if (theObj is Segment)
			{
				parse((Segment) theObj, theElem);
			}
		}
		
		//includes direct children only
		private System.Collections.IList getChildElementsByTagName(System.Xml.XmlElement theElement, System.String theName)
		{
			System.Collections.IList result = new System.Collections.ArrayList(10);
			System.Xml.XmlNodeList children = theElement.ChildNodes;
			
			for (int i = 0; i < children.Count; i++)
			{
				System.Xml.XmlNode child = children.Item(i);
				if (System.Convert.ToInt16(child.NodeType) == (short) System.Xml.XmlNodeType.Element && child.Name.Equals(theName))
				{
					result.Add(child);
				}
			}
			
			return result;
		}
		
		/// <summary> Given the name of a group element in an XML message, returns the corresponding 
		/// group class name.  This name is identical except in order to be a valid class 
		/// name, the dot character immediately following the message name is replaced with 
		/// an underscore.  For example, there is a group element called ADT_A01.INSURANCE and the 
		/// corresponding group Class is called ADT_A01_INSURANCE. 
		/// </summary>
		//    protected static String makeGroupClassName(String elementName) {
		//        return elementName.replace('.', '_');
		//    }
		
		/// <summary> Given the name of a message and a Group class, returns the corresponding group element name in an 
		/// XML-encoded message.  This is the message name and group name separated by a dot. For example, 
		/// ADT_A01.INSURANCE.
		/// 
		/// If it looks like a segment name (i.e. has 3 characters), no change is made. 
		/// </summary>
		protected internal static System.String makeGroupElementName(System.String messageName, System.String className)
		{
			System.String ret = null;
			
			if (className.Length > 4)
			{
				System.Text.StringBuilder elementName = new System.Text.StringBuilder();
				elementName.Append(messageName);
				elementName.Append('.');
				elementName.Append(className);
				ret = elementName.ToString();
			}
			else if (className.Length == 4)
			{
				ret = className.Substring(0, (3) - (0));
			}
			else
			{
				ret = className;
			}
			
			return ret;
		}
	}
}