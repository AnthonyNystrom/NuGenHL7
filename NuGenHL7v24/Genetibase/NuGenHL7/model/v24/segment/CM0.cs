using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v24.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v24.segment
{
	
	/// <summary> <p>Represents an HL7 CM0 message segment. 
	/// This segment has the following fields:</p><p>
	/// CM0-1: Set ID - CM0 (SI)<br> 
	/// CM0-2: Sponsor Study ID (EI)<br> 
	/// CM0-3: Alternate Study ID (EI)<br> 
	/// CM0-4: Title of Study (ST)<br> 
	/// CM0-5: Chairman of Study (XCN)<br> 
	/// CM0-6: Last IRB Approval Date (DT)<br> 
	/// CM0-7: Total Accrual to Date (NM)<br> 
	/// CM0-8: Last Accrual Date (DT)<br> 
	/// CM0-9: Contact for Study (XCN)<br> 
	/// CM0-10: Contact's Telephone Number (XTN)<br> 
	/// CM0-11: Contact's Address (XAD)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class CM0:AbstractSegment
	{
		/// <summary> Returns Set ID - CM0 (CM0-1).</summary>
		virtual public SI SetIDCM0
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
		/// <summary> Returns Sponsor Study ID (CM0-2).</summary>
		virtual public EI SponsorStudyID
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
		/// <summary> Returns Title of Study (CM0-4).</summary>
		virtual public ST TitleOfStudy
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
		/// <summary> Returns Last IRB Approval Date (CM0-6).</summary>
		virtual public DT LastIRBApprovalDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns Total Accrual to Date (CM0-7).</summary>
		virtual public NM TotalAccrualToDate
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
		/// <summary> Returns Last Accrual Date (CM0-8).</summary>
		virtual public DT LastAccrualDate
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
		/// <summary> Returns Contact's Telephone Number (CM0-10).</summary>
		virtual public XTN ContactSTelephoneNumber
		{
			get
			{
				XTN ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (XTN) t;
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
		
		/// <summary> Creates a CM0 (Clinical Study Master) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public CM0(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(EI), true, 1, 60, new System.Object[]{message});
				this.add(typeof(EI), false, 3, 60, new System.Object[]{message});
				this.add(typeof(ST), true, 1, 300, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Alternate Study ID (CM0-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual EI getAlternateStudyID(int rep)
		{
			EI ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (EI) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Alternate Study ID (CM0-3).</summary>
		public virtual EI[] getAlternateStudyID()
		{
			EI[] ret = null;
			try
			{
				Type[] t = this.getField(3);
				ret = new EI[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (EI) t[i];
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
		
		/// <summary> Returns a single repetition of Chairman of Study (CM0-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getChairmanOfStudy(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Chairman of Study (CM0-5).</summary>
		public virtual XCN[] getChairmanOfStudy()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of Contact for Study (CM0-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getContactForStudy(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (XCN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact for Study (CM0-9).</summary>
		public virtual XCN[] getContactForStudy()
		{
			XCN[] ret = null;
			try
			{
				Type[] t = this.getField(9);
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
		
		/// <summary> Returns a single repetition of Contact's Address (CM0-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getContactSAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (XAD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Contact's Address (CM0-11).</summary>
		public virtual XAD[] getContactSAddress()
		{
			XAD[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XAD) t[i];
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