using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 URS message segment. 
	/// This segment has the following fields:</p><p>
	/// URS-1: R/U WHERE SUBJECT DEFINITION (ST)<br> 
	/// URS-2: R/U WHEN DATA START DATE/TIME (TS)<br> 
	/// URS-3: R/U WHEN DATA END DATE/TIME (TS)<br> 
	/// URS-4: R/U WHAT USER QUALIFIER (ST)<br> 
	/// URS-5: R/U OTHER RESULTS SUBJECT DEFINI (ST)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class URS:AbstractSegment
	{
		/// <summary> Returns R/U WHEN DATA START DATE/TIME (URS-2).</summary>
		virtual public TS RUWHENDATASTARTDATETIME
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
		/// <summary> Returns R/U WHEN DATA END DATE/TIME (URS-3).</summary>
		virtual public TS RUWHENDATAENDDATETIME
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
		
		/// <summary> Creates a URS (UNSOLICITED SELECTION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public URS(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(ST), true, 0, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of R/U WHERE SUBJECT DEFINITION (URS-1).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUWHERESUBJECTDEFINITION(int rep)
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
		
		/// <summary> Returns all repetitions of R/U WHERE SUBJECT DEFINITION (URS-1).</summary>
		public virtual ST[] getRUWHERESUBJECTDEFINITION()
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
		
		/// <summary> Returns a single repetition of R/U WHAT USER QUALIFIER (URS-4).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUWHATUSERQUALIFIER(int rep)
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
		
		/// <summary> Returns all repetitions of R/U WHAT USER QUALIFIER (URS-4).</summary>
		public virtual ST[] getRUWHATUSERQUALIFIER()
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
		
		/// <summary> Returns a single repetition of R/U OTHER RESULTS SUBJECT DEFINI (URS-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getRUOTHERRESULTSSUBJECTDEFINI(int rep)
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
		
		/// <summary> Returns all repetitions of R/U OTHER RESULTS SUBJECT DEFINI (URS-5).</summary>
		public virtual ST[] getRUOTHERRESULTSSUBJECTDEFINI()
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
	}
}