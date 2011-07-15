using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 PCR message segment. 
	/// This segment has the following fields:</p><p>
	/// PCR-1: Implicated Product (CE)<br> 
	/// PCR-2: Generic Product (IS)<br> 
	/// PCR-3: Product Class (CE)<br> 
	/// PCR-4: Total Duration Of Therapy (CQ)<br> 
	/// PCR-5: Product Manufacture Date (TS)<br> 
	/// PCR-6: Product Expiration Date (TS)<br> 
	/// PCR-7: Product Implantation Date (TS)<br> 
	/// PCR-8: Product Explantation Date (TS)<br> 
	/// PCR-9: Single Use Device (IS)<br> 
	/// PCR-10: Indication For Product Use (CE)<br> 
	/// PCR-11: Product Problem (IS)<br> 
	/// PCR-12: Product Serial/Lot Number (ST)<br> 
	/// PCR-13: Product Available For Inspection (IS)<br> 
	/// PCR-14: Product Evaluation Performed (CE)<br> 
	/// PCR-15: Product Evaluation Status (CE)<br> 
	/// PCR-16: Product Evaluation Results (CE)<br> 
	/// PCR-17: Evaluated Product Source (ID)<br> 
	/// PCR-18: Date Product Returned To Manufacturer (TS)<br> 
	/// PCR-19: Device Operator Qualifications (ID)<br> 
	/// PCR-20: Relatedness Assessment (ID)<br> 
	/// PCR-21: Action Taken In Response To The Event (ID)<br> 
	/// PCR-22: Event Causality Observations (ID)<br> 
	/// PCR-23: Indirect Exposure Mechanism (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PCR:AbstractSegment
	{
		/// <summary> Returns Implicated Product (PCR-1).</summary>
		virtual public CE ImplicatedProduct
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Generic Product (PCR-2).</summary>
		virtual public IS GenericProduct
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
		/// <summary> Returns Product Class (PCR-3).</summary>
		virtual public CE ProductClass
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
		/// <summary> Returns Total Duration Of Therapy (PCR-4).</summary>
		virtual public CQ TotalDurationOfTherapy
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Product Manufacture Date (PCR-5).</summary>
		virtual public TS ProductManufactureDate
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
		/// <summary> Returns Product Expiration Date (PCR-6).</summary>
		virtual public TS ProductExpirationDate
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
		/// <summary> Returns Product Implantation Date (PCR-7).</summary>
		virtual public TS ProductImplantationDate
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
		/// <summary> Returns Product Explantation Date (PCR-8).</summary>
		virtual public TS ProductExplantationDate
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
		/// <summary> Returns Single Use Device (PCR-9).</summary>
		virtual public IS SingleUseDevice
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
		/// <summary> Returns Indication For Product Use (PCR-10).</summary>
		virtual public CE IndicationForProductUse
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
		/// <summary> Returns Product Problem (PCR-11).</summary>
		virtual public IS ProductProblem
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Product Available For Inspection (PCR-13).</summary>
		virtual public IS ProductAvailableForInspection
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		/// <summary> Returns Product Evaluation Performed (PCR-14).</summary>
		virtual public CE ProductEvaluationPerformed
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		/// <summary> Returns Product Evaluation Status (PCR-15).</summary>
		virtual public CE ProductEvaluationStatus
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
		/// <summary> Returns Product Evaluation Results (PCR-16).</summary>
		virtual public CE ProductEvaluationResults
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		/// <summary> Returns Evaluated Product Source (PCR-17).</summary>
		virtual public ID EvaluatedProductSource
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns Date Product Returned To Manufacturer (PCR-18).</summary>
		virtual public TS DateProductReturnedToManufacturer
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		/// <summary> Returns Device Operator Qualifications (PCR-19).</summary>
		virtual public ID DeviceOperatorQualifications
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
		/// <summary> Returns Relatedness Assessment (PCR-20).</summary>
		virtual public ID RelatednessAssessment
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		
		/// <summary> Creates a PCR (Possible Causal Relationship) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PCR(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 249});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 8, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 244});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 245});
				this.add(typeof(ST), false, 3, 30, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 246});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 248});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 242});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 250});
				this.add(typeof(ID), false, 6, 2, new System.Object[]{message, 251});
				this.add(typeof(ID), false, 6, 2, new System.Object[]{message, 252});
				this.add(typeof(ID), false, 3, 1, new System.Object[]{message, 253});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Product Serial/Lot Number (PCR-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getProductSerialLotNumber(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Product Serial/Lot Number (PCR-12).</summary>
		public virtual ST[] getProductSerialLotNumber()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(12);
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
		
		/// <summary> Returns a single repetition of Action Taken In Response To The Event (PCR-21).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getActionTakenInResponseToTheEvent(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(21, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Action Taken In Response To The Event (PCR-21).</summary>
		public virtual ID[] getActionTakenInResponseToTheEvent()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(21);
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
		
		/// <summary> Returns a single repetition of Event Causality Observations (PCR-22).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getEventCausalityObservations(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(22, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Event Causality Observations (PCR-22).</summary>
		public virtual ID[] getEventCausalityObservations()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(22);
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
		
		/// <summary> Returns a single repetition of Indirect Exposure Mechanism (PCR-23).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getIndirectExposureMechanism(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(23, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Indirect Exposure Mechanism (PCR-23).</summary>
		public virtual ID[] getIndirectExposureMechanism()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(23);
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
	}
}