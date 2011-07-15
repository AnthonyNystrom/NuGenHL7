using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 OBR message segment. 
	/// This segment has the following fields:</p><p>
	/// OBR-1: SET ID - OBSERVATION REQUEST (SI)<br> 
	/// OBR-2: PLACER ORDER # (CM)<br> 
	/// OBR-3: FILLER ORDER # (CM)<br> 
	/// OBR-4: UNIVERSAL SERVICE IDENT. (CE)<br> 
	/// OBR-5: PRIORITY (ST)<br> 
	/// OBR-6: REQUESTED DATE-TIME (TS)<br> 
	/// OBR-7: OBSERVATION DATE/TIME (TS)<br> 
	/// OBR-8: OBSERVATION END DATE/TIME (TS)<br> 
	/// OBR-9: COLLECTION VOLUME (CQ)<br> 
	/// OBR-10: COLLECTOR IDENTIFIER (CN)<br> 
	/// OBR-11: SPECIMEN ACTION CODE (ST)<br> 
	/// OBR-12: DANGER CODE (CM)<br> 
	/// OBR-13: RELEVANT CLINICAL INFO. (ST)<br> 
	/// OBR-14: SPECIMEN RECEIVED DATE/TIME (TS)<br> 
	/// OBR-15: SPECIMEN SOURCE (CM)<br> 
	/// OBR-16: ORDERING PROVIDER (CN)<br> 
	/// OBR-17: ORDER CALL-BACK PHONE NUM (TN)<br> 
	/// OBR-18: PLACERS FIELD #1 (ST)<br> 
	/// OBR-19: PLACERS FIELD #2 (ST)<br> 
	/// OBR-20: FILLERS FIELD #1 (ST)<br> 
	/// OBR-21: FILLERS FIELD #2 (ST)<br> 
	/// OBR-22: RESULTS RPT/STATUS CHNG - DATE/T (TS)<br> 
	/// OBR-23: CHARGE TO PRACTICE (CM)<br> 
	/// OBR-24: DIAGNOSTIC SERV SECT ID (ID)<br> 
	/// OBR-25: RESULT STATUS (ID)<br> 
	/// OBR-26: LINKED RESULTS (CE)<br> 
	/// OBR-27: QUANTITY/TIMING (CM)<br> 
	/// OBR-28: RESULT COPIES TO (CN)<br> 
	/// OBR-29: PARENT ACCESSION # (CM)<br> 
	/// OBR-30: TRANSPORTATION MODE (ID)<br> 
	/// OBR-31: REASON FOR STUDY (CE)<br> 
	/// OBR-32: PRINCIPAL RESULT INTERPRETER (CN)<br> 
	/// OBR-33: ASSISTANT RESULT INTERPRETER (CN)<br> 
	/// OBR-34: TECHNICIAN (CN)<br> 
	/// OBR-35: TRANSCRIPTIONIST (CN)<br> 
	/// OBR-36: SCHEDULED - DATE/TIME (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OBR:AbstractSegment
	{
		/// <summary> Returns SET ID - OBSERVATION REQUEST (OBR-1).</summary>
		virtual public SI SETIDOBSERVATIONREQUEST
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
		/// <summary> Returns PLACER ORDER # (OBR-2).</summary>
		virtual public CM PLACERORDER
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CM) t;
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
		/// <summary> Returns FILLER ORDER # (OBR-3).</summary>
		virtual public CM FILLERORDER
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CM) t;
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
		/// <summary> Returns UNIVERSAL SERVICE IDENT. (OBR-4).</summary>
		virtual public CE UNIVERSALSERVICEIDENT
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
		/// <summary> Returns PRIORITY (OBR-5).</summary>
		virtual public ST PRIORITY
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns REQUESTED DATE-TIME (OBR-6).</summary>
		virtual public TS REQUESTEDDATETIME
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
		/// <summary> Returns OBSERVATION DATE/TIME (OBR-7).</summary>
		virtual public TS OBSERVATIONDATETIME
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
		/// <summary> Returns OBSERVATION END DATE/TIME (OBR-8).</summary>
		virtual public TS OBSERVATIONENDDATETIME
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
		/// <summary> Returns COLLECTION VOLUME (OBR-9).</summary>
		virtual public CQ COLLECTIONVOLUME
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
		/// <summary> Returns SPECIMEN ACTION CODE (OBR-11).</summary>
		virtual public ST SPECIMENACTIONCODE
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
		/// <summary> Returns DANGER CODE (OBR-12).</summary>
		virtual public CM DANGERCODE
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CM) t;
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
		/// <summary> Returns RELEVANT CLINICAL INFO. (OBR-13).</summary>
		virtual public ST RELEVANTCLINICALINFO
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
		/// <summary> Returns SPECIMEN RECEIVED DATE/TIME (OBR-14).</summary>
		virtual public TS SPECIMENRECEIVEDDATETIME
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
		/// <summary> Returns SPECIMEN SOURCE (OBR-15).</summary>
		virtual public CM SPECIMENSOURCE
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (CM) t;
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
		/// <summary> Returns PLACERS FIELD #1 (OBR-18).</summary>
		virtual public ST PLACERSFIELD1
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
		/// <summary> Returns PLACERS FIELD #2 (OBR-19).</summary>
		virtual public ST PLACERSFIELD2
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
		/// <summary> Returns FILLERS FIELD #1 (OBR-20).</summary>
		virtual public ST FILLERSFIELD1
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
		/// <summary> Returns FILLERS FIELD #2 (OBR-21).</summary>
		virtual public ST FILLERSFIELD2
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
		/// <summary> Returns RESULTS RPT/STATUS CHNG - DATE/T (OBR-22).</summary>
		virtual public TS RESULTSRPTSTATUSCHNGDATET
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
		/// <summary> Returns CHARGE TO PRACTICE (OBR-23).</summary>
		virtual public CM CHARGETOPRACTICE
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (CM) t;
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
		/// <summary> Returns DIAGNOSTIC SERV SECT ID (OBR-24).</summary>
		virtual public ID DIAGNOSTICSERVSECTID
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
		/// <summary> Returns RESULT STATUS (OBR-25).</summary>
		virtual public ID RESULTSTATUS
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
		/// <summary> Returns LINKED RESULTS (OBR-26).</summary>
		virtual public CE LINKEDRESULTS
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(26, 0);
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
		/// <summary> Returns PARENT ACCESSION # (OBR-29).</summary>
		virtual public CM PARENTACCESSION
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(29, 0);
					ret = (CM) t;
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
		/// <summary> Returns TRANSPORTATION MODE (OBR-30).</summary>
		virtual public ID TRANSPORTATIONMODE
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
		/// <summary> Returns PRINCIPAL RESULT INTERPRETER (OBR-32).</summary>
		virtual public CN PRINCIPALRESULTINTERPRETER
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(32, 0);
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
		/// <summary> Returns ASSISTANT RESULT INTERPRETER (OBR-33).</summary>
		virtual public CN ASSISTANTRESULTINTERPRETER
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(33, 0);
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
		/// <summary> Returns TECHNICIAN (OBR-34).</summary>
		virtual public CN TECHNICIAN
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(34, 0);
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
		/// <summary> Returns TRANSCRIPTIONIST (OBR-35).</summary>
		virtual public CN TRANSCRIPTIONIST
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(35, 0);
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
		/// <summary> Returns SCHEDULED - DATE/TIME (OBR-36).</summary>
		virtual public TS SCHEDULEDDATETIME
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
				this.add(typeof(CM), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 75, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 2, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 19, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 19, new System.Object[]{message});
				this.add(typeof(CQ), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 1, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 300, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 19, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 300, new System.Object[]{message});
				this.add(typeof(CN), false, 0, 60, new System.Object[]{message});
				this.add(typeof(TN), false, 2, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 19, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 74});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 123});
				this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CM), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CN), false, 5, 80, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 150, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 124});
				this.add(typeof(CE), false, 0, 300, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of COLLECTOR IDENTIFIER (OBR-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CN getCOLLECTORIDENTIFIER(int rep)
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
		
		/// <summary> Returns all repetitions of COLLECTOR IDENTIFIER (OBR-10).</summary>
		public virtual CN[] getCOLLECTORIDENTIFIER()
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
		
		/// <summary> Returns a single repetition of ORDERING PROVIDER (OBR-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CN getORDERINGPROVIDER(int rep)
		{
			CN ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (CN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of ORDERING PROVIDER (OBR-16).</summary>
		public virtual CN[] getORDERINGPROVIDER()
		{
			CN[] ret = null;
			try
			{
				Type[] t = this.getField(16);
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
		
		/// <summary> Returns a single repetition of ORDER CALL-BACK PHONE NUM (OBR-17).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getORDERCALLBACKPHONENUM(int rep)
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
		
		/// <summary> Returns all repetitions of ORDER CALL-BACK PHONE NUM (OBR-17).</summary>
		public virtual TN[] getORDERCALLBACKPHONENUM()
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
		
		/// <summary> Returns a single repetition of QUANTITY/TIMING (OBR-27).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM getQUANTITYTIMING(int rep)
		{
			CM ret = null;
			try
			{
				Type t = this.getField(27, rep);
				ret = (CM) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of QUANTITY/TIMING (OBR-27).</summary>
		public virtual CM[] getQUANTITYTIMING()
		{
			CM[] ret = null;
			try
			{
				Type[] t = this.getField(27);
				ret = new CM[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM) t[i];
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
		
		/// <summary> Returns a single repetition of RESULT COPIES TO (OBR-28).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CN getRESULTCOPIESTO(int rep)
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
		
		/// <summary> Returns all repetitions of RESULT COPIES TO (OBR-28).</summary>
		public virtual CN[] getRESULTCOPIESTO()
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
		
		/// <summary> Returns a single repetition of REASON FOR STUDY (OBR-31).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getREASONFORSTUDY(int rep)
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
		
		/// <summary> Returns all repetitions of REASON FOR STUDY (OBR-31).</summary>
		public virtual CE[] getREASONFORSTUDY()
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
	}
}