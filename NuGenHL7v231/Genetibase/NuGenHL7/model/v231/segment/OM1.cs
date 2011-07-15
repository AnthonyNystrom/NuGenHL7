using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 OM1 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM1-1: Sequence Number - Test/Observation Master File (NM)<br> 
	/// OM1-2: Producer's Test/Observation ID (CE)<br> 
	/// OM1-3: Permitted Data Types (ID)<br> 
	/// OM1-4: Specimen Required (ID)<br> 
	/// OM1-5: Producer ID (CE)<br> 
	/// OM1-6: Observation Description (TX)<br> 
	/// OM1-7: Other Test/Observation IDs for the Observation (CE)<br> 
	/// OM1-8: Other Names (ST)<br> 
	/// OM1-9: Preferred Report Name for the Observation (ST)<br> 
	/// OM1-10: Preferred Short Name or Mnemonic for Observation (ST)<br> 
	/// OM1-11: Preferred Long Name for the Observation (ST)<br> 
	/// OM1-12: Orderability (ID)<br> 
	/// OM1-13: Identity of Instrument Used to Perform this Study (CE)<br> 
	/// OM1-14: Coded Representation of Method (CE)<br> 
	/// OM1-15: Portable (ID)<br> 
	/// OM1-16: Observation Producing Department/Section (CE)<br> 
	/// OM1-17: Telephone Number of Section (XTN)<br> 
	/// OM1-18: Nature of Test/Observation (IS)<br> 
	/// OM1-19: Report Subheader (CE)<br> 
	/// OM1-20: Report Display Order (ST)<br> 
	/// OM1-21: Date/Time Stamp for any change in Definition for the Observation (TS)<br> 
	/// OM1-22: Effective Date/Time of Change (TS)<br> 
	/// OM1-23: Typical Turn-Around Time (NM)<br> 
	/// OM1-24: Processing Time (NM)<br> 
	/// OM1-25: Processing Priority (ID)<br> 
	/// OM1-26: Reporting Priority (ID)<br> 
	/// OM1-27: Outside Site(s) Where Observation may be Performed (CE)<br> 
	/// OM1-28: Address of Outside Site(s) (XAD)<br> 
	/// OM1-29: Phone Number of Outside Site (XTN)<br> 
	/// OM1-30: Confidentiality Code (IS)<br> 
	/// OM1-31: Observations Required to Interpret the Obs (CE)<br> 
	/// OM1-32: Interpretation of Observations (TX)<br> 
	/// OM1-33: Contraindications to Observations (CE)<br> 
	/// OM1-34: Reflex Tests/Observations (CE)<br> 
	/// OM1-35: Rules that Trigger Reflex Testing (TX)<br> 
	/// OM1-36: Fixed Canned Message (CE)<br> 
	/// OM1-37: Patient Preparation (TX)<br> 
	/// OM1-38: Procedure Medication (CE)<br> 
	/// OM1-39: Factors that may Effect the Observation (TX)<br> 
	/// OM1-40: Test/Observation Performance Schedule (ST)<br> 
	/// OM1-41: Description of Test Methods (TX)<br> 
	/// OM1-42: Kind of Quantity Observed (CE)<br> 
	/// OM1-43: Point Versus Interval (CE)<br> 
	/// OM1-44: Challenge Information (TX)<br> 
	/// OM1-45: Relationship Modifier (CE)<br> 
	/// OM1-46: Target Anatomic Site Of Test (CE)<br> 
	/// OM1-47: Modality Of Imaging Measurement (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM1:AbstractSegment
	{
		/// <summary> Returns Sequence Number - Test/Observation Master File (OM1-1).</summary>
		virtual public NM SequenceNumberTestObservationMasterFile
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Producer's Test/Observation ID (OM1-2).</summary>
		virtual public CE ProducerSTestObservationID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Specimen Required (OM1-4).</summary>
		virtual public ID SpecimenRequired
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Producer ID (OM1-5).</summary>
		virtual public CE ProducerID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Observation Description (OM1-6).</summary>
		virtual public TX ObservationDescription
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Other Test/Observation IDs for the Observation (OM1-7).</summary>
		virtual public CE OtherTestObservationIDsForTheObservation
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Preferred Report Name for the Observation (OM1-9).</summary>
		virtual public ST PreferredReportNameForTheObservation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Preferred Short Name or Mnemonic for Observation (OM1-10).</summary>
		virtual public ST PreferredShortNameOrMnemonicForObservation
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
		/// <summary> Returns Preferred Long Name for the Observation (OM1-11).</summary>
		virtual public ST PreferredLongNameForTheObservation
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
		/// <summary> Returns Orderability (OM1-12).</summary>
		virtual public ID Orderability
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Portable (OM1-15).</summary>
		virtual public ID Portable
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Telephone Number of Section (OM1-17).</summary>
		virtual public XTN TelephoneNumberOfSection
		{
			get
			{
				XTN ret = null;
				try
				{
					Type t = this.getField(17, 0);
					ret = (XTN) t;
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
		/// <summary> Returns Nature of Test/Observation (OM1-18).</summary>
		virtual public IS NatureOfTestObservation
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (IS) t;
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
		/// <summary> Returns Report Subheader (OM1-19).</summary>
		virtual public CE ReportSubheader
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns Report Display Order (OM1-20).</summary>
		virtual public ST ReportDisplayOrder
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
		/// <summary> Returns Date/Time Stamp for any change in Definition for the Observation (OM1-21).</summary>
		virtual public TS DateTimeStampForAnyChangeInDefinitionForTheObservation
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		/// <summary> Returns Effective Date/Time of Change (OM1-22).</summary>
		virtual public TS EffectiveDateTimeOfChange
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
		/// <summary> Returns Typical Turn-Around Time (OM1-23).</summary>
		virtual public NM TypicalTurnAroundTime
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Processing Time (OM1-24).</summary>
		virtual public NM ProcessingTime
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
		/// <summary> Returns Reporting Priority (OM1-26).</summary>
		virtual public ID ReportingPriority
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns Phone Number of Outside Site (OM1-29).</summary>
		virtual public XTN PhoneNumberOfOutsideSite
		{
			get
			{
				XTN ret = null;
				try
				{
					Type t = this.getField(29, 0);
					ret = (XTN) t;
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
		/// <summary> Returns Confidentiality Code (OM1-30).</summary>
		virtual public IS ConfidentialityCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(30, 0);
					ret = (IS) t;
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
		/// <summary> Returns Observations Required to Interpret the Obs (OM1-31).</summary>
		virtual public CE ObservationsRequiredToInterpretTheObs
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(31, 0);
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
		/// <summary> Returns Interpretation of Observations (OM1-32).</summary>
		virtual public TX InterpretationOfObservations
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(32, 0);
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
		/// <summary> Returns Contraindications to Observations (OM1-33).</summary>
		virtual public CE ContraindicationsToObservations
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(33, 0);
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
		/// <summary> Returns Rules that Trigger Reflex Testing (OM1-35).</summary>
		virtual public TX RulesThatTriggerReflexTesting
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(35, 0);
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
		/// <summary> Returns Fixed Canned Message (OM1-36).</summary>
		virtual public CE FixedCannedMessage
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(36, 0);
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
		/// <summary> Returns Patient Preparation (OM1-37).</summary>
		virtual public TX PatientPreparation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(37, 0);
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
		/// <summary> Returns Procedure Medication (OM1-38).</summary>
		virtual public CE ProcedureMedication
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(38, 0);
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
		/// <summary> Returns Factors that may Effect the Observation (OM1-39).</summary>
		virtual public TX FactorsThatMayEffectTheObservation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(39, 0);
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
		/// <summary> Returns Description of Test Methods (OM1-41).</summary>
		virtual public TX DescriptionOfTestMethods
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(41, 0);
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
		/// <summary> Returns Kind of Quantity Observed (OM1-42).</summary>
		virtual public CE KindOfQuantityObserved
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(42, 0);
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
		/// <summary> Returns Point Versus Interval (OM1-43).</summary>
		virtual public CE PointVersusInterval
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(43, 0);
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
		/// <summary> Returns Challenge Information (OM1-44).</summary>
		virtual public TX ChallengeInformation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(44, 0);
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
		/// <summary> Returns Relationship Modifier (OM1-45).</summary>
		virtual public CE RelationshipModifier
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(45, 0);
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
		/// <summary> Returns Target Anatomic Site Of Test (OM1-46).</summary>
		virtual public CE TargetAnatomicSiteOfTest
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(46, 0);
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
		/// <summary> Returns Modality Of Imaging Measurement (OM1-47).</summary>
		virtual public CE ModalityOfImagingMeasurement
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(47, 0);
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
		
		/// <summary> Creates a OM1 (OM1 - general segment (fields that apply to most observations)) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 125});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 0, 1, new System.Object[]{message});
				this.add(typeof(XTN), false, 1, 40, new System.Object[]{message});
				this.add(typeof(IS), true, 1, 1, new System.Object[]{message, 174});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 40, new System.Object[]{message, 168});
				this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 169});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 1000, new System.Object[]{message});
				this.add(typeof(XTN), false, 1, 400, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 177});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 65536, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 65536, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 65536, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 65536, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Permitted Data Types (OM1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getPermittedDataTypes(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Permitted Data Types (OM1-3).</summary>
		public virtual ID[] getPermittedDataTypes()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Other Names (OM1-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getOtherNames(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Other Names (OM1-8).</summary>
		public virtual ST[] getOtherNames()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
		
		/// <summary> Returns a single repetition of Identity of Instrument Used to Perform this Study (OM1-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getIdentityOfInstrumentUsedToPerformThisStudy(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Identity of Instrument Used to Perform this Study (OM1-13).</summary>
		public virtual CE[] getIdentityOfInstrumentUsedToPerformThisStudy()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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
		
		/// <summary> Returns a single repetition of Coded Representation of Method (OM1-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCodedRepresentationOfMethod(int rep)
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
		
		/// <summary> Returns all repetitions of Coded Representation of Method (OM1-14).</summary>
		public virtual CE[] getCodedRepresentationOfMethod()
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
		
		/// <summary> Returns a single repetition of Observation Producing Department/Section (OM1-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getObservationProducingDepartmentSection(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Observation Producing Department/Section (OM1-16).</summary>
		public virtual CE[] getObservationProducingDepartmentSection()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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
		
		/// <summary> Returns a single repetition of Processing Priority (OM1-25).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getProcessingPriority(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(25, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Processing Priority (OM1-25).</summary>
		public virtual ID[] getProcessingPriority()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(25);
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
		
		/// <summary> Returns a single repetition of Outside Site(s) Where Observation may be Performed (OM1-27).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getOutsideSiteSWhereObservationMayBePerformed(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(27, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Outside Site(s) Where Observation may be Performed (OM1-27).</summary>
		public virtual CE[] getOutsideSiteSWhereObservationMayBePerformed()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(27);
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
		
		/// <summary> Returns a single repetition of Address of Outside Site(s) (OM1-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getAddressOfOutsideSiteS(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(28, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Address of Outside Site(s) (OM1-28).</summary>
		public virtual XAD[] getAddressOfOutsideSiteS()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(28);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
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
		
		/// <summary> Returns a single repetition of Reflex Tests/Observations (OM1-34).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getReflexTestsObservations(int rep)
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
		
		/// <summary> Returns all repetitions of Reflex Tests/Observations (OM1-34).</summary>
		public virtual CE[] getReflexTestsObservations()
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
		
		/// <summary> Returns a single repetition of Test/Observation Performance Schedule (OM1-40).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getTestObservationPerformanceSchedule(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(40, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Test/Observation Performance Schedule (OM1-40).</summary>
		public virtual ST[] getTestObservationPerformanceSchedule()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(40);
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