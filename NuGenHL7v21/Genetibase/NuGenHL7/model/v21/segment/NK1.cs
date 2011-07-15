using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 NK1 message segment. 
	/// This segment has the following fields:</p><p>
	/// NK1-1: SET ID - NEXT OF KIN (SI)<br> 
	/// NK1-2: NEXT OF KIN NAME (PN)<br> 
	/// NK1-3: NEXT OF KIN RELATIONSHIP (ST)<br> 
	/// NK1-4: NEXT OF KIN - ADDRESS (AD)<br> 
	/// NK1-5: NEXT OF KIN - PHONE NUMBER (TN)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class NK1:AbstractSegment
	{
		/// <summary> Returns SET ID - NEXT OF KIN (NK1-1).</summary>
		virtual public SI SETIDNEXTOFKIN
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
		/// <summary> Returns NEXT OF KIN NAME (NK1-2).</summary>
		virtual public PN NEXTOFKINNAME
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		/// <summary> Returns NEXT OF KIN RELATIONSHIP (NK1-3).</summary>
		virtual public ST NEXTOFKINRELATIONSHIP
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		/// <summary> Returns NEXT OF KIN - ADDRESS (NK1-4).</summary>
		virtual public AD NEXTOFKINADDRESS
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (AD) t;
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
		
		/// <summary> Creates a NK1 (NEXT OF KIN) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public NK1(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(PN), false, 1, 48, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(TN), false, 0, 40, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of NEXT OF KIN - PHONE NUMBER (NK1-5).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getNEXTOFKINPHONENUMBER(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of NEXT OF KIN - PHONE NUMBER (NK1-5).</summary>
		public virtual TN[] getNEXTOFKINPHONENUMBER()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(5);
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
	}
}