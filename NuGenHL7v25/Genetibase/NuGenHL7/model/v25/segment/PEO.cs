using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 PEO message segment. 
	/// This segment has the following fields:</p><p>
	/// PEO-1: Event Identifiers Used (CE)<br> 
	/// PEO-2: Event Symptom/Diagnosis Code (CE)<br> 
	/// PEO-3: Event Onset Date/Time (TS)<br> 
	/// PEO-4: Event Exacerbation Date/Time (TS)<br> 
	/// PEO-5: Event Improved Date/Time (TS)<br> 
	/// PEO-6: Event Ended Data/Time (TS)<br> 
	/// PEO-7: Event Location Occurred Address (XAD)<br> 
	/// PEO-8: Event Qualification (ID)<br> 
	/// PEO-9: Event Serious (ID)<br> 
	/// PEO-10: Event Expected (ID)<br> 
	/// PEO-11: Event Outcome (ID)<br> 
	/// PEO-12: Patient Outcome (ID)<br> 
	/// PEO-13: Event Description From Others (FT)<br> 
	/// PEO-14: Event From Original Reporter (FT)<br> 
	/// PEO-15: Event Description From Patient (FT)<br> 
	/// PEO-16: Event Description From Practitioner (FT)<br> 
	/// PEO-17: Event Description From Autopsy (FT)<br> 
	/// PEO-18: Cause Of Death (CE)<br> 
	/// PEO-19: Primary Observer Name (XPN)<br> 
	/// PEO-20: Primary Observer Address (XAD)<br> 
	/// PEO-21: Primary Observer Telephone (XTN)<br> 
	/// PEO-22: Primary Observer's Qualification (ID)<br> 
	/// PEO-23: Confirmation Provided By (ID)<br> 
	/// PEO-24: Primary Observer Aware Date/Time (TS)<br> 
	/// PEO-25: Primary Observer's identity May Be Divulged (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PEO:AbstractSegment
	{
		/// <summary> Returns Event Onset Date/Time (PEO-3).</summary>
		virtual public TS EventOnsetDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Event Exacerbation Date/Time (PEO-4).</summary>
		virtual public TS EventExacerbationDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Event Improved Date/Time (PEO-5).</summary>
		virtual public TS EventImprovedDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Event Ended Data/Time (PEO-6).</summary>
		virtual public TS EventEndedDataTime
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
		/// <summary> Returns Event Serious (PEO-9).</summary>
		virtual public ID EventSerious
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Event Expected (PEO-10).</summary>
		virtual public ID EventExpected
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Patient Outcome (PEO-12).</summary>
		virtual public ID PatientOutcome
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
		/// <summary> Returns Primary Observer's Qualification (PEO-22).</summary>
		virtual public ID PrimaryObserverSQualification
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Confirmation Provided By (PEO-23).</summary>
		virtual public ID ConfirmationProvidedBy
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		/// <summary> Returns Primary Observer Aware Date/Time (PEO-24).</summary>
		virtual public TS PrimaryObserverAwareDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(24, 0);
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
		/// <summary> Returns Primary Observer's identity May Be Divulged (PEO-25).</summary>
		virtual public ID PrimaryObserverSIdentityMayBeDivulged
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
		
		/// <summary> Creates a PEO (Product Experience Observation) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PEO(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 237});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 238});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 239});
				this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 240});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 241});
				this.add(typeof(FT), false, 0, 600, new System.Object[]{message});
				this.add(typeof(FT), false, 0, 600, new System.Object[]{message});
				this.add(typeof(FT), false, 0, 600, new System.Object[]{message});
				this.add(typeof(FT), false, 0, 600, new System.Object[]{message});
				this.add(typeof(FT), false, 0, 600, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 242});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 242});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 243});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Event Identifiers Used (PEO-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getEventIdentifiersUsed(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Identifiers Used (PEO-1).</summary>
		public virtual CE[] getEventIdentifiersUsed()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(1);
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
		
		/// <summary> Returns a single repetition of Event Symptom/Diagnosis Code (PEO-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getEventSymptomDiagnosisCode(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Symptom/Diagnosis Code (PEO-2).</summary>
		public virtual CE[] getEventSymptomDiagnosisCode()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(2);
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
		
		/// <summary> Returns a single repetition of Event Location Occurred Address (PEO-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getEventLocationOccurredAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Location Occurred Address (PEO-7).</summary>
		public virtual XAD[] getEventLocationOccurredAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of Event Qualification (PEO-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getEventQualification(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Qualification (PEO-8).</summary>
		public virtual ID[] getEventQualification()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
		
		/// <summary> Returns a single repetition of Event Outcome (PEO-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getEventOutcome(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Outcome (PEO-11).</summary>
		public virtual ID[] getEventOutcome()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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
		
		/// <summary> Returns a single repetition of Event Description From Others (PEO-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FT getEventDescriptionFromOthers(int rep)
		{
			FT ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (FT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Description From Others (PEO-13).</summary>
		public virtual FT[] getEventDescriptionFromOthers()
		{
			FT[] ret = null;
			try
			{
				Type[] t = this.getField(13);
				ret = new FT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FT) t[i];
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
		
		/// <summary> Returns a single repetition of Event From Original Reporter (PEO-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FT getEventFromOriginalReporter(int rep)
		{
			FT ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (FT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event From Original Reporter (PEO-14).</summary>
		public virtual FT[] getEventFromOriginalReporter()
		{
			FT[] ret = null;
			try
			{
				Type[] t = this.getField(14);
				ret = new FT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FT) t[i];
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
		
		/// <summary> Returns a single repetition of Event Description From Patient (PEO-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FT getEventDescriptionFromPatient(int rep)
		{
			FT ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (FT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Description From Patient (PEO-15).</summary>
		public virtual FT[] getEventDescriptionFromPatient()
		{
			FT[] ret = null;
			try
			{
				Type[] t = this.getField(15);
				ret = new FT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FT) t[i];
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
		
		/// <summary> Returns a single repetition of Event Description From Practitioner (PEO-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FT getEventDescriptionFromPractitioner(int rep)
		{
			FT ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (FT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Description From Practitioner (PEO-16).</summary>
		public virtual FT[] getEventDescriptionFromPractitioner()
		{
			FT[] ret = null;
			try
			{
				Type[] t = this.getField(16);
				ret = new FT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FT) t[i];
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
		
		/// <summary> Returns a single repetition of Event Description From Autopsy (PEO-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual FT getEventDescriptionFromAutopsy(int rep)
		{
			FT ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (FT) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Description From Autopsy (PEO-17).</summary>
		public virtual FT[] getEventDescriptionFromAutopsy()
		{
			FT[] ret = null;
			try
			{
				Type[] t = this.getField(17);
				ret = new FT[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (FT) t[i];
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
		
		/// <summary> Returns a single repetition of Cause Of Death (PEO-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getCauseOfDeath(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Cause Of Death (PEO-18).</summary>
		public virtual CE[] getCauseOfDeath()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(18);
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
		
		/// <summary> Returns a single repetition of Primary Observer Name (PEO-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XPN getPrimaryObserverName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (XPN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Primary Observer Name (PEO-19).</summary>
		public virtual XPN[] getPrimaryObserverName()
		{
			XPN[] ret = null;
			try
			{
				Type[] t = this.getField(19);
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XPN) t[i];
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
		
		/// <summary> Returns a single repetition of Primary Observer Address (PEO-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getPrimaryObserverAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Primary Observer Address (PEO-20).</summary>
		public virtual XAD[] getPrimaryObserverAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(20);
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
		
		/// <summary> Returns a single repetition of Primary Observer Telephone (PEO-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getPrimaryObserverTelephone(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Primary Observer Telephone (PEO-21).</summary>
		public virtual XTN[] getPrimaryObserverTelephone()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(21);
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
	}
}