using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 PR1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PR1-1: Set ID - PR1 (SI)<br> 
	/// PR1-2: Procedure Coding Method (IS)<br> 
	/// PR1-3: Procedure Code (CE)<br> 
	/// PR1-4: Procedure Description (ST)<br> 
	/// PR1-5: Procedure Date/Time (TS)<br> 
	/// PR1-6: Procedure Functional Type (IS)<br> 
	/// PR1-7: Procedure Minutes (NM)<br> 
	/// PR1-8: Anesthesiologist (XCN)<br> 
	/// PR1-9: Anesthesia Code (IS)<br> 
	/// PR1-10: Anesthesia Minutes (NM)<br> 
	/// PR1-11: Surgeon (XCN)<br> 
	/// PR1-12: Procedure Practitioner (XCN)<br> 
	/// PR1-13: Consent Code (CE)<br> 
	/// PR1-14: Procedure Priority (ID)<br> 
	/// PR1-15: Associated Diagnosis Code (CE)<br> 
	/// PR1-16: Procedure Code Modifier (CE)<br> 
	/// PR1-17: Procedure DRG Type (IS)<br> 
	/// PR1-18: Tissue Type Code (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PR1:AbstractSegment
	{
		/// <summary> Returns Set ID - PR1 (PR1-1).</summary>
		virtual public SI SetIDPR1
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
		/// <summary> Returns Procedure Coding Method (PR1-2).</summary>
		virtual public IS ProcedureCodingMethod
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Procedure Code (PR1-3).</summary>
		virtual public CE ProcedureCode
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
		/// <summary> Returns Procedure Description (PR1-4).</summary>
		virtual public ST ProcedureDescription
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Procedure Date/Time (PR1-5).</summary>
		virtual public TS ProcedureDateTime
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
		/// <summary> Returns Procedure Functional Type (PR1-6).</summary>
		virtual public IS ProcedureFunctionalType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Procedure Minutes (PR1-7).</summary>
		virtual public NM ProcedureMinutes
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Anesthesia Code (PR1-9).</summary>
		virtual public IS AnesthesiaCode
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Anesthesia Minutes (PR1-10).</summary>
		virtual public NM AnesthesiaMinutes
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Consent Code (PR1-13).</summary>
		virtual public CE ConsentCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Procedure Priority (PR1-14).</summary>
		virtual public ID ProcedurePriority
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Associated Diagnosis Code (PR1-15).</summary>
		virtual public CE AssociatedDiagnosisCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns Procedure DRG Type (PR1-17).</summary>
		virtual public IS ProcedureDRGType
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		
		/// <summary> Creates a PR1 (Procedures) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PR1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 89});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 230});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 19});
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 418});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 20, new System.Object[]{message, 416});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Anesthesiologist (PR1-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getAnesthesiologist(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Anesthesiologist (PR1-8).</summary>
		public virtual XCN[] getAnesthesiologist()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
		
		/// <summary> Returns a single repetition of Surgeon (PR1-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getSurgeon(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Surgeon (PR1-11).</summary>
		public virtual XCN[] getSurgeon()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(11);
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
		
		/// <summary> Returns a single repetition of Procedure Practitioner (PR1-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getProcedurePractitioner(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Procedure Practitioner (PR1-12).</summary>
		public virtual XCN[] getProcedurePractitioner()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(12);
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
		
		/// <summary> Returns a single repetition of Procedure Code Modifier (PR1-16).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProcedureCodeModifier(int rep)
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
		
		/// <summary> Returns all repetitions of Procedure Code Modifier (PR1-16).</summary>
		public virtual CE[] getProcedureCodeModifier()
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
		
		/// <summary> Returns a single repetition of Tissue Type Code (PR1-18).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getTissueTypeCode(int rep)
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
		
		/// <summary> Returns all repetitions of Tissue Type Code (PR1-18).</summary>
		public virtual CE[] getTissueTypeCode()
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
	}
}