using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 AFF message segment. 
	/// This segment has the following fields:</p><p>
	/// AFF-1: Set ID _ AFF (SI)<br> 
	/// AFF-2: Professional Organization (XON)<br> 
	/// AFF-3: Professional Organization Address (XAD)<br> 
	/// AFF-4: Professional Organization Affiliation Date Range (DR)<br> 
	/// AFF-5: Professional Affiliation Additional Information (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class AFF:AbstractSegment
	{
		/// <summary> Returns Set ID _ AFF (AFF-1).</summary>
		virtual public SI SetIDAFF
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
		/// <summary> Returns Professional Organization (AFF-2).</summary>
		virtual public XON ProfessionalOrganization
		{
			get
			{
				XON ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (XON) t;
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
		/// <summary> Returns Professional Organization Address (AFF-3).</summary>
		virtual public XAD ProfessionalOrganizationAddress
		{
			get
			{
				XAD ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (XAD) t;
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
		/// <summary> Returns Professional Affiliation Additional Information (AFF-5).</summary>
		virtual public ST ProfessionalAffiliationAdditionalInformation
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
		
		/// <summary> Creates a AFF (Professional Affiliation) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public AFF(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 60, new System.Object[]{message});
				this.add(typeof(XON), true, 1, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DR), false, 0, 52, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Professional Organization Affiliation Date Range (AFF-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual DR getProfessionalOrganizationAffiliationDateRange(int rep)
		{
			DR ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (DR) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Professional Organization Affiliation Date Range (AFF-4).</summary>
		public virtual DR[] getProfessionalOrganizationAffiliationDateRange()
		{
			DR[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
	}
}