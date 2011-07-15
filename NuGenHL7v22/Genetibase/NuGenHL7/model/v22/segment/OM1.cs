using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 OM1 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM1-1: Segment Type ID (ST)<br> 
	/// OM1-2: Sequence Number - Test/ Observation Master File (NM)<br> 
	/// OM1-3: Producer's test / observation ID (CE)<br> 
	/// OM1-4: Permitted Data Types (ID)<br> 
	/// OM1-5: Specimen Required (ID)<br> 
	/// OM1-6: Producer ID (CE)<br> 
	/// OM1-7: Observation Description (TX)<br> 
	/// OM1-8: Other test / observation IDs for the observation (CE)<br> 
	/// OM1-9: Other Names (ST)<br> 
	/// OM1-10: Preferred Report Name for the Observation (ST)<br> 
	/// OM1-11: Preferred Short Name or Mnemonic for Observation (ST)<br> 
	/// OM1-12: Preferred Long Name for the Observation (ST)<br> 
	/// OM1-13: Orderability (ID)<br> 
	/// OM1-14: Identity of instrument used to perform this study (CE)<br> 
	/// OM1-15: Coded Representation of Method (CE)<br> 
	/// OM1-16: Portable (ID)<br> 
	/// OM1-17: Observation producing department / section (ID)<br> 
	/// OM1-18: Telephone Number of Section (TN)<br> 
	/// OM1-19: Nature of test / observation (ID)<br> 
	/// OM1-20: Report Subheader (CE)<br> 
	/// OM1-21: Report Display Order (ST)<br> 
	/// OM1-22: Date / time stamp for any change in definition for obs (TS)<br> 
	/// OM1-23: Effective date / time of change (TS)<br> 
	/// OM1-24: Typical Turn-around Time (NM)<br> 
	/// OM1-25: Processing Time (NM)<br> 
	/// OM1-26: Processing Priority (ID)<br> 
	/// OM1-27: Reporting Priority (ID)<br> 
	/// OM1-28: Outside Site(s) Where Observation may be Performed (CE)<br> 
	/// OM1-29: Address of Outside Site(s) (AD)<br> 
	/// OM1-30: Phone Number of Outside Site (TN)<br> 
	/// OM1-31: Confidentiality Code (ID)<br> 
	/// OM1-32: Observations required to interpret the observation (CE)<br> 
	/// OM1-33: Interpretation of Observations (TX)<br> 
	/// OM1-34: Contraindications to Observations (CE)<br> 
	/// OM1-35: Reflex tests / observations (CE)<br> 
	/// OM1-36: Rules that Trigger Reflex Testing (ST)<br> 
	/// OM1-37: Fixed Canned Message (CE)<br> 
	/// OM1-38: Patient Preparation (TX)<br> 
	/// OM1-39: Procedure Medication (CE)<br> 
	/// OM1-40: Factors that may affect the observation (TX)<br> 
	/// OM1-41: Test / observation performance schedule (ST)<br> 
	/// OM1-42: Description of Test Methods (TX)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM1:AbstractSegment
	{
		/// <summary> Returns Segment Type ID (OM1-1).</summary>
		virtual public ST SegmentTypeID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Sequence Number - Test/ Observation Master File (OM1-2).</summary>
		virtual public NM SequenceNumberTestObservationMasterFile
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Producer's test / observation ID (OM1-3).</summary>
		virtual public CE ProducerSTestObservationID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Specimen Required (OM1-5).</summary>
		virtual public ID SpecimenRequired
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
		/// <summary> Returns Producer ID (OM1-6).</summary>
		virtual public CE ProducerID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Observation Description (OM1-7).</summary>
		virtual public TX ObservationDescription
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (TX) t;
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
		/// <summary> Returns Other test / observation IDs for the observation (OM1-8).</summary>
		virtual public CE OtherTestObservationIDsForTheObservation
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Preferred Report Name for the Observation (OM1-10).</summary>
		virtual public ST PreferredReportNameForTheObservation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Preferred Short Name or Mnemonic for Observation (OM1-11).</summary>
		virtual public ST PreferredShortNameOrMnemonicForObservation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Preferred Long Name for the Observation (OM1-12).</summary>
		virtual public ST PreferredLongNameForTheObservation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Orderability (OM1-13).</summary>
		virtual public ID Orderability
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Portable (OM1-16).</summary>
		virtual public ID Portable
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Telephone Number of Section (OM1-18).</summary>
		virtual public TN TelephoneNumberOfSection
		{
			get
			{
				TN ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (TN) t;
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
		/// <summary> Returns Nature of test / observation (OM1-19).</summary>
		virtual public ID NatureOfTestObservation
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Report Subheader (OM1-20).</summary>
		virtual public CE ReportSubheader
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		/// <summary> Returns Report Display Order (OM1-21).</summary>
		virtual public ST ReportDisplayOrder
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
		/// <summary> Returns Date / time stamp for any change in definition for obs (OM1-22).</summary>
		virtual public TS DateTimeStampForAnyChangeInDefinitionForObs
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
		/// <summary> Returns Effective date / time of change (OM1-23).</summary>
		virtual public TS EffectiveDateTimeOfChange
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Typical Turn-around Time (OM1-24).</summary>
		virtual public NM TypicalTurnAroundTime
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Processing Time (OM1-25).</summary>
		virtual public NM ProcessingTime
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(25, 0);
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
		/// <summary> Returns Reporting Priority (OM1-27).</summary>
		virtual public ID ReportingPriority
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		/// <summary> Returns Confidentiality Code (OM1-31).</summary>
		virtual public ID ConfidentialityCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(31, 0);
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
		/// <summary> Returns Interpretation of Observations (OM1-33).</summary>
		virtual public TX InterpretationOfObservations
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(33, 0);
					ret = (TX) t;
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
		/// <summary> Returns Rules that Trigger Reflex Testing (OM1-36).</summary>
		virtual public ST RulesThatTriggerReflexTesting
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Patient Preparation (OM1-38).</summary>
		virtual public TX PatientPreparation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(38, 0);
					ret = (TX) t;
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
		/// <summary> Returns Procedure Medication (OM1-39).</summary>
		virtual public CE ProcedureMedication
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(39, 0);
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
		/// <summary> Returns Factors that may affect the observation (OM1-40).</summary>
		virtual public TX FactorsThatMayAffectTheObservation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(40, 0);
					ret = (TX) t;
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
		/// <summary> Returns Description of Test Methods (OM1-42).</summary>
		virtual public TX DescriptionOfTestMethods
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(42, 0);
					ret = (TX) t;
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
		
		/// <summary> Creates a OM1 (GENERAL - fields that apply to most observations) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), false, 1, 3, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 125});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), true, 0, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 0});
				this.add(typeof(TN), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 174});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 40, new System.Object[]{message, 168});
				this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 169});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(AD), false, 0, 1000, new System.Object[]{message});
				this.add(typeof(TN), false, 0, 400, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 177});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 65536, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 65536, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 65536, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 65536, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Permitted Data Types (OM1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getPermittedDataTypes(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Permitted Data Types (OM1-4).</summary>
		public virtual ID[] getPermittedDataTypes()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(4);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
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
		
		/// <summary> Returns a single repetition of Other Names (OM1-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getOtherNames(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Other Names (OM1-9).</summary>
		public virtual ST[] getOtherNames()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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
		
		/// <summary> Returns a single repetition of Identity of instrument used to perform this study (OM1-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getIdentityOfInstrumentUsedToPerformThisStudy(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Identity of instrument used to perform this study (OM1-14).</summary>
		public virtual CE[] getIdentityOfInstrumentUsedToPerformThisStudy()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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
		
		/// <summary> Returns a single repetition of Coded Representation of Method (OM1-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCodedRepresentationOfMethod(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Coded Representation of Method (OM1-15).</summary>
		public virtual CE[] getCodedRepresentationOfMethod()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
		
		/// <summary> Returns a single repetition of Observation producing department / section (OM1-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getObservationProducingDepartmentSection(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Observation producing department / section (OM1-17).</summary>
		public virtual ID[] getObservationProducingDepartmentSection()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(17);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
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
		
		/// <summary> Returns a single repetition of Processing Priority (OM1-26).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getProcessingPriority(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Processing Priority (OM1-26).</summary>
		public virtual ID[] getProcessingPriority()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(26);
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ID) t[i];
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
		
		/// <summary> Returns a single repetition of Outside Site(s) Where Observation may be Performed (OM1-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getOutsideSiteSWhereObservationMayBePerformed(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Outside Site(s) Where Observation may be Performed (OM1-28).</summary>
		public virtual CE[] getOutsideSiteSWhereObservationMayBePerformed()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(28);
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
		
		/// <summary> Returns a single repetition of Address of Outside Site(s) (OM1-29).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual AD getAddressOfOutsideSiteS(int rep)
		{
			AD ret = null;
			try
			{
				Type t = this.getField(29, rep);
				ret = (AD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Address of Outside Site(s) (OM1-29).</summary>
		public virtual AD[] getAddressOfOutsideSiteS()
		{
			AD[] ret = null;
			try
			{
				Type[] t = this.getField(29);
				ret = new AD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (AD) t[i];
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
		
		/// <summary> Returns a single repetition of Phone Number of Outside Site (OM1-30).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getPhoneNumberOfOutsideSite(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(30, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone Number of Outside Site (OM1-30).</summary>
		public virtual TN[] getPhoneNumberOfOutsideSite()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(30);
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
		
		/// <summary> Returns a single repetition of Observations required to interpret the observation (OM1-32).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getObservationsRequiredToInterpretTheObservation(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(32, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Observations required to interpret the observation (OM1-32).</summary>
		public virtual CE[] getObservationsRequiredToInterpretTheObservation()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(32);
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
		
		/// <summary> Returns a single repetition of Contraindications to Observations (OM1-34).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getContraindicationsToObservations(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(34, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contraindications to Observations (OM1-34).</summary>
		public virtual CE[] getContraindicationsToObservations()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(34);
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
		
		/// <summary> Returns a single repetition of Reflex tests / observations (OM1-35).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getReflexTestsObservations(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(35, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Reflex tests / observations (OM1-35).</summary>
		public virtual CE[] getReflexTestsObservations()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(35);
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
		
		/// <summary> Returns a single repetition of Fixed Canned Message (OM1-37).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getFixedCannedMessage(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(37, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Fixed Canned Message (OM1-37).</summary>
		public virtual CE[] getFixedCannedMessage()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(37);
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
		
		/// <summary> Returns a single repetition of Test / observation performance schedule (OM1-41).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getTestObservationPerformanceSchedule(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(41, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Test / observation performance schedule (OM1-41).</summary>
		public virtual ST[] getTestObservationPerformanceSchedule()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(41);
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (ST) t[i];
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