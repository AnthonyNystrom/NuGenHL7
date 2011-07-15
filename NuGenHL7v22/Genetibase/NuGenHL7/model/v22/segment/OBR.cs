using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 OBR message segment. 
	/// This segment has the following fields:</p><p>
	/// OBR-1: Set ID - Observation Request (SI)<br> 
	/// OBR-2: Placer Order Number (CM_PLACER)<br> 
	/// OBR-3: Filler Order Number (CM_FILLER)<br> 
	/// OBR-4: Universal Service ID (CE)<br> 
	/// OBR-5: Priority (not used) (ID)<br> 
	/// OBR-6: Requested date / time (not used) (TS)<br> 
	/// OBR-7: Observation date / time (TS)<br> 
	/// OBR-8: Observation end date / time (TS)<br> 
	/// OBR-9: Collection Volume (CQ_QUANTITY)<br> 
	/// OBR-10: Collector Identifier (CN)<br> 
	/// OBR-11: Specimen action code (ID)<br> 
	/// OBR-12: Danger Code (CE)<br> 
	/// OBR-13: Relevant clinical information (ST)<br> 
	/// OBR-14: Specimen received date / time (TS)<br> 
	/// OBR-15: Specimen source (CM_SPS)<br> 
	/// OBR-16: Ordering Provider (CN)<br> 
	/// OBR-17: Order Callback Phone Number (TN)<br> 
	/// OBR-18: Placer field 1 (ST)<br> 
	/// OBR-19: Placer field 2 (ST)<br> 
	/// OBR-20: Filler Field 1 (ST)<br> 
	/// OBR-21: Filler Field 2 (ST)<br> 
	/// OBR-22: Results report / status change - date / time (TS)<br> 
	/// OBR-23: Charge to Practice (CM_MOC)<br> 
	/// OBR-24: Diagnostic service section ID (ID)<br> 
	/// OBR-25: Result Status (ID)<br> 
	/// OBR-26: Parent Result (CM_PARENT_RESULT)<br> 
	/// OBR-27: Quantity / timing (TQ)<br> 
	/// OBR-28: Result Copies To (CN)<br> 
	/// OBR-29: Parent Number (CM_EIP)<br> 
	/// OBR-30: Transportation Mode (ID)<br> 
	/// OBR-31: Reason for Study (CE)<br> 
	/// OBR-32: Principal Result Interpreter (CM_NDL)<br> 
	/// OBR-33: Assistant Result Interpreter (CM_NDL)<br> 
	/// OBR-34: Technician (CM_NDL)<br> 
	/// OBR-35: Transcriptionist (CM_NDL)<br> 
	/// OBR-36: Scheduled date / time (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OBR:AbstractSegment
	{
		/// <summary> Returns Set ID - Observation Request (OBR-1).</summary>
		virtual public SI SetIDObservationRequest
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
		virtual public CM_PLACER PlacerOrderNumber
		{
			get
			{
				CM_PLACER ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CM_PLACER) t;
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
		virtual public CM_FILLER FillerOrderNumber
		{
			get
			{
				CM_FILLER ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CM_FILLER) t;
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
		/// <summary> Returns Priority (not used) (OBR-5).</summary>
		virtual public ID PriorityNotused
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
		/// <summary> Returns Requested date / time (not used) (OBR-6).</summary>
		virtual public TS RequestedDateTimeNotused
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
		/// <summary> Returns Observation date / time (OBR-7).</summary>
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
		/// <summary> Returns Observation end date / time (OBR-8).</summary>
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
		/// <summary> Returns Collection Volume (OBR-9).</summary>
		virtual public CQ_QUANTITY CollectionVolume
		{
			get
			{
				CQ_QUANTITY ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (CQ_QUANTITY) t;
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
		/// <summary> Returns Specimen action code (OBR-11).</summary>
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
		/// <summary> Returns Relevant clinical information (OBR-13).</summary>
		virtual public ST RelevantClinicalInformation
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
		/// <summary> Returns Specimen received date / time (OBR-14).</summary>
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
		/// <summary> Returns Specimen source (OBR-15).</summary>
		virtual public CM_SPS SpecimenSource
		{
			get
			{
				CM_SPS ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (CM_SPS) t;
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
		/// <summary> Returns Ordering Provider (OBR-16).</summary>
		virtual public CN OrderingProvider
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(16, 0);
					ret = (CN) t;
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
		/// <summary> Returns Placer field 1 (OBR-18).</summary>
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
		/// <summary> Returns Placer field 2 (OBR-19).</summary>
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
		/// <summary> Returns Filler Field 1 (OBR-20).</summary>
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
		/// <summary> Returns Filler Field 2 (OBR-21).</summary>
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
		/// <summary> Returns Results report / status change - date / time (OBR-22).</summary>
		virtual public TS ResultsReportStatusChangeDateTime
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
		/// <summary> Returns Charge to Practice (OBR-23).</summary>
		virtual public CM_MOC ChargeToPractice
		{
			get
			{
				CM_MOC ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (CM_MOC) t;
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
		/// <summary> Returns Diagnostic service section ID (OBR-24).</summary>
		virtual public ID DiagnosticServiceSectionID
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
		/// <summary> Returns Result Status (OBR-25).</summary>
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
		/// <summary> Returns Parent Result (OBR-26).</summary>
		virtual public CM_PARENT_RESULT ParentResult
		{
			get
			{
				CM_PARENT_RESULT ret = null;
				try
				{
					Type t = this.getField(26, 0);
					ret = (CM_PARENT_RESULT) t;
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
		virtual public CM_EIP ParentNumber
		{
			get
			{
				CM_EIP ret = null;
				try
				{
					Type t = this.getField(29, 0);
					ret = (CM_EIP) t;
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
		/// <summary> Returns Principal Result Interpreter (OBR-32).</summary>
		virtual public CM_NDL PrincipalResultInterpreter
		{
			get
			{
				CM_NDL ret = null;
				try
				{
					Type t = this.getField(32, 0);
					ret = (CM_NDL) t;
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
		/// <summary> Returns Scheduled date / time (OBR-36).</summary>
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
		
		/// <summary> Creates a OBR (OBSERVATION REQUEST) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OBR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CM_PLACER), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CM_FILLER), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CQ_QUANTITY), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 65});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 300, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CM_SPS), false, 1, 300, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 80, new System.Object[]{message});
				this.add(typeof(TN), false, 2, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CM_MOC), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 74});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 123});
				this.add(typeof(CM_PARENT_RESULT), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TQ), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CN), false, 5, 150, new System.Object[]{message});
				this.add(typeof(CM_EIP), false, 1, 150, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 124});
				this.add(typeof(CE), false, 0, 300, new System.Object[]{message});
				this.add(typeof(CM_NDL), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CM_NDL), false, 0, 60, new System.Object[]{message});
				this.add(typeof(CM_NDL), false, 0, 60, new System.Object[]{message});
				this.add(typeof(CM_NDL), false, 0, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Collector Identifier (OBR-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CN getCollectorIdentifier(int rep)
		{
			CN ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (CN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Collector Identifier (OBR-10).</summary>
		public virtual CN[] getCollectorIdentifier()
		{
			CN[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new CN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CN) t[i];
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
		public virtual TN getOrderCallbackPhoneNumber(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Order Callback Phone Number (OBR-17).</summary>
		public virtual TN[] getOrderCallbackPhoneNumber()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(17);
				ret = new TN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TN) t[i];
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
		
		/// <summary> Returns a single repetition of Quantity / timing (OBR-27).</summary>
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
		
		/// <summary> Returns all repetitions of Quantity / timing (OBR-27).</summary>
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
		public virtual CN getResultCopiesTo(int rep)
		{
			CN ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (CN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Result Copies To (OBR-28).</summary>
		public virtual CN[] getResultCopiesTo()
		{
			CN[] ret = null;
			try
			{
				Type[] t = this.getField(28);
				ret = new CN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CN) t[i];
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
		
		/// <summary> Returns a single repetition of Assistant Result Interpreter (OBR-33).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_NDL getAssistantResultInterpreter(int rep)
		{
			CM_NDL ret = null;
			try
			{
				Type t = this.getField(33, rep);
				ret = (CM_NDL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Assistant Result Interpreter (OBR-33).</summary>
		public virtual CM_NDL[] getAssistantResultInterpreter()
		{
			CM_NDL[] ret = null;
			try
			{
				Type[] t = this.getField(33);
				ret = new CM_NDL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_NDL) t[i];
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
		
		/// <summary> Returns a single repetition of Technician (OBR-34).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_NDL getTechnician(int rep)
		{
			CM_NDL ret = null;
			try
			{
				Type t = this.getField(34, rep);
				ret = (CM_NDL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Technician (OBR-34).</summary>
		public virtual CM_NDL[] getTechnician()
		{
			CM_NDL[] ret = null;
			try
			{
				Type[] t = this.getField(34);
				ret = new CM_NDL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_NDL) t[i];
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
		
		/// <summary> Returns a single repetition of Transcriptionist (OBR-35).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_NDL getTranscriptionist(int rep)
		{
			CM_NDL ret = null;
			try
			{
				Type t = this.getField(35, rep);
				ret = (CM_NDL) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Transcriptionist (OBR-35).</summary>
		public virtual CM_NDL[] getTranscriptionist()
		{
			CM_NDL[] ret = null;
			try
			{
				Type[] t = this.getField(35);
				ret = new CM_NDL[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_NDL) t[i];
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