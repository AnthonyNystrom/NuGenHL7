//
// In order to convert some functionality to Visual C#, the Java Language Conversion Assistant
// creates "support classes" that duplicate the original functionality.  
//
// Support classes replicate the functionality of the original code, but in some cases they are 
// substantially different architecturally. Although every effort is made to preserve the 
// original architecture of the application in the converted project, the user should be aware that 
// the primary goal of these support classes is to replicate functionality, and that at times 
// the architecture of the resulting solution may differ somewhat.
//

using System;

	/// <summary>
	/// This interface should be implemented by any class whose instances are intended 
	/// to be executed by a thread.
	/// </summary>
	public interface IThreadRunnable
	{
		/// <summary>
		/// This method has to be implemented in order that starting of the thread causes the object's 
		/// run method to be called in that separately executing thread.
		/// </summary>
		void Run();
	}

	/*******************************/
	/// <summary>
	/// This interface will manage errors during the parsing of a XML document.
	/// </summary>
	public interface XmlSaxErrorHandler
	{
		/// <summary>
		/// This method manage an error exception ocurred during the parsing process.
		/// </summary>
		/// <param name="exception">The exception thrown by the parser.</param>
		void error(System.Xml.XmlException exception);

		/// <summary>
		/// This method manage a fatal error exception ocurred during the parsing process.
		/// </summary>
		/// <param name="exception">The exception thrown by the parser.</param>
		void fatalError(System.Xml.XmlException exception);

		/// <summary>
		/// This method manage a warning exception ocurred during the parsing process.
		/// </summary>
		/// <param name="exception">The exception thrown by the parser.</param>
		void warning(System.Xml.XmlException exception);
	}

	/*******************************/
	/// <summary>
	/// This class is used to encapsulate a source of Xml code in an single class.
	/// </summary>
	public class XmlSourceSupport
	{
		private System.IO.Stream bytes;
		private System.IO.StreamReader characters;
		private System.String uri;

		/// <summary>
		/// Constructs an empty XmlSourceSupport instance.
		/// </summary>
		public XmlSourceSupport()
		{
			bytes = null;
			characters = null;
			uri = null;
		}

		/// <summary>
		/// Constructs a XmlSource instance with the specified source System.IO.Stream.
		/// </summary>
		/// <param name="stream">The stream containing the document.</param>
		public XmlSourceSupport(System.IO.Stream stream)
		{
			bytes = stream;
			characters = null;
			uri = null;
		}

		/// <summary>
		/// Constructs a XmlSource instance with the specified source System.IO.StreamReader.
		/// </summary>
		/// <param name="reader">The reader containing the document.</param>
		public XmlSourceSupport(System.IO.StreamReader reader)
		{
			bytes = null;
			characters = reader;
			uri = null;
		}

		/// <summary>
		/// Construct a XmlSource instance with the specified source Uri string.
		/// </summary>
		/// <param name="source">The source containing the document.</param>
		public XmlSourceSupport(System.String source)
		{
			bytes = null;
			characters = null;
			uri = source;
		}

		/// <summary>
		/// Represents the source Stream of the XmlSource.
		/// </summary>
		public System.IO.Stream Bytes	
		{
			get
			{
				return bytes;
			}
			set
			{
				bytes = value;
			}
		}

		/// <summary>
		/// Represents the source StreamReader of the XmlSource.
		/// </summary>
		public System.IO.StreamReader Characters
		{
			get
			{
				return characters;
			}
			set
			{
				characters = value;
			}
		}

		/// <summary>
		/// Represents the source URI of the XmlSource.
		/// </summary>
		public System.String Uri
		{
			get
			{
				return uri;
			}
			set
			{
				uri = value;
			}
		}
	}

	/*******************************/
	/// <summary>
	/// Basic interface for resolving entities.
	/// </summary>
	public interface XmlSaxEntityResolver
	{
		/// <summary>
		/// Allow the application to resolve external entities.
		/// </summary>
		/// <param name="publicId">The public identifier of the external entity being referenced, or null if none was supplied.</param>
		/// <param name="systemId">The system identifier of the external entity being referenced.</param>
		/// <returns>A XmlSourceSupport object describing the new input source, or null to request that the parser open a regular URI connection to the system identifier.</returns>
		XmlSourceSupport resolveEntity(System.String publicId, System.String systemId);
	}

	/*******************************/
	/// <summary>
	/// This interface will manage the Content events of a XML document.
	/// </summary>
	public interface XmlSaxContentHandler
	{
		/// <summary>
		/// This method manage the notification when Characters elements were found.
		/// </summary>
		/// <param name="ch">The array with the characters found.</param>
		/// <param name="start">The index of the first position of the characters found.</param>
		/// <param name="length">Specify how many characters must be read from the array.</param>
		void characters(char[] ch, int start, int length);

		/// <summary>
		/// This method manage the notification when the end document node were found.
		/// </summary>
		void endDocument();

		/// <summary>
		/// This method manage the notification when the end element node was found.
		/// </summary>
		/// <param name="namespaceURI">The namespace URI of the element.</param>
		/// <param name="localName">The local name of the element.</param>
		/// <param name="qName">The long (qualified) name of the element.</param>
		void endElement(System.String namespaceURI, System.String localName, System.String qName);

		/// <summary>
		/// This method manage the event when an area of expecific URI prefix was ended.
		/// </summary>
		/// <param name="prefix">The prefix that ends.</param>
		void endPrefixMapping(System.String prefix);

		/// <summary>
		/// This method manage the event when a ignorable whitespace node was found.
		/// </summary>
		/// <param name="Ch">The array with the ignorable whitespaces.</param>
		/// <param name="Start">The index in the array with the ignorable whitespace.</param>
		/// <param name="Length">The length of the whitespaces.</param>
		void ignorableWhitespace(char[] Ch, int Start, int Length);

		/// <summary>
		/// This method manage the event when a processing instruction was found.
		/// </summary>
		/// <param name="target">The processing instruction target.</param>
		/// <param name="data">The processing instruction data.</param>
		void processingInstruction(System.String target, System.String data);

		/// <summary>
		/// This method is not supported, it is included for compatibility.
		/// </summary>
		void setDocumentLocator(XmlSaxLocator locator);

		/// <summary>
		/// This method manage the event when a skipped entity was found.
		/// </summary>
		/// <param name="name">The name of the skipped entity.</param>
		void skippedEntity(System.String name);

		/// <summary>
		/// This method manage the event when a start document node was found.
		/// </summary>
		void startDocument();

		/// <summary>
		/// This method manage the event when a start element node was found.
		/// </summary>
		/// <param name="namespaceURI">The namespace uri of the element tag.</param>
		/// <param name="localName">The local name of the element.</param>
		/// <param name="qName">The long (qualified) name of the element.</param>
		/// <param name="atts">The list of attributes of the element.</param>
		void startElement(System.String namespaceURI, System.String localName, System.String qName, SaxAttributesSupport atts);

		/// <summary>
		/// This methods indicates the start of a prefix area in the XML document.
		/// </summary>
		/// <param name="prefix">The prefix of the area.</param>
		/// <param name="uri">The namespace URI of the prefix area.</param>
		void startPrefixMapping(System.String prefix, System.String uri);
	}

	/*******************************/
	/// <summary>
	/// This interface is created to emulate the SAX Locator interface behavior.
	/// </summary>
	public interface XmlSaxLocator
	{
		/// <summary>
		/// This method return the column number where the current document event ends.
		/// </summary>
		/// <returns>The column number where the current document event ends.</returns>
		int getColumnNumber();

		/// <summary>
		/// This method return the line number where the current document event ends.
		/// </summary>
		/// <returns>The line number where the current document event ends.</returns>
		int getLineNumber();

		/// <summary>
		/// This method is not supported, it is included for compatibility.	
		/// </summary>
		/// <returns>The saved public identifier.</returns>
		System.String getPublicId();

		/// <summary>
		/// This method is not supported, it is included for compatibility.		
		/// </summary>
		/// <returns>The saved system identifier.</returns>
		System.String getSystemId();
	}

	/*******************************/
	/// <summary>
	/// This class is created for emulates the SAX LocatorImpl behaviors.
	/// </summary>
	public class XmlSaxLocatorImpl : XmlSaxLocator
	{
		/// <summary>
		/// This method returns a new instance of 'XmlSaxLocatorImpl'.
		/// </summary>
		/// <returns>A new 'XmlSaxLocatorImpl' instance.</returns>
		public XmlSaxLocatorImpl()
		{
		}

		/// <summary>
		/// This method returns a new instance of 'XmlSaxLocatorImpl'.
		/// Create a persistent copy of the current state of a locator.
		/// </summary>
		/// <param name="locator">The current state of a locator.</param>
		/// <returns>A new 'XmlSaxLocatorImpl' instance.</returns>
		public XmlSaxLocatorImpl(XmlSaxLocator locator)
		{
			setPublicId(locator.getPublicId());
			setSystemId(locator.getSystemId());
			setLineNumber(locator.getLineNumber());
			setColumnNumber(locator.getColumnNumber());
		}

		/// <summary>
		/// This method is not supported, it is included for compatibility.
		/// Return the saved public identifier.
		/// </summary>
		/// <returns>The saved public identifier.</returns>
		public virtual System.String getPublicId()
		{
			return publicId;
		}

		/// <summary>
		/// This method is not supported, it is included for compatibility.
		/// Return the saved system identifier.
		/// </summary>
		/// <returns>The saved system identifier.</returns>
		public virtual System.String getSystemId()
		{
			return systemId;
		}

		/// <summary>
		/// Return the saved line number.
		/// </summary>
		/// <returns>The saved line number.</returns>
		public virtual int getLineNumber()
		{
			return lineNumber;
		}

		/// <summary>
		/// Return the saved column number.
		/// </summary>
		/// <returns>The saved column number.</returns>
		public virtual int getColumnNumber()
		{
			return columnNumber;
		}

		/// <summary>
		/// This method is not supported, it is included for compatibility.
		/// Set the public identifier for this locator.
		/// </summary>
		/// <param name="publicId">The new public identifier.</param>
		public virtual void setPublicId(System.String publicId)
		{
			this.publicId = publicId;
		}

		/// <summary>
		/// This method is not supported, it is included for compatibility.
		/// Set the system identifier for this locator.
		/// </summary>
		/// <param name="systemId">The new system identifier.</param>
		public virtual void setSystemId(System.String systemId)
		{
			this.systemId = systemId;
		}

		/// <summary>
		/// Set the line number for this locator.
		/// </summary>
		/// <param name="lineNumber">The line number.</param>
		public virtual void setLineNumber(int lineNumber)
		{
			this.lineNumber = lineNumber;
		}

		/// <summary>
		/// Set the column number for this locator.
		/// </summary>
		/// <param name="columnNumber">The column number.</param>
		public virtual void setColumnNumber(int columnNumber)
		{
			this.columnNumber = columnNumber;
		}

		// Internal state.
		private System.String publicId;
		private System.String systemId;
		private int lineNumber;
		private int columnNumber;
	}

	/*******************************/
	/// <summary>
	/// This interface will manage the Content events of a XML document.
	/// </summary>
	public interface XmlSaxLexicalHandler
	{
		/// <summary>
		/// This method manage the notification when Characters elements were found.
		/// </summary>
		/// <param name="ch">The array with the characters found.</param>
		/// <param name="start">The index of the first position of the characters found.</param>
		/// <param name="length">Specify how many characters must be read from the array.</param>
		void comment(char[] ch, int start, int length);

		/// <summary>
		/// This method manage the notification when the end of a CDATA section were found.
		/// </summary>
		void endCDATA();

		/// <summary>
		/// This method manage the notification when the end of DTD declarations were found.
		/// </summary>
		void endDTD();

		/// <summary>
		/// This method report the end of an entity.
		/// </summary>
		/// <param name="name">The name of the entity that is ending.</param>
		void endEntity(System.String name);

		/// <summary>
		/// This method manage the notification when the start of a CDATA section were found.
		/// </summary>
		void startCDATA();

		/// <summary>
		/// This method manage the notification when the start of DTD declarations were found.
		/// </summary>
		/// <param name="name">The name of the DTD entity.</param>
		/// <param name="publicId">The public identifier.</param>
		/// <param name="systemId">The system identifier.</param>
		void startDTD(System.String name, System.String publicId, System.String systemId);

		/// <summary>
		/// This method report the start of an entity.
		/// </summary>
		/// <param name="name">The name of the entity that is ending.</param>
		void startEntity(System.String name);
	}

	/*******************************/
	/// <summary>
	/// This class will manage all the parsing operations emulating the SAX parser behavior
	/// </summary>
	public class SaxAttributesSupport
	{
		private System.Collections.ArrayList MainList;

		/// <summary>
		/// Builds a new instance of SaxAttributesSupport.
		/// </summary>
		public SaxAttributesSupport()
		{
			MainList = new System.Collections.ArrayList();
		}

		/// <summary>
		/// Creates a new instance of SaxAttributesSupport from an ArrayList of Att_Instance class.
		/// </summary>
		/// <param name="arrayList">An ArraList of Att_Instance class instances.</param>
		/// <returns>A new instance of SaxAttributesSupport</returns>
		public SaxAttributesSupport(SaxAttributesSupport List)
		{
			SaxAttributesSupport temp = new SaxAttributesSupport();
			temp.MainList = (System.Collections.ArrayList) List.MainList.Clone();
		}

		/// <summary>
		/// Adds a new attribute elment to the given SaxAttributesSupport instance.
		/// </summary>
		/// <param name="Uri">The Uri of the attribute to be added.</param>
		/// <param name="Lname">The Local name of the attribute to be added.</param>
		/// <param name="Qname">The Long(qualify) name of the attribute to be added.</param>
		/// <param name="Type">The type of the attribute to be added.</param>
		/// <param name="Value">The value of the attribute to be added.</param>
		public virtual void Add(System.String Uri, System.String Lname, System.String Qname, System.String Type, System.String Value)
		{
			Att_Instance temp_Attributes = new Att_Instance(Uri, Lname, Qname, Type, Value);
			MainList.Add(temp_Attributes);
		}

		/// <summary>
		/// Clears the list of attributes in the given AttributesSupport instance.
		/// </summary>
		public virtual void Clear()
		{
			MainList.Clear();
		}

		/// <summary>
		/// Obtains the index of an attribute of the AttributeSupport from its qualified (long) name.
		/// </summary>
		/// <param name="Qname">The qualified name of the attribute to search.</param>
		/// <returns>An zero-based index of the attribute if it is found, otherwise it returns -1.</returns>
		public virtual int GetIndex(System.String Qname)
		{
			int index = GetLength() - 1;
			while ((index >= 0) && !(((Att_Instance) (MainList[index])).att_fullName.Equals(Qname)))
				index--;
			if (index >= 0)
				return index;
			else
				return -1;
		}

		/// <summary>
		/// Obtains the index of an attribute of the AttributeSupport from its namespace URI and its localname.
		/// </summary>
		/// <param name="Uri">The namespace URI of the attribute to search.</param>
		/// <param name="Lname">The local name of the attribute to search.</param>
		/// <returns>An zero-based index of the attribute if it is found, otherwise it returns -1.</returns>
		public virtual int GetIndex(System.String Uri, System.String Lname)
		{
			int index = GetLength() - 1;
			while ((index >= 0) && !(((Att_Instance) (MainList[index])).att_localName.Equals(Lname) && ((Att_Instance)(MainList[index])).att_URI.Equals(Uri)))
				index--;
			if (index >= 0)
				return index;
			else
				return -1;
		}

		/// <summary>
		/// Returns the number of attributes saved in the SaxAttributesSupport instance.
		/// </summary>
		/// <returns>The number of elements in the given SaxAttributesSupport instance.</returns>
		public virtual int GetLength()
		{
			return MainList.Count;
		}

		/// <summary>
		/// Returns the local name of the attribute in the given SaxAttributesSupport instance that indicates the given index.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <returns>The local name of the attribute indicated by the index or null if the index is out of bounds.</returns>
		public virtual System.String GetLocalName(int index)
		{
			try
			{
				return ((Att_Instance) MainList[index]).att_localName;
			}
			catch (System.ArgumentOutOfRangeException)
			{
				return "";
			}
		}

		/// <summary>
		/// Returns the qualified name of the attribute in the given SaxAttributesSupport instance that indicates the given index.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <returns>The qualified name of the attribute indicated by the index or null if the index is out of bounds.</returns>
		public virtual System.String GetFullName(int index)
		{
			try
			{
				return ((Att_Instance) MainList[index]).att_fullName;
			}
			catch (System.ArgumentOutOfRangeException)
			{
				return "";
			}
		}

		/// <summary>
		/// Returns the type of the attribute in the given SaxAttributesSupport instance that indicates the given index.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <returns>The type of the attribute indicated by the index or null if the index is out of bounds.</returns>
		public virtual System.String GetType(int index)
		{
			try
			{
				return ((Att_Instance) MainList[index]).att_type;
			}
			catch(System.ArgumentOutOfRangeException)
			{
				return "";
			}
		}

		/// <summary>
		/// Returns the namespace URI of the attribute in the given SaxAttributesSupport instance that indicates the given index.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <returns>The namespace URI of the attribute indicated by the index or null if the index is out of bounds.</returns>
		public virtual System.String GetURI(int index)
		{
			try
			{
				return ((Att_Instance) MainList[index]).att_URI;
			}
			catch(System.ArgumentOutOfRangeException)
			{
				return "";
			}
		}

		/// <summary>
		/// Returns the value of the attribute in the given SaxAttributesSupport instance that indicates the given index.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <returns>The value of the attribute indicated by the index or null if the index is out of bounds.</returns>
		public virtual System.String GetValue(int index)
		{
			try
			{
				return ((Att_Instance) MainList[index]).att_value;
			}
			catch(System.ArgumentOutOfRangeException)
			{
				return "";
			}
		}

		/// <summary>
		/// Modifies the local name of the attribute in the given SaxAttributesSupport instance.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <param name="LocalName">The new Local name for the attribute.</param>
		public virtual void SetLocalName(int index, System.String LocalName)
		{
			((Att_Instance) MainList[index]).att_localName = LocalName;
		}

		/// <summary>
		/// Modifies the qualified name of the attribute in the given SaxAttributesSupport instance.
		/// </summary>	
		/// <param name="index">The attribute index.</param>
		/// <param name="FullName">The new qualified name for the attribute.</param>
		public virtual void SetFullName(int index, System.String FullName)
		{
			((Att_Instance) MainList[index]).att_fullName = FullName;
		}

		/// <summary>
		/// Modifies the type of the attribute in the given SaxAttributesSupport instance.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <param name="Type">The new type for the attribute.</param>
		public virtual void SetType(int index, System.String Type)
		{
			((Att_Instance) MainList[index]).att_type = Type;
		}

		/// <summary>
		/// Modifies the namespace URI of the attribute in the given SaxAttributesSupport instance.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <param name="URI">The new namespace URI for the attribute.</param>
		public virtual void SetURI(int index, System.String URI)
		{
			((Att_Instance) MainList[index]).att_URI = URI;
		}

		/// <summary>
		/// Modifies the value of the attribute in the given SaxAttributesSupport instance.
		/// </summary>
		/// <param name="index">The attribute index.</param>
		/// <param name="Value">The new value for the attribute.</param>
		public virtual void SetValue(int index, System.String Value)
		{
			((Att_Instance) MainList[index]).att_value = Value;
		}

		/// <summary>
		/// This method eliminates the Att_Instance instance at the specified index.
		/// </summary>
		/// <param name="index">The index of the attribute.</param>
		public virtual void RemoveAttribute(int index)
		{
			try
			{
				MainList.RemoveAt(index);
			}
			catch(System.ArgumentOutOfRangeException)
			{
				throw new System.IndexOutOfRangeException("The index is out of range");
			}
		}

		/// <summary>
		/// This method eliminates the Att_Instance instance in the specified index.
		/// </summary>
		/// <param name="indexName">The index name of the attribute.</param>
		public virtual void RemoveAttribute(System.String indexName)
		{
			try
			{
				int pos = GetLength() - 1;
				while ((pos >= 0) && !(((Att_Instance) (MainList[pos])).att_localName.Equals(indexName)))
					pos--;
				if (pos >= 0)
					MainList.RemoveAt(pos);
			}
			catch(System.ArgumentOutOfRangeException)
			{
				throw new System.IndexOutOfRangeException("The index is out of range");
			}
		}

		/// <summary>
		/// Replaces an Att_Instance in the given SaxAttributesSupport instance.
		/// </summary>
		/// <param name="index">The index of the attribute.</param>
		/// <param name="Uri">The namespace URI of the new Att_Instance.</param>
		/// <param name="Lname">The local name of the new Att_Instance.</param>
		/// <param name="Qname">The namespace URI of the new Att_Instance.</param>
		/// <param name="Type">The type of the new Att_Instance.</param>
		/// <param name="Value">The value of the new Att_Instance.</param>
		public virtual void SetAttribute(int index, System.String Uri, System.String Lname, System.String Qname, System.String Type, System.String Value)
		{
			MainList[index] = new Att_Instance(Uri, Lname, Qname, Type, Value);
		}

		/// <summary>
		/// Replaces all the list of Att_Instance of the given SaxAttributesSupport instance.
		/// </summary>
		/// <param name="Source">The source SaxAttributesSupport instance.</param>
		public virtual void SetAttributes(SaxAttributesSupport Source)
		{
			MainList = Source.MainList;
		}

		/// <summary>
		/// Returns the type of the Attribute that match with the given qualified name.
		/// </summary>
		/// <param name="Qname">The qualified name of the attribute to search.</param>
		/// <returns>The type of the attribute if it exist otherwise returns null.</returns>
		public virtual System.String GetType(System.String Qname)
		{
			int temp_Index = GetIndex(Qname);
			if (temp_Index != -1)
				return ((Att_Instance) MainList[temp_Index]).att_type;
			else
				return "";
		}

		/// <summary>
		/// Returns the type of the Attribute that match with the given namespace URI and local name.
		/// </summary>
		/// <param name="Uri">The namespace URI of the attribute to search.</param>
		/// <param name="Lname">The local name of the attribute to search.</param>
		/// <returns>The type of the attribute if it exist otherwise returns null.</returns>
		public virtual System.String GetType(System.String Uri, System.String Lname)
		{
			int temp_Index = GetIndex(Uri, Lname);
			if (temp_Index != -1)
				return ((Att_Instance) MainList[temp_Index]).att_type;
			else
				return "";
		}

		/// <summary>
		/// Returns the value of the Attribute that match with the given qualified name.
		/// </summary>
		/// <param name="Qname">The qualified name of the attribute to search.</param>
		/// <returns>The value of the attribute if it exist otherwise returns null.</returns>
		public virtual System.String GetValue(System.String Qname)
		{
			int temp_Index = GetIndex(Qname);
			if (temp_Index != -1)
				return ((Att_Instance) MainList[temp_Index]).att_value;
			else
				return "";
		}

		/// <summary>
		/// Returns the value of the Attribute that match with the given namespace URI and local name.
		/// </summary>
		/// <param name="Uri">The namespace URI of the attribute to search.</param>
		/// <param name="Lname">The local name of the attribute to search.</param>
		/// <returns>The value of the attribute if it exist otherwise returns null.</returns>
		public virtual System.String GetValue(System.String Uri, System.String Lname)
		{
			int temp_Index = GetIndex(Uri, Lname);
			if (temp_Index != -1)
				return ((Att_Instance) MainList[temp_Index]).att_value;
			else
				return "";
		}

		/*******************************/
		/// <summary>
		/// This class is created to save the information of each attributes in the SaxAttributesSupport.
		/// </summary>
		public class Att_Instance 
		{
			public System.String att_URI;
			public System.String att_localName;
			public System.String att_fullName;
			public System.String att_type;
			public System.String att_value;				

			/// <summary>
			/// This is the constructor of the Att_Instance
			/// </summary>
			/// <param name="Uri">The namespace URI of the attribute</param>
			/// <param name="Lname">The local name of the attribute</param>
			/// <param name="Qname">The long(Qualify) name of attribute</param>
			/// <param name="Type">The type of the attribute</param>
			/// <param name="Value">The value of the attribute</param>
			public Att_Instance(System.String Uri, System.String Lname, System.String Qname, System.String Type, System.String Value)
			{
				this.att_URI = Uri;
				this.att_localName = Lname;
				this.att_fullName = Qname;
				this.att_type = Type;
				this.att_value = Value;
			}
		}
	}

	/*******************************/
	/// <summary>
	/// This exception is thrown by the XmlSaxDocumentManager in the SetProperty and SetFeature 
	/// methods if a property or method couldn't be found.
	/// </summary>
	public class ManagerNotRecognizedException : System.Exception
	{
		/// <summary>
		/// Creates a new ManagerNotRecognizedException with the message specified.
		/// </summary>
		/// <param name="Message">Error message of the exception.</param>
		public ManagerNotRecognizedException(System.String Message) : base(Message)
		{
		}
	}

	/*******************************/
	/// <summary>
	/// This exception is thrown by the XmlSaxDocumentManager in the SetProperty and SetFeature methods 
	/// if a property or method couldn't be supported.
	/// </summary>
	public class ManagerNotSupportedException : System.Exception
	{
		/// <summary>
		/// Creates a new ManagerNotSupportedException with the message specified.
		/// </summary>
		/// <param name="Message">Error message of the exception.</param>
		public ManagerNotSupportedException(System.String Message) : base(Message)
		{
		}
	}

	/*******************************/
	/// <summary>
	/// This class provides the base implementation for the management of XML documents parsing.
	/// </summary>
	public class XmlSaxDefaultHandler : XmlSaxContentHandler, XmlSaxErrorHandler, XmlSaxEntityResolver
	{
		/// <summary>
		/// This method manage the notification when Characters element were found.
		/// </summary>
		/// <param name="ch">The array with the characters founds</param>
		/// <param name="start">The index of the first position of the characters found</param>
		/// <param name="length">Specify how many characters must be read from the array</param>
		public virtual void characters(char[] ch, int start, int length) 
		{
		}

		/// <summary>
		/// This method manage the notification when the end document node were found
		/// </summary>
		public virtual void endDocument() 
		{
		}

		/// <summary>
		/// This method manage the notification when the end element node were found
		/// </summary>
		/// <param name="namespaceURI">The namespace URI of the element</param>
		/// <param name="localName">The local name of the element</param>
		/// <param name="qName">The long name (qualify name) of the element</param>
		public virtual void endElement(System.String uri, System.String localName, System.String qName)
		{
		}
	
		/// <summary>
		/// This method manage the event when an area of expecific URI prefix was ended.
		/// </summary>
		/// <param name="prefix">The prefix that ends</param>
		public virtual void endPrefixMapping(System.String prefix)
		{
		}

		/// <summary>
		/// This method manage when an error exception ocurrs in the parsing process
		/// </summary>
		/// <param name="exception">The exception throws by the parser</param>
		public virtual void error(System.Xml.XmlException e)
		{
		}

		/// <summary>
		/// This method manage when a fatal error exception ocurrs in the parsing process
		/// </summary>
		/// <param name="exception">The exception Throws by the parser</param>
		public virtual void fatalError(System.Xml.XmlException e) 
		{
		}

		/// <summary>
		/// This method manage the event when a ignorable whitespace node were found
		/// </summary>
		/// <param name="Ch">The array with the ignorable whitespaces</param>
		/// <param name="Start">The index in the array with the ignorable whitespace</param>
		/// <param name="Length">The length of the whitespaces</param>
		public virtual void ignorableWhitespace(char[] ch, int start, int length)
		{
		}

		/// <summary>
		/// This method is not supported only is created for compatibility
		/// </summary>
		public virtual void notationDecl(System.String name, System.String publicId, System.String systemId) 
		{
		}

		/// <summary>
		/// This method manage the event when a processing instruction were found
		/// </summary>
		/// <param name="target">The processing instruction target</param>
		/// <param name="data">The processing instruction data</param>
		public virtual void processingInstruction(System.String target, System.String data) 
		{
		}

		/// <summary>
		/// Allow the application to resolve external entities.
		/// </summary>
		/// <param name="publicId">The public identifier of the external entity being referenced, or null if none was supplied.</param>
		/// <param name="systemId">The system identifier of the external entity being referenced.</param>
		/// <returns>A XmlSourceSupport object describing the new input source, or null to request that the parser open a regular URI connection to the system identifier.</returns>
		public virtual XmlSourceSupport resolveEntity(System.String publicId, System.String systemId)
		{
			return null;
		}

		/// <summary>
		/// This method is not supported, is include for compatibility
		/// </summary>		 
		public virtual void setDocumentLocator(XmlSaxLocator locator)
		{
		}

		/// <summary>
		/// This method manage the event when a skipped entity were found
		/// </summary>
		/// <param name="name">The name of the skipped entity</param>
		public virtual void skippedEntity(System.String name)
		{
		}

		/// <summary>
		/// This method manage the event when a start document node were found 
		/// </summary>
		public virtual void startDocument()
		{
		}

		/// <summary>
		/// This method manage the event when a start element node were found
		/// </summary>
		/// <param name="namespaceURI">The namespace uri of the element tag</param>
		/// <param name="localName">The local name of the element</param>
		/// <param name="qName">The Qualify (long) name of the element</param>
		/// <param name="atts">The list of attributes of the element</param>
		public virtual void startElement(System.String uri, System.String localName, System.String qName, SaxAttributesSupport attributes) 
		{
		}

		/// <summary>
		/// This methods indicates the start of a prefix area in the XML document.
		/// </summary>
		/// <param name="prefix">The prefix of the area</param>
		/// <param name="uri">The namespace uri of the prefix area</param>
		public virtual void startPrefixMapping(System.String prefix, System.String uri) 
		{
		}

		/// <summary>
		/// This method is not supported only is created for compatibility
		/// </summary>        
		public virtual void unparsedEntityDecl(System.String name, System.String publicId, System.String systemId, System.String notationName)
		{
		}

		/// <summary>
		/// This method manage when a warning exception ocurrs in the parsing process
		/// </summary>
		/// <param name="exception">The exception Throws by the parser</param>
		public virtual void warning(System.Xml.XmlException e)
		{
		}
	}
	/*******************************/
	/// <summary>
	/// This class provides the base implementation for the management of XML documents parsing.
	/// </summary>
	public class XmlSaxParserAdapter : XmlSAXDocumentManager, XmlSaxContentHandler 
	{

		/// <summary>
		/// This method manage the notification when Characters element were found.
		/// </summary>
		/// <param name="ch">The array with the characters founds</param>
		/// <param name="start">The index of the first position of the characters found</param>
		/// <param name="length">Specify how many characters must be read from the array</param>
		public virtual void characters(char[] ch, int start, int length){}

		/// <summary>
		/// This method manage the notification when the end document node were found
		/// </summary>
		public virtual void endDocument(){}

		/// <summary>
		/// This method manage the notification when the end element node were found
		/// </summary>
		/// <param name="namespaceURI">The namespace URI of the element</param>
		/// <param name="localName">The local name of the element</param>
		/// <param name="qName">The long name (qualify name) of the element</param>
		public virtual void endElement(System.String namespaceURI, System.String localName, System.String qName){}

		/// <summary>
		/// This method manage the event when an area of expecific URI prefix was ended.
		/// </summary>
		/// <param name="prefix">The prefix that ends.</param>
		public virtual void endPrefixMapping(System.String prefix){}

		/// <summary>
		/// This method manage the event when a ignorable whitespace node were found
		/// </summary>
		/// <param name="ch">The array with the ignorable whitespaces</param>
		/// <param name="start">The index in the array with the ignorable whitespace</param>
		/// <param name="length">The length of the whitespaces</param>
		public virtual void ignorableWhitespace(char[] ch, int start, int length){}

		/// <summary>
		/// This method manage the event when a processing instruction were found
		/// </summary>
		/// <param name="target">The processing instruction target</param>
		/// <param name="data">The processing instruction data</param>
		public virtual void processingInstruction(System.String target, System.String data){}

		/// <summary>
		/// Receive an object for locating the origin of events into the XML document
		/// </summary>
		/// <param name="locator">A 'XmlSaxLocator' object that can return the location of any events into the XML document</param>
		public virtual void setDocumentLocator(XmlSaxLocator locator){}

		/// <summary>
		/// This method manage the event when a skipped entity was found.
		/// </summary>
		/// <param name="name">The name of the skipped entity.</param>
		public virtual void skippedEntity(System.String name){}

		/// <summary>
		/// This method manage the event when a start document node were found 
		/// </summary>
		public virtual void startDocument(){}

		/// <summary>
		/// This method manage the event when a start element node were found
		/// </summary>
		/// <param name="namespaceURI">The namespace uri of the element tag</param>
		/// <param name="localName">The local name of the element</param>
		/// <param name="qName">The Qualify (long) name of the element</param>
		/// <param name="qAtts">The list of attributes of the element</param>
		public virtual void startElement(System.String namespaceURI, System.String localName, System.String qName, SaxAttributesSupport qAtts){}

		/// <summary>
		/// This methods indicates the start of a prefix area in the XML document.
		/// </summary>
		/// <param name="prefix">The prefix of the area.</param>
		/// <param name="uri">The namespace URI of the prefix area.</param>
		public virtual void startPrefixMapping(System.String prefix, System.String uri){}

	}


	/*******************************/
	/// <summary>
	/// Emulates the SAX parsers behaviours.
	/// </summary>
	public class XmlSAXDocumentManager
	{	
		protected bool isValidating;
		protected bool namespaceAllowed;
		protected System.Xml.XmlValidatingReader reader;
		protected XmlSaxContentHandler callBackHandler;
		protected XmlSaxErrorHandler errorHandler;
		protected XmlSaxLocatorImpl locator;
		protected XmlSaxLexicalHandler lexical;
		protected XmlSaxEntityResolver entityResolver;
		protected System.String parserFileName;

		/// <summary>
		/// Public constructor for the class.
		/// </summary>
		public XmlSAXDocumentManager()
		{
			isValidating = false;
			namespaceAllowed = false;
			reader = null;
			callBackHandler = null;
			errorHandler = null;
			locator = null;
			lexical = null;
			entityResolver = null;
			parserFileName = "";
		}

		/// <summary>
		/// Returns a new instance of 'XmlSAXDocumentManager'.
		/// </summary>
		/// <returns>A new 'XmlSAXDocumentManager' instance.</returns>
		public static XmlSAXDocumentManager NewInstance()
		{
			return new XmlSAXDocumentManager();
		}

		/// <summary>
		/// Returns a clone instance of 'XmlSAXDocumentManager'.
		/// </summary>
		/// <returns>A clone 'XmlSAXDocumentManager' instance.</returns>
		public static XmlSAXDocumentManager CloneInstance(XmlSAXDocumentManager instance)
		{
			XmlSAXDocumentManager temp = new XmlSAXDocumentManager();
			temp.NamespaceAllowed = instance.NamespaceAllowed;
			temp.isValidating = instance.isValidating;
			XmlSaxContentHandler contentHandler = instance.getContentHandler();
			if (contentHandler != null)
				temp.setContentHandler(contentHandler);
			XmlSaxErrorHandler errorHandler = instance.getErrorHandler();
			if (errorHandler != null)
				temp.setErrorHandler(errorHandler);
			temp.setFeature("http://xml.org/sax/features/namespaces", instance.getFeature("http://xml.org/sax/features/namespaces"));
			temp.setFeature("http://xml.org/sax/features/namespace-prefixes", instance.getFeature("http://xml.org/sax/features/namespace-prefixes"));
			temp.setFeature("http://xml.org/sax/features/validation", instance.getFeature("http://xml.org/sax/features/validation"));
			temp.setProperty("http://xml.org/sax/properties/lexical-handler", instance.getProperty("http://xml.org/sax/properties/lexical-handler"));
			temp.parserFileName = instance.parserFileName;
			return temp;
		}

		/// <summary>
		/// Indicates whether the 'XmlSAXDocumentManager' are validating the XML over a DTD.
		/// </summary>
		public bool IsValidating
		{
			get
			{
				return isValidating;
			}
			set
			{
				isValidating = value;
			}
		}

		/// <summary>
		/// Indicates whether the 'XmlSAXDocumentManager' manager allows namespaces.
		/// </summary>
		public  bool NamespaceAllowed
		{
			get
			{
				return namespaceAllowed;
			}
			set
			{
				namespaceAllowed = value;
			}
		}

		/// <summary>
		/// Emulates the behaviour of a SAX LocatorImpl object.
		/// </summary>
		/// <param name="locator">The 'XmlSaxLocatorImpl' instance to assing the document location.</param>
		/// <param name="textReader">The XML document instance to be used.</param>
		private void UpdateLocatorData(XmlSaxLocatorImpl locator, System.Xml.XmlTextReader textReader)
		{
			if ((locator != null) && (textReader != null))
			{
				locator.setColumnNumber(textReader.LinePosition);
				locator.setLineNumber(textReader.LineNumber);
				locator.setSystemId(parserFileName);
			}
		}

		/// <summary>
		/// Emulates the behavior of a SAX parsers. Set the value of a feature.
		/// </summary>
		/// <param name="name">The feature name, which is a fully-qualified URI.</param>
		/// <param name="value">The requested value for the feature.</param>
		public virtual void setFeature(System.String name, bool value)
		{
			switch (name)
			{
				case "http://xml.org/sax/features/namespaces":
				{
					try
					{
						this.NamespaceAllowed = value;
						break;
					}
					catch
					{
						throw new ManagerNotSupportedException("The specified operation was not performed");
					}
				}
				case "http://xml.org/sax/features/namespace-prefixes":
				{
					try
					{
						this.NamespaceAllowed = value;
						break;
					}
					catch
					{
						throw new ManagerNotSupportedException("The specified operation was not performed");
					}
				}
				case "http://xml.org/sax/features/validation":
				{
					try
					{
						this.isValidating = value;
						break;
					}
					catch
					{
						throw new ManagerNotSupportedException("The specified operation was not performed");
					}
				}
				default:
					throw new ManagerNotRecognizedException("The specified feature: " + name + " are not supported");
			}
		}

		/// <summary>
		/// Emulates the behavior of a SAX parsers. Gets the value of a feature.
		/// </summary>
		/// <param name="name">The feature name, which is a fully-qualified URI.</param>
		/// <returns>The requested value for the feature.</returns>
		public virtual bool getFeature(System.String name)
		{
			switch (name)
			{
				case "http://xml.org/sax/features/namespaces":
				{
					try
					{
						return this.NamespaceAllowed;
					}
					catch
					{
						throw new ManagerNotSupportedException("The specified operation was not performed");
					}
				}
				case "http://xml.org/sax/features/namespace-prefixes":
				{
					try
					{
						return this.NamespaceAllowed;
					}
					catch
					{
						throw new ManagerNotSupportedException("The specified operation was not performed");
					}
				}
				case "http://xml.org/sax/features/validation":
				{
					try
					{
						return this.isValidating;
					}
					catch
					{
						throw new ManagerNotSupportedException("The specified operation was not performed");
					}
				}
				default:
					throw new ManagerNotRecognizedException("The specified feature: " + name +" are not supported");
			}
		}

		/// <summary>
		/// Emulates the behavior of a SAX parsers. Sets the value of a property.
		/// </summary>
		/// <param name="name">The property name, which is a fully-qualified URI.</param>
		/// <param name="value">The requested value for the property.</param>
		public virtual void setProperty(System.String name, System.Object value)
		{
			switch (name)
			{
				case "http://xml.org/sax/properties/lexical-handler":
				{
					try
					{
						lexical = (XmlSaxLexicalHandler) value;
						break;
					}
					catch (System.Exception e)
					{
						throw new ManagerNotSupportedException("The property is not supported as an internal exception was thrown when trying to set it: " + e.Message);
					}
				}
				default:
					throw new ManagerNotRecognizedException("The specified feature: " + name + " is not recognized");
			}
		}

		/// <summary>
		/// Emulates the behavior of a SAX parsers. Gets the value of a property.
		/// </summary>
		/// <param name="name">The property name, which is a fully-qualified URI.</param>
		/// <returns>The requested value for the property.</returns>
		public virtual System.Object getProperty(System.String name)
		{
			switch (name)
			{
				case "http://xml.org/sax/properties/lexical-handler":
				{
					try
					{
						return this.lexical;
					}
					catch
					{
						throw new ManagerNotSupportedException("The specified operation was not performed");
					}
				}
				default:
					throw new ManagerNotRecognizedException("The specified feature: " + name + " are not supported");
			}
		}

		/// <summary>
		/// Emulates the behavior of a SAX parser, it realizes the callback events of the parser.
		/// </summary>
		private void DoParsing()
		{
			System.Collections.Hashtable prefixes = new System.Collections.Hashtable();
			System.Collections.Stack stackNameSpace = new System.Collections.Stack();
			locator = new XmlSaxLocatorImpl();
			try 
			{
				UpdateLocatorData(this.locator, (System.Xml.XmlTextReader) (this.reader.Reader));
				if (this.callBackHandler != null)
					this.callBackHandler.setDocumentLocator(locator);
				if (this.callBackHandler != null)
					this.callBackHandler.startDocument();
				while (this.reader.Read())
				{
					UpdateLocatorData(this.locator, (System.Xml.XmlTextReader) (this.reader.Reader));
					switch (this.reader.NodeType)
					{
						case System.Xml.XmlNodeType.Element:
							bool Empty = reader.IsEmptyElement;
							System.String namespaceURI = "";
							System.String localName = "";
							if (this.namespaceAllowed)
							{
								namespaceURI = reader.NamespaceURI;
								localName = reader.LocalName;
							}
							System.String name = reader.Name;
							SaxAttributesSupport attributes = new SaxAttributesSupport();
							if (reader.HasAttributes)
							{
								for (int i = 0; i < reader.AttributeCount; i++)
								{
									reader.MoveToAttribute(i);
									System.String prefixName = (reader.Name.IndexOf(":") > 0) ? reader.Name.Substring(reader.Name.IndexOf(":") + 1, reader.Name.Length - reader.Name.IndexOf(":") - 1) : "";
									System.String prefix = (reader.Name.IndexOf(":") > 0) ? reader.Name.Substring(0, reader.Name.IndexOf(":")) : reader.Name;
									bool IsXmlns = prefix.ToLower().Equals("xmlns");
									if (this.namespaceAllowed)
									{
										if (!IsXmlns)
											attributes.Add(reader.NamespaceURI, reader.LocalName, reader.Name, "" + reader.NodeType, reader.Value);
									}
									else
										attributes.Add("", "", reader.Name, "" + reader.NodeType, reader.Value);
									if (IsXmlns)
									{
										System.String namespaceTemp = "";
										namespaceTemp = (namespaceURI.Length == 0) ? reader.Value : namespaceURI;
										if (this.namespaceAllowed && !prefixes.ContainsKey(namespaceTemp) && namespaceTemp.Length > 0 )
										{
											stackNameSpace.Push(name);
											System.Collections.Stack namespaceStack = new System.Collections.Stack();
											namespaceStack.Push(prefixName);
											prefixes.Add(namespaceURI, namespaceStack);
											if (this.callBackHandler != null)
												((XmlSaxContentHandler) this.callBackHandler).startPrefixMapping(prefixName, namespaceTemp);
										}
										else
										{
											if (this.namespaceAllowed && namespaceTemp.Length > 0  && !((System.Collections.Stack) prefixes[namespaceTemp]).Contains(reader.Name))
											{
												((System.Collections.Stack) prefixes[namespaceURI]).Push(prefixName);
												if (this.callBackHandler != null)
													((XmlSaxContentHandler) this.callBackHandler).startPrefixMapping(prefixName, reader.Value);
											}
										}
									}
								}
							}
							if (this.callBackHandler != null)
								this.callBackHandler.startElement(namespaceURI, localName, name, attributes);
							if (Empty)
							{
								if (this.NamespaceAllowed)
								{
									if (this.callBackHandler != null)
										this.callBackHandler.endElement(namespaceURI, localName, name);
								}
								else
									if (this.callBackHandler != null)
									this.callBackHandler.endElement("", "", name);
							}
							break;

						case System.Xml.XmlNodeType.EndElement:
							if (this.namespaceAllowed)
							{
								if (this.callBackHandler != null)
									this.callBackHandler.endElement(reader.NamespaceURI, reader.LocalName, reader.Name);
							}
							else
								if (this.callBackHandler != null)
								this.callBackHandler.endElement("", "", reader.Name);
							if (this.namespaceAllowed && prefixes.ContainsKey(reader.NamespaceURI) && ((System.Collections.Stack) stackNameSpace).Contains(reader.Name))
							{
								stackNameSpace.Pop();
								System.Collections.Stack namespaceStack = (System.Collections.Stack) prefixes[reader.NamespaceURI];
								while (namespaceStack.Count > 0)
								{
									System.String tempString = (System.String) namespaceStack.Pop();
									if (this.callBackHandler != null )
										((XmlSaxContentHandler) this.callBackHandler).endPrefixMapping(tempString);
								}
								prefixes.Remove(reader.NamespaceURI);
							}
							break;

						case System.Xml.XmlNodeType.Text:
							if (this.callBackHandler != null)
								this.callBackHandler.characters(reader.Value.ToCharArray(), 0, reader.Value.Length);
							break;

						case System.Xml.XmlNodeType.Whitespace:
							if (this.callBackHandler != null)
								this.callBackHandler.ignorableWhitespace(reader.Value.ToCharArray(), 0, reader.Value.Length);
							break;

						case System.Xml.XmlNodeType.ProcessingInstruction:
							if (this.callBackHandler != null)
								this.callBackHandler.processingInstruction(reader.Name, reader.Value);
							break;

						case System.Xml.XmlNodeType.Comment:
							if (this.lexical != null)
								this.lexical.comment(reader.Value.ToCharArray(), 0, reader.Value.Length);
							break;

						case System.Xml.XmlNodeType.CDATA:
							if (this.lexical != null)
							{
								lexical.startCDATA();
								if (this.callBackHandler != null)
									this.callBackHandler.characters(this.reader.Value.ToCharArray(), 0, this.reader.Value.ToCharArray().Length);
								lexical.endCDATA();
							}
							break;

						case System.Xml.XmlNodeType.DocumentType:
							if (this.lexical != null)
							{
								System.String lname = this.reader.Name;
								System.String systemId = null;
								if (this.reader.Reader.AttributeCount > 0)
									systemId = this.reader.Reader.GetAttribute(0);
								this.lexical.startDTD(lname, null, systemId);
								this.lexical.startEntity("[dtd]");
								this.lexical.endEntity("[dtd]");
								this.lexical.endDTD();
							}
							break;
					}
				}
				if (this.callBackHandler != null)
					this.callBackHandler.endDocument();
			}
			catch (System.Xml.XmlException e)
			{
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified file and process the events over the specified handler.
		/// </summary>
		/// <param name="filepath">The file to be used.</param>
		/// <param name="handler">The handler that manages the parser events.</param>
		public virtual void parse(System.IO.FileInfo filepath, XmlSaxContentHandler handler)
		{
			try
			{
				if (handler is XmlSaxDefaultHandler)
				{
					this.errorHandler = (XmlSaxDefaultHandler) handler;
					this.entityResolver =  (XmlSaxDefaultHandler) handler;
				}
				if (!(this is XmlSaxParserAdapter))
					this.callBackHandler = handler;
				else
				{
					if(this.callBackHandler == null)
						this.callBackHandler = handler;
				}
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(filepath.OpenRead());
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = filepath.FullName;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified file path and process the events over the specified handler.
		/// </summary>
		/// <param name="filepath">The path of the file to be used.</param>
		/// <param name="handler">The handler that manage the parser events.</param>
		public virtual void parse(System.String filepath, XmlSaxContentHandler handler)
		{
			try
			{
				if (handler is XmlSaxDefaultHandler)
				{
					this.errorHandler = (XmlSaxDefaultHandler) handler;
					this.entityResolver =  (XmlSaxDefaultHandler) handler;
				}
				if (!(this is XmlSaxParserAdapter))
					this.callBackHandler = handler;
				else
				{
					if(this.callBackHandler == null)
						this.callBackHandler = handler;
				}
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(filepath);
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = filepath;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified stream and process the events over the specified handler.
		/// </summary>
		/// <param name="stream">The stream with the XML.</param>
		/// <param name="handler">The handler that manage the parser events.</param>
		public virtual void parse(System.IO.Stream stream, XmlSaxContentHandler handler)
		{
			try
			{
				if (handler is XmlSaxDefaultHandler)
				{
					this.errorHandler = (XmlSaxDefaultHandler) handler;
					this.entityResolver =  (XmlSaxDefaultHandler) handler;
				}
				if (!(this is XmlSaxParserAdapter))
					this.callBackHandler = handler;
				else
				{
					if(this.callBackHandler == null)
						this.callBackHandler = handler;
				}
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(stream);
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = null;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified stream and process the events over the specified handler, and resolves the 
		/// entities with the specified URI.
		/// </summary>
		/// <param name="stream">The stream with the XML.</param>
		/// <param name="handler">The handler that manage the parser events.</param>
		/// <param name="URI">The namespace URI for resolve external etities.</param>
		public virtual void parse(System.IO.Stream stream, XmlSaxContentHandler handler, System.String URI)
		{
			try
			{
				if (handler is XmlSaxDefaultHandler)
				{
					this.errorHandler = (XmlSaxDefaultHandler) handler;
					this.entityResolver =  (XmlSaxDefaultHandler) handler;
				}
				if (!(this is XmlSaxParserAdapter))
					this.callBackHandler = handler;
				else
				{
					if(this.callBackHandler == null)
						this.callBackHandler = handler;
				}
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(URI, stream);
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = null;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified 'XmlSourceSupport' instance and process the events over the specified handler, 
		/// and resolves the entities with the specified URI.
		/// </summary>
		/// <param name="source">The 'XmlSourceSupport' that contains the XML.</param>
		/// <param name="handler">The handler that manages the parser events.</param>
		public virtual void parse(XmlSourceSupport source, XmlSaxContentHandler handler)
		{
			if (source.Characters != null)
				parse(source.Characters.BaseStream, handler);
			else
			{
				if (source.Bytes != null)
					parse(source.Bytes, handler);
				else
				{
					if(source.Uri != null)
						parse(source.Uri, handler);
					else
						throw new System.Xml.XmlException("The XmlSource class can't be null");
				}
			}
		}

		/// <summary>
		/// Parses the specified file and process the events over previously specified handler.
		/// </summary>
		/// <param name="filepath">The file with the XML.</param>
		public virtual void parse(System.IO.FileInfo filepath)
		{
			try
			{
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(filepath.OpenRead());
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = filepath.FullName;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified file path and processes the events over previously specified handler.
		/// </summary>
		/// <param name="filepath">The path of the file with the XML.</param>
		public virtual void parse(System.String filepath)
		{
			try
			{
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(filepath);
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = filepath;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified stream and process the events over previusly specified handler.
		/// </summary>
		/// <param name="stream">The stream with the XML.</param>
		public virtual void parse(System.IO.Stream stream)
		{
			try
			{
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(stream);
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = null;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified stream and processes the events over previously specified handler, and resolves the 
		/// external entities with the specified URI.
		/// </summary>
		/// <param name="stream">The stream with the XML.</param>
		/// <param name="URI">The namespace URI for resolve external etities.</param>
		public virtual void parse(System.IO.Stream stream, System.String URI)
		{
			try
			{
				System.Xml.XmlTextReader tempTextReader = new System.Xml.XmlTextReader(URI, stream);
				System.Xml.XmlValidatingReader tempValidatingReader = new System.Xml.XmlValidatingReader(tempTextReader);
				parserFileName = null;
				tempValidatingReader.ValidationType = (this.isValidating) ? System.Xml.ValidationType.DTD : System.Xml.ValidationType.None;
				tempValidatingReader.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(this.ValidationEventHandle);
				this.reader = tempValidatingReader;
				this.DoParsing();
			}
			catch (System.Xml.XmlException e)
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(e);
				throw e;
			}
		}

		/// <summary>
		/// Parses the specified 'XmlSourceSupport' and processes the events over the specified handler, and 
		/// resolves the entities with the specified URI.
		/// </summary>
		/// <param name="source">The 'XmlSourceSupport' instance with the XML.</param>
		public virtual void parse(XmlSourceSupport source)
		{
			if (source.Characters != null)
				parse(source.Characters.BaseStream);
			else
			{
				if (source.Bytes != null)
					parse(source.Bytes);
				else
				{
					if (source.Uri != null)
						parse(source.Uri);
					else
						throw new System.Xml.XmlException("The XmlSource class can't be null");
				}
			}
		}

		/// <summary>
		/// Manages all the exceptions that were thrown when the validation over XML fails.
		/// </summary>
		public void ValidationEventHandle(System.Object sender, System.Xml.Schema.ValidationEventArgs args)
		{
			System.Xml.Schema.XmlSchemaException tempException = args.Exception;
			if (args.Severity == System.Xml.Schema.XmlSeverityType.Warning)
			{
				if (this.errorHandler != null)
					this.errorHandler.warning(new System.Xml.XmlException(tempException.Message, tempException, tempException.LineNumber, tempException.LinePosition));
			}
			else
			{
				if (this.errorHandler != null)
					this.errorHandler.fatalError(new System.Xml.XmlException(tempException.Message, tempException, tempException.LineNumber, tempException.LinePosition));
			}
		}
				
		/// <summary>
		/// Assigns the object that will handle all the content events.
		/// </summary>
		/// <param name="handler">The object that handles the content events.</param>
		public virtual void setContentHandler(XmlSaxContentHandler handler)
		{
			if (handler != null)
				this.callBackHandler = handler;
			else
				throw new System.Xml.XmlException("Error assigning the Content handler: a null Content Handler was received");
		}

		/// <summary>
		/// Assigns the object that will handle all the error events. 
		/// </summary>
		/// <param name="handler">The object that handles the errors events.</param>
		public virtual void setErrorHandler(XmlSaxErrorHandler handler)
		{
			if (handler != null)
				this.errorHandler = handler;
			else
				throw new System.Xml.XmlException("Error assigning the Error handler: a null Error Handler was received");
		}

		/// <summary>
		/// Obtains the object that will handle all the content events.
		/// </summary>
		/// <returns>The object that handles the content events.</returns>
		public virtual XmlSaxContentHandler getContentHandler()
		{
			return this.callBackHandler;
		}

		/// <summary>
		/// Assigns the object that will handle all the error events. 
		/// </summary>
		/// <returns>The object that handles the error events.</returns>
		public virtual XmlSaxErrorHandler getErrorHandler()
		{
			return this.errorHandler;
		}

		/// <summary>
		/// Returns the current entity resolver.
		/// </summary>
		/// <returns>The current entity resolver, or null if none has been registered.</returns>
		public virtual XmlSaxEntityResolver getEntityResolver()
		{
			return this.entityResolver;
		}

		/// <summary>
		/// Allows an application to register an entity resolver.
		/// </summary>
		/// <param name="resolver">The entity resolver.</param>
		public virtual void setEntityResolver(XmlSaxEntityResolver resolver)
		{
			this.entityResolver = resolver;
		}
	}

/// <summary>
/// Contains conversion support elements such as classes, interfaces and static methods.
/// </summary>
public class SupportClass
{
/// <summary>
/// Contains methods to construct customized Buttons
/// </summary>
public class ButtonSupport
{
	/// <summary>
	/// Creates a popup style Button with an specific text.	
	/// </summary>
	/// <param name="label">The text associated with the Button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.String label)
	{			
		System.Windows.Forms.Button tempButton = new System.Windows.Forms.Button();
		tempButton.Text = label;
		tempButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		return tempButton;
	}

	/// <summary>
	/// Sets the an specific text for the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="label">The text associated with the Button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button, System.String label)
	{
		Button.Text = label;
		Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	}

	/// <summary>
	/// Creates a Button with an specific text and style.
	/// </summary>
	/// <param name="label">The text associated with the Button</param>
	/// <param name="style">The style of the Button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.String label, int style)
	{
		System.Windows.Forms.Button tempButton = new System.Windows.Forms.Button();
		tempButton.Text = label;
		setStyle(tempButton,style);
		return tempButton;
	}

	/// <summary>
	/// Sets the specific Text and Style for the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="label">The text associated with the Button</param>
	/// <param name="style">The style of the Button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button, System.String label, int style)
	{
		Button.Text = label;
		setStyle(Button,style);
	}

	/// <summary>
	/// Creates a standard style Button that contains an specific text and/or image
	/// </summary>
	/// <param name="control">The control to be contained analized to get the text and/or image for the Button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.Windows.Forms.Control control)
	{
		System.Windows.Forms.Button tempButton = new System.Windows.Forms.Button();
		if(control.GetType().FullName == "System.Windows.Forms.Label")
		{
			tempButton.Image = ((System.Windows.Forms.Label)control).Image;
			tempButton.Text = ((System.Windows.Forms.Label)control).Text;
			tempButton.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			tempButton.TextAlign = ((System.Windows.Forms.Label)control).TextAlign;
		}
		else
		{
			if(control.GetType().FullName == "System.Windows.Forms.PictureBox")//Tentative to see maps of UIGraphic
			{
				tempButton.Image = ((System.Windows.Forms.PictureBox)control).Image;
				tempButton.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			}else
				tempButton.Text = control.Text;
		}
		tempButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
		return tempButton;
	}

	/// <summary>
	/// Sets an specific text and/or image to the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="control">The control to be contained analized to get the text and/or image for the Button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button,System.Windows.Forms.Control control)
	{
		if(control.GetType().FullName == "System.Windows.Forms.Label")
		{
			Button.Image = ((System.Windows.Forms.Label)control).Image;
			Button.Text = ((System.Windows.Forms.Label)control).Text;
			Button.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			Button.TextAlign = ((System.Windows.Forms.Label)control).TextAlign;
		}
		else
		{
			if(control.GetType().FullName == "System.Windows.Forms.PictureBox")//Tentative to see maps of UIGraphic
			{
				Button.Image = ((System.Windows.Forms.PictureBox)control).Image;
				Button.ImageAlign = ((System.Windows.Forms.Label)control).ImageAlign;
			}
			else
				Button.Text = control.Text;
		}
		Button.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
	}

	/// <summary>
	/// Creates a Button with an specific control and style
	/// </summary>
	/// <param name="control">The control to be contained by the button</param>
	/// <param name="style">The style of the button</param>
	/// <returns>The new Button</returns>
	public static System.Windows.Forms.Button CreateButton(System.Windows.Forms.Control control, int style)
	{
		System.Windows.Forms.Button tempButton = CreateButton(control);
		setStyle(tempButton,style);
		return tempButton;
	}

	/// <summary>
	/// Sets an specific text and/or image to the Button
	/// </summary>
	/// <param name="Button">The button to be set</param>
	/// <param name="control">The control to be contained by the button</param>
	/// <param name="style">The style of the button</param>
	public static void SetButton(System.Windows.Forms.ButtonBase Button,System.Windows.Forms.Control control,int style)
	{
		SetButton(Button,control);
		setStyle(Button,style);
	}

	/// <summary>
	/// Sets the style of the Button
	/// </summary>
	/// <param name="Button">The Button that will change its style</param>
	/// <param name="style">The new style of the Button</param>
	/// <remarks> 
	/// If style is 0 then sets a popup style to the Button, otherwise sets a standard style to the Button.
	/// </remarks>
	public static void setStyle(System.Windows.Forms.ButtonBase Button, int style)
	{
		if (  (style == 0 ) || (style ==  67108864) || (style ==  33554432) ) 
			Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
		else if ( (style == 2097152) || (style == 1048576) ||  (style == 16777216 ) )
				Button.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
		else 
			throw new System.ArgumentException("illegal style: " + style);		
	}

	/// <summary>
	/// Selects the Button
	/// </summary>
	/// <param name="Button">The Button that will change its style</param>
	/// <param name="select">It determines if the button woll be selected</param>
	/// <remarks> 
	/// If select is true thebutton will be selected, otherwise not.
	/// </remarks>
	public static void setSelected(System.Windows.Forms.ButtonBase Button, bool select)
	{
		if (select)
			Button.Select();
	}

	/// <summary>
	/// Receives a Button instance and sets the Text and Image properties.
	/// </summary>
	/// <param name="buttonInstance">Button instance to be set.</param>
	/// <param name="buttonText">Value to be set to Text.</param>
	/// <param name="icon">Value to be set to Image.</param>
	public static void SetStandardButton (System.Windows.Forms.ButtonBase buttonInstance, System.String buttonText , System.Drawing.Image icon )
	{
		buttonInstance.Text = buttonText;
		buttonInstance.Image = icon;
	}

	/// <summary>
	/// Creates a Button with a given text.
	/// </summary>
	/// <param name="buttonText">The text to be displayed in the button.</param>
	/// <returns>The new created button with text</returns>
	public static System.Windows.Forms.Button CreateStandardButton (System.String buttonText)
	{
		System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
		newButton.Text = buttonText;
		return newButton;
	}

	/// <summary>
	/// Creates a Button with a given image.
	/// </summary>
	/// <param name="buttonImage">The image to be displayed in the button.</param>
	/// <returns>The new created button with an image</returns>
	public static System.Windows.Forms.Button CreateStandardButton (System.Drawing.Image buttonImage)
	{
		System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
		newButton.Image = buttonImage;
		return newButton;
	}

	/// <summary>
	/// Creates a Button with a given image and a text.
	/// </summary>
	/// <param name="buttonText">The text to be displayed in the button.</param>
	/// <param name="buttonImage">The image to be displayed in the button.</param>
	/// <returns>The new created button with text and image</returns>
	public static System.Windows.Forms.Button CreateStandardButton (System.String buttonText, System.Drawing.Image buttonImage)
	{
		System.Windows.Forms.Button newButton = new System.Windows.Forms.Button();
		newButton.Text = buttonText;
		newButton.Image = buttonImage;
		return newButton;
	}
}
	/*******************************/
	/// <summary>
	/// Class used to store and retrieve an object command specified as a String.
	/// </summary>
	public class CommandManager
	{
		/// <summary>
		/// Private Hashtable used to store objects and their commands.
		/// </summary>
		private static System.Collections.Hashtable Commands = new System.Collections.Hashtable();

		/// <summary>
		/// Sets a command to the specified object.
		/// </summary>
		/// <param name="obj">The object that has the command.</param>
		/// <param name="cmd">The command for the object.</param>
		public static void SetCommand(System.Object obj, System.String cmd)
		{
			if (obj != null)
			{
				if (Commands.Contains(obj))
					Commands[obj] = cmd;
				else
					Commands.Add(obj, cmd);
			}
		}

		/// <summary>
		/// Gets a command associated with an object.
		/// </summary>
		/// <param name="obj">The object whose command is going to be retrieved.</param>
		/// <returns>The command of the specified object.</returns>
		public static System.String GetCommand(System.Object obj)
		{
			System.String result = "";
			if (obj != null)
				result = System.Convert.ToString(Commands[obj]);
			return result;
		}



		/// <summary>
		/// Checks if the Control contains a command, if it does not it sets the default
		/// </summary>
		/// <param name="button">The control whose command will be checked</param>
		public static void CheckCommand(System.Windows.Forms.ButtonBase button)
		{
			if (button != null)
			{
				if (GetCommand(button).Equals(""))
					SetCommand(button, button.Text);
			}
		}

		/// <summary>
		/// Checks if the Control contains a command, if it does not it sets the default
		/// </summary>
		/// <param name="button">The control whose command will be checked</param>
		public static void CheckCommand(System.Windows.Forms.MenuItem menuItem)
		{
			if (menuItem != null)
			{
				if (GetCommand(menuItem).Equals(""))
					SetCommand(menuItem, menuItem.Text);
			}
		}

		/// <summary>
		/// Checks if the Control contains a command, if it does not it sets the default
		/// </summary>
		/// <param name="button">The control whose command will be checked</param>
		public static void CheckCommand(System.Windows.Forms.ComboBox comboBox)
		{
			if (comboBox != null)
			{
				if (GetCommand(comboBox).Equals(""))
					SetCommand(comboBox,"comboBoxChanged");
			}
		}

	}
	/*******************************/
	/// <summary>
	/// This class supports basic functionality of the JOptionPane class.
	/// </summary>
	public class OptionPaneSupport 
	{
		/// <summary>
		/// This method finds the form which contains an specific control.
		/// </summary>
		/// <param name="control">The control which we need to find its form.</param>
		/// <returns>The form which contains the control</returns>
		public static System.Windows.Forms.Form GetFrameForComponent(System.Windows.Forms.Control control)
		{
			System.Windows.Forms.Form result = null;
			if (control == null)return null;
			if (control is System.Windows.Forms.Form)
				result = (System.Windows.Forms.Form)control;
			else if (control.Parent != null)
				result = GetFrameForComponent(control.Parent);
			return result;
		}

		/// <summary>
		/// This method finds the MDI container form which contains an specific control.
		/// </summary>
		/// <param name="control">The control which we need to find its MDI container form.</param>
		/// <returns>The MDI container form which contains the control.</returns>
		public static System.Windows.Forms.Form GetDesktopPaneForComponent(System.Windows.Forms.Control control)
		{
			System.Windows.Forms.Form result = null;
			if (control == null)return null;
			if (control.GetType().IsSubclassOf(typeof(System.Windows.Forms.Form)))
				if (((System.Windows.Forms.Form)control).IsMdiContainer)
					result = (System.Windows.Forms.Form)control;
				else if (((System.Windows.Forms.Form)control).IsMdiChild)
					result = GetDesktopPaneForComponent(((System.Windows.Forms.Form)control).MdiParent);
				else if (control.Parent != null)
					result = GetDesktopPaneForComponent(control.Parent);
			return result;
		}
		
		/// <summary>
		/// This method retrieves the message that is contained into the object that is sended by the user.
		/// </summary>
		/// <param name="control">The control which we need to find its form.</param>
		/// <returns>The form which contains the control</returns>
		public static System.String GetMessageForObject(System.Object message)
		{
			System.String result = "";
			if (message == null)
			  return result;
			else 
		 	  result = message.ToString();
			return result;
		}


		/// <summary>
		/// This method displays a dialog with a Yes, No, Cancel buttons and a question icon.
		/// </summary>
		/// <param name="parent">The component which will be the owner of the dialog.</param>
		/// <param name="message">The message to be displayed; if it isn't an String it displays the return value of the ToString() method of the object.</param>
		/// <returns>The integer value which represents the button pressed.</returns>
		public static int ShowConfirmDialog(System.Windows.Forms.Control parent, System.Object message)
		{
			return ShowConfirmDialog(parent, message,"Select an option...", (int)System.Windows.Forms.MessageBoxButtons.YesNoCancel,
				(int)System.Windows.Forms.MessageBoxIcon.Question);
		}

		/// <summary>
		/// This method displays a dialog with specific buttons and a question icon.
		/// </summary>
		/// <param name="parent">The component which will be the owner of the dialog.</param>
		/// <param name="message">The message to be displayed; if it isn't an String it displays the result value of the ToString() method of the object.</param>
		/// <param name="title">The title for the message dialog.</param>
		/// <param name="optiontype">The set of buttons to be displayed in the message box; defined by the MessageBoxButtons enumeration.</param>
		/// <returns>The integer value which represents the button pressed.</returns>
		public static int ShowConfirmDialog(System.Windows.Forms.Control parent, System.Object message,
			System.String title,int optiontype)
		{
			return ShowConfirmDialog(parent, message, title, optiontype, (int)System.Windows.Forms.MessageBoxIcon.Question);
		}

		/// <summary>
		/// This method displays a dialog with specific buttons and specific icon.
		/// </summary>
		/// <param name="parent">The component which will be the owner of the dialog.</param>
		/// <param name="message">The message to be displayed; if it isn't an String it displays the return value of the ToString() method of the object.</param>
		/// <param name="title">The title for the message dialog.</param>
		/// <param name="optiontype">The set of buttons to be displayed in the message box; defined by the MessageBoxButtons enumeration.</param>
		/// <param name="messagetype">The messagetype defines the icon to be displayed in the message box.</param>
		/// <returns>The integer value which represents the button pressed.</returns>
		public static int ShowConfirmDialog(System.Windows.Forms.Control parent, System.Object message,
			System.String title, int optiontype, int messagetype)
		{
			return (int)System.Windows.Forms.MessageBox.Show(GetFrameForComponent(parent), GetMessageForObject(message), title,
				(System.Windows.Forms.MessageBoxButtons)optiontype, (System.Windows.Forms.MessageBoxIcon)messagetype);
		}

		/// <summary>
		/// This method displays a simple MessageBox.
		/// </summary>
		/// <param name="parent">The component which will be the owner of the dialog.</param>
		/// <param name="message">The message to be displayed; if it isn't an String it displays result value of the ToString() method of the object.</param>
		public static void ShowMessageDialog(System.Windows.Forms.Control parent, System.Object message)
		{
			ShowMessageDialog(parent, message, "Message", (int)System.Windows.Forms.MessageBoxIcon.Information);
		}

		/// <summary>
		/// This method displays a simple MessageBox with a specific icon.
		/// </summary>
		/// <param name="parent">The component which will be the owner of the dialog.</param>
		/// <param name="message">The message to be displayed; if it isn't an String it displays result value of the ToString() method of the object.</param>
		/// <param name="title">The title for the message dialog.</param>
		/// <param name="messagetype">The messagetype defines the icon to be displayed in the message box.</param>
		public static void ShowMessageDialog(System.Windows.Forms.Control parent, System.Object message,
			System.String title, int messagetype)
		{
			System.Windows.Forms.MessageBox.Show(GetFrameForComponent(parent), GetMessageForObject(message), title,
				System.Windows.Forms.MessageBoxButtons.OK, (System.Windows.Forms.MessageBoxIcon)messagetype);
		}
	}


	/*******************************/
	/// <summary>
	/// Writes the exception stack trace to the received stream
	/// </summary>
	/// <param name="throwable">Exception to obtain information from</param>
	/// <param name="stream">Output sream used to write to</param>
	public static void WriteStackTrace(System.Exception throwable, System.IO.TextWriter stream)
	{
		stream.Write(throwable.StackTrace);
		stream.Flush();
	}

	/*******************************/
	/// <summary>
	/// Represents a collection ob objects that contains no duplicate elements.
	/// </summary>	
	public interface SetSupport : System.Collections.ICollection, System.Collections.IList
	{
		/// <summary>
		/// Adds a new element to the Collection if it is not already present.
		/// </summary>
		/// <param name="obj">The object to add to the collection.</param>
		/// <returns>Returns true if the object was added to the collection, otherwise false.</returns>
		new bool Add(System.Object obj);

		/// <summary>
		/// Adds all the elements of the specified collection to the Set.
		/// </summary>
		/// <param name="c">Collection of objects to add.</param>
		/// <returns>true</returns>
		bool AddAll(System.Collections.ICollection c);
	}


	/*******************************/
	/// <summary>
	/// SupportClass for the HashSet class.
	/// </summary>
	[Serializable]
	public class HashSetSupport : System.Collections.ArrayList, SetSupport
	{
		public HashSetSupport() : base()
		{	
		}

		public HashSetSupport(System.Collections.ICollection c) 
		{
			this.AddAll(c);
		}

		public HashSetSupport(int capacity) : base(capacity)
		{
		}

		/// <summary>
		/// Adds a new element to the ArrayList if it is not already present.
		/// </summary>		
		/// <param name="obj">Element to insert to the ArrayList.</param>
		/// <returns>Returns true if the new element was inserted, false otherwise.</returns>
		new public virtual bool Add(System.Object obj)
		{
			bool inserted;

			if ((inserted = this.Contains(obj)) == false)
			{
				base.Add(obj);
			}

			return !inserted;
		}

		/// <summary>
		/// Adds all the elements of the specified collection that are not present to the list.
		/// </summary>
		/// <param name="c">Collection where the new elements will be added</param>
		/// <returns>Returns true if at least one element was added, false otherwise.</returns>
		public bool AddAll(System.Collections.ICollection c)
		{
			System.Collections.IEnumerator e = new System.Collections.ArrayList(c).GetEnumerator();
			bool added = false;

			while (e.MoveNext() == true)
			{
				if (this.Add(e.Current) == true)
					added = true;
			}

			return added;
		}
		
		/// <summary>
		/// Returns a copy of the HashSet instance.
		/// </summary>		
		/// <returns>Returns a shallow copy of the current HashSet.</returns>
		public override System.Object Clone()
		{
			return base.MemberwiseClone();
		}
	}


	/*******************************/
	/// <summary>
	/// This class manages different features for calendars.
	/// The different calendars are internally managed using a hashtable structure.
	/// </summary>
	public class CalendarManager
	{
		/// <summary>
		/// Field used to get or set the year.
		/// </summary>
		public const int YEAR = 1;

		/// <summary>
		/// Field used to get or set the month.
		/// </summary>
		public const int MONTH = 2;
		
		/// <summary>
		/// Field used to get or set the day of the month.
		/// </summary>
		public const int DATE = 5;
		
		/// <summary>
		/// Field used to get or set the hour of the morning or afternoon.
		/// </summary>
		public const int HOUR = 10;
		
		/// <summary>
		/// Field used to get or set the minute within the hour.
		/// </summary>
		public const int MINUTE = 12;
		
		/// <summary>
		/// Field used to get or set the second within the minute.
		/// </summary>
		public const int SECOND = 13;
		
		/// <summary>
		/// Field used to get or set the millisecond within the second.
		/// </summary>
		public const int MILLISECOND = 14;
		
		/// <summary>
		/// Field used to get or set the day of the year.
		/// </summary>
		public const int DAY_OF_YEAR = 4;
		
		/// <summary>
		/// Field used to get or set the day of the month.
		/// </summary>
		public const int DAY_OF_MONTH = 6;
		
		/// <summary>
		/// Field used to get or set the day of the week.
		/// </summary>
		public const int DAY_OF_WEEK = 7;
		
		/// <summary>
		/// Field used to get or set the hour of the day.
		/// </summary>
		public const int HOUR_OF_DAY = 11;
		
		/// <summary>
		/// Field used to get or set whether the HOUR is before or after noon.
		/// </summary>
		public const int AM_PM = 9;
		
		/// <summary>
		/// Field used to get or set the value of the AM_PM field which indicates the period of the day from midnight to just before noon.
		/// </summary>
		public const int AM = 0;
		
		/// <summary>
		/// Field used to get or set the value of the AM_PM field which indicates the period of the day from noon to just before midnight.
		/// </summary>
		public const int PM = 1;
		
		/// <summary>
		/// The hashtable that contains the calendars and its properties.
		/// </summary>
		static public CalendarHashTable manager = new CalendarHashTable();

		/// <summary>
		/// Internal class that inherits from HashTable to manage the different calendars.
		/// This structure will contain an instance of System.Globalization.Calendar that represents 
		/// a type of calendar and its properties (represented by an instance of CalendarProperties 
		/// class).
		/// </summary>
		public class CalendarHashTable:System.Collections.Hashtable 
		{
			/// <summary>
			/// Gets the calendar current date and time.
			/// </summary>
			/// <param name="calendar">The calendar to get its current date and time.</param>
			/// <returns>A System.DateTime value that indicates the current date and time for the 
			/// calendar given.</returns>
			public System.DateTime GetDateTime(System.Globalization.Calendar calendar)
			{
				if (this[calendar] != null)
					return ((CalendarProperties) this[calendar]).dateTime;
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					this.Add(calendar, tempProps);
					return this.GetDateTime(calendar);
				}
			}

			/// <summary>
			/// Sets the specified System.DateTime value to the specified calendar.
			/// </summary>
			/// <param name="calendar">The calendar to set its date.</param>
			/// <param name="date">The System.DateTime value to set to the calendar.</param>
			public void SetDateTime(System.Globalization.Calendar calendar, System.DateTime date)
			{
				if (this[calendar] != null)
				{
					((CalendarProperties) this[calendar]).dateTime = date;
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = date;
					this.Add(calendar, tempProps);
				}
			}

			/// <summary>
			/// Sets the corresponding field in an specified calendar with the value given.
			/// If the specified calendar does not have exist in the hash table, it creates a 
			/// new instance of the calendar with the current date and time and then assings it 
			/// the new specified value.
			/// </summary>
			/// <param name="calendar">The calendar to set its date or time.</param>
			/// <param name="field">One of the fields that composes a date/time.</param>
			/// <param name="fieldValue">The value to be set.</param>
			public void Set(System.Globalization.Calendar calendar, int field, int fieldValue)
			{
				if (this[calendar] != null)
				{
					System.DateTime tempDate = ((CalendarProperties) this[calendar]).dateTime;
					switch (field)
					{
						case CalendarManager.DATE:
							tempDate = tempDate.AddDays(fieldValue - tempDate.Day);
							break;
						case CalendarManager.HOUR:
							tempDate = tempDate.AddHours(fieldValue - tempDate.Hour);
							break;
						case CalendarManager.MILLISECOND:
							tempDate = tempDate.AddMilliseconds(fieldValue - tempDate.Millisecond);
							break;
						case CalendarManager.MINUTE:
							tempDate = tempDate.AddMinutes(fieldValue - tempDate.Minute);
							break;
						case CalendarManager.MONTH:
							//Month value is 0-based. e.g., 0 for January
							tempDate = tempDate.AddMonths((fieldValue + 1) - tempDate.Month);
							break;
						case CalendarManager.SECOND:
							tempDate = tempDate.AddSeconds(fieldValue - tempDate.Second);
							break;
						case CalendarManager.YEAR:
							tempDate = tempDate.AddYears(fieldValue - tempDate.Year);
							break;
						case CalendarManager.DAY_OF_MONTH:
							tempDate = tempDate.AddDays(fieldValue - tempDate.Day);
							break;
						case CalendarManager.DAY_OF_WEEK:
							tempDate = tempDate.AddDays((fieldValue - 1) - (int)tempDate.DayOfWeek);
							break;
						case CalendarManager.DAY_OF_YEAR:
							tempDate = tempDate.AddDays(fieldValue - tempDate.DayOfYear);
							break;
						case CalendarManager.HOUR_OF_DAY:
							tempDate = tempDate.AddHours(fieldValue - tempDate.Hour);
							break;

						default:
							break;
					}
					((CalendarProperties) this[calendar]).dateTime = tempDate;
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					this.Add(calendar, tempProps);
					this.Set(calendar, field, fieldValue);
				}
			}

			/// <summary>
			/// Sets the corresponding date (day, month and year) to the calendar specified.
			/// If the calendar does not exist in the hash table, it creates a new instance and sets 
			/// its values.
			/// </summary>
			/// <param name="calendar">The calendar to set its date.</param>
			/// <param name="year">Integer value that represent the year.</param>
			/// <param name="month">Integer value that represent the month.</param>
			/// <param name="day">Integer value that represent the day.</param>
			public void Set(System.Globalization.Calendar calendar, int year, int month, int day)
			{
				if (this[calendar] != null)
				{
					this.Set(calendar, CalendarManager.YEAR, year);
					this.Set(calendar, CalendarManager.MONTH, month);
					this.Set(calendar, CalendarManager.DATE, day);
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					this.Add(calendar, tempProps);
					this.Set(calendar, year, month, day);
				}
			}

			/// <summary>
			/// Sets the corresponding date (day, month and year) and hour (hour and minute) 
			/// to the calendar specified.
			/// If the calendar does not exist in the hash table, it creates a new instance and sets 
			/// its values.
			/// </summary>
			/// <param name="calendar">The calendar to set its date and time.</param>
			/// <param name="year">Integer value that represent the year.</param>
			/// <param name="month">Integer value that represent the month.</param>
			/// <param name="day">Integer value that represent the day.</param>
			/// <param name="hour">Integer value that represent the hour.</param>
			/// <param name="minute">Integer value that represent the minutes.</param>
			public void Set(System.Globalization.Calendar calendar, int year, int month, int day, int hour, int minute)
			{
				if (this[calendar] != null)
				{
					this.Set(calendar, CalendarManager.YEAR, year);
					this.Set(calendar, CalendarManager.MONTH, month);
					this.Set(calendar, CalendarManager.DATE, day);
					this.Set(calendar, CalendarManager.HOUR, hour);
					this.Set(calendar, CalendarManager.MINUTE, minute);
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					this.Add(calendar, tempProps);
					this.Set(calendar, year, month, day, hour, minute);
				}
			}

			/// <summary>
			/// Sets the corresponding date (day, month and year) and hour (hour, minute and second) 
			/// to the calendar specified.
			/// If the calendar does not exist in the hash table, it creates a new instance and sets 
			/// its values.
			/// </summary>
			/// <param name="calendar">The calendar to set its date and time.</param>
			/// <param name="year">Integer value that represent the year.</param>
			/// <param name="month">Integer value that represent the month.</param>
			/// <param name="day">Integer value that represent the day.</param>
			/// <param name="hour">Integer value that represent the hour.</param>
			/// <param name="minute">Integer value that represent the minutes.</param>
			/// <param name="second">Integer value that represent the seconds.</param>
			public void Set(System.Globalization.Calendar calendar, int year, int month, int day, int hour, int minute, int second)
			{
				if (this[calendar] != null)
				{
					this.Set(calendar, CalendarManager.YEAR, year);
					this.Set(calendar, CalendarManager.MONTH, month);
					this.Set(calendar, CalendarManager.DATE, day);
					this.Set(calendar, CalendarManager.HOUR, hour);
					this.Set(calendar, CalendarManager.MINUTE, minute);
					this.Set(calendar, CalendarManager.SECOND, second);
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					this.Add(calendar, tempProps);
					this.Set(calendar, year, month, day, hour, minute, second);
				}
			}

			/// <summary>
			/// Gets the value represented by the field specified.
			/// </summary>
			/// <param name="calendar">The calendar to get its date or time.</param>
			/// <param name="field">One of the field that composes a date/time.</param>
			/// <returns>The integer value for the field given.</returns>
			public int Get(System.Globalization.Calendar calendar, int field)
			{
				if (this[calendar] != null)
				{
					int tempHour;
					switch (field)
					{
						case CalendarManager.DATE:
							return ((CalendarProperties) this[calendar]).dateTime.Day;
						case CalendarManager.HOUR:
							tempHour = ((CalendarProperties) this[calendar]).dateTime.Hour;
							return tempHour > 12 ? tempHour - 12 : tempHour;
						case CalendarManager.MILLISECOND:
							return ((CalendarProperties) this[calendar]).dateTime.Millisecond;
						case CalendarManager.MINUTE:
							return ((CalendarProperties) this[calendar]).dateTime.Minute;
						case CalendarManager.MONTH:
							//Month value is 0-based. e.g., 0 for January
							return ((CalendarProperties) this[calendar]).dateTime.Month - 1;
						case CalendarManager.SECOND:
							return ((CalendarProperties) this[calendar]).dateTime.Second;
						case CalendarManager.YEAR:
							return ((CalendarProperties) this[calendar]).dateTime.Year;
						case CalendarManager.DAY_OF_MONTH:
							return ((CalendarProperties) this[calendar]).dateTime.Day;
						case CalendarManager.DAY_OF_YEAR:							
							return (int)(((CalendarProperties) this[calendar]).dateTime.DayOfYear);
						case CalendarManager.DAY_OF_WEEK:
							return (int)(((CalendarProperties) this[calendar]).dateTime.DayOfWeek) + 1;
						case CalendarManager.HOUR_OF_DAY:
							return ((CalendarProperties) this[calendar]).dateTime.Hour;
						case CalendarManager.AM_PM:
							tempHour = ((CalendarProperties) this[calendar]).dateTime.Hour;
							return tempHour > 12 ? CalendarManager.PM : CalendarManager.AM;

						default:
							return 0;
					}
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					this.Add(calendar, tempProps);
					return this.Get(calendar, field);
				}
			}

			/// <summary>
			/// Sets the time in the specified calendar with the long value.
			/// </summary>
			/// <param name="calendar">The calendar to set its date and time.</param>
			/// <param name="milliseconds">A long value that indicates the milliseconds to be set to 
			/// the hour for the calendar.</param>
			public void SetTimeInMilliseconds(System.Globalization.Calendar calendar, long milliseconds)
			{
				if (this[calendar] != null)
				{
					((CalendarProperties) this[calendar]).dateTime = new System.DateTime(milliseconds);
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = new System.DateTime(System.TimeSpan.TicksPerMillisecond * milliseconds);
					this.Add(calendar, tempProps);
				}
			}
				
			/// <summary>
			/// Gets what the first day of the week is; e.g., Sunday in US, Monday in France.
			/// </summary>
			/// <param name="calendar">The calendar to get its first day of the week.</param>
			/// <returns>A System.DayOfWeek value indicating the first day of the week.</returns>
			public System.DayOfWeek GetFirstDayOfWeek(System.Globalization.Calendar calendar)
			{
				if (this[calendar] != null)
				{
					if (((CalendarProperties)this[calendar]).dateTimeFormat == null)
					{
						((CalendarProperties)this[calendar]).dateTimeFormat = new System.Globalization.DateTimeFormatInfo();
						((CalendarProperties)this[calendar]).dateTimeFormat.FirstDayOfWeek = System.DayOfWeek.Sunday;
					}
					return ((CalendarProperties) this[calendar]).dateTimeFormat.FirstDayOfWeek;
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					tempProps.dateTimeFormat = new System.Globalization.DateTimeFormatInfo();
					tempProps.dateTimeFormat.FirstDayOfWeek = System.DayOfWeek.Sunday;
					this.Add(calendar, tempProps);
					return this.GetFirstDayOfWeek(calendar);
				}
			}

			/// <summary>
			/// Sets what the first day of the week is; e.g., Sunday in US, Monday in France.
			/// </summary>
			/// <param name="calendar">The calendar to set its first day of the week.</param>
			/// <param name="firstDayOfWeek">A System.DayOfWeek value indicating the first day of the week
			/// to be set.</param>
			public void SetFirstDayOfWeek(System.Globalization.Calendar calendar, System.DayOfWeek  firstDayOfWeek)
			{
				if (this[calendar] != null)
				{
					if (((CalendarProperties)this[calendar]).dateTimeFormat == null)
						((CalendarProperties)this[calendar]).dateTimeFormat = new System.Globalization.DateTimeFormatInfo();

					((CalendarProperties) this[calendar]).dateTimeFormat.FirstDayOfWeek = firstDayOfWeek;
				}
				else
				{
					CalendarProperties tempProps = new CalendarProperties();
					tempProps.dateTime = System.DateTime.Now;
					tempProps.dateTimeFormat = new System.Globalization.DateTimeFormatInfo();
					this.Add(calendar, tempProps);
					this.SetFirstDayOfWeek(calendar, firstDayOfWeek);
				}
			}

			/// <summary>
			/// Removes the specified calendar from the hash table.
			/// </summary>
			/// <param name="calendar">The calendar to be removed.</param>
			public void Clear(System.Globalization.Calendar calendar)
			{
				if (this[calendar] != null)
					this.Remove(calendar);
			}

			/// <summary>
			/// Removes the specified field from the calendar given.
			/// If the field does not exists in the calendar, the calendar is removed from the table.
			/// </summary>
			/// <param name="calendar">The calendar to remove the value from.</param>
			/// <param name="field">The field to be removed from the calendar.</param>
			public void Clear(System.Globalization.Calendar calendar, int field)
			{
				if (this[calendar] != null)
					this.Set(calendar, field, 0);
			}

			/// <summary>
			/// Internal class that represents the properties of a calendar instance.
			/// </summary>
			class CalendarProperties
			{
				/// <summary>
				/// The date and time of a calendar.
				/// </summary>
				public System.DateTime dateTime;
				
				/// <summary>
				/// The format for the date and time in a calendar.
				/// </summary>
				public System.Globalization.DateTimeFormatInfo dateTimeFormat;
			}
		}
	}
	/*******************************/
	/// <summary>
	/// This class provides functionality not found in .NET collection-related interfaces.
	/// </summary>
	public class ICollectionSupport
	{
		/// <summary>
		/// Adds a new element to the specified collection.
		/// </summary>
		/// <param name="c">Collection where the new element will be added.</param>
		/// <param name="obj">Object to add.</param>
		/// <returns>true</returns>
		public static bool Add(System.Collections.ICollection c, System.Object obj)
		{
			bool added = false;
			//Reflection. Invoke either the "add" or "Add" method.
			System.Reflection.MethodInfo method;
			try
			{
				//Get the "add" method for proprietary classes
				method = c.GetType().GetMethod("Add");
				if (method == null)
					method = c.GetType().GetMethod("add");
				int index = (int) method.Invoke(c, new System.Object[] {obj});
				if (index >=0)	
					added = true;
			}
			catch (System.Exception e)
			{
				throw e;
			}
			return added;
		}

		/// <summary>
		/// Adds all of the elements of the "c" collection to the "target" collection.
		/// </summary>
		/// <param name="target">Collection where the new elements will be added.</param>
		/// <param name="c">Collection whose elements will be added.</param>
		/// <returns>Returns true if at least one element was added, false otherwise.</returns>
		public static bool AddAll(System.Collections.ICollection target, System.Collections.ICollection c)
		{
			System.Collections.IEnumerator e = new System.Collections.ArrayList(c).GetEnumerator();
			bool added = false;

			//Reflection. Invoke "addAll" method for proprietary classes
			System.Reflection.MethodInfo method;
			try
			{
				method = target.GetType().GetMethod("addAll");

				if (method != null)
					added = (bool) method.Invoke(target, new System.Object[] {c});
				else
				{
					method = target.GetType().GetMethod("Add");
					while (e.MoveNext() == true)
					{
						bool tempBAdded =  (int) method.Invoke(target, new System.Object[] {e.Current}) >= 0;
						added = added ? added : tempBAdded;
					}
				}
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
			return added;
		}

		/// <summary>
		/// Removes all the elements from the collection.
		/// </summary>
		/// <param name="c">The collection to remove elements.</param>
		public static void Clear(System.Collections.ICollection c)
		{
			//Reflection. Invoke "Clear" method or "clear" method for proprietary classes
			System.Reflection.MethodInfo method;
			try
			{
				method = c.GetType().GetMethod("Clear");

				if (method == null)
					method = c.GetType().GetMethod("clear");

				method.Invoke(c, new System.Object[] {});
			}
			catch (System.Exception e)
			{
				throw e;
			}
		}

		/// <summary>
		/// Determines whether the collection contains the specified element.
		/// </summary>
		/// <param name="c">The collection to check.</param>
		/// <param name="obj">The object to locate in the collection.</param>
		/// <returns>true if the element is in the collection.</returns>
		public static bool Contains(System.Collections.ICollection c, System.Object obj)
		{
			bool contains = false;

			//Reflection. Invoke "contains" method for proprietary classes
			System.Reflection.MethodInfo method;
			try
			{
				method = c.GetType().GetMethod("Contains");

				if (method == null)
					method = c.GetType().GetMethod("contains");

				contains = (bool)method.Invoke(c, new System.Object[] {obj});
			}
			catch (System.Exception e)
			{
				throw e;
			}

			return contains;
		}

		/// <summary>
		/// Determines whether the collection contains all the elements in the specified collection.
		/// </summary>
		/// <param name="target">The collection to check.</param>
		/// <param name="c">Collection whose elements would be checked for containment.</param>
		/// <returns>true id the target collection contains all the elements of the specified collection.</returns>
		public static bool ContainsAll(System.Collections.ICollection target, System.Collections.ICollection c)
		{						
			System.Collections.IEnumerator e =  c.GetEnumerator();

			bool contains = false;

			//Reflection. Invoke "containsAll" method for proprietary classes or "Contains" method for each element in the collection
			System.Reflection.MethodInfo method;
			try
			{
				method = target.GetType().GetMethod("containsAll");

				if (method != null)
					contains = (bool)method.Invoke(target, new Object[] {c});
				else
				{					
					method = target.GetType().GetMethod("Contains");
					while (e.MoveNext() == true)
					{
						if ((contains = (bool)method.Invoke(target, new Object[] {e.Current})) == false)
							break;
					}
				}
			}
			catch (System.Exception ex)
			{
				throw ex;
			}

			return contains;
		}

		/// <summary>
		/// Removes the specified element from the collection.
		/// </summary>
		/// <param name="c">The collection where the element will be removed.</param>
		/// <param name="obj">The element to remove from the collection.</param>
		public static bool Remove(System.Collections.ICollection c, System.Object obj)
		{
			bool changed = false;

			//Reflection. Invoke "remove" method for proprietary classes or "Remove" method
			System.Reflection.MethodInfo method;
			try
			{
				method = c.GetType().GetMethod("remove");

				if (method != null)
					method.Invoke(c, new System.Object[] {obj});
				else
				{
					method = c.GetType().GetMethod("Contains");
					changed = (bool)method.Invoke(c, new System.Object[] {obj});
					method = c.GetType().GetMethod("Remove");
					method.Invoke(c, new System.Object[] {obj});
				}
			}
			catch (System.Exception e)
			{
				throw e;
			}

			return changed;
		}

		/// <summary>
		/// Removes all the elements from the specified collection that are contained in the target collection.
		/// </summary>
		/// <param name="target">Collection where the elements will be removed.</param>
		/// <param name="c">Elements to remove from the target collection.</param>
		/// <returns>true</returns>
		public static bool RemoveAll(System.Collections.ICollection target, System.Collections.ICollection c)
		{
			System.Collections.ArrayList al = ToArrayList(c);
			System.Collections.IEnumerator e = al.GetEnumerator();

			//Reflection. Invoke "removeAll" method for proprietary classes or "Remove" for each element in the collection
			System.Reflection.MethodInfo method;
			try
			{
				method = target.GetType().GetMethod("removeAll");

				if (method != null)
					method.Invoke(target, new System.Object[] {al});
				else
				{
					method = target.GetType().GetMethod("Remove");
					System.Reflection.MethodInfo methodContains = target.GetType().GetMethod("Contains");

					while (e.MoveNext() == true)
					{
						while ((bool) methodContains.Invoke(target, new System.Object[] {e.Current}) == true)
							method.Invoke(target, new System.Object[] {e.Current});
					}
				}
			}
			catch (System.Exception ex)
			{
				throw ex;
			}
			return true;
		}

		/// <summary>
		/// Retains the elements in the target collection that are contained in the specified collection
		/// </summary>
		/// <param name="target">Collection where the elements will be removed.</param>
		/// <param name="c">Elements to be retained in the target collection.</param>
		/// <returns>true</returns>
		public static bool RetainAll(System.Collections.ICollection target, System.Collections.ICollection c)
		{
			System.Collections.IEnumerator e = new System.Collections.ArrayList(target).GetEnumerator();
			System.Collections.ArrayList al = new System.Collections.ArrayList(c);

			//Reflection. Invoke "retainAll" method for proprietary classes or "Remove" for each element in the collection
			System.Reflection.MethodInfo method;
			try
			{
				method = c.GetType().GetMethod("retainAll");

				if (method != null)
					method.Invoke(target, new System.Object[] {c});
				else
				{
					method = c.GetType().GetMethod("Remove");

					while (e.MoveNext() == true)
					{
						if (al.Contains(e.Current) == false)
							method.Invoke(target, new System.Object[] {e.Current});
					}
				}
			}
			catch (System.Exception ex)
			{
				throw ex;
			}

			return true;
		}

		/// <summary>
		/// Converts an ICollection instance to an ArrayList instance.
		/// </summary>
		/// <param name="c">The ICollection instance to be converted.</param>
		/// <returns>An ArrayList instance in which its elements are the elements of the ICollection instance.</returns>
		public static System.Collections.ArrayList ToArrayList(System.Collections.ICollection c)
		{
			System.Collections.ArrayList tempArrayList = new System.Collections.ArrayList();
			System.Collections.IEnumerator tempEnumerator = c.GetEnumerator();
			while (tempEnumerator.MoveNext())
				tempArrayList.Add(tempEnumerator.Current);
			return tempArrayList;
		}
	}


	/*******************************/
	/// <summary>
	/// Converts an array of sbytes to an array of bytes
	/// </summary>
	/// <param name="sbyteArray">The array of sbytes to be converted</param>
	/// <returns>The new array of bytes</returns>
	public static byte[] ToByteArray(sbyte[] sbyteArray)
	{
		byte[] byteArray = null;

		if (sbyteArray != null)
		{
			byteArray = new byte[sbyteArray.Length];
			for(int index=0; index < sbyteArray.Length; index++)
				byteArray[index] = (byte) sbyteArray[index];
		}
		return byteArray;
	}

	/// <summary>
	/// Converts a string to an array of bytes
	/// </summary>
	/// <param name="sourceString">The string to be converted</param>
	/// <returns>The new array of bytes</returns>
	public static byte[] ToByteArray(System.String sourceString)
	{
		return System.Text.UTF8Encoding.UTF8.GetBytes(sourceString);
	}

	/// <summary>
	/// Converts a array of object-type instances to a byte-type array.
	/// </summary>
	/// <param name="tempObjectArray">Array to convert.</param>
	/// <returns>An array of byte type elements.</returns>
	public static byte[] ToByteArray(System.Object[] tempObjectArray)
	{
		byte[] byteArray = null;
		if (tempObjectArray != null)
		{
			byteArray = new byte[tempObjectArray.Length];
			for (int index = 0; index < tempObjectArray.Length; index++)
				byteArray[index] = (byte)tempObjectArray[index];
		}
		return byteArray;
	}

	/*******************************/
	/// <summary>
	/// Receives a byte array and returns it transformed in an sbyte array
	/// </summary>
	/// <param name="byteArray">Byte array to process</param>
	/// <returns>The transformed array</returns>
	public static sbyte[] ToSByteArray(byte[] byteArray)
	{
		sbyte[] sbyteArray = null;
		if (byteArray != null)
		{
			sbyteArray = new sbyte[byteArray.Length];
			for(int index=0; index < byteArray.Length; index++)
				sbyteArray[index] = (sbyte) byteArray[index];
		}
		return sbyteArray;
	}

	/*******************************/
	/// <summary>
	/// Support class used to handle threads
	/// </summary>
	public class ThreadClass : IThreadRunnable
	{
		/// <summary>
		/// The instance of System.Threading.Thread
		/// </summary>
		private System.Threading.Thread threadField;
	      
		/// <summary>
		/// Initializes a new instance of the ThreadClass class
		/// </summary>
		public ThreadClass()
		{
			threadField = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
		}
	 
		/// <summary>
		/// Initializes a new instance of the Thread class.
		/// </summary>
		/// <param name="Name">The name of the thread</param>
		public ThreadClass(System.String Name)
		{
			threadField = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
			this.Name = Name;
		}
	      
		/// <summary>
		/// Initializes a new instance of the Thread class.
		/// </summary>
		/// <param name="Start">A ThreadStart delegate that references the methods to be invoked when this thread begins executing</param>
		public ThreadClass(System.Threading.ThreadStart Start)
		{
			threadField = new System.Threading.Thread(Start);
		}
	 
		/// <summary>
		/// Initializes a new instance of the Thread class.
		/// </summary>
		/// <param name="Start">A ThreadStart delegate that references the methods to be invoked when this thread begins executing</param>
		/// <param name="Name">The name of the thread</param>
		public ThreadClass(System.Threading.ThreadStart Start, System.String Name)
		{
			threadField = new System.Threading.Thread(Start);
			this.Name = Name;
		}
	      
		/// <summary>
		/// This method has no functionality unless the method is overridden
		/// </summary>
		public virtual void Run()
		{
		}
	      
		/// <summary>
		/// Causes the operating system to change the state of the current thread instance to ThreadState.Running
		/// </summary>
		public virtual void Start()
		{
			threadField.Start();
		}
	      
		/// <summary>
		/// Interrupts a thread that is in the WaitSleepJoin thread state
		/// </summary>
		public virtual void Interrupt()
		{
			threadField.Interrupt();
		}
	      
		/// <summary>
		/// Gets the current thread instance
		/// </summary>
		public System.Threading.Thread Instance
		{
			get
			{
				return threadField;
			}
			set
			{
				threadField = value;
			}
		}
	      
		/// <summary>
		/// Gets or sets the name of the thread
		/// </summary>
		public System.String Name
		{
			get
			{
				return threadField.Name;
			}
			set
			{
				if (threadField.Name == null)
					threadField.Name = value; 
			}
		}
	      
		/// <summary>
		/// Gets or sets a value indicating the scheduling priority of a thread
		/// </summary>
		public System.Threading.ThreadPriority Priority
		{
			get
			{
				return threadField.Priority;
			}
			set
			{
				threadField.Priority = value;
			}
		}
	      
		/// <summary>
		/// Gets a value indicating the execution status of the current thread
		/// </summary>
		public bool IsAlive
		{
			get
			{
				return threadField.IsAlive;
			}
		}
	      
		/// <summary>
		/// Gets or sets a value indicating whether or not a thread is a background thread.
		/// </summary>
		public bool IsBackground
		{
			get
			{
				return threadField.IsBackground;
			} 
			set
			{
				threadField.IsBackground = value;
			}
		}
	      
		/// <summary>
		/// Blocks the calling thread until a thread terminates
		/// </summary>
		public void Join()
		{
			threadField.Join();
		}
	      
		/// <summary>
		/// Blocks the calling thread until a thread terminates or the specified time elapses
		/// </summary>
		/// <param name="MiliSeconds">Time of wait in milliseconds</param>
		public void Join(long MiliSeconds)
		{
			lock(this)
			{
				threadField.Join(new System.TimeSpan(MiliSeconds * 10000));
			}
		}
	      
		/// <summary>
		/// Blocks the calling thread until a thread terminates or the specified time elapses
		/// </summary>
		/// <param name="MiliSeconds">Time of wait in milliseconds</param>
		/// <param name="NanoSeconds">Time of wait in nanoseconds</param>
		public void Join(long MiliSeconds, int NanoSeconds)
		{
			lock(this)
			{
				threadField.Join(new System.TimeSpan(MiliSeconds * 10000 + NanoSeconds * 100));
			}
		}
	      
		/// <summary>
		/// Resumes a thread that has been suspended
		/// </summary>
		public void Resume()
		{
			threadField.Resume();
		}
	      
		/// <summary>
		/// Raises a ThreadAbortException in the thread on which it is invoked, 
		/// to begin the process of terminating the thread. Calling this method 
		/// usually terminates the thread
		/// </summary>
		public void Abort()
		{
			threadField.Abort();
		}
	      
		/// <summary>
		/// Raises a ThreadAbortException in the thread on which it is invoked, 
		/// to begin the process of terminating the thread while also providing
		/// exception information about the thread termination. 
		/// Calling this method usually terminates the thread.
		/// </summary>
		/// <param name="stateInfo">An object that contains application-specific information, such as state, which can be used by the thread being aborted</param>
		public void Abort(System.Object stateInfo)
		{
			lock(this)
			{
				threadField.Abort(stateInfo);
			}
		}
	      
		/// <summary>
		/// Suspends the thread, if the thread is already suspended it has no effect
		/// </summary>
		public void Suspend()
		{
			threadField.Suspend();
		}
	      
		/// <summary>
		/// Obtain a String that represents the current Object
		/// </summary>
		/// <returns>A String that represents the current Object</returns>
		public override System.String ToString()
		{
			return "Thread[" + Name + "," + Priority.ToString() + "," + "" + "]";
		}
	     
		/// <summary>
		/// Gets the currently running thread
		/// </summary>
		/// <returns>The currently running thread</returns>
		public static ThreadClass Current()
		{
			ThreadClass CurrentThread = new ThreadClass();
			CurrentThread.Instance = System.Threading.Thread.CurrentThread;
			return CurrentThread;
		}
	}


	/*******************************/
	/// <summary>
	/// This class provides functionality to reads and unread characters into a buffer.
	/// </summary>
	public class BackReader : System.IO.StreamReader
	{
		private char[] buffer;
		private int position = 1;
		//private int markedPosition;

		/// <summary>
		/// Constructor. Calls the base constructor.
		/// </summary>
		/// <param name="streamReader">The buffer from which chars will be read.</param>
		/// <param name="size">The size of the Back buffer.</param>
		public BackReader(System.IO.Stream streamReader, int size, System.Text.Encoding encoding) : base(streamReader,encoding)
		{
			this.buffer = new char[size];
			this.position = size;
		}

		/// <summary>
		/// Constructor. Calls the base constructor.
		/// </summary>
		/// <param name="streamReader">The buffer from which chars will be read.</param>
		public BackReader(System.IO.Stream streamReader, System.Text.Encoding encoding) : base(streamReader, encoding)
		{
			this.buffer = new char[this.position];
		}

		/// <summary>
		/// Checks if this stream support mark and reset methods.
		/// </summary>
		/// <remarks>
		/// This method isn't supported.
		/// </remarks>
		/// <returns>Always false.</returns>
		public bool MarkSupported()
		{
			return false;
		}

		/// <summary>
		/// Marks the element at the corresponding position.
		/// </summary>
		/// <remarks>
		/// This method isn't supported.
		/// </remarks>
		public void Mark(int position)
		{
			throw new System.IO.IOException("Mark operations are not allowed");			
		}

		/// <summary>
		/// Resets the current stream.
		/// </summary>
		/// <remarks>
		/// This method isn't supported.
		/// </remarks>
		public void Reset()
		{
			throw new System.IO.IOException("Mark operations are not allowed");
		}

		/// <summary>
		/// Reads a character.
		/// </summary>
		/// <returns>The character read.</returns>
		public override int Read()
		{
			if (this.position >= 0 && this.position < this.buffer.Length)
				return (int) this.buffer[this.position++];
			return base.Read();
		}

		/// <summary>
		/// Reads an amount of characters from the buffer and copies the values to the array passed.
		/// </summary>
		/// <param name="array">Array where the characters will be stored.</param>
		/// <param name="index">The beginning index to read.</param>
		/// <param name="count">The number of characters to read.</param>
		/// <returns>The number of characters read.</returns>
		public override int Read(char[] array, int index, int count)
		{
			int readLimit = this.buffer.Length - this.position;

			if (count <= 0)
				return 0;

			if (readLimit > 0)
			{
				if (count < readLimit)
					readLimit = count;
				System.Array.Copy(this.buffer, this.position, array, index, readLimit);
				count -= readLimit;
				index += readLimit;
				this.position += readLimit;
			}

			if (count > 0)
			{
				count = base.Read(array, index, count);
				if (count == -1)
				{
					if (readLimit == 0)
						return -1;
					return readLimit;
				}
				return readLimit + count;
			}
			return readLimit;
		}

		/// <summary>
		/// Checks if this buffer is ready to be read.
		/// </summary>
		/// <returns>True if the position is less than the length, otherwise false.</returns>
		public bool IsReady()
		{
			return (this.position >= this.buffer.Length || this.BaseStream.Position >= this.BaseStream.Length);
		}

		/// <summary>
		/// Unreads a character.
		/// </summary>
		/// <param name="unReadChar">The character to be unread.</param>
		public void UnRead(int unReadChar)
		{
			this.position--;
			this.buffer[this.position] = (char) unReadChar;
		}

		/// <summary>
		/// Unreads an amount of characters by moving these to the buffer.
		/// </summary>
		/// <param name="array">The character array to be unread.</param>
		/// <param name="index">The beginning index to unread.</param>
		/// <param name="count">The number of characters to unread.</param>
		public void UnRead(char[] array, int index, int count)
		{
			this.Move(array, index, count);
		}

		/// <summary>
		/// Unreads an amount of characters by moving these to the buffer.
		/// </summary>
		/// <param name="array">The character array to be unread.</param>
		public void UnRead(char[] array)
		{
			this.Move(array, 0, array.Length - 1);
		}

		/// <summary>
		/// Moves the array of characters to the buffer.
		/// </summary>
		/// <param name="array">Array of characters to move.</param>
		/// <param name="index">Offset of the beginning.</param>
		/// <param name="count">Amount of characters to move.</param>
		private void Move(char[] array, int index, int count)
		{
			for (int arrayPosition = index + count; arrayPosition >= index; arrayPosition--)
				this.UnRead(array[arrayPosition]);
		}
	}


	/*******************************/
	/// <summary>
	/// The class performs token processing in strings
	/// </summary>
	public class Tokenizer: System.Collections.IEnumerator
	{
		/// Position over the string
		private long currentPos = 0;

		/// Include demiliters in the results.
		private bool includeDelims = false;

		/// Char representation of the String to tokenize.
		private char[] chars = null;
			
		//The tokenizer uses the default delimiter set: the space character, the tab character, the newline character, and the carriage-return character and the form-feed character
		private string delimiters = " \t\n\r\f";		

		/// <summary>
		/// Initializes a new class instance with a specified string to process
		/// </summary>
		/// <param name="source">String to tokenize</param>
		public Tokenizer(System.String source)
		{			
			this.chars = source.ToCharArray();
		}

		/// <summary>
		/// Initializes a new class instance with a specified string to process
		/// and the specified token delimiters to use
		/// </summary>
		/// <param name="source">String to tokenize</param>
		/// <param name="delimiters">String containing the delimiters</param>
		public Tokenizer(System.String source, System.String delimiters):this(source)
		{			
			this.delimiters = delimiters;
		}


		/// <summary>
		/// Initializes a new class instance with a specified string to process, the specified token 
		/// delimiters to use, and whether the delimiters must be included in the results.
		/// </summary>
		/// <param name="source">String to tokenize</param>
		/// <param name="delimiters">String containing the delimiters</param>
		/// <param name="includeDelims">Determines if delimiters are included in the results.</param>
		public Tokenizer(System.String source, System.String delimiters, bool includeDelims):this(source,delimiters)
		{
			this.includeDelims = includeDelims;
		}	


		/// <summary>
		/// Returns the next token from the token list
		/// </summary>
		/// <returns>The string value of the token</returns>
		public System.String NextToken()
		{				
			return NextToken(this.delimiters);
		}

		/// <summary>
		/// Returns the next token from the source string, using the provided
		/// token delimiters
		/// </summary>
		/// <param name="delimiters">String containing the delimiters to use</param>
		/// <returns>The string value of the token</returns>
		public System.String NextToken(System.String delimiters)
		{
			//According to documentation, the usage of the received delimiters should be temporary (only for this call).
			//However, it seems it is not true, so the following line is necessary.
			this.delimiters = delimiters;

			//at the end 
			if (this.currentPos == this.chars.Length)
				throw new System.ArgumentOutOfRangeException();
			//if over a delimiter and delimiters must be returned
			else if (   (System.Array.IndexOf(delimiters.ToCharArray(),chars[this.currentPos]) != -1)
				     && this.includeDelims )                	
				return "" + this.chars[this.currentPos++];
			//need to get the token wo delimiters.
			else
				return nextToken(delimiters.ToCharArray());
		}

		//Returns the nextToken wo delimiters
		private System.String nextToken(char[] delimiters)
		{
			string token="";
			long pos = this.currentPos;

			//skip possible delimiters
			while (System.Array.IndexOf(delimiters,this.chars[currentPos]) != -1)
				//The last one is a delimiter (i.e there is no more tokens)
				if (++this.currentPos == this.chars.Length)
				{
					this.currentPos = pos;
					throw new System.ArgumentOutOfRangeException();
				}
			
			//getting the token
			while (System.Array.IndexOf(delimiters,this.chars[this.currentPos]) == -1)
			{
				token+=this.chars[this.currentPos];
				//the last one is not a delimiter
				if (++this.currentPos == this.chars.Length)
					break;
			}
			return token;
		}

				
		/// <summary>
		/// Determines if there are more tokens to return from the source string
		/// </summary>
		/// <returns>True or false, depending if there are more tokens</returns>
		public bool HasMoreTokens()
		{
			//keeping the current pos
			long pos = this.currentPos;
			
			try
			{
				this.NextToken();
			}
			catch (System.ArgumentOutOfRangeException)
			{				
				return false;
			}
			finally
			{
				this.currentPos = pos;
			}
			return true;
		}

		/// <summary>
		/// Remaining tokens count
		/// </summary>
		public int Count
		{
			get
			{
				//keeping the current pos
				long pos = this.currentPos;
				int i = 0;
			
				try
				{
					while (true)
					{
						this.NextToken();
						i++;
					}
				}
				catch (System.ArgumentOutOfRangeException)
				{				
					this.currentPos = pos;
					return i;
				}
			}
		}

		/// <summary>
		///  Performs the same action as NextToken.
		/// </summary>
		public System.Object Current
		{
			get
			{
				return (Object) this.NextToken();
			}		
		}		
		
		/// <summary>
		//  Performs the same action as HasMoreTokens.
		/// </summary>
		/// <returns>True or false, depending if there are more tokens</returns>
		public bool MoveNext()
		{
			return this.HasMoreTokens();
		}
		
		/// <summary>
		/// Does nothing.
		/// </summary>
		public void  Reset()
		{
			;
		}			
	}
	/*******************************/
	/// <summary>
	/// Checks if the giving File instance is a directory or file, and returns his Length
	/// </summary>
	/// <param name="file">The File instance to check</param>
	/// <returns>The length of the file</returns>
	public static long FileLength(System.IO.FileInfo file)
	{
		if (file.Exists)
			return file.Length;
		else 
			return 0;
	}

	/*******************************/
	/// <summary>
	/// The SplitterPanel its a panel with two controls separated by a movable splitter.
	/// </summary>
	public class SplitterPanelSupport : System.Windows.Forms.Panel
	{
		private System.Windows.Forms.Control firstControl;
		private System.Windows.Forms.Control secondControl;
		private System.Windows.Forms.Splitter splitter;
		private System.Windows.Forms.Orientation orientation;
		private int splitterSize;
		private int splitterLocation;
		private int lastSplitterLocation;

		//Default controls
		private System.Windows.Forms.Control defaultFirstControl;
		private System.Windows.Forms.Control defaultSecondControl;

		/// <summary>
		/// Creates a SplitterPanel with Horizontal orientation and two buttons as the default
		/// controls. The default size of the splitter is set to 5.
		/// </summary>
		public SplitterPanelSupport() : base()
		{
			System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
			System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
			button1.Text = "button1";
			button2.Text = "button2";
				
			this.lastSplitterLocation = -1;
			this.orientation = System.Windows.Forms.Orientation.Horizontal;
			this.splitterSize = 5;

			this.defaultFirstControl  = button1;
			this.defaultSecondControl = button2;
			this.firstControl  = this.defaultFirstControl;
			this.secondControl = this.defaultSecondControl;
			this.splitterLocation = this.firstControl.Size.Width;
			this.splitter = new System.Windows.Forms.Splitter();
			this.SuspendLayout();

			//
			// panel1
			//
			this.Controls.Add(this.splitter);
			this.Controls.Add(this.firstControl);
			this.Controls.Add(this.secondControl);
				
			// 
			// firstControl
			// 
			this.firstControl.Dock = System.Windows.Forms.DockStyle.Left;
			this.firstControl.Name = "firstControl";
			this.firstControl.TabIndex = 0;
				
			// 
			// secondControl
			//
			this.secondControl.Name = "secondControl";
			this.secondControl.TabIndex = 1;
			this.secondControl.Size = new System.Drawing.Size((this.Size.Width - this.firstControl.Size.Width) + this.splitterSize, this.Size.Height);
			this.secondControl.Location = new System.Drawing.Point((this.firstControl.Location.X + this.firstControl.Size.Width + this.splitterSize), 0);

			// 
			// splitter
			//			
			this.splitter.Name = "splitter";
			this.splitter.TabIndex = 2;
			this.splitter.TabStop = false;
			this.splitter.MinExtra = 10;
			this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitter.Size = new System.Drawing.Size(this.splitterSize, this.Size.Height);
			this.splitter.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(splitter_SplitterMoved);
				
			this.SizeChanged += new System.EventHandler(SplitterPanel_SizeChanged);
			this.ResumeLayout(false);
		}

		/// <summary>
		/// Creates a new SplitterPanelSupport with two buttons as default controls and the specified
		/// splitter orientation.
		/// </summary>
		/// <param name="newOrientation">The orientation of the SplitterPanel.</param>
		public SplitterPanelSupport(int newOrientation) : this()
		{
			this.SplitterOrientation = (System.Windows.Forms.Orientation) newOrientation;
		}

		/// <summary>
		/// Creates a new SplitterPanelSupport with the specified controls and orientation.
		/// </summary>
		/// <param name="newOrientation">The orientation of the SplitterPanel.</param>
		/// <param name="first">The first control of the panel, left-top control.</param>
		/// <param name="second">The second control of the panel, right-botton control.</param>
		public SplitterPanelSupport(int newOrientation, System.Windows.Forms.Control first, System.Windows.Forms.Control second) : this(newOrientation)
		{
			this.FirstControl  = first;
			this.SecondControl = second;
		}


		/// <summary>
		/// Creates a new SplitterPanelSupport with the specified controls and orientation.
		/// </summary>		
		/// <param name="first">The first control of the panel, left-top control.</param>
		/// <param name="second">The second control of the panel, right-botton control.</param>
		public SplitterPanelSupport(System.Windows.Forms.Control first, System.Windows.Forms.Control second) : this()
		{
			this.FirstControl  = first;
			this.SecondControl = second;
		}

		/// <summary>
		/// Adds a control to the SplitterPanel in the first available position.
		/// </summary>		
		/// <param name="control">The control to by added.</param>
		public void Add(System.Windows.Forms.Control control)
		{
			if(FirstControl == defaultFirstControl)
				FirstControl = control;
			else if(SecondControl == defaultSecondControl) 
				SecondControl = control;
		}

		/// <summary>
		/// Adds a control to the SplitterPanel in the specified position.
		/// </summary>		
		/// <param name="control">The control to by added.</param>
		/// <param name="position">The position to add the control in the SpliterPanel.</param>
		public void Add(System.Windows.Forms.Control control, SpliterPosition position)
		{
			if(position == SpliterPosition.First)
				FirstControl = control;
			else if(position == SpliterPosition.Second) 
				SecondControl = control;
		}

		/// <summary>
		/// Defines the possible positions of a control in a SpliterPanel.
		/// </summary>		
		public enum SpliterPosition
		{
			First,
			Second,
		}

		/// <summary>
		/// Gets the specified component.
		/// </summary>
		/// <param name="name">the name of the part of the component to get: "nw": first control, 
		/// "se": second control, "splitter": splitter.</param>
		/// <returns>returns the specified component.</returns>
		public virtual System.Windows.Forms.Control GetComponent(System.String name)
		{
			if (name == "nw")
				return this.FirstControl;
			else if (name == "se")
				return this.SecondControl;
			else if (name == "splitter")
				return this.splitter;
			else return null;
		}

		/// <summary>
		/// First control of the panel. When orientation is Horizontal then this is the left control
		/// when the orientation is Vertical then this is the top control.
		/// </summary>
		public virtual System.Windows.Forms.Control FirstControl
		{
			get
			{
				return this.firstControl;
			}
			set
			{
				this.Controls.Remove(this.firstControl);
				if (this.orientation == System.Windows.Forms.Orientation.Horizontal)
					value.Dock = System.Windows.Forms.DockStyle.Left;
				else
					value.Dock = System.Windows.Forms.DockStyle.Top;
				value.Size = this.firstControl.Size;
				this.firstControl = value;
				this.Controls.Add(this.firstControl);
			}
		}

		/// <summary>
		/// The second control of the panel. Right control when the panel is Horizontal oriented and
		/// botton control when the SplitterPanel orientation is Vertical.
		/// </summary>
		public virtual System.Windows.Forms.Control SecondControl
		{
			get
			{
				return this.secondControl;
			}
			set
			{
				this.Controls.Remove(this.secondControl);
				value.Size = this.secondControl.Size;
				value.Location = this.secondControl.Location;
				this.secondControl = value;
				this.Controls.Add(this.secondControl);
			}
		}

		/// <summary>
		/// The orientation of the SplitterPanel. Specifies how the controls are aligned.
		/// Left to right using Horizontal orientation or top to botton with Vertical orientation.
		/// </summary>
		public virtual System.Windows.Forms.Orientation SplitterOrientation
		{
			get
			{
				return this.orientation;
			}
			set
			{
				if (value != this.orientation)
				{
					this.orientation = value;
					if (value == System.Windows.Forms.Orientation.Vertical)
					{
						int lastWidth = this.firstControl.Size.Width;
						this.firstControl.Dock = System.Windows.Forms.DockStyle.Top;
						this.firstControl.Size = new System.Drawing.Size(this.Width, lastWidth);
						this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
					}
					else
					{
						int lastHeight = this.firstControl.Size.Height;
						this.firstControl.Dock = System.Windows.Forms.DockStyle.Left;
						this.firstControl.Size = new System.Drawing.Size(lastHeight, this.Height);
						this.splitter.Dock = System.Windows.Forms.DockStyle.Left;
					}
					this.ResizeSecondControl();
				}
			}
		}

		/// <summary>
		/// Specifies the location of the Splitter in the panel.
		/// </summary>
		public virtual int SplitterLocation
		{
			get
			{
				return this.splitterLocation;
			}
			set
			{
				if (this.orientation == System.Windows.Forms.Orientation.Horizontal)
					this.firstControl.Size = new System.Drawing.Size(value, this.Height);
				else
					this.firstControl.Size = new System.Drawing.Size(this.Width, value);					
				this.ResizeSecondControl();
				this.lastSplitterLocation = this.splitterLocation;
				this.splitterLocation = value;
			}
		}

		/// <summary>
		/// The last location of the splitter on the panel.
		/// </summary>
		public virtual int LastSplitterLocation
		{
			get
			{
				return this.lastSplitterLocation;
			}
			set
			{
				this.lastSplitterLocation = value;
			}
		}

		/// <summary>
		/// Specifies the size of the splitter divider.
		/// </summary>
		public virtual int SplitterSize
		{
			get
			{
				return this.splitterSize;
			}
			set
			{
				this.splitterSize = value;
				if (this.orientation == System.Windows.Forms.Orientation.Horizontal)
					this.splitter.Size = new System.Drawing.Size(this.splitterSize, this.Size.Height);
				else
					this.splitter.Size = new System.Drawing.Size(this.Size.Width, this.splitterSize);
				this.ResizeSecondControl();
			}
		}

		/// <summary>
		/// The minimum location of the splitter on the panel.
		/// </summary>
		/// <returns>The minimum location value for the splitter.</returns>
		public virtual int GetMinimumLocation()
		{
			return this.splitter.MinSize;
		}

		/// <summary>
		/// The maximum location of the splitter on the panel.
		/// </summary>
		/// <returns>The maximum location value for the splitter.</returns>
		public virtual int GetMaximumLocation()
		{
			if (this.orientation == System.Windows.Forms.Orientation.Horizontal)
				return this.Width - ( this.SplitterSize / 2 );
			else
				return this.Height - ( this.SplitterSize / 2 );
		}

		/// <summary>
		/// Adds a control to splitter panel.
		/// </summary>
		/// <param name="controlToAdd">The control to add.</param>
		/// <param name="dockStyle">The dock style for the control, left-top, or botton-right.</param>
		/// <param name="index">The index of the control in the panel control list.</param>
		protected virtual void AddControl(System.Windows.Forms.Control controlToAdd, System.Object dockStyle, int index)
		{
			if (dockStyle is System.String)
			{
				System.String dock = (System.String)dockStyle;
				if (dock == "botton" || dock == "right")
					this.SecondControl = controlToAdd;
				else if (dock == "top" || dock == "left")
					this.FirstControl  = controlToAdd;
				else
					throw new System.ArgumentException("Cannot add control: unknown constraint: " + dockStyle.ToString());
				this.Controls.SetChildIndex(controlToAdd, index);
			}
			else
				throw new System.ArgumentException("Cannot add control: unknown constraint: " + dockStyle.ToString());
		}

		/// <summary>
		/// Removes the specified control from the panel.
		/// </summary>
		/// <param name="controlToRemove">The control to remove.</param>
		public virtual void RemoveControl(System.Windows.Forms.Control controlToRemove)
		{
			if (this.Contains(controlToRemove))
			{
				this.Controls.Remove(controlToRemove);
				if (this.firstControl == controlToRemove)
					this.secondControl.Dock = System.Windows.Forms.DockStyle.Fill;
				else
					this.firstControl.Dock = System.Windows.Forms.DockStyle.Fill;
			}
		}

		/// <summary>
		/// Remove the control identified by the specified index.
		/// </summary>
		/// <param name="index">The index of the control to remove.</param>
		public virtual void RemoveControl(int index)
		{
			try 
			{
				this.Controls.RemoveAt(index);
				if (this.firstControl != null)
					if (this.Controls.Contains(this.firstControl))
						this.firstControl.Dock = System.Windows.Forms.DockStyle.Fill;
					else if (this.secondControl != null && (this.Controls.Contains(this.secondControl)))
						this.secondControl.Dock = System.Windows.Forms.DockStyle.Fill;
			} // Compatibility with the conversion assistant.
			catch (System.ArgumentOutOfRangeException)
			{
				throw new System.IndexOutOfRangeException("No such child: " + index);
			}
		}
			
		/// <summary>
		/// Changes the location of the splitter in the panel as a percentage of the panel's size.
		/// </summary>
		/// <param name="proportion">The percentage from 0.0 to 1.0.</param>
		public virtual void SetLocationProportional(double proportion)
		{
			if ((proportion > 0.0) && (proportion < 1.0))
				this.SplitterLocation = (int)((this.orientation == System.Windows.Forms.Orientation.Horizontal) ? (proportion * this.Width) : (proportion * this.Height));
			else
				throw new System.ArgumentException("Proportional location must be between 0.0 and 1.0");
		}

		private void splitter_SplitterMoved(System.Object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			this.lastSplitterLocation = this.splitterLocation;
			if (this.orientation == System.Windows.Forms.Orientation.Horizontal)
				this.splitterLocation = this.firstControl.Width;
			else
				this.splitterLocation = this.firstControl.Height;
			this.ResizeSecondControl();
		}

		private void SplitterPanel_SizeChanged(System.Object sender, System.EventArgs e)
		{
			this.ResizeSecondControl();
		}

		private void ResizeSecondControl()
		{
			if (this.orientation == System.Windows.Forms.Orientation.Horizontal)
			{
				this.secondControl.Size = new System.Drawing.Size((this.Width - (this.firstControl.Size.Width + this.splitterSize)), this.Size.Height);
				this.secondControl.Location = new System.Drawing.Point((this.firstControl.Size.Width + this.splitterSize), 0);
			}
			else
			{
				this.secondControl.Size = new System.Drawing.Size(this.Size.Width, (this.Size.Height - (this.firstControl.Size.Height + this.splitterSize)));
				this.secondControl.Location = new System.Drawing.Point(0, (this.firstControl.Size.Height + this.splitterSize));
			}
		}
	}


	/*******************************/
	/// <summary>
	/// This method works as a handler for the Control.Layout event, it arranges the controls into the container 
	/// control in a left-to-right orientation.
	/// The location of each control will be calculated according the number of them in the container. 
	/// The corresponding alignment, the horizontal and vertical spacing between the inner controls are specified
	/// as an array of object values in the Tag property of the container.
	/// </summary>
	/// <param name="event_sender">The container control in which the controls will be relocated.</param>
	/// <param name="eventArgs">Data of the event.</param>
	public static void FlowLayoutResize(System.Object event_sender, System.Windows.Forms.LayoutEventArgs eventArgs)
	{
		System.Windows.Forms.Control container = (System.Windows.Forms.Control) event_sender;
		if (container.Tag is System.Array)
		{
			System.Object[] items = (System.Object[]) container.Tag;
			if (items.Length == 3)
			{
				container.SuspendLayout();

				int width = container.Width;
				int height = container.Height;
				if (!(container is System.Windows.Forms.ScrollableControl))
				{
					width = container.DisplayRectangle.Width;
					height = container.DisplayRectangle.Height;
				}
				else
					if (container is System.Windows.Forms.Form)
					{
						width = ((System.Windows.Forms.Form) container).ClientSize.Width;
						height = ((System.Windows.Forms.Form) container).ClientSize.Height;
					}
				System.Drawing.ContentAlignment alignment = (System.Drawing.ContentAlignment) items[0];
				int horizontal = (int) items[1];
				int vertical = (int) items[2];

				// Split controls in several rows
				System.Collections.ArrayList rows = new System.Collections.ArrayList();
				System.Collections.ArrayList list = new System.Collections.ArrayList();
				int tempWidth = 0;
				int tempHeight = 0;
				int totalHeight = 0;
				for (int index = 0; index < container.Controls.Count; index++)
				{
					if (tempHeight < container.Controls[index].Height)
						tempHeight = container.Controls[index].Height;

					list.Add(container.Controls[index]);

					if (index == 0) tempWidth = container.Controls[0].Width;

					if (index == container.Controls.Count - 1)
					{
						rows.Add(list);
						totalHeight += tempHeight + vertical;
					}
					else
					{
						tempWidth += horizontal + container.Controls[index + 1].Width;
						if (tempWidth >= width - horizontal * 2)
						{
							rows.Add(list);
							totalHeight += tempHeight + vertical;
							tempHeight = 0;
							list = new System.Collections.ArrayList();
							tempWidth = container.Controls[index + 1].Width;
						}
					}
				}
				totalHeight -= vertical;

				// Break out alignment coordinates
				int h = 0;
				int cx = 0;
				int cy = 0;
				if (((int) alignment & 0x00F) > 0)
				{
					h = (int) alignment;
					cy = 1;
				}
				if (((int) alignment & 0x0F0) > 0)
				{
					h = (int) alignment >> 4;
					cy = 2;
				}
				if (((int) alignment & 0xF00) > 0)
				{
					h = (int) alignment >> 8;
					cy = 3;
				}
				if (h == 1) cx = 1;
				if (h == 2) cx = 2;
				if (h == 4) cx = 3;

				int ypos = vertical;
				if (cy == 2) ypos = height / 2 - totalHeight / 2;
				if (cy == 3) ypos = height - totalHeight - vertical;
				foreach (System.Collections.ArrayList row in rows)
				{
					int maxHeight = PlaceControls(row, width, cx, ypos, horizontal);
					ypos += vertical + maxHeight;
				}
				container.ResumeLayout();
			}
		}
	}

	private static int PlaceControls(System.Collections.ArrayList controls, int width, int cx, int ypos, int horizontal)
	{
		int count = controls.Count;
		int controlsWidth = 0;
		int maxHeight = 0;
		foreach (System.Windows.Forms.Control control in controls)
		{
			controlsWidth += control.Width;
			if (maxHeight < control.Height) maxHeight = control.Height;
		}
		controlsWidth += horizontal * (count - 1);

		// Start x point
		int xpos = 0;
		if (cx == 1) xpos = horizontal; // Left
		if (cx == 2) xpos = width / 2 - controlsWidth / 2; // Center
		if (cx == 3) xpos = width - horizontal - controlsWidth; // Right

		// Place controls
		int x = xpos;
		foreach (System.Windows.Forms.Control control in controls)
		{
			int y = ypos + (maxHeight / 2) - control.Height / 2;
			control.Location = new System.Drawing.Point(x, y);
			x += control.Width + horizontal;
		}
		return maxHeight;
	}


	/*******************************/
	/// <summary>
	/// This class has static methods for manage CheckBox and RadioButton controls.
	/// </summary>
	public class CheckBoxSupport
	{

		/// <summary>
		/// Receives a CheckBox instance and sets the specific text and style.
		/// </summary>
		/// <param name="checkBoxInstance">CheckBox instance to be set.</param>
		/// <param name="text">The text to set Text property.</param>
		/// <param name="style">The style to be used to set the threeState property.</param>
		public static void SetCheckBox(System.Windows.Forms.CheckBox checkBoxInstance, System.String text, int style)
		{
			checkBoxInstance.Text = text;			
			if (style == 2097152)
				checkBoxInstance.ThreeState = true;
		}

		/// <summary>
		/// Returns a new CheckBox instance with the specified text
		/// </summary>
		/// <param name="text">The text to create the CheckBox with</param>
		/// <returns>A new CheckBox instance</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.String text)
		{
			System.Windows.Forms.CheckBox tempCheck = new System.Windows.Forms.CheckBox();
			tempCheck.Text = text;
			return tempCheck;
		}

		/// <summary>
		/// Creates a CheckBox with a specified image.
		/// </summary>
		/// <param name="icon">The image to be used with the CheckBox.</param>
		/// <returns>A new CheckBox instance with an image.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.Drawing.Image icon)
		{
			System.Windows.Forms.CheckBox tempCheckBox = new System.Windows.Forms.CheckBox();
			tempCheckBox.Image = icon;
			return tempCheckBox;
		}

		/// <summary>
		/// Creates a CheckBox with a specified label and image.
		/// </summary>
		/// <param name="text">The text to be used as label.</param>
		/// <param name="icon">The image to be used with the CheckBox.</param>
		/// <returns>A new CheckBox instance with a label and an image.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.String text, System.Drawing.Image icon)
		{
			System.Windows.Forms.CheckBox tempCheckBox = new System.Windows.Forms.CheckBox();
			tempCheckBox.Text = text;
			tempCheckBox.Image = icon;
			return tempCheckBox;
		}

		/// <summary>
		/// Returns a new CheckBox instance with the specified text and state
		/// </summary>
		/// <param name="text">The text to create the CheckBox with</param>
		/// <param name="checkedStatus">Indicates if the Checkbox is checked or not</param>
		/// <returns>A new CheckBox instance</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.String text, bool checkedStatus)
		{
			System.Windows.Forms.CheckBox tempCheckBox = new System.Windows.Forms.CheckBox();
			tempCheckBox.Text = text;
			tempCheckBox.Checked = checkedStatus;
			return tempCheckBox;
		}

		/// <summary>
		/// Creates a CheckBox with a specified image and checked if checkedStatus is true.
		/// </summary>
		/// <param name="icon">The image to be used with the CheckBox.</param>
		/// <param name="checkedStatus">Value to be set to Checked property.</param>
		/// <returns>A new CheckBox instance.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.Drawing.Image icon, bool checkedStatus)
		{
			System.Windows.Forms.CheckBox tempCheckBox = new System.Windows.Forms.CheckBox();
			tempCheckBox.Image = icon;
			tempCheckBox.Checked = checkedStatus;
			return tempCheckBox;
		}

		/// <summary>
		/// Creates a CheckBox with label, image and checked if checkedStatus is true.
		/// </summary>
		/// <param name="text">The text to be used as label.</param>
		/// <param name="icon">The image to be used with the CheckBox.</param>
		/// <param name="checkedStatus">Value to be set to Checked property.</param>
		/// <returns>A new CheckBox instance.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.String text, System.Drawing.Image icon, bool checkedStatus)
		{
			System.Windows.Forms.CheckBox tempCheckBox = new System.Windows.Forms.CheckBox();
			tempCheckBox.Text = text;
			tempCheckBox.Image = icon;
			tempCheckBox.Checked = checkedStatus;
			return tempCheckBox;
		}

		/// <summary>
		/// Creates a CheckBox with a specific control.
		/// </summary>
		/// <param name="control">The control to be added to the CheckBox.</param>
		/// <returns>The new CheckBox with the specific control.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.Windows.Forms.Control control)
		{
			System.Windows.Forms.CheckBox tempCheckBox = new System.Windows.Forms.CheckBox();
			tempCheckBox.Controls.Add(control);
			control.Location = new System.Drawing.Point(0, 18);
			return tempCheckBox;
		}

		/// <summary>
		/// Creates a CheckBox with the specific control and style.
		/// </summary>
		/// <param name="control">The control to be added to the CheckBox.</param>
		/// <param name="style">The style to be used to set the threeState property.</param>
		/// <returns>The new CheckBox with the specific control and style.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.Windows.Forms.Control control, int style)
		{
			System.Windows.Forms.CheckBox tempCheckBox = new System.Windows.Forms.CheckBox();
			tempCheckBox.Controls.Add(control);
			control.Location = new System.Drawing.Point(0, 18);
			if (style == 2097152)
				tempCheckBox.ThreeState = true;
			return tempCheckBox;
		}

		/// <summary>
		/// Returns a new RadioButton instance with the specified text in the specified panel.
		/// </summary>
		/// <param name="text">The text to create the RadioButton with.</param>
		/// <param name="checkedStatus">Indicates if the RadioButton is checked or not.</param>
		/// <param name="panel">The panel where the RadioButton will be placed.</param>
		/// <returns>A new RadioButton instance.</returns>
		/// <remarks>If the panel is null the third param is ignored</remarks>
		public static System.Windows.Forms.RadioButton CreateRadioButton(System.String text, bool checkedStatus, System.Windows.Forms.Panel panel)
		{
			System.Windows.Forms.RadioButton tempCheckBox = new System.Windows.Forms.RadioButton();
			tempCheckBox.Text = text;
			tempCheckBox.Checked= checkedStatus;
			if (panel != null)
				panel.Controls.Add(tempCheckBox);
			return tempCheckBox;
		}

		/// <summary>
		/// Receives a CheckBox instance and sets the Text and Image properties.
		/// </summary>
		/// <param name="checkBoxInstance">CheckBox instance to be set.</param>
		/// <param name="text">Value to be set to Text property.</param>
		/// <param name="icon">Value to be set to Image property.</param>
		public static void SetCheckBox(System.Windows.Forms.CheckBox checkBoxInstance, System.String text, System.Drawing.Image icon)
		{
			checkBoxInstance.Text = text;
			checkBoxInstance.Image = icon;
		}

		/// <summary>
		/// Receives a CheckBox instance and sets the Text and Checked properties.
		/// </summary>
		/// <param name="checkBoxInstance">CheckBox instance to be set</param>
		/// <param name="text">Value to be set to Text</param>
		/// <param name="checkedStatus">Value to be set to Checked property.</param>
		public static void SetCheckBox(System.Windows.Forms.CheckBox checkBoxInstance, System.String text, bool checkedStatus)
		{
			checkBoxInstance.Text = text;
			checkBoxInstance.Checked = checkedStatus;
		}

		/// <summary>
		/// Receives a CheckBox instance and sets the Image and Checked properties.
		/// </summary>
		/// <param name="checkBoxInstance">CheckBox instance to be set.</param>
		/// <param name="icon">Value to be set to Image property.</param>
		/// <param name="checkedStatus">Value to be set to Checked property.</param>
		public static void SetCheckBox(System.Windows.Forms.CheckBox checkBoxInstance, System.Drawing.Image icon, bool checkedStatus)
		{
			checkBoxInstance.Image = icon;
			checkBoxInstance.Checked = checkedStatus;
		}

		/// <summary>
		/// Receives a CheckBox instance and sets the Text, Image and Checked properties.
		/// </summary>
		/// <param name="checkBoxInstance">CheckBox instance to be set.</param>
		/// <param name="text">Value to be set to Text property.</param>
		/// <param name="icon">Value to be set to Image property.</param>
		/// <param name="checkedStatus">Value to be set to Checked property.</param>
		public static void SetCheckBox(System.Windows.Forms.CheckBox checkBoxInstance, System.String text, System.Drawing.Image icon, bool checkedStatus)
		{
			checkBoxInstance.Text = text;
			checkBoxInstance.Image = icon;
			checkBoxInstance.Checked = checkedStatus;
		}
		
		/// <summary>
		/// Receives a CheckBox instance and sets the control specified.
		/// </summary>
		/// <param name="checkBoxInstance">CheckBox instance to be set.</param>
		/// <param name="control">The control assiciated with the CheckBox</param>
		public static void SetCheckBox(System.Windows.Forms.CheckBox checkBoxInstance, System.Windows.Forms.Control control)
		{
			checkBoxInstance.Controls.Add(control);
			control.Location = new System.Drawing.Point(0, 18);
		}

		/// <summary>
		/// Receives a CheckBox instance and sets the specific control and style.
		/// </summary>
		/// <param name="checkBoxInstance">CheckBox instance to be set.</param>
		/// <param name="control">The control assiciated with the CheckBox.</param>
		/// <param name="style">The style to be used to set the threeState property.</param>
		public static void SetCheckBox(System.Windows.Forms.CheckBox checkBoxInstance, System.Windows.Forms.Control control, int style)
		{
			checkBoxInstance.Controls.Add(control);
			control.Location = new System.Drawing.Point(0, 18);
			if (style == 2097152)
				checkBoxInstance.ThreeState = true;
		}

		/// <summary>
		/// Receives an instance of a RadioButton and sets its Text and Checked properties.
		/// </summary>
		/// <param name="RadioButtonInstance">The instance of RadioButton to be set.</param>
		/// <param name="text">The text to set Text property.</param>
		/// <param name="checkedStatus">Indicates if the RadioButton is checked or not.</param>
		public static void SetCheckbox(System.Windows.Forms.RadioButton radioButtonInstance, System.String text, bool checkedStatus)
		{
			radioButtonInstance.Text = text;
			radioButtonInstance.Checked = checkedStatus;
		}

		/// <summary>
		/// Receives an instance of a RadioButton and sets its Text and Checked properties and its containing panel
		/// </summary>
		/// <param name="CheckBoxInstance">The instance of RadioButton to be set</param>
		/// <param name="text">The text to set Text property</param>
		/// <param name="checkedStatus">Indicates if the RadioButton is checked or not</param>
		/// <param name="panel">The panel where the RadioButton will be placed</param>
		/// <remarks>If the panel is null the third param is ignored</remarks>
		public static void SetRadioButton(System.Windows.Forms.RadioButton radioButtonInstance, System.String text, bool checkedStatus, System.Windows.Forms.Panel panel)
		{
			radioButtonInstance.Text = text;
			radioButtonInstance.Checked = checkedStatus;
			if (panel != null)
				panel.Controls.Add(radioButtonInstance);
		}
		
		/// <summary>
		/// Creates a CheckBox with a specified text label and style.
		/// </summary>
		/// <param name="text">The text to be used as label.</param>
		/// <param name="style">The style to be used to set the threeState property.</param>
		/// <returns>A new CheckBox instance.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.String text, int style)
		{
			System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
			checkBox.Text = text;
			if (style == 2097152)
				checkBox.ThreeState = true;
			return checkBox;
		}
		
		/// <summary>
		/// Receives a CheckBox instance and sets the Text and ThreeState properties.
		/// </summary>
		/// <param name="checkBox">CheckBox instance to be set.</param>
		/// <param name="text">Value to be set to Text property.</param>
		/// <param name="style">The style to be used to set the threeState property.</param>
		public static void setCheckBox(System.Windows.Forms.CheckBox checkBox, System.String text, int style)
		{
			checkBox.Text = text;
			if (style == 2097152)
				checkBox.ThreeState = true;
		}
		
		/// <summary>
		/// Creates a CheckBox with a specified text label, image and style.
		/// </summary>
		/// <param name="text">The text to be used as label.</param>
		/// <param name="icon">The image to be used with the CheckBox.</param>
		/// <param name="style">The style to be used to set the threeState property.</param>
		/// <returns>A new CheckBox instance.</returns>
		public static System.Windows.Forms.CheckBox CreateCheckBox(System.String text, System.Drawing.Image icon, int style)
		{
			System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
			checkBox.Text = text;
			checkBox.Image = icon;
			if (style == 2097152)
				checkBox.ThreeState = true;
			return checkBox;
		}
		
		/// <summary>
		/// Receives a CheckBox instance and sets the Text, Image and ThreeState properties.
		/// </summary>
		/// <param name="checkBox">CheckBox instance to be set.</param>
		/// <param name="text">Value to be set to Text property.</param>
		/// <param name="icon">Value to be set to Image property.</param>
		/// <param name="style">The style to be used to set the threeState property.</param>
		public static void setCheckBox(System.Windows.Forms.CheckBox checkBox, System.String text, System.Drawing.Image icon, int style)
		{
			checkBox.Text = text;
			checkBox.Image = icon;
			if (style == 2097152)
				checkBox.ThreeState = true;
		}
		
		/// <summary>
		/// The SetIndeterminate method is used to sets or clear the CheckState of the CheckBox component.
		/// </summary>
		/// <param name="indeterminate">The value to the Indeterminate state. If true, the state is set; otherwise, it is cleared.</param>
		/// <param name="checkBox">The CheckBox component to be modified.</param>
		/// <returns></returns>
		public static System.Windows.Forms.CheckBox SetIndeterminate(bool indeterminate, System.Windows.Forms.CheckBox checkBox)
		{
			if (indeterminate)
				checkBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			else if (checkBox.Checked)
				checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			else
				checkBox.CheckState = System.Windows.Forms.CheckState.Unchecked;
			return checkBox;
		}
	}

	/*******************************/
	public class FormSupport
	{
		/// <summary>
		/// Creates a Form instance and sets the property Text to the specified parameter.
		/// </summary>
		/// <param name="Text">Value for the Form property Text</param>
		/// <returns>A new Form instance</returns>
		public static System.Windows.Forms.Form CreateForm(System.String text)
		{
			System.Windows.Forms.Form tempForm;
			tempForm = new System.Windows.Forms.Form();
			tempForm.Text = text;
			return tempForm;
		}

		/// <summary>
		/// Creates a Form instance and sets the property Text to the specified parameter.
		/// Adds the received control to the Form's Controls collection in the position 0.
		/// </summary>
		/// <param name="text">Value for the Form Text property.</param>
		/// <param name="control">Control to be added to the Controls collection.</param>
		/// <returns>A new Form instance</returns>
		public static System.Windows.Forms.Form CreateForm(System.String text, System.Windows.Forms.Control control )
		{
			System.Windows.Forms.Form tempForm;
			tempForm = new System.Windows.Forms.Form();
			tempForm.Text = text;
			tempForm.Controls.Add( control );	
			tempForm.Controls.SetChildIndex( control, 0 );
			return tempForm;
		}
		
		
		/// <summary>
		/// Creates a Form instance and sets the property Owner to the specified parameter.
		/// This also sets the FormBorderStyle and ShowInTaskbar properties.
		/// </summary>
		/// <param name="Owner">Value for the Form property Owner</param>
		/// <returns>A new Form instance</returns>
		public static System.Windows.Forms.Form CreateForm(System.Windows.Forms.Form owner)
		{
			System.Windows.Forms.Form tempForm;
			tempForm = new System.Windows.Forms.Form();
			tempForm.Owner = owner;
			tempForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			tempForm.ShowInTaskbar = false;
			return tempForm;
		}


		/// <summary>
		/// Creates a Form instance and sets the property Owner to the specified parameter.
		/// Sets the FormBorderStyle and ShowInTaskbar properties.
		/// Also add the received Control to the Form's Controls collection in the position 0.
		/// </summary>
		/// <param name="owner">Value for the Form property Owner</param>
		/// <param name="header">Control to be added to the Form's Controls collection</param>
		/// <returns>A new Form instance</returns>
		public static System.Windows.Forms.Form CreateForm(System.Windows.Forms.Form owner, System.Windows.Forms.Control header)
		{
			System.Windows.Forms.Form tempForm;
			tempForm = new System.Windows.Forms.Form();
			tempForm.Owner = owner;
			tempForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			tempForm.ShowInTaskbar = false;
			tempForm.Controls.Add( header );
			tempForm.Controls.SetChildIndex( header, 0 );
			return tempForm;
		}

		/// <summary>
		/// Creates a Form instance and sets the FormBorderStyle property.
		/// </summary>
		/// <param name="title">The title of the Form</param>
		/// <param name="resizable">Boolean value indicating if the Form is or not resizable</param>
		/// <returns>A new Form instance</returns>
		public static System.Windows.Forms.Form CreateForm(System.String title,bool resizable)
		{
			System.Windows.Forms.Form tempForm;
			tempForm = new System.Windows.Forms.Form();
			tempForm.Text = title;
			if(resizable)
				tempForm.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.Sizable;
			else
				tempForm.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedSingle;
			tempForm.TopLevel = false;
			tempForm.MaximizeBox = false;
			tempForm.MinimizeBox = false;
			return tempForm;
		}

		/// <summary>
		/// Creates a Form instance and sets the FormBorderStyle property.
		/// </summary>
		/// <param name="title">The title of the Form</param>
		/// <param name="resizable">Boolean value indicating if the Form is or not resizable</param>
		/// <param name="maximizable">Boolean value indicating if the Form displays the maximaze box</param>
		/// <returns>A new Form instance</returns>
		public static System.Windows.Forms.Form CreateForm(System.String title,bool resizable, bool maximizable)
		{
			System.Windows.Forms.Form tempForm;
			tempForm = new System.Windows.Forms.Form();
			tempForm.Text = title;
			if(resizable)
				tempForm.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.Sizable;
			else
				tempForm.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedSingle;
			tempForm.TopLevel = false;
			tempForm.MaximizeBox = maximizable;
			tempForm.MinimizeBox = false;
			return tempForm;
		}

		/// <summary>
		/// Creates a Form instance and sets the FormBorderStyle property.
		/// </summary>
		/// <param name="title">The title of the Form</param>
		/// <param name="resizable">Boolean value indicating if the Form is or not resizable</param>
		/// <param name="maximizable">Boolean value indicating if the Form displays the maximaze box</param>
		/// <param name="minimizable">Boolean value indicating if the Form displays the minimaze box</param>
		/// <returns>A new Form instance</returns>
		public static System.Windows.Forms.Form CreateForm(System.String title,bool resizable, bool maximizable, bool minimizable)
		{
			System.Windows.Forms.Form tempForm;
			tempForm = new System.Windows.Forms.Form();
			tempForm.Text = title;
			if(resizable)
				tempForm.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.Sizable;
			else
				tempForm.FormBorderStyle  = System.Windows.Forms.FormBorderStyle.FixedSingle;
			tempForm.TopLevel = false;
			tempForm.MaximizeBox = maximizable;
			tempForm.MinimizeBox = minimizable;
			return tempForm;
		}

		/// <summary>
		/// Receives a Form instance and sets the property Owner to the specified parameter.
		/// This also sets the FormBorderStyle and ShowInTaskbar properties.
		/// </summary>
		/// <param name="formInstance">Form instance to be set</param>
		/// <param name="Owner">Value for the Form property Owner</param>
		public static void SetForm(System.Windows.Forms.Form formInstance, System.Windows.Forms.Form owner)
		{
			formInstance.Owner = owner;
			formInstance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			formInstance.ShowInTaskbar = false;
		}

		/// <summary>
		/// Receives a Form instance, sets the Text property and adds a Control.
		/// The received Control is added in the position 0 of the Form's Controls collection.
		/// </summary>
		/// <param name="formInstance">Form instance to be set</param>
		/// <param name="text">Value to be set to the Text property.</param>
		/// <param name="control">Control to add to the Controls collection.</param>
		public static void SetForm(System.Windows.Forms.Form formInstance, System.String text, System.Windows.Forms.Control control )
		{
			formInstance.Text = text;
			formInstance.Controls.Add( control );	
			formInstance.Controls.SetChildIndex( control, 0 );
		}
		
		/// <summary>
		/// Receives a Form instance and sets the property Owner to the specified parameter.
		/// Sets the FormBorderStyle and ShowInTaskbar properties.
		/// Also adds the received Control to the Form's Controls collection in position 0.
		/// </summary>
		/// <param name="formInstance">Form instance to be set</param>
		/// <param name="owner">Value for the Form property Owner</param>
		/// <param name="header">The Control to be added to the Controls collection.</param>
		public static void SetForm(System.Windows.Forms.Form formInstance, System.Windows.Forms.Form owner, System.Windows.Forms.Control header)
		{
			formInstance.Owner = owner;
			formInstance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			formInstance.ShowInTaskbar = false;
			formInstance.Controls.Add( header );
			formInstance.Controls.SetChildIndex( header, 0 );
		}
	}
	/*******************************/
	/// <summary>
	/// Converts the specified collection to its string representation.
	/// </summary>
	/// <param name="c">The collection to convert to string.</param>
	/// <returns>A string representation of the specified collection.</returns>
	public static System.String CollectionToString(System.Collections.ICollection c)
	{
		System.Text.StringBuilder s = new System.Text.StringBuilder();
		
		if (c != null)
		{
		
			System.Collections.ArrayList l = new System.Collections.ArrayList(c);

			bool isDictionary = (c is System.Collections.BitArray || c is System.Collections.Hashtable || c is System.Collections.IDictionary || c is System.Collections.Specialized.NameValueCollection || (l.Count > 0 && l[0] is System.Collections.DictionaryEntry));
			for (int index = 0; index < l.Count; index++) 
			{
				if (l[index] == null)
					s.Append("null");
				else if (!isDictionary)
					s.Append(l[index]);
				else
				{
					isDictionary = true;
					if (c is System.Collections.Specialized.NameValueCollection)
						s.Append(((System.Collections.Specialized.NameValueCollection)c).GetKey (index));
					else
						s.Append(((System.Collections.DictionaryEntry) l[index]).Key);
					s.Append("=");
					if (c is System.Collections.Specialized.NameValueCollection)
						s.Append(((System.Collections.Specialized.NameValueCollection)c).GetValues(index)[0]);
					else
						s.Append(((System.Collections.DictionaryEntry) l[index]).Value);

				}
				if (index < l.Count - 1)
					s.Append(", ");
			}
			
			if(isDictionary)
			{
				if(c is System.Collections.ArrayList)
					isDictionary = false;
			}
			if (isDictionary)
			{
				s.Insert(0, "{");
				s.Append("}");
			}
			else 
			{
				s.Insert(0, "[");
				s.Append("]");
			}
		}
		else
			s.Insert(0, "null");
		return s.ToString();
	}

	/// <summary>
	/// Tests if the specified object is a collection and converts it to its string representation.
	/// </summary>
	/// <param name="obj">The object to convert to string</param>
	/// <returns>A string representation of the specified object.</returns>
	public static System.String CollectionToString(System.Object obj)
	{
		System.String result = "";

		if (obj != null)
		{
			if (obj is System.Collections.ICollection)
				result = CollectionToString((System.Collections.ICollection)obj);
			else
				result = obj.ToString();
		}
		else
			result = "null";

		return result;
	}
	/*******************************/


	/// <summary>
	/// EventArgs for support to the contrained properties.
	/// </summary>
    public class PropertyChangingEventArgs : System.ComponentModel.PropertyChangedEventArgs
	{   
		private System.Object oldValue;
		private System.Object newValue;

		/// <summary>
		/// Initializes a new PropertyChangingEventArgs instance.
		/// </summary>
		/// <param name="propertyName">Property name that fire the event.</param>
		public PropertyChangingEventArgs(System.String propertyName) : base(propertyName)
		{
		}

		/// <summary>
		/// Initializes a new PropertyChangingEventArgs instance.
		/// </summary>
		/// <param name="propertyName">Property name that fire the event.</param>
		/// <param name="oldVal">Property value to be replaced.</param>
		/// <param name="newVal">Property value to be set.</param>
		public PropertyChangingEventArgs(System.String propertyName, System.Object oldVal, System.Object newVal) : base(propertyName)
		{
			this.oldValue = oldVal;
			this.newValue = newVal;
		}

		/// <summary>
		/// Gets or sets the old value of the event.
		/// </summary>
		public System.Object OldValue
		{
			get
			{
				return this.oldValue;
			}
			set
			{
				this.oldValue = value;
			}
		}
	        
		/// <summary>
		/// Gets or sets the new value of the event.
		/// </summary>
		public System.Object NewValue
		{
			get
			{
				return this.newValue;
			}
			set
			{
				this.newValue = value;
			}
		}
	}


	/*******************************/
	public class TransactionManager
	{
		public static ConnectionHashTable manager = new ConnectionHashTable();

		public class ConnectionHashTable : System.Collections.Hashtable
		{
			public System.Data.OleDb.OleDbCommand CreateStatement(System.Data.OleDb.OleDbConnection connection)
			{
				System.Data.OleDb.OleDbCommand command = connection.CreateCommand();
				System.Data.OleDb.OleDbTransaction transaction;
				if (this[connection] != null)
				{
					ConnectionProperties Properties = ((ConnectionProperties)this[connection]);
					transaction = Properties.Transaction;
					command.Transaction = transaction;
					command.CommandTimeout = 0;
				}
				else
				{
					ConnectionProperties TempProp = new ConnectionProperties();
					TempProp.AutoCommit = true;
					TempProp.TransactionLevel = 0;
					command.Transaction = TempProp.Transaction;
					command.CommandTimeout = 0;
					Add(connection, TempProp);
				}
				return command;
			}

			public void Commit(System.Data.OleDb.OleDbConnection connection)
			{
				if (this[connection] != null && !((ConnectionProperties)this[connection]).AutoCommit)
				{
					ConnectionProperties Properties = ((ConnectionProperties)this[connection]);
					System.Data.OleDb.OleDbTransaction transaction = Properties.Transaction;
					transaction.Commit();
					if (Properties.TransactionLevel == 0)
						Properties.Transaction = connection.BeginTransaction();
					else
						Properties.Transaction = connection.BeginTransaction(Properties.TransactionLevel);
				}
			}

			public void RollBack(System.Data.OleDb.OleDbConnection connection)
			{
				if (this[connection] != null && !((ConnectionProperties)this[connection]).AutoCommit)
				{
					ConnectionProperties Properties = ((ConnectionProperties) this[connection]);
					System.Data.OleDb.OleDbTransaction transaction = Properties.Transaction;
					transaction.Rollback();
					if (Properties.TransactionLevel == 0)
						Properties.Transaction = connection.BeginTransaction();
					else
						Properties.Transaction = connection.BeginTransaction(Properties.TransactionLevel);					
				}
			}

			public void SetAutoCommit(System.Data.OleDb.OleDbConnection connection, bool boolean)
			{
				if (this[connection] != null)
				{
					ConnectionProperties Properties = ((ConnectionProperties)this[connection]);
					if(Properties.AutoCommit != boolean)
					{
						Properties.AutoCommit = boolean;
						if (!boolean)
						{						
							if (Properties.TransactionLevel == 0)
								Properties.Transaction = connection.BeginTransaction();
							else
								Properties.Transaction = connection.BeginTransaction(Properties.TransactionLevel);
						}
						else
						{
							System.Data.OleDb.OleDbTransaction transaction =  Properties.Transaction;
							if (transaction != null)
							{
								transaction.Commit();
							}
						}
					}
				}
				else
				{
					ConnectionProperties TempProp = new ConnectionProperties();
					TempProp.AutoCommit = boolean;
					TempProp.TransactionLevel = 0;
					if (!boolean)
						TempProp.Transaction  = connection.BeginTransaction();
					Add(connection, TempProp);
				}
			}

			public System.Data.OleDb.OleDbCommand PrepareStatement(System.Data.OleDb.OleDbConnection connection, System.String sql)
			{
				System.Data.OleDb.OleDbCommand command = this.CreateStatement(connection);
				command.CommandText = sql;
				command.CommandTimeout = 0;
				return command;
			}

			public System.Data.OleDb.OleDbCommand PrepareCall(System.Data.OleDb.OleDbConnection connection, System.String sql)
			{
				System.Data.OleDb.OleDbCommand command = this.CreateStatement(connection);
				command.CommandText = sql;
				command.CommandTimeout = 0;
				return command;
			}

			public void SetTransactionIsolation(System.Data.OleDb.OleDbConnection connection, int level)
			{
				ConnectionProperties Properties;
				if(level == (int)System.Data.IsolationLevel.ReadCommitted)
					SetAutoCommit(connection, false);
				else
					if(level == (int)System.Data.IsolationLevel.ReadUncommitted)
					SetAutoCommit(connection, false);
				else
					if(level == (int)System.Data.IsolationLevel.RepeatableRead)
					SetAutoCommit(connection, false);
				else
					if(level == (int)System.Data.IsolationLevel.Serializable)
					SetAutoCommit(connection, false);

				if (this[connection] != null)
				{
					Properties =((ConnectionProperties)this[connection]);					
					Properties.TransactionLevel = (System.Data.IsolationLevel)level;
				}
				else
				{	
					Properties = new ConnectionProperties();
					Properties.AutoCommit = true;    					    
					Properties.TransactionLevel = (System.Data.IsolationLevel)level;	
					Add(connection, Properties);
				}
			}

			public int GetTransactionIsolation(System.Data.OleDb.OleDbConnection connection)
			{
				if (this[connection] != null)
				{
					ConnectionProperties Properties = ((ConnectionProperties)this[connection]);
					if (Properties.TransactionLevel != 0)
						return (int)Properties.TransactionLevel;
					else
						return 2;
				}
				else
					return 2;
			}

			public bool GetAutoCommit(System.Data.OleDb.OleDbConnection connection)
			{
				if (this[connection] != null)
					return ((ConnectionProperties)this[connection]).AutoCommit;
				else
					return true;
			}

			/// <summary>
			/// Sets the value of a parameter using any permitted object.  The given argument object will be converted to the
			/// corresponding SQL type before being sent to the database.
			/// </summary>
			/// <param name="command">Command object to be changed.</param>
			/// <param name="parameterIndex">One-based index of the parameter to be set.</param>
			/// <param name="parameter">The object containing the input parameter value.</param>
			public void SetValue(System.Data.OleDb.OleDbCommand command, int parameterIndex, System.Object parameter)
			{
				if (command.Parameters.Count < parameterIndex)
					command.Parameters.Add(command.CreateParameter());
				command.Parameters[parameterIndex - 1].Value = parameter;
			}

			/// <summary>
			/// Sets a parameter to SQL NULL.
			/// </summary>
			/// <param name="command">Command object to be changed.</param>
			/// <param name="parameterIndex">One-based index of the parameter to be set.</param>
			/// <param name="targetSqlType">The SQL type to be sent to the database.</param>
			public void SetNull(System.Data.OleDb.OleDbCommand command, int parameterIndex, int sqlType)
			{
				if (command.Parameters.Count < parameterIndex)
					command.Parameters.Add(command.CreateParameter());
				command.Parameters[parameterIndex - 1].Value = System.Convert.DBNull;
				command.Parameters[parameterIndex - 1].OleDbType = (System.Data.OleDb.OleDbType)sqlType;
			}

			/// <summary>
			/// Sets the value of a parameter using an object.  The given argument object will be converted to the
			/// corresponding SQL type before being sent to the database.
			/// </summary>
			/// <param name="command">Command object to be changed.</param>
			/// <param name="parameterIndex">One-based index of the parameter to be set.</param>
			/// <param name="parameter">The object containing the input parameter value.</param>
			/// <param name="targetSqlType">The SQL type to be sent to the database.</param>
			public void SetObject(System.Data.OleDb.OleDbCommand command, int parameterIndex, System.Object parameter, int targetSqlType)
			{
				if (command.Parameters.Count < parameterIndex)
					command.Parameters.Add(command.CreateParameter());
				command.Parameters[parameterIndex - 1].Value = parameter;
				command.Parameters[parameterIndex - 1].OleDbType = (System.Data.OleDb.OleDbType)targetSqlType;
			}

			/// <summary>
			/// Sets the value of a parameter using an object.  The given argument object will be converted to the
			/// corresponding SQL type before being sent to the database.
			/// </summary>
			/// <param name="command">Command object to be changed.</param>
			/// <param name="parameterIndex">One-based index of the parameter to be set.</param>
			/// <param name="parameter">The object containing the input parameter value.</param>
			public void SetObject(System.Data.OleDb.OleDbCommand command, int parameterIndex, System.Object parameter)
			{
				if (command.Parameters.Count < parameterIndex)
					command.Parameters.Add(command.CreateParameter());
				command.Parameters[parameterIndex - 1].Value = parameter;
			}

			/// <summary>
			/// This method is for such prepared statements verify if the Conection is autoCommit for assing the transaction to the command.
			/// </summary>
			/// <param name="command">The command to be tested.</param>
			/// <returns>The number of rows afected.</returns>
			public int ExecuteUpdate(System.Data.OleDb.OleDbCommand command)
			{
				if (!(((ConnectionProperties)this[command.Connection]).AutoCommit))
				{
					command.Transaction = ((ConnectionProperties)this[command.Connection]).Transaction;
					return command.ExecuteNonQuery();
				}
				else
					return command.ExecuteNonQuery();
			}
			
			/// <summary>
			/// This method Closes the connection, and if the property of autocommit is true make the comit operation
			/// </summary>
			/// <param name="command"> The command to be closed</param>		
			public void Close(System.Data.OleDb.OleDbConnection Connection)
			{

				if ((this[Connection] != null)&&!(((ConnectionProperties)this[Connection]).AutoCommit))
				{					
					Commit(Connection);	
				}
				Connection.Close();
			}

			class ConnectionProperties
			{
				public bool AutoCommit;
				public System.Data.OleDb.OleDbTransaction Transaction;
				public System.Data.IsolationLevel TransactionLevel;
			}
		}
	}


	/*******************************/
/// <summary>
/// Provides support for DateFormat
/// </summary>
public class DateTimeFormatManager
{
	static public DateTimeFormatHashTable manager = new DateTimeFormatHashTable();

	/// <summary>
	/// Hashtable class to provide functionality for dateformat properties
	/// </summary>
	public class DateTimeFormatHashTable :System.Collections.Hashtable 
	{
		/// <summary>
		/// Sets the format for datetime.
		/// </summary>
		/// <param name="format">DateTimeFormat instance to set the pattern</param>
		/// <param name="newPattern">A string with the pattern format</param>
		public void SetDateFormatPattern(System.Globalization.DateTimeFormatInfo format, System.String newPattern)
		{
			if (this[format] != null)
				((DateTimeFormatProperties) this[format]).DateFormatPattern = newPattern;
			else
			{
				DateTimeFormatProperties tempProps = new DateTimeFormatProperties();
				tempProps.DateFormatPattern  = newPattern;
				Add(format, tempProps);
			}
		}

		/// <summary>
		/// Gets the current format pattern of the DateTimeFormat instance
		/// </summary>
		/// <param name="format">The DateTimeFormat instance which the value will be obtained</param>
		/// <returns>The string representing the current datetimeformat pattern</returns>
		public System.String GetDateFormatPattern(System.Globalization.DateTimeFormatInfo format)
		{
			if (this[format] == null)
				return "d-MMM-yy";
			else
				return ((DateTimeFormatProperties) this[format]).DateFormatPattern;
		}
		
		/// <summary>
		/// Sets the datetimeformat pattern to the giving format
		/// </summary>
		/// <param name="format">The datetimeformat instance to set</param>
		/// <param name="newPattern">The new datetimeformat pattern</param>
		public void SetTimeFormatPattern(System.Globalization.DateTimeFormatInfo format, System.String newPattern)
		{
			if (this[format] != null)
				((DateTimeFormatProperties) this[format]).TimeFormatPattern = newPattern;
			else
			{
				DateTimeFormatProperties tempProps = new DateTimeFormatProperties();
				tempProps.TimeFormatPattern  = newPattern;
				Add(format, tempProps);
			}
		}

		/// <summary>
		/// Gets the current format pattern of the DateTimeFormat instance
		/// </summary>
		/// <param name="format">The DateTimeFormat instance which the value will be obtained</param>
		/// <returns>The string representing the current datetimeformat pattern</returns>
		public System.String GetTimeFormatPattern(System.Globalization.DateTimeFormatInfo format)
		{
			if (this[format] == null)
				return "h:mm:ss tt";
			else
				return ((DateTimeFormatProperties) this[format]).TimeFormatPattern;
		}

		/// <summary>
		/// Internal class to provides the DateFormat and TimeFormat pattern properties on .NET
		/// </summary>
		class DateTimeFormatProperties
		{
			public System.String DateFormatPattern = "d-MMM-yy";
			public System.String TimeFormatPattern = "h:mm:ss tt";
		}
	}	
}
	/*******************************/
	/// <summary>
	/// Gets the DateTimeFormat instance and date instance to obtain the date with the format passed
	/// </summary>
	/// <param name="format">The DateTimeFormat to obtain the time and date pattern</param>
	/// <param name="date">The date instance used to get the date</param>
	/// <returns>A string representing the date with the time and date patterns</returns>
	public static System.String FormatDateTime(System.Globalization.DateTimeFormatInfo format, System.DateTime date)
	{
		System.String timePattern = DateTimeFormatManager.manager.GetTimeFormatPattern(format);
		System.String datePattern = DateTimeFormatManager.manager.GetDateFormatPattern(format);
		return date.ToString(datePattern + " " + timePattern, format);            
	}

	/*******************************/
	/// <summary>
	/// Gets the DateTimeFormat instance using the culture passed as parameter and sets the pattern to the time or date depending of the value
	/// </summary>
	/// <param name="dateStyle">The desired date style.</param>
	/// <param name="timeStyle">The desired time style</param>
	/// <param name="culture">The CultureInfo instance used to obtain the DateTimeFormat</param>
	/// <returns>The DateTimeFomatInfo of the culture and with the desired date or time style</returns>
	public static System.Globalization.DateTimeFormatInfo GetDateTimeFormatInstance(int dateStyle, int timeStyle, System.Globalization.CultureInfo culture)
	{
		const int NULLPATERN = -1;
		const int PATERN_1 = 0;
		const int PATERN_2 = 1;
		const int PATERN_3 = 2;
		const int PATERN_4 = 3;
		System.Globalization.DateTimeFormatInfo format = culture.DateTimeFormat;
		 
		switch (timeStyle)
		{
			case NULLPATERN:
				DateTimeFormatManager.manager.SetTimeFormatPattern(format, "");
				break;

			case PATERN_1:
				DateTimeFormatManager.manager.SetTimeFormatPattern(format, format.LongTimePattern);
				break;

			case PATERN_2:
				DateTimeFormatManager.manager.SetTimeFormatPattern(format, "h:mm:ss tt zzz");
				break;

			case PATERN_3:
				DateTimeFormatManager.manager.SetTimeFormatPattern(format, "h:mm:ss tt");
				break;

			case PATERN_4:
				DateTimeFormatManager.manager.SetTimeFormatPattern(format, format.ShortTimePattern);
				break;
		}

		switch (dateStyle)
		{
			case NULLPATERN:
				DateTimeFormatManager.manager.SetDateFormatPattern(format, "");
				break;

			case PATERN_1:
				DateTimeFormatManager.manager.SetDateFormatPattern(format, format.LongDatePattern);
				break;

			case PATERN_2:
				DateTimeFormatManager.manager.SetDateFormatPattern(format, "MMMM d, yyy" );
				break;

			case PATERN_3:
				DateTimeFormatManager.manager.SetDateFormatPattern(format, "MMM d, yyy"  );
				break;

			case PATERN_4:
				DateTimeFormatManager.manager.SetDateFormatPattern(format, format.ShortDatePattern);
				break;
		}

		return format;
	}

	/*******************************/
	/// <summary>
	/// SupportClass for the Stack class.
	/// </summary>
	public class StackSupport
	{
		/// <summary>
		/// Removes the element at the top of the stack and returns it.
		/// </summary>
		/// <param name="stack">The stack where the element at the top will be returned and removed.</param>
		/// <returns>The element at the top of the stack.</returns>
		public static System.Object Pop(System.Collections.ArrayList stack)
		{
			System.Object obj = stack[stack.Count - 1];
			stack.RemoveAt(stack.Count - 1);

			return obj;
		}
	}


	/*******************************/
	/// <summary>
	/// Manager for the connection with the database
	/// </summary>
	public class OleDBSchema 
	{
		private System.Data.DataTable schemaData = null;
		private System.Data.OleDb.OleDbConnection Connection;
		private System.Data.ConnectionState ConnectionState;
 
		/// <summary>
		/// Constructs a new member with the provided connection
		/// </summary>
		/// <param name="Connection">The connection to assign to the new member</param>
		public OleDBSchema(System.Data.OleDb.OleDbConnection Connection)
		{
			this.Connection = Connection;
		}

		/// <summary>
		/// Gets the Driver name of the connection
		/// </summary>
		public System.String DriverName
		{
			get
			{
				System.String result = "";
				OpenConnection();
				result = this.Connection.Provider;
				CloseConnection();
				return result;
			}
		}
 
		/// <summary>
		/// Opens the connection
		/// </summary>
		private void OpenConnection()
		{
			this.ConnectionState = Connection.State;
			this.Connection.Close();
			this.Connection.Open();
			schemaData = null;
		}
 
		/// <summary>
		/// Closes the connection
		/// </summary>
		private void CloseConnection()
		{
			if (this.ConnectionState == System.Data.ConnectionState.Open)
				this.Connection.Close();
		}
 
		/// <summary>
		/// Gets the info of the row
		/// </summary>
		/// <param name="filter">Filter to apply to the row</param>
		/// <param name="RowName">The row from which to obtain the filter</param>
		/// <returns>A new String with the info from the row</returns>
		private System.String GetMaxInfo(System.String filter, System.String RowName)
		{
			System.String result = "";
			schemaData = null;
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.DbInfoLiterals,null);
			foreach(System.Data.DataRow DataRow in schemaData.Rows )
			{
				if (DataRow["LiteralName"].ToString() == filter)
				{
					result = DataRow[RowName].ToString();
					break;
				}
			}
			CloseConnection();
			return result;
		}
 
		/// <summary>
		/// Gets the catalogs from the database to which it is connected
		/// </summary>
		public System.Data.DataTable Catalogs
		{
			get
			{
				OpenConnection();
				schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Catalogs,null);
				CloseConnection();
				return schemaData;
			}
		}
            
		/// <summary>
		/// Gets the OleDBConnection for the current member
		/// </summary>
		/// <returns></returns>
		public System.Data.OleDb.OleDbConnection GetConnection()
		{
			return this.Connection;
		}
 
		/// <summary>
		/// Gets a description of the stored procedures available
		/// </summary>
		/// <param name="catalog">The catalog from which to obtain the procedures</param>
		/// <param name="schemaPattern">Schema pattern, retrieves those without the schema</param>
		/// <param name="procedureNamePattern">a procedure name pattern</param>
		/// <returns>each row but withing a procedure description</returns>
		public System.Data.DataTable GetProcedures(System.String catalog, System.String schemaPattern, System.String procedureNamePattern)
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Procedures,new System.Object[]{catalog, schemaPattern, procedureNamePattern, null});
			CloseConnection();
			return schemaData;
		}
 
		/// <summary>
		/// Gets a collection of the descriptions of the stored procedures parameters and result columns
		/// </summary>
		/// <param name="catalog">Retrieves those without a catalog</param>
		/// <param name="schemaPattern">Schema pattern, retrieves those without the schema</param>
		/// <param name="procedureNamePattern">a procedure name pattern</param>
		/// <param name="columnNamePattern">a columng name patterm</param>
		/// <returns>Each row but withing a procedure description or column</returns>
		public System.Data.DataTable GetProcedureColumns(System.String catalog, System.String schemaPattern, System.String procedureNamePattern, System.String columnNamePattern )
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Procedure_Parameters,new System.Object[]{catalog, schemaPattern, procedureNamePattern, columnNamePattern});
			CloseConnection();
			return schemaData;
		}
 
		/// <summary>
		/// Gets a description of the tables available for the catalog
		/// </summary>
		/// <param name="catalog">A catalog, retrieves those without a catalog</param>
		/// <param name="schemaPattern">Schema pattern, retrieves those without the schema</param>
		/// <param name="tableNamePattern">A table name pattern</param>
		/// <param name="types">a list of table types to include</param>
		/// <returns>Each row</returns>
		public System.Data.DataTable GetTables(System.String catalog, System.String schemaPattern, System.String tableNamePattern, System.String[] types)
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables,new System.Object[]{catalog, schemaPattern, tableNamePattern, types[0]});
			if(types != null)
			{
				for(int i=1;i<types.Length;i++)
				{
					System.Data.DataTable temp_Table = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables,new System.Object[]{catalog, schemaPattern, tableNamePattern, types[i]});
					for(int j = 0;j<temp_Table.Rows.Count;j++)
					{
						schemaData.ImportRow(temp_Table.Rows[j]);
					}
				}						
			}
			CloseConnection();
			return schemaData;
		}
 
		/// <summary>
		/// Gets a description of the table rights
		/// </summary>
		/// <param name="catalog">A catalog, retrieves those without a catalog</param>
		/// <param name="schemaPattern">Schema pattern, retrieves those without the schema</param>
		/// <param name="tableNamePattern">A table name pattern</param>
		/// <returns>A description of the table rights</returns>
		public System.Data.DataTable GetTablePrivileges(System.String catalog, System.String schemaPattern, System.String tableNamePattern)
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Table_Privileges,new System.Object[]{catalog, schemaPattern, tableNamePattern});
			CloseConnection();
			return schemaData;
		}
 
		/// <summary>
		/// Gets the table types available
		/// </summary>
		public System.Data.DataTable TableTypes
		{
			get
			{
				OpenConnection();
				schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables,null);
				System.Collections.ArrayList tableTypes = new System.Collections.ArrayList(schemaData.Rows.Count);
	 
				System.String tableType="";
				foreach(System.Data.DataRow DataRow in schemaData.Rows)
				{
					tableType = DataRow[schemaData.Columns["TABLE_TYPE"]].ToString();
					if (!(tableTypes.Contains(tableType)))
					{
						tableTypes.Add(tableType);
					}
				}
				schemaData = new System.Data.DataTable();
				schemaData.Columns.Add("TABLE_TYPE");
				for (int index=0; index < tableTypes.Count; index++)
				{
					schemaData.Rows.Add(new System.Object[]{tableTypes[index]});
				}
				CloseConnection();
				return schemaData;
			}
		}
 
		/// <summary>
		/// Gets a description of the table columns available
		/// </summary>
		/// <param name="catalog">A catalog, retrieves those without a catalog</param>
		/// <param name="schemaPattern">Schema pattern, retrieves those without the schema</param>
		/// <param name="tableNamePattern">A table name pattern</param>
		/// <param name="columnNamePattern">a columng name patterm</param>
		/// <returns>A description of the table columns available</returns>
		public System.Data.DataTable GetColumns(System.String catalog, System.String schemaPattern, System.String tableNamePattern, System.String columnNamePattern)
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns,new System.Object[]{catalog, schemaPattern, tableNamePattern, columnNamePattern});
			CloseConnection();
			return schemaData;
		}
 
		/// <summary>
		/// Gets a description of the primary keys available
		/// </summary>
		/// <param name="catalog">A catalog, retrieves those without a catalog</param>
		/// <param name="schema">Schema name, retrieves those without the schema</param>
		/// <param name="table">A table name</param>
		/// <returns>A description of the primary keys available</returns>
		public System.Data.DataTable GetPrimaryKeys(System.String catalog, System.String schema, System.String table)
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Primary_Keys,new System.Object[]{catalog, schema, table});
			CloseConnection();
			return schemaData;
		}
 
		/// <summary>
		/// Gets a description of the foreign keys available
		/// </summary>
		/// <param name="catalog">A catalog, retrieves those without a catalog</param>
		/// <param name="schema">Schema name, retrieves those without the schema</param>
		/// <param name="table">A table name</param>
		/// <returns>A description of the foreign keys available</returns>
		public System.Data.DataTable GetForeignKeys(System.String catalog, System.String schema, System.String table)
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Foreign_Keys,new System.Object[]{catalog, schema, table});
			CloseConnection();
			return schemaData;
		}

		/// <summary>
		/// Gets a description of the access rights for	a table columns
		/// </summary>
		/// <param name="catalog">A catalog, retrieves those without a catalog</param>
		/// <param name="schema">Schema name, retrieves those without the schema</param>
		/// <param name="table">A table name</param>
		/// <param name="columnNamePattern">A column name patter</param>
		/// <returns>A description of the access rights for	a table columns</returns>
		public System.Data.DataTable GetColumnPrivileges(System.String catalog, System.String schema, System.String table, System.String columnNamePattern)
		{
			OpenConnection();
			schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Column_Privileges,new System.Object[]{catalog, schema, table, columnNamePattern});
			CloseConnection();
			return schemaData;
		}

		/// <summary>
		/// Gets the provider version
		/// </summary>
		public System.String ProviderVersion
		{
			get
			{
				System.String result = "";
				OpenConnection();
				result = this.Connection.ServerVersion;
				CloseConnection();
				return result;
			}	
		}

		/// <summary>
		/// Gets the default transaction isolation integer value
		/// </summary>
		public int DefaultTransactionIsolation
		{
			get
			{
				int result = -1;
				OpenConnection();
				System.Data.OleDb.OleDbTransaction Transaction = this.Connection.BeginTransaction();
				result = (int)Transaction.IsolationLevel;
				CloseConnection();
				return result;
			}
		}

		/// <summary>
		/// Gets the schemata for the member
		/// </summary>
		public System.Data.DataTable Schemata
		{
			get
			{
				OpenConnection();
				schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Schemata,null);
				CloseConnection();
				return schemaData;
			}
		}

		/// <summary>
		/// Gets the provider types for the member
		/// </summary>
		public System.Data.DataTable ProviderTypes
		{	
			get
			{
				OpenConnection();
				schemaData = this.Connection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Provider_Types,null);
				CloseConnection();
				return schemaData;
			}
		}

		/// <summary>
		/// Gets the catalog separator
		/// </summary>
		public System.String CatalogSeparator
		{
			get{return GetMaxInfo("Catalog_Separator","LiteralValue");}
		}

		/// <summary>
		/// Gets the maximum binary length permited
		/// </summary>
		public int MaxBinaryLiteralLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Binary_Literal","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len)*4);
			}
		}
	
		/// <summary>
		/// Gets the maximum catalog name length permited
		/// </summary>
		public int MaxCatalogNameLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Catalog_Name","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len));
			}
		}

		/// <summary>
		/// Gets the maximum character literal length permited
		/// </summary>
		public int MaxCharLiteralLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Char_Literal","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len)*4);
			}
		}

		/// <summary>
		/// Gets the maximum column name length
		/// </summary>
		public int MaxColumnNameLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Column_Name","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len));
			}
		}

		/// <summary>
		/// Gets the maximum cursor name length
		/// </summary>
		public int MaxCursorNameLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Cursor_Name","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len));
			}
		}

		/// <summary>
		/// Gets the maximum procedure name length
		/// </summary>
		public int MaxProcedureNameLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Procedure_Name","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len));
			}
		}

		/// <summary>
		/// Gets the maximum schema name length
		/// </summary>
		public int MaxSchemaNameLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Schema_Name","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len));
			}
		}

		/// <summary>
		/// Gets the maximum table name length
		/// </summary>
		public int MaxTableNameLength
		{
			get
			{ 
				System.String len = GetMaxInfo("Table_Name","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return (System.Convert.ToInt32(len));
			}
		}

		/// <summary>
		/// Gets the maximum user name length
		/// </summary>
		public int MaxUserNameLength
		{
			get
			{ 
				System.String len = GetMaxInfo("User_Name","Maxlen"); 
				if (len.Equals(""))
					return 0;
				else 
					return System.Convert.ToInt32(len);
			}
		}
	}
	/*******************************/
	/// <summary>
	/// Copies an array of chars obtained from a String into a specified array of chars
	/// </summary>
	/// <param name="sourceString">The String to get the chars from</param>
	/// <param name="sourceStart">Position of the String to start getting the chars</param>
	/// <param name="sourceEnd">Position of the String to end getting the chars</param>
	/// <param name="destinationArray">Array to return the chars</param>
	/// <param name="destinationStart">Position of the destination array of chars to start storing the chars</param>
	/// <returns>An array of chars</returns>
	public static void GetCharsFromString(System.String sourceString, int sourceStart, int sourceEnd, char[] destinationArray, int destinationStart)
	{	
		int sourceCounter;
		int destinationCounter;
		sourceCounter = sourceStart;
		destinationCounter = destinationStart;
		while (sourceCounter < sourceEnd)
		{
			destinationArray[destinationCounter] = (char) sourceString[sourceCounter];
			sourceCounter++;
			destinationCounter++;
		}
	}

	/*******************************/
	/// <summary>
	/// Sets the capacity for the specified ArrayList
	/// </summary>
	/// <param name="vector">The ArrayList which capacity will be set</param>
	/// <param name="newCapacity">The new capacity value</param>
	public static void SetCapacity(System.Collections.ArrayList vector, int newCapacity)
	{
		if (newCapacity > vector.Count)
			vector.AddRange(new Array[newCapacity-vector.Count]);
		else if (newCapacity < vector.Count)
			vector.RemoveRange(newCapacity, vector.Count - newCapacity);
		vector.Capacity = newCapacity;
	}



	/*******************************/
	/// <summary>
	/// Verifies if a value exist in a NameValueCollection.
	/// </summary>
	/// <param name="collection">The NameValueCollection to look in.</param>
	/// <param name="key">The key to look for.</param>
	/// <returns>If key exist in the NameValueCollection returns true, otherwise false.</returns>
	public static  bool ContainsKeySupport(System.Collections.Specialized.NameValueCollection collection, string key)
	{
		bool exists = false;
		if( collection != null)
		{
			string [] keys = collection.AllKeys;
			exists = !(System.Array.IndexOf(keys,key) == -1);
		}
		return exists;
	}
	/*******************************/
	/// <summary>
	/// Provides functionality not found in .NET map-related interfaces.
	/// </summary>
	public class MapSupport
	{
		/// <summary>
		/// Determines whether the SortedList contains a specific value.
		/// </summary>
		/// <param name="d">The dictionary to check for the value.</param>
		/// <param name="obj">The object to locate in the SortedList.</param>
		/// <returns>Returns true if the value is contained in the SortedList, false otherwise.</returns>
		public static bool ContainsValue(System.Collections.IDictionary d, System.Object obj)
		{
			bool contained = false;
			System.Type type = d.GetType();

			//Classes that implement the SortedList class
			if (type == System.Type.GetType("System.Collections.SortedList"))
			{
				contained = (bool) ((System.Collections.SortedList) d).ContainsValue(obj);
			}
			//Classes that implement the Hashtable class
			else if (type == System.Type.GetType("System.Collections.Hashtable"))
			{
				contained = (bool) ((System.Collections.Hashtable) d).ContainsValue(obj);
			}
			else 
			{
				//Reflection. Invoke "containsValue" method for proprietary classes
				try
				{
					System.Reflection.MethodInfo method = type.GetMethod("containsValue");
					contained = (bool) method.Invoke(d, new Object[] {obj});
				}
				catch (System.Reflection.TargetInvocationException e)
				{
					throw e;
				}
				catch (System.Exception e)
				{
					throw e;
				}
			}

			return contained;
		}
		
		
		/// <summary>
		/// Determines whether the NameValueCollection contains a specific value.
		/// </summary>
		/// <param name="d">The dictionary to check for the value.</param>
		/// <param name="obj">The object to locate in the SortedList.</param>
		/// <returns>Returns true if the value is contained in the NameValueCollection, false otherwise.</returns>
		public static bool ContainsValue(System.Collections.Specialized.NameValueCollection d, System.Object obj)
		{
			bool contained = false;
			System.Type type = d.GetType();

			for (int i = 0; i < d.Count && !contained ; i++)
			{
				System.String [] values = d.GetValues(i);
				if (values != null) 
				{
					foreach (System.String val in values)
					{
						if (val.Equals(obj))
						{
							contained = true;
							break;
						}
					}
				}
			}
			return contained;
		}		

		/// <summary>
		/// Copies all the elements of d to target.
		/// </summary>
		/// <param name="target">Collection where d elements will be copied.</param>
		/// <param name="d">Elements to copy to the target collection.</param>
		public static void PutAll(System.Collections.IDictionary target, System.Collections.IDictionary d)
		{
			if(d != null)
			{
					System.Collections.ArrayList keys = new System.Collections.ArrayList(d.Keys);
				System.Collections.ArrayList values = new System.Collections.ArrayList(d.Values);

				for (int i=0; i < keys.Count; i++)
					target[keys[i]] = values[i];
			}
		}
		
		/// <summary>
		/// Returns a portion of the list whose keys are less than the limit object parameter.
		/// </summary>
		/// <param name="l">The list where the portion will be extracted.</param>
		/// <param name="limit">The end element of the portion to extract.</param>
		/// <returns>The portion of the collection whose elements are less than the limit object parameter.</returns>
		public static System.Collections.SortedList HeadMap(System.Collections.SortedList l, System.Object limit)
		{
			System.Collections.Comparer comparer = System.Collections.Comparer.Default;
			System.Collections.SortedList newList = new System.Collections.SortedList();

			for (int i=0; i < l.Count; i++)
			{
				if (comparer.Compare(l.GetKey(i), limit) >= 0)
					break;

				newList.Add(l.GetKey(i), l[l.GetKey(i)]);
			}

			return newList;
		}

		/// <summary>
		/// Returns a portion of the list whose keys are greater that the lowerLimit parameter less than the upperLimit parameter.
		/// </summary>
		/// <param name="l">The list where the portion will be extracted.</param>
		/// <param name="limit">The start element of the portion to extract.</param>
		/// <param name="limit">The end element of the portion to extract.</param>
		/// <returns>The portion of the collection.</returns>
		public static System.Collections.SortedList SubMap(System.Collections.SortedList list, System.Object lowerLimit, System.Object upperLimit)
		{
			System.Collections.Comparer comparer = System.Collections.Comparer.Default;
			System.Collections.SortedList newList = new System.Collections.SortedList();

			if (list != null)
			{
				if ((list.Count > 0)&&(!(lowerLimit.Equals(upperLimit))))
				{
					int index = 0;
					while (comparer.Compare(list.GetKey(index), lowerLimit) < 0)
						index++;

					for (; index < list.Count; index++)
					{
						if (comparer.Compare(list.GetKey(index), upperLimit) >= 0)
							break;

						newList.Add(list.GetKey(index), list[list.GetKey(index)]);
					}
				}
			}

			return newList;
		}

		/// <summary>
		/// Returns a portion of the list whose keys are greater than the limit object parameter.
		/// </summary>
		/// <param name="l">The list where the portion will be extracted.</param>
		/// <param name="limit">The start element of the portion to extract.</param>
		/// <returns>The portion of the collection whose elements are greater than the limit object parameter.</returns>
		public static System.Collections.SortedList TailMap(System.Collections.SortedList list, System.Object limit)
		{
			System.Collections.Comparer comparer = System.Collections.Comparer.Default;
			System.Collections.SortedList newList = new System.Collections.SortedList();

			if (list != null)
			{
				if (list.Count > 0)
				{
					int index = 0;
					while (comparer.Compare(list.GetKey(index), limit) < 0)
						index++;

					for (; index < list.Count; index++)
						newList.Add(list.GetKey(index), list[list.GetKey(index)]);
				}
			}

			return newList;
		}
	}


	/*******************************/
	/// <summary>
	/// SupportClass for MSMQ.
	/// </summary>
	public class MessagingManager
	{
		/// <summary>
		/// Creates a MessageQueue object for receiving messages from the specified queue.
		/// </summary>
		/// <param name="queue">The queue path where to get the messages from</param>
		/// <returns>A System.Messaging.MessageQueue object</returns>
		public static System.Messaging.MessageQueue CreateMessageQueue(System.String queue)
		{
			System.Messaging.MessageQueue tempMessageQueue = new System.Messaging.MessageQueue(queue);
			tempMessageQueue.MessageReadPropertyFilter.Priority = true;
			tempMessageQueue.MessageReadPropertyFilter.Recoverable = true;
			tempMessageQueue.MessageReadPropertyFilter.TimeToBeReceived = true;
			tempMessageQueue.MessageReadPropertyFilter.SentTime = true;
			tempMessageQueue.Formatter = new System.Messaging.BinaryMessageFormatter();
			return tempMessageQueue;
		}

		/// <summary>
		/// Returns an IEnumerator containing the names of the keys of the message body.
		/// </summary>
		/// <param name="message">The message where to get the keys names from</param>
		/// <returns>An IEnumerator containing the keys of the message body</returns>
		public static System.Collections.IEnumerator Keys(System.Messaging.Message message)
		{
			System.String[] tempString = new System.String[((System.Collections.SortedList)message.Body).Keys.Count];
			((System.Collections.SortedList)message.Body).Keys.CopyTo(tempString, 0);
			return tempString.GetEnumerator();
		}

		/// <summary>
		/// Creates a Message object.
		/// </summary>
		/// <returns>A Message object with a BinaryMessageFormatter as its formatter.</returns>
		public static System.Messaging.Message CreateMessage()
		{
			System.Messaging.Message tempMessage = new System.Messaging.Message();
			tempMessage.Formatter = new System.Messaging.BinaryMessageFormatter();
			return tempMessage;
		}

		/// <summary>
		/// Receives the next avaliable message from the specified queue and assigns a BinaryMessageFormatter to its formatter property.
		/// </summary>
		/// <param name="queue">The queue where to retrieve the message from</param>
		/// <param name="expiration">Specifies a timeout time to return if no message is avaliable</param>
		/// <returns>A message if one is avaliable or null if the timeout is specified and it expires</returns>
		public static System.Messaging.Message ReceiveMessage(System.Messaging.MessageQueue queue, params System.Object[] expiration)
		{
			System.Messaging.Message tempMessage = null;

			if (expiration.Length == 0)
			{
				tempMessage = queue.Receive();
			}
			else
			{
				try
				{
					tempMessage = queue.Receive((System.TimeSpan)expiration[0]);					
				}
				catch (System.Messaging.MessageQueueException e)
				{
					//Check if the exception was caused by the timeout expiration, in this case the method should return null
					if (e.MessageQueueErrorCode != System.Messaging.MessageQueueErrorCode.IOTimeout)
					{						
						throw e;
					}
				}		
			}
			if (tempMessage != null)
			{
				tempMessage.Formatter = new System.Messaging.BinaryMessageFormatter();
			}
			return tempMessage;
		}

		/// <summary>
		/// Creates a new queue with a unique name to be used as a temporary queue.
		/// </summary>
		/// <returns>The path of the newly created queue.</returns>
		public static System.String CreateUniqueQueue()
		{
			System.Random rnd = new System.Random();
			System.String tempPath = @"\private$\ConversionGenerated_Queue_" + rnd.Next();
			try 
			{
				tempPath = System.Net.Dns.GetHostName() + tempPath;
			}
			catch
			{
				tempPath = System.Environment.MachineName + tempPath;
			}
			System.Messaging.MessageQueue.Create(tempPath);
			return "FORMATNAME:DIRECT=OS:" + tempPath;
		}

		/// <summary>
		/// Sets a portion of a byte array into the given Message.
		/// </summary>
		/// <param name="message">The message where the byte array portion is to be set.</param>
		/// <param name="name">The name of the byte array portion.</param>
		/// <param name="value">The byte array to set in the message.</param>
		/// <param name="offset">The initial offset within the byte array.</param>
		/// <param name="length">The number of bytes to store in the message.</param>
		public static void SetMapBytesPortion(System.Messaging.Message message, System.String name, byte[] value, int offset, int length)  
		{  
			byte[] temp_array = new byte[length];  
			for (int i=offset; i < offset+length; i++)  
			{  
				temp_array[i-offset] = value[i];  
			}  

			((System.Collections.SortedList)message.Body).Add(name, temp_array);  
		}
		
		/// <summary>
		/// Writes an SByte value into the message BodyStream
		/// </summary>
		/// <param name="message">Message holding a BodyStream</param>
		/// <param name="SByteValue">The value to be written</param>
		public static void WriteByte(System.Messaging.Message message, sbyte SByteValue)
		{
			if (message != null)
			{
				System.IO.BinaryWriter writer = new System.IO.BinaryWriter(message.BodyStream);
				if (writer != null)
				{
					writer.Write(SByteValue);
				}
			}
		}
	}


	/*******************************/
	/*******************************/
	/// <summary>
	/// Gives support functions to Http internet connections.
	/// </summary>
	public class URLConnectionSupport
	{
		/// <summary>
		/// Sets the request property for the specified key
		/// </summary>
		/// <param name="connection">Connection used to assign the property value</param>
		/// <param name="key">Property name to obtain the property value</param>
		/// <param name="keyValue">The value to associate with the specified property</param>
		public static void SetRequestProperty(System.Net.HttpWebRequest connection, System.String key, System.String keyValue) 
		{
			connection.Headers.Set(key,keyValue);
		}

		/// <summary>
		/// Gets the request property for the specified key
		/// </summary>
		/// <param name="connection">Connection used to obtain the property value</param>
		/// <param name="key">Property name to return it's property value</param>
		/// <returns>The value associated with the specified property</returns>
		public static System.String GetRequestProperty(System.Net.HttpWebRequest connection, System.String key) 
		{
			try
			{
				return connection.Headers.Get(key);
			}
			catch(System.Exception)
			{}
			return "";
		}

		/// <summary>
		/// Receives a key and returns it's default property value
		/// </summary>
		/// <param name="key">Key name to obtain the default request value</param>
		/// <returns>The default value associated with the property</returns>
		public static System.String GetDefaultRequestProperty(System.String key) 
		{
			return null;
		}

		/// <summary> 
		/// Gets the value of the "Content-Encoding" property from the collection of headers associated with the specified HttpWebRequest
		/// </summary>
		/// <param name="request">Instance of HttpWebRequest to get the headers from</param>
		/// <returns>The value of the "Content-Encoding" property if found, otherwise returns null</returns>
		public static System.String GetContentEncoding(System.Net.HttpWebRequest request)
		{
			try 
			{
				return request.GetResponse().Headers.Get("Content-Encoding");
			}
			catch(System.Exception)
			{}
			return null;
		}

		/// <summary>
		/// Gets the sending date of the resource referenced by the HttpRequest
		/// </summary>
		/// <param name="request">Instance of HttpWebRequest to get the date from</param>
		/// <returns>The sending date of the resource if found, otherwise 0</returns>
		public static long GetSendingDate(System.Net.HttpWebRequest request)
		{
			long headerDate;
			try
			{
				headerDate = System.DateTime.Parse(request.GetResponse().Headers.Get("Date")).Ticks;
			}
			catch(System.Exception)
			{
				headerDate = 0;
			}
			return headerDate;
		}

		/// <summary>
		/// Gets the key for the specified index from the KeysCollection of the specified HttpWebRequest's Headers property
		/// </summary>
		/// <param name="request">Instance HttpWebRequest to get the key from</param>
		/// <param name="indexField">Index of the field to get the corresponding key</param>
		/// <returns>The key for the specified index if found, otherwise null</returns>
		public static System.String GetHeaderFieldKey(System.Net.HttpWebRequest request, int indexField)
		{
			try
			{
				return request.GetResponse().Headers.Keys.Get(indexField);
			}
			catch(System.Exception)
			{}
			return null;
		}

		/// <summary>
		/// Gets the value of the "Last-Modified" property from the collection of headers associated with the specified HttWebRequest
		/// </summary>
		/// <param name="request">Instance of HttpWebRequest to get the headers from</param>
		/// <returns>The value of the "Last-Modified" property if found, otherwise returns null</returns>
		public static long GetLastModifiedHeaderField(System.Net.HttpWebRequest request)
		{
			long fieldHeaderDate;
			try
			{
				fieldHeaderDate = System.DateTime.Parse(request.GetResponse().Headers.Get("Last-Modified")).Ticks;
			}
			catch(System.Exception)
			{
				fieldHeaderDate = 0;
			}
			return fieldHeaderDate;
		}

		/// <summary>
		/// Gets the value of the named field parsed as date in milliseconds
		/// </summary>
		/// <param name="request">Instance of System.Net.HttpWebRequest to get the headers from</param>
		/// <param name="fieldName">Name of the header field</param>
		/// <param name="defaultValue">A default value to return if the value does not exist in the headers</param>
		/// <returns></returns>
		public static long GetHeaderFieldDate(System.Net.HttpWebRequest request, System.String fieldName, long defaultValue)
		{
			long fieldHeaderDate;
			try
			{
				fieldHeaderDate = System.DateTime.Parse(request.GetResponse().Headers.Get(fieldName)).Ticks;
			}
			catch(System.Exception)
			{
				fieldHeaderDate = defaultValue;
			}
			return fieldHeaderDate;
		}
	}

	/*******************************/
	/// <summary>
	/// Represents the methods to support some operations over files.
	/// </summary>
	public class FileSupport
	{
		/// <summary>
		/// Creates a new empty file with the specified pathname.
		/// </summary>
		/// <param name="path">The abstract pathname of the file</param>
		/// <returns>True if the file does not exist and was succesfully created</returns>
		public static bool CreateNewFile(System.IO.FileInfo path)
		{
			if (path.Exists)
			{
				return false;
			}
			else
			{
                System.IO.FileStream createdFile = path.Create();
                createdFile.Close();
				return true;
			}
		}

		/// <summary>
		/// Compares the specified object with the specified path
		/// </summary>
		/// <param name="path">An abstract pathname to compare with</param>
		/// <param name="file">An object to compare with the given pathname</param>
		/// <returns>A value indicating a lexicographically comparison of the parameters</returns>
		public static int CompareTo(System.IO.FileInfo path, System.Object file)
		{
			if( file is System.IO.FileInfo )
			{
				System.IO.FileInfo fileInfo = (System.IO.FileInfo)file;
				return path.FullName.CompareTo( fileInfo.FullName );
			}
			else
			{
				throw new System.InvalidCastException();
			}
		}

		/// <summary>
		/// Returns an array of abstract pathnames representing the files and directories of the specified path.
		/// </summary>
		/// <param name="path">The abstract pathname to list it childs.</param>
		/// <returns>An array of abstract pathnames childs of the path specified or null if the path is not a directory</returns>
		public static System.IO.FileInfo[] GetFiles(System.IO.FileInfo path)
		{
			if ( (path.Attributes & System.IO.FileAttributes.Directory) > 0 )
			{																 
				String[] fullpathnames = System.IO.Directory.GetFileSystemEntries(path.FullName);
				System.IO.FileInfo[] result = new System.IO.FileInfo[fullpathnames.Length];
				for(int i = 0; i < result.Length ; i++)
					result[i] = new System.IO.FileInfo(fullpathnames[i]);
				return result;
			}
			else return null;
		}

		/// <summary>
		/// Creates an instance of System.Uri class with the pech specified
		/// </summary>
		/// <param name="path">The abstract path name to create the Uri</param>
		/// <returns>A System.Uri instance constructed with the specified path</returns>
		public static System.Uri ToUri(System.IO.FileInfo path)
		{
			System.UriBuilder uri = new System.UriBuilder();
			uri.Path = path.FullName;
			uri.Host = String.Empty;
			uri.Scheme = System.Uri.UriSchemeFile;
			return uri.Uri;
		}

		/// <summary>
		/// Returns true if the file specified by the pathname is a hidden file.
		/// </summary>
		/// <param name="file">The abstract pathname of the file to test</param>
		/// <returns>True if the file is hidden, false otherwise</returns>
		public static bool IsHidden(System.IO.FileInfo file)
		{
			return ((file.Attributes & System.IO.FileAttributes.Hidden) > 0); 
		}

		/// <summary>
		/// Sets the read-only property of the file to true.
		/// </summary>
		/// <param name="file">The abstract path name of the file to modify</param>
		public static bool SetReadOnly(System.IO.FileInfo file)
		{
			try 
			{
				file.Attributes = file.Attributes | System.IO.FileAttributes.ReadOnly;
				return true;
			}
			catch (System.Exception exception)
			{
				String exceptionMessage = exception.Message;
				return false;
			}
		}

		/// <summary>
		/// Sets the last modified time of the specified file with the specified value.
		/// </summary>
		/// <param name="file">The file to change it last-modified time</param>
		/// <param name="date">Total number of miliseconds since January 1, 1970 (new last-modified time)</param>
		/// <returns>True if the operation succeeded, false otherwise</returns>
		public static bool SetLastModified(System.IO.FileInfo file, long date)
		{
			try 
			{
				long valueConstant = (new System.DateTime(1969, 12, 31, 18, 0, 0)).Ticks;
				file.LastWriteTime = new System.DateTime( (date * 10000L) + valueConstant );
				return true;
			}
			catch (System.Exception exception)
			{
				String exceptionMessage = exception.Message;
				return false;
			}
		}
	}
	/*******************************/
	/// <summary>
	/// Gets the current System properties.
	/// </summary>
	/// <returns>The current system properties.</returns>
	public static System.Collections.Specialized.NameValueCollection GetProperties()
	{
		System.Collections.Specialized.NameValueCollection properties = new System.Collections.Specialized.NameValueCollection();
		System.Collections.ArrayList keys = new System.Collections.ArrayList(System.Environment.GetEnvironmentVariables().Keys);
		System.Collections.ArrayList values = new System.Collections.ArrayList(System.Environment.GetEnvironmentVariables().Values);
		for (int count = 0; count < keys.Count; count++)
			properties.Add(keys[count].ToString(), values[count].ToString());
		return properties;
	}


	/*******************************/
	/// <summary>
	/// This method loads a Xml DOM tree in memory taking data from a Xml source.
	/// </summary>
	/// <param name="manager">The XmlDOMDocumentManager needed to build the XmlDocument instance.</param>
	/// <param name="source">The source to be used to build the DOM tree.</param>
	/// <returns>A XmlDocument class with the contains of the source.</returns>
	public static System.Xml.XmlDocument ParseDocument(System.Xml.XmlDocument document, XmlSourceSupport source)
	{
		if (source.Characters != null)
		{
			document.Load(source.Characters.BaseStream);
			return (System.Xml.XmlDocument)document.Clone();
		}
		else
		{
			if (source.Bytes != null)
			{
				document.Load(source.Bytes);
				return (System.Xml.XmlDocument)document.Clone();
			}
			else
			{
				if(source.Uri != null)
				{
					document.Load(source.Uri);
					return (System.Xml.XmlDocument)document.Clone();
				}
				else
					throw new System.Xml.XmlException("The XmlSource class can't be null");
			}
		}
	}


	/*******************************/
	/// <summary>
	/// This class contains static methods to manage TreeViews.
	/// </summary>
	public class TreeSupport
	{
		/// <summary>
		/// Creates a new TreeView from the provided HashTable.
		/// </summary> 
		/// <param name="hashTable">HashTable</param>		
		/// <returns>Returns the created tree</returns>
		public static System.Windows.Forms.TreeView CreateTreeView(System.Collections.Hashtable hashTable)
		{
			System.Windows.Forms.TreeView tree = new System.Windows.Forms.TreeView();
			return SetTreeView(tree,hashTable);
		}

		/// <summary>
		/// Sets a TreeView with data from the provided HashTable.
		/// </summary> 
		/// <param name="treeView">Tree.</param>
		/// <param name="hashTable">HashTable.</param>
		/// <returns>Returns the set tree.</returns>		
		public static System.Windows.Forms.TreeView SetTreeView(System.Windows.Forms.TreeView treeView, System.Collections.Hashtable hashTable)
		{
			foreach (System.Collections.DictionaryEntry myEntry in hashTable)
			{				
				System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode();

				if (myEntry.Value is System.Collections.ArrayList)
				{
					root.Text = "[";
					FillNode(root, (System.Collections.ArrayList)myEntry.Value);	
					root.Text = root.Text + "]";				
				}
				else if (myEntry.Value is System.Object[])
				{
					root.Text = "[";
					FillNode(root,(System.Object[])myEntry.Value);
					root.Text = root.Text + "]";
				}
				else if (myEntry.Value is System.Collections.Hashtable)
				{
					root.Text = "[";
					FillNode(root,(System.Collections.Hashtable)myEntry.Value);
					root.Text = root.Text + "]";
				}
				else
					root.Text = myEntry.ToString();

				treeView.Nodes.Add(root);					
			}
			return treeView;
		}
		

		/// <summary>
		/// Creates a new TreeView from the provided ArrayList.
		/// </summary> 
		/// <param name="arrayList">ArrayList.</param>		
		/// <returns>Returns the created tree.</returns>
		public static System.Windows.Forms.TreeView CreateTreeView(System.Collections.ArrayList arrayList)
		{
			System.Windows.Forms.TreeView tree = new System.Windows.Forms.TreeView();
			return SetTreeView(tree, arrayList);
		}

		/// <summary>
		/// Sets a TreeView with data from the provided ArrayList.
		/// </summary> 
		/// <param name="treeView">Tree.</param>
		/// <param name="arrayList">ArrayList.</param>
		/// <returns>Returns the set tree.</returns>
		public static System.Windows.Forms.TreeView SetTreeView(System.Windows.Forms.TreeView treeView, System.Collections.ArrayList arrayList)		
		{
			foreach (System.Object arrayEntry in arrayList)
			{
				System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode();
		
				if (arrayEntry is System.Collections.ArrayList)
				{
					root.Text = "[";
					FillNode(root, (System.Collections.ArrayList)arrayEntry);
					root.Text = root.Text + "]";
				}
				else if (arrayEntry is System.Collections.Hashtable)
				{
					root.Text = "[";
					FillNode(root,(System.Collections.Hashtable)arrayEntry);
					root.Text = root.Text + "]";
				}
				else if (arrayEntry is System.Object[])	
				{
					root.Text = "[";
					FillNode(root,(System.Object[])arrayEntry);
					root.Text = root.Text + "]";
				}
				else
					root.Text = arrayEntry.ToString();
				
		
				treeView.Nodes.Add(root);					
			}
			return treeView;
		}		
		
		/// <summary>
		/// Creates a new TreeView from the provided Object Array.
		/// </summary> 
		/// <param name="objectArray">Object Array.</param>		
		/// <returns>Returns the created tree.</returns>
		public static System.Windows.Forms.TreeView CreateTreeView(System.Object[] objectArray)
		{
			System.Windows.Forms.TreeView tree = new System.Windows.Forms.TreeView();
			return SetTreeView(tree, objectArray);
		}

		/// <summary>
		/// Sets a TreeView with data from the provided Object Array.
		/// </summary> 
		/// <param name="treeView">Tree.</param>
		/// <param name="objectArray">Object Array.</param>
		/// <returns>Returns the created tree.</returns>
		public static System.Windows.Forms.TreeView SetTreeView(System.Windows.Forms.TreeView treeView, System.Object[] objectArray)
		{
			foreach (System.Object arrayEntry in objectArray)
			{		
				System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode();

				if (arrayEntry is System.Collections.ArrayList)
				{
					root.Text = "[";
					FillNode(root,(System.Collections.ArrayList)arrayEntry);
					root.Text = root.Text + "]";
				}
				else if (arrayEntry is System.Collections.Hashtable)				
				{
					root.Text = "[";
					FillNode(root,(System.Collections.Hashtable)arrayEntry);						
					root.Text = root.Text + "]";		
				}
				else if (arrayEntry is System.Object[])
				{
					root.Text = "[";
					FillNode(root,(System.Object[])arrayEntry);					
					root.Text = root.Text + "]";
				}
				else
					root.Text = arrayEntry.ToString();

				treeView.Nodes.Add(root);
			}		
			return treeView;
		}		

		/// <summary>
		/// Creates a new TreeView with the provided TreeNode as root.
		/// </summary> 
		/// <param name="root">Root.</param>		
		/// <returns>Returns the created tree.</returns>
		public static System.Windows.Forms.TreeView CreateTreeView(System.Windows.Forms.TreeNode root)
		{
			System.Windows.Forms.TreeView tree = new System.Windows.Forms.TreeView();
			return SetTreeView(tree, root);
		}

		/// <summary>
		/// Sets a TreeView with the provided TreeNode as root.
		/// </summary>
		/// <param name="treeView">Tree</param>
		/// <param name="root">Root</param>
		/// <returns>Returns the created tree</returns>
		public static System.Windows.Forms.TreeView SetTreeView(System.Windows.Forms.TreeView treeView, System.Windows.Forms.TreeNode root)
		{
			if (root != null)
				treeView.Nodes.Add(root);
			return treeView;
		}
			
		/// <summary>
		/// Sets a TreeView with the provided TreeNode as root.
		/// </summary> 
		/// <param name="model">Root data model.</param>
		public static void SetModel(System.Windows.Forms.TreeView tree, System.Windows.Forms.TreeNode model)
		{
			tree.Nodes.Clear();
			tree.Nodes.Add(model);
		}
			
		/// <summary>
		/// Get the root TreeNode from a TreeView.
		/// </summary> 
		/// <param name="tree">Tree.</param>
		public static System.Windows.Forms.TreeNode GetModel(System.Windows.Forms.TreeView tree)
		{
			if (tree.Nodes.Count > 0 )
				return tree.Nodes[0];
			else
				return null;
		}

		/// <summary>
		/// Sets a TreeNode with data from the provided ArrayList instance.
		/// </summary> 
		/// <param name="treeNode">Node.</param>
		/// <param name="arrayList">ArrayList.</param>
		/// <returns>Returns the set node.</returns>
		public static System.Windows.Forms.TreeNode FillNode(System.Windows.Forms.TreeNode treeNode, System.Collections.ArrayList arrayList)
		{		
			foreach (System.Object arrayEntry in arrayList)
			{
				System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode();				

				if (arrayEntry is System.Collections.ArrayList)
				{
					root.Text = "[";
					FillNode(root, (System.Collections.ArrayList)arrayEntry);
					root.Text = root.Text + "]";
					treeNode.Nodes.Add(root);
					treeNode.Text = treeNode.Text + ", " + root.Text;
				}
				else if (arrayEntry is System.Object[])
				{					
					root.Text = "[";
					FillNode(root,(System.Object[])arrayEntry);	
					root.Text = root.Text + "]";
					treeNode.Nodes.Add(root);	
					treeNode.Text = treeNode.Text + ", " + root.Text;
				}
				else if (arrayEntry is System.Collections.Hashtable)
				{
					root.Text = "[";
					FillNode(root,(System.Collections.Hashtable)arrayEntry);	
					root.Text = root.Text + "]";
					treeNode.Nodes.Add(root);	
					treeNode.Text = treeNode.Text + ", " + root.Text;
				}
				else
				{
					treeNode.Nodes.Add(arrayEntry.ToString());
					if (!(treeNode.Text.Equals("")))
					{
						if (treeNode.Text[treeNode.Text.Length-1].Equals('['))
							treeNode.Text = treeNode.Text + arrayEntry.ToString();
						else
							treeNode.Text = treeNode.Text + ", " + arrayEntry.ToString();
					}
					else
						treeNode.Text = treeNode.Text + ", " + arrayEntry.ToString();
				}
			}
			return treeNode;
		}
		

		/// <summary>
		/// Sets a TreeNode with data from the provided ArrayList.
		/// </summary> 
		/// <param name="treeNode">Node.</param>
		/// <param name="objectArray">Object Array.</param>
		/// <returns>Returns the set node.</returns>
		
		public static System.Windows.Forms.TreeNode FillNode(System.Windows.Forms.TreeNode treeNode, System.Object[] objectArray)
		{
			foreach (System.Object arrayEntry in objectArray)
			{
				System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode();

				if (arrayEntry is System.Collections.ArrayList)
				{
					root.Text = "[";
					FillNode(root,(System.Collections.ArrayList)arrayEntry);									
					root.Text = root.Text + "]";
				}
				else if (arrayEntry is System.Collections.Hashtable)				
				{
					root.Text = "[";
					FillNode(root,(System.Collections.Hashtable)arrayEntry);
					root.Text = root.Text + "]";				
				}
				else
				{
					root.Nodes.Add(objectArray.ToString());
					root.Text = root.Text + ", " + objectArray.ToString();
				}
				treeNode.Nodes.Add(root);
				treeNode.Text = treeNode.Text + root.Text;
			}
			return treeNode;
		}
		
		/// <summary>		
		/// Sets a TreeNode with data from the provided Hashtable.		
		/// </summary> 		
		/// <param name="treeNode">Node.</param>		
		/// <param name="hashTable">Hash Table Object.</param>		
		/// <returns>Returns the set node.</returns>		
		public static System.Windows.Forms.TreeNode FillNode(System.Windows.Forms.TreeNode treeNode, System.Collections.Hashtable hashTable)
		{		
			foreach (System.Collections.DictionaryEntry myEntry in hashTable)
			{
				System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode();				

				if (myEntry.Value is System.Collections.ArrayList)
				{
					FillNode(root, (System.Collections.ArrayList)myEntry.Value);
					treeNode.Nodes.Add(root);
				}
				else if (myEntry.Value is System.Object[])
				{
					FillNode(root,(System.Object[])myEntry.Value);	
					treeNode.Nodes.Add(root);	
				}
				else
					treeNode.Nodes.Add(myEntry.Key.ToString());
			}
			return treeNode;
		}
	}
}
