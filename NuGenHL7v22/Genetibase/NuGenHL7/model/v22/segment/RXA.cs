using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 RXA message segment. 
	/// This segment has the following fields:</p><p>
	/// RXA-1: Give Sub-ID Counter (NM)<br> 
	/// RXA-2: Administration Sub-ID Counter (NM)<br> 
	/// RXA-3: Date / time start of administration (TS)<br> 
	/// RXA-4: Date / time end of administration (TS)<br> 
	/// RXA-5: Administered Code (CE)<br> 
	/// RXA-6: Administered Amount (NM)<br> 
	/// RXA-7: Administered Units (CE)<br> 
	/// RXA-8: Administered Dosage Form (CE)<br> 
	/// RXA-9: Administration Notes (ST)<br> 
	/// RXA-10: Administering Provider (CN)<br> 
	/// RXA-11: Administered-at Location (CM_LA1)<br> 
	/// RXA-12: Administered Per (Time Unit) (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class RXA:AbstractSegment
	{
		/// <summary> Returns Give Sub-ID Counter (RXA-1).</summary>
		virtual public NM GiveSubIDCounter
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
		/// <summary> Returns Administration Sub-ID Counter (RXA-2).</summary>
		virtual public NM AdministrationSubIDCounter
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
		/// <summary> Returns Date / time start of administration (RXA-3).</summary>
		virtual public TS DateTimeStartOfAdministration
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
		/// <summary> Returns Date / time end of administration (RXA-4).</summary>
		virtual public TS DateTimeEndOfAdministration
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
		/// <summary> Returns Administered Code (RXA-5).</summary>
		virtual public CE AdministeredCode
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
		/// <summary> Returns Administered Amount (RXA-6).</summary>
		virtual public NM AdministeredAmount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Administered Units (RXA-7).</summary>
		virtual public CE AdministeredUnits
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
		/// <summary> Returns Administered Dosage Form (RXA-8).</summary>
		virtual public CE AdministeredDosageForm
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
		/// <summary> Returns Administration Notes (RXA-9).</summary>
		virtual public ST AdministrationNotes
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
		/// <summary> Returns Administering Provider (RXA-10).</summary>
		virtual public CN AdministeringProvider
		{
			get
			{
				CN ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns Administered-at Location (RXA-11).</summary>
		virtual public CM_LA1 AdministeredAtLocation
		{
			get
			{
				CM_LA1 ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CM_LA1) t;
				}
				catch (System.InvalidCastException )
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
		/// <summary> Returns Administered Per (Time Unit) (RXA-12).</summary>
		virtual public ST AdministeredPerTimeUnit
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
		
		/// <summary> Creates a RXA (PHARMACY AADMINISTRATION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public RXA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 100, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CN), false, 1, 200, new System.Object[]{message});
				this.add(typeof(CM_LA1), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}