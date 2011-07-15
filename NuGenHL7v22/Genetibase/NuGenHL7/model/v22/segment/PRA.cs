using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 PRA message segment. 
	/// This segment has the following fields:</p><p>
	/// PRA-1: PRA - primary key value (ST)<br> 
	/// PRA-2: Practitioner group (CE)<br> 
	/// PRA-3: Practitioner Category (ID)<br> 
	/// PRA-4: Provider Billing (ID)<br> 
	/// PRA-5: Specialty (CM_SPD)<br> 
	/// PRA-6: Practitioner ID Numbers (CM_PLN)<br> 
	/// PRA-7: Privileges (CM_PIP)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PRA:AbstractSegment
	{
		/// <summary> Returns PRA - primary key value (PRA-1).</summary>
		virtual public ST PRAPrimaryKeyValue
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Provider Billing (PRA-4).</summary>
		virtual public ID ProviderBilling
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
		
		/// <summary> Creates a PRA (practitioner detail) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PRA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 3, new System.Object[]{message, 186});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 187});
				this.add(typeof(CM_SPD), false, 0, 100, new System.Object[]{message});
				this.add(typeof(CM_PLN), false, 0, 100, new System.Object[]{message});
				this.add(typeof(CM_PIP), false, 0, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Practitioner group (PRA-2).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CE getPractitionerGroup(int rep)
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
		
		/// <summary> Returns all repetitions of Practitioner group (PRA-2).</summary>
		public virtual CE[] getPractitionerGroup()
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
		
		/// <summary> Returns a single repetition of Practitioner Category (PRA-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getPractitionerCategory(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Practitioner Category (PRA-3).</summary>
		public virtual ID[] getPractitionerCategory()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Specialty (PRA-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_SPD getSpecialty(int rep)
		{
			CM_SPD ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (CM_SPD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specialty (PRA-5).</summary>
		public virtual CM_SPD[] getSpecialty()
		{
			CM_SPD[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new CM_SPD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_SPD) t[i];
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
		
		/// <summary> Returns a single repetition of Practitioner ID Numbers (PRA-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_PLN getPractitionerIDNumbers(int rep)
		{
			CM_PLN ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (CM_PLN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Practitioner ID Numbers (PRA-6).</summary>
		public virtual CM_PLN[] getPractitionerIDNumbers()
		{
			CM_PLN[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new CM_PLN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_PLN) t[i];
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
		
		/// <summary> Returns a single repetition of Privileges (PRA-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual CM_PIP getPrivileges(int rep)
		{
			CM_PIP ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (CM_PIP) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Privileges (PRA-7).</summary>
		public virtual CM_PIP[] getPrivileges()
		{
			CM_PIP[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new CM_PIP[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (CM_PIP) t[i];
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