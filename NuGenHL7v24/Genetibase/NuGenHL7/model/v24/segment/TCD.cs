using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 TCD message segment. 
	/// This segment has the following fields:</p><p>
	/// TCD-1: Universal Service Identifier (CE)<br> 
	/// TCD-2: Auto-Dilution Factor (SN)<br> 
	/// TCD-3: Rerun Dilution Factor (SN)<br> 
	/// TCD-4: Pre-Dilution Factor (SN)<br> 
	/// TCD-5: Endogenous Content of Pre-Dilution Diluent (SN)<br> 
	/// TCD-6: Automatic Repeat Allowed (ID)<br> 
	/// TCD-7: Reflex Allowed (ID)<br> 
	/// TCD-8: Analyte Repeat Status (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class TCD:AbstractSegment
	{
		/// <summary> Returns Universal Service Identifier (TCD-1).</summary>
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
		/// <summary> Returns Auto-Dilution Factor (TCD-2).</summary>
		virtual public SN AutoDilutionFactor
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns Rerun Dilution Factor (TCD-3).</summary>
		virtual public SN RerunDilutionFactor
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns Pre-Dilution Factor (TCD-4).</summary>
		virtual public SN PreDilutionFactor
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
		/// <summary> Returns Endogenous Content of Pre-Dilution Diluent (TCD-5).</summary>
		virtual public SN EndogenousContentOfPreDilutionDiluent
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
		/// <summary> Returns Automatic Repeat Allowed (TCD-6).</summary>
		virtual public ID AutomaticRepeatAllowed
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Reflex Allowed (TCD-7).</summary>
		virtual public ID ReflexAllowed
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
		/// <summary> Returns Analyte Repeat Status (TCD-8).</summary>
		virtual public CE AnalyteRepeatStatus
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
		
		/// <summary> Creates a TCD (Test Code Detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public TCD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}