using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;

namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 PV2 message segment. 
	/// This segment has the following fields:</p><p>
	/// PV2-1: Prior Pending Location (CM_INTERNAL_LOCATION)<br> 
	/// PV2-2: Accommodation Code (CE)<br> 
	/// PV2-3: Admit Reason (CE)<br> 
	/// PV2-4: Transfer Reason (CE)<br> 
	/// PV2-5: Patient Valuables (ST)<br> 
	/// PV2-6: Patient Valuables Location (ST)<br> 
	/// PV2-7: Visit User Code (ID)<br> 
	/// PV2-8: Expected Admit Date (DT)<br> 
	/// PV2-9: Expected Discharge Date (DT)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PV2:AbstractSegment
	{
		/// <summary> Returns Prior Pending Location (PV2-1).</summary>
		virtual public CM_INTERNAL_LOCATION PriorPendingLocation
		{
			get
			{
				CM_INTERNAL_LOCATION ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (CM_INTERNAL_LOCATION) t;
				}
				catch (System.InvalidCastException )
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
		/// <summary> Returns Accommodation Code (PV2-2).</summary>
		virtual public CE AccommodationCode
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
		/// <summary> Returns Admit Reason (PV2-3).</summary>
		virtual public CE AdmitReason
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
		/// <summary> Returns Transfer Reason (PV2-4).</summary>
		virtual public CE TransferReason
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
		/// <summary> Returns Patient Valuables Location (PV2-6).</summary>
		virtual public ST PatientValuablesLocation
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Visit User Code (PV2-7).</summary>
		virtual public ID VisitUserCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Expected Admit Date (PV2-8).</summary>
		virtual public DT ExpectedAdmitDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (DT) t;
				}
				catch (System.InvalidCastException )
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
		/// <summary> Returns Expected Discharge Date (PV2-9).</summary>
		virtual public DT ExpectedDischargeDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (DT) t;
				}
				catch (System.InvalidCastException )
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
		
		/// <summary> Creates a PV2 (PATIENT VISIT - additional information) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PV2(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 25, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 130});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Patient Valuables (PV2-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getPatientValuables(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Valuables (PV2-5).</summary>
		public virtual ST[] getPatientValuables()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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