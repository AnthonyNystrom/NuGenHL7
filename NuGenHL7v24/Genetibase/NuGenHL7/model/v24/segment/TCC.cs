using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 TCC message segment. 
	/// This segment has the following fields:</p><p>
	/// TCC-1: Universal Service Identifier (CE)<br> 
	/// TCC-2: Test Application Identifier (EI)<br> 
	/// TCC-3: Specimen Source (SPS)<br> 
	/// TCC-4: Auto-Dilution Factor Default (SN)<br> 
	/// TCC-5: Rerun Dilution Factor Default (SN)<br> 
	/// TCC-6: Pre-Dilution Factor Default (SN)<br> 
	/// TCC-7: Endogenous Content of Pre-Dilution Diluent (SN)<br> 
	/// TCC-8: Inventory Limits Warning Level (NM)<br> 
	/// TCC-9: Automatic Rerun Allowed (ID)<br> 
	/// TCC-10: Automatic Repeat Allowed (ID)<br> 
	/// TCC-11: Automatic Reflex Allowed (ID)<br> 
	/// TCC-12: Equipment Dynamic Range (SN)<br> 
	/// TCC-13: Units (CE)<br> 
	/// TCC-14: Processing Type (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class TCC:AbstractSegment
	{
		/// <summary> Returns Universal Service Identifier (TCC-1).</summary>
		virtual public CE UniversalServiceIdentifier
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
		/// <summary> Returns Test Application Identifier (TCC-2).</summary>
		virtual public EI TestApplicationIdentifier
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
		/// <summary> Returns Specimen Source (TCC-3).</summary>
		virtual public SPS SpecimenSource
		{
			get
			{
				SPS ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (SPS) t;
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
		/// <summary> Returns Auto-Dilution Factor Default (TCC-4).</summary>
		virtual public SN AutoDilutionFactorDefault
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (SN) t;
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
		/// <summary> Returns Rerun Dilution Factor Default (TCC-5).</summary>
		virtual public SN RerunDilutionFactorDefault
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (SN) t;
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
		/// <summary> Returns Pre-Dilution Factor Default (TCC-6).</summary>
		virtual public SN PreDilutionFactorDefault
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (SN) t;
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
		/// <summary> Returns Endogenous Content of Pre-Dilution Diluent (TCC-7).</summary>
		virtual public SN EndogenousContentOfPreDilutionDiluent
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (SN) t;
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
		/// <summary> Returns Inventory Limits Warning Level (TCC-8).</summary>
		virtual public NM InventoryLimitsWarningLevel
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Automatic Rerun Allowed (TCC-9).</summary>
		virtual public ID AutomaticRerunAllowed
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
		/// <summary> Returns Automatic Repeat Allowed (TCC-10).</summary>
		virtual public ID AutomaticRepeatAllowed
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
		/// <summary> Returns Automatic Reflex Allowed (TCC-11).</summary>
		virtual public ID AutomaticReflexAllowed
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Equipment Dynamic Range (TCC-12).</summary>
		virtual public SN EquipmentDynamicRange
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (SN) t;
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
		/// <summary> Returns Units (TCC-13).</summary>
		virtual public CE Units
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
		/// <summary> Returns Processing Type (TCC-14).</summary>
		virtual public CE ProcessingType
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
		
		/// <summary> Creates a TCC (Test Code Configuration) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public TCC(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(EI), true, 1, 80, new System.Object[]{message});
				this.add(typeof(SPS), false, 1, 300, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}