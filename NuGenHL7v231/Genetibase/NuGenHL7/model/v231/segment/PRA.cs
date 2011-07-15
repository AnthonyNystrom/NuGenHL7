using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 PRA message segment. 
	/// This segment has the following fields:</p><p>
	/// PRA-1: Primary Key Value - PRA (CE)<br> 
	/// PRA-2: Practitioner Group (CE)<br> 
	/// PRA-3: Practitioner Category (IS)<br> 
	/// PRA-4: Provider Billing (ID)<br> 
	/// PRA-5: Specialty (SPD)<br> 
	/// PRA-6: Practitioner ID Numbers (PLN)<br> 
	/// PRA-7: Privileges (PIP)<br> 
	/// PRA-8: Date Entered Practice (DT)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PRA:AbstractSegment
	{
		/// <summary> Returns Primary Key Value - PRA (PRA-1).</summary>
		virtual public CE PrimaryKeyValuePRA
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
		/// <summary> Returns Date Entered Practice (PRA-8).</summary>
		virtual public DT DateEnteredPractice
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
		
		/// <summary> Creates a PRA (PRA - practitioner detail segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PRA(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 186});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 187});
				this.add(typeof(SPD), false, 0, 100, new System.Object[]{message});
				this.add(typeof(PLN), false, 0, 100, new System.Object[]{message});
				this.add(typeof(PIP), false, 0, 200, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of Practitioner Group (PRA-2).</summary>
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
		
		/// <summary> Returns all repetitions of Practitioner Group (PRA-2).</summary>
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
		public virtual IS getPractitionerCategory(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (IS) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Practitioner Category (PRA-3).</summary>
		public virtual IS[] getPractitionerCategory()
		{
			IS[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of Specialty (PRA-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual SPD getSpecialty(int rep)
		{
			SPD ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (SPD) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Specialty (PRA-5).</summary>
		public virtual SPD[] getSpecialty()
		{
			SPD[] ret = null;
			try
			{
				Type[] t = this.getField(5);
				ret = new SPD[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (SPD) t[i];
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
		public virtual PLN getPractitionerIDNumbers(int rep)
		{
			PLN ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (PLN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Practitioner ID Numbers (PRA-6).</summary>
		public virtual PLN[] getPractitionerIDNumbers()
		{
			PLN[] ret = null;
			try
			{
				Type[] t = this.getField(6);
				ret = new PLN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PLN) t[i];
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
		public virtual PIP getPrivileges(int rep)
		{
			PIP ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (PIP) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of Privileges (PRA-7).</summary>
		public virtual PIP[] getPrivileges()
		{
			PIP[] ret = null;
			try
			{
				Type[] t = this.getField(7);
				ret = new PIP[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PIP) t[i];
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