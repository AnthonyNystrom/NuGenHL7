using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 OBX message segment. 
	/// This segment has the following fields:</p><p>
	/// OBX-1: SET ID - OBSERVATION SIMPLE (SI)<br> 
	/// OBX-2: VALUE TYPE (ID)<br> 
	/// OBX-3: OBSERVATION IDENTIFIER (CE)<br> 
	/// OBX-4: OBSERVATION SUB-ID (NM)<br> 
	/// OBX-5: OBSERVATION RESULTS (varies)<br> 
	/// OBX-6: UNITS (ID)<br> 
	/// OBX-7: REFERENCES RANGE (ST)<br> 
	/// OBX-8: ABNORMAL FLAGS (ST)<br> 
	/// OBX-9: PROBABILITY (NM)<br> 
	/// OBX-10: NATURE OF ABNORMAL TEST (ID)<br> 
	/// OBX-11: OBSERV RESULT STATUS (ID)<br> 
	/// OBX-12: DATE LAST OBS NORMAL VALUES (TS)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class OBX:AbstractSegment
	{
		/// <summary> Returns SET ID - OBSERVATION SIMPLE (OBX-1).</summary>
		virtual public SI SETIDOBSERVATIONSIMPLE
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
		/// <summary> Returns VALUE TYPE (OBX-2).</summary>
		virtual public ID VALUETYPE
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
		/// <summary> Returns OBSERVATION IDENTIFIER (OBX-3).</summary>
		virtual public CE OBSERVATIONIDENTIFIER
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
		/// <summary> Returns OBSERVATION SUB-ID (OBX-4).</summary>
		virtual public NM OBSERVATIONSUBID
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		/// <summary> Returns OBSERVATION RESULTS (OBX-5).</summary>
		virtual public Varies OBSERVATIONRESULTS
		{
			get
			{
				Varies ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (Varies) t;
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
		/// <summary> Returns UNITS (OBX-6).</summary>
		virtual public ID UNITS
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns REFERENCES RANGE (OBX-7).</summary>
		virtual public ST REFERENCESRANGE
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns PROBABILITY (OBX-9).</summary>
		virtual public NM PROBABILITY
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(9, 0);
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
		/// <summary> Returns NATURE OF ABNORMAL TEST (OBX-10).</summary>
		virtual public ID NATUREOFABNORMALTEST
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		/// <summary> Returns OBSERV RESULT STATUS (OBX-11).</summary>
		virtual public ID OBSERVRESULTSTATUS
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns DATE LAST OBS NORMAL VALUES (OBX-12).</summary>
		virtual public TS DATELASTOBSNORMALVALUES
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		
		/// <summary> Creates a OBX (RESULT) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public OBX(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 125});
				this.add(typeof(CE), true, 1, 80, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(Varies), true, 1, 65, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 0});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 5, 10, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 80});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 85});
				this.add(typeof(TS), false, 1, 19, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of ABNORMAL FLAGS (OBX-8).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual ST getABNORMALFLAGS(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(8, rep);
				ret = (ST) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of ABNORMAL FLAGS (OBX-8).</summary>
		public virtual ST[] getABNORMALFLAGS()
		{
			ST[] ret = null;
			try
			{
				Type[] t = this.getField(8);
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