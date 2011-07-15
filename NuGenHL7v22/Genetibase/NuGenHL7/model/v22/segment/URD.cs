using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v22.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v22.segment
{
	
	/// <summary> <p>Represents an HL7 URD message segment. 
	/// This segment has the following fields:</p><p>
	/// URD-1: R/U date / time (TS)<br> 
	/// URD-2: Report Priority (ID)<br> 
	/// URD-3: R/U Who Subject Definition (ST)<br> 
	/// URD-4: R/U What Subject Definition (ID)<br> 
	/// URD-5: R/U What Department Code (ST)<br> 
	/// URD-6: R/U display / print locations (ST)<br> 
	/// URD-7: R/U Results Level (ID)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class URD:AbstractSegment
	{
		/// <summary> Returns R/U date / time (URD-1).</summary>
		virtual public TS RUDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		/// <summary> Returns Report Priority (URD-2).</summary>
		virtual public ID ReportPriority
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
		/// <summary> Returns R/U Results Level (URD-7).</summary>
		virtual public ID RUResultsLevel
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
		
		/// <summary> Creates a URD (RESULTS/UPDATE DEFINITION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public URD(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 109});
				this.add(typeof(ST), true, 0, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 3, new System.Object[]{message, 48});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 108});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of R/U Who Subject Definition (URD-3).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUWhoSubjectDefinition(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U Who Subject Definition (URD-3).</summary>
		public virtual ST[] getRUWhoSubjectDefinition()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(3);
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
		
		/// <summary> Returns a single repetition of R/U What Subject Definition (URD-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getRUWhatSubjectDefinition(int rep)
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
		
		/// <summary> Returns all repetitions of R/U What Subject Definition (URD-4).</summary>
		public virtual ID[] getRUWhatSubjectDefinition()
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
		
		/// <summary> Returns a single repetition of R/U What Department Code (URD-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUWhatDepartmentCode(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U What Department Code (URD-5).</summary>
		public virtual ST[] getRUWhatDepartmentCode()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
		
		/// <summary> Returns a single repetition of R/U display / print locations (URD-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUDisplayPrintLocations(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U display / print locations (URD-6).</summary>
		public virtual ST[] getRUDisplayPrintLocations()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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