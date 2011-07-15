/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DefaultValidator.java".  Description: 
/// "A default conformance validator." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2003.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.conf.spec.message;
using Genetibase.NuGenHL7.conf.spec;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ProfileException = Genetibase.NuGenHL7.conf.NuGenProfileException;
using ProfileParser = Genetibase.NuGenHL7.conf.parser.NuGenProfileParser;
using Genetibase.NuGenHL7.parser;

using Genetibase.NuGenHL7.conf.store;
namespace Genetibase.NuGenHL7.conf.check
{
	
	/// <summary> A default conformance validator.</summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class NuGenDefaultValidator : NuGenValidator
	{
		
		private NuGenEncodingCharacters enc; //used to check for content in parts of a message
		
		/// <summary>Creates a new instance of DefaultValidator </summary>
		public NuGenDefaultValidator()
		{
			enc = new NuGenEncodingCharacters('|', null); //the | is assumed later -- don't change
		}
		
		/// <seealso cref="Validator.validate">
		/// </seealso>
		public virtual NuGenHL7Exception[] validate(Message message, StaticDef profile)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList(20);
			Terser t = new Terser(message);
			
			//check msg type, event type, msg struct ID
			System.String msgType = t.get_Renamed("/MSH-9-1");
			if (!msgType.Equals(profile.MsgType))
			{
				NuGenHL7Exception e = new NuGenProfileNotFollowedException("Message type " + msgType + " doesn't match profile type of " + profile.MsgType);
				exList.Add(e);
			}
			
			System.String evType = t.get_Renamed("/MSH-9-2");
			if (!evType.Equals(profile.EventType) && !profile.EventType.ToUpper().Equals("ALL".ToUpper()))
			{
				NuGenHL7Exception e = new NuGenProfileNotFollowedException("Event type " + evType + " doesn't match profile type of " + profile.EventType);
				exList.Add(e);
			}
			
			System.String msgStruct = t.get_Renamed("/MSH-9-3");
			if (msgStruct == null || !msgStruct.Equals(profile.MsgStructID))
			{
				NuGenHL7Exception e = new NuGenProfileNotFollowedException("Message structure " + msgStruct + " doesn't match profile type of " + profile.MsgStructID);
				exList.Add(e);
			}
			
			System.Exception[] childExceptions;
			childExceptions = testGroup(message, profile, profile.Identifier);
			for (int i = 0; i < childExceptions.Length; i++)
			{
				exList.Add(childExceptions[i]);
			}
			
			return toArray(exList);
		}
		
		/// <summary> Tests a group against a group section of a profile.</summary>
		public virtual NuGenHL7Exception[] testGroup(Group group, AbstractSegmentContainer profile, System.String profileID)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList(20);
			System.Collections.ArrayList allowedStructures = new System.Collections.ArrayList(20);
			
			for (int i = 1; i <= profile.Children; i++)
			{
				ProfileStructure struct_Renamed = profile.getChild(i);
				
				//only test a structure in detail if it isn't X
				if (!struct_Renamed.Usage.ToUpper().Equals("X".ToUpper()))
				{
					allowedStructures.Add(struct_Renamed.Name);
					
					//see which instances have content
					try
					{
						Structure[] instances = group.getAll(struct_Renamed.Name);
						System.Collections.ArrayList instancesWithContent = new System.Collections.ArrayList(10);
						for (int j = 0; j < instances.Length; j++)
						{
							if (hasContent(instances[j]))
								instancesWithContent.Add(instances[j]);
						}
						
						NuGenHL7Exception ce = testCardinality(instancesWithContent.Count, struct_Renamed.Min, struct_Renamed.Max, struct_Renamed.Usage, struct_Renamed.Name);
						if (ce != null)
							exList.Add(ce);
						
						//test children on instances with content
						for (int j = 0; j < instancesWithContent.Count; j++)
						{
							Structure s = (Structure) instancesWithContent[j];
							NuGenHL7Exception[] childExceptions = testStructure(s, struct_Renamed, profileID);
							addToList(childExceptions, exList);
						}
					}
					catch (NuGenHL7Exception)
					{
						exList.Add(new NuGenProfileNotHL7CompliantException(struct_Renamed.Name + " not found in message"));
					}
				}
			}
			
			//complain about X structures that have content
			addToList(checkForExtraStructures(group, allowedStructures), exList);
			
			return toArray(exList);
		}
		
		/// <summary> Checks a group's children against a list of allowed structures for the group 
		/// (ie those mentioned in the profile with usage other than X).  Returns 
		/// a list of exceptions representing structures that appear in the message  
		/// but are not supposed to.  
		/// </summary>
		private NuGenHL7Exception[] checkForExtraStructures(Group group, System.Collections.ArrayList allowedStructures)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList();
			System.String[] childNames = group.Names;
			for (int i = 0; i < childNames.Length; i++)
			{
				if (!allowedStructures.Contains(childNames[i]))
				{
					try
					{
						Structure[] reps = group.getAll(childNames[i]);
						for (int j = 0; j < reps.Length; j++)
						{
							if (hasContent(reps[j]))
							{
								NuGenHL7Exception e = new NuGenXElementPresentException("The structure " + childNames[i] + " appears in the message but not in the profile");
								exList.Add(e);
							}
						}
					}
					catch (NuGenHL7Exception he)
					{
						throw new NuGenProfileException("Problem checking profile", he);
					}
				}
			}
			return toArray(exList);
		}
		
		/// <summary> Checks cardinality and creates an appropriate exception if out 
		/// of bounds.  The usage code is needed because if min cardinality
		/// is > 0, the min # of reps is only required if the usage code
		/// is 'R' (see HL7 v2.5 section 2.12.6.4).  
		/// </summary>
		/// <param name="reps">the number of reps
		/// </param>
		/// <param name="min">the minimum number of reps
		/// </param>
		/// <param name="max">the maximum number of reps (-1 means *)
		/// </param>
		/// <param name="usage">the usage code 
		/// </param>
		/// <param name="name">the name of the repeating structure (used in exception msg)
		/// </param>
		/// <returns> null if cardinality OK, exception otherwise
		/// </returns>
		protected internal virtual NuGenHL7Exception testCardinality(int reps, int min, int max, System.String usage, System.String name)
		{
			NuGenHL7Exception e = null;
			if (reps < min && usage.ToUpper().Equals("R".ToUpper()))
			{
				e = new NuGenProfileNotFollowedException(name + " must have at least " + min + " repetitions (has " + reps + ")");
			}
			else if (max > 0 && reps > max)
			{
				e = new NuGenProfileNotFollowedException(name + " must have no more than " + max + " repetitions (has " + reps + ")");
			}
			return e;
		}
		
		/// <summary> Tests a structure (segment or group) against the corresponding part of a profile.  </summary>
		public virtual NuGenHL7Exception[] testStructure(Structure s, ProfileStructure profile, System.String profileID)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList(20);
			if (profile is Seg)
			{
				if (typeof(Segment).IsAssignableFrom(s.GetType()))
				{
					addToList(testSegment((Segment) s, (Seg) profile, profileID), exList);
				}
				else
				{
					exList.Add(new NuGenProfileNotHL7CompliantException("Mismatch between a segment in the profile and the structure " + s.GetType().FullName + " in the message"));
				}
			}
			else if (profile is SegGroup)
			{
				if (typeof(Group).IsAssignableFrom(s.GetType()))
				{
					addToList(testGroup((Group) s, (SegGroup) profile, profileID), exList);
				}
				else
				{
					exList.Add(new NuGenProfileNotHL7CompliantException("Mismatch between a group in the profile and the structure " + s.GetType().FullName + " in the message"));
				}
			}
			return toArray(exList);
		}
		
		/// <summary> Tests a segment against a segment section of a profile.</summary>
		public virtual NuGenHL7Exception[] testSegment(Genetibase.NuGenHL7.model.Segment segment, Seg profile, System.String profileID)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList(20);
			System.Collections.ArrayList allowedFields = new System.Collections.ArrayList(20);
			
			for (int i = 1; i <= profile.Fields; i++)
			{
				Field field = profile.getField(i);
				
				//only test a field in detail if it isn't X
				if (!field.Usage.ToUpper().Equals("X".ToUpper()))
				{
					allowedFields.Add((System.Int32) i);
					
					//see which instances have content
					try
					{                        
						Genetibase.NuGenHL7.model.Type[] instances = segment.getField(i);
						System.Collections.ArrayList instancesWithContent = new System.Collections.ArrayList(10);
						for (int j = 0; j < instances.Length; j++)
						{
							if (hasContent(instances[j]))
								instancesWithContent.Add(instances[j]);
						}
						
						NuGenHL7Exception ce = testCardinality(instancesWithContent.Count, field.Min, field.Max, field.Usage, field.Name);
						if (ce != null)
						{
							ce.FieldPosition = i;
							exList.Add(ce);
						}
						
						//test field instances with content
						for (int j = 0; j < instancesWithContent.Count; j++)
						{
							Genetibase.NuGenHL7.model.Type s = (Genetibase.NuGenHL7.model.Type) instancesWithContent[j];
							
							bool escape = true; //escape field value when checking length
							if (profile.Name.ToUpper().Equals("MSH".ToUpper()) && i < 3)
							{
								escape = false;
							}
							NuGenHL7Exception[] childExceptions = testField(s, field, escape, profileID);
							for (int k = 0; k < childExceptions.Length; k++)
							{
								childExceptions[k].FieldPosition = i;
							}
							addToList(childExceptions, exList);
						}
					}
					catch (NuGenHL7Exception)
					{
						exList.Add(new NuGenProfileNotHL7CompliantException("Field " + i + " not found in message"));
					}
				}
			}
			
			//complain about X fields with content
			this.addToList(checkForExtraFields(segment, allowedFields), exList);
			
			NuGenHL7Exception[] ret = toArray(exList);
			for (int i = 0; i < ret.Length; i++)
			{
				ret[i].SegmentName = profile.Name;
			}
			return ret;
		}
		
		/// <summary> Checks a segment against a list of allowed fields 
		/// (ie those mentioned in the profile with usage other than X).  Returns 
		/// a list of exceptions representing field that appear 
		/// but are not supposed to.  
		/// </summary>
		/// <param name="allowedFields">an array of Integers containing field #s of allowed fields
		/// </param>
		private NuGenHL7Exception[] checkForExtraFields(Segment segment, System.Collections.ArrayList allowedFields)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList();
			for (int i = 1; i <= segment.numFields(); i++)
			{
				if (!allowedFields.Contains((System.Int32) i))
				{
					try
					{
						Genetibase.NuGenHL7.model.Type[] reps = segment.getField(i);
						for (int j = 0; j < reps.Length; j++)
						{
							if (hasContent(reps[j]))
							{
								NuGenHL7Exception e = new NuGenXElementPresentException("Field " + i + " in " + segment.getName() + " appears in the message but not in the profile");
								exList.Add(e);
							}
						}
					}
					catch (NuGenHL7Exception he)
					{
						throw new NuGenProfileException("Problem testing against profile", he);
					}
				}
			}
			return this.toArray(exList);
		}
		
		/// <summary> Tests a Type against the corresponding section of a profile.</summary>
		/// <param name="encoded">optional encoded form of type (if you want to specify this -- if null,  
		/// default pipe-encoded form is used to check length and constant val)
		/// </param>
        public virtual NuGenHL7Exception[] testType(Genetibase.NuGenHL7.model.Type type, AbstractComponent profile, System.String encoded, System.String profileID)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList();
			if (encoded == null)
				encoded = NuGenPipeParser.encode(type, this.enc);
			
			NuGenHL7Exception ue = testUsage(encoded, profile.Usage, profile.Name);
			if (ue != null)
				exList.Add(ue);
			
			if (!profile.Usage.Equals("X"))
			{
				//check datatype
				System.String typeClass = type.GetType().FullName;
				if (typeClass.IndexOf("." + profile.Datatype) < 0)
				{
					typeClass = typeClass.Substring(typeClass.LastIndexOf('.') + 1);
					exList.Add(new NuGenProfileNotHL7CompliantException("HL7 datatype " + typeClass + " doesn't match profile datatype " + profile.Datatype));
				}
				
				//check length
				if (encoded.Length > profile.Length)
					exList.Add(new NuGenProfileNotFollowedException("The type " + profile.Name + " has length " + encoded.Length + " which exceeds max of " + profile.Length));
				
				//check constant value
				if (profile.ConstantValue != null && profile.ConstantValue.Length > 0)
				{
					if (!encoded.Equals(profile.ConstantValue))
						exList.Add(new NuGenProfileNotFollowedException("'" + encoded + "' doesn't equal constant value of '" + profile.ConstantValue + "'"));
				}
				
				NuGenHL7Exception[] te = testTypeAgainstTable(type, profile, profileID);
				for (int i = 0; i < te.Length; i++)
				{
					exList.Add(te[i]);
				}
			}
			
			return this.toArray(exList);
		}
		
		/// <summary> Tests whether the given type falls within a maximum length.  </summary>
		/// <returns> null of OK, an HL7Exception otherwise 
		/// </returns>
        public virtual NuGenHL7Exception testLength(Genetibase.NuGenHL7.model.Type type, int maxLength)
		{
			NuGenHL7Exception e = null;
			System.String encoded = NuGenPipeParser.encode(type, this.enc);
			if (encoded.Length > maxLength)
			{
				e = new NuGenProfileNotFollowedException("Length of " + encoded.Length + " exceeds maximum of " + maxLength);
			}
			return e;
		}
		
		/// <summary> Tests an element against the corresponding usage code.  The element 
		/// is required in its encoded form.  
		/// </summary>
		/// <param name="encoded">the pipe-encoded message element 
		/// </param>
		/// <param name="usage">the usage code (e.g. "CE")
		/// </param>
		/// <param name="name">the name of the element (for use in exception messages)
		/// </param>
		/// <returns>s null if there is no problem, an HL7Exception otherwise 
		/// </returns>
		private NuGenHL7Exception testUsage(System.String encoded, System.String usage, System.String name)
		{
			NuGenHL7Exception e = null;
			if (usage.ToUpper().Equals("R".ToUpper()))
			{
				if (encoded.Length == 0)
					e = new NuGenProfileNotFollowedException("Required element " + name + " is missing");
			}
			else if (usage.ToUpper().Equals("RE".ToUpper()))
			{
				//can't test anything 
			}
			else if (usage.ToUpper().Equals("O".ToUpper()))
			{
				//can't test anything
			}
			else if (usage.ToUpper().Equals("C".ToUpper()))
			{
				//can't test anything yet -- wait for condition syntax in v2.6 
			}
			else if (usage.ToUpper().Equals("CE".ToUpper()))
			{
				//can't test anything
			}
			else if (usage.ToUpper().Equals("X".ToUpper()))
			{
				if (encoded.Length > 0)
					e = new NuGenXElementPresentException("Element " + name + " is present but specified as not used (X)");
			}
			else if (usage.ToUpper().Equals("B".ToUpper()))
			{
				//can't test anything 
			}
			return e;
		}
		
		/// <summary> Tests table values for ID, IS, and CE types.  An empty list is returned for 
		/// all other types or if the table name or number is missing.  
		/// </summary>
        private NuGenHL7Exception[] testTypeAgainstTable(Genetibase.NuGenHL7.model.Type type, AbstractComponent profile, System.String profileID)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList();
			if (profile.Table != null && type.Name.Equals("IS") || type.Name.Equals("ID"))
			{
				System.String codeSystem = makeTableName(profile.Table);
				System.String value_Renamed = ((Primitive) type).Value;
				addTableTestResult(exList, profileID, codeSystem, value_Renamed);
			}
			else if (type.Name.Equals("CE"))
			{
				System.String value_Renamed = Terser.getPrimitive(type, 1, 1).Value;
				System.String codeSystem = Terser.getPrimitive(type, 3, 1).Value;
				addTableTestResult(exList, profileID, codeSystem, value_Renamed);
				
				value_Renamed = Terser.getPrimitive(type, 4, 1).Value;
				codeSystem = Terser.getPrimitive(type, 6, 1).Value;
				addTableTestResult(exList, profileID, codeSystem, value_Renamed);
			}
			return this.toArray(exList);
		}
		
		private void  addTableTestResult(System.Collections.ArrayList exList, System.String profileID, System.String codeSystem, System.String value_Renamed)
		{
			if (codeSystem != null && value_Renamed != null)
			{
				NuGenHL7Exception e = testValueAgainstTable(profileID, codeSystem, value_Renamed);
				if (e != null)
					exList.Add(e);
			}
		}
		
		private NuGenHL7Exception testValueAgainstTable(System.String profileID, System.String codeSystem, System.String value_Renamed)
		{
			NuGenHL7Exception ret = null;
			CodeStore store = ProfileStoreFactory.getCodeStore(profileID, codeSystem);
			if (store == null)
			{
			}
			else
			{
				if (!store.isValidCode(codeSystem, value_Renamed))
					ret = new NuGenProfileNotFollowedException("Code " + value_Renamed + " not found in table " + codeSystem + ", profile " + profileID);
			}
			return ret;
		}
		
		private System.String makeTableName(System.String hl7Table)
		{
			System.Text.StringBuilder buf = new System.Text.StringBuilder("HL7");
			if (hl7Table.Length < 4)
				buf.Append("0");
			if (hl7Table.Length < 3)
				buf.Append("0");
			if (hl7Table.Length < 2)
				buf.Append("0");
			buf.Append(hl7Table);
			return buf.ToString();
		}

        public virtual NuGenHL7Exception[] testField(Genetibase.NuGenHL7.model.Type type, Field profile, bool escape, System.String profileID)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList(20);
			
			//account for MSH 1 & 2 which aren't escaped
			System.String encoded = null;
			if (!escape && typeof(Primitive).IsAssignableFrom(type.GetType()))
				encoded = ((Primitive) type).Value;
			
			addToList(testType(type, profile, encoded, profileID), exList);
			
			//test children
			if (profile.Components > 0 && !profile.Usage.Equals("X"))
			{
				if (typeof(Composite).IsAssignableFrom(type.GetType()))
				{
					Composite comp = (Composite) type;
					for (int i = 1; i <= profile.Components; i++)
					{
						Component childProfile = profile.getComponent(i);
						try
						{
							Genetibase.NuGenHL7.model.Type child = comp.getComponent(i - 1);
							addToList(testComponent(child, childProfile, profileID), exList);
						}
						catch (DataTypeException de)
						{
							exList.Add(new NuGenProfileNotHL7CompliantException("More components in profile than allowed in message: " + de.Message));
						}
					}
					addToList(checkExtraComponents(comp, profile.Components), exList);
				}
				else
				{
					exList.Add(new NuGenProfileNotHL7CompliantException("A field has type primitive " + type.GetType().FullName + " but the profile defines components"));
				}
			}
			
			return toArray(exList);
		}

        public virtual NuGenHL7Exception[] testComponent(Genetibase.NuGenHL7.model.Type type, Component profile, System.String profileID)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList(20);
			
			addToList(testType(type, profile, null, profileID), exList);
			
			//test children
			if (profile.SubComponents > 0 && !profile.Usage.Equals("X") && hasContent(type))
			{
				if (typeof(Composite).IsAssignableFrom(type.GetType()))
				{
					Composite comp = (Composite) type;
					for (int i = 1; i <= profile.SubComponents; i++)
					{
						SubComponent childProfile = profile.getSubComponent(i);
						try
						{
							Genetibase.NuGenHL7.model.Type child = comp.getComponent(i - 1);
							addToList(testType(child, childProfile, null, profileID), exList);
						}
						catch (DataTypeException de)
						{
							exList.Add(new NuGenProfileNotHL7CompliantException("More subcomponents in profile than allowed in message: " + de.Message));
						}
					}
					addToList(checkExtraComponents(comp, profile.SubComponents), exList);
				}
				else
				{
					exList.Add(new NuGenProfileNotFollowedException("A component has primitive type " + type.GetType().FullName + " but the profile defines subcomponents"));
				}
			}
			
			return toArray(exList);
		}
		
		/// <summary>Tests for extra components (ie any not defined in the profile) </summary>
		private NuGenHL7Exception[] checkExtraComponents(Composite comp, int numInProfile)
		{
			System.Collections.ArrayList exList = new System.Collections.ArrayList(20);
			
			System.Text.StringBuilder extra = new System.Text.StringBuilder();
			for (int i = numInProfile; i < comp.Components.Length; i++)
			{
				try
				{
					System.String s = NuGenPipeParser.encode(comp.getComponent(i), enc);
					if (s.Length > 0)
					{
						extra.Append(s);
						extra.Append(enc.ComponentSeparator);
					}
				}
				catch (DataTypeException de)
				{
					throw new NuGenProfileException("Problem testing against profile", de);
				}
			}
			
			if (extra.ToString().Length > 0)
			{
				exList.Add(new NuGenXElementPresentException("The following components are not defined in the profile: " + extra.ToString()));
			}
			
			return toArray(exList);
		}
		
		/// <summary> Tests a composite against the corresponding section of a profile.</summary>
		/*public HL7Exception[] testComposite(Composite comp, AbstractComposite profile) {
		}*/
		
		/// <summary> Tests a primitive datatype against a profile.  Tests include
		/// length, datatype, whether the profile defines any children
		/// (this would indicate an error), constant value if defined.
		/// Table values are not verified.
		/// </summary>
		/*public Hl7Exception[] testPrimitive(Primitive, AbstractComponent profile) {
		
		}*/
		
		/// <summary>Returns true is there is content in the given structure </summary>
		private bool hasContent(Structure struct_Renamed)
		{
			if (typeof(Group).IsAssignableFrom(struct_Renamed.GetType()))
			{
				return hasContent((Group) struct_Renamed);
			}
			else if (typeof(Segment).IsAssignableFrom(struct_Renamed.GetType()))
			{
				return hasContent((Segment) struct_Renamed);
			}
			else
			{
				throw new NuGenHL7Exception("Structure " + struct_Renamed.GetType().FullName + " not recognized", NuGenHL7Exception.APPLICATION_INTERNAL_ERROR);
			}
		}
		
		/// <summary>Returns true is there is content in the given group </summary>
		private bool hasContent(Group group)
		{
			bool has = false;
			System.String encoded = NuGenPipeParser.encode(group, enc);
			if (encoded.IndexOf('|') >= 0)
				has = true;
			return has;
		}
		
		/// <summary>Returns true is there is content in the given segment </summary>
		private bool hasContent(Segment segment)
		{
			bool has = false;
			System.String encoded = NuGenPipeParser.encode(segment, enc);
			if (encoded != null && encoded.Length > 3)
				has = true;
			return has;
		}
		
		/// <summary>Returns true is there is content in the given type </summary>
        private bool hasContent(Genetibase.NuGenHL7.model.Type type)
		{
			bool has = false;
			System.String encoded = NuGenPipeParser.encode(type, enc);
			if (encoded != null && encoded.Length > 0)
				has = true;
			return has;
		}
		
		/// <summary>Appends an array of HL7 exceptions to a list </summary>
		private void  addToList(NuGenHL7Exception[] exceptions, System.Collections.ArrayList list)
		{
			for (int i = 0; i < exceptions.Length; i++)
			{
				list.Add(exceptions[i]);
			}
		}
		
		/// <summary>Returns the HL7 exceptions in the given arraylist in an array </summary>
		private NuGenHL7Exception[] toArray(System.Collections.ArrayList list)
		{
            NuGenHL7Exception[] retVal = new NuGenHL7Exception[list.Count];
            list.CopyTo(retVal);

            return retVal;
		}
		
		[STAThread]
		public static void  Main(System.String[] args)
		{
			
			if (args.Length != 2)
			{
				System.Console.Out.WriteLine("Usage: DefaultValidator message_file profile_file");
				System.Environment.Exit(1);
			}
			
			NuGenDefaultValidator val = new NuGenDefaultValidator();
			try
			{
				System.String msgString = loadFile(args[0]);
				NuGenParser parser = new NuGenGenericParser();
				Message message = parser.parse(msgString);
				
				System.String profileString = loadFile(args[1]);
				ProfileParser profParser = new ProfileParser(true);
				RuntimeProfile profile = profParser.parse(profileString);
				
				NuGenHL7Exception[] exceptions = val.validate(message, profile.Message);
				
				System.Console.Out.WriteLine("Exceptions: ");
				for (int i = 0; i < exceptions.Length; i++)
				{
					System.Console.Out.WriteLine((i + 1) + ". " + exceptions[i].Message);
				}
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		
		/// <summary>loads file at the given path </summary>
		private static System.String loadFile(System.String path)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(path);
			System.IO.StreamReader in_Renamed = new System.IO.StreamReader(new System.IO.StreamReader(file.FullName, System.Text.Encoding.Default).BaseStream, new System.IO.StreamReader(file.FullName, System.Text.Encoding.Default).CurrentEncoding);
			System.Text.StringBuilder buf = new System.Text.StringBuilder(5000);
			int c = - 1;
			while ((c = in_Renamed.Read()) != - 1)
			{
				buf.Append((char) c);
			}
			in_Renamed.Close();
			return buf.ToString();
		}
		static NuGenDefaultValidator()
		{
		}
	}
}