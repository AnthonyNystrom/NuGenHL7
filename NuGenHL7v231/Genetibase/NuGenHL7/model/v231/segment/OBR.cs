using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 OBR message segment. 
	/// This segment has the following fields:</p><p>
	/// OBR-1: Set ID - OBR (SI)<br> 
	/// OBR-2: Placer Order Number (EI)<br> 
	/// OBR-3: Filler Order Number (EI)<br> 
	/// OBR-4: Universal Service ID (CE)<br> 
	/// OBR-5: Priority-OBR (ID)<br> 
	/// OBR-6: Requested Date/time (TS)<br> 
	/// OBR-7: Observation Date/Time # (TS)<br> 
	/// OBR-8: Observation End Date/Time # (TS)<br> 
	/// OBR-9: Collection Volume * (CQ)<br> 
	/// OBR-10: Collector Identifier * (XCN)<br> 
	/// OBR-11: Specimen Action Code * (ID)<br> 
	/// OBR-12: Danger Code (CE)<br> 
	/// OBR-13: Relevant Clinical Info. (ST)<br> 
	/// OBR-14: Specimen Received Date/Time * (TS)<br> 
	/// OBR-15: Specimen Source (SPS)<br> 
	/// OBR-16: Ordering Provider (XCN)<br> 
	/// OBR-17: Order Callback Phone Number (XTN)<br> 
	/// OBR-18: Placer Field 1 (ST)<br> 
	/// OBR-19: Placer Field 2 (ST)<br> 
	/// OBR-20: Filler Field 1 + (ST)<br> 
	/// OBR-21: Filler Field 2 + (ST)<br> 
	/// OBR-22: Results Rpt/Status Chng - Date/Time + (TS)<br> 
	/// OBR-23: Charge to Practice + (MOC)<br> 
	/// OBR-24: Diagnostic Serv Sect ID (ID)<br> 
	/// OBR-25: Result Status + (ID)<br> 
	/// OBR-26: Parent Result + (PRL)<br> 
	/// OBR-27: Quantity/Timing (TQ)<br> 
	/// OBR-28: Result Copies To (XCN)<br> 
	/// OBR-29: Parent Number (EIP)<br> 
	/// OBR-30: Transportation Mode (ID)<br> 
	/// OBR-31: Reason for Study (CE)<br> 
	/// OBR-32: Principal Result Interpreter + (NDL)<br> 
	/// OBR-33: Assistant Result Interpreter + (NDL)<br> 
	/// OBR-34: Technician + (NDL)<br> 
	/// OBR-35: Transcriptionist + (NDL)<br> 
	/// OBR-36: Scheduled Date/Time + (TS)<br> 
	/// OBR-37: Number of Sample Containers * (NM)<br> 
	/// OBR-38: Transport Logistics of Collected Sample * (CE)<br> 
	/// OBR-39: Collector’s Comment * (CE)<br> 
	/// OBR-40: Transport Arrangement Responsibility (CE)<br> 
	/// OBR-41: Transport Arranged (ID)<br> 
	/// OBR-42: Escort Required (ID)<br> 
	/// OBR-43: Planned Patient Transport Comment (CE)<br> 
	/// OBR-44: Procedure Code (CE)<br> 
	/// OBR-45: Procedure Code Modifier (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OBR:AbstractSegment
	{
		/// <summary> Returns Set ID - OBR (OBR-1).</summary>
		virtual public SI SetIDOBR
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Placer Order Number (OBR-2).</summary>
		virtual public EI PlacerOrderNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (EI) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Filler Order Number (OBR-3).</summary>
		virtual public EI FillerOrderNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (EI) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Universal Service ID (OBR-4).</summary>
		virtual public CE UniversalServiceID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Priority-OBR (OBR-5).</summary>
		virtual public ID PriorityOBR
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Requested Date/time (OBR-6).</summary>
		virtual public TS RequestedDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Observation Date/Time # (OBR-7).</summary>
		virtual public TS ObservationDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Observation End Date/Time # (OBR-8).</summary>
		virtual public TS ObservationEndDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Collection Volume * (OBR-9).</summary>
		virtual public CQ CollectionVolume
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (CQ) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Specimen Action Code * (OBR-11).</summary>
		virtual public ID SpecimenActionCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Danger Code (OBR-12).</summary>
		virtual public CE DangerCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Relevant Clinical Info. (OBR-13).</summary>
		virtual public ST RelevantClinicalInfo
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Specimen Received Date/Time * (OBR-14).</summary>
		virtual public TS SpecimenReceivedDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(14, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Specimen Source (OBR-15).</summary>
		virtual public SPS SpecimenSource
		{
			get
			{
				SPS ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (SPS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Placer Field 1 (OBR-18).</summary>
		virtual public ST PlacerField1
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Placer Field 2 (OBR-19).</summary>
		virtual public ST PlacerField2
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(19, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Filler Field 1 + (OBR-20).</summary>
		virtual public ST FillerField1
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Filler Field 2 + (OBR-21).</summary>
		virtual public ST FillerField2
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (ST) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Results Rpt/Status Chng - Date/Time + (OBR-22).</summary>
		virtual public TS ResultsRptStatusChngDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(22, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Charge to Practice + (OBR-23).</summary>
		virtual public MOC ChargeToPractice
		{
			get
			{
				MOC ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (MOC) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Diagnostic Serv Sect ID (OBR-24).</summary>
		virtual public ID DiagnosticServSectID
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(24, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Result Status + (OBR-25).</summary>
		virtual public ID ResultStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(25, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Parent Result + (OBR-26).</summary>
		virtual public PRL ParentResult
		{
			get
			{
				PRL ret = null;
				try
				{
					Type t = this.getField(26, 0);
					ret = (PRL) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Parent Number (OBR-29).</summary>
		virtual public EIP ParentNumber
		{
			get
			{
				EIP ret = null;
				try
				{
					Type t = this.getField(29, 0);
					ret = (EIP) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Transportation Mode (OBR-30).</summary>
		virtual public ID TransportationMode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(30, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Principal Result Interpreter + (OBR-32).</summary>
		virtual public NDL PrincipalResultInterpreter
		{
			get
			{
				NDL ret = null;
				try
				{
					Type t = this.getField(32, 0);
					ret = (NDL) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Scheduled Date/Time + (OBR-36).</summary>
		virtual public TS ScheduledDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(36, 0);
					ret = (TS) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Number of Sample Containers * (OBR-37).</summary>
		virtual public NM NumberOfSampleContainers
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(37, 0);
					ret = (NM) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Transport Arrangement Responsibility (OBR-40).</summary>
		virtual public CE TransportArrangementResponsibility
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(40, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Transport Arranged (OBR-41).</summary>
		virtual public ID TransportArranged
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(41, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Escort Required (OBR-42).</summary>
		virtual public ID EscortRequired
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(42, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Procedure Code (OBR-44).</summary>
		virtual public CE ProcedureCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(44, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a OBR (OBR - observation request segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OBR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 65});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 300, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(SPS), false, 1, 300, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 120, new System.Object[]{message});
				this.add(typeof(XTN), false, 2, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(MOC), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 74});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 123});
				this.add(typeof(PRL), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TQ), false, 0, 200, new System.Object[]{message});
				this.add(typeof(XCN), false, 5, 150, new System.Object[]{message});
				this.add(typeof(EIP), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 124});
				this.add(typeof(CE), false, 0, 300, new System.Object[]{message});
				this.add(typeof(NDL), false, 1, 200, new System.Object[]{message});
				this.add(typeof(NDL), false, 0, 200, new System.Object[]{message});
				this.add(typeof(NDL), false, 0, 200, new System.Object[]{message});
				this.add(typeof(NDL), false, 0, 200, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 30, new System.Object[]{message, 224});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 225});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 80, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Collector Identifier * (OBR-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getCollectorIdentifier(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Collector Identifier * (OBR-10).</summary>
		public virtual XCN[] getCollectorIdentifier()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Ordering Provider (OBR-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getOrderingProvider(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Ordering Provider (OBR-16).</summary>
		public virtual XCN[] getOrderingProvider()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Order Callback Phone Number (OBR-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getOrderCallbackPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Order Callback Phone Number (OBR-17).</summary>
		public virtual XTN[] getOrderCallbackPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(17);
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XTN) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Quantity/Timing (OBR-27).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TQ getQuantityTiming(int rep)
		{
			TQ ret = null;
			try
			{
				Type t = this.getField(27, rep);
				ret = (TQ) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Quantity/Timing (OBR-27).</summary>
		public virtual TQ[] getQuantityTiming()
		{
			TQ[] ret = null;
			try
			{
				Type[] t = this.getField(27);
				ret = new TQ[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TQ) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Result Copies To (OBR-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getResultCopiesTo(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Result Copies To (OBR-28).</summary>
		public virtual XCN[] getResultCopiesTo()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(28);
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XCN) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Reason for Study (OBR-31).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getReasonForStudy(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(31, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Reason for Study (OBR-31).</summary>
		public virtual CE[] getReasonForStudy()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(31);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Assistant Result Interpreter + (OBR-33).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NDL getAssistantResultInterpreter(int rep)
		{
			NDL ret = null;
			try
			{
				Type t = this.getField(33, rep);
				ret = (NDL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Assistant Result Interpreter + (OBR-33).</summary>
		public virtual NDL[] getAssistantResultInterpreter()
		{
			NDL[] ret = null;
			try
			{
				Type[] t = this.getField(33);
				ret = new NDL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NDL) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Technician + (OBR-34).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NDL getTechnician(int rep)
		{
			NDL ret = null;
			try
			{
				Type t = this.getField(34, rep);
				ret = (NDL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Technician + (OBR-34).</summary>
		public virtual NDL[] getTechnician()
		{
			NDL[] ret = null;
			try
			{
				Type[] t = this.getField(34);
				ret = new NDL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NDL) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Transcriptionist + (OBR-35).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual NDL getTranscriptionist(int rep)
		{
			NDL ret = null;
			try
			{
				Type t = this.getField(35, rep);
				ret = (NDL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Transcriptionist + (OBR-35).</summary>
		public virtual NDL[] getTranscriptionist()
		{
			NDL[] ret = null;
			try
			{
				Type[] t = this.getField(35);
				ret = new NDL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (NDL) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Transport Logistics of Collected Sample * (OBR-38).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getTransportLogisticsOfCollectedSample(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(38, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Transport Logistics of Collected Sample * (OBR-38).</summary>
		public virtual CE[] getTransportLogisticsOfCollectedSample()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(38);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Collector’s Comment * (OBR-39).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCollectorSComment(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(39, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Collector’s Comment * (OBR-39).</summary>
		public virtual CE[] getCollectorSComment()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(39);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Planned Patient Transport Comment (OBR-43).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getPlannedPatientTransportComment(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(43, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Planned Patient Transport Comment (OBR-43).</summary>
		public virtual CE[] getPlannedPatientTransportComment()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(43);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a single repetition of Procedure Code Modifier (OBR-45).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProcedureCodeModifier(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(45, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Procedure Code Modifier (OBR-45).</summary>
		public virtual CE[] getProcedureCodeModifier()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(45);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
				}
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
	}
}