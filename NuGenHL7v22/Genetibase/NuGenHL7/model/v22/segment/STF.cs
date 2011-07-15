using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 STF message segment. 
	/// This segment has the following fields:</p><p>
	/// STF-1: STF - primary key value (CE)<br> 
	/// STF-2: Staff ID Code (CE)<br> 
	/// STF-3: Staff Name (PN)<br> 
	/// STF-4: Staff Type (ID)<br> 
	/// STF-5: Sex (ID)<br> 
	/// STF-6: Date of Birth (TS)<br> 
	/// STF-7: Active / inactive (ID)<br> 
	/// STF-8: Department (CE)<br> 
	/// STF-9: Service (CE)<br> 
	/// STF-10: Phone (TN)<br> 
	/// STF-11: Office / home address (AD)<br> 
	/// STF-12: Activation Date (CM_DIN)<br> 
	/// STF-13: Inactivation Date (CM_DIN)<br> 
	/// STF-14: Backup Person ID (CE)<br> 
	/// STF-15: E-mail Address (ST)<br> 
	/// STF-16: Preferred method of Contact (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class STF:AbstractSegment
	{
		/// <summary> Returns STF - primary key value (STF-1).</summary>
		virtual public CE STFPrimaryKeyValue
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
		/// <summary> Returns Staff Name (STF-3).</summary>
		virtual public PN StaffName
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (PN) t;
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
		/// <summary> Returns Sex (STF-5).</summary>
		virtual public ID Sex
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Date of Birth (STF-6).</summary>
		virtual public TS DateOfBirth
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
		/// <summary> Returns Active / inactive (STF-7).</summary>
		virtual public ID ActiveInactive
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
		/// <summary> Returns Preferred method of Contact (STF-16).</summary>
		virtual public ID PreferredMethodOfContact
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		
		/// <summary> Creates a STF (staff identification segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public STF(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 182});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 183});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(TN), false, 0, 40, new System.Object[]{message});
				this.add(typeof(AD), false, 2, 106, new System.Object[]{message});
				this.add(typeof(CM_DIN), false, 0, 19, new System.Object[]{message});
				this.add(typeof(CM_DIN), false, 0, 19, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 40, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 185});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Staff ID Code (STF-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getStaffIDCode(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Staff ID Code (STF-2).</summary>
		public virtual CE[] getStaffIDCode()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(2);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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
		
		/// <summary> Returns a single repetition of Staff Type (STF-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getStaffType(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Staff Type (STF-4).</summary>
		public virtual ID[] getStaffType()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of Department (STF-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getDepartment(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Department (STF-8).</summary>
		public virtual CE[] getDepartment()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(8);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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
		
		/// <summary> Returns a single repetition of Service (STF-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getService(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Service (STF-9).</summary>
		public virtual CE[] getService()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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
		
		/// <summary> Returns a single repetition of Phone (STF-10).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getPhone(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone (STF-10).</summary>
		public virtual TN[] getPhone()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(10);
				ret = new TN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (TN) t[i];
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
		
		/// <summary> Returns a single repetition of Office / home address (STF-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual AD getOfficeHomeAddress(int rep)
		{
			AD ret = null;
			try
			{
				Type t = this.getField(11, rep);
				ret = (AD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Office / home address (STF-11).</summary>
		public virtual AD[] getOfficeHomeAddress()
		{
			AD[] ret = null;
			try
			{
				Type[] t = this.getField(11);
				ret = new AD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (AD) t[i];
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
		
		/// <summary> Returns a single repetition of Activation Date (STF-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_DIN getActivationDate(int rep)
		{
			CM_DIN ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (CM_DIN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Activation Date (STF-12).</summary>
		public virtual CM_DIN[] getActivationDate()
		{
			CM_DIN[] ret = null;
			try
			{
				Type[] t = this.getField(12);
				ret = new CM_DIN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_DIN) t[i];
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
		
		/// <summary> Returns a single repetition of Inactivation Date (STF-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_DIN getInactivationDate(int rep)
		{
			CM_DIN ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (CM_DIN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Inactivation Date (STF-13).</summary>
		public virtual CM_DIN[] getInactivationDate()
		{
			CM_DIN[] ret = null;
			try
			{
				Type[] t = this.getField(13);
				ret = new CM_DIN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_DIN) t[i];
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
		
		/// <summary> Returns a single repetition of Backup Person ID (STF-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getBackupPersonID(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (CE) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Backup Person ID (STF-14).</summary>
		public virtual CE[] getBackupPersonID()
		{
			CE[] ret = null;
			try
			{
				Type[] t = this.getField(14);
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CE) t[i];
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
		
		/// <summary> Returns a single repetition of E-mail Address (STF-15).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getEMailAddress(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of E-mail Address (STF-15).</summary>
		public virtual ST[] getEMailAddress()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(15);
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