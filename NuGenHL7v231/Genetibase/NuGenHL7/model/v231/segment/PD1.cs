using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 PD1 message segment. 
	/// This segment has the following fields:</p><p>
	/// PD1-1: Living Dependency (IS)<br> 
	/// PD1-2: Living Arrangement (IS)<br> 
	/// PD1-3: Patient Primary Facility (XON)<br> 
	/// PD1-4: Patient Primary Care Provider Name & ID No. (XCN)<br> 
	/// PD1-5: Student Indicator (IS)<br> 
	/// PD1-6: Handicap (IS)<br> 
	/// PD1-7: Living Will (IS)<br> 
	/// PD1-8: Organ Donor (IS)<br> 
	/// PD1-9: Separate Bill (ID)<br> 
	/// PD1-10: Duplicate Patient (CX)<br> 
	/// PD1-11: Publicity Code (CE)<br> 
	/// PD1-12: Protection Indicator (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PD1:AbstractSegment
	{
		/// <summary> Returns Living Arrangement (PD1-2).</summary>
		virtual public IS LivingArrangement
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
		/// <summary> Returns Student Indicator (PD1-5).</summary>
		virtual public IS StudentIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Handicap (PD1-6).</summary>
		virtual public IS Handicap
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
		/// <summary> Returns Living Will (PD1-7).</summary>
		virtual public IS LivingWill
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns Organ Donor (PD1-8).</summary>
		virtual public IS OrganDonor
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns Separate Bill (PD1-9).</summary>
		virtual public ID SeparateBill
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
		/// <summary> Returns Publicity Code (PD1-11).</summary>
		virtual public CE PublicityCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns Protection Indicator (PD1-12).</summary>
		virtual public ID ProtectionIndicator
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
		
		/// <summary> Creates a PD1 (PD1 - patient additional demographic segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PD1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 223});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220});
				this.add(typeof(XON), false, 0, 90, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 90, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 315});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 316});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CX), false, 0, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Living Dependency (PD1-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual IS getLivingDependency(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Living Dependency (PD1-1).</summary>
		public virtual IS[] getLivingDependency()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(1);
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (IS) t[i];
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
		
		/// <summary> Returns a single repetition of Patient Primary Facility (PD1-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XON getPatientPrimaryFacility(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (XON) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Primary Facility (PD1-3).</summary>
		public virtual XON[] getPatientPrimaryFacility()
		{
			XON[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new XON[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XON) t[i];
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
		
		/// <summary> Returns a single repetition of Patient Primary Care Provider Name & ID No. (PD1-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getPatientPrimaryCareProviderNameIDNo(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Patient Primary Care Provider Name & ID No. (PD1-4).</summary>
		public virtual XCN[] getPatientPrimaryCareProviderNameIDNo()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Duplicate Patient (PD1-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CX getDuplicatePatient(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (CX) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Duplicate Patient (PD1-10).</summary>
		public virtual CX[] getDuplicatePatient()
		{
			CX[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CX) t[i];
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