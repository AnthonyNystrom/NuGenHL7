using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 ORG message segment. 
	/// This segment has the following fields:</p><p>
	/// ORG-1: Set ID - ORG (SI)<br> 
	/// ORG-2: Organization Unit Code (CE)<br> 
	/// ORG-3: Organization Unit Type Code - ORG (CE)<br> 
	/// ORG-4: Primary Org Unit Indicator (ID)<br> 
	/// ORG-5: Practitioner Org Unit Identifier (CX)<br> 
	/// ORG-6: Health Care Provider Type Code (CE)<br> 
	/// ORG-7: Health Care Provider Classification Code (CE)<br> 
	/// ORG-8: Health Care Provider Area of Specialization Code (CE)<br> 
	/// ORG-9: Effective Date Range (DR)<br> 
	/// ORG-10: Employment Status Code (CE)<br> 
	/// ORG-11: Board Approval Indicator (ID)<br> 
	/// ORG-12: Primary Care Physician Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ORG:AbstractSegment
	{
		/// <summary> Returns Set ID - ORG (ORG-1).</summary>
		virtual public SI SetIDORG
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
		/// <summary> Returns Organization Unit Code (ORG-2).</summary>
		virtual public CE OrganizationUnitCode
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
		/// <summary> Returns Organization Unit Type Code - ORG (ORG-3).</summary>
		virtual public CE OrganizationUnitTypeCodeORG
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
		/// <summary> Returns Primary Org Unit Indicator (ORG-4).</summary>
		virtual public ID PrimaryOrgUnitIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns Practitioner Org Unit Identifier (ORG-5).</summary>
		virtual public CX PractitionerOrgUnitIdentifier
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CX) t;
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
		/// <summary> Returns Health Care Provider Type Code (ORG-6).</summary>
		virtual public CE HealthCareProviderTypeCode
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
		/// <summary> Returns Health Care Provider Classification Code (ORG-7).</summary>
		virtual public CE HealthCareProviderClassificationCode
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
		/// <summary> Returns Health Care Provider Area of Specialization Code (ORG-8).</summary>
		virtual public CE HealthCareProviderAreaOfSpecializationCode
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
		/// <summary> Returns Effective Date Range (ORG-9).</summary>
		virtual public DR EffectiveDateRange
		{
			get
			{
				DR ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (DR) t;
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
		/// <summary> Returns Employment Status Code (ORG-10).</summary>
		virtual public CE EmploymentStatusCode
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
		/// <summary> Returns Board Approval Indicator (ORG-11).</summary>
		virtual public ID BoardApprovalIndicator
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
		/// <summary> Returns Primary Care Physician Indicator (ORG-12).</summary>
		virtual public ID PrimaryCarePhysicianIndicator
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
		
		/// <summary> Creates a ORG (Practitioner Organization Unit) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ORG(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CX), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DR), false, 1, 52, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 2, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}