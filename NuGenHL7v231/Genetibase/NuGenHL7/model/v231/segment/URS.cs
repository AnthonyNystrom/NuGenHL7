using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v231.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v231.segment
{
	
	/// <summary> <p>Represents an HL7 URS message segment. 
	/// This segment has the following fields:</p><p>
	/// URS-1: R/U Where Subject Definition (ST)<br> 
	/// URS-2: R/U When Data Start Date/Time (TS)<br> 
	/// URS-3: R/U When Data End Date/Time (TS)<br> 
	/// URS-4: R/U What User Qualifier (ST)<br> 
	/// URS-5: R/U Other Results Subject Definition (ST)<br> 
	/// URS-6: R/U Which Date/Time Qualifier (ID)<br> 
	/// URS-7: R/U Which Date/Time Status Qualifier (ID)<br> 
	/// URS-8: R/U Date/Time Selection Qualifier (ID)<br> 
	/// URS-9: R/U Quantity/Timing Qualifier (TQ)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class URS:AbstractSegment
	{
		/// <summary> Returns R/U When Data Start Date/Time (URS-2).</summary>
		virtual public TS RUWhenDataStartDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns R/U When Data End Date/Time (URS-3).</summary>
		virtual public TS RUWhenDataEndDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns R/U Quantity/Timing Qualifier (URS-9).</summary>
		virtual public TQ RUQuantityTimingQualifier
		{
			get
			{
				TQ ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (TQ) t;
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
		
		/// <summary> Creates a URS (URS - unsolicited selection segment) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public URS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 0, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 156});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 157});
				this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 158});
				this.add(typeof(TQ), false, 1, 60, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of R/U Where Subject Definition (URS-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUWhereSubjectDefinition(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(1, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U Where Subject Definition (URS-1).</summary>
		public virtual ST[] getRUWhereSubjectDefinition()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(1);
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
		
		/// <summary> Returns a single repetition of R/U What User Qualifier (URS-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUWhatUserQualifier(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U What User Qualifier (URS-4).</summary>
		public virtual ST[] getRUWhatUserQualifier()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(4);
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
		
		/// <summary> Returns a single repetition of R/U Other Results Subject Definition (URS-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUOtherResultsSubjectDefinition(int rep)
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
		
		/// <summary> Returns all repetitions of R/U Other Results Subject Definition (URS-5).</summary>
		public virtual ST[] getRUOtherResultsSubjectDefinition()
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
		
		/// <summary> Returns a single repetition of R/U Which Date/Time Qualifier (URS-6).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getRUWhichDateTimeQualifier(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U Which Date/Time Qualifier (URS-6).</summary>
		public virtual ID[] getRUWhichDateTimeQualifier()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(6);
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
		
		/// <summary> Returns a single repetition of R/U Which Date/Time Status Qualifier (URS-7).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getRUWhichDateTimeStatusQualifier(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U Which Date/Time Status Qualifier (URS-7).</summary>
		public virtual ID[] getRUWhichDateTimeStatusQualifier()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(7);
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
		
		/// <summary> Returns a single repetition of R/U Date/Time Selection Qualifier (URS-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ID getRUDateTimeSelectionQualifier(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (ID) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of R/U Date/Time Selection Qualifier (URS-8).</summary>
		public virtual ID[] getRUDateTimeSelectionQualifier()
		{
			ID[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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
	}
}