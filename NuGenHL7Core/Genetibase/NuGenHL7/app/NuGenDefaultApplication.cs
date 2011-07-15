/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "DefaultApplication.java".  Description: 
/// "An Application that does nothing with the message and returns an Application 
/// Reject message in response." 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2002.  All Rights Reserved. 
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
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Message = Genetibase.NuGenHL7.model.Message;
using Segment = Genetibase.NuGenHL7.model.Segment;
using Structure = Genetibase.NuGenHL7.model.Structure;
using CommonTS = Genetibase.NuGenHL7.model.primitive.CommonTS;
using SourceGenerator = Genetibase.NuGenHL7.sourcegen.NuGenSourceGenerator;
using MessageIDGenerator = Genetibase.NuGenHL7.util.NuGenMessageIDGenerator;
using Terser = Genetibase.NuGenHL7.util.NuGenTerser;
namespace Genetibase.NuGenHL7.app
{
	
	/// <summary> An Application that does nothing with the message and returns an Application 
	/// Reject message in response.  To be used when there are no other Applications 
	/// that can process a given message.  
	/// </summary>
	/// <author>   Bryan Tripp
	/// </author>
	public class NuGenDefaultApplication : NuGenApplication{
		/// <summary>Creates a new instance of DefaultApplication </summary>
		public NuGenDefaultApplication()
		{
		}
		
		/// <summary> Returns true.  </summary>
		public virtual bool canProcess(Message in_Renamed)
		{
			return true;
		}
		
		/// <summary> Creates and returns an acknowledgement -- the details are determined by fillDetails().</summary>
		public virtual Message processMessage(Message in_Renamed)
		{
			Message out_Renamed = null;
			try
			{
				//get default ACK
				out_Renamed = makeACK((Segment) in_Renamed.get_Renamed("MSH"));
				fillDetails(out_Renamed);
			}
			catch (System.Exception e)
			{
				throw new NuGenApplicationException("Couldn't create response message: " + e.Message);
			}
			return out_Renamed;
		}
		
		/// <summary> Fills in the details of an Application Reject message, including response and 
		/// error codes, and a text error message.  This is the method to override if you want
		/// to respond differently.  
		/// </summary>
		public virtual void  fillDetails(Message ack)
		{
			try
			{
				//populate MSA and ERR with generic error ... 
				Segment msa = (Segment) ack.get_Renamed("MSA");
				Terser.set_Renamed(msa, 1, 0, 1, 1, "AR");
				Terser.set_Renamed(msa, 3, 0, 1, 1, "No appropriate destination could be found to which this message could be routed.");
				//this is max length
				
				//populate ERR segment if it exists (may not depending on version)
				Structure s = ack.get_Renamed("ERR");
				if (s != null)
				{
					Segment err = (Segment) s;
					Terser.set_Renamed(err, 1, 0, 4, 1, "207");
					Terser.set_Renamed(err, 1, 0, 4, 2, "Application Internal Error");
					Terser.set_Renamed(err, 1, 0, 4, 3, "HL70357");
				}
			}
			catch (System.Exception e)
			{
				throw new NuGenApplicationException("Error trying to create Application Reject message: " + e.Message);
			}
		}
		
		/// <summary> Creates an ACK message with the minimum required information from an inbound message.  
		/// Optional fields can be filled in afterwards, before the message is returned.  Pleaase   
		/// note that MSH-10, the outbound message control ID, is also set using the class 
		/// <code>Genetibase.NuGenHL7.util.MessageIDGenerator</code>.  Also note that the ACK messages returned
		/// is the same version as the version stated in the inbound MSH if there is a generic ACK for that
		/// version, otherwise a version 2.4 ACK is returned. MSA-1 is set to AA by default.  
		/// 
		/// </summary>
		/// <param name="inboundHeader">the MSH segment if the inbound message
		/// </param>
		/// <throws>  IOException if there is a problem reading or writing the message ID file </throws>
		/// <throws>  DataTypeException if there is a problem setting ACK values </throws>
		public static Message makeACK(Segment inboundHeader)
		{
			if (!inboundHeader.getName().Equals("MSH"))
				throw new NuGenHL7Exception("Need an MSH segment to create a response ACK (got " + inboundHeader.getName() + ")");
			
			//make ACK of correct version
			System.String version = null;
			try
			{
				version = Terser.get_Renamed(inboundHeader, 12, 0, 1, 1);
			}
			catch (NuGenHL7Exception)
			{
				/* proceed with null */
			}
			if (version == null)
				version = "2.4";
			
			System.String ackClassName = SourceGenerator.getVersionPackageName(version) + "message.ACK";
			
			Message out_Renamed = null;
			try
			{
				System.Type ackClass = System.Type.GetType(ackClassName);
				out_Renamed = (Message) System.Activator.CreateInstance(ackClass);
			}
			catch (System.Exception e)
			{
				throw new NuGenHL7Exception("Can't instantiate ACK of class " + ackClassName + ": " + e.GetType().FullName);
			}
			Terser terser = new Terser(out_Renamed);
			
			//populate outbound MSH using data from inbound message ...             
			Segment outHeader = (Segment) out_Renamed.get_Renamed("MSH");
			fillResponseHeader(inboundHeader, outHeader);
			
			terser.set_Renamed("/MSH-9", "ACK");
			terser.set_Renamed("/MSH-12", version);
			terser.set_Renamed("/MSA-1", "AA");
			terser.set_Renamed("/MSA-2", Genetibase.NuGenHL7.util.NuGenTerser.get_Renamed(inboundHeader, 10, 0, 1, 1));
			
			return out_Renamed;
		}
		
		/// <summary> Populates certain required fields in a response message header, using 
		/// information from the corresponding inbound message.  The current time is 
		/// used for the message time field, and <code>MessageIDGenerator</code> is 
		/// used to create a unique message ID.  Version and message type fields are 
		/// not populated.  
		/// </summary>
		public static void  fillResponseHeader(Segment inbound, Segment outbound)
		{
			if (!inbound.getName().Equals("MSH") || !outbound.getName().Equals("MSH"))
				throw new NuGenHL7Exception("Need MSH segments.  Got " + inbound.getName() + " and " + outbound.getName());
			
			//get MSH data from incoming message ...        
			System.String encChars = Terser.get_Renamed(inbound, 2, 0, 1, 1);
			System.String fieldSep = Terser.get_Renamed(inbound, 1, 0, 1, 1);
			System.String procID = Terser.get_Renamed(inbound, 11, 0, 1, 1);
			
			//populate outbound MSH using data from inbound message ...                     
			Terser.set_Renamed(outbound, 2, 0, 1, 1, encChars);
			Terser.set_Renamed(outbound, 1, 0, 1, 1, fieldSep);
			System.Globalization.GregorianCalendar now = new System.Globalization.GregorianCalendar();
			SupportClass.CalendarManager.manager.SetDateTime(now, System.DateTime.Now);
			Terser.set_Renamed(outbound, 7, 0, 1, 1, CommonTS.toHl7TSFormat(now));
			Terser.set_Renamed(outbound, 10, 0, 1, 1, MessageIDGenerator.Instance.NewID);
			Terser.set_Renamed(outbound, 11, 0, 1, 1, procID);
		}
		static NuGenDefaultApplication()
		{
		}
	}
}