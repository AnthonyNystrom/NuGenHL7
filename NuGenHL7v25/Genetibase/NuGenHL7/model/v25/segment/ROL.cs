using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 ROL message segment. 
	/// This segment has the following fields:</p><p>
	/// ROL-1: Role Instance ID (EI)<br> 
	/// ROL-2: Action Code (ID)<br> 
	/// ROL-3: Role-ROL (CE)<br> 
	/// ROL-4: Role Person (XCN)<br> 
	/// ROL-5: Role Begin Date/Time (TS)<br> 
	/// ROL-6: Role End Date/Time (TS)<br> 
	/// ROL-7: Role Duration (CE)<br> 
	/// ROL-8: Role Action Reason (CE)<br> 
	/// ROL-9: Provider Type (CE)<br> 
	/// ROL-10: Organization Unit Type (CE)<br> 
	/// ROL-11: Office/Home Address/Birthplace (XAD)<br> 
	/// ROL-12: Phone (XTN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class ROL:AbstractSegment
	{
		/// <summary> Returns Role Instance ID (ROL-1).</summary>
		virtual public EI RoleInstanceID
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Action Code (ROL-2).</summary>
		virtual public ID ActionCode
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
		/// <summary> Returns Role-ROL (ROL-3).</summary>
		virtual public CE RoleROL
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
		/// <summary> Returns Role Begin Date/Time (ROL-5).</summary>
		virtual public TS RoleBeginDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns Role End Date/Time (ROL-6).</summary>
		virtual public TS RoleEndDateTime
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
		/// <summary> Returns Role Duration (ROL-7).</summary>
		virtual public CE RoleDuration
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
		/// <summary> Returns Role Action Reason (ROL-8).</summary>
		virtual public CE RoleActionReason
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
		/// <summary> Returns Organization Unit Type (ROL-10).</summary>
		virtual public CE OrganizationUnitType
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
		
		/// <summary> Creates a ROL (Role) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public ROL(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(EI), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 287});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(XCN), true, 0, 250, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Role Person (ROL-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XCN getRolePerson(int rep)
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
		
		/// <summary> Returns all repetitions of Role Person (ROL-4).</summary>
		public virtual XCN[] getRolePerson()
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
		
		/// <summary> Returns a single repetition of Provider Type (ROL-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getProviderType(int rep)
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
		
		/// <summary> Returns all repetitions of Provider Type (ROL-9).</summary>
		public virtual CE[] getProviderType()
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
		
		/// <summary> Returns a single repetition of Office/Home Address/Birthplace (ROL-11).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XAD getOfficeHomeAddressBirthplace(int rep)
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
		
		/// <summary> Returns all repetitions of Office/Home Address/Birthplace (ROL-11).</summary>
		public virtual XAD[] getOfficeHomeAddressBirthplace()
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
		
		/// <summary> Returns a single repetition of Phone (ROL-12).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual XTN getPhone(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(12, rep);
				ret = (XTN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Phone (ROL-12).</summary>
		public virtual XTN[] getPhone()
		{
			XTN[] ret = null;
			try
			{
				Type[] t = this.getField(12);
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (XTN) t[i];
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