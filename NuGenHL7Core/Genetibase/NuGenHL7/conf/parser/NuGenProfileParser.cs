/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "ProfileParser.java".  Description: 
/// "Parses a Message Profile XML document into a RuntimeProfile object." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2003.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  ?GPL?), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
using MetaData = Genetibase.NuGenHL7.conf.spec.MetaData;
using RuntimeProfile = Genetibase.NuGenHL7.conf.spec.RuntimeProfile;
using AbstractComponent = Genetibase.NuGenHL7.conf.spec.message.AbstractComponent;
using AbstractSegmentContainer = Genetibase.NuGenHL7.conf.spec.message.AbstractSegmentContainer;
using Component = Genetibase.NuGenHL7.conf.spec.message.Component;
using DataValue = Genetibase.NuGenHL7.conf.spec.message.DataValue;
using Field = Genetibase.NuGenHL7.conf.spec.message.Field;
using ProfileStructure = Genetibase.NuGenHL7.conf.spec.message.ProfileStructure;
using Seg = Genetibase.NuGenHL7.conf.spec.message.Seg;
using SegGroup = Genetibase.NuGenHL7.conf.spec.message.SegGroup;
using StaticDef = Genetibase.NuGenHL7.conf.spec.message.StaticDef;
using SubComponent = Genetibase.NuGenHL7.conf.spec.message.SubComponent;
using org.xml.sax;
using System.Xml;

namespace org.xml.sax
{
    public interface NuGenEntityResolver
    {
        XmlSourceSupport resolveEntity(String publicId, String systemId);
    }
}

namespace Genetibase.NuGenHL7.conf.parser
{
	
	/// <summary> Parses a Message Profile XML document into a RuntimeProfile object.  A 
	/// Message Profile is a formal description of additional constraints on a 
	/// message (beyond what is specified in the HL7 specification), usually for  
	/// a particular system, region, etc.  Message profiles are introduced in 
	/// HL7 version 2.5 section 2.12.  The RuntimeProfile object is simply an 
	/// object representation of the profile, which may be used for validating  
	/// messages or editing the profile.   
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenProfileParser
	{
		private class AnonymousClassErrorHandler : XmlSaxErrorHandler
		{
			public AnonymousClassErrorHandler(NuGenProfileParser enclosingInstance)
			{
				InitBlock(enclosingInstance);
			}
			private void  InitBlock(NuGenProfileParser enclosingInstance)
			{
				this.enclosingInstance = enclosingInstance;
			}
			private NuGenProfileParser enclosingInstance;
			public NuGenProfileParser Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			public virtual void  error(System.Xml.XmlException e)
			{
				throw e;
			}
			public virtual void  fatalError(System.Xml.XmlException e)
			{
				throw e;
			}
			public virtual void  warning(System.Xml.XmlException e)
			{
				System.Console.Error.WriteLine("Warning: " + e.Message);
			}
		}

		private class AnonymousClassEntityResolver : NuGenEntityResolver
		{
			public AnonymousClassEntityResolver(System.String grammar, NuGenProfileParser enclosingInstance)
			{
				InitBlock(grammar, enclosingInstance);
			}
			private void  InitBlock(System.String grammar, NuGenProfileParser enclosingInstance)
			{
				this.grammar = grammar;
				this.enclosingInstance = enclosingInstance;
			}
			private System.String grammar;
			private NuGenProfileParser enclosingInstance;
			public NuGenProfileParser Enclosing_Instance
			{
				get
				{
					return enclosingInstance;
				}
				
			}
			//returns the grammar we specify no matter what the document declares
			public virtual XmlSourceSupport resolveEntity(System.String publicID, System.String systemID)
			{
				return new XmlSourceSupport(new System.IO.MemoryStream(new System.Text.ASCIIEncoding().GetBytes(grammar)));
			}
		}
		private bool alwaysValidate;
		
		/// <summary> Creates a new instance of ProfileParser </summary>
		/// <param name="alwaysValidateAgainstDTD">if true, validates all profiles against a 
		/// local copy of the profile DTD; if false, validates against declared 
		/// grammar (if any)
		/// </param>
		public NuGenProfileParser(bool alwaysValidateAgainstDTD)
		{
			this.alwaysValidate = alwaysValidateAgainstDTD;
		}
		
		/// <summary>Loads the XML grammar from disk </summary>
		private System.String loadGrammar()
		{
            System.IO.StreamReader dtdReader = new System.IO.StreamReader("ca/uhn/hl7v2/conf/parser/message_profile.dtd");
			System.String line = null;
			System.Text.StringBuilder dtd = new System.Text.StringBuilder();
			while ((line = dtdReader.ReadLine()) != null)
			{
				dtd.Append(line);
				dtd.Append("\r\n");
			}
			return dtd.ToString();
		}
		
		/// <summary> Parses an XML profile string into a RuntimeProfile object.  </summary>
		public virtual RuntimeProfile parse(System.String profileString)
		{
			RuntimeProfile profile = new RuntimeProfile();
			System.Xml.XmlDocument doc = parseIntoDOM(profileString);
			
			System.Xml.XmlElement root = (System.Xml.XmlElement) doc.DocumentElement;
			profile.setHL7Version(root.GetAttribute("HL7Version"));
			
			//get static definition
			System.Xml.XmlNodeList nl = root.GetElementsByTagName("HL7v2xStaticDef");
			System.Xml.XmlElement staticDef = (System.Xml.XmlElement) nl.Item(0);
			StaticDef sd = parseStaticProfile(staticDef);
			profile.Message = sd;
			return profile;
		}
		
		private StaticDef parseStaticProfile(System.Xml.XmlElement elem)
		{
			StaticDef message = new StaticDef();
			message.MsgType = elem.GetAttribute("MsgType");
			message.EventType = elem.GetAttribute("EventType");
			message.MsgStructID = elem.GetAttribute("MsgStructID");
			message.OrderControl = elem.GetAttribute("OrderControl");
			message.EventDesc = elem.GetAttribute("EventDesc");
			message.Identifier = elem.GetAttribute("identifier");
			message.Role = elem.GetAttribute("role");
			
			System.Xml.XmlElement md = getFirstElementByTagName("MetaData", elem);
			if (md != null)
				message.MetaData = parseMetaData(md);
			
			message.ImpNote = getValueOfFirstElement("ImpNote", elem);
			message.Description = getValueOfFirstElement("Description", elem);
			message.Reference = getValueOfFirstElement("Reference", elem);
			
			parseChildren(message, elem);
			return message;
		}
		
		/// <summary>Parses metadata element </summary>
		private MetaData parseMetaData(System.Xml.XmlElement elem)
		{
			return null;
		}
		
		/// <summary>Parses children (i.e. segment groups, segments) of a segment group or message profile </summary>
		private void  parseChildren(AbstractSegmentContainer parent, System.Xml.XmlElement elem)
		{
			int childIndex = 1;
			System.Xml.XmlNodeList children = elem.ChildNodes;
			for (int i = 0; i < children.Count; i++)
			{
				System.Xml.XmlNode n = children.Item(i);
				if (System.Convert.ToInt16(n.NodeType) == (short) System.Xml.XmlNodeType.Element)
				{
					System.Xml.XmlElement child = (System.Xml.XmlElement) n;
					if (child.Name.ToUpper().Equals("SegGroup".ToUpper()))
					{
						SegGroup group = parseSegmentGroupProfile(child);
						parent.setChild(childIndex++, group);
					}
					else if (child.Name.ToUpper().Equals("Segment".ToUpper()))
					{
						Seg segment = parseSegmentProfile(child);
						parent.setChild(childIndex++, segment);
					}
				}
			}
		}
		
		/// <summary>Parses a segment group profile </summary>
		private SegGroup parseSegmentGroupProfile(System.Xml.XmlElement elem)
		{
			SegGroup group = new SegGroup();
			
			parseProfileStuctureData(group, elem);
			
			parseChildren(group, elem);
			return group;
		}
		
		/// <summary>Parses a segment profile </summary>
		private Seg parseSegmentProfile(System.Xml.XmlElement elem)
		{
			Seg segment = new Seg();
			
			parseProfileStuctureData(segment, elem);
			
			int childIndex = 1;
			System.Xml.XmlNodeList children = elem.ChildNodes;
			for (int i = 0; i < children.Count; i++)
			{
				System.Xml.XmlNode n = children.Item(i);
				if (System.Convert.ToInt16(n.NodeType) == (short) System.Xml.XmlNodeType.Element)
				{
					System.Xml.XmlElement child = (System.Xml.XmlElement) n;
					if (child.Name.ToUpper().Equals("Field".ToUpper()))
					{
						Field field = parseFieldProfile(child);
						segment.setField(childIndex++, field);
					}
				}
			}
			
			return segment;
		}
		
		/// <summary>Parse common data in profile structure (eg SegGroup, Segment) </summary>
		private void  parseProfileStuctureData(ProfileStructure struct_Renamed, System.Xml.XmlElement elem)
		{
			struct_Renamed.Name = elem.GetAttribute("Name");
			struct_Renamed.LongName = elem.GetAttribute("LongName");
			struct_Renamed.Usage = elem.GetAttribute("Usage");
			System.String min = elem.GetAttribute("Min");
			System.String max = elem.GetAttribute("Max");
			try
			{
				struct_Renamed.Min = System.Int16.Parse(min);
				if (max.IndexOf('*') >= 0)
				{
					struct_Renamed.Max = (short) (- 1);
				}
				else
				{
					struct_Renamed.Max = System.Int16.Parse(max);
				}
			}
			catch (System.FormatException e)
			{
				throw new NuGenProfileException("Min and max must be short integers: " + min + ", " + max, e);
			}
			
			struct_Renamed.ImpNote = getValueOfFirstElement("ImpNote", elem);
			struct_Renamed.Description = getValueOfFirstElement("Description", elem);
			struct_Renamed.Reference = getValueOfFirstElement("Reference", elem);
			struct_Renamed.Predicate = getValueOfFirstElement("Predicate", elem);
		}
		
		/// <summary>Parses a field profile </summary>
		private Field parseFieldProfile(System.Xml.XmlElement elem)
		{
			Field field = new Field();
			
			field.Usage = elem.GetAttribute("Usage");
			System.String itemNo = elem.GetAttribute("ItemNo");
			System.String min = elem.GetAttribute("Min");
			System.String max = elem.GetAttribute("Max");
			
			try
			{
				if (itemNo.Length > 0)
				{
					field.ItemNo = System.Int16.Parse(itemNo);
				}
			}
			catch (System.FormatException e)
			{
				throw new NuGenProfileException("Invalid ItemNo: " + itemNo + "( for name " + elem.GetAttribute("Name") + ")", e);
			} // try-catch
			
			try
			{
				field.Min = System.Int16.Parse(min);
				if (max.IndexOf('*') >= 0)
				{
					field.Max = (short) (- 1);
				}
				else
				{
					field.Max = System.Int16.Parse(max);
				}
			}
			catch (System.FormatException e)
			{
				throw new NuGenProfileException("Min and max must be short integers: " + min + ", " + max, e);
			}
			
			parseAbstractComponentData(field, elem);
			
			int childIndex = 1;
			System.Xml.XmlNodeList children = elem.ChildNodes;
			for (int i = 0; i < children.Count; i++)
			{
				System.Xml.XmlNode n = children.Item(i);
				if (System.Convert.ToInt16(n.NodeType) == (short) System.Xml.XmlNodeType.Element)
				{
					System.Xml.XmlElement child = (System.Xml.XmlElement) n;
					if (child.Name.ToUpper().Equals("Component".ToUpper()))
					{
						Component comp = (Component) parseComponentProfile(child, false);
						field.setComponent(childIndex++, comp);
					}
				}
			}
			
			return field;
		}
		
		/// <summary>Parses a component profile </summary>
		private AbstractComponent parseComponentProfile(System.Xml.XmlElement elem, bool isSubComponent)
		{
			AbstractComponent comp = null;
			if (isSubComponent)
			{
				comp = new SubComponent();
			}
			else
			{
				comp = new Component();
				
				int childIndex = 1;
				System.Xml.XmlNodeList children = elem.ChildNodes;
				for (int i = 0; i < children.Count; i++)
				{
					System.Xml.XmlNode n = children.Item(i);
					if (System.Convert.ToInt16(n.NodeType) == (short) System.Xml.XmlNodeType.Element)
					{
						System.Xml.XmlElement child = (System.Xml.XmlElement) n;
						if (child.Name.ToUpper().Equals("SubComponent".ToUpper()))
						{
							SubComponent subcomp = (SubComponent) parseComponentProfile(child, true);
							((Component) comp).setSubComponent(childIndex++, subcomp);
						}
					}
				}
			}
			
			parseAbstractComponentData(comp, elem);
			
			return comp;
		}
		
		/// <summary>Parses common features of AbstractComponents (ie field, component, subcomponent) </summary>
		private void  parseAbstractComponentData(AbstractComponent comp, System.Xml.XmlElement elem)
		{
			comp.Name = elem.GetAttribute("Name");
			comp.Usage = elem.GetAttribute("Usage");
			comp.Datatype = elem.GetAttribute("Datatype");
			System.String length = elem.GetAttribute("Length");
			if (length != null && length.Length > 0)
			{
				try
				{
					comp.Length = System.Int64.Parse(length);
				}
				catch (System.FormatException e)
				{
					throw new NuGenProfileException("Length must be a long integer: " + length, e);
				}
			}
			comp.ConstantValue = elem.GetAttribute("ConstantValue");
			System.String table = elem.GetAttribute("Table");
			if (table != null && table.Length > 0)
			{
				try
				{
					comp.Table = table;
				}
				catch (System.FormatException e)
				{
					throw new NuGenProfileException("Table must be a short integer: " + table, e);
				}
			}
			
			comp.ImpNote = getValueOfFirstElement("ImpNote", elem);
			comp.Description = getValueOfFirstElement("Description", elem);
			comp.Reference = getValueOfFirstElement("Reference", elem);
			comp.Predicate = getValueOfFirstElement("Predicate", elem);
			
			int dataValIndex = 0;
			System.Xml.XmlNodeList children = elem.ChildNodes;
			for (int i = 0; i < children.Count; i++)
			{
				System.Xml.XmlNode n = children.Item(i);
				if (System.Convert.ToInt16(n.NodeType) == (short) System.Xml.XmlNodeType.Element)
				{
					System.Xml.XmlElement child = (System.Xml.XmlElement) n;
					if (child.Name.ToUpper().Equals("DataValues".ToUpper()))
					{
						DataValue val = new DataValue();
						val.ExValue = child.GetAttribute("ExValue");
						comp.setDataValues(dataValIndex++, val);
					}
				}
			}
		}
		
		/// <summary>Parses profile string into DOM document </summary>
		private System.Xml.XmlDocument parseIntoDOM(System.String profileString)
		{
			if (this.alwaysValidate)
				profileString = insertDoctype(profileString);
			System.Xml.XmlDocument doc = null;
			try
			{
				lock (this)
				{
                    XmlTextReader reader = new XmlTextReader(new System.IO.MemoryStream(new System.Text.ASCIIEncoding().GetBytes(profileString)));
                    System.Data.DataSet data = new System.Data.DataSet();
                    data.ReadXml(reader);
                    doc = new XmlDataDocument(data);
				}
			}
			catch (System.Xml.XmlException se)
			{
				throw new NuGenProfileException("SAXException parsing message profile: " + se.Message);
			}
			catch (System.IO.IOException ioe)
			{
				throw new NuGenProfileException("IOException parsing message profile: " + ioe.Message);
			}
			return doc;
		}
		
		/// <summary>Inserts a DOCTYPE declaration in the string if there isn't one </summary>
		private System.String insertDoctype(System.String profileString)
		{
			System.String result = profileString;
			if (profileString.IndexOf("<!DOCTYPE") < 0)
			{
				System.Text.StringBuilder buf = new System.Text.StringBuilder();
				int loc = profileString.IndexOf("?>");
				if (loc > 0)
				{
					buf.Append(profileString.Substring(0, (loc + 2) - (0)));
					buf.Append("<!DOCTYPE HL7v2xConformanceProfile SYSTEM \"\">");
					buf.Append(profileString.Substring(loc + 2));
					result = buf.ToString();
				}
			}
			return result;
		}
		
		/// <summary> Returns the first child element of the given parent that matches the given 
		/// tag name.  Returns null if no instance of the expected element is present.  
		/// </summary>
		private System.Xml.XmlElement getFirstElementByTagName(System.String name, System.Xml.XmlElement parent)
		{
			System.Xml.XmlNodeList nl = parent.GetElementsByTagName(name);
			System.Xml.XmlElement ret = null;
			if (nl.Count > 0)
			{
				ret = (System.Xml.XmlElement) nl.Item(0);
			}
			return ret;
		}
		
		/// <summary> Gets the result of getFirstElementByTagName() and returns the 
		/// value of that element.  
		/// </summary>
		private System.String getValueOfFirstElement(System.String name, System.Xml.XmlElement parent)
		{
			System.Xml.XmlElement el = getFirstElementByTagName(name, parent);
			System.String val = null;
			if (el != null)
			{
				try
				{
					System.Xml.XmlNode n = el.FirstChild;
					if (System.Convert.ToInt16(n.NodeType) == (short) System.Xml.XmlNodeType.Text)
					{
						val = n.Value;
					}
				}
				catch (System.Exception e)
				{
					throw new NuGenProfileException("Unable to get value of node " + name, e);
				}
			}
			return val;
		}
		
		[STAThread]
		public static void  Main(System.String[] args)
		{
			
			if (args.Length != 1)
			{
				System.Console.Out.WriteLine("Usage: ProfileParser profile_file");
				System.Environment.Exit(1);
			}
			
			try
			{
				System.IO.FileInfo f = new System.IO.FileInfo(args[0]);
				System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(f.FullName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(f.FullName, System.Text.Encoding.Default).CurrentEncoding);
				char[] cbuf = new char[(int) SupportClass.FileLength(f)];
				in_Renamed.Read(cbuf, 0, (int) SupportClass.FileLength(f));
				System.String xml = System.Convert.ToString(cbuf);
				
				NuGenProfileParser pp = new NuGenProfileParser(true);
				RuntimeProfile spec = pp.parse(xml);
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
	}
}