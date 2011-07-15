using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 ARQ message segment. 
	/// This segment has the following fields:</p><p>
	/// ARQ-1: Placer Appointment ID (EI)<br> 
	/// ARQ-2: Filler Appointment ID (EI)<br> 
	/// ARQ-3: Occurrence Number (NM)<br> 
	/// ARQ-4: Placer Group Number (EI)<br> 
	/// ARQ-5: Schedule ID (CE)<br> 
	/// ARQ-6: Request Event Reason (CE)<br> 
	/// ARQ-7: Appointment Reason (CE)<br> 
	/// ARQ-8: Appointment Type (CE)<br> 
	/// ARQ-9: Appointment Duration (NM)<br> 
	/// ARQ-10: Appointment Duration Units (CE)<br> 
	/// ARQ-11: Requested Start Date/Time Range (DR)<br> 
	/// ARQ-12: Priority-ARQ (ST)<br> 
	/// ARQ-13: Repeating Interval (RI)<br> 
	/// ARQ-14: Repeating Interval Duration (ST)<br> 
	/// ARQ-15: Placer Contact Person (XCN)<br> 
	/// ARQ-16: Placer Contact Phone Number (XTN)<br> 
	/// ARQ-17: Placer Contact Address (XAD)<br> 
	/// ARQ-18: Placer Contact Location (PL)<br> 
	/// ARQ-19: Entered By Person (XCN)<br> 
	/// ARQ-20: Entered By Phone Number (XTN)<br> 
	/// ARQ-21: Entered by Location (PL)<br> 
	/// ARQ-22: Parent Placer Appointment ID (EI)<br> 
	/// ARQ-23: Parent Filler Appointment ID (EI)<br> 
	/// ARQ-24: Placer Order Number (EI)<br> 
	/// ARQ-25: Filler Order Number (EI)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ARQ:AbstractSegment
	{
		/// <summary> Returns Placer Appointment ID (ARQ-1).</summary>
		virtual public EI PlacerAppointmentID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Filler Appointment ID (ARQ-2).</summary>
		virtual public EI FillerAppointmentID
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
		/// <summary> Returns Occurrence Number (ARQ-3).</summary>
		virtual public NM OccurrenceNumber
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Placer Group Number (ARQ-4).</summary>
		virtual public EI PlacerGroupNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Schedule ID (ARQ-5).</summary>
		virtual public CE ScheduleID
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
		/// <summary> Returns Request Event Reason (ARQ-6).</summary>
		virtual public CE RequestEventReason
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
		/// <summary> Returns Appointment Reason (ARQ-7).</summary>
		virtual public CE AppointmentReason
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
		/// <summary> Returns Appointment Type (ARQ-8).</summary>
		virtual public CE AppointmentType
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
		/// <summary> Returns Appointment Duration (ARQ-9).</summary>
		virtual public NM AppointmentDuration
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Appointment Duration Units (ARQ-10).</summary>
		virtual public CE AppointmentDurationUnits
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Priority-ARQ (ARQ-12).</summary>
		virtual public ST PriorityARQ
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
		/// <summary> Returns Repeating Interval (ARQ-13).</summary>
		virtual public RI RepeatingInterval
		{
			get
			{
				RI ret = null;
				try
				{
					Type t = this.getField(13, 0);
					ret = (RI) t;
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
		/// <summary> Returns Repeating Interval Duration (ARQ-14).</summary>
		virtual public ST RepeatingIntervalDuration
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Placer Contact Location (ARQ-18).</summary>
		virtual public PL PlacerContactLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (PL) t;
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
		/// <summary> Returns Entered by Location (ARQ-21).</summary>
		virtual public PL EnteredByLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (PL) t;
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
		/// <summary> Returns Parent Placer Appointment ID (ARQ-22).</summary>
		virtual public EI ParentPlacerAppointmentID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		/// <summary> Returns Parent Filler Appointment ID (ARQ-23).</summary>
		virtual public EI ParentFillerAppointmentID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		
		/// <summary> Creates a ARQ (Appointment Request) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ARQ(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(EI), true, 1, 75, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DR), false, 0, 53, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 5, new System.Object[]{message});
				this.add(typeof(RI), false, 1, 100, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 5, new System.Object[]{message});
				this.add(typeof(XCN), true, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(XCN), true, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
				this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
				this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Requested Start Date/Time Range (ARQ-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DR getRequestedStartDateTimeRange(int rep)
		{
			DR ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (DR) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Requested Start Date/Time Range (ARQ-11).</summary>
		public virtual DR[] getRequestedStartDateTimeRange()
		{
			DR[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new DR[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (DR) t[i];
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
		
		/// <summary> Returns a single repetition of Placer Contact Person (ARQ-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getPlacerContactPerson(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Placer Contact Person (ARQ-15).</summary>
		public virtual XCN[] getPlacerContactPerson()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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
		
		/// <summary> Returns a single repetition of Placer Contact Phone Number (ARQ-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getPlacerContactPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Placer Contact Phone Number (ARQ-16).</summary>
		public virtual XTN[] getPlacerContactPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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
		
		/// <summary> Returns a single repetition of Placer Contact Address (ARQ-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getPlacerContactAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Placer Contact Address (ARQ-17).</summary>
		public virtual XAD[] getPlacerContactAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(17);
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
		
		/// <summary> Returns a single repetition of Entered By Person (ARQ-19).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getEnteredByPerson(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Entered By Person (ARQ-19).</summary>
		public virtual XCN[] getEnteredByPerson()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(19);
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
		
		/// <summary> Returns a single repetition of Entered By Phone Number (ARQ-20).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getEnteredByPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(20, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Entered By Phone Number (ARQ-20).</summary>
		public virtual XTN[] getEnteredByPhoneNumber()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(20);
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
		
		/// <summary> Returns a single repetition of Placer Order Number (ARQ-24).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EI getPlacerOrderNumber(int rep)
		{
			EI ret = null;
			try
			{
				Type t = this.getField(24, rep);
				ret = (EI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Placer Order Number (ARQ-24).</summary>
		public virtual EI[] getPlacerOrderNumber()
		{
			EI[] ret = null;
			try
			{
				Type[] t = this.getField(24);
				ret = new EI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EI) t[i];
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
		
		/// <summary> Returns a single repetition of Filler Order Number (ARQ-25).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EI getFillerOrderNumber(int rep)
		{
			EI ret = null;
			try
			{
				Type t = this.getField(25, rep);
				ret = (EI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Filler Order Number (ARQ-25).</summary>
		public virtual EI[] getFillerOrderNumber()
		{
			EI[] ret = null;
			try
			{
				Type[] t = this.getField(25);
				ret = new EI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EI) t[i];
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