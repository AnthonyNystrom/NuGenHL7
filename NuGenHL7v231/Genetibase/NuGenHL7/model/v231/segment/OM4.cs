using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 OM4 message segment. 
	/// This segment has the following fields:</p><p>
	/// OM4-1: Sequence Number - Test/Observation Master File (NM)<br> 
	/// OM4-2: Derived Specimen (ID)<br> 
	/// OM4-3: Container Description (TX)<br> 
	/// OM4-4: Container Volume (NM)<br> 
	/// OM4-5: Container Units (CE)<br> 
	/// OM4-6: Specimen (CE)<br> 
	/// OM4-7: Additive (CE)<br> 
	/// OM4-8: Preparation (TX)<br> 
	/// OM4-9: Special Handling Requirements (TX)<br> 
	/// OM4-10: Normal Collection Volume (CQ)<br> 
	/// OM4-11: Minimum Collection Volume (CQ)<br> 
	/// OM4-12: Specimen Requirements (TX)<br> 
	/// OM4-13: Specimen Priorities (ID)<br> 
	/// OM4-14: Specimen Retention Time (CQ)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OM4:AbstractSegment
	{
		/// <summary> Returns Sequence Number - Test/Observation Master File (OM4-1).</summary>
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
		/// <summary> Returns Derived Specimen (OM4-2).</summary>
		virtual public ID DerivedSpecimen
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Container Description (OM4-3).</summary>
		virtual public TX ContainerDescription
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Container Volume (OM4-4).</summary>
		virtual public NM ContainerVolume
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Container Units (OM4-5).</summary>
		virtual public CE ContainerUnits
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
		/// <summary> Returns Specimen (OM4-6).</summary>
		virtual public CE Specimen
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
		/// <summary> Returns Additive (OM4-7).</summary>
		virtual public CE Additive
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
		/// <summary> Returns Preparation (OM4-8).</summary>
		virtual public TX Preparation
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Special Handling Requirements (OM4-9).</summary>
		virtual public TX SpecialHandlingRequirements
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns Normal Collection Volume (OM4-10).</summary>
		virtual public CQ NormalCollectionVolume
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Minimum Collection Volume (OM4-11).</summary>
		virtual public CQ MinimumCollectionVolume
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Specimen Requirements (OM4-12).</summary>
		virtual public TX SpecimenRequirements
		{
			get
			{
				TX ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns Specimen Retention Time (OM4-14).</summary>
		virtual public CQ SpecimenRetentionTime
		{
			get
			{
				CQ ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		
		/// <summary> Creates a OM4 (OM4 - observations that require specimens segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OM4(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 170});
				this.add(typeof(TX), false, 1, 60, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 10240, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 10240, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
				this.add(typeof(TX), false, 1, 10240, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 27});
				this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Specimen Priorities (OM4-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getSpecimenPriorities(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specimen Priorities (OM4-13).</summary>
		public virtual ID[] getSpecimenPriorities()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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