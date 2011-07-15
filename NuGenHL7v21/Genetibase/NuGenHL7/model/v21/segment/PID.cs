using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v21.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v21.segment
{
	
	/// <summary> <p>Represents an HL7 PID message segment. 
	/// This segment has the following fields:</p><p>
	/// PID-1: SET ID - PATIENT ID (SI)<br> 
	/// PID-2: PATIENT ID EXTERNAL (EXTERNAL ID) (CK)<br> 
	/// PID-3: PATIENT ID INTERNAL (INTERNAL ID) (CK)<br> 
	/// PID-4: ALTERNATE PATIENT ID (ST)<br> 
	/// PID-5: PATIENT NAME (PN)<br> 
	/// PID-6: MOTHER'S MAIDEN NAME (ST)<br> 
	/// PID-7: DATE OF BIRTH (DT)<br> 
	/// PID-8: SEX (ID)<br> 
	/// PID-9: PATIENT ALIAS (PN)<br> 
	/// PID-10: ETHNIC GROUP (ID)<br> 
	/// PID-11: PATIENT ADDRESS (AD)<br> 
	/// PID-12: COUNTY CODE (ID)<br> 
	/// PID-13: PHONE NUMBER - HOME (TN)<br> 
	/// PID-14: PHONE NUMBER - BUSINESS (TN)<br> 
	/// PID-15: LANGUAGE - PATIENT (ST)<br> 
	/// PID-16: MARITAL STATUS (ID)<br> 
	/// PID-17: RELIGION (ID)<br> 
	/// PID-18: PATIENT ACCOUNT NUMBER (CK)<br> 
	/// PID-19: SSN NUMBER - PATIENT (ST)<br> 
	/// PID-20: DRIVER'S LIC NUM - PATIENT (CM)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class PID:AbstractSegment
	{
		/// <summary> Returns SET ID - PATIENT ID (PID-1).</summary>
		virtual public SI SETIDPATIENTID
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
		/// <summary> Returns PATIENT ID EXTERNAL (EXTERNAL ID) (PID-2).</summary>
		virtual public CK PATIENTIDEXTERNALEXTERNALID
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (CK) t;
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
		/// <summary> Returns PATIENT ID INTERNAL (INTERNAL ID) (PID-3).</summary>
		virtual public CK PATIENTIDINTERNALINTERNALID
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (CK) t;
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
		/// <summary> Returns ALTERNATE PATIENT ID (PID-4).</summary>
		virtual public ST ALTERNATEPATIENTID
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
		/// <summary> Returns PATIENT NAME (PID-5).</summary>
		virtual public PN PATIENTNAME
		{
			get
			{
				PN ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		/// <summary> Returns MOTHER'S MAIDEN NAME (PID-6).</summary>
		virtual public ST MOTHERSMAIDENNAME
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		/// <summary> Returns DATE OF BIRTH (PID-7).</summary>
		virtual public DT DATEOFBIRTH
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		/// <summary> Returns SEX (PID-8).</summary>
		virtual public ID SEX
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(8, 0);
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
		/// <summary> Returns ETHNIC GROUP (PID-10).</summary>
		virtual public ID ETHNICGROUP
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
		/// <summary> Returns PATIENT ADDRESS (PID-11).</summary>
		virtual public AD PATIENTADDRESS
		{
			get
			{
				AD ret = null;
				try
				{
					Type t = this.getField(11, 0);
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
		/// <summary> Returns COUNTY CODE (PID-12).</summary>
		virtual public ID COUNTYCODE
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		/// <summary> Returns LANGUAGE - PATIENT (PID-15).</summary>
		virtual public ST LANGUAGEPATIENT
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(15, 0);
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
		/// <summary> Returns MARITAL STATUS (PID-16).</summary>
		virtual public ID MARITALSTATUS
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
		/// <summary> Returns RELIGION (PID-17).</summary>
		virtual public ID RELIGION
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		/// <summary> Returns PATIENT ACCOUNT NUMBER (PID-18).</summary>
		virtual public CK PATIENTACCOUNTNUMBER
		{
			get
			{
				CK ret = null;
				try
				{
					Type t = this.getField(18, 0);
					ret = (CK) t;
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
		/// <summary> Returns SSN NUMBER - PATIENT (PID-19).</summary>
		virtual public ST SSNNUMBERPATIENT
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(19, 0);
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
		/// <summary> Returns DRIVER'S LIC NUM - PATIENT (PID-20).</summary>
		virtual public CM DRIVERSLICNUMPATIENT
		{
			get
			{
				CM ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (CM) t;
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
		
		/// <summary> Creates a PID (PATIENT IDENTIFICATION) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public PID(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(CK), false, 1, 16, new System.Object[]{message});
				this.add(typeof(CK), true, 1, 16, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(PN), true, 1, 48, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(PN), false, 0, 48, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 5});
				this.add(typeof(AD), false, 1, 106, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 0});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(TN), false, 3, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 2});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 6});
				this.add(typeof(CK), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
				this.add(typeof(CM), false, 1, 25, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns a single repetition of PATIENT ALIAS (PID-9).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual PN getPATIENTALIAS(int rep)
		{
			PN ret = null;
			try
			{
				Type t = this.getField(9, rep);
				ret = (PN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of PATIENT ALIAS (PID-9).</summary>
		public virtual PN[] getPATIENTALIAS()
		{
			PN[] ret = null;
			try
			{
				Type[] t = this.getField(9);
				ret = new PN[t.Length];
				for (int i = 0; i < ret.Length; i++)
				{
					ret[i] = (PN) t[i];
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
		
		/// <summary> Returns a single repetition of PHONE NUMBER - HOME (PID-13).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getPHONENUMBERHOME(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of PHONE NUMBER - HOME (PID-13).</summary>
		public virtual TN[] getPHONENUMBERHOME()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(13);
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
		
		/// <summary> Returns a single repetition of PHONE NUMBER - BUSINESS (PID-14).</summary>
		/// <param name="rep">the repetition number (this is a repeating field)
		/// </param>
		/// <throws>  HL7Exception if the repetition number is invalid. </throws>
		public virtual TN getPHONENUMBERBUSINESS(int rep)
		{
			TN ret = null;
			try
			{
				Type t = this.getField(14, rep);
				ret = (TN) t;
			}
			catch (System.InvalidCastException )
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns all repetitions of PHONE NUMBER - BUSINESS (PID-14).</summary>
		public virtual TN[] getPHONENUMBERBUSINESS()
		{
			TN[] ret = null;
			try
			{
				Type[] t = this.getField(14);
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